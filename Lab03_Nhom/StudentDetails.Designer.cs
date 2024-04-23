namespace Lab03_Nhom
{
    partial class StudentDetails
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            dtGriv_SinhvienDetail = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_fullname = new TextBox();
            txt_address = new TextBox();
            txt_born = new TextBox();
            txt_comp = new TextBox();
            bnt_change = new Button();
            bnt_return = new Button();
            bnt_InsertMark = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGriv_SinhvienDetail).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(442, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 28);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtGriv_SinhvienDetail);
            groupBox1.Location = new Point(62, 214);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(920, 445);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sinh viên";
            // 
            // dtGriv_SinhvienDetail
            // 
            dtGriv_SinhvienDetail.BackgroundColor = SystemColors.ButtonHighlight;
            dtGriv_SinhvienDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGriv_SinhvienDetail.Location = new Point(0, 40);
            dtGriv_SinhvienDetail.Name = "dtGriv_SinhvienDetail";
            dtGriv_SinhvienDetail.RowHeadersWidth = 62;
            dtGriv_SinhvienDetail.Size = new Size(920, 399);
            dtGriv_SinhvienDetail.TabIndex = 0;
            dtGriv_SinhvienDetail.CellContentClick += dtGriv_SinhvienDetail_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(62, 60);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 2;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(654, 60);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 3;
            label3.Text = "NTNS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(62, 122);
            label4.Name = "label4";
            label4.Size = new Size(70, 25);
            label4.TabIndex = 4;
            label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(550, 125);
            label5.Name = "label5";
            label5.Size = new Size(165, 25);
            label5.TabIndex = 5;
            label5.Text = "Tên doanh nghiệp";
            // 
            // txt_fullname
            // 
            txt_fullname.Location = new Point(142, 59);
            txt_fullname.Name = "txt_fullname";
            txt_fullname.Size = new Size(271, 31);
            txt_fullname.TabIndex = 6;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(138, 122);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(271, 31);
            txt_address.TabIndex = 7;
            // 
            // txt_born
            // 
            txt_born.Location = new Point(744, 57);
            txt_born.Name = "txt_born";
            txt_born.Size = new Size(238, 31);
            txt_born.TabIndex = 8;
            // 
            // txt_comp
            // 
            txt_comp.Location = new Point(744, 119);
            txt_comp.Name = "txt_comp";
            txt_comp.Size = new Size(238, 31);
            txt_comp.TabIndex = 9;
            // 
            // bnt_change
            // 
            bnt_change.BackColor = SystemColors.HotTrack;
            bnt_change.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_change.ForeColor = SystemColors.HighlightText;
            bnt_change.Location = new Point(830, 174);
            bnt_change.Name = "bnt_change";
            bnt_change.Size = new Size(152, 34);
            bnt_change.TabIndex = 10;
            bnt_change.Text = "Chỉnh sửa";
            bnt_change.UseVisualStyleBackColor = false;
            bnt_change.Click += bnt_change_Click;
            // 
            // bnt_return
            // 
            bnt_return.BackColor = SystemColors.HotTrack;
            bnt_return.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_return.ForeColor = SystemColors.ControlLightLight;
            bnt_return.Location = new Point(62, 3);
            bnt_return.Name = "bnt_return";
            bnt_return.Size = new Size(108, 34);
            bnt_return.TabIndex = 11;
            bnt_return.Text = "Trở về";
            bnt_return.UseVisualStyleBackColor = false;
            bnt_return.Click += bnt_return_Click;
            // 
            // bnt_InsertMark
            // 
            bnt_InsertMark.BackColor = SystemColors.HotTrack;
            bnt_InsertMark.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_InsertMark.ForeColor = SystemColors.HighlightText;
            bnt_InsertMark.Location = new Point(608, 174);
            bnt_InsertMark.Name = "bnt_InsertMark";
            bnt_InsertMark.Size = new Size(152, 34);
            bnt_InsertMark.TabIndex = 12;
            bnt_InsertMark.Text = "Nhập điểm";
            bnt_InsertMark.UseVisualStyleBackColor = false;
            bnt_InsertMark.Click += bnt_InsertMark_Click;
            // 
            // StudentDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 691);
            Controls.Add(bnt_InsertMark);
            Controls.Add(bnt_return);
            Controls.Add(bnt_change);
            Controls.Add(txt_comp);
            Controls.Add(txt_born);
            Controls.Add(txt_address);
            Controls.Add(txt_fullname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "StudentDetails";
            Text = "StudentDetails";
            Load += StudentDetails_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGriv_SinhvienDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dtGriv_SinhvienDetail;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txt_fullname;
        private TextBox txt_address;
        private TextBox txt_born;
        private TextBox txt_comp;
        private Button bnt_change;
        private Button bnt_return;
        private Button bnt_InsertMark;
    }
}