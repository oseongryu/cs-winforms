namespace F5074.DevExpressWinforms.MyForm.C_Charts
{
    partial class ucValuePresenter
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
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.tableLayoutPanel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.labelTitle, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.labelValue, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.labelLine, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(475, 129);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.Gray;
            this.labelTitle.Location = new System.Drawing.Point(10, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(462, 38);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValue.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(10, 38);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(462, 91);
            this.labelValue.TabIndex = 1;
            this.labelValue.Text = "value";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLine
            // 
            this.labelLine.BackColor = System.Drawing.Color.Silver;
            this.labelLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLine.Location = new System.Drawing.Point(0, 0);
            this.labelLine.Margin = new System.Windows.Forms.Padding(0);
            this.labelLine.Name = "labelLine";
            this.tableLayoutPanel7.SetRowSpan(this.labelLine, 2);
            this.labelLine.Size = new System.Drawing.Size(1, 129);
            this.labelLine.TabIndex = 2;
            // 
            // ucValuePresenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel7);
            this.Name = "ucValuePresenter";
            this.Size = new System.Drawing.Size(475, 129);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelLine;
    }
}
