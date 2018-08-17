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
using System.Threading;

namespace IP_GameChat
{
    public partial class Form : System.Windows.Forms.Form
    {


        /// <summary>
        ///     Klassenvariablen Deklaration.
        /// </summary>

        private static int _nNumberOf = 7 * 5;
        Rectangle[,] _spielfeld = new Rectangle[7, 5];
        Point[] _point = new Point[_nNumberOf];
        Size[] _size = new Size[_nNumberOf];
        private int _timerCount;

        public Form()
        {
            InitializeComponent();
            Connection.CreateSocket();

            // Füge LokaleIp automatsich im Textefeld ein 
            textIP1.Text = Connection.GetLocalIp();
            textIP2.Text = Connection.GetLocalIp();
        }


        /// <summary>
        ///     Ereignis - Windows Form wird geladen.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

        private void Form1_Load(object sender, EventArgs e)
        {

            DoubleBuffered = true;

            Paint += Form1_Paint;
        }


        /// <summary>
        ///     Ereignis - Connect-Button wird gedrück.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

        private void bConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textIP1.Text) && !string.IsNullOrEmpty(textIP2.Text) && !string.IsNullOrEmpty(textPort1.Text) && !string.IsNullOrEmpty(textPort2.Text))
                {
                    Connection.ConnectWithEndPoint(textIP1.Text, textPort1.Text, textIP2.Text, textPort2.Text);

                    // Sperre "Connect" Button und schreibe Connected
                    bConnect.Text = @"Connected";
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


        /// <summary>
        ///     Delegate für Methode "AddTextToChat".
        /// </summary>
        /// <param name="message">Textnachricht</param>

        delegate void SetTextCallback(string message);


        /// <summary>
        ///     Fügt einen Text der Chatliste hinzu.
        /// </summary>
        /// <param name="message">Textnachricht</param>

        public void AddTextToChat(string message)
        {
 
            if (message.Length != 0)
            {

                if (textChatlist.InvokeRequired)
                {
                    SetTextCallback d = AddTextToChat;
                    Invoke(d, message);
                }
                else
                {
                    textChatlist.Items.Add(message);
                    textChatlist.SelectedIndex = textChatlist.Items.Count - 1;
                }
            }
        }


        /// <summary>
        ///     Ereignis - Send-Button wird gedrück.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

        private void bSend_Click(object sender, EventArgs e)
        {
            SendBinaryData.SendData("chat", textChat.Text, "platzhalter");
            // Schreibe Nachricht in Chatliste
            AddTextToChat(Program.User.Name + " @" + DateTime.Now + ": " + textChat.Text);
            textChat.Clear();
        }


        /// <summary>
        ///     Ereignis - Enter wird gedrückt wird gedrück.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">KeyEventArgs</param>

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


        /// <summary>
        ///     Zeichne das Spielbrett.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">PaintEventArgs</param>

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


        /// <summary>
        ///     Fülle ein Quadrat am Spielfeld aus.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">PaintEventArgs</param>

        public void FillField(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.SkyBlue, _spielfeld[1, 1]);
        }


        /// <summary>
        ///     Ereignis - Start-Button wird gedrück.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

        private void bStartGame_Click(object sender, EventArgs e)
        {
            StartGameOrRequestForGame.StartOrRequest();
        }


        /// <summary>
        ///     Ereignis - Stop-Button wird gedrück.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

        private void bStopGame_Click(object sender, EventArgs e)
        {
            StopGameOrStopRequest.Decide();
        }


        /// <summary>
        ///     Delegate für Methode "SperreStart".
        /// </summary>

        delegate void SetStartButtonCallback();


        /// <summary>
        ///     Sperre den Start-Button, entsperre den Stop-Button.
        /// </summary>

        public void SperreStart()
        {
            if (bStartGame.InvokeRequired || bStopGame.InvokeRequired)
            {
                SetStartButtonCallback d = SperreStop;
                Invoke(d, new object[] {});
            }
            else
            {
                bStartGame.Enabled = false;
                bStopGame.Enabled = true;
            }
        }


        /// <summary>
        ///     Delegate für Methode "SperreStop".
        /// </summary>

        delegate void SetStopButtonCallback();


        /// <summary>
        ///     Sperre den Stop-Button, entsperre den Start-Button.
        /// </summary>

        public void SperreStop()
        {

                if (bStartGame.InvokeRequired || bStopGame.InvokeRequired)
                {
                    SetStopButtonCallback d = SperreStop;
                    Invoke(d, new object[] {});
                }
                else
                {
                    bStartGame.Enabled = true;
                    bStopGame.Enabled = false;
                }
        }


        /// <summary>
        ///     Ereignis - Synchronisation Timer.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

        private void TimerSync_Tick(object sender, EventArgs e)
        {
            _timerCount++;

            try
            {
                SendBinaryData.SendData("sync", "Synchronisiere", Convert.ToString(_timerCount));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

        }


        /// <summary>
        ///     Ereignis - Connect-Button wird gedrück.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

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

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                // wenn Textfeld nicht lee ist ändere name
                if (!string.IsNullOrEmpty(txtName.Text))
                {

                    Program.User.Name = txtName.Text;
                    textChatlist.Items.Add("Der Name wurde auf '" + txtName.Text + "' geändert!");
                    txtName.Clear();

                    e.Handled = true;
                    e.SuppressKeyPress = true;

                }
            }
        }



        /// <summary>
        ///     Ereignis - Connect-Button wird gedrück.
        /// </summary>

        public void EnableGameButtons()
        {
            bSpalte1.Enabled = true;
            bSpalte2.Enabled = true;
            bSpalte3.Enabled = true;
            bSpalte4.Enabled = true;
            bSpalte5.Enabled = true;
            bSpalte6.Enabled = true;
            bSpalte7.Enabled = true;
        }


        /// <summary>
        ///     Ereignis - Connect-Button wird gedrück.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">EventArgs</param>

        private void bSpalte1_Click(object sender, EventArgs e)
        {

            SpielSchnittstelle.SetEinwurf(1);
            DisableGameButtons();

        }

        private void bSpalte2_Click(object sender, EventArgs e)
        {

            SpielSchnittstelle.SetEinwurf(2);
            DisableGameButtons();

        }

        private void bSpalte3_Click(object sender, EventArgs e)
        {

            SpielSchnittstelle.SetEinwurf(3);
            DisableGameButtons();

        }

        private void bSpalte4_Click(object sender, EventArgs e)
        {

            SpielSchnittstelle.SetEinwurf(4);
            DisableGameButtons();

        }

        private void bSpalte5_Click(object sender, EventArgs e)
        {

            SpielSchnittstelle.SetEinwurf(5);
            DisableGameButtons();

        }

        private void bSpalte6_Click(object sender, EventArgs e)
        {

            SpielSchnittstelle.SetEinwurf(6);
            DisableGameButtons();

        }

        private void bSpalte7_Click(object sender, EventArgs e)
        {

            SpielSchnittstelle.SetEinwurf(7);
            DisableGameButtons();

        }

        private void DisableGameButtons()
        {

            bSpalte1.Enabled = false;
            bSpalte2.Enabled = false;
            bSpalte3.Enabled = false;
            bSpalte4.Enabled = false;
            bSpalte5.Enabled = false;
            bSpalte6.Enabled = false;
            bSpalte7.Enabled = false;

        }

        private void textChatlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
