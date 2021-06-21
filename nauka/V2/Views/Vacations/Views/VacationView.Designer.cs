
namespace nauka.V2.Views.Vacations.Views
{
    partial class VacationView
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
            this.buttonMenagerVacations = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelRestOfVacationDays = new System.Windows.Forms.Label();
            this.labelShowDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMenagerVacations
            // 
            this.buttonMenagerVacations.Location = new System.Drawing.Point(328, 13);
            this.buttonMenagerVacations.Name = "buttonMenagerVacations";
            this.buttonMenagerVacations.Size = new System.Drawing.Size(250, 34);
            this.buttonMenagerVacations.TabIndex = 2;
            this.buttonMenagerVacations.Text = "Zarządzaj urlopami";
            this.buttonMenagerVacations.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(328, 78);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(112, 34);
            this.buttonOk.TabIndex = 5;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(466, 78);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(112, 34);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // labelRestOfVacationDays
            // 
            this.labelRestOfVacationDays.AutoSize = true;
            this.labelRestOfVacationDays.Location = new System.Drawing.Point(25, 13);
            this.labelRestOfVacationDays.Name = "labelRestOfVacationDays";
            this.labelRestOfVacationDays.Size = new System.Drawing.Size(182, 25);
            this.labelRestOfVacationDays.TabIndex = 8;
            this.labelRestOfVacationDays.Text = "Dni do wykorzystania";
            // 
            // labelShowDays
            // 
            this.labelShowDays.AutoSize = true;
            this.labelShowDays.Location = new System.Drawing.Point(235, 13);
            this.labelShowDays.Name = "labelShowDays";
            this.labelShowDays.Size = new System.Drawing.Size(0, 25);
            this.labelShowDays.TabIndex = 9;
            // 
            // VacationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 149);
            this.Controls.Add(this.labelShowDays);
            this.Controls.Add(this.labelRestOfVacationDays);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonMenagerVacations);
            this.Name = "VacationView";
            this.Text = "VacationView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected internal System.Windows.Forms.Button buttonMenagerVacations;
        protected internal System.Windows.Forms.Button buttonOk;
        protected internal System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelRestOfVacationDays;
        protected internal System.Windows.Forms.Label labelShowDays;
    }
}