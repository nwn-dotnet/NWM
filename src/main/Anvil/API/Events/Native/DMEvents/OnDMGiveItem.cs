using System;
using Anvil.API.Events;

namespace Anvil.API.Events
{
  public abstract class OnDMGiveItem : IEvent
  {
    public NwGameObject Target { get; internal init; }

    public NwPlayer DungeonMaster { get; internal init; }

    NwObject IEvent.Context
    {
      get => DungeonMaster?.LoginCreature;
    }
  }

  public sealed class OnDMGiveItemBefore : OnDMGiveItem
  {
    public bool Skip { get; set; }
  }

  public sealed class OnDMGiveItemAfter : OnDMGiveItem
  {
    public NwItem Item { get; internal init; }
  }
}

namespace Anvil.API
{
  public sealed partial class NwPlayer
  {
    /// <inheritdoc cref="Events.OnDMGiveItemBefore"/>
    public event Action<OnDMGiveItemBefore> OnDMGiveItemBefore
    {
      add => EventService.Subscribe<OnDMGiveItemBefore, DMEventFactory>(LoginCreature, value);
      remove => EventService.Unsubscribe<OnDMGiveItemBefore, DMEventFactory>(LoginCreature, value);
    }

    /// <inheritdoc cref="Events.OnDMGiveItemAfter"/>
    public event Action<OnDMGiveItemAfter> OnDMGiveItemAfter
    {
      add => EventService.Subscribe<OnDMGiveItemAfter, DMEventFactory>(LoginCreature, value);
      remove => EventService.Unsubscribe<OnDMGiveItemAfter, DMEventFactory>(LoginCreature, value);
    }
  }

  public sealed partial class NwModule
  {
    /// <inheritdoc cref="Events.OnDMGiveItemBefore"/>
    public event Action<OnDMGiveItemBefore> OnDMGiveItemBefore
    {
      add => EventService.SubscribeAll<OnDMGiveItemBefore, DMEventFactory>(value);
      remove => EventService.UnsubscribeAll<OnDMGiveItemBefore, DMEventFactory>(value);
    }

    /// <inheritdoc cref="Events.OnDMGiveItemAfter"/>
    public event Action<OnDMGiveItemAfter> OnDMGiveItemAfter
    {
      add => EventService.SubscribeAll<OnDMGiveItemAfter, DMEventFactory>(value);
      remove => EventService.UnsubscribeAll<OnDMGiveItemAfter, DMEventFactory>(value);
    }
  }
}
