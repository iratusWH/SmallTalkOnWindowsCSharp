
namespace SmallTalk
{
    partial class AddChatActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddChatActivity));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chatAddButton = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAddChat = new System.Windows.Forms.Button();
            this.exitButtonAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chatAddButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAddChat);
            this.groupBox1.Controls.Add(this.exitButtonAdd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 97);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Создать Беседу";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chatAddButton
            // 
            this.chatAddButton.Location = new System.Drawing.Point(10, 35);
            this.chatAddButton.Name = "chatAddButton";
            this.chatAddButton.Size = new System.Drawing.Size(150, 20);
            this.chatAddButton.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Название чата";
            // 
            // buttonAddChat
            // 
            this.buttonAddChat.Enabled = false;
            this.buttonAddChat.Location = new System.Drawing.Point(45, 61);
            this.buttonAddChat.Name = "buttonAddChat";
            this.buttonAddChat.Size = new System.Drawing.Size(115, 23);
            this.buttonAddChat.TabIndex = 8;
            this.buttonAddChat.Text = "Создать";
            this.buttonAddChat.UseVisualStyleBackColor = true;
            // 
            // exitButtonAdd
            // 
            this.exitButtonAdd.Location = new System.Drawing.Point(10, 61);
            this.exitButtonAdd.Name = "exitButtonAdd";
            this.exitButtonAdd.Size = new System.Drawing.Size(32, 23);
            this.exitButtonAdd.TabIndex = 9;
            this.exitButtonAdd.Text = "<";
            this.exitButtonAdd.UseVisualStyleBackColor = true;
            // 
            // AddChatActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 118);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddChatActivity";
            this.Text = "SmallTalk";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox chatAddButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAddChat;
        private System.Windows.Forms.Button exitButtonAdd;
    }
}