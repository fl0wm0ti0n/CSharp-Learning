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
    public partial class Form1 : Form
    {

        private static int _nNumberOf = 7 * 5;
        private static int _timeLeft = 10;
        Rectangle[,] _spielfeld = new Rectangle[7, 5];
        Point[] _point = new Point[_nNumberOf];
        Size[] _size = new Size[_nNumberOf];

        public Form1()
        {

            InitializeComponent();
            Connection.CreateSocket();



            // Füge LokaleIp automatsich im Textefeld ein 
            textIP1.Text = Connection.GetLocalIp();
            textIP2.Text = Connection.GetLocalIp();
        }

//--------------------------------------------------------------------------------------------------------
        private void bStart_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.ConnectWithEndPoint(textIP1.Text, textPort1.Text, textIP2.Text, textPort2.Text);

                // Sperre "Start" Button und schreibe Connected
                bStart.Text = "Connected";
                bStart.Enabled = false;
                bSend.Enabled = true;
                textChat.Focus();

                timerSync.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //--------------------------------------------------------------------------------------------------------
        public void AddTextToChat(string message)
        {
            if (message.Length != 0)
            {
                textChatlist.Items.Add(message);
            }

        }

        //--------------------------------------------------------------------------------------------------------
        private void bSend_Click(object sender, EventArgs e)
        {
            var sMsg = Connection.SendMsgData(textChat.Text);

            // Schreibe Nachricht in Chatliste
            textChatlist.Items.Add(sMsg);
            textChat.Clear();

        }

        //--------------------------------------------------------------------------------------------------------

        private void textChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var sMsg = Connection.SendMsgData(textChat.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;

                // Schreibe Nachricht in Chatliste
                textChatlist.Items.Add(sMsg);
                textChat.Clear();

            }
        }

//--------------------------------------------------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {

            DoubleBuffered = true;

            Paint += Form1_Paint;


        }

//--------------------------------------------------------------------------------------------------------
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

        //--------------------------------------------------------------------------------------------------------
        public void FillField(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.SkyBlue, _spielfeld[1, 1]);
        }

        //--------------------------------------------------------------------------------------------------------
        private void bStartGame_Click(object sender, EventArgs e)
        {
            var test = textChatlist.Items.Add("Warte auf anderen Spieler");

            if (Connection.Angefragt)
            {
                GameProcess.StartTheGame();
            }
            else
            {
                GameProcess.GameRequest();
                timerGameRequest.Start();
            }

        }

        // Countdown Forms Timer --------------------------------------------------------------------------------------------------------
        private void TimerGameRequest_Tick(object sender, EventArgs e)
        {
            try
            {

                if (_timeLeft > 0)
                {
                    // Display the new time left
                    // by updating the Time Left label.
                    _timeLeft--;
                    textChatlist.Items.Add("Noch " + _timeLeft + " Sekunden um das Spiel zu starten");
                }
                else
                {
                    // If  out of time, stop the timer, show
                    // a MessageBox.
                    timerGameRequest.Stop();
                    textChatlist.Items.Add(Connection.User.Name + " hat dem Spiel nicht zugestimmt");
                    _timeLeft = 10;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        // Sync Forms Timer --------------------------------------------------------------------------------------------------------
        private void TimerSync_Tick(object sender, EventArgs e)
        {
            try
            {
                Connection.SendSyncData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        //--------------------------------------------------------------------------------------------------------
        private void bStopGame_Click(object sender, EventArgs e)
        {

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
            GameProcess.SetEinwurf(1);

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
            GameProcess.SetEinwurf(2);

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
            GameProcess.SetEinwurf(3);

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
            GameProcess.SetEinwurf(4);

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
            GameProcess.SetEinwurf(5);

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
            GameProcess.SetEinwurf(6);

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
            GameProcess.SetEinwurf(7);

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


    }
}
