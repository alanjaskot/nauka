
namespace nauka.V3.Views.UserControllers
{
    partial class MenageVacationUserControl
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
            this.buttonNewVacation = new System.Windows.Forms.Button();
            this.buttonEditVacation = new System.Windows.Forms.Button();
            this.buttonUsuń = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonNewVacation
            // 
            this.buttonNewVacation.Location = new System.Drawing.Point(75, 57);
            this.buttonNewVacation.Name = "buttonNewVacation";
            this.buttonNewVacation.Size = new System.Drawing.Size(231, 34);
            this.buttonNewVacation.TabIndex = 0;
            this.buttonNewVacation.Text = "nowy urlop";
            this.buttonNewVacation.UseVisualStyleBackColor = true;
            // 
            // buttonEditVacation
            // 
            this.buttonEditVacation.Location = new System.Drawing.Point(75, 137);
            this.buttonEditVacation.Name = "buttonEditVacation";
            this.buttonEditVacation.Size = new System.Drawing.Size(231, 34);
            this.buttonEditVacation.TabIndex = 1;
            this.buttonEditVacation.Text = "zmień urlop";
            this.buttonEditVacation.UseVisualStyleBackColor = true;
            // 
            // buttonUsuń
            // 
            this.buttonUsuń.Location = new System.Drawing.Point(75, 223);
            this.buttonUsuń.Name = "buttonUsuń";
            this.buttonUsuń.Size = new System.Drawing.Size(231, 34);
            this.buttonUsuń.TabIndex = 2;
            this.buttonUsuń.Text = "rezygnacja z urlopu";
            this.buttonUsuń.UseVisualStyleBackColor = true;
            // 
            // MenageVacationUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonUsuń);
            this.Controls.Add(this.buttonEditVacation);
            this.Controls.Add(this.buttonNewVacation);
            this.Name = "MenageVacationUserControl";
            this.Size = new System.Drawing.Size(377, 422);
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.Button buttonNewVacation;
        private System.Windows.Forms.Button buttonEditVacation;
        private System.Windows.Forms.Button buttonUsuń;
    }
}
