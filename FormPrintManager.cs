using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;

namespace YoEaseReport
{
	public partial class FormPrintManager : Form
	{
		public FormPrintManager()
		{
			InitializeComponent();
			label_line.Paint += Label_Paint;
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
			btn_multiPrint.Click += async (sender, e) => await StartTaskAsync();
			btn_printOnce.Click += async (sender, e) => await StartTaskAsync();
		}

		Image backgroundStamp = Image.FromFile(Application.StartupPath + "/small_stamp.png");
		YoIniFile iniFile = new YoIniFile(Application.StartupPath + "/report.ini");
		int serialNumber = -1;
		Bitmap memoryImage;
		public YoDateTime creationDate;
		public YoDateTime startDate;
		public YoDateTime endDate;
		public YoDateTime invoiceDate;
		public List<Vendor> selectedVendorList;

		private void Label_Paint(object sender, PaintEventArgs e)
		{
			// Draw a dotted line border around the label
			ControlPaint.DrawBorder(e.Graphics, label_line.ClientRectangle,
				Color.LightGray, 1, ButtonBorderStyle.Dotted,
				Color.LightGray, 1, ButtonBorderStyle.Dotted,
				Color.LightGray, 1, ButtonBorderStyle.Dotted,
				Color.LightGray, 1, ButtonBorderStyle.Dotted);
		}

		public void PrintInvoice(Panel panel)
		{
			PrinterSettings printerSettings = new PrinterSettings();
			panel1 = panel;
			getPrintArea(panel);
			printPreviewDialog1.Document = printDocument1;
			printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
			//printDocument1.Print();
			printPreviewDialog1.ShowDialog();
		}

		private void getPrintArea(Panel panel)
		{
			memoryImage = new Bitmap(panel.Width, panel.Height);
			panel.DrawToBitmap(memoryImage, new Rectangle(0, 0, panel.Width, panel.Height));
		}

		private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
		{
			// Calculate the width and height of the printed image
			int imageWidth = (int)(memoryImage.Width * memoryImage.HorizontalResolution / 96);
			int imageHeight = (int)(memoryImage.Height * memoryImage.VerticalResolution / 96);
			Console.WriteLine("imageWidth: " + imageWidth);
			Console.WriteLine("imageHeight: " + imageHeight);
			Rectangle rectangle = e.PageBounds;

			e.Graphics.PageUnit = GraphicsUnit.Pixel;
			e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
			e.Graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;

			e.Graphics.DrawImage(memoryImage, (rectangle.Width / 2) - (panel1.Width / 2) + 105, panel1.Location.Y + 450);
		}

		private void toolTip1_Popup(object sender, PopupEventArgs e)
		{

		}

		private string calculateSerialNumber(int serialNumber)
		{
			string result = "";
			for(int i = 6; i > serialNumber.ToString().Length; i--)
			{
				result += "0";
			}
			result += serialNumber.ToString();
			return result;
		}

		private void FormPrintManager_Load(object sender, EventArgs e)
		{
			tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
			serialNumber = int.Parse(iniFile.Read("EaseReport", "serialNumber"));

			if (serialNumber == -1)
			{
				MessageBox.Show("設定檔錯誤");
			}

			if (selectedVendorList != null && selectedVendorList.Count == 1)
			{
				SetControls(selectedVendorList[0]);
				label_selectedNum.Text = selectedVendorList.Count().ToString();
				label_printCount.Text = "0 / " + selectedVendorList.Count();
				btn_multiPrint.Enabled = false;
			}
			else if (selectedVendorList != null && selectedVendorList.Count > 1)
			{
				SetControls(selectedVendorList[0]);
				label_selectedNum.Text = selectedVendorList.Count().ToString();
				label_printCount.Text = "0 / " + selectedVendorList.Count();
				btn_printOnce.Enabled = false;
			}
			else
			{
				btn_multiPrint.Enabled = false;
				btn_printOnce.Enabled = false;
			}

			
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tableLayoutPanel2_CellPaint(object sender, TableLayoutCellPaintEventArgs e)
		{
			
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{
			// Set the position where you want to draw the background image
			int x = 250; // X coordinate
			int y = 90; // Y coordinate

			// Draw the background image at the specified position
			e.Graphics.DrawImage(backgroundStamp, x, y);
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{
			// Set the position where you want to draw the background image
			int x = 250; // X coordinate
			int y = 90; // Y coordinate

			// Draw the background image at the specified position
			e.Graphics.DrawImage(backgroundStamp, x, y);
		}

		private void SetControls(Vendor vendor)
		{
			if (vendor != null)
			{
				label_seriwlNumber_copy.Text = calculateSerialNumber(serialNumber);
				label_seriwlNumber.Text = calculateSerialNumber(serialNumber);

				//上聯(左)
				label_vendorNumber.Text = vendor.VendorNumber;
				label_lastMonthENumber.Text = vendor.LastMonthENumber.ToString();
				label_currentMonthENumber.Text = vendor.CurrentMonthENumber.ToString();
				label_eNumber.Text = vendor.EUsedValue.ToString();
				label_eFee.Text = vendor.EFee.ToString();
				label_publicWaterFee.Text = vendor.PublicWaterFee.ToString();
				//上聯(右)
				label_basicEFee.Text = vendor.BasicEFee.ToString();
				label_lightFee.Text = vendor.LightFee.ToString();
				label_acFee.Text = vendor.ACFee.ToString();
				label_businessFee.Text = vendor.BusinessFee.ToString();
				label_waterFee.Text = vendor.WaterFee.ToString();
				label_totalAmount.Text = vendor.TotalAmount.ToString();

				//下聯(左)
				label_vendorNumber_copy.Text = vendor.VendorNumber;
				label_lastMonthENumber_copy.Text = vendor.LastMonthENumber.ToString();
				label_currentMonthENumber_copy.Text = vendor.CurrentMonthENumber.ToString();
				label_eNumber_copy.Text = vendor.EUsedValue.ToString();
				label_eFee_copy.Text = vendor.EFee.ToString();
				label_publicWaterFee_copy.Text = vendor.PublicWaterFee.ToString();
				//下聯(右)
				label_basicEFee_copy.Text = vendor.BasicEFee.ToString();
				label_lightFee_copy.Text = vendor.LightFee.ToString();
				label_acFee_copy.Text = vendor.ACFee.ToString();
				label_businessFee_copy.Text = vendor.BusinessFee.ToString();
				label_waterFee_copy.Text = vendor.WaterFee.ToString();
				label_totalAmount_copy.Text = vendor.TotalAmount.ToString();
			}
			if (creationDate.Year == DateTime.Now.Year.ToString())
			{
				creationDate.Year = (int.Parse(creationDate.Year) - 1911).ToString();
			}
			if (startDate.Year == DateTime.Now.Year.ToString())
			{
				startDate.Year = (int.Parse(startDate.Year) - 1911).ToString();
			}
			if (endDate.Year == DateTime.Now.Year.ToString())
			{
				endDate.Year = (int.Parse(endDate.Year) - 1911).ToString();
			}
			if (invoiceDate.Year == DateTime.Now.Year.ToString())
			{
				invoiceDate.Year = (int.Parse(invoiceDate.Year) - 1911).ToString();
			}

			label_creationYear.Text = creationDate.Year;
			label_creationMonth.Text = creationDate.Month;
			label_creationDay.Text = creationDate.Day;
			label_creationYear_copy.Text = creationDate.Year;
			label_creationMonth_copy.Text = creationDate.Month;
			label_creationDay_copy.Text = creationDate.Day;

			label_startYear.Text = startDate.Year;
			label_startMonth.Text = startDate.Month;
			label_startDay.Text = startDate.Day;
			label_startYear_copy.Text = startDate.Year;
			label_startMonth_copy.Text = startDate.Month;
			label_startDay_copy.Text = startDate.Day;

			label_endYear.Text = endDate.Year;
			label_endMonth.Text = endDate.Month;
			label_endDay.Text = endDate.Day;
			label_endYear_copy.Text = endDate.Year;
			label_endMonth_copy.Text = endDate.Month;
			label_endDay_copy.Text = endDate.Day;

			label_invoiceYear.Text = invoiceDate.Year;
			label_invoiceMonth.Text = invoiceDate.Month;

			label_invoiceYear_copy.Text = invoiceDate.Year;
			label_invoiceMonth_copy.Text = invoiceDate.Month;
		}

		private async Task StartTaskAsync()
		{
			int multiPrintCount = 1;
			if (selectedVendorList != null)
			{
				foreach (Vendor currentVendor in selectedVendorList)
				{
					label_printCount.Text = multiPrintCount.ToString() + " / " + selectedVendorList.Count();
					SetControls(currentVendor);
					Console.WriteLine("當前收據流水號: " + serialNumber);
					serialNumber += 1;
					iniFile.Write("EaseReport", "serialNumber", serialNumber.ToString());
					PrintInvoice(panel1);
					multiPrintCount++;

					await Task.Delay(2000);
				}
				MessageBox.Show("所有列印已傳送完成");
			}
		}
	}
}
