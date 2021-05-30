using System.Numerics;
using System.Runtime.InteropServices;
using NWN.API.Constants;
using NWN.Native.API;
using NWN.Services;

namespace NWN.API.Events
{
  public sealed class OnSpellCast : IEvent
  {
    public bool PreventSpellCast { get; set; }

    public NwGameObject Caster { get; private init; }

    public Spell Spell { get; private init; }

    public Vector3 TargetPosition { get; private init; }

    public NwGameObject TargetObject { get; private init; }

    public int ClassIndex { get; private init; }

    public NwItem Item { get; private init; }

    public bool SpellCountered { get; private init; }

    public bool CounteringSpell { get; private init; }

    public ProjectilePathType ProjectilePathType { get; private init; }

    public bool IsInstantSpell { get; private init; }

    NwObject IEvent.Context
    {
      get => Caster;
    }

    internal sealed unsafe class Factory : SingleHookEventFactory<Factory.SpellCastAndImpactHook>
    {
      internal delegate void SpellCastAndImpactHook(void* pObject, int nSpellId, Vector3 targetPosition, uint oidTarget,
        byte nMultiClass, uint itemObj, int bSpellCountered, int bCounteringSpell, byte projectilePathType, int bInstantSpell);

      protected override FunctionHook<SpellCastAndImpactHook> RequestHook()
      {
        delegate* unmanaged<void*, int, Vector3, uint, byte, uint, int, int, byte, int, void> pHook = &OnSpellCastAndImpact;
        return HookService.RequestHook<SpellCastAndImpactHook>(pHook, FunctionsLinux._ZN10CNWSObject18SpellCastAndImpactEj6Vectorjhjiihi, HookOrder.Early);
      }

      [UnmanagedCallersOnly]
      private static void OnSpellCastAndImpact(void* pObject, int nSpellId, Vector3 targetPosition, uint oidTarget,
        byte nMultiClass, uint itemObj, int bSpellCountered, int bCounteringSpell, byte projectilePathType, int bInstantSpell)
      {
        CNWSObject gameObject = CNWSObject.FromPointer(pObject);

        OnSpellCast eventData = ProcessEvent(new OnSpellCast
        {
          Caster = gameObject.ToNwObject<NwCreature>(),
          Spell = (Spell)nSpellId,
          TargetPosition = targetPosition,
          TargetObject = oidTarget.ToNwObject<NwGameObject>(),
          ClassIndex = nMultiClass,
          Item = itemObj.ToNwObject<NwItem>(),
          SpellCountered = bSpellCountered.ToBool(),
          CounteringSpell = bCounteringSpell.ToBool(),
          ProjectilePathType = (ProjectilePathType)projectilePathType,
          IsInstantSpell = bInstantSpell.ToBool(),
        });

        if (!eventData.PreventSpellCast)
        {
          Hook.CallOriginal(pObject, nSpellId, targetPosition, oidTarget, nMultiClass, itemObj, bSpellCountered, bCounteringSpell, projectilePathType, bInstantSpell);
        }
        else
        {
          gameObject.m_bLastSpellCast = true.ToInt();
        }
      }
    }
  }
}
