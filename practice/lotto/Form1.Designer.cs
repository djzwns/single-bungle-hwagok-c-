
namespace lotto
{
    partial class Lotto
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
            this.labelWinTitle = new System.Windows.Forms.Label();
            this.tbWin0 = new System.Windows.Forms.TextBox();
            this.tbWin1 = new System.Windows.Forms.TextBox();
            this.tbWin2 = new System.Windows.Forms.TextBox();
            this.tbWin3 = new System.Windows.Forms.TextBox();
            this.tbWin4 = new System.Windows.Forms.TextBox();
            this.tbWin5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbWinBonus = new System.Windows.Forms.TextBox();
            this.btnPickNumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelWinTitle
            // 
            this.labelWinTitle.AutoSize = true;
            this.labelWinTitle.Location = new System.Drawing.Point(13, 13);
            this.labelWinTitle.Name = "labelWinTitle";
            this.labelWinTitle.Size = new System.Drawing.Size(67, 15);
            this.labelWinTitle.TabIndex = 98;
            this.labelWinTitle.Text = "당첨번호";
            // 
            // tbWin0
            // 
            this.tbWin0.Font = new System.Drawing.Font("굴림", 13F);
            this.tbWin0.Location = new System.Drawing.Point(16, 31);
            this.tbWin0.Name = "tbWin0";
            this.tbWin0.Size = new System.Drawing.Size(43, 32);
            this.tbWin0.TabIndex = 1;
            this.tbWin0.Text = "*";
            this.tbWin0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWin1
            // 
            this.tbWin1.Font = new System.Drawing.Font("굴림", 13F);
            this.tbWin1.Location = new System.Drawing.Point(65, 31);
            this.tbWin1.Name = "tbWin1";
            this.tbWin1.Size = new System.Drawing.Size(43, 32);
            this.tbWin1.TabIndex = 2;
            this.tbWin1.Text = "*";
            this.tbWin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWin2
            // 
            this.tbWin2.Font = new System.Drawing.Font("굴림", 13F);
            this.tbWin2.Location = new System.Drawing.Point(114, 31);
            this.tbWin2.Name = "tbWin2";
            this.tbWin2.Size = new System.Drawing.Size(43, 32);
            this.tbWin2.TabIndex = 3;
            this.tbWin2.Text = "*";
            this.tbWin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWin3
            // 
            this.tbWin3.Font = new System.Drawing.Font("굴림", 13F);
            this.tbWin3.Location = new System.Drawing.Point(163, 31);
            this.tbWin3.Name = "tbWin3";
            this.tbWin3.Size = new System.Drawing.Size(43, 32);
            this.tbWin3.TabIndex = 4;
            this.tbWin3.Text = "*";
            this.tbWin3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWin4
            // 
            this.tbWin4.Font = new System.Drawing.Font("굴림", 13F);
            this.tbWin4.Location = new System.Drawing.Point(212, 31);
            this.tbWin4.Name = "tbWin4";
            this.tbWin4.Size = new System.Drawing.Size(43, 32);
            this.tbWin4.TabIndex = 5;
            this.tbWin4.Text = "*";
            this.tbWin4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWin5
            // 
            this.tbWin5.Font = new System.Drawing.Font("굴림", 13F);
            this.tbWin5.Location = new System.Drawing.Point(261, 31);
            this.tbWin5.Name = "tbWin5";
            this.tbWin5.Size = new System.Drawing.Size(43, 32);
            this.tbWin5.TabIndex = 6;
            this.tbWin5.Text = "*";
            this.tbWin5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 99;
            this.label1.Text = "+";
            // 
            // tbWinBonus
            // 
            this.tbWinBonus.Font = new System.Drawing.Font("굴림", 13F);
            this.tbWinBonus.Location = new System.Drawing.Point(331, 31);
            this.tbWinBonus.Name = "tbWinBonus";
            this.tbWinBonus.Size = new System.Drawing.Size(43, 32);
            this.tbWinBonus.TabIndex = 7;
            this.tbWinBonus.Text = "*";
            this.tbWinBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPickNumber
            // 
            this.btnPickNumber.Location = new System.Drawing.Point(12, 69);
            this.btnPickNumber.Name = "btnPickNumber";
            this.btnPickNumber.Size = new System.Drawing.Size(365, 80);
            this.btnPickNumber.TabIndex = 0;
            this.btnPickNumber.Text = "로또롤ㄹ롤로";
            this.btnPickNumber.UseVisualStyleBackColor = true;
            this.btnPickNumber.Click += new System.EventHandler(this.btnPickNumber_Click);
            // 
            // Lotto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 159);
            this.Controls.Add(this.btnPickNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbWinBonus);
            this.Controls.Add(this.tbWin5);
            this.Controls.Add(this.tbWin4);
            this.Controls.Add(this.tbWin3);
            this.Controls.Add(this.tbWin2);
            this.Controls.Add(this.tbWin1);
            this.Controls.Add(this.tbWin0);
            this.Controls.Add(this.labelWinTitle);
            this.Name = "Lotto";
            this.Text = "Lotto";
            this.Load += new System.EventHandler(this.Lotto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWinTitle;
        private System.Windows.Forms.TextBox tbWin0;
        private System.Windows.Forms.TextBox tbWin1;
        private System.Windows.Forms.TextBox tbWin2;
        private System.Windows.Forms.TextBox tbWin3;
        private System.Windows.Forms.TextBox tbWin4;
        private System.Windows.Forms.TextBox tbWin5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWinBonus;
        private System.Windows.Forms.Button btnPickNumber;
    }
}

