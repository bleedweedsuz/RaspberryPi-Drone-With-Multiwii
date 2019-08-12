namespace PIDrone
{
    partial class CustomButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainBackPanel = new System.Windows.Forms.Panel();
            this.BorderPabel = new System.Windows.Forms.Panel();
            this.TitleBox = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.SelectedBox = new System.Windows.Forms.PictureBox();
            this.MainBackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainBackPanel
            // 
            this.MainBackPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.MainBackPanel.Controls.Add(this.IconBox);
            this.MainBackPanel.Controls.Add(this.SelectedBox);
            this.MainBackPanel.Controls.Add(this.BorderPabel);
            this.MainBackPanel.Controls.Add(this.TitleBox);
            this.MainBackPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainBackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBackPanel.Location = new System.Drawing.Point(0, 0);
            this.MainBackPanel.Name = "MainBackPanel";
            this.MainBackPanel.Size = new System.Drawing.Size(220, 40);
            this.MainBackPanel.TabIndex = 2;
            this.MainBackPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainBackPanel_MouseClick);
            this.MainBackPanel.MouseLeave += new System.EventHandler(this.MainBackPanel_MouseLeave);
            this.MainBackPanel.MouseHover += new System.EventHandler(this.MainBackPanel_MouseHover);
            // 
            // BorderPabel
            // 
            this.BorderPabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(145)))), ((int)(((byte)(176)))));
            this.BorderPabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BorderPabel.Location = new System.Drawing.Point(0, 37);
            this.BorderPabel.Name = "BorderPabel";
            this.BorderPabel.Size = new System.Drawing.Size(220, 3);
            this.BorderPabel.TabIndex = 0;
            // 
            // TitleBox
            // 
            this.TitleBox.AutoSize = true;
            this.TitleBox.BackColor = System.Drawing.Color.Transparent;
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.TitleBox.Location = new System.Drawing.Point(40, 11);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(111, 16);
            this.TitleBox.TabIndex = 0;
            this.TitleBox.Text = "suz-custombutton";
            this.TitleBox.Click += new System.EventHandler(this.TitleBox_Click);
            this.TitleBox.MouseLeave += new System.EventHandler(this.MainBackPanel_MouseLeave);
            this.TitleBox.MouseHover += new System.EventHandler(this.MainBackPanel_MouseHover);
            // 
            // IconBox
            // 
            this.IconBox.Location = new System.Drawing.Point(3, 2);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(33, 33);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconBox.TabIndex = 1;
            this.IconBox.TabStop = false;
            // 
            // SelectedBox
            // 
            this.SelectedBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(163)))), ((int)(((byte)(165)))));
            this.SelectedBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.SelectedBox.Location = new System.Drawing.Point(212, 0);
            this.SelectedBox.Name = "SelectedBox";
            this.SelectedBox.Size = new System.Drawing.Size(8, 37);
            this.SelectedBox.TabIndex = 2;
            this.SelectedBox.TabStop = false;
            this.SelectedBox.Visible = false;
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainBackPanel);
            this.MaximumSize = new System.Drawing.Size(220, 40);
            this.MinimumSize = new System.Drawing.Size(220, 40);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(220, 40);
            this.MainBackPanel.ResumeLayout(false);
            this.MainBackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainBackPanel;
        private System.Windows.Forms.Panel BorderPabel;
        private System.Windows.Forms.Label TitleBox;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.PictureBox SelectedBox;
    }
}
