namespace PatchMaster
{
    partial class MultiSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiSelect));
            this.cbl_Items = new System.Windows.Forms.CheckedListBox();
            this.b_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbl_Items
            // 
            this.cbl_Items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbl_Items.FormattingEnabled = true;
            this.cbl_Items.Location = new System.Drawing.Point(-3, -2);
            this.cbl_Items.Name = "cbl_Items";
            this.cbl_Items.Size = new System.Drawing.Size(302, 229);
            this.cbl_Items.Sorted = true;
            this.cbl_Items.TabIndex = 0;
            // 
            // b_OK
            // 
            this.b_OK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_OK.Location = new System.Drawing.Point(114, 235);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 1;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.button1_Click);
            // 
            // MultiSelect
            // 
            this.AcceptButton = this.b_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_OK;
            this.ClientSize = new System.Drawing.Size(299, 270);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.cbl_Items);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MultiSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selection";
            this.Load += new System.EventHandler(this.MultiSelect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cbl_Items;
        private System.Windows.Forms.Button b_OK;
    }
}