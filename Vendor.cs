using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace YoEaseReport
{
	public class Vendor
	{
		public string VendorNumber { get; set; }
		public int LastMonthENumber { get; set; }
		public int CurrentMonthENumber { get; set; }
		public int EUsedValue { get; set; }
		public int EFee { get; set; }
		public int WaterNumber { get; set; }
		public int BasicEFee { get; set; }
		public int LightFee { get; set; }
		public int ACFee { get; set; }
		public int BusinessFee { get; set; }
		public int PublicWaterFee { get; set; }
		public int WaterFee { get; set; }
		public int TotalAmount { get; set; }

		public Vendor(
			string VendorNumber, int LastMonthENumber, int CurrentMonthENumber, int EUsedValue,
			int EFee, int WaterNumber, int BasicEFee, int LightFee, int ACFee, int BusinessFee, int PublicWaterFee,
			int WaterFee, int TotalAmount)
		{
			this.VendorNumber = VendorNumber;
			this.LastMonthENumber = LastMonthENumber;
			this.CurrentMonthENumber = CurrentMonthENumber;
			this.EUsedValue = EUsedValue;
			this.EFee = EFee;
			this.WaterNumber = WaterNumber;
			this.BasicEFee = BasicEFee;
			this.LightFee = LightFee;
			this.ACFee = ACFee;
			this.BusinessFee = BusinessFee;
			this.PublicWaterFee = PublicWaterFee;
			this.WaterFee = WaterFee;
			this.TotalAmount = TotalAmount;
		}
	}
}
