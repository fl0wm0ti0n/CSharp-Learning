using System;
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

namespace Chat_Client_APP
{
    public partial class Form1 : Form
    {

        static int nNumberOf = 7 * 5;
        Rectangle[,] spielfeld = new Rectangle[7, 5];
        Point[] point = new Point[nNumberOf];
        Size[] size = new Size[nNumberOf];

        public Form1()
        {

            InitializeComponent();
            Connection.CreateSocket();



            // Füge LokaleIp automatsich im Textefeld ein 
            textIP1.Text = Connection.GetLocalIP();
            textIP2.Text = Connection.GetLocalIP();
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //--------------------------------------------------------------------------------------------------------
        public void SendFuckMSG(string message)
        {
            if (message.Length != 0)
            {
                textChatlist.Items.Add(message);
            }

        }
        //--------------------------------------------------------------------------------------------------------
        private void bSend_Click(object sender, EventArgs e)
        {
            string sMsg = Connection.SendMSG(textChat.Text);

            // Schreibe Nachricht in Chatliste
            textChatlist.Items.Add(sMsg);
            textChat.Clear();

        }

        //--------------------------------------------------------------------------------------------------------

        private void textChat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sMsg = Connection.SendMSG(textChat.Text);
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

            this.DoubleBuffered = true;

            this.Paint += new PaintEventHandler(Form1_Paint);


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
            for (int i = 0; i < 5; i++)
            {

                //Zeilen
                for (int j = 0; j < 7; j++)
                {
                    point[nNumberInc] = new Point(xPoint, yPoint);
                    size[nNumberInc] = new Size(ySize, xSize);
                    spielfeld[j, i] = new Rectangle(point[nNumberInc], size[nNumberInc]);

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


            foreach (Rectangle s in spielfeld)
            {
            e.Graphics.DrawRectangle(Pens.White, s);
            }
        }
//--------------------------------------------------------------------------------------------------------
        public void FillField(PaintEventArgs e)
        {

            e.Graphics.FillRectangle(Brushes.Azure, spielfeld[1, 1]);

        }
        //--------------------------------------------------------------------------------------------------------

        private void bSpalte1_Click(object sender, EventArgs e)
        {
            Game.Einwurf(1, e);

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
            Game.Einwurf(2, e);

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
            Game.Einwurf(3, e);

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
            Game.Einwurf(4, e);

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
            Game.Einwurf(5, e);

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
            Game.Einwurf(6, e);

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
            Game.Einwurf(7, e);

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

    }
}
