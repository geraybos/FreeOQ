using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXAffectedOrdersGroup : FIXGroup
  {
    [FIXField("41", EFieldOption.Optional)]
    public string OrigClOrdID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(41).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(41, value);
      }
    }

    [FIXField("535", EFieldOption.Optional)]
    public string AffectedOrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(535).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(535, value);
      }
    }

    [FIXField("536", EFieldOption.Optional)]
    public string AffectedSecondaryOrderID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(536).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(536, value);
      }
    }

  }
}
