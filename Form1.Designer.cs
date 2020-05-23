namespace AmbitAAC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDevice1Connect = new System.Windows.Forms.Button();
            this.cbxCOMS = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdLQ = new System.Windows.Forms.RadioButton();
            this.cbRework = new System.Windows.Forms.CheckBox();
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.rdPack = new System.Windows.Forms.RadioButton();
            this.rdNI = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 75);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnDevice1Connect);
            this.panel4.Controls.Add(this.cbxCOMS);
            this.panel4.Controls.Add(this.btnExport);
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtLot);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtSN);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(223, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(845, 75);
            this.panel4.TabIndex = 1;
            // 
            // btnDevice1Connect
            // 
            this.btnDevice1Connect.Location = new System.Drawing.Point(199, 26);
            this.btnDevice1Connect.Name = "btnDevice1Connect";
            this.btnDevice1Connect.Size = new System.Drawing.Size(29, 25);
            this.btnDevice1Connect.TabIndex = 39;
            this.btnDevice1Connect.Text = "连接";
            this.btnDevice1Connect.UseVisualStyleBackColor = true;
            this.btnDevice1Connect.Click += new System.EventHandler(this.btnDevice1Connect_Click);
            // 
            // cbxCOMS
            // 
            this.cbxCOMS.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbxCOMS.FormattingEnabled = true;
            this.cbxCOMS.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.cbxCOMS.Location = new System.Drawing.Point(91, 24);
            this.cbxCOMS.Name = "cbxCOMS";
            this.cbxCOMS.Size = new System.Drawing.Size(102, 28);
            this.cbxCOMS.TabIndex = 38;
            // 
            // btnExport
            // 
            this.btnExport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(784, 1);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(53, 71);
            this.btnExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnExport.TabIndex = 5;
            this.btnExport.TabStop = false;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(703, 1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 72);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLot
            // 
            this.txtLot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLot.Location = new System.Drawing.Point(507, 27);
            this.txtLot.Name = "txtLot";
            this.txtLot.Size = new System.Drawing.Size(190, 20);
            this.txtLot.TabIndex = 3;
            this.txtLot.Click += new System.EventHandler(this.txtLot_Click);
            this.txtLot.TextChanged += new System.EventHandler(this.txtLot_TextChanged);
            this.txtLot.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLot_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(455, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lô/批次:";
            // 
            // txtSN
            // 
            this.txtSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSN.Location = new System.Drawing.Point(260, 27);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(189, 20);
            this.txtSN.TabIndex = 1;
            this.txtSN.Click += new System.EventHandler(this.txtSN_Click);
            this.txtSN.TextChanged += new System.EventHandler(this.txtSN_TextChanged);
            this.txtSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSN_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "reader扫码枪:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SN:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.rdLQ);
            this.panel3.Controls.Add(this.cbRework);
            this.panel3.Controls.Add(this.cbModel);
            this.panel3.Controls.Add(this.rdPack);
            this.panel3.Controls.Add(this.rdNI);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(223, 75);
            this.panel3.TabIndex = 0;
            // 
            // rdLQ
            // 
            this.rdLQ.AutoSize = true;
            this.rdLQ.Location = new System.Drawing.Point(11, 48);
            this.rdLQ.Name = "rdLQ";
            this.rdLQ.Size = new System.Drawing.Size(88, 17);
            this.rdLQ.TabIndex = 4;
            this.rdLQ.Text = "Dò Khí/漏气";
            this.rdLQ.UseVisualStyleBackColor = true;
            this.rdLQ.CheckedChanged += new System.EventHandler(this.rdLQ_CheckedChanged);
            // 
            // cbRework
            // 
            this.cbRework.AutoSize = true;
            this.cbRework.Location = new System.Drawing.Point(129, 28);
            this.cbRework.Name = "cbRework";
            this.cbRework.Size = new System.Drawing.Size(88, 17);
            this.cbRework.TabIndex = 3;
            this.cbRework.Text = "Làm lại/返工";
            this.cbRework.UseVisualStyleBackColor = true;
            this.cbRework.Visible = false;
            this.cbRework.CheckedChanged += new System.EventHandler(this.cbRework_CheckedChanged);
            // 
            // cbModel
            // 
            this.cbModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Items.AddRange(new object[] {
            "HUAWEI",
            "OPPO",
            "SAMSUNG",
            "MEIZU",
            "MICROSOFT",
            "VIVO",
            "XIAOMI",
            "MOTO",
            "SONY"});
            this.cbModel.Location = new System.Drawing.Point(87, 2);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(121, 21);
            this.cbModel.TabIndex = 2;
            this.cbModel.SelectedIndexChanged += new System.EventHandler(this.cbModel_SelectedIndexChanged);
            // 
            // rdPack
            // 
            this.rdPack.AutoSize = true;
            this.rdPack.Location = new System.Drawing.Point(11, 27);
            this.rdPack.Name = "rdPack";
            this.rdPack.Size = new System.Drawing.Size(109, 17);
            this.rdPack.TabIndex = 1;
            this.rdPack.Text = "Đóng gói/打包房";
            this.rdPack.UseVisualStyleBackColor = true;
            this.rdPack.CheckedChanged += new System.EventHandler(this.rdPack_CheckedChanged);
            // 
            // rdNI
            // 
            this.rdNI.AutoSize = true;
            this.rdNI.Checked = true;
            this.rdNI.Location = new System.Drawing.Point(11, 7);
            this.rdNI.Name = "rdNI";
            this.rdNI.Size = new System.Drawing.Size(65, 17);
            this.rdNI.TabIndex = 0;
            this.rdNI.TabStop = true;
            this.rdNI.Text = "NI/性能";
            this.rdNI.UseVisualStyleBackColor = true;
            this.rdNI.CheckedChanged += new System.EventHandler(this.rdNI_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 420);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1068, 420);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 495);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AmbitAAC - Version 1.3.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExport)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtLot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdPack;
        private System.Windows.Forms.RadioButton rdNI;
        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.CheckBox cbRework;
        private System.Windows.Forms.PictureBox btnExport;
        private System.Windows.Forms.RadioButton rdLQ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbxCOMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDevice1Connect;
    }
}

