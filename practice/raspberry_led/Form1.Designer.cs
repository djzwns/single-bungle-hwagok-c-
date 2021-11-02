
namespace raspberry_led
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
            this.components = new System.ComponentModel.Container();
            this.btnLED1 = new System.Windows.Forms.Button();
            this.btnLED2 = new System.Windows.Forms.Button();
            this.btnLED3 = new System.Windows.Forms.Button();
            this.btnSw1 = new System.Windows.Forms.Button();
            this.btnSw2 = new System.Windows.Forms.Button();
            this.tbCommand = new System.Windows.Forms.TextBox();
            this.btnCmdSend = new System.Windows.Forms.Button();
            this.serialDevice = new System.IO.Ports.SerialPort(this.components);
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLED1
            // 
            this.btnLED1.Location = new System.Drawing.Point(38, 76);
            this.btnLED1.Name = "btnLED1";
            this.btnLED1.Size = new System.Drawing.Size(75, 75);
            this.btnLED1.TabIndex = 0;
            this.btnLED1.Text = "LED1";
            this.btnLED1.UseVisualStyleBackColor = true;
            // 
            // btnLED2
            // 
            this.btnLED2.Location = new System.Drawing.Point(170, 76);
            this.btnLED2.Name = "btnLED2";
            this.btnLED2.Size = new System.Drawing.Size(75, 75);
            this.btnLED2.TabIndex = 0;
            this.btnLED2.Text = "LED2";
            this.btnLED2.UseVisualStyleBackColor = true;
            // 
            // btnLED3
            // 
            this.btnLED3.Location = new System.Drawing.Point(294, 76);
            this.btnLED3.Name = "btnLED3";
            this.btnLED3.Size = new System.Drawing.Size(75, 75);
            this.btnLED3.TabIndex = 0;
            this.btnLED3.Text = "LED3";
            this.btnLED3.UseVisualStyleBackColor = true;
            // 
            // btnSw1
            // 
            this.btnSw1.Location = new System.Drawing.Point(71, 197);
            this.btnSw1.Name = "btnSw1";
            this.btnSw1.Size = new System.Drawing.Size(110, 23);
            this.btnSw1.TabIndex = 1;
            this.btnSw1.Text = "SW1 OFF";
            this.btnSw1.UseVisualStyleBackColor = true;
            // 
            // btnSw2
            // 
            this.btnSw2.Location = new System.Drawing.Point(236, 197);
            this.btnSw2.Name = "btnSw2";
            this.btnSw2.Size = new System.Drawing.Size(111, 23);
            this.btnSw2.TabIndex = 1;
            this.btnSw2.Text = "SW2 OFF";
            this.btnSw2.UseVisualStyleBackColor = true;
            // 
            // tbCommand
            // 
            this.tbCommand.Location = new System.Drawing.Point(27, 293);
            this.tbCommand.Name = "tbCommand";
            this.tbCommand.Size = new System.Drawing.Size(250, 25);
            this.tbCommand.TabIndex = 2;
            this.tbCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbCommand_KeyDown);
            // 
            // btnCmdSend
            // 
            this.btnCmdSend.Location = new System.Drawing.Point(294, 295);
            this.btnCmdSend.Name = "btnCmdSend";
            this.btnCmdSend.Size = new System.Drawing.Size(75, 23);
            this.btnCmdSend.TabIndex = 3;
            this.btnCmdSend.Text = "명령수행";
            this.btnCmdSend.UseVisualStyleBackColor = true;
            this.btnCmdSend.Click += new System.EventHandler(this.btnCmdSend_Click);
            // 
            // serialDevice
            // 
            this.serialDevice.BaudRate = 19200;
            this.serialDevice.PortName = "COM10";
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(38, 22);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 23);
            this.cbComPort.TabIndex = 4;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(183, 22);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 355);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cbComPort);
            this.Controls.Add(this.btnCmdSend);
            this.Controls.Add(this.tbCommand);
            this.Controls.Add(this.btnSw2);
            this.Controls.Add(this.btnSw1);
            this.Controls.Add(this.btnLED3);
            this.Controls.Add(this.btnLED2);
            this.Controls.Add(this.btnLED1);
            this.Name = "Form1";
            this.Text = "시리얼 연동";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLED1;
        private System.Windows.Forms.Button btnLED2;
        private System.Windows.Forms.Button btnLED3;
        private System.Windows.Forms.Button btnSw1;
        private System.Windows.Forms.Button btnSw2;
        private System.Windows.Forms.TextBox tbCommand;
        private System.Windows.Forms.Button btnCmdSend;
        private System.IO.Ports.SerialPort serialDevice;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Button btnConnect;
    }
}

