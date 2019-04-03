namespace F5074.Winforms.TabFolder
{
    partial class B_UserControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.testUserControl1 = new F5074.Winforms.MyUserControl.TestUserControl();
            this.testUserControl2 = new F5074.Winforms.MyUserControl.TestUserControl();
            this.SuspendLayout();
            // 
            // testUserControl1
            // 
            this.testUserControl1.Location = new System.Drawing.Point(15, 17);
            this.testUserControl1.Name = "testUserControl1";
            this.testUserControl1.Size = new System.Drawing.Size(310, 41);
            this.testUserControl1.TabIndex = 1;
            // 
            // testUserControl2
            // 
            this.testUserControl2.Location = new System.Drawing.Point(15, 64);
            this.testUserControl2.Name = "testUserControl2";
            this.testUserControl2.Size = new System.Drawing.Size(310, 41);
            this.testUserControl2.TabIndex = 2;
            // 
            // B_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.testUserControl2);
            this.Controls.Add(this.testUserControl1);
            this.Name = "B_UserControl";
            this.Size = new System.Drawing.Size(828, 468);
            this.ResumeLayout(false);

        }

        #endregion

        private MyUserControl.TestUserControl testUserControl1;
        private MyUserControl.TestUserControl testUserControl2;
    }
}
