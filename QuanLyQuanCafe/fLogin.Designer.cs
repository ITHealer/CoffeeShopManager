
namespace QuanLyQuanCafe
{
    partial class fLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnBGLogin = new System.Windows.Forms.Panel();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.lbPassWord = new System.Windows.Forms.Label();
            this.lbUserName = new System.Windows.Forms.Label();
            this.pnBGLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(185, 170);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 40);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Đăng Nhập";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(345, 170);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnBGLogin
            // 
            this.pnBGLogin.BackgroundImage = global::QuanLyQuanCafe.Properties.Resources.a2;
            this.pnBGLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnBGLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnBGLogin.Controls.Add(this.btnExit);
            this.pnBGLogin.Controls.Add(this.btnLogin);
            this.pnBGLogin.Controls.Add(this.tbPassWord);
            this.pnBGLogin.Controls.Add(this.tbUserName);
            this.pnBGLogin.Controls.Add(this.lbPassWord);
            this.pnBGLogin.Controls.Add(this.lbUserName);
            this.pnBGLogin.Location = new System.Drawing.Point(1, 2);
            this.pnBGLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnBGLogin.Name = "pnBGLogin";
            this.pnBGLogin.Size = new System.Drawing.Size(485, 260);
            this.pnBGLogin.TabIndex = 0;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassWord.Location = new System.Drawing.Point(185, 100);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(260, 25);
            this.tbPassWord.TabIndex = 2;
            this.tbPassWord.Text = "0909";
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.Location = new System.Drawing.Point(185, 35);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(260, 25);
            this.tbUserName.TabIndex = 1;
            this.tbUserName.Text = "hoai";
            // 
            // lbPassWord
            // 
            this.lbPassWord.BackColor = System.Drawing.Color.Lime;
            this.lbPassWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPassWord.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.lbPassWord.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassWord.Location = new System.Drawing.Point(30, 90);
            this.lbPassWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassWord.Name = "lbPassWord";
            this.lbPassWord.Size = new System.Drawing.Size(120, 35);
            this.lbPassWord.TabIndex = 0;
            this.lbPassWord.Text = "Mật Khẩu";
            this.lbPassWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUserName
            // 
            this.lbUserName.BackColor = System.Drawing.Color.Lime;
            this.lbUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUserName.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.lbUserName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(30, 30);
            this.lbUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(120, 35);
            this.lbUserName.TabIndex = 0;
            this.lbUserName.Text = "Tên Đăng Nhập";
            this.lbUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fLogin
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.pnBGLogin);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
            this.pnBGLogin.ResumeLayout(false);
            this.pnBGLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBGLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.Label lbPassWord;
        private System.Windows.Forms.Label lbUserName;
    }
}

