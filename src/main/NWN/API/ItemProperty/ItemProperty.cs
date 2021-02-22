using System;
using NWN.API.Constants;
using NWN.Core;
using NWN.Native.API;

namespace NWN.API
{
  public sealed partial class ItemProperty : EffectBase
  {
    private ItemProperty(IntPtr handle, CGameEffect effect) : base(handle, effect) {}

    public static implicit operator IntPtr(ItemProperty effect) => effect.Handle;

    public static implicit operator ItemProperty(IntPtr intPtr) => new ItemProperty(intPtr, new CGameEffect(intPtr, false));

    private protected override void ReleaseUnmanagedResources()
    {
      VM.FreeGameDefinedStructure(NWScript.ENGINE_STRUCTURE_ITEMPROPERTY, this);
    }

    /// <summary>
    /// Gets or sets the tag for this item property.
    /// </summary>
    public string Tag
    {
      get => Effect.GetString(0).ToString();
      set => Effect.SetString(0, value.ToExoString());
    }

    /// <summary>
    /// Gets or sets the type of this item property (as defined in itempropdef.2da).
    /// </summary>
    public ItemPropertyType PropertyType
    {
      get => (ItemPropertyType)Effect.GetInteger(0);
      set => Effect.SetInteger(0, (int)value);
    }

    /// <summary>
    /// Gets or sets the SubType index for this item property.<br/>
    /// The mapping of this value can be found by first finding the 2da name in itempropdef.2da under the "SubTypeResRef" column, then locating the index of the subtype in the specified 2da.
    /// </summary>
    public int SubType
    {
      get => Effect.GetInteger(1);
      set => Effect.SetInteger(1, value);
    }

    /// <summary>
    /// Gets or sets the cost table to use for this item property.<br/>
    /// See "iprp_costtable.2da" for a list of available tables.
    /// </summary>
    public int CostTable
    {
      get => Effect.GetInteger(2);
      set => Effect.SetInteger(2, value);
    }

    /// <summary>
    /// Gets or sets the cost table entry to use for this item property.<br/>
    /// This is the row index inside the set <see cref="CostTable"/>.
    /// </summary>
    public int CostTableValue
    {
      get => Effect.GetInteger(3);
      set => Effect.SetInteger(3, value);
    }

    /// <summary>
    /// Gets or sets the "param1" table to use for this item property.<br/>
    /// See "iprp_paramtable.2da" for a list of available tables.
    /// </summary>
    public int Param1Table
    {
      get => Effect.GetInteger(4);
      set => Effect.SetInteger(4, value);
    }

    /// <summary>
    /// Gets or sets the "param1" table entry to use for this item property.<br/>
    /// This is the row index inside the set <see cref="Param1Table"/>.
    /// </summary>
    public int Param1TableValue
    {
      get => Effect.GetInteger(5);
      set => Effect.SetInteger(5, value);
    }

    public int UsesPerDay
    {
      get => Effect.GetInteger(6);
      set => Effect.SetInteger(6, value);
    }

    public bool Usable
    {
      get => Effect.GetInteger(8).ToBool();
      set => Effect.SetInteger(8, value.ToInt());
    }

    /// <summary>
    /// Gets or sets whether this item property is a permanent or temporary effect.
    /// </summary>
    public EffectDuration DurationType
    {
      get => (EffectDuration)Effect.m_nSubType;
      set => Effect.m_nSubType = (ushort)value;
    }

    /// <summary>
    /// Gets the remaining duration until the item property expires (if this item property is temporary). Otherwise, returns <see cref="TimeSpan.Zero"/>.
    /// </summary>
    public TimeSpan RemainingDuration
    {
      get => TimeSpan.FromSeconds(NWScript.GetItemPropertyDurationRemaining(this));
    }

    /// <summary>
    /// Gets the total duration of the item property effect (if this item property is temporary). Otherwise, returns <see cref="TimeSpan.Zero"/>.
    /// </summary>
    public TimeSpan TotalDuration
    {
      get => TimeSpan.FromSeconds(NWScript.GetItemPropertyDuration(this));
    }

    /// <summary>
    /// Gets a value indicating whether this item property is valid.
    /// </summary>
    public bool Valid
    {
      get => NWScript.GetIsItemPropertyValid(this).ToBool();
    }
  }
}
