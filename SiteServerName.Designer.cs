namespace PatchMaster
{
    partial class f_siteserverName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(f_siteserverName));
            this.b_OK = new System.Windows.Forms.Button();
            this.tb_siteserverName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_OK
            // 
            this.b_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_OK.Location = new System.Drawing.Point(131, 47);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 0;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // tb_siteserverName
            // 
            this.tb_siteserverName.Location = new System.Drawing.Point(12, 12);
            this.tb_siteserverName.Name = "tb_siteserverName";
            this.tb_siteserverName.Size = new System.Drawing.Size(306, 20);
            this.tb_siteserverName.TabIndex = 1;
            // 
            // f_siteserverName
            // 
            this.AcceptButton = this.b_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.b_OK;
            this.ClientSize = new System.Drawing.Size(349, 82);
            this.Controls.Add(this.tb_siteserverName);
            this.Controls.Add(this.b_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(365, 121);
            this.MinimumSize = new System.Drawing.Size(365, 121);
            this.Name = "f_siteserverName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter SMS Provider \\ Site name";
            this.Load += new System.EventHandler(this.F_siteserverName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.TextBox tb_siteserverName;
    }
}