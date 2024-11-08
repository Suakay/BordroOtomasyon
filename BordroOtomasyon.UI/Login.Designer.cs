namespace BordroOtomasyon.UI
{
    partial class Login
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
            grpLogin = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textPassword = new TextBox();
            textEmail = new TextBox();
            btn = new Button();
            grpLogin.SuspendLayout();
            SuspendLayout();
            // 
            // grpLogin
            // 
            grpLogin.BackColor = SystemColors.ControlDark;
            grpLogin.Controls.Add(label2);
            grpLogin.Controls.Add(label1);
            grpLogin.Controls.Add(textPassword);
            grpLogin.Controls.Add(textEmail);
            grpLogin.Controls.Add(btn);
            grpLogin.Location = new Point(68, 59);
            grpLogin.Name = "grpLogin";
            grpLogin.Size = new Size(739, 358);
            grpLogin.TabIndex = 0;
            grpLogin.TabStop = false;
            grpLogin.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Simple Indust Shaded", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(52, 135);
            label2.Name = "label2";
            label2.Size = new Size(130, 33);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(64, 60);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(188, 137);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(244, 31);
            textPassword.TabIndex = 3;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(175, 60);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(220, 31);
            textEmail.TabIndex = 1;
            // 
            // btn
            // 
            btn.Font = new Font("Simple Outline Pat", 11F, FontStyle.Italic, GraphicsUnit.Point);
            btn.Location = new Point(175, 216);
            btn.Name = "btn";
            btn.Size = new Size(208, 47);
            btn.TabIndex = 0;
            btn.Text = "Login";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(1133, 813);
            Controls.Add(grpLogin);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            grpLogin.ResumeLayout(false);
            grpLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpLogin;
        private Button btn;
        private Label label2;
        private Label label1;
        private TextBox textPassword;
        private TextBox textEmail;
    }
}