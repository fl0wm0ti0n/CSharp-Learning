namespace IP_GameChat
{
    public partial class Form
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
            this.components = new System.ComponentModel.Container();
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
            this.bConnect = new System.Windows.Forms.Button();
            this.bSend = new System.Windows.Forms.Button();
            this.bSpalte1 = new System.Windows.Forms.Button();
            this.bSpalte2 = new System.Windows.Forms.Button();
            this.bSpalte3 = new System.Windows.Forms.Button();
            this.bSpalte4 = new System.Windows.Forms.Button();
            this.bSpalte5 = new System.Windows.Forms.Button();
            this.bSpalte6 = new System.Windows.Forms.Button();
            this.bSpalte7 = new System.Windows.Forms.Button();
            this.panelForButtons = new System.Windows.Forms.Panel();
            this.bStartGame = new System.Windows.Forms.Button();
            this.bStopGame = new System.Windows.Forms.Button();
            this.boxName = new System.Windows.Forms.GroupBox();
            this.bChangeName = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.timerSync = new System.Windows.Forms.Timer(this.components);
            this.boxRunde = new System.Windows.Forms.GroupBox();
            this.labelRunde = new System.Windows.Forms.Label();
            this.boxGewonnen = new System.Windows.Forms.GroupBox();
            this.labelGewonnen = new System.Windows.Forms.Label();
            this.boxVerloren = new System.Windows.Forms.GroupBox();
            this.labelVerloren = new System.Windows.Forms.Label();
            this.boxInfo = new System.Windows.Forms.GroupBox();
            this.labelInfobox = new System.Windows.Forms.Label();
            this.boxClient1.SuspendLayout();
            this.boxClient2.SuspendLayout();
            this.panelForButtons.SuspendLayout();
            this.boxName.SuspendLayout();
            this.boxRunde.SuspendLayout();
            this.boxGewonnen.SuspendLayout();
            this.boxVerloren.SuspendLayout();
            this.boxInfo.SuspendLayout();
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
            this.boxClient1.Size = new System.Drawing.Size(170, 77);
            this.boxClient1.TabIndex = 0;
            this.boxClient1.TabStop = false;
            this.boxClient1.Text = "Client 1";
            this.boxClient1.Enter += new System.EventHandler(this.boxClient1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textPort1
            // 
            this.textPort1.Location = new System.Drawing.Point(58, 45);
            this.textPort1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textPort1.Name = "textPort1";
            this.textPort1.Size = new System.Drawing.Size(99, 22);
            this.textPort1.TabIndex = 1;
            this.textPort1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textIP1
            // 
            this.textIP1.Location = new System.Drawing.Point(58, 18);
            this.textIP1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textIP1.Name = "textIP1";
            this.textIP1.Size = new System.Drawing.Size(99, 22);
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
            this.boxClient2.Location = new System.Drawing.Point(188, 10);
            this.boxClient2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxClient2.Name = "boxClient2";
            this.boxClient2.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxClient2.Size = new System.Drawing.Size(170, 77);
            this.boxClient2.TabIndex = 1;
            this.boxClient2.TabStop = false;
            this.boxClient2.Text = "Client 2";
            this.boxClient2.Enter += new System.EventHandler(this.boxClient2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textPort2
            // 
            this.textPort2.Location = new System.Drawing.Point(58, 48);
            this.textPort2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textPort2.Name = "textPort2";
            this.textPort2.Size = new System.Drawing.Size(99, 22);
            this.textPort2.TabIndex = 1;
            this.textPort2.TextChanged += new System.EventHandler(this.textPort4_TextChanged);
            // 
            // textIP2
            // 
            this.textIP2.Location = new System.Drawing.Point(58, 19);
            this.textIP2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textIP2.Name = "textIP2";
            this.textIP2.Size = new System.Drawing.Size(99, 22);
            this.textIP2.TabIndex = 0;
            this.textIP2.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textChat
            // 
            this.textChat.BackColor = System.Drawing.Color.LightCyan;
            this.textChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textChat.Enabled = false;
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
            this.textChatlist.Location = new System.Drawing.Point(12, 140);
            this.textChatlist.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textChatlist.Name = "textChatlist";
            this.textChatlist.Size = new System.Drawing.Size(530, 375);
            this.textChatlist.TabIndex = 3;
            this.textChatlist.SelectedIndexChanged += new System.EventHandler(this.textChatlist_SelectedIndexChanged);
            // 
            // bConnect
            // 
            this.bConnect.BackColor = System.Drawing.Color.SteelBlue;
            this.bConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bConnect.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bConnect.FlatAppearance.BorderSize = 0;
            this.bConnect.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bConnect.Location = new System.Drawing.Point(364, 16);
            this.bConnect.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bConnect.Name = "bConnect";
            this.bConnect.Size = new System.Drawing.Size(72, 71);
            this.bConnect.TabIndex = 4;
            this.bConnect.Text = "Connect";
            this.bConnect.UseVisualStyleBackColor = false;
            this.bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bSend
            // 
            this.bSend.BackColor = System.Drawing.Color.SteelBlue;
            this.bSend.Enabled = false;
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
            this.bSpalte1.Enabled = false;
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
            this.bSpalte2.Enabled = false;
            this.bSpalte2.ForeColor = System.Drawing.Color.White;
            this.bSpalte2.Location = new System.Drawing.Point(91, 3);
            this.bSpalte2.Name = "bSpalte2";
            this.bSpalte2.Size = new System.Drawing.Size(91, 45);
            this.bSpalte2.TabIndex = 7;
            this.bSpalte2.Text = "2";
            this.bSpalte2.UseVisualStyleBackColor = false;
            this.bSpalte2.Click += new System.EventHandler(this.bSpalte2_Click);
            // 
            // bSpalte3
            // 
            this.bSpalte3.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte3.Enabled = false;
            this.bSpalte3.ForeColor = System.Drawing.Color.White;
            this.bSpalte3.Location = new System.Drawing.Point(182, 3);
            this.bSpalte3.Name = "bSpalte3";
            this.bSpalte3.Size = new System.Drawing.Size(91, 45);
            this.bSpalte3.TabIndex = 8;
            this.bSpalte3.Text = "3";
            this.bSpalte3.UseVisualStyleBackColor = false;
            this.bSpalte3.Click += new System.EventHandler(this.bSpalte3_Click);
            // 
            // bSpalte4
            // 
            this.bSpalte4.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte4.Enabled = false;
            this.bSpalte4.ForeColor = System.Drawing.Color.White;
            this.bSpalte4.Location = new System.Drawing.Point(273, 3);
            this.bSpalte4.Name = "bSpalte4";
            this.bSpalte4.Size = new System.Drawing.Size(91, 45);
            this.bSpalte4.TabIndex = 9;
            this.bSpalte4.Text = "4";
            this.bSpalte4.UseVisualStyleBackColor = false;
            this.bSpalte4.Click += new System.EventHandler(this.bSpalte4_Click);
            // 
            // bSpalte5
            // 
            this.bSpalte5.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte5.Enabled = false;
            this.bSpalte5.ForeColor = System.Drawing.Color.White;
            this.bSpalte5.Location = new System.Drawing.Point(364, 3);
            this.bSpalte5.Name = "bSpalte5";
            this.bSpalte5.Size = new System.Drawing.Size(91, 45);
            this.bSpalte5.TabIndex = 10;
            this.bSpalte5.Text = "5";
            this.bSpalte5.UseVisualStyleBackColor = false;
            this.bSpalte5.Click += new System.EventHandler(this.bSpalte5_Click);
            // 
            // bSpalte6
            // 
            this.bSpalte6.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte6.Enabled = false;
            this.bSpalte6.ForeColor = System.Drawing.Color.White;
            this.bSpalte6.Location = new System.Drawing.Point(455, 3);
            this.bSpalte6.Name = "bSpalte6";
            this.bSpalte6.Size = new System.Drawing.Size(91, 45);
            this.bSpalte6.TabIndex = 11;
            this.bSpalte6.Text = "6";
            this.bSpalte6.UseVisualStyleBackColor = false;
            this.bSpalte6.Click += new System.EventHandler(this.bSpalte6_Click);
            // 
            // bSpalte7
            // 
            this.bSpalte7.BackColor = System.Drawing.Color.SkyBlue;
            this.bSpalte7.Enabled = false;
            this.bSpalte7.ForeColor = System.Drawing.Color.White;
            this.bSpalte7.Location = new System.Drawing.Point(546, 3);
            this.bSpalte7.Name = "bSpalte7";
            this.bSpalte7.Size = new System.Drawing.Size(91, 45);
            this.bSpalte7.TabIndex = 12;
            this.bSpalte7.Text = "7";
            this.bSpalte7.UseVisualStyleBackColor = false;
            this.bSpalte7.Click += new System.EventHandler(this.bSpalte7_Click);
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
            // bStartGame
            // 
            this.bStartGame.BackColor = System.Drawing.Color.SkyBlue;
            this.bStartGame.Enabled = false;
            this.bStartGame.ForeColor = System.Drawing.Color.White;
            this.bStartGame.Location = new System.Drawing.Point(442, 16);
            this.bStartGame.Name = "bStartGame";
            this.bStartGame.Size = new System.Drawing.Size(100, 33);
            this.bStartGame.TabIndex = 13;
            this.bStartGame.Text = "Starte Spiel";
            this.bStartGame.UseVisualStyleBackColor = false;
            this.bStartGame.Click += new System.EventHandler(this.bStartGame_Click);
            // 
            // bStopGame
            // 
            this.bStopGame.BackColor = System.Drawing.Color.SkyBlue;
            this.bStopGame.Enabled = false;
            this.bStopGame.ForeColor = System.Drawing.Color.White;
            this.bStopGame.Location = new System.Drawing.Point(442, 55);
            this.bStopGame.Name = "bStopGame";
            this.bStopGame.Size = new System.Drawing.Size(100, 32);
            this.bStopGame.TabIndex = 14;
            this.bStopGame.Text = "Beende Spiel";
            this.bStopGame.UseVisualStyleBackColor = false;
            this.bStopGame.Click += new System.EventHandler(this.bStopGame_Click);
            // 
            // boxName
            // 
            this.boxName.Controls.Add(this.bChangeName);
            this.boxName.Controls.Add(this.txtName);
            this.boxName.Location = new System.Drawing.Point(12, 87);
            this.boxName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxName.Name = "boxName";
            this.boxName.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxName.Size = new System.Drawing.Size(170, 46);
            this.boxName.TabIndex = 4;
            this.boxName.TabStop = false;
            this.boxName.Text = "Name";
            // 
            // bChangeName
            // 
            this.bChangeName.BackColor = System.Drawing.Color.SkyBlue;
            this.bChangeName.ForeColor = System.Drawing.Color.White;
            this.bChangeName.Location = new System.Drawing.Point(109, 14);
            this.bChangeName.Name = "bChangeName";
            this.bChangeName.Size = new System.Drawing.Size(55, 25);
            this.bChangeName.TabIndex = 15;
            this.bChangeName.Text = "Ändern";
            this.bChangeName.UseVisualStyleBackColor = false;
            this.bChangeName.Click += new System.EventHandler(this.bChangeName_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 16);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(97, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // timerSync
            // 
            this.timerSync.Tick += new System.EventHandler(this.TimerSync_Tick);
            // 
            // boxRunde
            // 
            this.boxRunde.Controls.Add(this.labelRunde);
            this.boxRunde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxRunde.Location = new System.Drawing.Point(188, 87);
            this.boxRunde.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxRunde.Name = "boxRunde";
            this.boxRunde.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxRunde.Size = new System.Drawing.Size(80, 46);
            this.boxRunde.TabIndex = 4;
            this.boxRunde.TabStop = false;
            this.boxRunde.Text = "Runde";
            // 
            // labelRunde
            // 
            this.labelRunde.AutoSize = true;
            this.labelRunde.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRunde.Location = new System.Drawing.Point(27, 15);
            this.labelRunde.Name = "labelRunde";
            this.labelRunde.Size = new System.Drawing.Size(19, 22);
            this.labelRunde.TabIndex = 15;
            this.labelRunde.Text = "0";
            this.labelRunde.Click += new System.EventHandler(this.labelRunde_Click);
            // 
            // boxGewonnen
            // 
            this.boxGewonnen.Controls.Add(this.labelGewonnen);
            this.boxGewonnen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxGewonnen.Location = new System.Drawing.Point(358, 87);
            this.boxGewonnen.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxGewonnen.Name = "boxGewonnen";
            this.boxGewonnen.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxGewonnen.Size = new System.Drawing.Size(78, 46);
            this.boxGewonnen.TabIndex = 5;
            this.boxGewonnen.TabStop = false;
            this.boxGewonnen.Text = "Gewonnen";
            // 
            // labelGewonnen
            // 
            this.labelGewonnen.AutoSize = true;
            this.labelGewonnen.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGewonnen.Location = new System.Drawing.Point(25, 15);
            this.labelGewonnen.Name = "labelGewonnen";
            this.labelGewonnen.Size = new System.Drawing.Size(19, 22);
            this.labelGewonnen.TabIndex = 17;
            this.labelGewonnen.Text = "0";
            this.labelGewonnen.Click += new System.EventHandler(this.labelGewonnen_Click);
            // 
            // boxVerloren
            // 
            this.boxVerloren.Controls.Add(this.labelVerloren);
            this.boxVerloren.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxVerloren.Location = new System.Drawing.Point(274, 87);
            this.boxVerloren.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxVerloren.Name = "boxVerloren";
            this.boxVerloren.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxVerloren.Size = new System.Drawing.Size(78, 46);
            this.boxVerloren.TabIndex = 6;
            this.boxVerloren.TabStop = false;
            this.boxVerloren.Text = "Verloren";
            // 
            // labelVerloren
            // 
            this.labelVerloren.AutoSize = true;
            this.labelVerloren.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVerloren.Location = new System.Drawing.Point(26, 15);
            this.labelVerloren.Name = "labelVerloren";
            this.labelVerloren.Size = new System.Drawing.Size(19, 22);
            this.labelVerloren.TabIndex = 16;
            this.labelVerloren.Text = "0";
            this.labelVerloren.Click += new System.EventHandler(this.labelVerloren_Click);
            // 
            // boxInfo
            // 
            this.boxInfo.Controls.Add(this.labelInfobox);
            this.boxInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boxInfo.Location = new System.Drawing.Point(442, 87);
            this.boxInfo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxInfo.Name = "boxInfo";
            this.boxInfo.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boxInfo.Size = new System.Drawing.Size(100, 46);
            this.boxInfo.TabIndex = 6;
            this.boxInfo.TabStop = false;
            this.boxInfo.Text = "Infobox";
            // 
            // labelInfobox
            // 
            this.labelInfobox.AutoSize = true;
            this.labelInfobox.BackColor = System.Drawing.Color.Transparent;
            this.labelInfobox.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfobox.Location = new System.Drawing.Point(3, 15);
            this.labelInfobox.Name = "labelInfobox";
            this.labelInfobox.Size = new System.Drawing.Size(69, 22);
            this.labelInfobox.TabIndex = 18;
            this.labelInfobox.Text = "-empty-";
            this.labelInfobox.Click += new System.EventHandler(this.labelInfobox_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1219, 547);
            this.Controls.Add(this.boxVerloren);
            this.Controls.Add(this.boxInfo);
            this.Controls.Add(this.boxGewonnen);
            this.Controls.Add(this.boxRunde);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.bStopGame);
            this.Controls.Add(this.bStartGame);
            this.Controls.Add(this.panelForButtons);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.bConnect);
            this.Controls.Add(this.textChatlist);
            this.Controls.Add(this.textChat);
            this.Controls.Add(this.boxClient2);
            this.Controls.Add(this.boxClient1);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimizeBox = false;
            this.Name = "Form";
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
            this.boxName.ResumeLayout(false);
            this.boxName.PerformLayout();
            this.boxRunde.ResumeLayout(false);
            this.boxRunde.PerformLayout();
            this.boxGewonnen.ResumeLayout(false);
            this.boxGewonnen.PerformLayout();
            this.boxVerloren.ResumeLayout(false);
            this.boxVerloren.PerformLayout();
            this.boxInfo.ResumeLayout(false);
            this.boxInfo.PerformLayout();
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
        private System.Windows.Forms.Button bConnect;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Button bSpalte1;
        private System.Windows.Forms.Button bSpalte2;
        private System.Windows.Forms.Button bSpalte3;
        private System.Windows.Forms.Button bSpalte4;
        private System.Windows.Forms.Button bSpalte5;
        private System.Windows.Forms.Button bSpalte6;
        private System.Windows.Forms.Button bSpalte7;
        private System.Windows.Forms.Panel panelForButtons;
        public System.Windows.Forms.Button bStartGame;
        public System.Windows.Forms.Button bStopGame;
        private System.Windows.Forms.GroupBox boxName;
        private System.Windows.Forms.Button bChangeName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Timer timerSync;
        private System.Windows.Forms.GroupBox boxRunde;
        private System.Windows.Forms.GroupBox boxGewonnen;
        private System.Windows.Forms.GroupBox boxVerloren;
        private System.Windows.Forms.GroupBox boxInfo;
        private System.Windows.Forms.Label labelRunde;
        private System.Windows.Forms.Label labelGewonnen;
        private System.Windows.Forms.Label labelVerloren;
        private System.Windows.Forms.Label labelInfobox;
    }
}

