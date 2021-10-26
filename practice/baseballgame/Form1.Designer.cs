
namespace baseballgame
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
            this.labelCom = new System.Windows.Forms.Label();
            this.tbComNum0 = new System.Windows.Forms.TextBox();
            this.tbComNum1 = new System.Windows.Forms.TextBox();
            this.tbComNum2 = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.tbUserNum0 = new System.Windows.Forms.TextBox();
            this.tbUserNum1 = new System.Windows.Forms.TextBox();
            this.tbUserNum2 = new System.Windows.Forms.TextBox();
            this.listResult = new System.Windows.Forms.ListBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.cbHide = new System.Windows.Forms.CheckBox();
            this.labelTimes = new System.Windows.Forms.Label();
            this.labelTimesCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelComScore = new System.Windows.Forms.Label();
            this.labelUserScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Location = new System.Drawing.Point(13, 13);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(69, 15);
            this.labelCom.TabIndex = 0;
            this.labelCom.Text = "Computer";
            // 
            // tbComNum0
            // 
            this.tbComNum0.Cursor = System.Windows.Forms.Cursors.No;
            this.tbComNum0.Enabled = false;
            this.tbComNum0.Location = new System.Drawing.Point(16, 32);
            this.tbComNum0.Name = "tbComNum0";
            this.tbComNum0.PasswordChar = '*';
            this.tbComNum0.Size = new System.Drawing.Size(66, 25);
            this.tbComNum0.TabIndex = 1;
            this.tbComNum0.Text = "0";
            this.tbComNum0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbComNum1
            // 
            this.tbComNum1.Cursor = System.Windows.Forms.Cursors.No;
            this.tbComNum1.Enabled = false;
            this.tbComNum1.Location = new System.Drawing.Point(88, 32);
            this.tbComNum1.Name = "tbComNum1";
            this.tbComNum1.PasswordChar = '*';
            this.tbComNum1.Size = new System.Drawing.Size(66, 25);
            this.tbComNum1.TabIndex = 1;
            this.tbComNum1.Text = "0";
            this.tbComNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbComNum2
            // 
            this.tbComNum2.Cursor = System.Windows.Forms.Cursors.No;
            this.tbComNum2.Enabled = false;
            this.tbComNum2.Location = new System.Drawing.Point(160, 32);
            this.tbComNum2.Name = "tbComNum2";
            this.tbComNum2.PasswordChar = '*';
            this.tbComNum2.Size = new System.Drawing.Size(66, 25);
            this.tbComNum2.TabIndex = 1;
            this.tbComNum2.Text = "0";
            this.tbComNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(13, 67);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(37, 15);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "User";
            // 
            // tbUserNum0
            // 
            this.tbUserNum0.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserNum0.Location = new System.Drawing.Point(16, 85);
            this.tbUserNum0.Name = "tbUserNum0";
            this.tbUserNum0.Size = new System.Drawing.Size(66, 25);
            this.tbUserNum0.TabIndex = 0;
            this.tbUserNum0.Text = "0";
            this.tbUserNum0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserNum0.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUserNum0_KeyUp);
            // 
            // tbUserNum1
            // 
            this.tbUserNum1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserNum1.Location = new System.Drawing.Point(88, 85);
            this.tbUserNum1.Name = "tbUserNum1";
            this.tbUserNum1.Size = new System.Drawing.Size(66, 25);
            this.tbUserNum1.TabIndex = 1;
            this.tbUserNum1.Text = "0";
            this.tbUserNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserNum1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUserNum1_KeyUp);
            // 
            // tbUserNum2
            // 
            this.tbUserNum2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserNum2.Location = new System.Drawing.Point(160, 85);
            this.tbUserNum2.Name = "tbUserNum2";
            this.tbUserNum2.Size = new System.Drawing.Size(66, 25);
            this.tbUserNum2.TabIndex = 2;
            this.tbUserNum2.Text = "0";
            this.tbUserNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUserNum2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbUserNum2_KeyUp);
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.ItemHeight = 15;
            this.listResult.Location = new System.Drawing.Point(16, 192);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(210, 154);
            this.listResult.TabIndex = 4;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(16, 116);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(210, 43);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelResult.Location = new System.Drawing.Point(16, 171);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(39, 15);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "결과";
            // 
            // cbHide
            // 
            this.cbHide.AutoSize = true;
            this.cbHide.Checked = true;
            this.cbHide.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHide.Location = new System.Drawing.Point(170, 12);
            this.cbHide.Name = "cbHide";
            this.cbHide.Size = new System.Drawing.Size(56, 19);
            this.cbHide.TabIndex = 5;
            this.cbHide.Text = "hide";
            this.cbHide.UseVisualStyleBackColor = true;
            this.cbHide.CheckedChanged += new System.EventHandler(this.cbHide_CheckedChanged);
            // 
            // labelTimes
            // 
            this.labelTimes.AutoSize = true;
            this.labelTimes.Location = new System.Drawing.Point(108, 171);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(82, 15);
            this.labelTimes.TabIndex = 6;
            this.labelTimes.Text = "남은 횟수: ";
            // 
            // labelTimesCount
            // 
            this.labelTimesCount.AutoSize = true;
            this.labelTimesCount.Location = new System.Drawing.Point(196, 171);
            this.labelTimesCount.Name = "labelTimesCount";
            this.labelTimesCount.Size = new System.Drawing.Size(15, 15);
            this.labelTimesCount.TabIndex = 6;
            this.labelTimesCount.Text = "9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(16, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "기록";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Computer: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 380);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "User: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelComScore
            // 
            this.labelComScore.AutoSize = true;
            this.labelComScore.Location = new System.Drawing.Point(144, 361);
            this.labelComScore.Name = "labelComScore";
            this.labelComScore.Size = new System.Drawing.Size(15, 15);
            this.labelComScore.TabIndex = 9;
            this.labelComScore.Text = "0";
            // 
            // labelUserScore
            // 
            this.labelUserScore.AutoSize = true;
            this.labelUserScore.Location = new System.Drawing.Point(144, 380);
            this.labelUserScore.Name = "labelUserScore";
            this.labelUserScore.Size = new System.Drawing.Size(15, 15);
            this.labelUserScore.TabIndex = 9;
            this.labelUserScore.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 411);
            this.Controls.Add(this.labelUserScore);
            this.Controls.Add(this.labelComScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTimesCount);
            this.Controls.Add(this.labelTimes);
            this.Controls.Add(this.cbHide);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.listResult);
            this.Controls.Add(this.tbUserNum2);
            this.Controls.Add(this.tbUserNum1);
            this.Controls.Add(this.tbComNum2);
            this.Controls.Add(this.tbUserNum0);
            this.Controls.Add(this.tbComNum1);
            this.Controls.Add(this.tbComNum0);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelCom);
            this.Name = "Form1";
            this.Text = "야구게임";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.TextBox tbComNum0;
        private System.Windows.Forms.TextBox tbComNum1;
        private System.Windows.Forms.TextBox tbComNum2;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox tbUserNum0;
        private System.Windows.Forms.TextBox tbUserNum1;
        private System.Windows.Forms.TextBox tbUserNum2;
        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.CheckBox cbHide;
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Label labelTimesCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelComScore;
        private System.Windows.Forms.Label labelUserScore;
    }
}

