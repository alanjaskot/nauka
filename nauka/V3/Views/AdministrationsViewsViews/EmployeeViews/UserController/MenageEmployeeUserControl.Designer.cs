
namespace nauka.V3.Views.UserControllers
{
    partial class MenageEmployeeUserControl
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
            this.buttonAddEmployee = new System.Windows.Forms.Button();
            this.buttonEditEmployee = new System.Windows.Forms.Button();
            this.buttonDeleteEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddEmployee
            // 
            this.buttonAddEmployee.Location = new System.Drawing.Point(40, 59);
            this.buttonAddEmployee.Name = "buttonAddEmployee";
            this.buttonAddEmployee.Size = new System.Drawing.Size(181, 34);
            this.buttonAddEmployee.TabIndex = 1;
            this.buttonAddEmployee.Text = "Nowy pracownik";
            this.buttonAddEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonEditEmployee
            // 
            this.buttonEditEmployee.Location = new System.Drawing.Point(40, 136);
            this.buttonEditEmployee.Name = "buttonEditEmployee";
            this.buttonEditEmployee.Size = new System.Drawing.Size(181, 34);
            this.buttonEditEmployee.TabIndex = 2;
            this.buttonEditEmployee.Text = "Edytuj pracownika";
            this.buttonEditEmployee.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteEmployee
            // 
            this.buttonDeleteEmployee.Location = new System.Drawing.Point(40, 212);
            this.buttonDeleteEmployee.Name = "buttonDeleteEmployee";
            this.buttonDeleteEmployee.Size = new System.Drawing.Size(181, 34);
            this.buttonDeleteEmployee.TabIndex = 3;
            this.buttonDeleteEmployee.Text = "Usuń pracownika";
            this.buttonDeleteEmployee.UseVisualStyleBackColor = true;
            // 
            // MenageEmployeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeleteEmployee);
            this.Controls.Add(this.buttonEditEmployee);
            this.Controls.Add(this.buttonAddEmployee);
            this.Name = "MenageEmployeeUserControl";
            this.Size = new System.Drawing.Size(297, 445);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonAddEmployee;
        private System.Windows.Forms.Button buttonEditEmployee;
        private System.Windows.Forms.Button buttonDeleteEmployee;
    }
}
