
namespace nauka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button_addPass = new System.Windows.Forms.Button();
            this.button_addVacation = new System.Windows.Forms.Button();
            this.newEmloyee = new System.Windows.Forms.Button();
            this.txt_firstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_lastName = new System.Windows.Forms.TextBox();
            this.txt_hourStart = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_hourStop = new System.Windows.Forms.TextBox();
            this.list_passView = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passDatePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker_hollidayStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePicker_HolidayEnd = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "lista pracownikow:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(103, 165);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 679);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button_addPass
            // 
            this.button_addPass.Location = new System.Drawing.Point(665, 165);
            this.button_addPass.Name = "button_addPass";
            this.button_addPass.Size = new System.Drawing.Size(204, 34);
            this.button_addPass.TabIndex = 2;
            this.button_addPass.Text = "przepustka";
            this.button_addPass.UseVisualStyleBackColor = true;
            this.button_addPass.Click += new System.EventHandler(this.button_addPass_Click);
            // 
            // button_addVacation
            // 
            this.button_addVacation.Location = new System.Drawing.Point(665, 431);
            this.button_addVacation.Name = "button_addVacation";
            this.button_addVacation.Size = new System.Drawing.Size(204, 34);
            this.button_addVacation.TabIndex = 3;
            this.button_addVacation.Text = "dodaj urlop";
            this.button_addVacation.UseVisualStyleBackColor = true;
            this.button_addVacation.Click += new System.EventHandler(this.button_addVacation_Click);
            // 
            // newEmloyee
            // 
            this.newEmloyee.Location = new System.Drawing.Point(1247, 811);
            this.newEmloyee.Name = "newEmloyee";
            this.newEmloyee.Size = new System.Drawing.Size(204, 34);
            this.newEmloyee.TabIndex = 4;
            this.newEmloyee.Text = "nowy pracownik";
            this.newEmloyee.UseVisualStyleBackColor = true;
            this.newEmloyee.Click += new System.EventHandler(this.newEmloyee_Click);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Location = new System.Drawing.Point(641, 813);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.Size = new System.Drawing.Size(208, 31);
            this.txt_firstName.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 816);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "imie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(895, 816);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "nazwisko";
            // 
            // txt_lastName
            // 
            this.txt_lastName.Location = new System.Drawing.Point(1000, 813);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.Size = new System.Drawing.Size(207, 31);
            this.txt_lastName.TabIndex = 10;
            // 
            // txt_hourStart
            // 
            this.txt_hourStart.Location = new System.Drawing.Point(947, 167);
            this.txt_hourStart.Name = "txt_hourStart";
            this.txt_hourStart.Size = new System.Drawing.Size(86, 31);
            this.txt_hourStart.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(895, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "od";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1065, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "do";
            // 
            // txt_hourStop
            // 
            this.txt_hourStop.Location = new System.Drawing.Point(1121, 168);
            this.txt_hourStop.Name = "txt_hourStop";
            this.txt_hourStop.Size = new System.Drawing.Size(86, 31);
            this.txt_hourStop.TabIndex = 14;
            // 
            // list_passView
            // 
            this.list_passView.FormattingEnabled = true;
            this.list_passView.ItemHeight = 25;
            this.list_passView.Location = new System.Drawing.Point(665, 240);
            this.list_passView.Name = "list_passView";
            this.list_passView.Size = new System.Drawing.Size(542, 154);
            this.list_passView.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1345, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // passDatePicker
            // 
            this.passDatePicker.Location = new System.Drawing.Point(1247, 170);
            this.passDatePicker.Name = "passDatePicker";
            this.passDatePicker.Size = new System.Drawing.Size(178, 31);
            this.passDatePicker.TabIndex = 17;
            // 
            // datePicker_hollidayStart
            // 
            this.datePicker_hollidayStart.Location = new System.Drawing.Point(710, 496);
            this.datePicker_hollidayStart.Name = "datePicker_hollidayStart";
            this.datePicker_hollidayStart.Size = new System.Drawing.Size(300, 31);
            this.datePicker_hollidayStart.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 497);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "od";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1032, 498);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "do";
            // 
            // datePicker_HolidayEnd
            // 
            this.datePicker_HolidayEnd.Location = new System.Drawing.Point(1078, 495);
            this.datePicker_HolidayEnd.Name = "datePicker_HolidayEnd";
            this.datePicker_HolidayEnd.Size = new System.Drawing.Size(300, 31);
            this.datePicker_HolidayEnd.TabIndex = 21;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(665, 562);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(542, 213);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 933);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.datePicker_HolidayEnd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.datePicker_hollidayStart);
            this.Controls.Add(this.passDatePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.list_passView);
            this.Controls.Add(this.txt_hourStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_hourStart);
            this.Controls.Add(this.txt_lastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_firstName);
            this.Controls.Add(this.newEmloyee);
            this.Controls.Add(this.button_addVacation);
            this.Controls.Add(this.button_addPass);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button_addPass;
        private System.Windows.Forms.Button button_addVacation;
        private System.Windows.Forms.Button newEmloyee;
        private System.Windows.Forms.TextBox txt_firstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_lastName;
        private System.Windows.Forms.TextBox txt_hourStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_hourStop;
        private System.Windows.Forms.ListBox list_passView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker passDatePicker;
        private System.Windows.Forms.DateTimePicker datePicker_hollidayStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePicker_HolidayEnd;
        private System.Windows.Forms.ListView listView1;
    }
}

