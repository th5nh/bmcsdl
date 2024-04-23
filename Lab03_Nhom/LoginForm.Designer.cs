namespace Lab03_Nhom
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_Username = new TextBox();
            txt_Password = new TextBox();
            bnt_Exit = new Button();
            bnt_SignIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 141);
            label1.Name = "label1";
            label1.Size = new Size(152, 28);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(151, 227);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Segoe UI", 10F);
            txt_Username.Location = new Point(344, 144);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(245, 34);
            txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 10F);
            txt_Password.Location = new Point(344, 227);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(245, 34);
            txt_Password.TabIndex = 3;
            txt_Password.UseSystemPasswordChar = true;
            // 
            // bnt_Exit
            // 
            bnt_Exit.BackColor = SystemColors.Highlight;
            bnt_Exit.Font = new Font("Segoe UI", 10F);
            bnt_Exit.ForeColor = SystemColors.ControlLightLight;
            bnt_Exit.Location = new Point(505, 313);
            bnt_Exit.Name = "bnt_Exit";
            bnt_Exit.Size = new Size(114, 45);
            bnt_Exit.TabIndex = 4;
            bnt_Exit.Text = "Thoát";
            bnt_Exit.UseVisualStyleBackColor = false;
            bnt_Exit.Click += bnt_Exit_Click;
            // 
            // bnt_SignIn
            // 
            bnt_SignIn.BackColor = SystemColors.Highlight;
            bnt_SignIn.Font = new Font("Segoe UI", 10F);
            bnt_SignIn.ForeColor = SystemColors.ControlLightLight;
            bnt_SignIn.Location = new Point(318, 313);
            bnt_SignIn.Name = "bnt_SignIn";
            bnt_SignIn.Size = new Size(140, 45);
            bnt_SignIn.TabIndex = 5;
            bnt_SignIn.Text = "Đăng nhập";
            bnt_SignIn.UseVisualStyleBackColor = false;
            bnt_SignIn.Click += bnt_SignIn_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bnt_SignIn);
            Controls.Add(bnt_Exit);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Màn hình đăng nhập";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Username;
        private TextBox txt_Password;
        private Button bnt_Exit;
        private Button bnt_SignIn;
    }
}
