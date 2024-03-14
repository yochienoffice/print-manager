using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace YoEaseReport
{
	public partial class FormYoEaseReport : Form
	{
		public FormYoEaseReport()
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.Fixed3D;
		}

		OpenFileDialog openFD = new OpenFileDialog();
		List<Vendor> VendorList = new List<Vendor>();
		YoDateTime creationDate = new YoDateTime();
		YoDateTime startDate = new YoDateTime();
		YoDateTime endDate = new YoDateTime();
		YoDateTime invoiceDate = new YoDateTime();

		private void FormYoEaseReport_Load(object sender, EventArgs e)
		{

		}

		private void btn_import_Click(object sender, EventArgs e)
		{
			Microsoft.Office.Interop.Excel.Application xlApp;
			Workbook xlWorkbook;
			Worksheet xlWorksheet;
			Range xlRange;

			int xlRow;
			string strFileName;

			
			openFD.Filter = "Excel Office | *.xls; *xlsx";
			openFD.ShowDialog();
			

			if(!string.IsNullOrEmpty(openFD?.FileName))
			{
				strFileName = openFD?.FileName;
				xlApp = new Microsoft.Office.Interop.Excel.Application();
				xlWorkbook = xlApp.Workbooks.Open(strFileName);
				xlWorksheet = xlWorkbook.Worksheets["工作表1"] as Worksheet;
				xlRange = xlWorksheet.UsedRange;

				int i = 1;

				for(xlRow = 3; xlRow <= xlRange.Rows.Count - 1; xlRow++)
				{
					
					VendorList.Add(new Vendor(
						(xlRange.Cells[xlRow, 1] as Range)?.Value?.ToString(),
						int.Parse((xlRange.Cells[xlRow, 2] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 3] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 4] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 5] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 6] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 7] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 8] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 9] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 10] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 11] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 12] as Range)?.Value.ToString()),
						int.Parse((xlRange.Cells[xlRow, 13] as Range)?.Value.ToString())
					));

					dataGridViewMain.Rows.Add(
						i,
						VendorList[VendorList.Count - 1].VendorNumber,
						VendorList[VendorList.Count - 1].LastMonthENumber,
						VendorList[VendorList.Count - 1].CurrentMonthENumber,
						VendorList[VendorList.Count - 1].EUsedValue,
						VendorList[VendorList.Count - 1].EFee,
						VendorList[VendorList.Count - 1].WaterNumber,
						VendorList[VendorList.Count - 1].BasicEFee,
						VendorList[VendorList.Count - 1].LightFee,
						VendorList[VendorList.Count - 1].ACFee,
						VendorList[VendorList.Count - 1].BusinessFee,
						VendorList[VendorList.Count - 1].PublicWaterFee,
						VendorList[VendorList.Count - 1].WaterFee,
						VendorList[VendorList.Count - 1].TotalAmount
					);
					i++;
				}
				xlWorkbook.Close();
				xlApp.Quit();
			}
		}

		private void btn_print_Click(object sender, EventArgs e)
		{
			if (dataGridViewMain.SelectedRows.Count == 0)
			{
				MessageBox.Show("請選取攤商或匯入資料");
			}
			else
			{
				FormPrintManager formPrintManager = new FormPrintManager();
				formPrintManager.selectedVendorList = new List<Vendor>();
				for (int i = 0; i < dataGridViewMain.SelectedRows.Count; i++)
				{
					formPrintManager.selectedVendorList.Add(VendorList[dataGridViewMain.SelectedRows[i].Index]);
				}
				formPrintManager.creationDate = this.creationDate;
				formPrintManager.startDate = this.startDate;
				formPrintManager.endDate = this.endDate;
				formPrintManager.invoiceDate = this.invoiceDate;
				formPrintManager.Show();
				//MessageBox.Show("單次列印一次只能選一個攤商");
			}
			
		}

		private void dataGridViewMain_SelectionChanged(object sender, EventArgs e)
		{
			// Handle DataGridView selection changed cvent. No need to use this now.
		}

		#region 抄表日
		private void tbox_recordYear_TextChanged(object sender, EventArgs e)
		{
			if(!string.IsNullOrEmpty(tbox_recordYear.Text))
			{
				creationDate.Year = tbox_recordYear.Text;
			}
		}

		private void tbox_recordMonth_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_recordMonth.Text))
			{
				creationDate.Month = tbox_recordMonth.Text;
			}
		}

		private void tbox_recordDay_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_recordDay.Text))
			{
				creationDate.Day = tbox_recordDay.Text;
			}
		}
		#endregion

		#region 計費起始日期
		private void tbox_startYear_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_startYear.Text))
			{
				startDate.Year = tbox_startYear.Text;
			}
		}

		private void tbox_startMonth_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_startMonth.Text))
			{
				startDate.Month = tbox_startMonth.Text;
			}
		}

		private void tbox_startDay_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_startDay.Text))
			{
				startDate.Day = tbox_startDay.Text;
			}
		}
		#endregion

		#region 計費結束日期
		private void tbox_endYear_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_endYear.Text))
			{
				endDate.Year = tbox_endYear.Text;
			}
		}

		private void tbox_endMonth_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_endMonth.Text))
			{
				endDate.Month = tbox_endMonth.Text;
			}
		}

		private void tbox_endDay_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_endDay.Text))
			{
				endDate.Day = tbox_endDay.Text;
			}
		}
		#endregion

		#region 紀錄月份
		private void tbox_Year_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_Year.Text))
			{
				invoiceDate.Year = tbox_Year.Text;
			}
		}

		private void tbox_Month_TextChanged(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(tbox_Month.Text))
			{
				invoiceDate.Month = tbox_Month.Text;
			}
		}
		#endregion

		private void btn_selectAll_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridViewMain.Rows)
			{
				if (row.Index < dataGridViewMain.Rows.Count - 1)
					row.Selected = true;
			}
		}

		private void dataGridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Console.WriteLine("當前編輯的攤商: " + VendorList[e.RowIndex].VendorNumber);
		}

		private void dataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
			if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				string targetValue = "";
				if (dataGridViewMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
				{
					targetValue = dataGridViewMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
				}
				Console.WriteLine("當前編輯完成的攤商: " + VendorList[e.RowIndex].VendorNumber);
				switch (e.ColumnIndex)
				{
					case 0:
						break;
					case 1:
						//VendorNumber
						VendorList[e.RowIndex].VendorNumber = targetValue;
						break;
					case 2:
						//LastMonthENumber
						VendorList[e.RowIndex].LastMonthENumber = int.Parse(targetValue);
						break;
					case 3:
						//CurrentMonthENumber
						VendorList[e.RowIndex].CurrentMonthENumber = int.Parse(targetValue);
						break;
					case 4:
						//EUsedValue
						VendorList[e.RowIndex].EUsedValue = int.Parse(targetValue);
						break;
					case 5:
						//EFee
						VendorList[e.RowIndex].EFee = int.Parse(targetValue);
						break;
					case 6:
						//WaterNumber
						VendorList[e.RowIndex].WaterNumber = int.Parse(targetValue);
						break;
					case 7:
						//BasicEFee
						VendorList[e.RowIndex].BasicEFee = int.Parse(targetValue);
						break;
					case 8:
						//LightFee
						VendorList[e.RowIndex].LightFee = int.Parse(targetValue);
						break;
					case 9:
						//ACFee
						VendorList[e.RowIndex].ACFee = int.Parse(targetValue);
						break;
					case 10:
						//BusinessFee
						VendorList[e.RowIndex].BusinessFee = int.Parse(targetValue);
						break;
					case 11:
						//PublicWaterFee
						VendorList[e.RowIndex].PublicWaterFee = int.Parse(targetValue);
						break;
					case 12:
						//WaterFee
						VendorList[e.RowIndex].WaterFee = int.Parse(targetValue);
						break;
					case 13:
						//TotalAmount
						VendorList[e.RowIndex].TotalAmount = int.Parse(targetValue);
						break;
				}
			}
			
		}
	}
}
