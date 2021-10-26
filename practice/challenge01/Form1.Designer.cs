
namespace challenge01
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
            this.labelScore = new System.Windows.Forms.Label();
            this.labelScoreDesc = new System.Windows.Forms.Label();
            this.tbKor = new System.Windows.Forms.TextBox();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.btnScoreCalc = new System.Windows.Forms.Button();
            this.labelTotalTitle = new System.Windows.Forms.Label();
            this.labelAverageTitle = new System.Windows.Forms.Label();
            this.labelGradeTitle = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.list99 = new System.Windows.Forms.ListBox();
            this.btn99 = new System.Windows.Forms.Button();
            this.tbDan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(12, 33);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(129, 15);
            this.labelScore.TabIndex = 0;
            this.labelScore.Text = "국어 / 영어 / 수학";
            // 
            // labelScoreDesc
            // 
            this.labelScoreDesc.AutoSize = true;
            this.labelScoreDesc.Location = new System.Drawing.Point(12, 9);
            this.labelScoreDesc.Name = "labelScoreDesc";
            this.labelScoreDesc.Size = new System.Drawing.Size(72, 15);
            this.labelScoreDesc.TabIndex = 0;
            this.labelScoreDesc.Text = "점수 입력";
            // 
            // tbKor
            // 
            this.tbKor.Location = new System.Drawing.Point(15, 52);
            this.tbKor.Name = "tbKor";
            this.tbKor.Size = new System.Drawing.Size(38, 25);
            this.tbKor.TabIndex = 1;
            this.tbKor.Text = "0";
            this.tbKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbEng
            // 
            this.tbEng.Location = new System.Drawing.Point(59, 52);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(38, 25);
            this.tbEng.TabIndex = 1;
            this.tbEng.Text = "0";
            this.tbEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(103, 51);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(38, 25);
            this.tbMath.TabIndex = 1;
            this.tbMath.Text = "0";
            this.tbMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnScoreCalc
            // 
            this.btnScoreCalc.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnScoreCalc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnScoreCalc.Location = new System.Drawing.Point(13, 84);
            this.btnScoreCalc.Name = "btnScoreCalc";
            this.btnScoreCalc.Size = new System.Drawing.Size(128, 47);
            this.btnScoreCalc.TabIndex = 2;
            this.btnScoreCalc.Text = "Score Button";
            this.btnScoreCalc.UseVisualStyleBackColor = false;
            this.btnScoreCalc.Click += new System.EventHandler(this.btnScoreCalc_Click);
            // 
            // labelTotalTitle
            // 
            this.labelTotalTitle.AutoSize = true;
            this.labelTotalTitle.Location = new System.Drawing.Point(181, 62);
            this.labelTotalTitle.Name = "labelTotalTitle";
            this.labelTotalTitle.Size = new System.Drawing.Size(42, 15);
            this.labelTotalTitle.TabIndex = 3;
            this.labelTotalTitle.Text = "총점:";
            // 
            // labelAverageTitle
            // 
            this.labelAverageTitle.AutoSize = true;
            this.labelAverageTitle.Location = new System.Drawing.Point(181, 86);
            this.labelAverageTitle.Name = "labelAverageTitle";
            this.labelAverageTitle.Size = new System.Drawing.Size(42, 15);
            this.labelAverageTitle.TabIndex = 3;
            this.labelAverageTitle.Text = "평균:";
            // 
            // labelGradeTitle
            // 
            this.labelGradeTitle.AutoSize = true;
            this.labelGradeTitle.Location = new System.Drawing.Point(181, 110);
            this.labelGradeTitle.Name = "labelGradeTitle";
            this.labelGradeTitle.Size = new System.Drawing.Size(42, 15);
            this.labelGradeTitle.TabIndex = 3;
            this.labelGradeTitle.Text = "평가:";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(229, 61);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(15, 15);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "0";
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(229, 86);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(15, 15);
            this.labelAverage.TabIndex = 3;
            this.labelAverage.Text = "0";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(229, 110);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(15, 15);
            this.labelGrade.TabIndex = 3;
            this.labelGrade.Text = "0";
            // 
            // list99
            // 
            this.list99.FormattingEnabled = true;
            this.list99.ItemHeight = 15;
            this.list99.Location = new System.Drawing.Point(12, 187);
            this.list99.Name = "list99";
            this.list99.Size = new System.Drawing.Size(309, 214);
            this.list99.TabIndex = 4;
            // 
            // btn99
            // 
            this.btn99.Location = new System.Drawing.Point(72, 148);
            this.btn99.Name = "btn99";
            this.btn99.Size = new System.Drawing.Size(75, 33);
            this.btn99.TabIndex = 6;
            this.btn99.Text = "구구단";
            this.btn99.UseVisualStyleBackColor = true;
            this.btn99.Click += new System.EventHandler(this.btn99_Click);
            // 
            // tbDan
            // 
            this.tbDan.Location = new System.Drawing.Point(13, 156);
            this.tbDan.Name = "tbDan";
            this.tbDan.Size = new System.Drawing.Size(53, 25);
            this.tbDan.TabIndex = 7;
            this.tbDan.Text = "2";
            this.tbDan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 413);
            this.Controls.Add(this.tbDan);
            this.Controls.Add(this.btn99);
            this.Controls.Add(this.list99);
            this.Controls.Add(this.labelGradeTitle);
            this.Controls.Add(this.labelAverageTitle);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTotalTitle);
            this.Controls.Add(this.btnScoreCalc);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.tbKor);
            this.Controls.Add(this.labelScoreDesc);
            this.Controls.Add(this.labelScore);
            this.Name = "Form1";
            this.Text = "점수 계산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelScoreDesc;
        private System.Windows.Forms.TextBox tbKor;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Button btnScoreCalc;
        private System.Windows.Forms.Label labelTotalTitle;
        private System.Windows.Forms.Label labelAverageTitle;
        private System.Windows.Forms.Label labelGradeTitle;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.ListBox list99;
        private System.Windows.Forms.Button btn99;
        private System.Windows.Forms.TextBox tbDan;
    }
}

