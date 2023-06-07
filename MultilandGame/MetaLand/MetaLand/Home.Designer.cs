namespace MetaLand
{
    partial class Home
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblNickname = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUNickname = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.lblMultiland = new System.Windows.Forms.Label();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtRepass = new System.Windows.Forms.TextBox();
            this.lblRepass = new System.Windows.Forms.Label();
            this.txtRpass = new System.Windows.Forms.TextBox();
            this.lbl2Pass = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.lbl2Nickname = new System.Windows.Forms.Label();
            this.txtRSurname = new System.Windows.Forms.TextBox();
            this.lbl2Surname = new System.Windows.Forms.Label();
            this.txtRName = new System.Windows.Forms.TextBox();
            this.btnRegistera = new System.Windows.Forms.Button();
            this.lbl2Name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogin.SuspendLayout();
            this.pnlRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogin.Location = new System.Drawing.Point(209, 183);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblNickname
            // 
            this.lblNickname.AutoSize = true;
            this.lblNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNickname.Location = new System.Drawing.Point(20, 45);
            this.lblNickname.Name = "lblNickname";
            this.lblNickname.Size = new System.Drawing.Size(136, 25);
            this.lblNickname.TabIndex = 7;
            this.lblNickname.Text = "Kullanıcı Adı:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPass.Location = new System.Drawing.Point(20, 114);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(62, 25);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Şifre:";
            // 
            // txtUNickname
            // 
            this.txtUNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUNickname.Location = new System.Drawing.Point(173, 45);
            this.txtUNickname.Multiline = true;
            this.txtUNickname.Name = "txtUNickname";
            this.txtUNickname.Size = new System.Drawing.Size(137, 31);
            this.txtUNickname.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(173, 114);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(137, 31);
            this.txtPass.TabIndex = 1;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.btnDirectory);
            this.pnlLogin.Controls.Add(this.lblNickname);
            this.pnlLogin.Controls.Add(this.txtPass);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtUNickname);
            this.pnlLogin.Controls.Add(this.lblPass);
            this.pnlLogin.Location = new System.Drawing.Point(12, 64);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(338, 461);
            this.pnlLogin.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(814, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Şifre:";
            // 
            // btnDirectory
            // 
            this.btnDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.6F);
            this.btnDirectory.Location = new System.Drawing.Point(25, 183);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(101, 35);
            this.btnDirectory.TabIndex = 3;
            this.btnDirectory.Text = "Kaydol";
            this.btnDirectory.UseVisualStyleBackColor = true;
            this.btnDirectory.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblMultiland
            // 
            this.lblMultiland.AutoSize = true;
            this.lblMultiland.Font = new System.Drawing.Font("Ravie", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiland.Location = new System.Drawing.Point(2, 6);
            this.lblMultiland.Name = "lblMultiland";
            this.lblMultiland.Size = new System.Drawing.Size(358, 57);
            this.lblMultiland.TabIndex = 5;
            this.lblMultiland.Text = "MULTILAND";
            // 
            // pnlRegister
            // 
            this.pnlRegister.Controls.Add(this.label1);
            this.pnlRegister.Controls.Add(this.btnBack);
            this.pnlRegister.Controls.Add(this.txtRepass);
            this.pnlRegister.Controls.Add(this.lblRepass);
            this.pnlRegister.Controls.Add(this.txtRpass);
            this.pnlRegister.Controls.Add(this.lbl2Pass);
            this.pnlRegister.Controls.Add(this.txtNickname);
            this.pnlRegister.Controls.Add(this.lbl2Nickname);
            this.pnlRegister.Controls.Add(this.txtRSurname);
            this.pnlRegister.Controls.Add(this.lbl2Surname);
            this.pnlRegister.Controls.Add(this.txtRName);
            this.pnlRegister.Controls.Add(this.btnRegistera);
            this.pnlRegister.Controls.Add(this.lbl2Name);
            this.pnlRegister.Location = new System.Drawing.Point(12, 64);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(338, 461);
            this.pnlRegister.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(814, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F);
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 34);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtRepass
            // 
            this.txtRepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRepass.Location = new System.Drawing.Point(162, 310);
            this.txtRepass.Multiline = true;
            this.txtRepass.Name = "txtRepass";
            this.txtRepass.Size = new System.Drawing.Size(137, 31);
            this.txtRepass.TabIndex = 10;
            // 
            // lblRepass
            // 
            this.lblRepass.AutoSize = true;
            this.lblRepass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F);
            this.lblRepass.Location = new System.Drawing.Point(18, 310);
            this.lblRepass.Name = "lblRepass";
            this.lblRepass.Size = new System.Drawing.Size(130, 25);
            this.lblRepass.TabIndex = 9;
            this.lblRepass.Text = "Şifre Tekrar:";
            // 
            // txtRpass
            // 
            this.txtRpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRpass.Location = new System.Drawing.Point(162, 250);
            this.txtRpass.Multiline = true;
            this.txtRpass.Name = "txtRpass";
            this.txtRpass.Size = new System.Drawing.Size(137, 31);
            this.txtRpass.TabIndex = 8;
            // 
            // lbl2Pass
            // 
            this.lbl2Pass.AutoSize = true;
            this.lbl2Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F);
            this.lbl2Pass.Location = new System.Drawing.Point(18, 250);
            this.lbl2Pass.Name = "lbl2Pass";
            this.lbl2Pass.Size = new System.Drawing.Size(62, 25);
            this.lbl2Pass.TabIndex = 7;
            this.lbl2Pass.Text = "Şifre:";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(162, 190);
            this.txtNickname.Multiline = true;
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(137, 31);
            this.txtNickname.TabIndex = 6;
            // 
            // lbl2Nickname
            // 
            this.lbl2Nickname.AutoSize = true;
            this.lbl2Nickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F);
            this.lbl2Nickname.Location = new System.Drawing.Point(18, 190);
            this.lbl2Nickname.Name = "lbl2Nickname";
            this.lbl2Nickname.Size = new System.Drawing.Size(136, 25);
            this.lbl2Nickname.TabIndex = 5;
            this.lbl2Nickname.Text = "Kullanıcı Adı:";
            // 
            // txtRSurname
            // 
            this.txtRSurname.Location = new System.Drawing.Point(162, 130);
            this.txtRSurname.Multiline = true;
            this.txtRSurname.Name = "txtRSurname";
            this.txtRSurname.Size = new System.Drawing.Size(137, 31);
            this.txtRSurname.TabIndex = 4;
            // 
            // lbl2Surname
            // 
            this.lbl2Surname.AutoSize = true;
            this.lbl2Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F);
            this.lbl2Surname.Location = new System.Drawing.Point(18, 130);
            this.lbl2Surname.Name = "lbl2Surname";
            this.lbl2Surname.Size = new System.Drawing.Size(79, 25);
            this.lbl2Surname.TabIndex = 3;
            this.lbl2Surname.Text = "Soyad:";
            // 
            // txtRName
            // 
            this.txtRName.Location = new System.Drawing.Point(162, 70);
            this.txtRName.Multiline = true;
            this.txtRName.Name = "txtRName";
            this.txtRName.Size = new System.Drawing.Size(137, 31);
            this.txtRName.TabIndex = 2;
            // 
            // btnRegistera
            // 
            this.btnRegistera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F);
            this.btnRegistera.Location = new System.Drawing.Point(198, 382);
            this.btnRegistera.Name = "btnRegistera";
            this.btnRegistera.Size = new System.Drawing.Size(101, 35);
            this.btnRegistera.TabIndex = 1;
            this.btnRegistera.Text = "Kaydol";
            this.btnRegistera.UseVisualStyleBackColor = true;
            this.btnRegistera.Click += new System.EventHandler(this.btnRegistera_Click);
            // 
            // lbl2Name
            // 
            this.lbl2Name.AutoSize = true;
            this.lbl2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F);
            this.lbl2Name.Location = new System.Drawing.Point(18, 70);
            this.lbl2Name.Name = "lbl2Name";
            this.lbl2Name.Size = new System.Drawing.Size(44, 25);
            this.lbl2Name.TabIndex = 0;
            this.lbl2Name.Text = "Ad:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1003, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.2F);
            this.label3.Location = new System.Drawing.Point(71, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 30);
            this.label3.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMultiland);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlRegister);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblNickname;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.TextBox txtUNickname;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Label lblMultiland;
        private System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.TextBox txtRpass;
        private System.Windows.Forms.Label lbl2Pass;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label lbl2Nickname;
        private System.Windows.Forms.TextBox txtRSurname;
        private System.Windows.Forms.Label lbl2Surname;
        private System.Windows.Forms.TextBox txtRName;
        private System.Windows.Forms.Button btnRegistera;
        private System.Windows.Forms.Label lbl2Name;
        private System.Windows.Forms.TextBox txtRepass;
        private System.Windows.Forms.Label lblRepass;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

