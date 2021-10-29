
namespace ScoreData
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKor = new System.Windows.Forms.TextBox();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lvResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "국어";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "영어";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "수학";
            // 
            // tbKor
            // 
            this.tbKor.Location = new System.Drawing.Point(71, 10);
            this.tbKor.Name = "tbKor";
            this.tbKor.Size = new System.Drawing.Size(100, 25);
            this.tbKor.TabIndex = 0;
            this.tbKor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKor_KeyDown);
            // 
            // tbEng
            // 
            this.tbEng.Location = new System.Drawing.Point(71, 41);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(100, 25);
            this.tbEng.TabIndex = 1;
            this.tbEng.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEng_KeyDown);
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(71, 72);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(100, 25);
            this.tbMath.TabIndex = 2;
            this.tbMath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMath_KeyDown);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(199, 72);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 25);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "결과";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(280, 72);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "클리어";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lvResult
            // 
            this.lvResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(16, 103);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(339, 97);
            this.lvResult.TabIndex = 3;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "국어";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "영어";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수학";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "총점";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "평균";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 213);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.tbKor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Score";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKor;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ListView lvResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

