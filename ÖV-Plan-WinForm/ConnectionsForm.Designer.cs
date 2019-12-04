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
            this.lblTitel = new System.Windows.Forms.Label();
            this.livConnections = new System.Windows.Forms.ListView();
            this.cAbfahrtc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            // livConnections
            // 
            this.livConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cAbfahrtc,
            this.cAnkunft,
            this.cBus,
            this.cDauer});
            this.livConnections.HideSelection = false;
            this.livConnections.Location = new System.Drawing.Point(57, 113);
            this.livConnections.Name = "livConnections";
            this.livConnections.Size = new System.Drawing.Size(600, 276);
            this.livConnections.TabIndex = 3;
            this.livConnections.UseCompatibleStateImageBehavior = false;
            this.livConnections.View = System.Windows.Forms.View.Details;
            // 
            // cAbfahrtc
            // 
            this.cAbfahrtc.Text = "Abfahrt";
            this.cAbfahrtc.Width = 120;
            // 
            // cAnkunft
            // 
            this.cAnkunft.Text = "Ankunft";
            this.cAnkunft.Width = 120;
            // 
            // cDauer
            // 
            this.cDauer.DisplayIndex = 3;
            this.cDauer.Text = "Dauer";
            this.cDauer.Width = 120;
            // 
            // cBus
            // 
            this.cBus.DisplayIndex = 2;
            this.cBus.Text = "Bus/ Zug Nummer";
            this.cBus.Width = 120;
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 418);
            this.Controls.Add(this.livConnections);
            this.Controls.Add(this.lblTitel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConnectionsForm";
            this.Text = "Verbindungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ListView livConnections;
        private System.Windows.Forms.ColumnHeader cAbfahrtc;
        private System.Windows.Forms.ColumnHeader cAnkunft;
        private System.Windows.Forms.ColumnHeader cBus;
        private System.Windows.Forms.ColumnHeader cDauer;
    }
}