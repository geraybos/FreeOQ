using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXCxlRejResponseTo : FIXCharField
  {
    public const char CancelRequest = '1';
    public const char CancelReplaceRequest = '2';

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCxlRejResponseTo(char value):base(434, value)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static CxlRejResponseTo FromFIX(char value)
    {
      switch (value)
      {
        case '1':
          return CxlRejResponseTo.CancelRequest;
        case '2':
          return CxlRejResponseTo.CancelReplaceRequest;
        default:
					throw new ArgumentException(string.Format("Error: ", (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static char ToFIX(CxlRejResponseTo response)
    {
      switch (response)
      {
        case CxlRejResponseTo.CancelRequest:
          return '1';
        case CxlRejResponseTo.CancelReplaceRequest:
          return '2';
        default:
					throw new ArgumentException(string.Format("Error: ", (object) response));
      }
    }
  }
}
