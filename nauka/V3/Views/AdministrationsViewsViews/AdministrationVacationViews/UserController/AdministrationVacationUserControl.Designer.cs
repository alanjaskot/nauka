
namespace nauka.V3.Views.AdministrationsViewsViews.AdministrationVacationViews.UserController
{
    partial class AdministrationVacationUserControl
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
            this.dataGridViewVacationEmployeeCalendar = new System.Windows.Forms.DataGridView();
            this.buttonPreviousMonth = new System.Windows.Forms.Button();
            this.labelMonth = new System.Windows.Forms.Label();
            this.buttonNextMonth = new System.Windows.Forms.Button();
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.buttonVacationApplication = new System.Windows.Forms.Button();
            this.buttonAddEdit = new System.Windows.Forms.Button();
            this.menageVacationApplicatoinUserControl1 = new nauka.V3.Views.UserControllers.MenageVacationApplicatoinUserControl();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationEmployeeCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacationEmployeeCalendar
            // 
            this.dataGridViewVacationEmployeeCalendar.AllowUserToAddRows = false;
            this.dataGridViewVacationEmployeeCalendar.AllowUserToDeleteRows = false;
            this.dataGridViewVacationEmployeeCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacationEmployeeCalendar.Location = new System.Drawing.Point(38, 85);
            this.dataGridViewVacationEmployeeCalendar.Name = "dataGridViewVacationEmployeeCalendar";
            this.dataGridViewVacationEmployeeCalendar.ReadOnly = true;
            this.dataGridViewVacationEmployeeCalendar.RowHeadersWidth = 62;
            this.dataGridViewVacationEmployeeCalendar.RowTemplate.Height = 33;
            this.dataGridViewVacationEmployeeCalendar.Size = new System.Drawing.Size(946, 361);
            this.dataGridViewVacationEmployeeCalendar.TabIndex = 0;
            // 
            // buttonPreviousMonth
            // 
            this.buttonPreviousMonth.Location = new System.Drawing.Point(556, 28);
            this.buttonPreviousMonth.Name = "buttonPreviousMonth";
            this.buttonPreviousMonth.Size = new System.Drawing.Size(130, 34);
            this.buttonPreviousMonth.TabIndex = 1;
            this.buttonPreviousMonth.Text = "<<";
            this.buttonPreviousMonth.UseVisualStyleBackColor = true;
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(780, 33);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(70, 25);
            this.labelMonth.TabIndex = 3;
            this.labelMonth.Text = "miesiąc";
            // 
            // buttonNextMonth
            // 
            this.buttonNextMonth.Location = new System.Drawing.Point(934, 33);
            this.buttonNextMonth.Name = "buttonNextMonth";
            this.buttonNextMonth.Size = new System.Drawing.Size(130, 34);
            this.buttonNextMonth.TabIndex = 4;
            this.buttonNextMonth.Text = ">>";
            this.buttonNextMonth.UseVisualStyleBackColor = true;
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(38, 25);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(264, 33);
            this.comboBoxSections.TabIndex = 5;
            this.comboBoxSections.Text = "Wydziały";
            // 
            // buttonVacationApplication
            // 
            this.buttonVacationApplication.Location = new System.Drawing.Point(334, 28);
            this.buttonVacationApplication.Name = "buttonVacationApplication";
            this.buttonVacationApplication.Size = new System.Drawing.Size(186, 34);
            this.buttonVacationApplication.TabIndex = 6;
            this.buttonVacationApplication.Text = "wnioski o urlop";
            this.buttonVacationApplication.UseVisualStyleBackColor = true;
            // 
            // buttonAddEdit
            // 
            this.buttonAddEdit.Location = new System.Drawing.Point(991, 384);
            this.buttonAddEdit.Name = "buttonAddEdit";
            this.buttonAddEdit.Size = new System.Drawing.Size(70, 60);
            this.buttonAddEdit.TabIndex = 7;
            this.buttonAddEdit.Text = "+";
            this.buttonAddEdit.UseVisualStyleBackColor = true;
            // 
            // menageVacationApplicatoinUserControl1
            // 
            this.menageVacationApplicatoinUserControl1.Location = new System.Drawing.Point(494, 195);
            this.menageVacationApplicatoinUserControl1.Name = "menageVacationApplicatoinUserControl1";
            this.menageVacationApplicatoinUserControl1.Size = new System.Drawing.Size(491, 249);
            this.menageVacationApplicatoinUserControl1.TabIndex = 8;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(990, 298);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(70, 60);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "E";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(988, 220);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(70, 60);
            this.buttonRemove.TabIndex = 10;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // AdministrationVacationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.menageVacationApplicatoinUserControl1);
            this.Controls.Add(this.buttonAddEdit);
            this.Controls.Add(this.buttonVacationApplication);
            this.Controls.Add(this.comboBoxSections);
            this.Controls.Add(this.buttonNextMonth);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.buttonPreviousMonth);
            this.Controls.Add(this.dataGridViewVacationEmployeeCalendar);
            this.Name = "AdministrationVacationUserControl";
            this.Size = new System.Drawing.Size(1076, 473);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacationEmployeeCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Button buttonPreviousMonth;
        protected internal System.Windows.Forms.Label labelMonth;
        protected internal System.Windows.Forms.Button buttonNextMonth;
        protected internal System.Windows.Forms.ComboBox comboBoxSections;
        protected internal System.Windows.Forms.DataGridView dataGridViewVacationEmployeeCalendar;
        protected internal System.Windows.Forms.Button buttonVacationApplication;
        protected internal System.Windows.Forms.Button buttonAddEdit;
        private Views.UserControllers.MenageVacationApplicatoinUserControl menageVacationApplicatoinUserControl1;
        protected internal System.Windows.Forms.Button buttonEdit;
        protected internal System.Windows.Forms.Button buttonRemove;
    }
}
