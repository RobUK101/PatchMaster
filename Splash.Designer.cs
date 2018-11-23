namespace PatchMaster
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.pb_thugLife = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.l_buildVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.b_triggerserverName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_thugLife)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_thugLife
            // 
            this.pb_thugLife.Location = new System.Drawing.Point(378, 18);
            this.pb_thugLife.Name = "pb_thugLife";
            this.pb_thugLife.Size = new System.Drawing.Size(128, 128);
            this.pb_thugLife.TabIndex = 0;
            this.pb_thugLife.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "PatchMaster";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // l_buildVersion
            // 
            this.l_buildVersion.AutoSize = true;
            this.l_buildVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_buildVersion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l_buildVersion.Location = new System.Drawing.Point(16, 58);
            this.l_buildVersion.Name = "l_buildVersion";
            this.l_buildVersion.Size = new System.Drawing.Size(110, 25);
            this.l_buildVersion.TabIndex = 2;
            this.l_buildVersion.Text = "Version 1.x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(18, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(338, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "By Robert Marshall - EM MVP and SMSMarshall consultant - Freeware";
            // 
            // b_triggerserverName
            // 
            this.b_triggerserverName.Location = new System.Drawing.Point(330, 18);
            this.b_triggerserverName.Name = "b_triggerserverName";
            this.b_triggerserverName.Size = new System.Drawing.Size(26, 23);
            this.b_triggerserverName.TabIndex = 4;
            this.b_triggerserverName.Text = "...";
            this.b_triggerserverName.UseVisualStyleBackColor = true;
            this.b_triggerserverName.Click += new System.EventHandler(this.b_triggerserverName_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(518, 166);
            this.ControlBox = false;
            this.Controls.Add(this.b_triggerserverName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.l_buildVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_thugLife);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_thugLife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_thugLife;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label l_buildVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_triggerserverName;
    }
}