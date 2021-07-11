using NWN.Core;

namespace Anvil.API
{
  public sealed class LocalVariableLocation : LocalVariable<Location>
  {
    public override Location Value
    {
      get => NWScript.GetLocalLocation(Object, Name);
      set => NWScript.SetLocalLocation(Object, Name, value);
    }

    public override void Delete()
    {
      NWScript.DeleteLocalLocation(Object, Name);
    }
  }
}
