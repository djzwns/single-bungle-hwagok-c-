
namespace FormEvent
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
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnCatch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvent
            // 
            this.btnEvent.Location = new System.Drawing.Point(12, 12);
            this.btnEvent.Name = "btnEvent";
            this.btnEvent.Size = new System.Drawing.Size(75, 66);
            this.btnEvent.TabIndex = 0;
            this.btnEvent.Text = "button";
            this.btnEvent.UseVisualStyleBackColor = true;
            this.btnEvent.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEvent_MouseDown);
            this.btnEvent.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnEvent_MouseMove);
            this.btnEvent.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnEvent_MouseUp);
            // 
            // btnCatch
            // 
            this.btnCatch.Location = new System.Drawing.Point(308, 125);
            this.btnCatch.Name = "btnCatch";
            this.btnCatch.Size = new System.Drawing.Size(55, 55);
            this.btnCatch.TabIndex = 1;
            this.btnCatch.Text = "catch me";
            this.btnCatch.UseVisualStyleBackColor = true;
            this.btnCatch.Click += new System.EventHandler(this.btnCatch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 288);
            this.Controls.Add(this.btnCatch);
            this.Controls.Add(this.btnEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnCatch;
    }
}

