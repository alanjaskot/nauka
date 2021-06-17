
namespace nauka.V2.Views.Sections.Views
{
    partial class SectionView
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
            this.labelSectionName = new System.Windows.Forms.Label();
            this.textBoxNewSectionName = new System.Windows.Forms.TextBox();
            this.buttonNewSection = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSectionName
            // 
            this.labelSectionName.AutoSize = true;
            this.labelSectionName.Location = new System.Drawing.Point(98, 60);
            this.labelSectionName.Name = "labelSectionName";
            this.labelSectionName.Size = new System.Drawing.Size(107, 25);
            this.labelSectionName.TabIndex = 0;
            this.labelSectionName.Text = "nowa sekcja";
            // 
            // textBoxNewSectionName
            // 
            this.textBoxNewSectionName.Location = new System.Drawing.Point(247, 60);
            this.textBoxNewSectionName.Name = "textBoxNewSectionName";
            this.textBoxNewSectionName.Size = new System.Drawing.Size(259, 31);
            this.textBoxNewSectionName.TabIndex = 1;
            // 
            // buttonNewSection
            // 
            this.buttonNewSection.Location = new System.Drawing.Point(247, 133);
            this.buttonNewSection.Name = "buttonNewSection";
            this.buttonNewSection.Size = new System.Drawing.Size(112, 34);
            this.buttonNewSection.TabIndex = 2;
            this.buttonNewSection.Text = "Ok";
            this.buttonNewSection.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(394, 133);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // SectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 200);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNewSection);
            this.Controls.Add(this.textBoxNewSectionName);
            this.Controls.Add(this.labelSectionName);
            this.Name = "SectionView";
            this.Text = "SectionView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSectionName;
        protected internal System.Windows.Forms.TextBox textBoxNewSectionName;
        protected internal System.Windows.Forms.Button buttonNewSection;
        protected internal System.Windows.Forms.Button buttonCancel;
    }
}