using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;

namespace FreeQuant.FinChart
{
	public abstract class SeriesView : IChartDrawable, IAxesMarked, IZoomable
	{
		protected Pad pad;
		protected DateTime firstDate;
		protected DateTime lastDate;
		protected bool isMarkEnable;
		protected bool toolTipEnabled;
		protected string toolTipFormat;
		protected bool selected;
		protected bool displayNameEnabled;

		public virtual string DisplayName
		{
			get
			{
				return this.MainSeries.Name;
			}
		}

		public virtual bool DisplayNameEnabled
		{
			get
			{
				return this.displayNameEnabled;
			}
			set
			{
				this.displayNameEnabled = value;
			}
		}

		public bool IsMarkEnable
		{
			get
			{
				return this.isMarkEnable;
			}
			set
			{
				this.isMarkEnable = value;
			}
		}

		public virtual int LabelDigitsCount
		{
			get
			{
				return this.pad.Chart.LabelDigitsCount;
			}
		}

		public bool ToolTipEnabled
		{
			get
			{
				return this.toolTipEnabled;
			}
			set
			{
				this.toolTipEnabled = value;
			}
		}

		public string ToolTipFormat
		{
			get
			{
				return this.toolTipFormat;
			}
			set
			{
				this.toolTipFormat = value;
			}
		}

		public abstract Color Color { get; set; }

		[Browsable(false)]
		public abstract double LastValue { get; }

		[Browsable(false)]
		public abstract TimeSeries MainSeries { get; }

		public SeriesView(Pad pad)
		{
			this.isMarkEnable = true;
			this.toolTipEnabled = true;
			this.toolTipFormat = String.Empty;
			this.displayNameEnabled = true;
			this.pad = pad;
		}

		public void SetInterval(DateTime minDate, DateTime maxDate)
		{
			this.firstDate = minDate;
			this.lastDate = maxDate;
		}

		public abstract PadRange GetPadRangeY(Pad Pad);

		public abstract void Paint();

		public abstract Distance Distance(int x, double y);

		public void Select()
		{
			this.selected = true;
		}

		public void UnSelect()
		{
			this.selected = false;
		}
	}
}
