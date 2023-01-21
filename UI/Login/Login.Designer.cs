
namespace Telzir_Tel
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TITULO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Email = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.bntEntrar_Click = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TITULO
            // 
            this.TITULO.AutoSize = true;
            this.TITULO.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TITULO.Location = new System.Drawing.Point(396, 28);
            this.TITULO.Name = "TITULO";
            this.TITULO.Size = new System.Drawing.Size(354, 41);
            this.TITULO.TabIndex = 0;
            this.TITULO.Text = "TELZIR CONSULTAS";
            this.TITULO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(29, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(282, 338);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Email.Location = new System.Drawing.Point(394, 159);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(84, 29);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email:";
            this.Email.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Senha.Location = new System.Drawing.Point(394, 211);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(92, 29);
            this.Senha.TabIndex = 3;
            this.Senha.Text = "Senha:";
            this.Senha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textEmail.Location = new System.Drawing.Point(484, 158);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(266, 30);
            this.textEmail.TabIndex = 4;
            this.textEmail.TextChanged += new System.EventHandler(this.textEmail_TextChanged_1);
            // 
            // textSenha
            // 
            this.textSenha.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textSenha.Location = new System.Drawing.Point(484, 210);
            this.textSenha.Name = "textSenha";
            this.textSenha.PasswordChar = '*';
            this.textSenha.Size = new System.Drawing.Size(266, 30);
            this.textSenha.TabIndex = 5;
            this.textSenha.TextChanged += new System.EventHandler(this.textSenha_TextChanged);
            // 
            // bntEntrar_Click
            // 
            this.bntEntrar_Click.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntEntrar_Click.Location = new System.Drawing.Point(556, 271);
            this.bntEntrar_Click.Name = "bntEntrar_Click";
            this.bntEntrar_Click.Size = new System.Drawing.Size(124, 38);
            this.bntEntrar_Click.TabIndex = 6;
            this.bntEntrar_Click.Text = "Entrar";
            this.bntEntrar_Click.UseVisualStyleBackColor = true;
            this.bntEntrar_Click.Click += new System.EventHandler(this.bntEntrar_Click_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.bntEntrar_Click);
            this.Controls.Add(this.textSenha);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TITULO);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TITULO;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Button bntEntrar_Click;
    }
}

