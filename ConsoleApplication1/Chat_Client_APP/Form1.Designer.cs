namespace Chat_Client_APP
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxClient1 = new System.Windows.Forms.GroupBox();
            this.boxClient2 = new System.Windows.Forms.GroupBox();
            this.textIP1 = new System.Windows.Forms.TextBox();
            this.textPort1 = new System.Windows.Forms.TextBox();
            this.textIP2 = new System.Windows.Forms.TextBox();
            this.textPort4 = new System.Windows.Forms.TextBox();
            this.textChat = new System.Windows.Forms.TextBox();
            this.textChatlist = new System.Windows.Forms.ListBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxClient1.SuspendLayout();
            this.boxClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxClient1
            // 
            this.boxClient1.Controls.Add(this.label2);
            this.boxClient1.Controls.Add(this.label1);
            this.boxClient1.Controls.Add(this.textPort1);
            this.boxClient1.Controls.Add(this.textIP1);
            this.boxClient1.Location = new System.Drawing.Point(12, 18);
            this.boxClient1.Name = "boxClient1";
            this.boxClient1.Size = new System.Drawing.Size(234, 147);
            this.boxClient1.TabIndex = 0;
            this.boxClient1.TabStop = false;
            this.boxClient1.Text = "Client 1";
            this.boxClient1.Enter += new System.EventHandler(this.boxClient1_Enter);
            // 
            // boxClient2
            // 
            this.boxClient2.Controls.Add(this.label4);
            this.boxClient2.Controls.Add(this.label3);
            this.boxClient2.Controls.Add(this.textPort4);
            this.boxClient2.Controls.Add(this.textIP2);
            this.boxClient2.Location = new System.Drawing.Point(252, 18);
            this.boxClient2.Name = "boxClient2";
            this.boxClient2.Size = new System.Drawing.Size(234, 147);
            this.boxClient2.TabIndex = 1;
            this.boxClient2.TabStop = false;
            this.boxClient2.Text = "Client 2";
            this.boxClient2.Enter += new System.EventHandler(this.boxClient2_Enter);
            // 
            // textIP1
            // 
            this.textIP1.Location = new System.Drawing.Point(58, 25);
            this.textIP1.Name = "textIP1";
            this.textIP1.Size = new System.Drawing.Size(170, 20);
            this.textIP1.TabIndex = 0;
            this.textIP1.TextChanged += new System.EventHandler(this.textIP1_TextChanged);
            // 
            // textPort1
            // 
            this.textPort1.Location = new System.Drawing.Point(58, 64);
            this.textPort1.Name = "textPort1";
            this.textPort1.Size = new System.Drawing.Size(170, 20);
            this.textPort1.TabIndex = 1;
            this.textPort1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textIP2
            // 
            this.textIP2.Location = new System.Drawing.Point(61, 25);
            this.textIP2.Name = "textIP2";
            this.textIP2.Size = new System.Drawing.Size(167, 20);
            this.textIP2.TabIndex = 0;
            this.textIP2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textPort4
            // 
            this.textPort4.Location = new System.Drawing.Point(61, 64);
            this.textPort4.Name = "textPort4";
            this.textPort4.Size = new System.Drawing.Size(167, 20);
            this.textPort4.TabIndex = 1;
            this.textPort4.TextChanged += new System.EventHandler(this.textPort4_TextChanged);
            // 
            // textChat
            // 
            this.textChat.Location = new System.Drawing.Point(12, 416);
            this.textChat.Name = "textChat";
            this.textChat.Size = new System.Drawing.Size(474, 20);
            this.textChat.TabIndex = 2;
            this.textChat.TextChanged += new System.EventHandler(this.textChat_TextChanged);
            // 
            // textChatlist
            // 
            this.textChatlist.FormattingEnabled = true;
            this.textChatlist.Location = new System.Drawing.Point(12, 171);
            this.textChatlist.Name = "textChatlist";
            this.textChatlist.Size = new System.Drawing.Size(530, 238);
            this.textChatlist.TabIndex = 3;
            this.textChatlist.SelectedIndexChanged += new System.EventHandler(this.textChatlist_SelectedIndexChanged);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(492, 24);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(50, 141);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start Chat";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(492, 416);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(50, 23);
            this.bSend.TabIndex = 5;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 448);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.textChatlist);
            this.Controls.Add(this.textChat);
            this.Controls.Add(this.boxClient2);
            this.Controls.Add(this.boxClient1);
            this.Name = "Form1";
            this.Text = "IP Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxClient1.ResumeLayout(false);
            this.boxClient1.PerformLayout();
            this.boxClient2.ResumeLayout(false);
            this.boxClient2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox boxClient1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPort1;
        private System.Windows.Forms.TextBox textIP1;
        private System.Windows.Forms.GroupBox boxClient2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPort4;
        private System.Windows.Forms.TextBox textIP2;
        private System.Windows.Forms.TextBox textChat;
        private System.Windows.Forms.ListBox textChatlist;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bSend;
    }
}

