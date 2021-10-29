
namespace SimpleDataManager
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.lbDataList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "데이터";
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(72, 13);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 25);
            this.tbData.TabIndex = 1;
            this.tbData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbData_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(179, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "결과";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(69, 49);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(31, 15);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "000";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(179, 144);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "클리어";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(179, 44);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(75, 25);
            this.btnSum.TabIndex = 2;
            this.btnSum.Text = "합";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(178, 75);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 25);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "최대값";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(179, 106);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(75, 25);
            this.btnMin.TabIndex = 2;
            this.btnMin.Text = "최소값";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // lbDataList
            // 
            this.lbDataList.FormattingEnabled = true;
            this.lbDataList.ItemHeight = 15;
            this.lbDataList.Location = new System.Drawing.Point(15, 75);
            this.lbDataList.Name = "lbDataList";
            this.lbDataList.Size = new System.Drawing.Size(157, 94);
            this.lbDataList.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 184);
            this.Controls.Add(this.lbDataList);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Simple Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.ListBox lbDataList;
    }
}

