namespace DE01
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
            this.lblmsv = new System.Windows.Forms.Label();
            this.lblns = new System.Windows.Forms.Label();
            this.lblhoten = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmblop = new System.Windows.Forms.ComboBox();
            this.dgvsv = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnkl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmsv
            // 
            this.lblmsv.AutoSize = true;
            this.lblmsv.Location = new System.Drawing.Point(8, 27);
            this.lblmsv.Name = "lblmsv";
            this.lblmsv.Size = new System.Drawing.Size(85, 16);
            this.lblmsv.TabIndex = 1;
            this.lblmsv.Text = "Mã Sinh Viên";
            // 
            // lblns
            // 
            this.lblns.AutoSize = true;
            this.lblns.Location = new System.Drawing.Point(8, 68);
            this.lblns.Name = "lblns";
            this.lblns.Size = new System.Drawing.Size(69, 16);
            this.lblns.TabIndex = 2;
            this.lblns.Text = "Ngày Sinh";
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.Location = new System.Drawing.Point(312, 27);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(46, 16);
            this.lblhoten.TabIndex = 3;
            this.lblhoten.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lớp học";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmblop);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmssv);
            this.groupBox1.Controls.Add(this.lblmsv);
            this.groupBox1.Controls.Add(this.lblns);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblhoten);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(138, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 114);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN CHI TIẾT";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(108, 24);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(187, 22);
            this.txtmssv.TabIndex = 6;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(364, 24);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(187, 22);
            this.txthoten.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(108, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(187, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // cmblop
            // 
            this.cmblop.FormattingEnabled = true;
            this.cmblop.Location = new System.Drawing.Point(365, 68);
            this.cmblop.Name = "cmblop";
            this.cmblop.Size = new System.Drawing.Size(186, 24);
            this.cmblop.TabIndex = 9;
            // 
            // dgvsv
            // 
            this.dgvsv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvsv.Location = new System.Drawing.Point(13, 263);
            this.dgvsv.Name = "dgvsv";
            this.dgvsv.RowHeadersWidth = 51;
            this.dgvsv.RowTemplate.Height = 24;
            this.dgvsv.Size = new System.Drawing.Size(918, 286);
            this.dgvsv.TabIndex = 7;
            this.dgvsv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsv_CellClick);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 222);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 22);
            this.textBox3.TabIndex = 8;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(161, 222);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 23);
            this.btntim.TabIndex = 9;
            this.btntim.Text = "TÌM";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(292, 221);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 10;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(373, 222);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 11;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(454, 221);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 12;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(797, 221);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 13;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "MSSV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Họ Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày Sinh";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Lớp";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(589, 221);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 14;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnkl
            // 
            this.btnkl.Location = new System.Drawing.Point(682, 221);
            this.btnkl.Name = "btnkl";
            this.btnkl.Size = new System.Drawing.Size(75, 23);
            this.btnkl.TabIndex = 15;
            this.btnkl.Text = "Không Lưu";
            this.btnkl.UseVisualStyleBackColor = true;
            this.btnkl.Click += new System.EventHandler(this.btnkl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 561);
            this.Controls.Add(this.btnkl);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dgvsv);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DANH SÁCH SINH VIÊN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblmsv;
        private System.Windows.Forms.Label lblns;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmblop;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.DataGridView dgvsv;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnkl;
    }
}

