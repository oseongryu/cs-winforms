namespace F5074.Winforms.TabFolder
{
    partial class FormTab2
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
            this.testUserControl1 = new F5074.Winforms.MyUserControl.TestUserControl();
            this.testUserControl2 = new F5074.Winforms.MyUserControl.TestUserControl();
            this.SuspendLayout();
            // 
            // testUserControl1
            // 
            this.testUserControl1.Location = new System.Drawing.Point(40, 31);
            this.testUserControl1.Name = "testUserControl1";
            this.testUserControl1.Size = new System.Drawing.Size(310, 41);
            this.testUserControl1.TabIndex = 0;
            // 
            // testUserControl2
            // 
            this.testUserControl2.Location = new System.Drawing.Point(40, 78);
            this.testUserControl2.Name = "testUserControl2";
            this.testUserControl2.Size = new System.Drawing.Size(310, 41);
            this.testUserControl2.TabIndex = 1;
            // 
            // FormTab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testUserControl2);
            this.Controls.Add(this.testUserControl1);
            this.Name = "FormTab2";
            this.Text = "FormTab2";
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControl.TestUserControl testUserControl1;
        private MyUserControl.TestUserControl testUserControl2;
    }
}