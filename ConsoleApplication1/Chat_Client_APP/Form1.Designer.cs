namespace Chat_Client_APP
{
    public partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPort1 = new System.Windows.Forms.TextBox();
            this.textIP1 = new System.Windows.Forms.TextBox();
            this.boxClient2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textPort2 = new System.Windows.Forms.TextBox();
            this.textIP2 = new System.Windows.Forms.TextBox();
            this.textChat = new System.Windows.Forms.TextBox();
            this.textChatlist = new System.Windows.Forms.ListBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.bSpalte1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.bSpalte2 = new System.Windows.Forms.Button();
            this.bSpalte3 = new System.Windows.Forms.Button();
            this.bSpalte4 = new System.Windows.Forms.Button();
            this.bSpalte5 = new System.Windows.Forms.Button();
            this.bSpalte6 = new System.Windows.Forms.Button();
            this.bSpalte7 = new System.Windows.Forms.Button();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.boxClient1.SuspendLayout();
            this.boxClient2.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxClient1
            // 
            this.boxClient1.Controls.Add(this.label2);
            this.boxClient1.Controls.Add(this.label1);
            this.boxClient1.Controls.Add(this.textPort1);
            this.boxClient1.Controls.Add(this.textIP1);
            this.boxClient1.Location = new System.Drawing.Point(12, 10);
            this.boxClient1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxClient1.Name = "boxClient1";
            this.boxClient1.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxClient1.Size = new System.Drawing.Size(234, 106);
            this.boxClient1.TabIndex = 0;
            this.boxClient1.TabStop = false;
            this.boxClient1.Text = "Client 1";
            this.boxClient1.Enter += new System.EventHandler(this.boxClient1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textPort1
            // 
            this.textPort1.Location = new System.Drawing.Point(58, 74);
            this.textPort1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textPort1.Name = "textPort1";
            this.textPort1.Size = new System.Drawing.Size(170, 22);
            this.textPort1.TabIndex = 1;
            this.textPort1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textIP1
            // 
            this.textIP1.Location = new System.Drawing.Point(58, 29);
            this.textIP1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textIP1.Name = "textIP1";
            this.textIP1.Size = new System.Drawing.Size(170, 22);
            this.textIP1.TabIndex = 0;
            this.textIP1.TextChanged += new System.EventHandler(this.textIP1_TextChanged);
            // 
            // boxClient2
            // 
            this.boxClient2.Controls.Add(this.label4);
            this.boxClient2.Controls.Add(this.label3);
            this.boxClient2.Controls.Add(this.textPort2);
            this.boxClient2.Controls.Add(this.textIP2);
            this.boxClient2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxClient2.Location = new System.Drawing.Point(252, 10);
            this.boxClient2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxClient2.Name = "boxClient2";
            this.boxClient2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxClient2.Size = new System.Drawing.Size(234, 106);
            this.boxClient2.TabIndex = 1;
            this.boxClient2.TabStop = false;
            this.boxClient2.Text = "Client 2";
            this.boxClient2.Enter += new System.EventHandler(this.boxClient2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textPort2
            // 
            this.textPort2.Location = new System.Drawing.Point(61, 74);
            this.textPort2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textPort2.Name = "textPort2";
            this.textPort2.Size = new System.Drawing.Size(167, 22);
            this.textPort2.TabIndex = 1;
            this.textPort2.TextChanged += new System.EventHandler(this.textPort4_TextChanged);
            // 
            // textIP2
            // 
            this.textIP2.Location = new System.Drawing.Point(61, 29);
            this.textIP2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textIP2.Name = "textIP2";
            this.textIP2.Size = new System.Drawing.Size(167, 22);
            this.textIP2.TabIndex = 0;
            this.textIP2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textChat
            // 
            this.textChat.BackColor = System.Drawing.Color.LightCyan;
            this.textChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textChat.Location = new System.Drawing.Point(12, 521);
            this.textChat.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textChat.Name = "textChat";
            this.textChat.Size = new System.Drawing.Size(474, 15);
            this.textChat.TabIndex = 2;
            this.textChat.TextChanged += new System.EventHandler(this.textChat_TextChanged);
            this.textChat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textChat_KeyDown);
            // 
            // textChatlist
            // 
            this.textChatlist.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.textChatlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textChatlist.FormattingEnabled = true;
            this.textChatlist.ItemHeight = 15;
            this.textChatlist.Location = new System.Drawing.Point(12, 125);
            this.textChatlist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textChatlist.Name = "textChatlist";
            this.textChatlist.Size = new System.Drawing.Size(530, 390);
            this.textChatlist.TabIndex = 3;
            this.textChatlist.SelectedIndexChanged += new System.EventHandler(this.textChatlist_SelectedIndexChanged);
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.SteelBlue;
            this.bStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bStart.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bStart.FlatAppearance.BorderSize = 0;
            this.bStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bStart.Location = new System.Drawing.Point(492, 14);
            this.bStart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(50, 102);
            this.bStart.TabIndex = 4;
            this.bStart.Text = "Start Chat";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.Color.SteelBlue;
            this.bSend.Location = new System.Drawing.Point(492, 518);
            this.bSend.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(50, 24);
            this.bSend.TabIndex = 5;
            this.bSend.Text = "Send";
            this.bSend.UseVisualStyleBackColor = false;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // bSpalte1
            // 
            this.bSpalte1.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte1.ForeColor = System.Drawing.Color.White;
            this.bSpalte1.Location = new System.Drawing.Point(0, 3);
            this.bSpalte1.Name = "bSpalte1";
            this.bSpalte1.Size = new System.Drawing.Size(91, 45);
            this.bSpalte1.TabIndex = 6;
            this.bSpalte1.Text = "1";
            this.bSpalte1.UseVisualStyleBackColor = false;
            this.bSpalte1.Click += new System.EventHandler(this.bSpalte1_Click);
            // 
            // bSpalte2
            // 
            this.bSpalte2.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte2.ForeColor = System.Drawing.Color.White;
            this.bSpalte2.Location = new System.Drawing.Point(91, 3);
            this.bSpalte2.Name = "bSpalte2";
            this.bSpalte2.Size = new System.Drawing.Size(91, 45);
            this.bSpalte2.TabIndex = 7;
            this.bSpalte2.Text = "2";
            this.bSpalte2.UseVisualStyleBackColor = false;
            // 
            // bSpalte3
            // 
            this.bSpalte3.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte3.ForeColor = System.Drawing.Color.White;
            this.bSpalte3.Location = new System.Drawing.Point(182, 3);
            this.bSpalte3.Name = "bSpalte3";
            this.bSpalte3.Size = new System.Drawing.Size(91, 45);
            this.bSpalte3.TabIndex = 8;
            this.bSpalte3.Text = "3";
            this.bSpalte3.UseVisualStyleBackColor = false;
            // 
            // bSpalte4
            // 
            this.bSpalte4.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte4.ForeColor = System.Drawing.Color.White;
            this.bSpalte4.Location = new System.Drawing.Point(273, 3);
            this.bSpalte4.Name = "bSpalte4";
            this.bSpalte4.Size = new System.Drawing.Size(91, 45);
            this.bSpalte4.TabIndex = 9;
            this.bSpalte4.Text = "4";
            this.bSpalte4.UseVisualStyleBackColor = false;
            // 
            // bSpalte5
            // 
            this.bSpalte5.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte5.ForeColor = System.Drawing.Color.White;
            this.bSpalte5.Location = new System.Drawing.Point(364, 3);
            this.bSpalte5.Name = "bSpalte5";
            this.bSpalte5.Size = new System.Drawing.Size(91, 45);
            this.bSpalte5.TabIndex = 10;
            this.bSpalte5.Text = "5";
            this.bSpalte5.UseVisualStyleBackColor = false;
            // 
            // bSpalte6
            // 
            this.bSpalte6.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte6.ForeColor = System.Drawing.Color.White;
            this.bSpalte6.Location = new System.Drawing.Point(455, 3);
            this.bSpalte6.Name = "bSpalte6";
            this.bSpalte6.Size = new System.Drawing.Size(91, 45);
            this.bSpalte6.TabIndex = 11;
            this.bSpalte6.Text = "6";
            this.bSpalte6.UseVisualStyleBackColor = false;
            // 
            // bSpalte7
            // 
            this.bSpalte7.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte7.ForeColor = System.Drawing.Color.White;
            this.bSpalte7.Location = new System.Drawing.Point(546, 3);
            this.bSpalte7.Name = "bSpalte7";
            this.bSpalte7.Size = new System.Drawing.Size(91, 45);
            this.bSpalte7.TabIndex = 12;
            this.bSpalte7.Text = "7";
            this.bSpalte7.UseVisualStyleBackColor = false;
            // 
            // panelForButtons
            // 
            this.panelForButtons.Controls.Add(this.bSpalte7);
            this.panelForButtons.Controls.Add(this.bSpalte1);
            this.panelForButtons.Controls.Add(this.bSpalte6);
            this.panelForButtons.Controls.Add(this.bSpalte2);
            this.panelForButtons.Controls.Add(this.bSpalte5);
            this.panelForButtons.Controls.Add(this.bSpalte3);
            this.panelForButtons.Controls.Add(this.bSpalte4);
            this.panelForButtons.Location = new System.Drawing.Point(569, 13);
            this.panelForButtons.Name = "panelForButtons";
            this.panelForButtons.Size = new System.Drawing.Size(637, 47);
            this.panelForButtons.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1234, 547);
            this.Controls.Add(this.panelForButtons);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.textChatlist);
            this.Controls.Add(this.textChat);
            this.Controls.Add(this.boxClient2);
            this.Controls.Add(this.boxClient1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "IP Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxClient1.ResumeLayout(false);
            this.boxClient1.PerformLayout();
            this.boxClient2.ResumeLayout(false);
            this.boxClient2.PerformLayout();
            this.panelForButtons.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textPort2;
        private System.Windows.Forms.TextBox textIP2;
        private System.Windows.Forms.TextBox textChat;
        private System.Windows.Forms.ListBox textChatlist;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bSpalte1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button bSpalte2;
        private System.Windows.Forms.Button bSpalte3;
        private System.Windows.Forms.Button bSpalte4;
        private System.Windows.Forms.Button bSpalte5;
        private System.Windows.Forms.Button bSpalte6;
        private System.Windows.Forms.Button bSpalte7;
        private System.Windows.Forms.Panel panelForButtons;
    }
}

