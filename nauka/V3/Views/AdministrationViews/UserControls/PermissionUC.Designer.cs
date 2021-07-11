
namespace nauka.V3.Views.AdministrationViews.UsereControls
{
    partial class PermissionUC
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
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.labelSections = new System.Windows.Forms.Label();
            this.labelPermission = new System.Windows.Forms.Label();
            this.checkBoxVacations = new System.Windows.Forms.CheckBox();
            this.checkBoxEmployee = new System.Windows.Forms.CheckBox();
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.buttonDIsplayEmployees = new System.Windows.Forms.Button();
            this.buttonChangePermisson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AllowUserToAddRows = false;
            this.dataGridViewEmployees.AllowUserToDeleteRows = false;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(223, 168);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.ReadOnly = true;
            this.dataGridViewEmployees.RowHeadersWidth = 62;
            this.dataGridViewEmployees.RowTemplate.Height = 33;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(850, 530);
            this.dataGridViewEmployees.TabIndex = 0;
            // 
            // labelSections
            // 
            this.labelSections.AutoSize = true;
            this.labelSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSections.Location = new System.Drawing.Point(44, 82);
            this.labelSections.Name = "labelSections";
            this.labelSections.Size = new System.Drawing.Size(71, 30);
            this.labelSections.TabIndex = 2;
            this.labelSections.Text = "Działy";
            // 
            // labelPermission
            // 
            this.labelPermission.AutoSize = true;
            this.labelPermission.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPermission.Location = new System.Drawing.Point(1165, 245);
            this.labelPermission.Name = "labelPermission";
            this.labelPermission.Size = new System.Drawing.Size(213, 32);
            this.labelPermission.TabIndex = 3;
            this.labelPermission.Text = "Nadaj uprawnienia";
            // 
            // checkBoxVacations
            // 
            this.checkBoxVacations.AutoSize = true;
            this.checkBoxVacations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxVacations.Location = new System.Drawing.Point(1165, 361);
            this.checkBoxVacations.Name = "checkBoxVacations";
            this.checkBoxVacations.Size = new System.Drawing.Size(144, 36);
            this.checkBoxVacations.TabIndex = 4;
            this.checkBoxVacations.Text = "   wakacje";
            this.checkBoxVacations.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployee
            // 
            this.checkBoxEmployee.AutoSize = true;
            this.checkBoxEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxEmployee.Location = new System.Drawing.Point(1165, 473);
            this.checkBoxEmployee.Name = "checkBoxEmployee";
            this.checkBoxEmployee.Size = new System.Drawing.Size(180, 36);
            this.checkBoxEmployee.TabIndex = 5;
            this.checkBoxEmployee.Text = "   pracownicy";
            this.checkBoxEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(223, 82);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(349, 38);
            this.comboBoxSections.TabIndex = 7;
            // 
            // buttonDIsplayEmployees
            // 
            this.buttonDIsplayEmployees.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDIsplayEmployees.Location = new System.Drawing.Point(1142, 82);
            this.buttonDIsplayEmployees.Name = "buttonDIsplayEmployees";
            this.buttonDIsplayEmployees.Size = new System.Drawing.Size(236, 66);
            this.buttonDIsplayEmployees.TabIndex = 8;
            this.buttonDIsplayEmployees.Text = "Pokaż pracowników";
            this.buttonDIsplayEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonChangePermisson
            // 
            this.buttonChangePermisson.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChangePermisson.Location = new System.Drawing.Point(1142, 632);
            this.buttonChangePermisson.Name = "buttonChangePermisson";
            this.buttonChangePermisson.Size = new System.Drawing.Size(236, 66);
            this.buttonChangePermisson.TabIndex = 9;
            this.buttonChangePermisson.Text = "Zmień uprawnienia";
            this.buttonChangePermisson.UseVisualStyleBackColor = true;
            // 
            // PermissionUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonChangePermisson);
            this.Controls.Add(this.buttonDIsplayEmployees);
            this.Controls.Add(this.comboBoxSections);
            this.Controls.Add(this.checkBoxEmployee);
            this.Controls.Add(this.checkBoxVacations);
            this.Controls.Add(this.labelPermission);
            this.Controls.Add(this.labelSections);
            this.Controls.Add(this.dataGridViewEmployees);
            this.Name = "PermissionUC";
            this.Size = new System.Drawing.Size(1598, 780);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DataGridView dataGridViewEmployees;
        private System.Windows.Forms.Label labelSections;
        private System.Windows.Forms.Label labelPermission;
        protected internal System.Windows.Forms.CheckBox checkBoxVacations;
        protected internal System.Windows.Forms.CheckBox checkBoxEmployee;
        protected internal System.Windows.Forms.ComboBox comboBoxSections;
        protected internal System.Windows.Forms.Button buttonDIsplayEmployees;
        protected internal System.Windows.Forms.Button buttonChangePermisson;
    }
}
