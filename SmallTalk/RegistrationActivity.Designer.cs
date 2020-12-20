
namespace SmallTalk
{
    partial class RegistrationActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationActivity));
            this.loginTexEditReg = new System.Windows.Forms.TextBox();
            this.passwordTextEditReg = new System.Windows.Forms.TextBox();
            this.passwordAgainText = new System.Windows.Forms.TextBox();
            this.emailButton = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.exitButtonReg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTexEditReg
            // 
            this.loginTexEditReg.Location = new System.Drawing.Point(18, 40);
            this.loginTexEditReg.Name = "loginTexEditReg";
            this.loginTexEditReg.Size = new System.Drawing.Size(123, 20);
            this.loginTexEditReg.TabIndex = 0;
            // 
            // passwordTextEditReg
            // 
            this.passwordTextEditReg.Location = new System.Drawing.Point(18, 79);
            this.passwordTextEditReg.Name = "passwordTextEditReg";
            this.passwordTextEditReg.Size = new System.Drawing.Size(123, 20);
            this.passwordTextEditReg.TabIndex = 1;
            // 
            // passwordAgainText
            // 
            this.passwordAgainText.Location = new System.Drawing.Point(19, 118);
            this.passwordAgainText.Name = "passwordAgainText";
            this.passwordAgainText.Size = new System.Drawing.Size(123, 20);
            this.passwordAgainText.TabIndex = 2;
            this.passwordAgainText.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(19, 157);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(123, 20);
            this.emailButton.TabIndex = 3;
            // 
            // buttonReg
            // 
            this.buttonReg.Enabled = false;
            this.buttonReg.Location = new System.Drawing.Point(57, 183);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(85, 23);
            this.buttonReg.TabIndex = 4;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.exitButtonReg);
            this.groupBox1.Controls.Add(this.buttonReg);
            this.groupBox1.Controls.Add(this.emailButton);
            this.groupBox1.Controls.Add(this.passwordAgainText);
            this.groupBox1.Controls.Add(this.loginTexEditReg);
            this.groupBox1.Controls.Add(this.passwordTextEditReg);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(162, 224);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Регистрация";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Логин";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Повторение пароля";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-Mail";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // exitButtonReg
            // 
            this.exitButtonReg.Location = new System.Drawing.Point(19, 183);
            this.exitButtonReg.Name = "exitButtonReg";
            this.exitButtonReg.Size = new System.Drawing.Size(32, 23);
            this.exitButtonReg.TabIndex = 5;
            this.exitButtonReg.Text = "<";
            this.exitButtonReg.UseVisualStyleBackColor = true;
            this.exitButtonReg.Click += new System.EventHandler(this.exitButtonReg_Click);
            // 
            // RegistrationActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 244);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationActivity";
            this.Text = "SmallTalk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox loginTexEditReg;
        private System.Windows.Forms.TextBox passwordTextEditReg;
        private System.Windows.Forms.TextBox passwordAgainText;
        private System.Windows.Forms.TextBox emailButton;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitButtonReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}