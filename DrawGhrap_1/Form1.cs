using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawGhrap_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int x1 = 32, y1 = 32,x2,y2;
            int w = 1200, h = 600;
            int value = 25;
            int l1 = y1 + 50;
            int l2 = l1 + 125;
            int l3 = l2 + 125;
            int l4 = l3 + 125;
            int l5 = l4 + 125;
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(x1,y1, w, h));

            //DrawLine
            //line 1
            x2 = w-20 ;
            x1 += 50;

            e.Graphics.DrawLine(new Pen(Color.Black, 3), x1, l1, x2, l1);
            e.Graphics.DrawString(value.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), x1-40, l1-10);


            //line 2

            e.Graphics.DrawLine(new Pen(Color.Black, 3), x1, l2, x2, l2);
            value -= 5;
            e.Graphics.DrawString(value.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), x1 - 40, l2 - 10);


            //line 3


            e.Graphics.DrawLine(new Pen(Color.Black, 3), x1, l3, x2, l3);
            value -= 5;
            e.Graphics.DrawString(value.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), x1 - 40, l3 - 10);


            //line 4

 
            e.Graphics.DrawLine(new Pen(Color.Black, 3), x1, l4, x2, l4);
            value -= 5;
            e.Graphics.DrawString(value.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), x1 - 40, l4 - 10);


            //line 5

    
            e.Graphics.DrawLine(new Pen(Color.Black, 3), x1, l5, x2, l5);
            value -= 5;
            e.Graphics.DrawString(value.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), x1 - 40, l5 - 10);


            //Draw 5 data
            //รูปสูง 600 เส้น หรือ พื้นที่ข้อมูล สูง 500 
            Random r = new Random();
            int _v,min_max;

            for (int i = 0; i < 6; i++)
            {
                _v = r.Next(10, 20);
                min_max = r.Next(1, 5);

              

                x1 += (i == 0)?50:180;
                y1 = l1 + ((25 - _v) * 500 / 20) - 6; // 20 คือ ค่าของความสูงของกราฟจาก 5-25 
                e.Graphics.DrawEllipse(new Pen(System.Drawing.Color.Blue, 5), x1, y1, 10, 10);
                e.Graphics.DrawEllipse(new Pen(System.Drawing.Color.Red, 3), x1 - 3, y1 - 3, 16, 16);
                e.Graphics.DrawString(_v.ToString(), new Font("Arial", 16), new SolidBrush(Color.Black), x1 +10 , y1 +10);

                //draw line
                int h1 = (min_max * 125 / 5);
               // MessageBox.Show( h1.ToString());
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1 + 5,y1,x1 +5,y1-h1);
                e.Graphics.DrawLine(new Pen(Color.Blue, 2), x1 -5, y1 - h1, x1 + 15, y1 - h1);

                e.Graphics.DrawLine(new Pen(Color.Red, 2), x1 + 5, y1 + 15, x1 + 5, y1 + h1+10);
                 e.Graphics.DrawLine(new Pen(Color.Red, 2), x1 -5, y1 + h1+10, x1 +15, y1 + h1+10);
            }
        }
    }
}
