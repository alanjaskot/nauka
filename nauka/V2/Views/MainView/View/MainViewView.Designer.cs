
namespace nauka.V2.Views.MainView.View
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
            this.groupBoxUsers.Margin = new System.Windows.Forms.Padding(310);
            this.groupBoxUsers.Name = "groupBoxUsers";
            this.groupBoxUsers.Padding = new System.Windows.Forms.Padding(10);
            this.groupBoxUsers.Size = new System.Drawing.Size(800, 450);
            this.groupBoxUsers.TabIndex = 0;
            this.groupBoxUsers.TabStop = false;
            this.groupBoxUsers.Text = "Pracownicy";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsers.Location = new System.Drawing.Point(10, 26);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(10);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.RowTemplate.Height = 25;
            this.dataGridViewUsers.Size = new System.Drawing.Size(780, 414);
            this.dataGridViewUsers.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.buttonUserRemove);
            this.flowLayoutPanel1.Controls.Add(this.buttonUserEdit);
            this.flowLayoutPanel1.Controls.Add(this.buttonUserAdd);
            this.flowLayoutPanel1.Controls.Add(this.labelTimer);
            this.flowLayoutPanel1.Controls.Add(this.buttonInfo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 397);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 53);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // buttonUserRemove
            // 
            this.buttonUserRemove.Enabled = false;
            this.buttonUserRemove.Location = new System.Drawing.Point(677, 13);
            this.buttonUserRemove.Name = "buttonUserRemove";
            this.buttonUserRemove.Size = new System.Drawing.Size(100, 30);
            this.buttonUserRemove.TabIndex = 9;
            this.buttonUserRemove.Text = "Usuń";
            this.buttonUserRemove.UseVisualStyleBackColor = true;
            // 
            // buttonUserEdit
            // 
            this.buttonUserEdit.Enabled = false;
            this.buttonUserEdit.Location = new System.Drawing.Point(571, 13);
            this.buttonUserEdit.Name = "buttonUserEdit";
            this.buttonUserEdit.Size = new System.Drawing.Size(100, 30);
            this.buttonUserEdit.TabIndex = 11;
            this.buttonUserEdit.Text = "Edytuj";
            this.buttonUserEdit.UseVisualStyleBackColor = true;
            // 
            // buttonUserAdd
            // 
            this.buttonUserAdd.Enabled = false;
            this.buttonUserAdd.Location = new System.Drawing.Point(465, 13);
            this.buttonUserAdd.Name = "buttonUserAdd";
            this.buttonUserAdd.Size = new System.Drawing.Size(100, 30);
            this.buttonUserAdd.TabIndex = 12;
            this.buttonUserAdd.Text = "Dodaj";
            this.buttonUserAdd.UseVisualStyleBackColor = true;
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTimer.Location = new System.Drawing.Point(274, 10);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(185, 36);
            this.labelTimer.TabIndex = 13;
            this.labelTimer.Text = "currentTime";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonInfo
            // 
            this.buttonInfo.Location = new System.Drawing.Point(168, 13);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(100, 30);
            this.buttonInfo.TabIndex = 14;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = true;
            // 
            // MainViewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBoxUsers);
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
    }
}