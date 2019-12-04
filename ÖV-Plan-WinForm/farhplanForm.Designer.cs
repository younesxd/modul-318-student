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
            this.lblTitel = new System.Windows.Forms.Label();
            this.livFahrplan = new System.Windows.Forms.ListView();
            this.cAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cRichtung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cBus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
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
            // livFahrplan
            // 
            this.livFahrplan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cAbfahrt,
            this.cRichtung,
            this.cBus});
            this.livFahrplan.HideSelection = false;
            this.livFahrplan.Location = new System.Drawing.Point(57, 113);
            this.livFahrplan.Name = "livFahrplan";
            this.livFahrplan.Size = new System.Drawing.Size(600, 276);
            this.livFahrplan.TabIndex = 2;
            this.livFahrplan.UseCompatibleStateImageBehavior = false;
            this.livFahrplan.View = System.Windows.Forms.View.Details;
            // 
            // cAbfahrt
            // 
            this.cAbfahrt.Text = "Abfahrt";
            this.cAbfahrt.Width = 150;
            // 
            // cRichtung
            // 
            this.cRichtung.Text = "Richtung";
            this.cRichtung.Width = 150;
            // 
            // cBus
            // 
            this.cBus.Text = "Bus/ Zug Nummer";
            this.cBus.Width = 150;
            // 
            // farhplanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 418);
            this.Controls.Add(this.livFahrplan);
            this.Controls.Add(this.lblTitel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "farhplanForm";
            this.Text = "Fahrplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.ListView livFahrplan;
        private System.Windows.Forms.ColumnHeader cAbfahrt;
        private System.Windows.Forms.ColumnHeader cRichtung;
        private System.Windows.Forms.ColumnHeader cBus;
    }
}