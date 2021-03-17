using System;
using System.Collections.Generic;
using NWN.API.Constants;
using NWN.API.Events;
using NWN.Core;
using NWN.Native.API;

namespace NWN.API
{
  [NativeObjectInfo(ObjectTypes.Trigger, ObjectType.Trigger)]
  public sealed class NwTrigger : NwTrappable
  {
    internal readonly CNWSTrigger Trigger;

    internal NwTrigger(uint objectId, CNWSTrigger trigger) : base(objectId, trigger)
    {
      this.Trigger = trigger;
    }

    public static implicit operator CNWSTrigger(NwTrigger trigger)
    {
      return trigger?.Trigger;
    }

    public event Action<TriggerEvents.OnHeartbeat> OnHeartbeat
    {
      add => EventService.Subscribe<TriggerEvents.OnHeartbeat, GameEventFactory>(this, value)
        .Register<TriggerEvents.OnHeartbeat>(this);
      remove => EventService.Unsubscribe<TriggerEvents.OnHeartbeat, GameEventFactory>(this, value);
    }

    public event Action<TriggerEvents.OnEnter> OnEnter
    {
      add => EventService.Subscribe<TriggerEvents.OnEnter, GameEventFactory>(this, value)
        .Register<TriggerEvents.OnEnter>(this);
      remove => EventService.Unsubscribe<TriggerEvents.OnEnter, GameEventFactory>(this, value);
    }

    public event Action<TriggerEvents.OnExit> OnExit
    {
      add => EventService.Subscribe<TriggerEvents.OnExit, GameEventFactory>(this, value)
        .Register<TriggerEvents.OnExit>(this);
      remove => EventService.Unsubscribe<TriggerEvents.OnExit, GameEventFactory>(this, value);
    }

    public event Action<TriggerEvents.OnUserDefined> OnUserDefined
    {
      add => EventService.Subscribe<TriggerEvents.OnUserDefined, GameEventFactory>(this, value)
        .Register<TriggerEvents.OnUserDefined>(this);
      remove => EventService.Unsubscribe<TriggerEvents.OnUserDefined, GameEventFactory>(this, value);
    }

    public event Action<TriggerEvents.OnTrapTriggered> OnTrapTriggered
    {
      add => EventService.Subscribe<TriggerEvents.OnTrapTriggered, GameEventFactory>(this, value)
        .Register<TriggerEvents.OnTrapTriggered>(this);
      remove => EventService.Unsubscribe<TriggerEvents.OnTrapTriggered, GameEventFactory>(this, value);
    }

    public event Action<TriggerEvents.OnDisarmed> OnDisarmed
    {
      add => EventService.Subscribe<TriggerEvents.OnDisarmed, GameEventFactory>(this, value)
        .Register<TriggerEvents.OnDisarmed>(this);
      remove => EventService.Unsubscribe<TriggerEvents.OnDisarmed, GameEventFactory>(this, value);
    }

    public event Action<TriggerEvents.OnClicked> OnClicked
    {
      add => EventService.Subscribe<TriggerEvents.OnClicked, GameEventFactory>(this, value)
        .Register<TriggerEvents.OnClicked>(this);
      remove => EventService.Unsubscribe<TriggerEvents.OnClicked, GameEventFactory>(this, value);
    }

    public override Location Location
    {
      set
      {
        Trigger.AddToArea(value.Area, value.Position.X, value.Position.Y, value.Position.Z, true.ToInt());

        // If the trigger is trapped it needs to be added to the area's trap list for it to be detectable by players.
        if (IsTrapped)
        {
          value.Area.Area.m_pTrapList.Add(this);
        }

        Rotation = value.Rotation;
      }
    }

    /// <summary>
    /// Gets all objects of the given type that are currently in this trigger.
    /// </summary>
    /// <typeparam name="T">The type of objects to return.</typeparam>
    /// <returns>An enumerable containing all objects currently in the trigger.</returns>
    public IEnumerator<T> GetObjectsInTrigger<T>() where T : NwGameObject
    {
      int objType = (int) GetObjectType<T>();
      for (uint obj = NWScript.GetFirstInPersistentObject(this, objType); obj != INVALID; obj = NWScript.GetNextInPersistentObject(this, objType))
      {
        yield return obj.ToNwObject<T>();
      }
    }

    /// <summary>
    /// Gets all objects of the given types that are currently in this trigger.
    /// </summary>
    /// <param name="objectTypes">The types of object to return.</param>
    /// <returns>An enumerable containing all objects currently in the trigger.</returns>
    public IEnumerator<NwGameObject> GetObjectsInTrigger(ObjectTypes objectTypes)
    {
      int objType = (int) objectTypes;
      for (uint obj = NWScript.GetFirstInPersistentObject(this, objType); obj != INVALID; obj = NWScript.GetNextInPersistentObject(this, objType))
      {
        yield return obj.ToNwObject<NwGameObject>();
      }
    }
  }
}
