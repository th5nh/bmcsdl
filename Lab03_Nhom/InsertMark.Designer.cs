namespace Lab03_Nhom
{
    partial class InsertMark
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
            dtGriv_mark = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_StudentId = new TextBox();
            txt_HP = new TextBox();
            txt_mark = new TextBox();
            bnt_InsertMark = new Button();
            bnt_Return = new Button();
            bnt_Exit = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGriv_mark).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(254, 30);
            label1.Name = "label1";
            label1.Size = new Size(278, 28);
            label1.TabIndex = 0;
            label1.Text = "NHẬP ĐIỂM CỦA SINH VIÊN";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtGriv_mark);
            groupBox1.Location = new Point(44, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 289);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin bảng điểm";
            // 
            // dtGriv_mark
            // 
            dtGriv_mark.BackgroundColor = SystemColors.ButtonHighlight;
            dtGriv_mark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGriv_mark.Location = new Point(0, 40);
            dtGriv_mark.Name = "dtGriv_mark";
            dtGriv_mark.RowHeadersWidth = 62;
            dtGriv_mark.Size = new Size(755, 249);
            dtGriv_mark.TabIndex = 0;
            dtGriv_mark.CellContentClick += dtGriv_mark_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 75);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã sinh viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 78);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 3;
            label3.Text = "Mã học phần";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 125);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 4;
            label4.Text = "Điểm số";
            // 
            // txt_StudentId
            // 
            txt_StudentId.Location = new Point(157, 75);
            txt_StudentId.Name = "txt_StudentId";
            txt_StudentId.Size = new Size(150, 31);
            txt_StudentId.TabIndex = 1;
            // 
            // txt_HP
            // 
            txt_HP.Location = new Point(526, 75);
            txt_HP.Name = "txt_HP";
            txt_HP.Size = new Size(139, 31);
            txt_HP.TabIndex = 5;
            // 
            // txt_mark
            // 
            txt_mark.Location = new Point(157, 122);
            txt_mark.Name = "txt_mark";
            txt_mark.Size = new Size(150, 31);
            txt_mark.TabIndex = 6;
            // 
            // bnt_InsertMark
            // 
            bnt_InsertMark.BackColor = SystemColors.HotTrack;
            bnt_InsertMark.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_InsertMark.ForeColor = SystemColors.ControlLightLight;
            bnt_InsertMark.Location = new Point(643, 125);
            bnt_InsertMark.Name = "bnt_InsertMark";
            bnt_InsertMark.Size = new Size(156, 48);
            bnt_InsertMark.TabIndex = 7;
            bnt_InsertMark.Text = "Nhập điểm";
            bnt_InsertMark.UseVisualStyleBackColor = false;
            bnt_InsertMark.Click += bnt_InsertMark_Click;
            // 
            // bnt_Return
            // 
            bnt_Return.BackColor = SystemColors.MenuHighlight;
            bnt_Return.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_Return.ForeColor = SystemColors.ControlLightLight;
            bnt_Return.Location = new Point(50, 12);
            bnt_Return.Name = "bnt_Return";
            bnt_Return.Size = new Size(112, 46);
            bnt_Return.TabIndex = 8;
            bnt_Return.Text = "Trở về";
            bnt_Return.UseVisualStyleBackColor = false;
            bnt_Return.Click += bnt_Return_Click;
            // 
            // bnt_Exit
            // 
            bnt_Exit.BackColor = SystemColors.MenuHighlight;
            bnt_Exit.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_Exit.ForeColor = SystemColors.ControlLightLight;
            bnt_Exit.Location = new Point(687, 12);
            bnt_Exit.Name = "bnt_Exit";
            bnt_Exit.Size = new Size(112, 46);
            bnt_Exit.TabIndex = 9;
            bnt_Exit.Text = "Thoát";
            bnt_Exit.UseVisualStyleBackColor = false;
            bnt_Exit.Click += bnt_Exit_Click;
            // 
            // InsertMark
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(864, 507);
            Controls.Add(bnt_Exit);
            Controls.Add(bnt_Return);
            Controls.Add(bnt_InsertMark);
            Controls.Add(txt_mark);
            Controls.Add(txt_HP);
            Controls.Add(txt_StudentId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "InsertMark";
            Text = "InsertMark";
            Load += InsertMark_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGriv_mark).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private DataGridView dtGriv_mark;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_StudentId;
        private TextBox txt_HP;
        private TextBox txt_mark;
        private Button bnt_InsertMark;
        private Button bnt_Return;
        private Button bnt_Exit;
    }
}