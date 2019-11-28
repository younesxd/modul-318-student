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
            this.btnSearch2 = new System.Windows.Forms.Button();
            this.lblVon = new System.Windows.Forms.Label();
            this.lblNach = new System.Windows.Forms.Label();
            this.lblStation = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAnkunft = new System.Windows.Forms.TextBox();
            this.txtAbfahrt = new System.Windows.Forms.TextBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(488, 72);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 0;
            this.btnSearch1.Text = "Suchen";
            this.btnSearch1.UseVisualStyleBackColor = true;
            this.btnSearch1.Click += new System.EventHandler(this.btnSearch1_Click);
            // 
            // btnSearch2
            // 
            this.btnSearch2.Location = new System.Drawing.Point(488, 196);
            this.btnSearch2.Name = "btnSearch2";
            this.btnSearch2.Size = new System.Drawing.Size(75, 23);
            this.btnSearch2.TabIndex = 1;
            this.btnSearch2.Text = "Suchen";
            this.btnSearch2.UseVisualStyleBackColor = true;
            this.btnSearch2.Click += new System.EventHandler(this.btnSearch2_Click);
            // 
            // lblVon
            // 
            this.lblVon.AutoSize = true;
            this.lblVon.Location = new System.Drawing.Point(46, 55);
            this.lblVon.Name = "lblVon";
            this.lblVon.Size = new System.Drawing.Size(29, 13);
            this.lblVon.TabIndex = 5;
            this.lblVon.Text = "Von:";
            // 
            // lblNach
            // 
            this.lblNach.AutoSize = true;
            this.lblNach.Location = new System.Drawing.Point(262, 55);
            this.lblNach.Name = "lblNach";
            this.lblNach.Size = new System.Drawing.Size(36, 13);
            this.lblNach.TabIndex = 6;
            this.lblNach.Text = "Nach:";
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(46, 182);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(43, 13);
            this.lblStation.TabIndex = 7;
            this.lblStation.Text = "Station:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(46, 110);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 13);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Datum und Uhrzeit:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(46, 126);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(177, 20);
            this.datePicker.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "hh:mm";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(265, 126);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(46, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // txtAnkunft
            // 
            this.txtAnkunft.Location = new System.Drawing.Point(265, 74);
            this.txtAnkunft.Name = "txtAnkunft";
            this.txtAnkunft.Size = new System.Drawing.Size(177, 20);
            this.txtAnkunft.TabIndex = 15;
            // 
            // txtAbfahrt
            // 
            this.txtAbfahrt.Location = new System.Drawing.Point(46, 75);
            this.txtAbfahrt.Name = "txtAbfahrt";
            this.txtAbfahrt.Size = new System.Drawing.Size(177, 20);
            this.txtAbfahrt.TabIndex = 16;
            // 
            // txtStation
            // 
            this.txtStation.Location = new System.Drawing.Point(46, 199);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(177, 20);
            this.txtStation.TabIndex = 17;
            // 
            // Hauptseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 290);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.txtAbfahrt);
            this.Controls.Add(this.txtAnkunft);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.lblNach);
            this.Controls.Add(this.lblVon);
            this.Controls.Add(this.btnSearch2);
            this.Controls.Add(this.btnSearch1);
            this.Name = "Hauptseite";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.Button btnSearch2;
        private System.Windows.Forms.Label lblVon;
        private System.Windows.Forms.Label lblNach;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAnkunft;
        private System.Windows.Forms.TextBox txtAbfahrt;
        private System.Windows.Forms.TextBox txtStation;
    }
}

