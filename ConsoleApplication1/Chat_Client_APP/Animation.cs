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
    class Animation : System.Windows.Forms.Form
    {


        /// <summary>
        ///     Ctor
        /// </summary>

        public Animation()
        {
            DoubleBuffered = true;

            Paint += DoAnimation;
        }


        /// <summary>
        ///     DoAnimation.
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">PaintEventArgs</param>

        public void DoAnimation(object sender, PaintEventArgs e)
                {
                    var nNumberInc = 0;
                    var ySize = 91;
                    var xSize = 91;
                    var xPoint = 569;
                    var yPoint = 70;
                    var xmove = 1;
                    var ymove = 1;
                    var rect = new Rectangle();
                    var point = new Point();
        
                    var size = new Size(ySize, xSize);
        
        
        
                    //erstelle Gitter
                    //Spalten
                    while (true)
                    {
                        for (var i = 0; i < 10; i++)
                        {
                            //Invalidate(rect);
        
                            point = new Point(xPoint + xmove, yPoint);
                            rect = new Rectangle(point, size);
        
                            e.Graphics.DrawRectangle(Pens.White, rect);
        
                            nNumberInc++;
        
                            xmove++;
                            e.Graphics.Dispose();
                        }
                        nNumberInc++;
        
                        //e.Graphics.Dispose();
        
                        for (var i = 0; i < 10; i++)
                        {
                            //Invalidate(rect);
        
                            point = new Point(xPoint, yPoint + ymove);
                            rect = new Rectangle(point, size);
        
                            e.Graphics.DrawRectangle(Pens.White, rect);

                            nNumberInc++;
        
                            ymove++;
                            e.Graphics.Dispose();
                        }
        
                        //e.Graphics.Dispose();
        
                    }
        
        }
    }
}
