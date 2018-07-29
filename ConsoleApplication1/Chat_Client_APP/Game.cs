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
    public static class Game
    {


    public static void Einwurf(int spalte, EventArgs e)
        {
            int gesetzt = 0;

            Connection.SendData(gesetzt);



        }
        /*public static void ZeichneCoin(int spalte)
        {
            int gesetzt = 0;

            Connection.SendData(gesetzt);

            Control.Paint += new PaintEventHandler(FillField);
        }*/

    }
}
