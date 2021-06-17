
namespace nauka.V2.Views.MainView.Views
{
    partial class MainViewView
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
            this.groupBoxUsers = new System.Windows.Forms.GroupBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonUserRemove = new System.Windows.Forms.Button();
            this.buttonUserEdit = new System.Windows.Forms.Button();
            this.buttonUserAdd = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonVacations = new System.Windows.Forms.Button();
            this.groupBoxUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUsers
            // 
            this.groupBoxUsers.Controls.Add(this.dataGridViewUsers);
            this.groupBoxUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUsers.Location = new System.Drawing.Point(0, 0);
            this.groupBoxUsers.Margin = new System.Windows.Forms.Padding(443, 517, 443, 517);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Padding = new System.Windows.Forms.Padding(14, 17, 14, 17);
            this.groupBoxUsers.Size = new System.Drawing.Size(1375, 750);
            this.groupBoxUsers.TabIndex = 0;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Pracownicy";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(14, 41);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(14, 17, 14, 17);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.RowTemplate.Height = 25;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1347, 692);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonUserRemove);
            this.flowLayoutPanel1.Controls.Add(this.buttonUserEdit);
            this.flowLayoutPanel1.Controls.Add(this.buttonUserAdd);
            this.flowLayoutPanel1.Controls.Add(this.labelTimer);
            this.flowLayoutPanel1.Controls.Add(this.buttonInfo);
            this.flowLayoutPanel1.Controls.Add(this.buttonLogin);
            this.flowLayoutPanel1.Controls.Add(this.buttonLogout);
            this.flowLayoutPanel1.Controls.Add(this.buttonVacations);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 662);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(14, 17, 14, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(14, 17, 14, 17);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1375, 88);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonUserRemove
            // 
            this.buttonUserRemove.Enabled = false;
            this.buttonUserRemove.Location = new System.Drawing.Point(1200, 22);
            this.buttonUserRemove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserRemove.Name = "buttonUserRemove";
            this.buttonUserRemove.Size = new System.Drawing.Size(143, 50);
            this.buttonUserRemove.TabIndex = 9;
            this.buttonUserRemove.Text = "Usuń";
            this.buttonUserRemove.UseVisualStyleBackColor = true;
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Enabled = false;
            this.buttonUserEdit.Location = new System.Drawing.Point(1049, 22);
            this.buttonUserEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(143, 50);
            this.buttonUserEdit.TabIndex = 11;
            this.buttonUserEdit.Text = "Edytuj";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Enabled = false;
            this.buttonUserAdd.Location = new System.Drawing.Point(898, 22);
            this.buttonUserAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(143, 50);
            this.buttonUserAdd.TabIndex = 12;
            this.buttonUserAdd.Text = "Dodaj";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTimer.Location = new System.Drawing.Point(626, 17);
            this.labelTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(264, 60);
            this.labelTimer.TabIndex = 13;
            this.labelTimer.Text = "currentTime";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(475, 22);
            this.buttonInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(143, 50);
            this.buttonInfo.TabIndex = 14;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(324, 22);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(143, 50);
            this.buttonLogin.TabIndex = 15;
            this.buttonLogin.Text = "Logowanie";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(173, 22);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(143, 50);
            this.buttonLogout.TabIndex = 16;
            this.buttonLogout.Text = "Wylogowanie";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonVacations
            // 
            this.buttonVacations.Location = new System.Drawing.Point(22, 22);
            this.buttonVacations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonVacations.Name = "buttonVacations";
            this.buttonVacations.Size = new System.Drawing.Size(143, 50);
            this.buttonVacations.TabIndex = 17;
            this.buttonVacations.Text = "Wakacje";
            this.buttonVacations.UseVisualStyleBackColor = true;
            // 
            // MainViewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 750);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBoxUsers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainViewView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarzadzanie urlopami i przepustkami";
            this.groupBoxUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUsers;
        protected internal System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected internal System.Windows.Forms.Button buttonUserAdd;
        protected internal System.Windows.Forms.Button buttonUserRemove;
        protected internal System.Windows.Forms.Button buttonUserEdit;
        protected internal System.Windows.Forms.Label labelTimer;
        protected internal System.Windows.Forms.Button buttonInfo;
        protected internal System.Windows.Forms.Button buttonLogin;
        protected internal System.Windows.Forms.Button buttonLogout;
        protected internal System.Windows.Forms.Button buttonVacations;
    }
}