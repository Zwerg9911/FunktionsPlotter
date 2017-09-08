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
           Pen p1 = new Pen(Color.Black,1);
           
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.CreateGraphics();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
     
            




                



                
            }
            private void Optimiere_Fenster()
            {
                panel1.Width = this.ClientRectangle.Width - 50;
                panel1.Height = this.ClientRectangle.Height - 100;


                if (panel1.Width % 2 == 0)
                {
                    panel1.Width = panel1.Width - 1;
                }
                if (panel1.Height % 2 == 0)
                {
                    panel1.Height = panel1.Height - 1;
                }
                



            }

            private void panel1_Paint(object sender, PaintEventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

            Point x_MO;
            x_MO = new Point(panel1.Width / 2, 0);
            Point x_MU;
            x_MU = new Point(panel1.Width / 2, Height);
            Point y_ML;
            y_ML = new Point(0, panel1.Height / 2);
            Point y_MR;
            y_MR = new Point(Width, panel1.Height / 2);
            Zeichenflaeche.DrawLine(Zeichenstift, x_MO, x_MU);
            Zeichenflaeche.DrawLine(Zeichenstift, y_ML, y_MR);
        }
    }
    }


    

