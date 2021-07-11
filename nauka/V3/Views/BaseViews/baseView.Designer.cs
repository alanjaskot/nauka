
namespace nauka.V3.BaseViews
{
    partial class baseView
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelBottom.Controls.Add(this.buttonLogout);
            this.panelBottom.Controls.Add(this.buttonExit);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 930);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1898, 94);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(1552, 35);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(112, 34);
            this.buttonLogout.TabIndex = 1;
            this.buttonLogout.Text = "Anuluj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1701, 35);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(112, 34);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "OK";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1898, 150);
            this.panelTop.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.SystemColors.Highlight;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1898, 150);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "AppTitle";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 150);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(300, 780);
            this.panelLeftMenu.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(300, 150);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1598, 780);
            this.panelMain.TabIndex = 3;
            // 
            // baseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLeftMenu);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.Name = "baseView";
            this.Text = "baseView";
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Panel panelBottom;
        protected internal System.Windows.Forms.Button buttonLogout;
        protected internal System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        protected internal System.Windows.Forms.Panel panelLeftMenu;
        protected internal System.Windows.Forms.Panel panelMain;
    }
}