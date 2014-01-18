using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;

namespace FreeQuant.FinChart
{
  public class KagiBaView : SeriesView
  {
    private BarSeries Itiy9gS5Yd;
    private Kagi RCUyO2wSvi;

    public override Color Color
    {
       get
      {
        return Color.FromArgb(0, (int) byte.MaxValue, 0);
      }
       set
      {
      }
    }

    public override double LastValue
    {
       get
      {
        return this.Itiy9gS5Yd[this.lastDate, EIndexOption.Prev].Close;
      }
    }

    public override TimeSeries MainSeries
    {
       get
      {
        return (TimeSeries) this.RCUyO2wSvi;
      }
    }

    
    public KagiBaView(Pad pad, BarSeries series)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector(pad);
      this.Itiy9gS5Yd = series;
      this.pad = pad;
      this.toolTipFormat = FJDHryrxb1WIq5jBAt.mT707pbkgT(3020);
      this.RCUyO2wSvi = new Kagi(series, EKagiStyle.Percent, 1.0);
      this.RCUyO2wSvi.Calculate();
    }

    
    public override PadRange GetPadRangeY(Pad Pad)
    {
      return new PadRange(this.RCUyO2wSvi.LowestLow(this.firstDate, this.lastDate), this.RCUyO2wSvi.HighestHigh(this.firstDate, this.lastDate));
    }

    
    public void Calculate()
    {
      this.RCUyO2wSvi.Calculate();
    }

    
    public override void Paint()
    {
      Pen pen1 = new Pen(Color.Black);
      Pen pen2 = new Pen(Color.Pink);
      Pen pen3 = new Pen(Color.LightBlue);
      SolidBrush solidBrush1 = new SolidBrush(Color.White);
      SolidBrush solidBrush2 = new SolidBrush(Color.Black);
      int index1 = this.RCUyO2wSvi.GetIndex(this.firstDate);
      int index2 = this.RCUyO2wSvi.GetIndex(this.lastDate);
      if (index2 == -1 || index2 == -1)
        return;
      int num1 = Math.Max(2, (int) this.pad.IntervalWidth);
      for (int index3 = index1; index3 <= index2; ++index3)
      {
        int num2 = this.pad.ClientX(this.RCUyO2wSvi.GetDateTime(index3));
        Bar bar = this.RCUyO2wSvi[index3];
        double open = this.RCUyO2wSvi[index3].Open;
        double close = this.RCUyO2wSvi[index3].Close;
        Pen pen4 = this.RCUyO2wSvi[index3].Open >= this.RCUyO2wSvi[index3].Close ? pen3 : pen2;
        this.pad.Graphics.DrawLine(pen4, num2 - num1 / 2, this.pad.ClientY(open), num2 + num1 / 2, this.pad.ClientY(open));
        this.pad.Graphics.DrawLine(pen4, num2 + num1 / 2, this.pad.ClientY(open), num2 + num1 / 2, this.pad.ClientY(close));
      }
    }

    
    public override Distance Distance(int x, double y)
    {
      Distance distance = new Distance();
      Bar bar = this.RCUyO2wSvi[this.pad.GetDateTime(x)];
      distance.DX = 0.0;
      if (y >= bar.Low && y <= bar.High)
        distance.DY = 0.0;
      if (distance.DX == double.MaxValue || distance.DY == double.MaxValue)
        return (Distance) null;
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.AppendFormat(this.toolTipFormat, (object) this.Itiy9gS5Yd.Name, (object) this.Itiy9gS5Yd.Title, (object) bar.DateTime.ToString(this.Itiy9gS5Yd.ToolTipDateTimeFormat), (object) bar.High, (object) bar.Low, (object) bar.Open, (object) bar.Close, (object) bar.Volume);
      distance.ToolTipText = ((object) stringBuilder).ToString();
      return distance;
    }
  }
}
