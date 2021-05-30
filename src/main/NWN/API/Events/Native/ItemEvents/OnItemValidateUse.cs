using System.Runtime.InteropServices;
using NWN.Native.API;
using NWN.Services;

namespace NWN.API.Events
{
  public sealed class OnItemValidateUse : IEvent
  {
    public NwCreature UsedBy { get; private init; }

    public NwItem Item { get; private init; }

    public bool CanUse { get; set; }

    NwObject IEvent.Context
    {
      get => UsedBy;
    }

    internal sealed unsafe class Factory : SingleHookEventFactory<Factory.CanUseItemHook>
    {
      internal delegate int CanUseItemHook(void* pCreature, void* pItem, int bIgnoreIdentifiedFlag);

      protected override FunctionHook<CanUseItemHook> RequestHook()
      {
        delegate* unmanaged<void*, void*, int, int> pHook = &OnCanUseItem;
        return HookService.RequestHook<CanUseItemHook>(pHook, FunctionsLinux._ZN12CNWSCreature10CanUseItemEP8CNWSItemi, HookOrder.Early);
      }

      [UnmanagedCallersOnly]
      private static int OnCanUseItem(void* pCreature, void* pItem, int bIgnoreIdentifiedFlag)
      {
        OnItemValidateUse eventData = ProcessEvent(new OnItemValidateUse
        {
          UsedBy = CNWSCreature.FromPointer(pCreature).ToNwObject<NwCreature>(),
          Item = CNWSItem.FromPointer(pItem).ToNwObject<NwItem>(),
          CanUse = Hook.CallOriginal(pCreature, pItem, bIgnoreIdentifiedFlag).ToBool(),
        });

        return eventData.CanUse.ToInt();
      }
    }
  }
}
