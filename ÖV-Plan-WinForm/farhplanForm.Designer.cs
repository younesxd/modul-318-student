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
            this.SuspendLayout();
            // 
            // libFahrplan
            // 
            this.libFahrplan.FormattingEnabled = true;
            this.libFahrplan.Location = new System.Drawing.Point(30, 31);
            this.libFahrplan.Name = "libFahrplan";
            this.libFahrplan.Size = new System.Drawing.Size(210, 238);
            this.libFahrplan.TabIndex = 0;
            // 
            // farhplanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.libFahrplan);
            this.Name = "farhplanForm";
            this.Text = "farhplanForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox libFahrplan;
    }
}