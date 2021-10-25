
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
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.BackColor = System.Drawing.Color.Salmon;
            this.btnHello.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHello.Location = new System.Drawing.Point(104, 131);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(210, 106);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "Button";
            this.btnHello.UseVisualStyleBackColor = false;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(104, 42);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(210, 48);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "속성 변경";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 249);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Hello Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnChange;
    }
}

