
namespace YoEaseReport
{
	partial class FormYoEaseReport
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_import = new System.Windows.Forms.Button();
			this.btn_print = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.tbox_startYear = new System.Windows.Forms.TextBox();
			this.tbox_startMonth = new System.Windows.Forms.TextBox();
			this.tbox_startDay = new System.Windows.Forms.TextBox();
			this.tbox_endDay = new System.Windows.Forms.TextBox();
			this.tbox_endMonth = new System.Windows.Forms.TextBox();
			this.tbox_endYear = new System.Windows.Forms.TextBox();
			this.dataGridViewMain = new System.Windows.Forms.DataGridView();
			this.tbox_recordDay = new System.Windows.Forms.TextBox();
			this.tbox_recordMonth = new System.Windows.Forms.TextBox();
			this.tbox_recordYear = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tbox_Month = new System.Windows.Forms.TextBox();
			this.tbox_Year = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.btn_selectAll = new System.Windows.Forms.Button();
			this.ColIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColVendorNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColLastMonthElectricNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColCurrentMonthElectricNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColElectricUsedValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColElectricFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColWaterNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColBasicElectricFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColLightFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColACFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColBusinessFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColPublicWaterFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColWaterFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColTotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_import
			// 
			this.btn_import.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_import.Location = new System.Drawing.Point(910, 68);
			this.btn_import.Name = "btn_import";
			this.btn_import.Size = new System.Drawing.Size(148, 43);
			this.btn_import.TabIndex = 13;
			this.btn_import.Text = "匯入Excel";
			this.btn_import.UseVisualStyleBackColor = true;
			this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
			// 
			// btn_print
			// 
			this.btn_print.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_print.Location = new System.Drawing.Point(1064, 68);
			this.btn_print.Name = "btn_print";
			this.btn_print.Size = new System.Drawing.Size(148, 43);
			this.btn_print.TabIndex = 14;
			this.btn_print.Text = "列印收據";
			this.btn_print.UseVisualStyleBackColor = true;
			this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(18, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(109, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "用電計費期間:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(177, 52);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "年";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(251, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "月";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(327, 52);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "日至";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(570, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "日";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(489, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 20);
			this.label6.TabIndex = 8;
			this.label6.Text = "月";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(415, 52);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(25, 20);
			this.label7.TabIndex = 7;
			this.label7.Text = "年";
			// 
			// tbox_startYear
			// 
			this.tbox_startYear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_startYear.Location = new System.Drawing.Point(129, 48);
			this.tbox_startYear.Name = "tbox_startYear";
			this.tbox_startYear.Size = new System.Drawing.Size(47, 29);
			this.tbox_startYear.TabIndex = 3;
			this.tbox_startYear.TextChanged += new System.EventHandler(this.tbox_startYear_TextChanged);
			// 
			// tbox_startMonth
			// 
			this.tbox_startMonth.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_startMonth.Location = new System.Drawing.Point(205, 48);
			this.tbox_startMonth.Name = "tbox_startMonth";
			this.tbox_startMonth.Size = new System.Drawing.Size(47, 29);
			this.tbox_startMonth.TabIndex = 4;
			this.tbox_startMonth.TextChanged += new System.EventHandler(this.tbox_startMonth_TextChanged);
			// 
			// tbox_startDay
			// 
			this.tbox_startDay.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_startDay.Location = new System.Drawing.Point(279, 48);
			this.tbox_startDay.Name = "tbox_startDay";
			this.tbox_startDay.Size = new System.Drawing.Size(47, 29);
			this.tbox_startDay.TabIndex = 5;
			this.tbox_startDay.TextChanged += new System.EventHandler(this.tbox_startDay_TextChanged);
			// 
			// tbox_endDay
			// 
			this.tbox_endDay.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_endDay.Location = new System.Drawing.Point(517, 48);
			this.tbox_endDay.Name = "tbox_endDay";
			this.tbox_endDay.Size = new System.Drawing.Size(47, 29);
			this.tbox_endDay.TabIndex = 8;
			this.tbox_endDay.TextChanged += new System.EventHandler(this.tbox_endDay_TextChanged);
			// 
			// tbox_endMonth
			// 
			this.tbox_endMonth.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_endMonth.Location = new System.Drawing.Point(443, 48);
			this.tbox_endMonth.Name = "tbox_endMonth";
			this.tbox_endMonth.Size = new System.Drawing.Size(47, 29);
			this.tbox_endMonth.TabIndex = 7;
			this.tbox_endMonth.TextChanged += new System.EventHandler(this.tbox_endMonth_TextChanged);
			// 
			// tbox_endYear
			// 
			this.tbox_endYear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_endYear.Location = new System.Drawing.Point(367, 48);
			this.tbox_endYear.Name = "tbox_endYear";
			this.tbox_endYear.Size = new System.Drawing.Size(47, 29);
			this.tbox_endYear.TabIndex = 6;
			this.tbox_endYear.TextChanged += new System.EventHandler(this.tbox_endYear_TextChanged);
			// 
			// dataGridViewMain
			// 
			this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIndex,
            this.ColVendorNumber,
            this.ColLastMonthElectricNum,
            this.ColCurrentMonthElectricNum,
            this.ColElectricUsedValue,
            this.ColElectricFee,
            this.ColWaterNumber,
            this.ColBasicElectricFee,
            this.ColLightFee,
            this.ColACFee,
            this.ColBusinessFee,
            this.ColPublicWaterFee,
            this.ColWaterFee,
            this.ColTotalAmount});
			this.dataGridViewMain.Location = new System.Drawing.Point(12, 125);
			this.dataGridViewMain.Name = "dataGridViewMain";
			this.dataGridViewMain.RowTemplate.Height = 24;
			this.dataGridViewMain.Size = new System.Drawing.Size(1200, 624);
			this.dataGridViewMain.TabIndex = 16;
			this.dataGridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellClick);
			this.dataGridViewMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellEndEdit);
			this.dataGridViewMain.SelectionChanged += new System.EventHandler(this.dataGridViewMain_SelectionChanged);
			// 
			// tbox_recordDay
			// 
			this.tbox_recordDay.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_recordDay.Location = new System.Drawing.Point(279, 85);
			this.tbox_recordDay.Name = "tbox_recordDay";
			this.tbox_recordDay.Size = new System.Drawing.Size(47, 29);
			this.tbox_recordDay.TabIndex = 11;
			this.tbox_recordDay.TextChanged += new System.EventHandler(this.tbox_recordDay_TextChanged);
			// 
			// tbox_recordMonth
			// 
			this.tbox_recordMonth.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_recordMonth.Location = new System.Drawing.Point(205, 85);
			this.tbox_recordMonth.Name = "tbox_recordMonth";
			this.tbox_recordMonth.Size = new System.Drawing.Size(47, 29);
			this.tbox_recordMonth.TabIndex = 10;
			this.tbox_recordMonth.TextChanged += new System.EventHandler(this.tbox_recordMonth_TextChanged);
			// 
			// tbox_recordYear
			// 
			this.tbox_recordYear.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_recordYear.Location = new System.Drawing.Point(129, 85);
			this.tbox_recordYear.Name = "tbox_recordYear";
			this.tbox_recordYear.Size = new System.Drawing.Size(47, 29);
			this.tbox_recordYear.TabIndex = 9;
			this.tbox_recordYear.TextChanged += new System.EventHandler(this.tbox_recordYear_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label8.Location = new System.Drawing.Point(327, 89);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(25, 20);
			this.label8.TabIndex = 20;
			this.label8.Text = "日";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(251, 89);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(25, 20);
			this.label9.TabIndex = 19;
			this.label9.Text = "月";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label10.Location = new System.Drawing.Point(177, 89);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(25, 20);
			this.label10.TabIndex = 18;
			this.label10.Text = "年";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label11.Location = new System.Drawing.Point(18, 89);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 20);
			this.label11.TabIndex = 17;
			this.label11.Text = "抄表日:";
			// 
			// tbox_Month
			// 
			this.tbox_Month.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_Month.Location = new System.Drawing.Point(205, 13);
			this.tbox_Month.Name = "tbox_Month";
			this.tbox_Month.Size = new System.Drawing.Size(47, 29);
			this.tbox_Month.TabIndex = 2;
			this.tbox_Month.TextChanged += new System.EventHandler(this.tbox_Month_TextChanged);
			// 
			// tbox_Year
			// 
			this.tbox_Year.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tbox_Year.Location = new System.Drawing.Point(129, 13);
			this.tbox_Year.Name = "tbox_Year";
			this.tbox_Year.Size = new System.Drawing.Size(47, 29);
			this.tbox_Year.TabIndex = 1;
			this.tbox_Year.TextChanged += new System.EventHandler(this.tbox_Year_TextChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label12.Location = new System.Drawing.Point(251, 17);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(25, 20);
			this.label12.TabIndex = 26;
			this.label12.Text = "月";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label13.Location = new System.Drawing.Point(177, 17);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(25, 20);
			this.label13.TabIndex = 25;
			this.label13.Text = "年";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label14.Location = new System.Drawing.Point(18, 17);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(45, 20);
			this.label14.TabIndex = 24;
			this.label14.Text = "月份:";
			// 
			// btn_selectAll
			// 
			this.btn_selectAll.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.btn_selectAll.Location = new System.Drawing.Point(1064, 17);
			this.btn_selectAll.Name = "btn_selectAll";
			this.btn_selectAll.Size = new System.Drawing.Size(148, 43);
			this.btn_selectAll.TabIndex = 27;
			this.btn_selectAll.Text = "全選";
			this.btn_selectAll.UseVisualStyleBackColor = true;
			this.btn_selectAll.Click += new System.EventHandler(this.btn_selectAll_Click);
			// 
			// ColIndex
			// 
			this.ColIndex.HeaderText = "序號";
			this.ColIndex.Name = "ColIndex";
			this.ColIndex.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColIndex.Width = 60;
			// 
			// ColVendorNumber
			// 
			this.ColVendorNumber.HeaderText = "攤號";
			this.ColVendorNumber.Name = "ColVendorNumber";
			this.ColVendorNumber.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColVendorNumber.Width = 75;
			// 
			// ColLastMonthElectricNum
			// 
			this.ColLastMonthElectricNum.HeaderText = "上月電表度數";
			this.ColLastMonthElectricNum.Name = "ColLastMonthElectricNum";
			// 
			// ColCurrentMonthElectricNum
			// 
			this.ColCurrentMonthElectricNum.HeaderText = "本月電表度數";
			this.ColCurrentMonthElectricNum.Name = "ColCurrentMonthElectricNum";
			// 
			// ColElectricUsedValue
			// 
			this.ColElectricUsedValue.HeaderText = "實用度數";
			this.ColElectricUsedValue.Name = "ColElectricUsedValue";
			this.ColElectricUsedValue.Width = 77;
			// 
			// ColElectricFee
			// 
			this.ColElectricFee.HeaderText = "用電電費";
			this.ColElectricFee.Name = "ColElectricFee";
			this.ColElectricFee.Width = 77;
			// 
			// ColWaterNumber
			// 
			this.ColWaterNumber.HeaderText = "水表用量";
			this.ColWaterNumber.Name = "ColWaterNumber";
			this.ColWaterNumber.Width = 77;
			// 
			// ColBasicElectricFee
			// 
			this.ColBasicElectricFee.HeaderText = "基本電費";
			this.ColBasicElectricFee.Name = "ColBasicElectricFee";
			this.ColBasicElectricFee.Width = 77;
			// 
			// ColLightFee
			// 
			this.ColLightFee.HeaderText = "照明電費";
			this.ColLightFee.Name = "ColLightFee";
			this.ColLightFee.Width = 77;
			// 
			// ColACFee
			// 
			this.ColACFee.HeaderText = "冷氣電費";
			this.ColACFee.Name = "ColACFee";
			this.ColACFee.Width = 77;
			// 
			// ColBusinessFee
			// 
			this.ColBusinessFee.HeaderText = "業務費";
			this.ColBusinessFee.Name = "ColBusinessFee";
			this.ColBusinessFee.Width = 70;
			// 
			// ColPublicWaterFee
			// 
			this.ColPublicWaterFee.HeaderText = "公共用水費";
			this.ColPublicWaterFee.Name = "ColPublicWaterFee";
			// 
			// ColWaterFee
			// 
			this.ColWaterFee.HeaderText = "自來水費";
			this.ColWaterFee.Name = "ColWaterFee";
			this.ColWaterFee.Width = 80;
			// 
			// ColTotalAmount
			// 
			this.ColTotalAmount.HeaderText = "應繳總金額";
			this.ColTotalAmount.Name = "ColTotalAmount";
			// 
			// FormYoEaseReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1230, 761);
			this.Controls.Add(this.btn_selectAll);
			this.Controls.Add(this.tbox_Month);
			this.Controls.Add(this.tbox_Year);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.tbox_recordDay);
			this.Controls.Add(this.tbox_recordMonth);
			this.Controls.Add(this.tbox_recordYear);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.dataGridViewMain);
			this.Controls.Add(this.tbox_endDay);
			this.Controls.Add(this.tbox_endMonth);
			this.Controls.Add(this.tbox_endYear);
			this.Controls.Add(this.tbox_startDay);
			this.Controls.Add(this.tbox_startMonth);
			this.Controls.Add(this.tbox_startYear);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_print);
			this.Controls.Add(this.btn_import);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(1246, 800);
			this.MinimumSize = new System.Drawing.Size(1246, 800);
			this.Name = "FormYoEaseReport";
			this.Text = "Yo Ease Report";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormYoEaseReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_import;
		private System.Windows.Forms.Button btn_print;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tbox_startYear;
		private System.Windows.Forms.TextBox tbox_startMonth;
		private System.Windows.Forms.TextBox tbox_startDay;
		private System.Windows.Forms.TextBox tbox_endDay;
		private System.Windows.Forms.TextBox tbox_endMonth;
		private System.Windows.Forms.TextBox tbox_endYear;
		private System.Windows.Forms.DataGridView dataGridViewMain;
		private System.Windows.Forms.TextBox tbox_recordDay;
		private System.Windows.Forms.TextBox tbox_recordMonth;
		private System.Windows.Forms.TextBox tbox_recordYear;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbox_Month;
		private System.Windows.Forms.TextBox tbox_Year;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button btn_selectAll;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColIndex;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColVendorNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColLastMonthElectricNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColCurrentMonthElectricNum;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColElectricUsedValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColElectricFee;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColWaterNumber;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColBasicElectricFee;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColLightFee;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColACFee;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColBusinessFee;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColPublicWaterFee;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColWaterFee;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColTotalAmount;
	}
}

