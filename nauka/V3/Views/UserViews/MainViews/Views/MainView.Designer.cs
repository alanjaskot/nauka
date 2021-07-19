
namespace nauka.V3.Views.MianViews
{
    partial class MainView
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
            this.tabPageAdminPanel = new System.Windows.Forms.TabPage();
            this.buttonOk = new System.Windows.Forms.Button();
            this.textBoxPassowrd = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tabPageVacationApplication = new System.Windows.Forms.TabPage();
            this.buttonDeleteVacApp = new System.Windows.Forms.Button();
            this.buttonAddVacApp = new System.Windows.Forms.Button();
            this.labelVacationApplicationList = new System.Windows.Forms.Label();
            this.dataGridViewVacAppList = new System.Windows.Forms.DataGridView();
            this.tabPageVacations = new System.Windows.Forms.TabPage();
            this.monthCalendarVavations = new System.Windows.Forms.MonthCalendar();
            this.labelVacationList = new System.Windows.Forms.Label();
            this.dataGridViewVacations = new System.Windows.Forms.DataGridView();
            this.tabPageEmployee = new System.Windows.Forms.TabPage();
            this.labelFreeDays = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurnameEmployee = new System.Windows.Forms.Label();
            this.labelFreeDaysLeft = new System.Windows.Forms.Label();
            this.labelUsernameEmployee = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelNameEmployee = new System.Windows.Forms.Label();
            this.labelSectionEmployee = new System.Windows.Forms.Label();
            this.labelEmailEmployee = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSection = new System.Windows.Forms.Label();
            this.labelSexEmployee = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.tabPageDashboard = new System.Windows.Forms.TabPage();
            this.tabControlMainView = new System.Windows.Forms.TabControl();
            this.labelFreeDayLestYear = new System.Windows.Forms.Label();
            this.labelLastYearFreeDays = new System.Windows.Forms.Label();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.tabPageAdminPanel.SuspendLayout();
            this.tabPageVacationApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacAppList)).BeginInit();
            this.tabPageVacations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).BeginInit();
            this.tabPageEmployee.SuspendLayout();
            this.tabControlMainView.SuspendLayout();
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
            // panelLeftMenu
            // 
            this.panelLeftMenu.Size = new System.Drawing.Size(192, 780);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tabControlMainView);
            this.panelMain.Location = new System.Drawing.Point(192, 150);
            this.panelMain.Size = new System.Drawing.Size(1706, 780);
            // 
            // tabPageAdminPanel
            // 
            this.tabPageAdminPanel.Controls.Add(this.buttonOk);
            this.tabPageAdminPanel.Controls.Add(this.textBoxPassowrd);
            this.tabPageAdminPanel.Controls.Add(this.labelPassword);
            this.tabPageAdminPanel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageAdminPanel.Location = new System.Drawing.Point(4, 44);
            this.tabPageAdminPanel.Name = "tabPageAdminPanel";
            this.tabPageAdminPanel.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdminPanel.Size = new System.Drawing.Size(1578, 732);
            this.tabPageAdminPanel.TabIndex = 4;
            this.tabPageAdminPanel.Text = "Panel Administratora";
            this.tabPageAdminPanel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(711, 353);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(133, 49);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // textBoxPassowrd
            // 
            this.textBoxPassowrd.Location = new System.Drawing.Point(516, 256);
            this.textBoxPassowrd.Name = "textBoxPassowrd";
            this.textBoxPassowrd.PasswordChar = '*';
            this.textBoxPassowrd.Size = new System.Drawing.Size(329, 37);
            this.textBoxPassowrd.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(390, 263);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(64, 30);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "hasło";
            // 
            // tabPageVacationApplication
            // 
            this.tabPageVacationApplication.Controls.Add(this.buttonDeleteVacApp);
            this.tabPageVacationApplication.Controls.Add(this.buttonAddVacApp);
            this.tabPageVacationApplication.Controls.Add(this.labelVacationApplicationList);
            this.tabPageVacationApplication.Controls.Add(this.dataGridViewVacAppList);
            this.tabPageVacationApplication.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageVacationApplication.Location = new System.Drawing.Point(4, 44);
            this.tabPageVacationApplication.Name = "tabPageVacationApplication";
            this.tabPageVacationApplication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVacationApplication.Size = new System.Drawing.Size(1578, 732);
            this.tabPageVacationApplication.TabIndex = 3;
            this.tabPageVacationApplication.Text = "Wnioski o urlop";
            this.tabPageVacationApplication.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteVacApp
            // 
            this.buttonDeleteVacApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDeleteVacApp.Location = new System.Drawing.Point(954, 298);
            this.buttonDeleteVacApp.Name = "buttonDeleteVacApp";
            this.buttonDeleteVacApp.Size = new System.Drawing.Size(211, 103);
            this.buttonDeleteVacApp.TabIndex = 8;
            this.buttonDeleteVacApp.Text = "Zrezygnuj z wniosku";
            this.buttonDeleteVacApp.UseVisualStyleBackColor = true;
            // 
            // buttonAddVacApp
            // 
            this.buttonAddVacApp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAddVacApp.Location = new System.Drawing.Point(954, 110);
            this.buttonAddVacApp.Name = "buttonAddVacApp";
            this.buttonAddVacApp.Size = new System.Drawing.Size(211, 82);
            this.buttonAddVacApp.TabIndex = 7;
            this.buttonAddVacApp.Text = "Wniosek o urlop";
            this.buttonAddVacApp.UseVisualStyleBackColor = true;
            // 
            // labelVacationApplicationList
            // 
            this.labelVacationApplicationList.AutoSize = true;
            this.labelVacationApplicationList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVacationApplicationList.Location = new System.Drawing.Point(177, 44);
            this.labelVacationApplicationList.Name = "labelVacationApplicationList";
            this.labelVacationApplicationList.Size = new System.Drawing.Size(165, 30);
            this.labelVacationApplicationList.TabIndex = 6;
            this.labelVacationApplicationList.Text = "Wnioski o urlop";
            // 
            // dataGridViewVacAppList
            // 
            this.dataGridViewVacAppList.AllowUserToAddRows = false;
            this.dataGridViewVacAppList.AllowUserToDeleteRows = false;
            this.dataGridViewVacAppList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacAppList.Location = new System.Drawing.Point(177, 110);
            this.dataGridViewVacAppList.Name = "dataGridViewVacAppList";
            this.dataGridViewVacAppList.ReadOnly = true;
            this.dataGridViewVacAppList.RowHeadersWidth = 62;
            this.dataGridViewVacAppList.RowTemplate.Height = 33;
            this.dataGridViewVacAppList.Size = new System.Drawing.Size(550, 579);
            this.dataGridViewVacAppList.TabIndex = 5;
            // 
            // tabPageVacations
            // 
            this.tabPageVacations.Controls.Add(this.monthCalendarVavations);
            this.tabPageVacations.Controls.Add(this.labelVacationList);
            this.tabPageVacations.Controls.Add(this.dataGridViewVacations);
            this.tabPageVacations.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageVacations.Location = new System.Drawing.Point(4, 44);
            this.tabPageVacations.Name = "tabPageVacations";
            this.tabPageVacations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVacations.Size = new System.Drawing.Size(1578, 732);
            this.tabPageVacations.TabIndex = 2;
            this.tabPageVacations.Text = "Urlopy";
            this.tabPageVacations.UseVisualStyleBackColor = true;
            // 
            // monthCalendarVavations
            // 
            this.monthCalendarVavations.CalendarDimensions = new System.Drawing.Size(2, 2);
            this.monthCalendarVavations.Location = new System.Drawing.Point(696, 141);
            this.monthCalendarVavations.Name = "monthCalendarVavations";
            this.monthCalendarVavations.TabIndex = 5;
            // 
            // labelVacationList
            // 
            this.labelVacationList.AutoSize = true;
            this.labelVacationList.Location = new System.Drawing.Point(80, 83);
            this.labelVacationList.Name = "labelVacationList";
            this.labelVacationList.Size = new System.Drawing.Size(141, 30);
            this.labelVacationList.TabIndex = 4;
            this.labelVacationList.Text = "Lista urlopów";
            // 
            // dataGridViewVacations
            // 
            this.dataGridViewVacations.AllowUserToAddRows = false;
            this.dataGridViewVacations.AllowUserToDeleteRows = false;
            this.dataGridViewVacations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacations.Location = new System.Drawing.Point(80, 141);
            this.dataGridViewVacations.Name = "dataGridViewVacations";
            this.dataGridViewVacations.ReadOnly = true;
            this.dataGridViewVacations.RowHeadersWidth = 62;
            this.dataGridViewVacations.RowTemplate.Height = 33;
            this.dataGridViewVacations.Size = new System.Drawing.Size(550, 480);
            this.dataGridViewVacations.TabIndex = 3;
            // 
            // tabPageEmployee
            // 
            this.tabPageEmployee.Controls.Add(this.labelLastYearFreeDays);
            this.tabPageEmployee.Controls.Add(this.labelFreeDayLestYear);
            this.tabPageEmployee.Controls.Add(this.labelFreeDays);
            this.tabPageEmployee.Controls.Add(this.labelName);
            this.tabPageEmployee.Controls.Add(this.labelSurnameEmployee);
            this.tabPageEmployee.Controls.Add(this.labelFreeDaysLeft);
            this.tabPageEmployee.Controls.Add(this.labelUsernameEmployee);
            this.tabPageEmployee.Controls.Add(this.labelSurname);
            this.tabPageEmployee.Controls.Add(this.labelNameEmployee);
            this.tabPageEmployee.Controls.Add(this.labelSectionEmployee);
            this.tabPageEmployee.Controls.Add(this.labelEmailEmployee);
            this.tabPageEmployee.Controls.Add(this.labelUser);
            this.tabPageEmployee.Controls.Add(this.labelEmail);
            this.tabPageEmployee.Controls.Add(this.labelSection);
            this.tabPageEmployee.Controls.Add(this.labelSexEmployee);
            this.tabPageEmployee.Controls.Add(this.labelSex);
            this.tabPageEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageEmployee.Location = new System.Drawing.Point(4, 44);
            this.tabPageEmployee.Name = "tabPageEmployee";
            this.tabPageEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployee.Size = new System.Drawing.Size(1578, 732);
            this.tabPageEmployee.TabIndex = 1;
            this.tabPageEmployee.Text = "Dane Pracownika";
            this.tabPageEmployee.UseVisualStyleBackColor = true;
            // 
            // labelFreeDays
            // 
            this.labelFreeDays.AutoSize = true;
            this.labelFreeDays.Location = new System.Drawing.Point(1078, 70);
            this.labelFreeDays.Name = "labelFreeDays";
            this.labelFreeDays.Size = new System.Drawing.Size(0, 30);
            this.labelFreeDays.TabIndex = 40;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(249, 70);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 30);
            this.labelName.TabIndex = 27;
            this.labelName.Text = "imie";
            // 
            // labelSurnameEmployee
            // 
            this.labelSurnameEmployee.AutoSize = true;
            this.labelSurnameEmployee.Location = new System.Drawing.Point(498, 143);
            this.labelSurnameEmployee.Name = "labelSurnameEmployee";
            this.labelSurnameEmployee.Size = new System.Drawing.Size(0, 30);
            this.labelSurnameEmployee.TabIndex = 33;
            // 
            // labelFreeDaysLeft
            // 
            this.labelFreeDaysLeft.AutoSize = true;
            this.labelFreeDaysLeft.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFreeDaysLeft.Location = new System.Drawing.Point(783, 70);
            this.labelFreeDaysLeft.Name = "labelFreeDaysLeft";
            this.labelFreeDaysLeft.Size = new System.Drawing.Size(227, 30);
            this.labelFreeDaysLeft.TabIndex = 39;
            this.labelFreeDaysLeft.Text = "wolne dni w tym roku:";
            // 
            // labelUsernameEmployee
            // 
            this.labelUsernameEmployee.AutoSize = true;
            this.labelUsernameEmployee.Location = new System.Drawing.Point(498, 296);
            this.labelUsernameEmployee.Name = "labelUsernameEmployee";
            this.labelUsernameEmployee.Size = new System.Drawing.Size(0, 30);
            this.labelUsernameEmployee.TabIndex = 34;
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSurname.Location = new System.Drawing.Point(249, 143);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(100, 30);
            this.labelSurname.TabIndex = 28;
            this.labelSurname.Text = "nazwisko";
            // 
            // labelNameEmployee
            // 
            this.labelNameEmployee.AutoSize = true;
            this.labelNameEmployee.Location = new System.Drawing.Point(498, 70);
            this.labelNameEmployee.Name = "labelNameEmployee";
            this.labelNameEmployee.Size = new System.Drawing.Size(0, 30);
            this.labelNameEmployee.TabIndex = 32;
            // 
            // labelSectionEmployee
            // 
            this.labelSectionEmployee.AutoSize = true;
            this.labelSectionEmployee.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSectionEmployee.Location = new System.Drawing.Point(498, 227);
            this.labelSectionEmployee.Name = "labelSectionEmployee";
            this.labelSectionEmployee.Size = new System.Drawing.Size(0, 30);
            this.labelSectionEmployee.TabIndex = 38;
            // 
            // labelEmailEmployee
            // 
            this.labelEmailEmployee.AutoSize = true;
            this.labelEmailEmployee.Location = new System.Drawing.Point(498, 375);
            this.labelEmailEmployee.Name = "labelEmailEmployee";
            this.labelEmailEmployee.Size = new System.Drawing.Size(0, 30);
            this.labelEmailEmployee.TabIndex = 35;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUser.Location = new System.Drawing.Point(249, 296);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(121, 30);
            this.labelUser.TabIndex = 29;
            this.labelUser.Text = "użytkownik";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(249, 375);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 30);
            this.labelEmail.TabIndex = 31;
            this.labelEmail.Text = "E-mail";
            // 
            // labelSection
            // 
            this.labelSection.AutoSize = true;
            this.labelSection.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSection.Location = new System.Drawing.Point(249, 227);
            this.labelSection.Name = "labelSection";
            this.labelSection.Size = new System.Drawing.Size(109, 30);
            this.labelSection.TabIndex = 37;
            this.labelSection.Text = "Jednostka";
            // 
            // labelSexEmployee
            // 
            this.labelSexEmployee.AutoSize = true;
            this.labelSexEmployee.Location = new System.Drawing.Point(498, 447);
            this.labelSexEmployee.Name = "labelSexEmployee";
            this.labelSexEmployee.Size = new System.Drawing.Size(0, 30);
            this.labelSexEmployee.TabIndex = 36;
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSex.Location = new System.Drawing.Point(249, 458);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(54, 30);
            this.labelSex.TabIndex = 30;
            this.labelSex.Text = "płeć";
            // 
            // tabPageDashboard
            // 
            this.tabPageDashboard.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPageDashboard.Location = new System.Drawing.Point(4, 44);
            this.tabPageDashboard.Name = "tabPageDashboard";
            this.tabPageDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDashboard.Size = new System.Drawing.Size(1578, 732);
            this.tabPageDashboard.TabIndex = 0;
            this.tabPageDashboard.Text = "Tablica";
            this.tabPageDashboard.UseVisualStyleBackColor = true;
            // 
            // tabControlMainView
            // 
            this.tabControlMainView.Controls.Add(this.tabPageDashboard);
            this.tabControlMainView.Controls.Add(this.tabPageEmployee);
            this.tabControlMainView.Controls.Add(this.tabPageVacations);
            this.tabControlMainView.Controls.Add(this.tabPageVacationApplication);
            this.tabControlMainView.Controls.Add(this.tabPageAdminPanel);
            this.tabControlMainView.ItemSize = new System.Drawing.Size(200, 40);
            this.tabControlMainView.Location = new System.Drawing.Point(0, 0);
            this.tabControlMainView.Name = "tabControlMainView";
            this.tabControlMainView.SelectedIndex = 0;
            this.tabControlMainView.Size = new System.Drawing.Size(1586, 780);
            this.tabControlMainView.TabIndex = 0;
            // 
            // labelFreeDayLestYear
            // 
            this.labelFreeDayLestYear.AutoSize = true;
            this.labelFreeDayLestYear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFreeDayLestYear.Location = new System.Drawing.Point(783, 161);
            this.labelFreeDayLestYear.Name = "labelFreeDayLestYear";
            this.labelFreeDayLestYear.Size = new System.Drawing.Size(241, 30);
            this.labelFreeDayLestYear.TabIndex = 41;
            this.labelFreeDayLestYear.Text = "wolne dni za zeszły rok:";
            // 
            // labelLastYearFreeDays
            // 
            this.labelLastYearFreeDays.AutoSize = true;
            this.labelLastYearFreeDays.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLastYearFreeDays.Location = new System.Drawing.Point(1078, 161);
            this.labelLastYearFreeDays.Name = "labelLastYearFreeDays";
            this.labelLastYearFreeDays.Size = new System.Drawing.Size(0, 30);
            this.labelLastYearFreeDays.TabIndex = 42;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Name = "MainView";
            this.Text = "MainView";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.tabPageAdminPanel.ResumeLayout(false);
            this.tabPageAdminPanel.PerformLayout();
            this.tabPageVacationApplication.ResumeLayout(false);
            this.tabPageVacationApplication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacAppList)).EndInit();
            this.tabPageVacations.ResumeLayout(false);
            this.tabPageVacations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacations)).EndInit();
            this.tabPageEmployee.ResumeLayout(false);
            this.tabPageEmployee.PerformLayout();
            this.tabControlMainView.ResumeLayout(false);
            this.ResumeLayout(false);

        }



        #endregion

        protected internal System.Windows.Forms.TabControl tabControlMainView;
        protected internal System.Windows.Forms.TabPage tabPageDashboard;
        protected internal System.Windows.Forms.TabPage tabPageEmployee;
        protected internal System.Windows.Forms.Label labelFreeDays;
        protected internal System.Windows.Forms.Label labelName;
        protected internal System.Windows.Forms.Label labelSurnameEmployee;
        protected internal System.Windows.Forms.Label labelFreeDaysLeft;
        protected internal System.Windows.Forms.Label labelUsernameEmployee;
        protected internal System.Windows.Forms.Label labelSurname;
        protected internal System.Windows.Forms.Label labelNameEmployee;
        protected internal System.Windows.Forms.Label labelSectionEmployee;
        protected internal System.Windows.Forms.Label labelEmailEmployee;
        protected internal System.Windows.Forms.Label labelUser;
        protected internal System.Windows.Forms.Label labelEmail;
        protected internal System.Windows.Forms.Label labelSection;
        protected internal System.Windows.Forms.Label labelSexEmployee;
        protected internal System.Windows.Forms.Label labelSex;
        protected internal System.Windows.Forms.TabPage tabPageVacations;
        protected internal System.Windows.Forms.MonthCalendar monthCalendarVavations;
        protected internal System.Windows.Forms.Label labelVacationList;
        protected internal System.Windows.Forms.DataGridView dataGridViewVacations;
        protected internal System.Windows.Forms.TabPage tabPageVacationApplication;
        protected internal System.Windows.Forms.TabPage tabPageAdminPanel;
        protected internal System.Windows.Forms.Button buttonDeleteVacApp;
        protected internal System.Windows.Forms.Button buttonAddVacApp;
        protected internal System.Windows.Forms.Label labelVacationApplicationList;
        protected internal System.Windows.Forms.DataGridView dataGridViewVacAppList;
        protected internal System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.TextBox textBoxPassowrd;
        protected internal System.Windows.Forms.Label labelPassword;
        protected internal System.Windows.Forms.Label labelLastYearFreeDays;
        protected internal System.Windows.Forms.Label labelFreeDayLestYear;
    }
}