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
          Pen p1;   
          Graphics Zeichenfläche;
            int NiemalsJ = 10;
            private void button1_Click(object sender, EventArgs e)
      {
         
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


      

 


        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 1000000; i++)
            {
                Console.WriteLine(i);
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
          Pen p1 = new Pen(Color.Black,1);
          Zeichenfläche = panel1.CreateGraphics();

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
               int k = (panel1.Width/10);  
                Point one;
                one = new Point(i*k, panel1.Height / 2 + panel1.Height / 50);
                Point two;
                two = new Point(i*k, panel1.Height / 2 - panel1.Height / 50);


                
                int l = (panel1.Height / 10);
                Point three;
                three = new Point( panel1.Width / 2 + panel1.Width / 50, i * l);
                Point four;
                four = new Point(panel1.Width / 2 - panel1.Width / 50, i * l);


                Zeichenfläche.DrawLine(p1, three, four);
                Zeichenfläche.DrawLine(p1,one,two);
            }
        }
    }
    }


    

