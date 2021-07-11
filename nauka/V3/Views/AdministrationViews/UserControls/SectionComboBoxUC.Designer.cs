
namespace nauka.V3.Views.AdministrationViews.UserControls
{
    partial class SectionComboBoxUC
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
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(42, 23);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(350, 38);
            this.comboBoxSections.TabIndex = 0;
            // 
            // SectionComboBocUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSections);
            this.Name = "SectionComboBocUC";
            this.Size = new System.Drawing.Size(424, 90);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.ComboBox comboBoxSections;
    }
}
