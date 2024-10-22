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
            this.butReload = new System.Windows.Forms.Button();
            this.labDateTime2 = new System.Windows.Forms.Label();
            this.labDateTime = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.TBCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butReload
            // 
            this.butReload.BackColor = System.Drawing.Color.Transparent;
            this.butReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butReload.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butReload.ForeColor = System.Drawing.Color.White;
            this.butReload.Location = new System.Drawing.Point(815, 51);
            this.butReload.Name = "butReload";
            this.butReload.Size = new System.Drawing.Size(120, 39);
            this.butReload.TabIndex = 27;
            this.butReload.Text = "Reload";
            this.butReload.UseVisualStyleBackColor = false;
            // 
            // labDateTime2
            // 
            this.labDateTime2.AutoSize = true;
            this.labDateTime2.BackColor = System.Drawing.Color.Transparent;
            this.labDateTime2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateTime2.ForeColor = System.Drawing.Color.White;
            this.labDateTime2.Location = new System.Drawing.Point(72, 24);
            this.labDateTime2.Name = "labDateTime2";
            this.labDateTime2.Size = new System.Drawing.Size(53, 28);
            this.labDateTime2.TabIndex = 26;
            this.labDateTime2.Text = "Day:";
            // 
            // labDateTime
            // 
            this.labDateTime.AutoSize = true;
            this.labDateTime.BackColor = System.Drawing.Color.Transparent;
            this.labDateTime.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDateTime.ForeColor = System.Drawing.Color.White;
            this.labDateTime.Location = new System.Drawing.Point(3, 24);
            this.labDateTime.Name = "labDateTime";
            this.labDateTime.Size = new System.Drawing.Size(63, 28);
            this.labDateTime.TabIndex = 25;
            this.labDateTime.Text = "Time:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(815, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 44);
            this.btnSearch.TabIndex = 24;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // TBCity
            // 
            this.TBCity.BackColor = System.Drawing.Color.White;
            this.TBCity.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.ForeColor = System.Drawing.Color.Black;
            this.TBCity.Location = new System.Drawing.Point(182, 68);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(611, 36);
            this.TBCity.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 22;
            this.label1.Text = "Find City";
            // 
            // butExit
            // 
            this.butExit.BackColor = System.Drawing.Color.Transparent;
            this.butExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.ForeColor = System.Drawing.Color.Red;
            this.butExit.Location = new System.Drawing.Point(2, 465);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(64, 35);
            this.butExit.TabIndex = 28;
            this.butExit.Text = "EXIT";
            this.butExit.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 512);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.butReload);
            this.Controls.Add(this.labDateTime2);
            this.Controls.Add(this.labDateTime);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeatherApplication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butReload;
        private System.Windows.Forms.Label labDateTime2;
        private System.Windows.Forms.Label labDateTime;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butExit;
    }
}

