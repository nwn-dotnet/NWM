using System.Numerics;
using System.Threading.Tasks;
using NWN.Core;
using NWN.Core.NWNX;

namespace NWN.API
{
  public abstract class NwStationary : NwTrappable
  {
    internal NwStationary(uint objectId) : base(objectId) {}

    /// <summary>
    /// Gets or sets a value indicating whether this stationary object is locked.
    /// </summary>
    public bool Locked
    {
      get => NWScript.GetLocked(this).ToBool();
      set => NWScript.SetLocked(this, value.ToInt());
    }

    /// <summary>
    /// Gets or sets a value indicating whether this stationary object is lockable.
    /// </summary>
    public bool Lockable
    {
      get => NWScript.GetLockLockable(this).ToBool();
      set => NWScript.SetLockLockable(this, value.ToInt());
    }

    /// <summary>
    /// Gets or sets a value indicating whether a specific key with the tag <see cref="LockKeyTag"/> is required to open this stationary object.
    /// </summary>
    public bool LockKeyRequired
    {
      get => NWScript.GetLockKeyRequired(this).ToBool();
      set => NWScript.SetLockKeyRequired(this, value.ToInt());
    }

    /// <summary>
    /// Gets or sets the tag of the key that will open this placeable.
    /// </summary>
    public string LockKeyTag
    {
      get => NWScript.GetLockKeyTag(this);
      set => NWScript.SetLockKeyTag(this, value);
    }

    /// <summary>
    /// Gets or sets a value indicating whether the key for this lock should "break"/be removed from the creature's inventory when used on this lock.
    /// </summary>
    public bool KeyAutoRemoved
    {
      get => ObjectPlugin.GetAutoRemoveKey(this).ToBool();
      set => ObjectPlugin.SetAutoRemoveKey(this, value.ToInt());
    }

    /// <summary>
    /// Gets or sets the skill DC required to lock this object.
    /// </summary>
    public int LockDC
    {
      get => NWScript.GetLockLockDC(this);
      set => NWScript.SetLockLockDC(this, value);
    }

    /// <summary>
    /// Gets or sets the skill DC required to unlock this object.
    /// </summary>
    public int UnlockDC
    {
      get => NWScript.GetLockUnlockDC(this);
      set => NWScript.SetLockUnlockDC(this, value);
    }

    /// <summary>
    /// Gets or sets the hardness of this stationary object. This is the amount of damage deducted from each hit.
    /// </summary>
    public int Hardness
    {
      get => NWScript.GetHardness(this);
      set => NWScript.SetHardness(value, this);
    }

    public bool IsOpen => NWScript.GetIsOpen(this).ToBool();

    public override async Task FaceToPoint(Vector3 point)
    {
      Vector3 direction = Vector3.Normalize(point - Position);
      await base.FaceToPoint(Position - direction);
    }

    public override float Rotation
    {
      get => (360 - NWScript.GetFacing(this)) % 360;
      set => base.Rotation = 360 - value;
    }

    public override Location Location => Location.Create(Area, Position, Rotation);

    /// <summary>
    /// Gets or sets the feedback message that will be displayed when trying to unlock this (object).
    /// </summary>
    public string KeyRequiredFeedback
    {
      get => NWScript.GetKeyRequiredFeedback(this);
      set => NWScript.SetKeyRequiredFeedback(this, value);
    }

    /// <summary>
    /// Get the last object that locked the caller.
    /// </summary>
    public NwStationary LastLocked => (NwStationary)NWScript.GetLastLocked().ToNwObject<NwGameObject>();
  }
}
