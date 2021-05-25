
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
            this.label2 = new System.Windows.Forms.Label();
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
            // 
            // button_addPass
            // 
            this.button_addPass.Location = new System.Drawing.Point(719, 165);
            this.button_addPass.Name = "button_addPass";
            this.button_addPass.Size = new System.Drawing.Size(204, 34);
            this.button_addPass.TabIndex = 2;
            this.button_addPass.Text = "przepustka";
            this.button_addPass.UseVisualStyleBackColor = true;
            // 
            // button_addVacation
            // 
            this.button_addVacation.Location = new System.Drawing.Point(719, 299);
            this.button_addVacation.Name = "button_addVacation";
            this.button_addVacation.Size = new System.Drawing.Size(204, 34);
            this.button_addVacation.TabIndex = 3;
            this.button_addVacation.Text = "dodaj urlop";
            this.button_addVacation.UseVisualStyleBackColor = true;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1000, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            // 
            // button_show_emp
            // 

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 933);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
    }
}

