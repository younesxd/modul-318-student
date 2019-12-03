namespace ÖV_Plan_WinForm
{
    partial class farhplanForm
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
            this.libFahrplan = new System.Windows.Forms.ListBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblDauer = new System.Windows.Forms.Label();
            this.lblAnkunft = new System.Windows.Forms.Label();
            this.lblAbfahrt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libFahrplan
            // 
            this.libFahrplan.FormattingEnabled = true;
            this.libFahrplan.ItemHeight = 16;
            this.libFahrplan.Location = new System.Drawing.Point(57, 129);
            this.libFahrplan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.libFahrplan.Name = "libFahrplan";
            this.libFahrplan.Size = new System.Drawing.Size(600, 260);
            this.libFahrplan.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(208, 33);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(303, 69);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "FAHRPLAN";
            // 
            // lblDauer
            // 
            this.lblDauer.AutoSize = true;
            this.lblDauer.Location = new System.Drawing.Point(317, 108);
            this.lblDauer.Name = "lblDauer";
            this.lblDauer.Size = new System.Drawing.Size(47, 17);
            this.lblDauer.TabIndex = 7;
            this.lblDauer.Text = "Dauer";
            // 
            // lblAnkunft
            // 
            this.lblAnkunft.AutoSize = true;
            this.lblAnkunft.Location = new System.Drawing.Point(183, 108);
            this.lblAnkunft.Name = "lblAnkunft";
            this.lblAnkunft.Size = new System.Drawing.Size(56, 17);
            this.lblAnkunft.TabIndex = 6;
            this.lblAnkunft.Text = "Ankunft";
            // 
            // lblAbfahrt
            // 
            this.lblAbfahrt.AutoSize = true;
            this.lblAbfahrt.Location = new System.Drawing.Point(85, 108);
            this.lblAbfahrt.Name = "lblAbfahrt";
            this.lblAbfahrt.Size = new System.Drawing.Size(54, 17);
            this.lblAbfahrt.TabIndex = 5;
            this.lblAbfahrt.Text = "Abfahrt";
            // 
            // farhplanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 418);
            this.Controls.Add(this.lblDauer);
            this.Controls.Add(this.lblAnkunft);
            this.Controls.Add(this.lblAbfahrt);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.libFahrplan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "farhplanForm";
            this.Text = "farhplanForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox libFahrplan;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblDauer;
        private System.Windows.Forms.Label lblAnkunft;
        private System.Windows.Forms.Label lblAbfahrt;
    }
}