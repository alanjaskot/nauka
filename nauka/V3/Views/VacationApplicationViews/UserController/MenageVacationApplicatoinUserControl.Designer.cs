
namespace nauka.V3.Views.UserControllers
{
    partial class MenageVacationApplicatoinUserControl
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
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelVacationDescription = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(121, 46);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(350, 31);
            this.dateTimePickerStart.TabIndex = 0;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(121, 123);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(350, 31);
            this.dateTimePickerEnd.TabIndex = 1;
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(25, 46);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(34, 25);
            this.labelStart.TabIndex = 2;
            this.labelStart.Text = "od";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(25, 123);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(36, 25);
            this.labelEnd.TabIndex = 3;
            this.labelEnd.Text = "Do";
            // 
            // labelVacationDescription
            // 
            this.labelVacationDescription.AutoSize = true;
            this.labelVacationDescription.Location = new System.Drawing.Point(25, 191);
            this.labelVacationDescription.Name = "labelVacationDescription";
            this.labelVacationDescription.Size = new System.Drawing.Size(126, 25);
            this.labelVacationDescription.TabIndex = 4;
            this.labelVacationDescription.Text = "powód urlopu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 191);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(314, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // MenageVacationApplicatoinUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelVacationDescription);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.dateTimePickerStart);
            this.Name = "MenageVacationApplicatoinUserControl";
            this.Size = new System.Drawing.Size(618, 302);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected internal System.Windows.Forms.DateTimePicker dateTimePickerStart;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelVacationDescription;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
