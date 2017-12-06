using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Graphics Zeichenfläche;
        double h;
        double j;

        private void Optimiere_Fenster()
        {
            /*  panel1.Width = this.ClientRectangle.Width - 50;
               panel1.Height = this.ClientRectangle.Height - 100;


               if (panel1.Width % 2 == 0)
               {
                   panel1.Width = panel1.Width - 1;
               }
               if (panel1.Height % 2 == 0)
               {
                   panel1.Height = panel1.Height - 1;
               }

     */


        }

       





        private void button3_Click(object sender, EventArgs e)
        {
            //Schräger Wurf
            double l = Convert.ToDouble(txtdef.Text);
            h = Math.Abs(Convert.ToDouble(txtdef.Text));
            double h2 = (h2 = h / 100000);
            for (double i = -Convert.ToDouble(txtdef.Text); i < Convert.ToDouble(txtdef.Text); i = i +h2)
            {


              double Wurf = -(9.81 / 2) * (Math.Pow(i, 2) / (Math.Pow(10, 2) * Math.Pow(Math.Cos(Math.PI * 45 / 180), 2) + i * Math.Tan(45);
            }
            {
                Console.WriteLine(i);

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Pen p1 = new Pen(Color.Black, 1);
            Zeichenfläche = panel1.CreateGraphics();
            h = Convert.ToDouble(txtdef.Text)/Convert.ToDouble(txtskal.Text);
            Zeichenfläche.Clear(Color.White);
            int NiemalsK = Convert.ToInt32(h)*2;
            int NiemalsJ = NiemalsK;

            Point x_MO;
            x_MO = new Point(panel1.Width / 2, 0);
            Point x_MU;
            x_MU = new Point(panel1.Width / 2, Height);
            Point y_ML;
            y_ML = new Point(0, panel1.Height / 2);
            Point y_MR;
            y_MR = new Point(Width, panel1.Height / 2);
            Zeichenfläche.DrawLine(p1, x_MO, x_MU);
            Zeichenfläche.DrawLine(p1, y_ML, y_MR);
            for (int i = 1; i <= NiemalsJ; i++)
            {
                int k = (panel1.Width / NiemalsK);
                Point one;
                one = new Point(panel1.Width / 2 + i * k - 1, panel1.Height / 2 + panel1.Height / 100);
                Point two;
                two = new Point(panel1.Width / 2 + i * k - 1, panel1.Height / 2 - panel1.Height / 100);

                Point three;
                three = new Point(panel1.Width / 2 - i * k, panel1.Height / 2 + panel1.Height / 100);
                Point four;
                four = new Point(panel1.Width / 2 - i * k, panel1.Height / 2 - panel1.Height / 100);



                int l = (panel1.Height / NiemalsK);
                Point five;
                five = new Point(panel1.Width / 2 + panel1.Width / 100, panel1.Height / 2 + i * l - 1);
                Point six;
                six = new Point(panel1.Width / 2 - panel1.Width / 100, panel1.Height / 2 + i * l - 1);

                Point seven;
                seven = new Point(panel1.Width / 2 + panel1.Width / 100, panel1.Height / 2 - i * l);
                Point eight;
                eight = new Point(panel1.Width / 2 - panel1.Width / 100, panel1.Height / 2 - i * l);


                Zeichenfläche.DrawLine(p1, three, four);
                Zeichenfläche.DrawLine(p1, one, two);
                Zeichenfläche.DrawLine(p1, five, six);
                Zeichenfläche.DrawLine(p1, seven, eight);

                /*   Point EdgeLeftNr1;
                   EdgeLeftNr1 = new Point(0, panel1.Height);
                   Point EdgeLeftNr2;
                   EdgeLeftNr2 = new Point(0, 0);
                   Zeichenfläche.DrawLine(p1, EdgeLeftNr1, EdgeLeftNr2); */
            }
        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Pen p1 = new Pen(Color.Black, 1);
                Zeichenfläche = panel1.CreateGraphics();
                h = Convert.ToDouble(txtdef.Text) / Convert.ToDouble(txtskal.Text);
                Zeichenfläche.Clear(Color.White);
                int NiemalsK = Convert.ToInt32(h) * 2;
                int k = (panel1.Width / NiemalsK);
                int l = (panel1.Height / NiemalsK);
                double xmin = Convert.ToDouble(txtxmin.Text);
                double xmax = Convert.ToDouble(txtxmax.Text);
                double ymin = Convert.ToDouble(txtymin.Text);
                double ymax = Convert.ToDouble(txtymax.Text);

                Point x_MO;
                x_MO = new Point(panel1.Width / 2, 0);
                Point x_MU;
                x_MU = new Point(panel1.Width / 2, Height);
                Point y_ML;
                y_ML = new Point(0, panel1.Height / 2);
                Point y_MR;
                y_MR = new Point(Width, panel1.Height / 2);
                Zeichenfläche.DrawLine(p1, x_MO, x_MU);
                Zeichenfläche.DrawLine(p1, y_ML, y_MR);
                for (int i = 1; i <= NiemalsK; i++)
                {
                    
                    Point one;
                    one = new Point(panel1.Width / 2 + i * k - 1, panel1.Height / 2 + panel1.Height / 100);
                    Point two;
                    two = new Point(panel1.Width / 2 + i * k - 1, panel1.Height / 2 - panel1.Height / 100);

                    Point three;
                    three = new Point(panel1.Width / 2 - i * k, panel1.Height / 2 + panel1.Height / 100);
                    Point four;
                    four = new Point(panel1.Width / 2 - i * k, panel1.Height / 2 - panel1.Height / 100);



                    
                    Point five;
                    five = new Point(panel1.Width / 2 + panel1.Width / 100, panel1.Height / 2 + i * l - 1);
                    Point six;
                    six = new Point(panel1.Width / 2 - panel1.Width / 100, panel1.Height / 2 + i * l - 1);

                    Point seven;
                    seven = new Point(panel1.Width / 2 + panel1.Width / 100, panel1.Height / 2 - i * l);
                    Point eight;
                    eight = new Point(panel1.Width / 2 - panel1.Width / 100, panel1.Height / 2 - i * l);


                    Zeichenfläche.DrawLine(p1, three, four);
                    Zeichenfläche.DrawLine(p1, one, two);
                    Zeichenfläche.DrawLine(p1, five, six);
                    Zeichenfläche.DrawLine(p1, seven, eight);
                }
                  double skalew;
                  double skaleh;
                  h = Math.Abs(Convert.ToDouble(txtdef.Text));
                  j = h - (h * 2);
                  double h2 = (h2 = h / 100000);
                  skalew = Convert.ToDouble(panel1.Width) / (Convert.ToDouble(txtdef.Text) * 2);
                  skaleh = Convert.ToDouble(panel1.Height) / (Convert.ToDouble(txtdef.Text) * 2);
                  double FunktionsWert;
                  for (double i = j; i < h; i = i + h2)
                  {


                      double xWert = i;
                      FunktionsWert = Polynom_3G(xWert);
                      SolidBrush a = new SolidBrush(Color.Black);
                        // Zeichenfläche.FillRectangle(a, ((float)xWert * (float)skalew)+(panel1.Width/2), -((float)FunktionsWert * (float)skaleh)+(panel1.Height/2), 1, 1);
                        //  Zeichenfläche.FillRectangle(a, (((float)xWert) * (float)skalew) + (panel1.Width / 2), -((float)FunktionsWert * (float)skaleh) + (panel1.Height / 2), 1, 1);

                      Zeichenfläche.FillRectangle(a, ((float)xWert * (float)skalew) + (panel1.Width / 2), -((float)FunktionsWert * (float)skaleh) + (panel1.Height / 2), 1, 1);
                  }
            }
            catch { }
        }
        private double Polynom_3G(double x)
        {
            double a, b, c, d; 
            
            a = Convert.ToDouble(txtboxa.Text);
            b = Convert.ToDouble(txtboxb.Text);
            c = Convert.ToDouble(txtboxc.Text);
            d = Convert.ToDouble(txtboxd.Text);
            
            return (a * Math.Pow(x, 3) + b * Math.Pow(x, 2) + c * x + d);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          /*  Pen p1 = new Pen(Color.Black, 1);
            Zeichenfläche = panel1.CreateGraphics();
            h = Convert.ToDouble(txtdef.Text) / Convert.ToDouble(txtskal.Text);
            Zeichenfläche.Clear(Color.White);
            int NiemalsK = Convert.ToInt32(h) * 2;
            int NiemalsJ = NiemalsK;

            Point x_MO;
            x_MO = new Point(panel1.Width / 2, 0);
            Point x_MU;
            x_MU = new Point(panel1.Width / 2, Height);
            Point y_ML;
            y_ML = new Point(0, panel1.Height / 2);
            Point y_MR;
            y_MR = new Point(Width, panel1.Height / 2);
            Zeichenfläche.DrawLine(p1, x_MO, x_MU);
            Zeichenfläche.DrawLine(p1, y_ML, y_MR);
            for (int i = 1; i <= NiemalsJ; i++)
            {
                int k = (panel1.Width / NiemalsK);
                Point one;
                one = new Point(panel1.Width / 2 + i * k - 1, panel1.Height / 2 + panel1.Height / 100);
                Point two;
                two = new Point(panel1.Width / 2 + i * k - 1, panel1.Height / 2 - panel1.Height / 100);

                Point three;
                three = new Point(panel1.Width / 2 - i * k, panel1.Height / 2 + panel1.Height / 100);
                Point four;
                four = new Point(panel1.Width / 2 - i * k, panel1.Height / 2 - panel1.Height / 100);



                int l = (panel1.Height / NiemalsK);
                Point five;
                five = new Point(panel1.Width / 2 + panel1.Width / 100, panel1.Height / 2 + i * l - 1);
                Point six;
                six = new Point(panel1.Width / 2 - panel1.Width / 100, panel1.Height / 2 + i * l - 1);

                Point seven;
                seven = new Point(panel1.Width / 2 + panel1.Width / 100, panel1.Height / 2 - i * l);
                Point eight;
                eight = new Point(panel1.Width / 2 - panel1.Width / 100, panel1.Height / 2 - i * l);


                Zeichenfläche.DrawLine(p1, three, four);
                Zeichenfläche.DrawLine(p1, one, two);
                Zeichenfläche.DrawLine(p1, five, six);
                Zeichenfläche.DrawLine(p1, seven, eight);
            }*/
            timer1.Enabled = false;
        }
    }
}