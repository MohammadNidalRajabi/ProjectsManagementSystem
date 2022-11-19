namespace project
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MTxtBPassword = new System.Windows.Forms.MaskedTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.MTxtBEmailAddress = new System.Windows.Forms.MaskedTextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CHKBShowpassword = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(161, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(161, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MTxtBPassword
            // 
            this.MTxtBPassword.Location = new System.Drawing.Point(267, 122);
            this.MTxtBPassword.Name = "MTxtBPassword";
            this.MTxtBPassword.PasswordChar = '*';
            this.MTxtBPassword.PromptChar = '-';
            this.MTxtBPassword.Size = new System.Drawing.Size(164, 20);
            this.MTxtBPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(236, 214);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(159, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // MTxtBEmailAddress
            // 
            this.MTxtBEmailAddress.Location = new System.Drawing.Point(267, 73);
            this.MTxtBEmailAddress.Name = "MTxtBEmailAddress";
            this.MTxtBEmailAddress.Size = new System.Drawing.Size(164, 20);
            this.MTxtBEmailAddress.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CHKBShowpassword
            // 
            this.CHKBShowpassword.AutoSize = true;
            this.CHKBShowpassword.BackColor = System.Drawing.Color.Transparent;
            this.CHKBShowpassword.ForeColor = System.Drawing.Color.White;
            this.CHKBShowpassword.Location = new System.Drawing.Point(453, 125);
            this.CHKBShowpassword.Name = "CHKBShowpassword";
            this.CHKBShowpassword.Size = new System.Drawing.Size(101, 17);
            this.CHKBShowpassword.TabIndex = 3;
            this.CHKBShowpassword.Text = "Show Password";
            this.CHKBShowpassword.UseVisualStyleBackColor = false;
            this.CHKBShowpassword.CheckedChanged += new System.EventHandler(this.CHKBShowpassword_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(244, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login page";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(631, 297);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CHKBShowpassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.MTxtBPassword);
            this.Controls.Add(this.MTxtBEmailAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Projects Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MTxtBPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MaskedTextBox MTxtBEmailAddress;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckBox CHKBShowpassword;
        private System.Windows.Forms.Label label3;
    }
}

