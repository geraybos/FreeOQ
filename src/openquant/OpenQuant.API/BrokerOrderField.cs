﻿namespace OpenQuant.API
{
	public class BrokerOrderField
	{
		private FreeQuant.Providers.BrokerOrderField field;

		public string Name
		{
			get
			{
				return this.field.Name;
			}
		}

		public string Value
		{
			get
			{
				return this.field.Value;
			}
		}

		internal BrokerOrderField(FreeQuant.Providers.BrokerOrderField field)
		{
			this.field = field;
		}

		public override string ToString()
		{
			return string.Format("Name={0} Value={1}", (object)this.Name, (object)this.Value);
		}
	}
}
