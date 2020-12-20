
namespace SmallTalk
{
    partial class ChatSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatSettings));
            this.groupBoxChat = new System.Windows.Forms.GroupBox();
            this.chatUsersDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.exitFromChatButton = new System.Windows.Forms.Button();
            this.addUserToChatButton = new System.Windows.Forms.Button();
            this.changeChatNameButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.countMessageLabel = new System.Windows.Forms.Label();
            this.nameChangeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chatUsersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxChat
            // 
            this.groupBoxChat.Controls.Add(this.label4);
            this.groupBoxChat.Controls.Add(this.nameChangeTextBox);
            this.groupBoxChat.Controls.Add(this.countMessageLabel);
            this.groupBoxChat.Controls.Add(this.label2);
            this.groupBoxChat.Controls.Add(this.changeChatNameButton);
            this.groupBoxChat.Controls.Add(this.addUserToChatButton);
            this.groupBoxChat.Controls.Add(this.exitFromChatButton);
            this.groupBoxChat.Controls.Add(this.label1);
            this.groupBoxChat.Controls.Add(this.chatUsersDataGridView);
            this.groupBoxChat.Location = new System.Drawing.Point(10, 8);
            this.groupBoxChat.Name = "groupBoxChat";
            this.groupBoxChat.Size = new System.Drawing.Size(241, 405);
            this.groupBoxChat.TabIndex = 6;
            this.groupBoxChat.TabStop = false;
            this.groupBoxChat.Text = "Настройки Беседы";
            // 
            // chatUsersDataGridView
            // 
            this.chatUsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.chatUsersDataGridView.Location = new System.Drawing.Point(6, 32);
            this.chatUsersDataGridView.Name = "chatUsersDataGridView";
            this.chatUsersDataGridView.Size = new System.Drawing.Size(228, 255);
            this.chatUsersDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Участники Беседы";
            // 
            // exitFromChatButton
            // 
            this.exitFromChatButton.Image = ((System.Drawing.Image)(resources.GetObject("exitFromChatButton.Image")));
            this.exitFromChatButton.Location = new System.Drawing.Point(184, 347);
            this.exitFromChatButton.Name = "exitFromChatButton";
            this.exitFromChatButton.Size = new System.Drawing.Size(50, 49);
            this.exitFromChatButton.TabIndex = 2;
            this.exitFromChatButton.UseVisualStyleBackColor = true;
            // 
            // addUserToChatButton
            // 
            this.addUserToChatButton.Image = ((System.Drawing.Image)(resources.GetObject("addUserToChatButton.Image")));
            this.addUserToChatButton.Location = new System.Drawing.Point(128, 347);
            this.addUserToChatButton.Name = "addUserToChatButton";
            this.addUserToChatButton.Size = new System.Drawing.Size(50, 49);
            this.addUserToChatButton.TabIndex = 3;
            this.addUserToChatButton.UseVisualStyleBackColor = true;
            // 
            // changeChatNameButton
            // 
            this.changeChatNameButton.Location = new System.Drawing.Point(9, 373);
            this.changeChatNameButton.Name = "changeChatNameButton";
            this.changeChatNameButton.Size = new System.Drawing.Size(113, 23);
            this.changeChatNameButton.TabIndex = 4;
            this.changeChatNameButton.Text = "Изменить";
            this.changeChatNameButton.UseVisualStyleBackColor = true;
            this.changeChatNameButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Изменить название";
            // 
            // countMessageLabel
            // 
            this.countMessageLabel.AutoSize = true;
            this.countMessageLabel.Location = new System.Drawing.Point(6, 294);
            this.countMessageLabel.Name = "countMessageLabel";
            this.countMessageLabel.Size = new System.Drawing.Size(107, 13);
            this.countMessageLabel.TabIndex = 7;
            this.countMessageLabel.Text = "Кол-во сообщений: ";
            // 
            // nameChangeTextBox
            // 
            this.nameChangeTextBox.Location = new System.Drawing.Point(9, 347);
            this.nameChangeTextBox.Name = "nameChangeTextBox";
            this.nameChangeTextBox.Size = new System.Drawing.Size(113, 20);
            this.nameChangeTextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Кол-во участников: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 425);
            this.Controls.Add(this.groupBoxChat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SmallTalk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxChat.ResumeLayout(false);
            this.groupBoxChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chatUsersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxChat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameChangeTextBox;
        private System.Windows.Forms.Label countMessageLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeChatNameButton;
        private System.Windows.Forms.Button addUserToChatButton;
        private System.Windows.Forms.Button exitFromChatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView chatUsersDataGridView;
    }
}