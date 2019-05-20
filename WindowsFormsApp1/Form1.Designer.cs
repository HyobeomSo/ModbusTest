namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.PortName = new System.Windows.Forms.TextBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SendText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataBits = new System.Windows.Forms.ComboBox();
            this.StopBits = new System.Windows.Forms.ComboBox();
            this.ParityBits = new System.Windows.Forms.ComboBox();
            this.BaudRate = new System.Windows.Forms.ComboBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.M_SlaveID = new System.Windows.Forms.TextBox();
            this.M_Function = new System.Windows.Forms.ComboBox();
            this.M_Offset = new System.Windows.Forms.TextBox();
            this.M_Length = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.HexBtn = new System.Windows.Forms.RadioButton();
            this.AsciiBtn = new System.Windows.Forms.RadioButton();
            this.ModbusBtn = new System.Windows.Forms.Button();
            this.ReceiveTextBox = new System.Windows.Forms.RichTextBox();
            this.DataView = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectDataType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baud Rate";
            // 
            // PortName
            // 
            this.PortName.Location = new System.Drawing.Point(86, 30);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(112, 21);
            this.PortName.TabIndex = 1;
            this.PortName.Text = "COM4";
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(86, 162);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(53, 31);
            this.OpenBtn.TabIndex = 2;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(145, 162);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(53, 31);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port Name";
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(12, 395);
            this.SendText.Name = "SendText";
            this.SendText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SendText.Size = new System.Drawing.Size(129, 21);
            this.SendText.TabIndex = 4;
            this.SendText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SendText_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Bits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stop Bits";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Parity Bits";
            // 
            // DataBits
            // 
            this.DataBits.FormattingEnabled = true;
            this.DataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.DataBits.Location = new System.Drawing.Point(86, 84);
            this.DataBits.Name = "DataBits";
            this.DataBits.Size = new System.Drawing.Size(112, 20);
            this.DataBits.TabIndex = 5;
            this.DataBits.Text = "8";
            // 
            // StopBits
            // 
            this.StopBits.FormattingEnabled = true;
            this.StopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.StopBits.Location = new System.Drawing.Point(86, 110);
            this.StopBits.Name = "StopBits";
            this.StopBits.Size = new System.Drawing.Size(112, 20);
            this.StopBits.TabIndex = 5;
            this.StopBits.Text = "2";
            // 
            // ParityBits
            // 
            this.ParityBits.FormattingEnabled = true;
            this.ParityBits.Items.AddRange(new object[] {
            "Even",
            "None",
            "Odd"});
            this.ParityBits.Location = new System.Drawing.Point(86, 136);
            this.ParityBits.Name = "ParityBits";
            this.ParityBits.Size = new System.Drawing.Size(112, 20);
            this.ParityBits.TabIndex = 5;
            this.ParityBits.Text = "None";
            // 
            // BaudRate
            // 
            this.BaudRate.FormattingEnabled = true;
            this.BaudRate.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.BaudRate.Location = new System.Drawing.Point(86, 57);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(112, 20);
            this.BaudRate.TabIndex = 5;
            this.BaudRate.Text = "115200";
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(142, 395);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(75, 23);
            this.SendBtn.TabIndex = 6;
            this.SendBtn.Text = "Send";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(1185, 862);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(224, 87);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(1169, 547);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.CustomProperties = "IsXAxisQuantitative=False";
            series3.Legend = "Legend1";
            series3.Name = "TEST1";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "TEST2";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(522, 297);
            this.chart1.TabIndex = 10;
            this.chart1.Text = "chart1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(1438, 862);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(224, 87);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1263, 847);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "TEST1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1530, 847);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "TEST2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ParityBits);
            this.groupBox1.Controls.Add(this.StopBits);
            this.groupBox1.Controls.Add(this.BaudRate);
            this.groupBox1.Controls.Add(this.DataBits);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CloseBtn);
            this.groupBox1.Controls.Add(this.PortName);
            this.groupBox1.Controls.Add(this.OpenBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 200);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Property";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "Slave ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Function";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "Offset";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "Length";
            // 
            // M_SlaveID
            // 
            this.M_SlaveID.Location = new System.Drawing.Point(86, 28);
            this.M_SlaveID.Name = "M_SlaveID";
            this.M_SlaveID.Size = new System.Drawing.Size(112, 21);
            this.M_SlaveID.TabIndex = 18;
            this.M_SlaveID.Text = "1";
            // 
            // M_Function
            // 
            this.M_Function.FormattingEnabled = true;
            this.M_Function.Items.AddRange(new object[] {
            "01 - Read Coil",
            "02 - Read Dicrete Inputs",
            "03 - Read Holding Registers",
            "04 - Read Input Registers"});
            this.M_Function.Location = new System.Drawing.Point(86, 55);
            this.M_Function.Name = "M_Function";
            this.M_Function.Size = new System.Drawing.Size(112, 20);
            this.M_Function.TabIndex = 19;
            this.M_Function.Text = "01 - Read Coil";
            // 
            // M_Offset
            // 
            this.M_Offset.Location = new System.Drawing.Point(86, 81);
            this.M_Offset.Name = "M_Offset";
            this.M_Offset.Size = new System.Drawing.Size(112, 21);
            this.M_Offset.TabIndex = 20;
            // 
            // M_Length
            // 
            this.M_Length.Location = new System.Drawing.Point(86, 108);
            this.M_Length.Name = "M_Length";
            this.M_Length.Size = new System.Drawing.Size(112, 21);
            this.M_Length.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.HexBtn);
            this.groupBox3.Controls.Add(this.AsciiBtn);
            this.groupBox3.Controls.Add(this.ModbusBtn);
            this.groupBox3.Controls.Add(this.M_Offset);
            this.groupBox3.Controls.Add(this.M_Length);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.M_Function);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.M_SlaveID);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 180);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Modbus";
            // 
            // HexBtn
            // 
            this.HexBtn.AutoSize = true;
            this.HexBtn.Location = new System.Drawing.Point(6, 157);
            this.HexBtn.Name = "HexBtn";
            this.HexBtn.Size = new System.Drawing.Size(47, 16);
            this.HexBtn.TabIndex = 23;
            this.HexBtn.Text = "HEX";
            this.HexBtn.UseVisualStyleBackColor = true;
            // 
            // AsciiBtn
            // 
            this.AsciiBtn.AutoSize = true;
            this.AsciiBtn.Checked = true;
            this.AsciiBtn.Location = new System.Drawing.Point(6, 135);
            this.AsciiBtn.Name = "AsciiBtn";
            this.AsciiBtn.Size = new System.Drawing.Size(54, 16);
            this.AsciiBtn.TabIndex = 23;
            this.AsciiBtn.TabStop = true;
            this.AsciiBtn.Text = "ASCII";
            this.AsciiBtn.UseVisualStyleBackColor = true;
            // 
            // ModbusBtn
            // 
            this.ModbusBtn.Location = new System.Drawing.Point(86, 140);
            this.ModbusBtn.Name = "ModbusBtn";
            this.ModbusBtn.Size = new System.Drawing.Size(112, 34);
            this.ModbusBtn.TabIndex = 22;
            this.ModbusBtn.Text = "Modbus";
            this.ModbusBtn.UseVisualStyleBackColor = true;
            this.ModbusBtn.Click += new System.EventHandler(this.ModbusGen);
            // 
            // ReceiveTextBox
            // 
            this.ReceiveTextBox.Location = new System.Drawing.Point(239, 13);
            this.ReceiveTextBox.Name = "ReceiveTextBox";
            this.ReceiveTextBox.ReadOnly = true;
            this.ReceiveTextBox.Size = new System.Drawing.Size(437, 376);
            this.ReceiveTextBox.TabIndex = 23;
            this.ReceiveTextBox.Text = "";
            // 
            // DataView
            // 
            this.DataView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Data});
            this.DataView.Location = new System.Drawing.Point(682, 36);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(219, 376);
            this.DataView.TabIndex = 24;
            this.DataView.UseCompatibleStateImageBehavior = false;
            this.DataView.View = System.Windows.Forms.View.Details;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 107;
            // 
            // Data
            // 
            this.Data.Text = "Data";
            this.Data.Width = 108;
            // 
            // SelectDataType
            // 
            this.SelectDataType.FormattingEnabled = true;
            this.SelectDataType.Items.AddRange(new object[] {
            "Hex",
            "Signed",
            "Float"});
            this.SelectDataType.Location = new System.Drawing.Point(682, 10);
            this.SelectDataType.Name = "SelectDataType";
            this.SelectDataType.Size = new System.Drawing.Size(100, 20);
            this.SelectDataType.TabIndex = 25;
            this.SelectDataType.Text = "Hex";
            this.SelectDataType.SelectedIndexChanged += new System.EventHandler(this.Change_DataType);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 424);
            this.Controls.Add(this.SelectDataType);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.ReceiveTextBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PortName;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SendText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox DataBits;
        private System.Windows.Forms.ComboBox StopBits;
        private System.Windows.Forms.ComboBox ParityBits;
        private System.Windows.Forms.ComboBox BaudRate;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox M_SlaveID;
        private System.Windows.Forms.ComboBox M_Function;
        private System.Windows.Forms.TextBox M_Offset;
        private System.Windows.Forms.TextBox M_Length;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ModbusBtn;
        private System.Windows.Forms.RadioButton HexBtn;
        private System.Windows.Forms.RadioButton AsciiBtn;
        private System.Windows.Forms.RichTextBox ReceiveTextBox;
        private System.Windows.Forms.ListView DataView;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ComboBox SelectDataType;
    }
}

