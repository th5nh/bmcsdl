namespace Lab03_Nhom
{
    partial class ClassManagement
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
            dataGridView1 = new DataGridView();
            bnt_ViewStDetail = new Button();
            btn_ExitClassMana = new Button();
            label2 = new Label();
            txt_ClassId = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 18);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ LỚP HỌC";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(61, 143);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(695, 308);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin lớp";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.InactiveCaptionText;
            dataGridView1.Location = new Point(81, 56);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(570, 252);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // bnt_ViewStDetail
            // 
            bnt_ViewStDetail.BackColor = SystemColors.HotTrack;
            bnt_ViewStDetail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bnt_ViewStDetail.ForeColor = SystemColors.ControlLightLight;
            bnt_ViewStDetail.Location = new Point(587, 85);
            bnt_ViewStDetail.Name = "bnt_ViewStDetail";
            bnt_ViewStDetail.Size = new Size(169, 47);
            bnt_ViewStDetail.TabIndex = 5;
            bnt_ViewStDetail.Text = "Xem DS sinh viên";
            bnt_ViewStDetail.UseVisualStyleBackColor = false;
            bnt_ViewStDetail.Click += bnt_ViewStDetail_Click;
            // 
            // btn_ExitClassMana
            // 
            btn_ExitClassMana.BackColor = SystemColors.HotTrack;
            btn_ExitClassMana.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ExitClassMana.ForeColor = SystemColors.ControlLightLight;
            btn_ExitClassMana.Location = new Point(61, 79);
            btn_ExitClassMana.Name = "btn_ExitClassMana";
            btn_ExitClassMana.Size = new Size(112, 47);
            btn_ExitClassMana.TabIndex = 5;
            btn_ExitClassMana.Text = "Exit";
            btn_ExitClassMana.UseVisualStyleBackColor = false;
            btn_ExitClassMana.Click += btn_ExitClassMana_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(251, 90);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 6;
            label2.Text = "Mã lớp";
            // 
            // txt_ClassId
            // 
            txt_ClassId.Font = new Font("Segoe UI", 10F);
            txt_ClassId.Location = new Point(348, 90);
            txt_ClassId.Name = "txt_ClassId";
            txt_ClassId.Size = new Size(150, 34);
            txt_ClassId.TabIndex = 7;
            // 
            // ClassManagement
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_ClassId);
            Controls.Add(label2);
            Controls.Add(btn_ExitClassMana);
            Controls.Add(bnt_ViewStDetail);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "ClassManagement";
            Text = "Màn hình quản lý lớp học";
            Load += ClassManagement_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button bnt_ViewStDetail;
        private DataGridView dataGridView1;
        private Button btn_ExitClassMana;
        private Label label2;
        private TextBox txt_ClassId;
    }
}