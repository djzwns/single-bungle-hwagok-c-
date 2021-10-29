
namespace SerialBase
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
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.lbMessageBox = new System.Windows.Forms.ListBox();
            this.tbSendBox = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.serialDevice = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(32, 40);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(121, 23);
            this.cbComPort.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "포트 번호";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Baud Rate";
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.cbBaudRate.Location = new System.Drawing.Point(181, 40);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 23);
            this.cbBaudRate.TabIndex = 3;
            this.cbBaudRate.Text = "9600";
            // 
            // btnConnection
            // 
            this.btnConnection.Location = new System.Drawing.Point(328, 39);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(137, 24);
            this.btnConnection.TabIndex = 4;
            this.btnConnection.Text = "COM 포트 연결";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(29, 87);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(52, 15);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "메세지";
            // 
            // lbMessageBox
            // 
            this.lbMessageBox.FormattingEnabled = true;
            this.lbMessageBox.ItemHeight = 15;
            this.lbMessageBox.Location = new System.Drawing.Point(32, 105);
            this.lbMessageBox.Name = "lbMessageBox";
            this.lbMessageBox.Size = new System.Drawing.Size(433, 199);
            this.lbMessageBox.TabIndex = 6;
            this.lbMessageBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbMessageBox_DrawItem);
            // 
            // tbSendBox
            // 
            this.tbSendBox.Location = new System.Drawing.Point(32, 311);
            this.tbSendBox.Name = "tbSendBox";
            this.tbSendBox.Size = new System.Drawing.Size(336, 25);
            this.tbSendBox.TabIndex = 7;
            this.tbSendBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSendBox_KeyDown);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(374, 311);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(91, 25);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "전송";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // serialDevice
            // 
            this.serialDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialDevice_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 358);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbSendBox);
            this.Controls.Add(this.lbMessageBox);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.cbBaudRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbComPort);
            this.Name = "Form1";
            this.Text = "Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ListBox lbMessageBox;
        private System.Windows.Forms.TextBox tbSendBox;
        private System.Windows.Forms.Button btnSend;
        private System.IO.Ports.SerialPort serialDevice;
    }
}

