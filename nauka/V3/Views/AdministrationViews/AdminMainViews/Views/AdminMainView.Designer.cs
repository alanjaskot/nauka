
namespace nauka.V3.Views.AdministrationViews.AdminMainViews.Views
{
    partial class AdminMainView
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
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPageSections = new System.Windows.Forms.TabPage();
            this.buttonDeleteSection = new System.Windows.Forms.Button();
            this.buttonEditSection = new System.Windows.Forms.Button();
            this.buttonAddSection = new System.Windows.Forms.Button();
            this.labelSectionList = new System.Windows.Forms.Label();
            this.listViewSections = new System.Windows.Forms.ListView();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.buttonUpdateEmployee = new System.Windows.Forms.Button();
            this.comboBoxSections = new System.Windows.Forms.ComboBox();
            this.buttonDisplayEmployees = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.labelSections = new System.Windows.Forms.Label();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.tabPageAbsence = new System.Windows.Forms.TabPage();
            this.buttonChooseSectionAbsence = new System.Windows.Forms.Button();
            this.comboBoxSectionAbsence = new System.Windows.Forms.ComboBox();
            this.buttonDeleteAbsence = new System.Windows.Forms.Button();
            this.buttonAddAbsence = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewVacations = new System.Windows.Forms.DataGridView();
            this.tabPageMenageVacApp = new System.Windows.Forms.TabPage();
            this.tabPagePermisson = new System.Windows.Forms.TabPage();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabControlAdmin.SuspendLayout();
            this.tabPageSections.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            this.tabPageAbsence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Text = "Wyloguj";
            // 
            // buttonExit
            // 
            this.buttonExit.Text = "Wyjście";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlAdmin);
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Controls.Add(this.tabPageSections);
            this.tabControlAdmin.Controls.Add(this.tabPageEmployees);
            this.tabControlAdmin.Controls.Add(this.tabPageAbsence);
            this.tabControlAdmin.Controls.Add(this.tabPageMenageVacApp);
            this.tabControlAdmin.Controls.Add(this.tabPagePermisson);
            this.tabControlAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 0);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1598, 780);
            this.tabControlAdmin.TabIndex = 0;
            // 
            // tabPageSections
            // 
            this.tabPageSections.Controls.Add(this.buttonDeleteSection);
            this.tabPageSections.Controls.Add(this.buttonEditSection);
            this.tabPageSections.Controls.Add(this.buttonAddSection);
            this.tabPageSections.Controls.Add(this.labelSectionList);
            this.tabPageSections.Controls.Add(this.listViewSections);
            this.tabPageSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageSections.Location = new System.Drawing.Point(4, 39);
            this.tabPageSections.Name = "tabPageSections";
            this.tabPageSections.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSections.Size = new System.Drawing.Size(1590, 737);
            this.tabPageSections.TabIndex = 0;
            this.tabPageSections.Text = "Jednostki";
            this.tabPageSections.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSection
            // 
            this.buttonDeleteSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteSection.Location = new System.Drawing.Point(1001, 500);
            this.buttonDeleteSection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteSection.Name = "buttonDeleteSection";
            this.buttonDeleteSection.Size = new System.Drawing.Size(218, 89);
            this.buttonDeleteSection.TabIndex = 9;
            this.buttonDeleteSection.Text = "Usuń jednostkę";
            this.buttonDeleteSection.UseVisualStyleBackColor = true;
            // 
            // buttonEditSection
            // 
            this.buttonEditSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonEditSection.Location = new System.Drawing.Point(1001, 308);
            this.buttonEditSection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditSection.Name = "buttonEditSection";
            this.buttonEditSection.Size = new System.Drawing.Size(218, 89);
            this.buttonEditSection.TabIndex = 8;
            this.buttonEditSection.Text = "Zmień nazwę";
            this.buttonEditSection.UseVisualStyleBackColor = true;
            // 
            // buttonAddSection
            // 
            this.buttonAddSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddSection.Location = new System.Drawing.Point(1001, 122);
            this.buttonAddSection.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddSection.Name = "buttonAddSection";
            this.buttonAddSection.Size = new System.Drawing.Size(218, 89);
            this.buttonAddSection.TabIndex = 7;
            this.buttonAddSection.Text = "Nowa jednostka";
            this.buttonAddSection.UseVisualStyleBackColor = true;
            // 
            // labelSectionList
            // 
            this.labelSectionList.AutoSize = true;
            this.labelSectionList.Location = new System.Drawing.Point(372, 46);
            this.labelSectionList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSectionList.Name = "labelSectionList";
            this.labelSectionList.Size = new System.Drawing.Size(155, 30);
            this.labelSectionList.TabIndex = 6;
            this.labelSectionList.Text = "Lista jednostek";
            // 
            // listViewSections
            // 
            this.listViewSections.AutoArrange = false;
            this.listViewSections.HideSelection = false;
            this.listViewSections.Location = new System.Drawing.Point(372, 122);
            this.listViewSections.Margin = new System.Windows.Forms.Padding(4);
            this.listViewSections.Name = "listViewSections";
            this.listViewSections.ShowGroups = false;
            this.listViewSections.Size = new System.Drawing.Size(309, 569);
            this.listViewSections.TabIndex = 5;
            this.listViewSections.UseCompatibleStateImageBehavior = false;
            this.listViewSections.View = System.Windows.Forms.View.List;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.Controls.Add(this.buttonUpdateEmployee);
            this.tabPageEmployees.Controls.Add(this.comboBoxSections);
            this.tabPageEmployees.Controls.Add(this.buttonDisplayEmployees);
            this.tabPageEmployees.Controls.Add(this.buttonDeleteEmployee);
            this.tabPageEmployees.Controls.Add(this.buttonAddEmployee);
            this.tabPageEmployees.Controls.Add(this.labelSections);
            this.tabPageEmployees.Controls.Add(this.dataGridViewEmployees);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 39);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployees.Size = new System.Drawing.Size(1590, 737);
            this.tabPageEmployees.TabIndex = 1;
            this.tabPageEmployees.Text = "Pracownicy";
            this.tabPageEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonUpdateEmployee
            // 
            this.buttonUpdateEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdateEmployee.Location = new System.Drawing.Point(757, 447);
            this.buttonUpdateEmployee.Name = "buttonUpdateEmployee";
            this.buttonUpdateEmployee.Size = new System.Drawing.Size(262, 82);
            this.buttonUpdateEmployee.TabIndex = 15;
            this.buttonUpdateEmployee.Text = "Edytuj pracownika";
            this.buttonUpdateEmployee.UseVisualStyleBackColor = true;
            // 
            // comboBoxSections
            // 
            this.comboBoxSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSections.FormattingEnabled = true;
            this.comboBoxSections.Location = new System.Drawing.Point(184, 63);
            this.comboBoxSections.Name = "comboBoxSections";
            this.comboBoxSections.Size = new System.Drawing.Size(349, 38);
            this.comboBoxSections.TabIndex = 14;
            // 
            // buttonDisplayEmployees
            // 
            this.buttonDisplayEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDisplayEmployees.Location = new System.Drawing.Point(757, 63);
            this.buttonDisplayEmployees.Name = "buttonDisplayEmployees";
            this.buttonDisplayEmployees.Size = new System.Drawing.Size(262, 82);
            this.buttonDisplayEmployees.TabIndex = 13;
            this.buttonDisplayEmployees.Text = "Pokaż pracowników";
            this.buttonDisplayEmployees.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(757, 577);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(262, 82);
            this.buttonDeleteEmployee.TabIndex = 12;
            this.buttonDeleteEmployee.Text = "Usuń pracownika";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddEmployee.Location = new System.Drawing.Point(757, 312);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(262, 82);
            this.buttonAddEmployee.TabIndex = 11;
            this.buttonAddEmployee.Text = "Nowy pracownik";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // labelSections
            // 
            this.labelSections.AutoSize = true;
            this.labelSections.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSections.Location = new System.Drawing.Point(52, 63);
            this.labelSections.Name = "labelSections";
            this.labelSections.Size = new System.Drawing.Size(103, 30);
            this.labelSections.TabIndex = 10;
            this.labelSections.Text = "Jednostki";
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(184, 159);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 150;
            this.dataGridViewEmployees.RowTemplate.Height = 33;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(450, 500);
            this.dataGridViewEmployees.TabIndex = 9;
            // 
            // tabPageAbsence
            // 
            this.tabPageAbsence.Controls.Add(this.buttonChooseSectionAbsence);
            this.tabPageAbsence.Controls.Add(this.comboBoxSectionAbsence);
            this.tabPageAbsence.Controls.Add(this.buttonDeleteAbsence);
            this.tabPageAbsence.Controls.Add(this.buttonAddAbsence);
            this.tabPageAbsence.Controls.Add(this.label1);
            this.tabPageAbsence.Controls.Add(this.dataGridViewVacations);
            this.tabPageAbsence.Location = new System.Drawing.Point(4, 39);
            this.tabPageAbsence.Name = "tabPageAbsence";
            this.tabPageAbsence.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAbsence.Size = new System.Drawing.Size(1590, 737);
            this.tabPageAbsence.TabIndex = 2;
            this.tabPageAbsence.Text = "Absencje pracowników";
            this.tabPageAbsence.UseVisualStyleBackColor = true;
            // 
            // buttonChooseSectionAbsence
            // 
            this.buttonChooseSectionAbsence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChooseSectionAbsence.Location = new System.Drawing.Point(1258, 88);
            this.buttonChooseSectionAbsence.Name = "buttonChooseSectionAbsence";
            this.buttonChooseSectionAbsence.Size = new System.Drawing.Size(239, 55);
            this.buttonChooseSectionAbsence.TabIndex = 13;
            this.buttonChooseSectionAbsence.Text = "Pokaż";
            this.buttonChooseSectionAbsence.UseVisualStyleBackColor = true;
            // 
            // comboBoxSectionAbsence
            // 
            this.comboBoxSectionAbsence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSectionAbsence.FormattingEnabled = true;
            this.comboBoxSectionAbsence.Location = new System.Drawing.Point(223, 23);
            this.comboBoxSectionAbsence.Name = "comboBoxSectionAbsence";
            this.comboBoxSectionAbsence.Size = new System.Drawing.Size(349, 38);
            this.comboBoxSectionAbsence.TabIndex = 12;
            // 
            // buttonDeleteAbsence
            // 
            this.buttonDeleteAbsence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteAbsence.Location = new System.Drawing.Point(1258, 658);
            this.buttonDeleteAbsence.Name = "buttonDeleteAbsence";
            this.buttonDeleteAbsence.Size = new System.Drawing.Size(239, 55);
            this.buttonDeleteAbsence.TabIndex = 11;
            this.buttonDeleteAbsence.Text = "Usuń";
            this.buttonDeleteAbsence.UseVisualStyleBackColor = true;
            // 
            // buttonAddAbsence
            // 
            this.buttonAddAbsence.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddAbsence.Location = new System.Drawing.Point(1258, 547);
            this.buttonAddAbsence.Name = "buttonAddAbsence";
            this.buttonAddAbsence.Size = new System.Drawing.Size(239, 55);
            this.buttonAddAbsence.TabIndex = 10;
            this.buttonAddAbsence.Text = "Dodaj";
            this.buttonAddAbsence.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Jednostki";
            // 
            // dataGridViewVacations
            // 
            this.dataGridViewVacations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacations.Location = new System.Drawing.Point(94, 88);
            this.dataGridViewVacations.Name = "dataGridViewVacations";
            this.dataGridViewVacations.RowHeadersWidth = 62;
            this.dataGridViewVacations.RowTemplate.Height = 33;
            this.dataGridViewVacations.Size = new System.Drawing.Size(1000, 625);
            this.dataGridViewVacations.TabIndex = 8;
            // 
            // tabPageMenageVacApp
            // 
            this.tabPageMenageVacApp.Location = new System.Drawing.Point(4, 39);
            this.tabPageMenageVacApp.Name = "tabPageMenageVacApp";
            this.tabPageMenageVacApp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMenageVacApp.Size = new System.Drawing.Size(1590, 737);
            this.tabPageMenageVacApp.TabIndex = 3;
            this.tabPageMenageVacApp.Text = "Wnioski o urlop";
            this.tabPageMenageVacApp.UseVisualStyleBackColor = true;
            // 
            // tabPagePermisson
            // 
            this.tabPagePermisson.Location = new System.Drawing.Point(4, 39);
            this.tabPagePermisson.Name = "tabPagePermisson";
            this.tabPagePermisson.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePermisson.Size = new System.Drawing.Size(1590, 737);
            this.tabPagePermisson.TabIndex = 4;
            this.tabPagePermisson.Text = "Uprawnienia";
            this.tabPagePermisson.UseVisualStyleBackColor = true;
            // 
            // AdminMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Name = "AdminMainView";
            this.Text = "AdminMainView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPageSections.ResumeLayout(false);
            this.tabPageSections.PerformLayout();
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            this.tabPageAbsence.ResumeLayout(false);
            this.tabPageAbsence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected internal System.Windows.Forms.TabPage tabPageSections;
        protected internal System.Windows.Forms.TabPage tabPageEmployees;
        protected internal System.Windows.Forms.TabPage tabPageAbsence;
        protected internal System.Windows.Forms.TabPage tabPageMenageVacApp;
        protected internal System.Windows.Forms.TabPage tabPagePermisson;
        protected internal System.Windows.Forms.TabControl tabControlAdmin;
        protected internal System.Windows.Forms.Button buttonDeleteSection;
        protected internal System.Windows.Forms.Button buttonEditSection;
        protected internal System.Windows.Forms.Button buttonAddSection;
        protected internal System.Windows.Forms.ListView listViewSections;
        protected internal System.Windows.Forms.Label labelSectionList;
        protected internal System.Windows.Forms.Button buttonUpdateEmployee;
        protected internal System.Windows.Forms.ComboBox comboBoxSections;
        protected internal System.Windows.Forms.Button buttonDisplayEmployees;
        protected internal System.Windows.Forms.Button buttonDeleteEmployee;
        protected internal System.Windows.Forms.Button buttonAddEmployee;
        protected internal System.Windows.Forms.Label labelSections;
        protected internal System.Windows.Forms.DataGridView dataGridViewEmployees;
        protected internal System.Windows.Forms.Button buttonChooseSectionAbsence;
        protected internal System.Windows.Forms.ComboBox comboBoxSectionAbsence;
        protected internal System.Windows.Forms.Button buttonDeleteAbsence;
        protected internal System.Windows.Forms.Button buttonAddAbsence;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.DataGridView dataGridViewVacations;
    }
}