
namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    partial class VacationPermissionUC
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
            this.dataGridViewVacationApplications = new System.Windows.Forms.DataGridView();
            this.labelVacationApplicationSections = new System.Windows.Forms.Label();
            this.buttonApprove = new System.Windows.Forms.Button();
            this.buttonDenay = new System.Windows.Forms.Button();
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.buttonChooseSection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationApplications)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacationApplications
            // 
            this.dataGridViewVacationApplications.AllowUserToAddRows = false;
            this.dataGridViewVacationApplications.AllowUserToDeleteRows = false;
            this.dataGridViewVacationApplications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacationApplications.Location = new System.Drawing.Point(130, 157);
            this.dataGridViewVacationApplications.Name = "dataGridViewVacationApplications";
            this.dataGridViewVacationApplications.ReadOnly = true;
            this.dataGridViewVacationApplications.RowHeadersWidth = 62;
            this.dataGridViewVacationApplications.RowTemplate.Height = 33;
            this.dataGridViewVacationApplications.Size = new System.Drawing.Size(1000, 531);
            this.dataGridViewVacationApplications.TabIndex = 0;
            // 
            // labelVacationApplicationSections
            // 
            this.labelVacationApplicationSections.AutoSize = true;
            this.labelVacationApplicationSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVacationApplicationSections.Location = new System.Drawing.Point(130, 69);
            this.labelVacationApplicationSections.Name = "labelVacationApplicationSections";
            this.labelVacationApplicationSections.Size = new System.Drawing.Size(71, 30);
            this.labelVacationApplicationSections.TabIndex = 1;
            this.labelVacationApplicationSections.Text = "Działy";
            // 
            // buttonApprove
            // 
            this.buttonApprove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonApprove.Location = new System.Drawing.Point(1240, 484);
            this.buttonApprove.Name = "buttonApprove";
            this.buttonApprove.Size = new System.Drawing.Size(275, 56);
            this.buttonApprove.TabIndex = 3;
            this.buttonApprove.Text = "Zgoda";
            this.buttonApprove.UseVisualStyleBackColor = true;
            // 
            // buttonDenay
            // 
            this.buttonDenay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDenay.Location = new System.Drawing.Point(1240, 632);
            this.buttonDenay.Name = "buttonDenay";
            this.buttonDenay.Size = new System.Drawing.Size(275, 56);
            this.buttonDenay.TabIndex = 4;
            this.buttonDenay.Text = "Odmowa";
            this.buttonDenay.UseVisualStyleBackColor = true;
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(234, 66);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(349, 38);
            this.comboBoxSections.TabIndex = 7;
            // 
            // buttonChooseSection
            // 
            this.buttonChooseSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseSection.Location = new System.Drawing.Point(1240, 66);
            this.buttonChooseSection.Name = "buttonChooseSection";
            this.buttonChooseSection.Size = new System.Drawing.Size(275, 56);
            this.buttonChooseSection.TabIndex = 8;
            this.buttonChooseSection.Text = "Wybierz dział";
            this.buttonChooseSection.UseVisualStyleBackColor = true;
            // 
            // VacationPermissionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChooseSection);
            this.Controls.Add(this.comboBoxSections);
            this.Controls.Add(this.buttonDenay);
            this.Controls.Add(this.buttonApprove);
            this.Controls.Add(this.labelVacationApplicationSections);
            this.Controls.Add(this.dataGridViewVacationApplications);
            this.Name = "VacationPermissionUC";
            this.Size = new System.Drawing.Size(1598, 780);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationApplications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Label labelVacationApplicationSections;
        protected internal System.Windows.Forms.Button buttonApprove;
        protected internal System.Windows.Forms.Button buttonDenay;
        protected internal System.Windows.Forms.DataGridView dataGridViewVacationApplications;
        protected internal System.Windows.Forms.ComboBox comboBoxSections;
        protected internal System.Windows.Forms.Button buttonChooseSection;
    }
}
