
namespace nauka.V3.Views
{
    partial class SectionUserControl
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
            this.labelSectionTitle = new System.Windows.Forms.Label();
            this.labelSectionName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSectionTitle
            // 
            this.labelSectionTitle.AutoSize = true;
            this.labelSectionTitle.Location = new System.Drawing.Point(83, 138);
            this.labelSectionTitle.Name = "labelSectionTitle";
            this.labelSectionTitle.Size = new System.Drawing.Size(178, 25);
            this.labelSectionTitle.TabIndex = 0;
            this.labelSectionTitle.Text = "Pracujesz w wydziale:";
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Location = new System.Drawing.Point(309, 138);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(175, 25);
            this.labelSectionName.TabIndex = 1;
            this.labelSectionName.Text = "tutaj nazwa wydziału";
            // 
            // SectionUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSectionName);
            this.Controls.Add(this.labelSectionTitle);
            this.Name = "SectionUserControl";
            this.Size = new System.Drawing.Size(620, 372);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSectionTitle;
        private System.Windows.Forms.Label labelSectionName;
    }
}
