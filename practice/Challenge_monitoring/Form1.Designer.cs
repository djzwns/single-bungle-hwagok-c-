
namespace Challenge_monitoring
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbLine = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.chartTH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialDevice = new System.IO.Ports.SerialPort(this.components);
            this.lbDevice1 = new System.Windows.Forms.Label();
            this.lbDevice2 = new System.Windows.Forms.Label();
            this.lbDevice3 = new System.Windows.Forms.Label();
            this.lbSensor1 = new System.Windows.Forms.Label();
            this.lbSensor2 = new System.Windows.Forms.Label();
            this.lbRecv = new System.Windows.Forms.Label();
            this.lbRecvPacket = new System.Windows.Forms.Label();
            this.lbDev1Stats = new System.Windows.Forms.Label();
            this.lbDev2Stats = new System.Windows.Forms.Label();
            this.lbDev3Stats = new System.Windows.Forms.Label();
            this.lbSens1Stats = new System.Windows.Forms.Label();
            this.lbSens2Stats = new System.Windows.Forms.Label();
            this.gbConnect.SuspendLayout();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTH)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.btnStart);
            this.gbConnect.Controls.Add(this.cbLine);
            this.gbConnect.Controls.Add(this.label3);
            this.gbConnect.Controls.Add(this.cbBaud);
            this.gbConnect.Controls.Add(this.label2);
            this.gbConnect.Controls.Add(this.cbPort);
            this.gbConnect.Controls.Add(this.label1);
            this.gbConnect.Location = new System.Drawing.Point(12, 12);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Size = new System.Drawing.Size(776, 63);
            this.gbConnect.TabIndex = 0;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "라인 연결";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "포트선택";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(79, 24);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 23);
            this.cbPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "포트속도";
            // 
            // cbBaud
            // 
            this.cbBaud.FormattingEnabled = true;
            this.cbBaud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbBaud.Location = new System.Drawing.Point(300, 24);
            this.cbBaud.Name = "cbBaud";
            this.cbBaud.Size = new System.Drawing.Size(121, 23);
            this.cbBaud.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "라인선택";
            // 
            // cbLine
            // 
            this.cbLine.FormattingEnabled = true;
            this.cbLine.Items.AddRange(new object[] {
            "라인1",
            "라인2",
            "라인3"});
            this.cbLine.Location = new System.Drawing.Point(528, 24);
            this.cbLine.Name = "cbLine";
            this.cbLine.Size = new System.Drawing.Size(121, 23);
            this.cbLine.TabIndex = 5;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(671, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 23);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "실행하기";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // gbControl
            // 
            this.gbControl.Controls.Add(this.lbSens2Stats);
            this.gbControl.Controls.Add(this.lbSens1Stats);
            this.gbControl.Controls.Add(this.lbDev3Stats);
            this.gbControl.Controls.Add(this.lbDev2Stats);
            this.gbControl.Controls.Add(this.lbDev1Stats);
            this.gbControl.Controls.Add(this.lbRecvPacket);
            this.gbControl.Controls.Add(this.lbRecv);
            this.gbControl.Controls.Add(this.lbSensor2);
            this.gbControl.Controls.Add(this.lbSensor1);
            this.gbControl.Controls.Add(this.lbDevice3);
            this.gbControl.Controls.Add(this.lbDevice2);
            this.gbControl.Controls.Add(this.lbDevice1);
            this.gbControl.Location = new System.Drawing.Point(12, 81);
            this.gbControl.Name = "gbControl";
            this.gbControl.Size = new System.Drawing.Size(381, 357);
            this.gbControl.TabIndex = 1;
            this.gbControl.TabStop = false;
            this.gbControl.Text = "라인1 제어 및 상태";
            // 
            // chartTH
            // 
            chartArea2.Name = "ChartArea1";
            this.chartTH.ChartAreas.Add(chartArea2);
            this.chartTH.Location = new System.Drawing.Point(399, 81);
            this.chartTH.Name = "chartTH";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Name = "Humidity";
            series3.ShadowOffset = 1;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.IsVisibleInLegend = false;
            series4.IsXValueIndexed = true;
            series4.Name = "Temperature";
            series4.ShadowOffset = 1;
            this.chartTH.Series.Add(series3);
            this.chartTH.Series.Add(series4);
            this.chartTH.Size = new System.Drawing.Size(389, 357);
            this.chartTH.TabIndex = 2;
            this.chartTH.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "실시간 온습도 그래프";
            this.chartTH.Titles.Add(title2);
            // 
            // lbDevice1
            // 
            this.lbDevice1.AutoSize = true;
            this.lbDevice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDevice1.Location = new System.Drawing.Point(34, 49);
            this.lbDevice1.Name = "lbDevice1";
            this.lbDevice1.Size = new System.Drawing.Size(55, 15);
            this.lbDevice1.TabIndex = 0;
            this.lbDevice1.Text = "장비1: ";
            this.lbDevice1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDevice2
            // 
            this.lbDevice2.AutoSize = true;
            this.lbDevice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDevice2.Location = new System.Drawing.Point(34, 80);
            this.lbDevice2.Name = "lbDevice2";
            this.lbDevice2.Size = new System.Drawing.Size(55, 15);
            this.lbDevice2.TabIndex = 0;
            this.lbDevice2.Text = "장비2: ";
            this.lbDevice2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDevice3
            // 
            this.lbDevice3.AutoSize = true;
            this.lbDevice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDevice3.Location = new System.Drawing.Point(34, 108);
            this.lbDevice3.Name = "lbDevice3";
            this.lbDevice3.Size = new System.Drawing.Size(55, 15);
            this.lbDevice3.TabIndex = 0;
            this.lbDevice3.Text = "장비3: ";
            this.lbDevice3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSensor1
            // 
            this.lbSensor1.AutoSize = true;
            this.lbSensor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSensor1.Location = new System.Drawing.Point(34, 137);
            this.lbSensor1.Name = "lbSensor1";
            this.lbSensor1.Size = new System.Drawing.Size(55, 15);
            this.lbSensor1.TabIndex = 0;
            this.lbSensor1.Text = "센서1: ";
            this.lbSensor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSensor2
            // 
            this.lbSensor2.AutoSize = true;
            this.lbSensor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSensor2.Location = new System.Drawing.Point(34, 165);
            this.lbSensor2.Name = "lbSensor2";
            this.lbSensor2.Size = new System.Drawing.Size(55, 15);
            this.lbSensor2.TabIndex = 0;
            this.lbSensor2.Text = "센서2: ";
            this.lbSensor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRecv
            // 
            this.lbRecv.AutoSize = true;
            this.lbRecv.Location = new System.Drawing.Point(34, 300);
            this.lbRecv.Name = "lbRecv";
            this.lbRecv.Size = new System.Drawing.Size(67, 15);
            this.lbRecv.TabIndex = 1;
            this.lbRecv.Text = "받은패킷";
            // 
            // lbRecvPacket
            // 
            this.lbRecvPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRecvPacket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecvPacket.Location = new System.Drawing.Point(107, 294);
            this.lbRecvPacket.Name = "lbRecvPacket";
            this.lbRecvPacket.Size = new System.Drawing.Size(246, 26);
            this.lbRecvPacket.TabIndex = 2;
            this.lbRecvPacket.Text = "label4";
            this.lbRecvPacket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDev1Stats
            // 
            this.lbDev1Stats.AutoSize = true;
            this.lbDev1Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDev1Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDev1Stats.Location = new System.Drawing.Point(95, 49);
            this.lbDev1Stats.Name = "lbDev1Stats";
            this.lbDev1Stats.Size = new System.Drawing.Size(30, 15);
            this.lbDev1Stats.TabIndex = 3;
            this.lbDev1Stats.Text = "ON";
            this.lbDev1Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDev2Stats
            // 
            this.lbDev2Stats.AutoSize = true;
            this.lbDev2Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDev2Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDev2Stats.Location = new System.Drawing.Point(95, 80);
            this.lbDev2Stats.Name = "lbDev2Stats";
            this.lbDev2Stats.Size = new System.Drawing.Size(30, 15);
            this.lbDev2Stats.TabIndex = 3;
            this.lbDev2Stats.Text = "ON";
            this.lbDev2Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDev3Stats
            // 
            this.lbDev3Stats.AutoSize = true;
            this.lbDev3Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDev3Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDev3Stats.Location = new System.Drawing.Point(95, 108);
            this.lbDev3Stats.Name = "lbDev3Stats";
            this.lbDev3Stats.Size = new System.Drawing.Size(30, 15);
            this.lbDev3Stats.TabIndex = 3;
            this.lbDev3Stats.Text = "ON";
            this.lbDev3Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSens1Stats
            // 
            this.lbSens1Stats.AutoSize = true;
            this.lbSens1Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSens1Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSens1Stats.Location = new System.Drawing.Point(95, 137);
            this.lbSens1Stats.Name = "lbSens1Stats";
            this.lbSens1Stats.Size = new System.Drawing.Size(30, 15);
            this.lbSens1Stats.TabIndex = 3;
            this.lbSens1Stats.Text = "ON";
            this.lbSens1Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSens2Stats
            // 
            this.lbSens2Stats.AutoSize = true;
            this.lbSens2Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSens2Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSens2Stats.Location = new System.Drawing.Point(95, 165);
            this.lbSens2Stats.Name = "lbSens2Stats";
            this.lbSens2Stats.Size = new System.Drawing.Size(30, 15);
            this.lbSens2Stats.TabIndex = 3;
            this.lbSens2Stats.Text = "ON";
            this.lbSens2Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartTH);
            this.Controls.Add(this.gbControl);
            this.Controls.Add(this.gbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.gbControl.ResumeLayout(false);
            this.gbControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbBaud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbControl;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTH;
        private System.IO.Ports.SerialPort serialDevice;
        private System.Windows.Forms.Label lbSens2Stats;
        private System.Windows.Forms.Label lbSens1Stats;
        private System.Windows.Forms.Label lbDev3Stats;
        private System.Windows.Forms.Label lbDev2Stats;
        private System.Windows.Forms.Label lbDev1Stats;
        private System.Windows.Forms.Label lbRecvPacket;
        private System.Windows.Forms.Label lbRecv;
        private System.Windows.Forms.Label lbSensor2;
        private System.Windows.Forms.Label lbSensor1;
        private System.Windows.Forms.Label lbDevice3;
        private System.Windows.Forms.Label lbDevice2;
        private System.Windows.Forms.Label lbDevice1;
    }
}

