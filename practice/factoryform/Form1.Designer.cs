
namespace factoryform
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbProductList = new System.Windows.Forms.GroupBox();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.btnProductAll = new System.Windows.Forms.Button();
            this.btnProductCompany = new System.Windows.Forms.Button();
            this.btnProductName = new System.Windows.Forms.Button();
            this.btnProductNo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.gbProductCreate = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductCompany = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbEtc = new System.Windows.Forms.TextBox();
            this.tbProductCost = new System.Windows.Forms.TextBox();
            this.tbProductEa = new System.Windows.Forms.TextBox();
            this.tbProductNo = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tbProductNoSearch_in = new System.Windows.Forms.TextBox();
            this.tbProductNo_in = new System.Windows.Forms.TextBox();
            this.tbInputEa = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInput = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProductNoSearch_in = new System.Windows.Forms.Button();
            this.dataGV_in_list = new System.Windows.Forms.DataGridView();
            this.dataGV_in_rt = new System.Windows.Forms.DataGridView();
            this.btnProductNoSearch_out = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGV_out_rt = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGV_out_list = new System.Windows.Forms.DataGridView();
            this.btnOutput = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOutputEa = new System.Windows.Forms.TextBox();
            this.tbProductNo_out = new System.Windows.Forms.TextBox();
            this.tbProductNoSearch_out = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.gbProductCreate.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_in_list)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_in_rt)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_out_rt)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_out_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(794, 444);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbProductList);
            this.tabPage1.Controls.Add(this.gbProductCreate);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 415);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "재고관리";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbProductList
            // 
            this.gbProductList.Controls.Add(this.dataGV);
            this.gbProductList.Controls.Add(this.btnProductAll);
            this.gbProductList.Controls.Add(this.btnProductCompany);
            this.gbProductList.Controls.Add(this.btnProductName);
            this.gbProductList.Controls.Add(this.btnProductNo);
            this.gbProductList.Controls.Add(this.label7);
            this.gbProductList.Controls.Add(this.tbSearch);
            this.gbProductList.Location = new System.Drawing.Point(6, 128);
            this.gbProductList.Name = "gbProductList";
            this.gbProductList.Size = new System.Drawing.Size(774, 281);
            this.gbProductList.TabIndex = 1;
            this.gbProductList.TabStop = false;
            this.gbProductList.Text = "제품목록";
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(6, 55);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 27;
            this.dataGV.Size = new System.Drawing.Size(762, 220);
            this.dataGV.TabIndex = 6;
            // 
            // btnProductAll
            // 
            this.btnProductAll.Location = new System.Drawing.Point(685, 26);
            this.btnProductAll.Name = "btnProductAll";
            this.btnProductAll.Size = new System.Drawing.Size(83, 23);
            this.btnProductAll.TabIndex = 5;
            this.btnProductAll.Text = "전체";
            this.btnProductAll.UseVisualStyleBackColor = true;
            this.btnProductAll.Click += new System.EventHandler(this.btnProductAll_Click);
            // 
            // btnProductCompany
            // 
            this.btnProductCompany.Location = new System.Drawing.Point(596, 26);
            this.btnProductCompany.Name = "btnProductCompany";
            this.btnProductCompany.Size = new System.Drawing.Size(83, 23);
            this.btnProductCompany.TabIndex = 4;
            this.btnProductCompany.Text = "제품회사";
            this.btnProductCompany.UseVisualStyleBackColor = true;
            this.btnProductCompany.Click += new System.EventHandler(this.btnProductCompany_Click);
            // 
            // btnProductName
            // 
            this.btnProductName.Location = new System.Drawing.Point(507, 25);
            this.btnProductName.Name = "btnProductName";
            this.btnProductName.Size = new System.Drawing.Size(83, 23);
            this.btnProductName.TabIndex = 3;
            this.btnProductName.Text = "제품명";
            this.btnProductName.UseVisualStyleBackColor = true;
            this.btnProductName.Click += new System.EventHandler(this.btnProductName_Click);
            // 
            // btnProductNo
            // 
            this.btnProductNo.Location = new System.Drawing.Point(418, 25);
            this.btnProductNo.Name = "btnProductNo";
            this.btnProductNo.Size = new System.Drawing.Size(83, 23);
            this.btnProductNo.TabIndex = 2;
            this.btnProductNo.Text = "제품번호";
            this.btnProductNo.UseVisualStyleBackColor = true;
            this.btnProductNo.Click += new System.EventHandler(this.btnProductNo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "검색단어";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(76, 24);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(287, 25);
            this.tbSearch.TabIndex = 0;
            // 
            // gbProductCreate
            // 
            this.gbProductCreate.Controls.Add(this.btnCreate);
            this.gbProductCreate.Controls.Add(this.label6);
            this.gbProductCreate.Controls.Add(this.label5);
            this.gbProductCreate.Controls.Add(this.label4);
            this.gbProductCreate.Controls.Add(this.label3);
            this.gbProductCreate.Controls.Add(this.label2);
            this.gbProductCreate.Controls.Add(this.label1);
            this.gbProductCreate.Controls.Add(this.tbProductCompany);
            this.gbProductCreate.Controls.Add(this.tbProductName);
            this.gbProductCreate.Controls.Add(this.tbEtc);
            this.gbProductCreate.Controls.Add(this.tbProductCost);
            this.gbProductCreate.Controls.Add(this.tbProductEa);
            this.gbProductCreate.Controls.Add(this.tbProductNo);
            this.gbProductCreate.Location = new System.Drawing.Point(6, 6);
            this.gbProductCreate.Name = "gbProductCreate";
            this.gbProductCreate.Size = new System.Drawing.Size(774, 116);
            this.gbProductCreate.TabIndex = 0;
            this.gbProductCreate.TabStop = false;
            this.gbProductCreate.Text = "제품등록";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(686, 22);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(82, 87);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "제품등록";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "제조회사";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "제품명";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "비고";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "제품단가";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "제품수량";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "제품번호";
            // 
            // tbProductCompany
            // 
            this.tbProductCompany.Location = new System.Drawing.Point(437, 53);
            this.tbProductCompany.Name = "tbProductCompany";
            this.tbProductCompany.Size = new System.Drawing.Size(243, 25);
            this.tbProductCompany.TabIndex = 4;
            this.tbProductCompany.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductCompany_KeyUp);
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(437, 22);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(243, 25);
            this.tbProductName.TabIndex = 1;
            this.tbProductName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductName_KeyUp);
            // 
            // tbEtc
            // 
            this.tbEtc.Location = new System.Drawing.Point(76, 84);
            this.tbEtc.Name = "tbEtc";
            this.tbEtc.Size = new System.Drawing.Size(604, 25);
            this.tbEtc.TabIndex = 5;
            this.tbEtc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbEtc_KeyUp);
            // 
            // tbProductCost
            // 
            this.tbProductCost.Location = new System.Drawing.Point(263, 53);
            this.tbProductCost.Name = "tbProductCost";
            this.tbProductCost.Size = new System.Drawing.Size(100, 25);
            this.tbProductCost.TabIndex = 3;
            this.tbProductCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductCost_KeyUp);
            // 
            // tbProductEa
            // 
            this.tbProductEa.Location = new System.Drawing.Point(76, 53);
            this.tbProductEa.Name = "tbProductEa";
            this.tbProductEa.Size = new System.Drawing.Size(100, 25);
            this.tbProductEa.TabIndex = 2;
            this.tbProductEa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductEa_KeyUp);
            // 
            // tbProductNo
            // 
            this.tbProductNo.Location = new System.Drawing.Point(76, 22);
            this.tbProductNo.Name = "tbProductNo";
            this.tbProductNo.Size = new System.Drawing.Size(287, 25);
            this.tbProductNo.TabIndex = 0;
            this.tbProductNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductNo_KeyUp);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnProductNoSearch_in);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnInput);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tbInputEa);
            this.tabPage2.Controls.Add(this.tbProductNo_in);
            this.tabPage2.Controls.Add(this.tbProductNoSearch_in);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 415);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "입고관리";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnProductNoSearch_out);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.btnOutput);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.tbOutputEa);
            this.tabPage3.Controls.Add(this.tbProductNo_out);
            this.tabPage3.Controls.Add(this.tbProductNoSearch_out);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 415);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "출고관리";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tbProductNoSearch_in
            // 
            this.tbProductNoSearch_in.Location = new System.Drawing.Point(18, 6);
            this.tbProductNoSearch_in.Name = "tbProductNoSearch_in";
            this.tbProductNoSearch_in.Size = new System.Drawing.Size(151, 25);
            this.tbProductNoSearch_in.TabIndex = 0;
            this.tbProductNoSearch_in.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductNoSearch_in_KeyUp);
            // 
            // tbProductNo_in
            // 
            this.tbProductNo_in.Location = new System.Drawing.Point(443, 6);
            this.tbProductNo_in.Name = "tbProductNo_in";
            this.tbProductNo_in.ReadOnly = true;
            this.tbProductNo_in.Size = new System.Drawing.Size(168, 25);
            this.tbProductNo_in.TabIndex = 2;
            // 
            // tbInputEa
            // 
            this.tbInputEa.Location = new System.Drawing.Point(443, 37);
            this.tbInputEa.Name = "tbInputEa";
            this.tbInputEa.Size = new System.Drawing.Size(168, 25);
            this.tbInputEa.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(370, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "제품번호";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "입고수량";
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(658, 6);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 56);
            this.btnInput.TabIndex = 6;
            this.btnInput.Text = "입고";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGV_in_list);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 167);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "재고 현황";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGV_in_rt);
            this.groupBox2.Location = new System.Drawing.Point(12, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(768, 167);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "입고 현황";
            // 
            // btnProductNoSearch_in
            // 
            this.btnProductNoSearch_in.Location = new System.Drawing.Point(176, 6);
            this.btnProductNoSearch_in.Name = "btnProductNoSearch_in";
            this.btnProductNoSearch_in.Size = new System.Drawing.Size(121, 25);
            this.btnProductNoSearch_in.TabIndex = 9;
            this.btnProductNoSearch_in.Text = "제품번호 검색";
            this.btnProductNoSearch_in.UseVisualStyleBackColor = true;
            this.btnProductNoSearch_in.Click += new System.EventHandler(this.btnProductNoSearch_in_Click);
            // 
            // dataGV_in_list
            // 
            this.dataGV_in_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_in_list.Location = new System.Drawing.Point(6, 24);
            this.dataGV_in_list.Name = "dataGV_in_list";
            this.dataGV_in_list.RowHeadersWidth = 51;
            this.dataGV_in_list.RowTemplate.Height = 27;
            this.dataGV_in_list.Size = new System.Drawing.Size(756, 137);
            this.dataGV_in_list.TabIndex = 0;
            this.dataGV_in_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_in_list_CellClick);
            // 
            // dataGV_in_rt
            // 
            this.dataGV_in_rt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_in_rt.Location = new System.Drawing.Point(6, 24);
            this.dataGV_in_rt.Name = "dataGV_in_rt";
            this.dataGV_in_rt.RowHeadersWidth = 51;
            this.dataGV_in_rt.RowTemplate.Height = 27;
            this.dataGV_in_rt.Size = new System.Drawing.Size(756, 141);
            this.dataGV_in_rt.TabIndex = 0;
            // 
            // btnProductNoSearch_out
            // 
            this.btnProductNoSearch_out.Location = new System.Drawing.Point(176, 6);
            this.btnProductNoSearch_out.Name = "btnProductNoSearch_out";
            this.btnProductNoSearch_out.Size = new System.Drawing.Size(121, 25);
            this.btnProductNoSearch_out.TabIndex = 18;
            this.btnProductNoSearch_out.Text = "제품번호 검색";
            this.btnProductNoSearch_out.UseVisualStyleBackColor = true;
            this.btnProductNoSearch_out.Click += new System.EventHandler(this.btnProductNoSearch_out_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGV_out_rt);
            this.groupBox3.Location = new System.Drawing.Point(12, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(768, 167);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "출고 현황";
            // 
            // dataGV_out_rt
            // 
            this.dataGV_out_rt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_out_rt.Location = new System.Drawing.Point(6, 24);
            this.dataGV_out_rt.Name = "dataGV_out_rt";
            this.dataGV_out_rt.RowHeadersWidth = 51;
            this.dataGV_out_rt.RowTemplate.Height = 27;
            this.dataGV_out_rt.Size = new System.Drawing.Size(756, 141);
            this.dataGV_out_rt.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGV_out_list);
            this.groupBox4.Location = new System.Drawing.Point(12, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(768, 167);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "재고 현황";
            // 
            // dataGV_out_list
            // 
            this.dataGV_out_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_out_list.Location = new System.Drawing.Point(6, 24);
            this.dataGV_out_list.Name = "dataGV_out_list";
            this.dataGV_out_list.RowHeadersWidth = 51;
            this.dataGV_out_list.RowTemplate.Height = 27;
            this.dataGV_out_list.Size = new System.Drawing.Size(756, 137);
            this.dataGV_out_list.TabIndex = 0;
            this.dataGV_out_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_out_list_CellClick);
            // 
            // btnOutput
            // 
            this.btnOutput.Location = new System.Drawing.Point(658, 6);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 56);
            this.btnOutput.TabIndex = 15;
            this.btnOutput.Text = "출고";
            this.btnOutput.UseVisualStyleBackColor = true;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(370, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "출고수량";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(370, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 15);
            this.label11.TabIndex = 13;
            this.label11.Text = "제품번호";
            // 
            // tbOutputEa
            // 
            this.tbOutputEa.Location = new System.Drawing.Point(443, 37);
            this.tbOutputEa.Name = "tbOutputEa";
            this.tbOutputEa.Size = new System.Drawing.Size(168, 25);
            this.tbOutputEa.TabIndex = 12;
            // 
            // tbProductNo_out
            // 
            this.tbProductNo_out.Location = new System.Drawing.Point(443, 6);
            this.tbProductNo_out.Name = "tbProductNo_out";
            this.tbProductNo_out.ReadOnly = true;
            this.tbProductNo_out.Size = new System.Drawing.Size(168, 25);
            this.tbProductNo_out.TabIndex = 11;
            // 
            // tbProductNoSearch_out
            // 
            this.tbProductNoSearch_out.Location = new System.Drawing.Point(18, 6);
            this.tbProductNoSearch_out.Name = "tbProductNoSearch_out";
            this.tbProductNoSearch_out.Size = new System.Drawing.Size(151, 25);
            this.tbProductNoSearch_out.TabIndex = 10;
            this.tbProductNoSearch_out.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProductNoSearch_out_KeyUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "재고관리";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbProductList.ResumeLayout(false);
            this.gbProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.gbProductCreate.ResumeLayout(false);
            this.gbProductCreate.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_in_list)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_in_rt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_out_rt)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_out_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox gbProductList;
        private System.Windows.Forms.GroupBox gbProductCreate;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button btnProductAll;
        private System.Windows.Forms.Button btnProductCompany;
        private System.Windows.Forms.Button btnProductName;
        private System.Windows.Forms.Button btnProductNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductCompany;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbEtc;
        private System.Windows.Forms.TextBox tbProductCost;
        private System.Windows.Forms.TextBox tbProductEa;
        private System.Windows.Forms.TextBox tbProductNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInputEa;
        private System.Windows.Forms.TextBox tbProductNo_in;
        private System.Windows.Forms.TextBox tbProductNoSearch_in;
        private System.Windows.Forms.Button btnProductNoSearch_in;
        private System.Windows.Forms.DataGridView dataGV_in_rt;
        private System.Windows.Forms.DataGridView dataGV_in_list;
        private System.Windows.Forms.Button btnProductNoSearch_out;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGV_out_rt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGV_out_list;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOutputEa;
        private System.Windows.Forms.TextBox tbProductNo_out;
        private System.Windows.Forms.TextBox tbProductNoSearch_out;
    }
}

