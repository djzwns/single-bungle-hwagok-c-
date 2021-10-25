
namespace FirstHelloWorld
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
            this.btnHello = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnEven = new System.Windows.Forms.Button();
            this.btnTry = new System.Windows.Forms.Button();
            this.tbKor = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotalTxt = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.tbEng = new System.Windows.Forms.TextBox();
            this.tbMath = new System.Windows.Forms.TextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.labelAverageTxt = new System.Windows.Forms.Label();
            this.labelGrade = new System.Windows.Forms.Label();
            this.labelGradeTxt = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.Salmon;
            this.btnHello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHello.Location = new System.Drawing.Point(226, 56);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(182, 57);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Button";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(226, 14);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(182, 36);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "속성 변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 119);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 31);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(105, 119);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(75, 31);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "Sub";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnMul
            // 
            this.btnMul.Location = new System.Drawing.Point(24, 156);
            this.btnMul.Name = "btnMul";
            this.btnMul.Size = new System.Drawing.Size(75, 31);
            this.btnMul.TabIndex = 4;
            this.btnMul.Text = "Mul";
            this.btnMul.UseVisualStyleBackColor = true;
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(105, 156);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(75, 31);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "Div";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(21, 35);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(57, 15);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "결과값:";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(79, 35);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(15, 15);
            this.labelResult.TabIndex = 7;
            this.labelResult.Text = "0";
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(24, 88);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(75, 25);
            this.tbLeft.TabIndex = 8;
            this.tbLeft.Text = "0";
            this.tbLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(105, 88);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(75, 25);
            this.tbRight.TabIndex = 8;
            this.tbRight.Text = "0";
            this.tbRight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(24, 67);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(92, 15);
            this.label.TabIndex = 9;
            this.label.Text = "값 두개 입력";
            // 
            // btnEqual
            // 
            this.btnEqual.Location = new System.Drawing.Point(24, 193);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(75, 31);
            this.btnEqual.TabIndex = 10;
            this.btnEqual.Text = "Equal";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(105, 193);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(75, 31);
            this.btnTotal.TabIndex = 10;
            this.btnTotal.Text = "Total";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnEven
            // 
            this.btnEven.Location = new System.Drawing.Point(226, 119);
            this.btnEven.Name = "btnEven";
            this.btnEven.Size = new System.Drawing.Size(75, 31);
            this.btnEven.TabIndex = 10;
            this.btnEven.Text = "Even";
            this.btnEven.UseVisualStyleBackColor = true;
            this.btnEven.Click += new System.EventHandler(this.btnEven_Click);
            // 
            // btnTry
            // 
            this.btnTry.Location = new System.Drawing.Point(226, 156);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(75, 31);
            this.btnTry.TabIndex = 10;
            this.btnTry.Text = "Try";
            this.btnTry.UseVisualStyleBackColor = true;
            this.btnTry.Click += new System.EventHandler(this.btnTry_Click);
            // 
            // tbKor
            // 
            this.tbKor.Location = new System.Drawing.Point(24, 293);
            this.tbKor.Name = "tbKor";
            this.tbKor.Size = new System.Drawing.Size(38, 25);
            this.tbKor.TabIndex = 8;
            this.tbKor.Text = "0";
            this.tbKor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(168, 296);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(42, 15);
            this.labelTotal.TabIndex = 6;
            this.labelTotal.Text = "총점:";
            // 
            // labelTotalTxt
            // 
            this.labelTotalTxt.AutoSize = true;
            this.labelTotalTxt.Location = new System.Drawing.Point(216, 296);
            this.labelTotalTxt.Name = "labelTotalTxt";
            this.labelTotalTxt.Size = new System.Drawing.Size(15, 15);
            this.labelTotalTxt.TabIndex = 7;
            this.labelTotalTxt.Text = "0";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(24, 275);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(129, 15);
            this.labelClass.TabIndex = 9;
            this.labelClass.Text = "국어 / 영어 / 수학";
            // 
            // tbEng
            // 
            this.tbEng.Location = new System.Drawing.Point(68, 293);
            this.tbEng.Name = "tbEng";
            this.tbEng.Size = new System.Drawing.Size(38, 25);
            this.tbEng.TabIndex = 8;
            this.tbEng.Text = "0";
            this.tbEng.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbMath
            // 
            this.tbMath.Location = new System.Drawing.Point(112, 293);
            this.tbMath.Name = "tbMath";
            this.tbMath.Size = new System.Drawing.Size(38, 25);
            this.tbMath.TabIndex = 8;
            this.tbMath.Text = "0";
            this.tbMath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(168, 318);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(42, 15);
            this.labelAverage.TabIndex = 6;
            this.labelAverage.Text = "평균:";
            // 
            // labelAverageTxt
            // 
            this.labelAverageTxt.AutoSize = true;
            this.labelAverageTxt.Location = new System.Drawing.Point(216, 318);
            this.labelAverageTxt.Name = "labelAverageTxt";
            this.labelAverageTxt.Size = new System.Drawing.Size(15, 15);
            this.labelAverageTxt.TabIndex = 7;
            this.labelAverageTxt.Text = "0";
            // 
            // labelGrade
            // 
            this.labelGrade.AutoSize = true;
            this.labelGrade.Location = new System.Drawing.Point(168, 340);
            this.labelGrade.Name = "labelGrade";
            this.labelGrade.Size = new System.Drawing.Size(42, 15);
            this.labelGrade.TabIndex = 6;
            this.labelGrade.Text = "평가:";
            // 
            // labelGradeTxt
            // 
            this.labelGradeTxt.AutoSize = true;
            this.labelGradeTxt.Location = new System.Drawing.Point(216, 340);
            this.labelGradeTxt.Name = "labelGradeTxt";
            this.labelGradeTxt.Size = new System.Drawing.Size(15, 15);
            this.labelGradeTxt.TabIndex = 7;
            this.labelGradeTxt.Text = "0";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(24, 324);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(126, 31);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "Score Button";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 400);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.btnEven);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.label);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.tbMath);
            this.Controls.Add(this.tbEng);
            this.Controls.Add(this.tbKor);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.labelGradeTxt);
            this.Controls.Add(this.labelAverageTxt);
            this.Controls.Add(this.labelTotalTxt);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelGrade);
            this.Controls.Add(this.labelAverage);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "사칙연산";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnEven;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.TextBox tbKor;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotalTxt;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.TextBox tbEng;
        private System.Windows.Forms.TextBox tbMath;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.Label labelAverageTxt;
        private System.Windows.Forms.Label labelGrade;
        private System.Windows.Forms.Label labelGradeTxt;
        private System.Windows.Forms.Button btnCheck;
    }
}

