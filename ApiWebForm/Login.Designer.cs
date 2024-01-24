namespace ApiWebForm
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
            btnLogin = new Button();
            Inputpassword = new TextBox();
            Inputuser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(346, 284);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 23);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Iniciar Sesion";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // Inputpassword
            // 
            Inputpassword.Location = new Point(295, 215);
            Inputpassword.Name = "Inputpassword";
            Inputpassword.Size = new Size(230, 23);
            Inputpassword.TabIndex = 1;
            Inputpassword.Text = "0lelplR";
            // 
            // Inputuser
            // 
            Inputuser.Location = new Point(295, 149);
            Inputuser.Name = "Inputuser";
            Inputuser.Size = new Size(230, 23);
            Inputuser.TabIndex = 2;
            Inputuser.Text = "kminchelle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(295, 131);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 197);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "contraseña";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Inputuser);
            Controls.Add(Inputpassword);
            Controls.Add(btnLogin);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox Inputpassword;
        private TextBox Inputuser;
        private Label label1;
        private Label label2;
    }
}