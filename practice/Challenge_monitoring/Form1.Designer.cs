
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbLine = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbBaud = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbControl = new System.Windows.Forms.GroupBox();
            this.lbSens2Stats = new System.Windows.Forms.Label();
            this.lbSens1Stats = new System.Windows.Forms.Label();
            this.lbDev3Stats = new System.Windows.Forms.Label();
            this.lbDev2Stats = new System.Windows.Forms.Label();
            this.lbDev1Stats = new System.Windows.Forms.Label();
            this.lbRecvPacket = new System.Windows.Forms.Label();
            this.lbRecv = new System.Windows.Forms.Label();
            this.lbSensor2 = new System.Windows.Forms.Label();
            this.lbSensor1 = new System.Windows.Forms.Label();
            this.lbDevice3 = new System.Windows.Forms.Label();
            this.lbDevice2 = new System.Windows.Forms.Label();
            this.lbDevice1 = new System.Windows.Forms.Label();
            this.chartTH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialDevice = new System.IO.Ports.SerialPort(this.components);
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.pbDev1 = new System.Windows.Forms.PictureBox();
            this.pbDev2 = new System.Windows.Forms.PictureBox();
            this.pbDev3 = new System.Windows.Forms.PictureBox();
            this.pbSensor1 = new System.Windows.Forms.PictureBox();
            this.pbSensor2 = new System.Windows.Forms.PictureBox();
            this.gbConnect.SuspendLayout();
            this.gbControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDev1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDev2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDev3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).BeginInit();
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(455, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "라인선택";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "포트속도";
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(79, 24);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 23);
            this.cbPort.TabIndex = 1;
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
            // gbControl
            // 
            this.gbControl.Controls.Add(this.pbSensor2);
            this.gbControl.Controls.Add(this.pbSensor1);
            this.gbControl.Controls.Add(this.pbDev3);
            this.gbControl.Controls.Add(this.pbDev2);
            this.gbControl.Controls.Add(this.pbDev1);
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
            // lbSens2Stats
            // 
            this.lbSens2Stats.AutoSize = true;
            this.lbSens2Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSens2Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSens2Stats.Location = new System.Drawing.Point(256, 181);
            this.lbSens2Stats.Name = "lbSens2Stats";
            this.lbSens2Stats.Size = new System.Drawing.Size(30, 15);
            this.lbSens2Stats.TabIndex = 3;
            this.lbSens2Stats.Text = "ON";
            this.lbSens2Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSens1Stats
            // 
            this.lbSens1Stats.AutoSize = true;
            this.lbSens1Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbSens1Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbSens1Stats.Location = new System.Drawing.Point(145, 181);
            this.lbSens1Stats.Name = "lbSens1Stats";
            this.lbSens1Stats.Size = new System.Drawing.Size(30, 15);
            this.lbSens1Stats.TabIndex = 3;
            this.lbSens1Stats.Text = "ON";
            this.lbSens1Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDev3Stats
            // 
            this.lbDev3Stats.AutoSize = true;
            this.lbDev3Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDev3Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDev3Stats.Location = new System.Drawing.Point(312, 49);
            this.lbDev3Stats.Name = "lbDev3Stats";
            this.lbDev3Stats.Size = new System.Drawing.Size(30, 15);
            this.lbDev3Stats.TabIndex = 3;
            this.lbDev3Stats.Text = "ON";
            this.lbDev3Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDev2Stats
            // 
            this.lbDev2Stats.AutoSize = true;
            this.lbDev2Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDev2Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDev2Stats.Location = new System.Drawing.Point(201, 49);
            this.lbDev2Stats.Name = "lbDev2Stats";
            this.lbDev2Stats.Size = new System.Drawing.Size(30, 15);
            this.lbDev2Stats.TabIndex = 3;
            this.lbDev2Stats.Text = "ON";
            this.lbDev2Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDev1Stats
            // 
            this.lbDev1Stats.AutoSize = true;
            this.lbDev1Stats.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDev1Stats.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbDev1Stats.Location = new System.Drawing.Point(90, 49);
            this.lbDev1Stats.Name = "lbDev1Stats";
            this.lbDev1Stats.Size = new System.Drawing.Size(30, 15);
            this.lbDev1Stats.TabIndex = 3;
            this.lbDev1Stats.Text = "ON";
            this.lbDev1Stats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRecvPacket
            // 
            this.lbRecvPacket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbRecvPacket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRecvPacket.Location = new System.Drawing.Point(107, 318);
            this.lbRecvPacket.Name = "lbRecvPacket";
            this.lbRecvPacket.Size = new System.Drawing.Size(246, 26);
            this.lbRecvPacket.TabIndex = 2;
            this.lbRecvPacket.Text = "label4";
            this.lbRecvPacket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbRecv
            // 
            this.lbRecv.AutoSize = true;
            this.lbRecv.Location = new System.Drawing.Point(34, 324);
            this.lbRecv.Name = "lbRecv";
            this.lbRecv.Size = new System.Drawing.Size(67, 15);
            this.lbRecv.TabIndex = 1;
            this.lbRecv.Text = "받은패킷";
            // 
            // lbSensor2
            // 
            this.lbSensor2.AutoSize = true;
            this.lbSensor2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbSensor2.Location = new System.Drawing.Point(200, 181);
            this.lbSensor2.Name = "lbSensor2";
            this.lbSensor2.Size = new System.Drawing.Size(50, 15);
            this.lbSensor2.TabIndex = 0;
            this.lbSensor2.Text = "센서2:";
            this.lbSensor2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSensor1
            // 
            this.lbSensor1.AutoSize = true;
            this.lbSensor1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lbSensor1.Location = new System.Drawing.Point(89, 181);
            this.lbSensor1.Name = "lbSensor1";
            this.lbSensor1.Size = new System.Drawing.Size(50, 15);
            this.lbSensor1.TabIndex = 0;
            this.lbSensor1.Text = "센서1:";
            this.lbSensor1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDevice3
            // 
            this.lbDevice3.AutoSize = true;
            this.lbDevice3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDevice3.Location = new System.Drawing.Point(256, 49);
            this.lbDevice3.Name = "lbDevice3";
            this.lbDevice3.Size = new System.Drawing.Size(50, 15);
            this.lbDevice3.TabIndex = 0;
            this.lbDevice3.Text = "장비3:";
            this.lbDevice3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDevice3.Click += new System.EventHandler(this.lbDevice3_Click);
            // 
            // lbDevice2
            // 
            this.lbDevice2.AutoSize = true;
            this.lbDevice2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDevice2.Location = new System.Drawing.Point(145, 49);
            this.lbDevice2.Name = "lbDevice2";
            this.lbDevice2.Size = new System.Drawing.Size(50, 15);
            this.lbDevice2.TabIndex = 0;
            this.lbDevice2.Text = "장비2:";
            this.lbDevice2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDevice2.Click += new System.EventHandler(this.lbDevice2_Click);
            // 
            // lbDevice1
            // 
            this.lbDevice1.AutoSize = true;
            this.lbDevice1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDevice1.Location = new System.Drawing.Point(34, 49);
            this.lbDevice1.Name = "lbDevice1";
            this.lbDevice1.Size = new System.Drawing.Size(50, 15);
            this.lbDevice1.TabIndex = 0;
            this.lbDevice1.Text = "장비1:";
            this.lbDevice1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbDevice1.Click += new System.EventHandler(this.lbDevice1_Click);
            // 
            // chartTH
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTH.ChartAreas.Add(chartArea1);
            this.chartTH.Location = new System.Drawing.Point(399, 81);
            this.chartTH.Name = "chartTH";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "Humidity";
            series1.ShadowOffset = 1;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.IsXValueIndexed = true;
            series2.Name = "Temperature";
            series2.ShadowOffset = 1;
            this.chartTH.Series.Add(series1);
            this.chartTH.Series.Add(series2);
            this.chartTH.Size = new System.Drawing.Size(389, 357);
            this.chartTH.TabIndex = 2;
            this.chartTH.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "실시간 온습도 그래프";
            this.chartTH.Titles.Add(title1);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "device_off.png");
            this.imageList.Images.SetKeyName(1, "device_on.png");
            // 
            // pbDev1
            // 
            this.pbDev1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDev1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDev1.Location = new System.Drawing.Point(37, 68);
            this.pbDev1.Name = "pbDev1";
            this.pbDev1.Size = new System.Drawing.Size(80, 80);
            this.pbDev1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDev1.TabIndex = 4;
            this.pbDev1.TabStop = false;
            this.pbDev1.Click += new System.EventHandler(this.lbDevice1_Click);
            // 
            // pbDev2
            // 
            this.pbDev2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDev2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDev2.Location = new System.Drawing.Point(148, 67);
            this.pbDev2.Name = "pbDev2";
            this.pbDev2.Size = new System.Drawing.Size(80, 80);
            this.pbDev2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDev2.TabIndex = 4;
            this.pbDev2.TabStop = false;
            this.pbDev2.Click += new System.EventHandler(this.lbDevice2_Click);
            // 
            // pbDev3
            // 
            this.pbDev3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbDev3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbDev3.Location = new System.Drawing.Point(259, 67);
            this.pbDev3.Name = "pbDev3";
            this.pbDev3.Size = new System.Drawing.Size(80, 80);
            this.pbDev3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbDev3.TabIndex = 4;
            this.pbDev3.TabStop = false;
            this.pbDev3.Click += new System.EventHandler(this.lbDevice3_Click);
            // 
            // pbSensor1
            // 
            this.pbSensor1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSensor1.Location = new System.Drawing.Point(92, 199);
            this.pbSensor1.Name = "pbSensor1";
            this.pbSensor1.Size = new System.Drawing.Size(80, 80);
            this.pbSensor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSensor1.TabIndex = 4;
            this.pbSensor1.TabStop = false;
            // 
            // pbSensor2
            // 
            this.pbSensor2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSensor2.Location = new System.Drawing.Point(203, 199);
            this.pbSensor2.Name = "pbSensor2";
            this.pbSensor2.Size = new System.Drawing.Size(80, 80);
            this.pbSensor2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbSensor2.TabIndex = 4;
            this.pbSensor2.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbDev1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDev2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDev3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSensor2)).EndInit();
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
        private System.Windows.Forms.PictureBox pbSensor2;
        private System.Windows.Forms.PictureBox pbSensor1;
        private System.Windows.Forms.PictureBox pbDev3;
        private System.Windows.Forms.PictureBox pbDev2;
        private System.Windows.Forms.PictureBox pbDev1;
        private System.Windows.Forms.ImageList imageList;
    }
}

