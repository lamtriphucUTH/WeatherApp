namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label8 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.labDetail2 = new System.Windows.Forms.Label();
            this.labAdvice = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.butReload = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.labGrndLevel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labCondition = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.labSeaLevel = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.labFeels_like = new System.Windows.Forms.Label();
            this.labDetail = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labTemp_max = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labTemp_min = new System.Windows.Forms.Label();
            this.labTemperature = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labDateTime2 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labDateTime = new System.Windows.Forms.Label();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1405, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 28);
            this.label8.TabIndex = 46;
            this.label8.Text = "v2.0";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.Transparent;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(1329, 683);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 38);
            this.btnShow.TabIndex = 45;
            this.btnShow.Text = "Tải Lại Bảng";
            this.btnShow.UseVisualStyleBackColor = false;
            // 
            // labDetail2
            // 
            this.labDetail2.AutoSize = true;
            this.labDetail2.BackColor = System.Drawing.Color.Transparent;
            this.labDetail2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetail2.ForeColor = System.Drawing.Color.White;
            this.labDetail2.Location = new System.Drawing.Point(208, 217);
            this.labDetail2.Name = "labDetail2";
            this.labDetail2.Size = new System.Drawing.Size(71, 41);
            this.labDetail2.TabIndex = 44;
            this.labDetail2.Text = "N/A";
            // 
            // labAdvice
            // 
            this.labAdvice.AutoSize = true;
            this.labAdvice.BackColor = System.Drawing.Color.Transparent;
            this.labAdvice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAdvice.ForeColor = System.Drawing.Color.White;
            this.labAdvice.Location = new System.Drawing.Point(202, 258);
            this.labAdvice.Name = "labAdvice";
            this.labAdvice.Size = new System.Drawing.Size(192, 54);
            this.labAdvice.TabIndex = 43;
            this.labAdvice.Text = "Lời Nhắn:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(767, 379);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(552, 342);
            this.dataGridView1.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(13, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mặt Trời Mọc:";
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.BackColor = System.Drawing.Color.Transparent;
            this.labSunrise.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.Transparent;
            this.labSunrise.Location = new System.Drawing.Point(175, 29);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(48, 28);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(11, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 28);
            this.label7.TabIndex = 8;
            this.label7.Text = "Mặt Trời Lặng:";
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.BackColor = System.Drawing.Color.Transparent;
            this.labSunset.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.Transparent;
            this.labSunset.Location = new System.Drawing.Point(175, 71);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(48, 28);
            this.labSunset.TabIndex = 9;
            this.labSunset.Text = "N/A";
            // 
            // butReload
            // 
            this.butReload.BackColor = System.Drawing.Color.Transparent;
            this.butReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReload.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReload.ForeColor = System.Drawing.Color.White;
            this.butReload.Location = new System.Drawing.Point(1062, 23);
            this.butReload.Name = "butReload";
            this.butReload.Size = new System.Drawing.Size(120, 39);
            this.butReload.TabIndex = 40;
            this.butReload.Text = "Tải Lại";
            this.butReload.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(12, 686);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 35);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(352, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 28);
            this.label10.TabIndex = 21;
            this.label10.Text = "Trạng Thái:";
            // 
            // labGrndLevel
            // 
            this.labGrndLevel.AutoSize = true;
            this.labGrndLevel.BackColor = System.Drawing.Color.Transparent;
            this.labGrndLevel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGrndLevel.ForeColor = System.Drawing.Color.Transparent;
            this.labGrndLevel.Location = new System.Drawing.Point(527, 165);
            this.labGrndLevel.Name = "labGrndLevel";
            this.labGrndLevel.Size = new System.Drawing.Size(48, 28);
            this.labGrndLevel.TabIndex = 21;
            this.labGrndLevel.Text = "N/A";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labSunset);
            this.groupBox1.Controls.Add(this.labSunrise);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.labGrndLevel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labCondition);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.labWindSpeed);
            this.groupBox1.Controls.Add(this.labSeaLevel);
            this.groupBox1.Controls.Add(this.labPressure);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.labHumidity);
            this.groupBox1.Controls.Add(this.labFeels_like);
            this.groupBox1.Controls.Add(this.labDetail);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(121, 471);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 250);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Chi Tiết:";
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(487, 212);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(55, 31);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(352, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tốc Độ Gió:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(354, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 28);
            this.label14.TabIndex = 20;
            this.label14.Text = "Bề Mặt:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.Transparent;
            this.labWindSpeed.Location = new System.Drawing.Point(519, 29);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(48, 28);
            this.labWindSpeed.TabIndex = 11;
            this.labWindSpeed.Text = "N/A";
            // 
            // labSeaLevel
            // 
            this.labSeaLevel.AutoSize = true;
            this.labSeaLevel.BackColor = System.Drawing.Color.Transparent;
            this.labSeaLevel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSeaLevel.ForeColor = System.Drawing.Color.Transparent;
            this.labSeaLevel.Location = new System.Drawing.Point(521, 71);
            this.labSeaLevel.Name = "labSeaLevel";
            this.labSeaLevel.Size = new System.Drawing.Size(48, 28);
            this.labSeaLevel.TabIndex = 19;
            this.labSeaLevel.Text = "N/A";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.Transparent;
            this.labPressure.Location = new System.Drawing.Point(523, 118);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(48, 28);
            this.labPressure.TabIndex = 13;
            this.labPressure.Text = "N/A";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(352, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 28);
            this.label12.TabIndex = 18;
            this.label12.Text = "Mực Nước Biển:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(352, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 12;
            this.label4.Text = "Áp Suất:";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.BackColor = System.Drawing.Color.Transparent;
            this.labHumidity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.Transparent;
            this.labHumidity.Location = new System.Drawing.Point(194, 165);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(48, 28);
            this.labHumidity.TabIndex = 17;
            this.labHumidity.Text = "N/A";
            // 
            // labFeels_like
            // 
            this.labFeels_like.AutoSize = true;
            this.labFeels_like.BackColor = System.Drawing.Color.Transparent;
            this.labFeels_like.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFeels_like.ForeColor = System.Drawing.Color.Transparent;
            this.labFeels_like.Location = new System.Drawing.Point(194, 118);
            this.labFeels_like.Name = "labFeels_like";
            this.labFeels_like.Size = new System.Drawing.Size(48, 28);
            this.labFeels_like.TabIndex = 15;
            this.labFeels_like.Text = "N/A";
            // 
            // labDetail
            // 
            this.labDetail.AutoSize = true;
            this.labDetail.BackColor = System.Drawing.Color.Transparent;
            this.labDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetail.ForeColor = System.Drawing.Color.White;
            this.labDetail.Location = new System.Drawing.Point(110, 214);
            this.labDetail.Name = "labDetail";
            this.labDetail.Size = new System.Drawing.Size(48, 28);
            this.labDetail.TabIndex = 4;
            this.labDetail.Text = "N/A";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(8, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 28);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cảm Thấy :";
            // 
            // labTemp_max
            // 
            this.labTemp_max.AutoSize = true;
            this.labTemp_max.BackColor = System.Drawing.Color.Transparent;
            this.labTemp_max.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp_max.ForeColor = System.Drawing.Color.Transparent;
            this.labTemp_max.Location = new System.Drawing.Point(315, 150);
            this.labTemp_max.Name = "labTemp_max";
            this.labTemp_max.Size = new System.Drawing.Size(48, 28);
            this.labTemp_max.TabIndex = 13;
            this.labTemp_max.Text = "N/A";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(10, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 28);
            this.label11.TabIndex = 16;
            this.label11.Text = "Độ Ẩm:";
            // 
            // labTemp_min
            // 
            this.labTemp_min.AutoSize = true;
            this.labTemp_min.BackColor = System.Drawing.Color.Transparent;
            this.labTemp_min.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp_min.ForeColor = System.Drawing.Color.Transparent;
            this.labTemp_min.Location = new System.Drawing.Point(210, 150);
            this.labTemp_min.Name = "labTemp_min";
            this.labTemp_min.Size = new System.Drawing.Size(48, 28);
            this.labTemp_min.TabIndex = 11;
            this.labTemp_min.Text = "N/A";
            // 
            // labTemperature
            // 
            this.labTemperature.AutoSize = true;
            this.labTemperature.BackColor = System.Drawing.Color.Transparent;
            this.labTemperature.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemperature.ForeColor = System.Drawing.Color.Transparent;
            this.labTemperature.Location = new System.Drawing.Point(632, 97);
            this.labTemperature.Name = "labTemperature";
            this.labTemperature.Size = new System.Drawing.Size(167, 146);
            this.labTemperature.TabIndex = 34;
            this.labTemperature.Text = "°C";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1062, 68);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 44);
            this.btnSearch.TabIndex = 33;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // TBCity
            // 
            this.TBCity.AutoCompleteCustomSource.AddRange(new string[] {
            "Quận 1",
            "Quận 12",
            "Quận Gò Vấp",
            "Quận Bình Thạnh",
            "Quận Tân Bình",
            "Quận Tân Phú",
            "Quận Phú Nhuận",
            "Thành phố Thủ Đức",
            "Quận 3",
            "Quận 10",
            "Quận 11",
            "Quận 4",
            " Quận 5",
            "Quận 6",
            "Quận 8",
            "Quận Bình Tân",
            "Quận 7",
            "Huyện Củ Chi",
            "Huyện Hóc Môn",
            "Huyện Bình Chánh",
            "Huyện Nhà Bè",
            "Huyện Cần Giờ"});
            this.TBCity.BackColor = System.Drawing.Color.White;
            this.TBCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.ForeColor = System.Drawing.Color.Black;
            this.TBCity.Location = new System.Drawing.Point(429, 47);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(611, 36);
            this.TBCity.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(186, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nhập Tên Thành Phố ";
            // 
            // labDateTime2
            // 
            this.labDateTime2.AutoSize = true;
            this.labDateTime2.BackColor = System.Drawing.Color.Transparent;
            this.labDateTime2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateTime2.ForeColor = System.Drawing.Color.White;
            this.labDateTime2.Location = new System.Drawing.Point(101, 16);
            this.labDateTime2.Name = "labDateTime2";
            this.labDateTime2.Size = new System.Drawing.Size(65, 28);
            this.labDateTime2.TabIndex = 37;
            this.labDateTime2.Text = "Ngày:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(478, 106);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(137, 97);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 35;
            this.picIcon.TabStop = false;
            // 
            // labDateTime
            // 
            this.labDateTime.AutoSize = true;
            this.labDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labDateTime.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateTime.ForeColor = System.Drawing.Color.White;
            this.labDateTime.Location = new System.Drawing.Point(32, 16);
            this.labDateTime.Name = "labDateTime";
            this.labDateTime.Size = new System.Drawing.Size(51, 28);
            this.labDateTime.TabIndex = 36;
            this.labDateTime.Text = "Giờ:";
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(121, 379);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(640, 100);
            this.elementHost1.TabIndex = 47;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.cartesianChart1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(288, 150);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 28);
            this.label15.TabIndex = 48;
            this.label15.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1473, 749);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.labDetail2);
            this.Controls.Add(this.labAdvice);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butReload);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labTemperature);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labDateTime2);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labDateTime);
            this.Controls.Add(this.labTemp_min);
            this.Controls.Add(this.labTemp_max);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherApplication-v2.0";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label labDetail2;
        private System.Windows.Forms.Label labAdvice;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Button butReload;
        private System.Windows.Forms.Button btnExit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labGrndLevel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label labSeaLevel;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.Label labFeels_like;
        private System.Windows.Forms.Label labDetail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labTemp_max;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labTemp_min;
        private System.Windows.Forms.Label labTemperature;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDateTime2;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labDateTime;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private LiveCharts.Wpf.CartesianChart cartesianChart1;
        private System.Windows.Forms.Label label15;
    }
}

