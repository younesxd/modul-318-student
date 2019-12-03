namespace ÖV_Plan_WinForm
{
    partial class Hauptseite
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
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtAnkunft = new System.Windows.Forms.TextBox();
            this.txtAbfahrt = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.libVorschlagVon = new System.Windows.Forms.ListBox();
            this.libVorschlagNach = new System.Windows.Forms.ListBox();
            this.libVorschlagStation = new System.Windows.Forms.ListBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.txtTimeStation = new System.Windows.Forms.TextBox();
            this.datePickerStation = new System.Windows.Forms.DateTimePicker();
            this.lblDateStation = new System.Windows.Forms.Label();
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSearch1
            // 
            this.btnSearch1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch1.Location = new System.Drawing.Point(641, 266);
            this.btnSearch1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(156, 52);
            this.btnSearch1.TabIndex = 0;
            this.btnSearch1.Text = "SUCHEN";
            this.btnSearch1.UseVisualStyleBackColor = false;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(51, 149);
            this.lblVon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(37, 17);
            this.lblVon.TabIndex = 5;
            this.lblVon.Text = "Von:";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(339, 149);
            this.lblNach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(45, 17);
            this.lblNach.TabIndex = 6;
            this.lblNach.Text = "Nach:";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(51, 366);
            this.lblStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(56, 17);
            this.lblStation.TabIndex = 7;
            this.lblStation.Text = "Station:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(638, 149);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(130, 17);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Datum und Uhrzeit:";
            // 
            // txtAnkunft
            // 
            this.txtAnkunft.Location = new System.Drawing.Point(343, 172);
            this.txtAnkunft.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnkunft.Name = "txtAnkunft";
            this.txtAnkunft.Size = new System.Drawing.Size(249, 22);
            this.txtAnkunft.TabIndex = 15;
            this.txtAnkunft.TextChanged += new System.EventHandler(this.On_Text_Changed_Nach);
            // 
            // txtAbfahrt
            // 
            this.txtAbfahrt.Location = new System.Drawing.Point(51, 173);
            this.txtAbfahrt.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbfahrt.Name = "txtAbfahrt";
            this.txtAbfahrt.Size = new System.Drawing.Size(252, 22);
            this.txtAbfahrt.TabIndex = 16;
            this.txtAbfahrt.TextChanged += new System.EventHandler(this.On_Text_Changed_Von);
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(51, 387);
            this.txtStation.Margin = new System.Windows.Forms.Padding(4);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(252, 22);
            this.txtStation.TabIndex = 17;
            this.txtStation.TextChanged += new System.EventHandler(this.On_Text_Changed_Station);
            // 
            // libVorschlagVon
            // 
            this.libVorschlagVon.FormattingEnabled = true;
            this.libVorschlagVon.ItemHeight = 16;
            this.libVorschlagVon.Location = new System.Drawing.Point(51, 202);
            this.libVorschlagVon.Name = "libVorschlagVon";
            this.libVorschlagVon.Size = new System.Drawing.Size(252, 116);
            this.libVorschlagVon.TabIndex = 18;
            this.libVorschlagVon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.On_Double_Click_Von);
            // 
            // libVorschlagNach
            // 
            this.libVorschlagNach.FormattingEnabled = true;
            this.libVorschlagNach.ItemHeight = 16;
            this.libVorschlagNach.Location = new System.Drawing.Point(342, 202);
            this.libVorschlagNach.Name = "libVorschlagNach";
            this.libVorschlagNach.Size = new System.Drawing.Size(250, 116);
            this.libVorschlagNach.TabIndex = 19;
            this.libVorschlagNach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.On_Double_Click_Nach);
            // 
            // libVorschlagStation
            // 
            this.libVorschlagStation.FormattingEnabled = true;
            this.libVorschlagStation.ItemHeight = 16;
            this.libVorschlagStation.Location = new System.Drawing.Point(51, 416);
            this.libVorschlagStation.Name = "libVorschlagStation";
            this.libVorschlagStation.Size = new System.Drawing.Size(252, 116);
            this.libVorschlagStation.TabIndex = 20;
            this.libVorschlagStation.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.On_Double_Click_Station);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "MM.dd.yyyy";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(641, 173);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(156, 22);
            this.datePicker.TabIndex = 21;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(641, 202);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(156, 22);
            this.txtTime.TabIndex = 22;
            this.txtTime.TextChanged += new System.EventHandler(this.On_Text_Changed_Time);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Arial Narrow", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTitel.Location = new System.Drawing.Point(237, 25);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(331, 94);
            this.lblTitel.TabIndex = 23;
            this.lblTitel.Text = "ÖV PLAN";
            // 
            // txtTimeStation
            // 
            this.txtTimeStation.Location = new System.Drawing.Point(342, 416);
            this.txtTimeStation.Name = "txtTimeStation";
            this.txtTimeStation.Size = new System.Drawing.Size(156, 22);
            this.txtTimeStation.TabIndex = 27;
            this.txtTimeStation.TextChanged += new System.EventHandler(this.On_Text_Changed_Time_Station);
            // 
            // datePickerStation
            // 
            this.datePickerStation.CustomFormat = "MM.dd.yyyy";
            this.datePickerStation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerStation.Location = new System.Drawing.Point(342, 387);
            this.datePickerStation.Margin = new System.Windows.Forms.Padding(4);
            this.datePickerStation.Name = "datePickerStation";
            this.datePickerStation.Size = new System.Drawing.Size(156, 22);
            this.datePickerStation.TabIndex = 26;
            // 
            // lblDateStation
            // 
            this.lblDateStation.AutoSize = true;
            this.lblDateStation.Location = new System.Drawing.Point(340, 366);
            this.lblDateStation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateStation.Name = "lblDateStation";
            this.lblDateStation.Size = new System.Drawing.Size(130, 17);
            this.lblDateStation.TabIndex = 25;
            this.lblDateStation.Text = "Datum und Uhrzeit:";
            // 
            // btnSearch2
            // 
            this.btnSearch2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSearch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch2.Location = new System.Drawing.Point(343, 480);
            this.btnSearch2.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(156, 52);
            this.btnSearch2.TabIndex = 24;
            this.btnSearch2.Text = "SUCHEN";
            this.btnSearch2.UseVisualStyleBackColor = false;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // Hauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 566);
            this.Controls.Add(this.txtTimeStation);
            this.Controls.Add(this.datePickerStation);
            this.Controls.Add(this.lblDateStation);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.libVorschlagStation);
            this.Controls.Add(this.libVorschlagNach);
            this.Controls.Add(this.libVorschlagVon);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.txtAbfahrt);
            this.Controls.Add(this.txtAnkunft);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.btnSearch1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hauptseite";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtAnkunft;
        private System.Windows.Forms.TextBox txtAbfahrt;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.ListBox libVorschlagVon;
        private System.Windows.Forms.ListBox libVorschlagNach;
        private System.Windows.Forms.ListBox libVorschlagStation;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.TextBox txtTimeStation;
        private System.Windows.Forms.DateTimePicker datePickerStation;
        private System.Windows.Forms.Label lblDateStation;
        private System.Windows.Forms.Button btnSearch2;
    }
}

