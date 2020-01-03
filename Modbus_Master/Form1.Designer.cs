namespace Modbus_Master
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_connect = new System.Windows.Forms.Button();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_SlaveID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_FunCode = new System.Windows.Forms.ComboBox();
            this.textBox_startAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_numInputs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel_meg = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_errImage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel_err = new System.Windows.Forms.ToolStripLabel();
            this.btn_Read = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_Write = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(47, 40);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(252, 7);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_show.Size = new System.Drawing.Size(358, 193);
            this.txt_show.TabIndex = 1;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(35, 13);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(112, 20);
            this.txt_ip.TabIndex = 2;
            this.txt_ip.Text = "127.0.0.1";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(186, 13);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(45, 20);
            this.txt_port.TabIndex = 3;
            this.txt_port.Text = "502";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "从站号";
            // 
            // textBox_SlaveID
            // 
            this.textBox_SlaveID.Location = new System.Drawing.Point(77, 115);
            this.textBox_SlaveID.Name = "textBox_SlaveID";
            this.textBox_SlaveID.Size = new System.Drawing.Size(45, 20);
            this.textBox_SlaveID.TabIndex = 7;
            this.textBox_SlaveID.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "功能码";
            // 
            // comboBox_FunCode
            // 
            this.comboBox_FunCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_FunCode.Items.AddRange(new object[] {
            "01 Read Coils (0x)",
            "02 Read Discrete Inputs (1x)",
            "03 Read Holding Registers [4x]",
            "04 Read Input Registers [3x]"});
            this.comboBox_FunCode.Location = new System.Drawing.Point(77, 152);
            this.comboBox_FunCode.Name = "comboBox_FunCode";
            this.comboBox_FunCode.Size = new System.Drawing.Size(153, 21);
            this.comboBox_FunCode.TabIndex = 9;
            // 
            // textBox_startAddress
            // 
            this.textBox_startAddress.Location = new System.Drawing.Point(77, 183);
            this.textBox_startAddress.Name = "textBox_startAddress";
            this.textBox_startAddress.Size = new System.Drawing.Size(45, 20);
            this.textBox_startAddress.TabIndex = 11;
            this.textBox_startAddress.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "起始地址";
            // 
            // textBox_numInputs
            // 
            this.textBox_numInputs.Location = new System.Drawing.Point(186, 183);
            this.textBox_numInputs.Name = "textBox_numInputs";
            this.textBox_numInputs.Size = new System.Drawing.Size(45, 20);
            this.textBox_numInputs.TabIndex = 13;
            this.textBox_numInputs.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(128, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "地址长度";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.toolStripLabel_meg,
            this.toolStripLabel_errImage,
            this.toolStripLabel_err});
            this.toolStrip1.Location = new System.Drawing.Point(0, 638);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(614, 25);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(22, 22);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel_meg
            // 
            this.toolStripLabel_meg.AutoSize = false;
            this.toolStripLabel_meg.Name = "toolStripLabel_meg";
            this.toolStripLabel_meg.Size = new System.Drawing.Size(180, 22);
            this.toolStripLabel_meg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripLabel_errImage
            // 
            this.toolStripLabel_errImage.AutoSize = false;
            this.toolStripLabel_errImage.Name = "toolStripLabel_errImage";
            this.toolStripLabel_errImage.Size = new System.Drawing.Size(22, 22);
            // 
            // toolStripLabel_err
            // 
            this.toolStripLabel_err.AutoSize = false;
            this.toolStripLabel_err.Name = "toolStripLabel_err";
            this.toolStripLabel_err.Size = new System.Drawing.Size(340, 22);
            this.toolStripLabel_err.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Read
            // 
            this.btn_Read.Location = new System.Drawing.Point(128, 40);
            this.btn_Read.Name = "btn_Read";
            this.btn_Read.Size = new System.Drawing.Size(75, 23);
            this.btn_Read.TabIndex = 16;
            this.btn_Read.Text = "读取";
            this.btn_Read.UseVisualStyleBackColor = true;
            this.btn_Read.Click += new System.EventHandler(this.btn_Read_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(47, 69);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 17;
            this.btn_disconnect.Text = "断开";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_Write
            // 
            this.btn_Write.Location = new System.Drawing.Point(128, 69);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(75, 23);
            this.btn_Write.TabIndex = 18;
            this.btn_Write.Text = "写入";
            this.btn_Write.UseVisualStyleBackColor = true;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 233);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(598, 402);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 663);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_disconnect);
            this.Controls.Add(this.btn_Read);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox_numInputs);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_startAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_FunCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_SlaveID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.btn_connect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Modbus-Master";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_SlaveID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_FunCode;
        private System.Windows.Forms.TextBox textBox_startAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_numInputs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_meg;
        private System.Windows.Forms.Button btn_Read;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_Write;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_err;
        private System.Windows.Forms.ToolStripLabel toolStripLabel_errImage;
    }
}

