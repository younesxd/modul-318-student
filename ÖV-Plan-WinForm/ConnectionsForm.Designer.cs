namespace ÖV_Plan_WinForm
{
    partial class ConnectionsForm
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
            this.libConnections = new System.Windows.Forms.ListBox();
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblAbfahrt = new System.Windows.Forms.Label();
            this.lblAnkunft = new System.Windows.Forms.Label();
            this.lblDauer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // libConnections
            // 
            this.libConnections.FormattingEnabled = true;
            this.libConnections.ItemHeight = 16;
            this.libConnections.Location = new System.Drawing.Point(57, 129);
            this.libConnections.Margin = new System.Windows.Forms.Padding(4);
            this.libConnections.Name = "libConnections";
            this.libConnections.Size = new System.Drawing.Size(600, 260);
            this.libConnections.TabIndex = 0;
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(137, 33);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(433, 69);
            this.lblTitel.TabIndex = 1;
            this.lblTitel.Text = "VERBINDUNGEN";
            // 
            // lblAbfahrt
            // 
            this.lblAbfahrt.AutoSize = true;
            this.lblAbfahrt.Location = new System.Drawing.Point(84, 108);
            this.lblAbfahrt.Name = "lblAbfahrt";
            this.lblAbfahrt.Size = new System.Drawing.Size(54, 17);
            this.lblAbfahrt.TabIndex = 2;
            this.lblAbfahrt.Text = "Abfahrt";
            // 
            // lblAnkunft
            // 
            this.lblAnkunft.AutoSize = true;
            this.lblAnkunft.Location = new System.Drawing.Point(182, 108);
            this.lblAnkunft.Name = "lblAnkunft";
            this.lblAnkunft.Size = new System.Drawing.Size(56, 17);
            this.lblAnkunft.TabIndex = 3;
            this.lblAnkunft.Text = "Ankunft";
            // 
            // lblDauer
            // 
            this.lblDauer.AutoSize = true;
            this.lblDauer.Location = new System.Drawing.Point(316, 108);
            this.lblDauer.Name = "lblDauer";
            this.lblDauer.Size = new System.Drawing.Size(47, 17);
            this.lblDauer.TabIndex = 4;
            this.lblDauer.Text = "Dauer";
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 418);
            this.Controls.Add(this.lblDauer);
            this.Controls.Add(this.lblAnkunft);
            this.Controls.Add(this.lblAbfahrt);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.libConnections);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionsForm";
            this.Text = "Connections";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox libConnections;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblAbfahrt;
        private System.Windows.Forms.Label lblAnkunft;
        private System.Windows.Forms.Label lblDauer;
    }
}