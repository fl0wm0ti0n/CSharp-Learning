using System;
using System.Timers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace IP_GameChat
{
    public partial class Form : System.Windows.Forms.Form
    {
        private static int _nNumberOf = 7 * 5;
        public int TimeLeft = 10;
        Rectangle[,] _spielfeld = new Rectangle[7, 5];
        Point[] _point = new Point[_nNumberOf];
        Size[] _size = new Size[_nNumberOf];
        private int timerCount;

        public Form()
        {
            InitializeComponent();
            Connection.CreateSocket();

            // Füge LokaleIp automatsich im Textefeld ein 
            textIP1.Text = Connection.GetLocalIp();
            textIP2.Text = Connection.GetLocalIp();
        }

        // Wird ausgeführt wenn die Form geladen wird ---------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

            DoubleBuffered = true;

            Paint += Form1_Paint;
        }

        // Wird ausgeführt wenn der Connect Button gedrückt wird ----------------------------------------------------------------------------
        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textIP1.Text) && !string.IsNullOrEmpty(textIP2.Text) && !string.IsNullOrEmpty(textPort1.Text) && !string.IsNullOrEmpty(textPort2.Text))
                {
                    Connection.ConnectWithEndPoint(textIP1.Text, textPort1.Text, textIP2.Text, textPort2.Text);

                    // Sperre "Connect" Button und schreibe Connected
                    bConnect.Text = "Connected";
                    bConnect.Enabled = false;
                    // Enable "Send" Button
                    bSend.Enabled = true;
                    // Enable "ChatTextFeld" Button
                    textChat.Enabled = true;
                    // Enable "Spiel Starten" Button
                    bStartGame.Enabled = true;

                    textChat.Focus();

                    timerSync.Start();
                }
                else
                {
                    textChatlist.Items.Add("Es wurden keine Verbindungsparameter eingegeben");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        delegate void SetTextCallback(string message);

        // Fügt Text in den Chat ein --------------------------------------------------------------------------------------------------------
        public void AddTextToChat(string message)
        {
 
            if (message.Length != 0)
            {

                if (textChatlist.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(AddTextToChat);
                    this.Invoke(d, new object[] { message });
                }
                else
                {
                    textChatlist.Items.Add(message);
                }
            }
        }

        // Sendet die Textnachricht per Button -----------------------------------------------------------------------------------------------
        private void bSend_Click(object sender, EventArgs e)
        {
            SendBinaryData.SendData("chat", textChat.Text, "platzhalter");
            // Schreibe Nachricht in Chatliste
            AddTextToChat(Program.User.Name + " @" + DateTime.Now + ": " + textChat.Text);
            textChat.Clear();
        }

        // Sendet die Textnachricht per Enter ------------------------------------------------------------------------------------------------
        private void textChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendBinaryData.SendData("chat", textChat.Text, "platzhalter");
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Schreibe Nachricht in Chatliste
                AddTextToChat(Program.User.Name + " @" + DateTime.Now + ": " + textChat.Text);
                textChat.Clear();
            }
        }

        // Zeichnet das Spielbrett ------------------------------------------------------------------------------------------------------------
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var nNumberInc  = 0;
            var ySize       = 91;
            var xSize       = 91;
            var xPoint      = 569;
            var yPoint      = 70;

            //erstelle Gitter
            //Spalten
            for (var i = 0; i < 5; i++)
            {
                //Zeilen
                for (var j = 0; j < 7; j++)
                {
                    _point[nNumberInc] = new Point(xPoint, yPoint);
                    _size[nNumberInc] = new Size(ySize, xSize);
                    _spielfeld[j, i] = new Rectangle(_point[nNumberInc], _size[nNumberInc]);

                    nNumberInc = nNumberInc++;
                    xPoint = xPoint + 91;

                    if (j == 6)
                    {
                        xPoint = 569;
                    }
                }
                yPoint = yPoint + 91;
                nNumberInc = nNumberInc++;
            }
            foreach (var s in _spielfeld)
            {
            e.Graphics.DrawRectangle(Pens.White, s);
            }
        }

        // Füllt ein Feld im Spielbrett--------------------------------------------------------------------------------------------------------
        public void FillField(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.SkyBlue, _spielfeld[1, 1]);
        }

        // Button - Starte das Spiel oder Frage um ein Spiel an --------------------------------------------------------------------------------------------------------
        private void bStartGame_Click(object sender, EventArgs e)
        {
            StartGameOrRequestForGame.StartOrRequest();
        }



        // Button - beende das Spiel oder Stoppe die Anfrage--------------------------------------------------------------------------------------------------------
        private void bStopGame_Click(object sender, EventArgs e)
        {
            StopGameOrStopRequest.StopGameOrNot();
        }

        // beende das Spiel oder Stoppe die Anfrage--------------------------------------------------------------------------------------------------------
        public void SperreStart()
        {

            bStartGame.Enabled = false;
            bStopGame.Enabled = true;
        }

        public void SperreStop()
        {
            bStartGame.Enabled = true;
            bStopGame.Enabled = false;
        }

        // Sync Forms Timer --------------------------------------------------------------------------------------------------------
        private void TimerSync_Tick(object sender, EventArgs e)
        {
            timerCount++;

            try
            {
                SendBinaryData.SendData("sync", "Synchronisiere", Convert.ToString(timerCount));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        //--------------------------------------------------------------------------------------------------------
        private void bChangeName_Click(object sender, EventArgs e)
        {
            // wenn Textfeld nicht lee ist ändere name
            if (!string.IsNullOrEmpty(txtName.Text))
            {
                Program.User.Name = txtName.Text;
                textChatlist.Items.Add("Der Name wurde auf '" + txtName.Text + "' geändert!");
                txtName.Clear();
            }
        }

        // Schaltet die Spaltenbuttons wieder frei--------------------------------------------------------------------------------------------------------
        private void EnableGameButtons()
        {
            bSpalte1.Enabled = true;
            bSpalte2.Enabled = true;
            bSpalte3.Enabled = true;
            bSpalte4.Enabled = true;
            bSpalte5.Enabled = true;
            bSpalte6.Enabled = true;
            bSpalte7.Enabled = true;
        }

        // Sperrt die Spaltenbuttons wenn gesetzt--------------------------------------------------------------------------------------------------------
        private void bSpalte1_Click(object sender, EventArgs e)
        {
            SpielSchnittstelle.SetEinwurf(1);

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;
        }

        private void bSpalte2_Click(object sender, EventArgs e)
        {
            SpielSchnittstelle.SetEinwurf(2);

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;
        }

        private void bSpalte3_Click(object sender, EventArgs e)
        {
            SpielSchnittstelle.SetEinwurf(3);

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;
        }

        private void bSpalte4_Click(object sender, EventArgs e)
        {
            SpielSchnittstelle.SetEinwurf(4);

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;
        }

        private void bSpalte5_Click(object sender, EventArgs e)
        {
            SpielSchnittstelle.SetEinwurf(5);

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;
        }

        private void bSpalte6_Click(object sender, EventArgs e)
        {
            SpielSchnittstelle.SetEinwurf(6);

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;
        }

        private void bSpalte7_Click(object sender, EventArgs e)
        {
            SpielSchnittstelle.SetEinwurf(7);

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textChatlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void boxClient1_Enter(object sender, EventArgs e)
        {

        }

        private void boxClient2_Enter(object sender, EventArgs e)
        {

        }

        private void textIP1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPort4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelInfobox_Click(object sender, EventArgs e)
        {

        }

        private void labelGewonnen_Click(object sender, EventArgs e)
        {

        }

        private void labelVerloren_Click(object sender, EventArgs e)
        {

        }

        private void labelRunde_Click(object sender, EventArgs e)
        {

        }
    }
}
