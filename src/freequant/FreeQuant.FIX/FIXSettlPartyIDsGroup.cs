using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXSettlPartyIDsGroup : FIXGroup
  {
    private ArrayList rTwtW5j0d5;

    [FIXField("782", EFieldOption.Optional)]
    public string SettlPartyID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetStringField(782).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddStringField(782, value);
      }
    }

    [FIXField("783", EFieldOption.Optional)]
    public char SettlPartyIDSource
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetCharField(783).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddCharField(783, value);
      }
    }

    [FIXField("784", EFieldOption.Optional)]
    public int SettlPartyRole
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(784).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(784, value);
      }
    }

    [FIXField("801", EFieldOption.Optional)]
    public int NoSettlPartySubIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(801).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(801, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXSettlPartyIDsGroup():base()
    {

      this.rTwtW5j0d5 = new ArrayList();
  
    }


    public FIXSettlPartySubIDsGroup GetSettlPartySubIDsGroup(int i)
    {
      if (i < this.NoSettlPartySubIDs)
        return (FIXSettlPartySubIDsGroup) this.rTwtW5j0d5[i];
      else
        return (FIXSettlPartySubIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXSettlPartySubIDsGroup group)
    {
      this.rTwtW5j0d5.Add((object) group);
      ++this.NoSettlPartySubIDs;
    }
  }
}
