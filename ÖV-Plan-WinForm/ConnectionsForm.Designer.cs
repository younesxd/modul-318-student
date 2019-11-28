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
            this.SuspendLayout();
            // 
            // libConnections
            // 
            this.libConnections.FormattingEnabled = true;
            this.libConnections.Location = new System.Drawing.Point(26, 51);
            this.libConnections.Name = "libConnections";
            this.libConnections.Size = new System.Drawing.Size(339, 186);
            this.libConnections.TabIndex = 0;
            // 
            // ConnectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 290);
            this.Controls.Add(this.libConnections);
            this.Name = "ConnectionsForm";
            this.Text = "Connections";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox libConnections;
    }
}