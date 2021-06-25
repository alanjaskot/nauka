
namespace nauka.V3.Views.UserViews.UserControls
{
    partial class NoPermissionUC
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
            this.labelNoPermission = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNoPermission
            // 
            this.labelNoPermission.AutoSize = true;
            this.labelNoPermission.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNoPermission.Location = new System.Drawing.Point(670, 308);
            this.labelNoPermission.Name = "labelNoPermission";
            this.labelNoPermission.Size = new System.Drawing.Size(241, 38);
            this.labelNoPermission.TabIndex = 0;
            this.labelNoPermission.Text = "Brak uprawnień! ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(584, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proszę opuścić Panel Administratora";
            // 
            // NoPermissionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNoPermission);
            this.Name = "NoPermissionUC";
            this.Size = new System.Drawing.Size(1596, 780);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNoPermission;
        private System.Windows.Forms.Label label1;
    }
}
