using System;
using NWN.Native.API;
using NWN.Services;

namespace NWN.API.Events
{
  public class OnStoreRequestSell : IEvent
  {
    public bool PreventBuy { get; set; }

    public NwCreature Creature { get; private init; }

    public NwItem Item { get; private init; }

    public NwStore Store { get; private init; }

    public int Price { get; private init; }

    NwObject IEvent.Context => Creature;

    [NativeFunction(NWNXLib.Functions._ZN12CNWSCreature11RequestSellEjj)]
    internal delegate int RequestSellHook(IntPtr pCreature, uint oidItemToBuy, uint oidStore);

    internal class Factory : NativeEventFactory<RequestSellHook>
    {
      public Factory(Lazy<EventService> eventService, HookService hookService) : base(eventService, hookService) {}

      protected override FunctionHook<RequestSellHook> RequestHook(HookService hookService)
        => hookService.RequestHook<RequestSellHook>(OnRequestSell, HookOrder.Early);

      private int OnRequestSell(IntPtr pCreature, uint oidItemToSell, uint oidStore)
      {
        CNWSCreature creature = new CNWSCreature(pCreature, false);
        NwItem item = oidItemToSell.ToNwObject<NwItem>();
        NwStore store = oidStore.ToNwObject<NwStore>();

        int price = 0;

        if (store != null && item != null)
        {
          price = store.Store.CalculateItemBuyPrice(item, creature.m_idSelf);
        }

        OnStoreRequestSell eventData = ProcessEvent(new OnStoreRequestSell
        {
          Creature = creature.m_idSelf.ToNwObject<NwCreature>(),
          Item = item,
          Store = store,
          Price = price
        });

        return !eventData.PreventBuy ? Hook.CallOriginal(pCreature, oidItemToSell, oidStore) : false.ToInt();
      }
    }
  }
}