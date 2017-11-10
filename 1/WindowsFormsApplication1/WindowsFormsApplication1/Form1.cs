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
         double Var1 = 1;
         double Var2 = 0;
         double Var3 = 1;
         double Var4 = 0;
        
        


        private void button1_Click(object sender, EventArgs e)
      {
            if (radioButton1.Checked == true)
            {
                for (double i = -10; i <= 10; i = i + 0.1)
                {
                    Pen p2 = new Pen(Color.Black, 1);
                    Point j = new Point((panel1.Width / 20)*i,(Var1*(Math.Pow(i-Var2,Var3)-Var4)));
                    Point k = new Point((panel1.Width / 20) * (i + 1), (Var1 * Math.Pow(i+0.1-Var2,Var3) - Var4));
                    Zeichenfläche.DrawLine(p2, j, k);
                }
            }
            else if (radioButton2.Checked == true)
            {
                for (double i = -100; i < 100; i = i+ 0.1)
                {

                }
            }
            else if (radioButton3.Checked == true)
            {
                for (double i = -1000; i < 1000; i=i+0.1)
                {

                }
            }
            
      }

      private void panel1_Paint(object sender, PaintEventArgs e)
        { 

          }
          private void Optimiere_Fenster()
          {
           /*   panel1.Width = this.ClientRectangle.Width - 50;
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
            for (int i = 0; i <= 1000000; i++)
            {
                Console.WriteLine(i);
                
            }
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
           Pen p1 = new Pen(Color.Black,1);
           Zeichenfläche = panel1.CreateGraphics();
            Zeichenfläche.Clear(Color.White);
            int NiemalsK = 20;
           int NiemalsJ = NiemalsK/2;

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
               int k = (panel1.Width/NiemalsK);  
                Point one;
                one = new Point(panel1.Width/2 + i*k-1, panel1.Height / 2 + panel1.Height / 100);
                Point two;
                two = new Point(panel1.Width/2 + i*k-1, panel1.Height / 2 - panel1.Height / 100);

                Point three;
                three = new Point(panel1.Width/2 - i * k, panel1.Height / 2 + panel1.Height / 100);
                Point four;
                four = new Point(panel1.Width/2 - i * k, panel1.Height / 2 - panel1.Height / 100);



                int l = (panel1.Height / NiemalsK);
                Point five;
                five = new Point( panel1.Width / 2 + panel1.Width / 100, panel1.Height / 2 + i * l-1);
                Point six;
                six = new Point(panel1.Width / 2 - panel1.Width / 100, panel1.Height / 2 + i * l-1);

                Point seven;
                seven = new Point(panel1.Width / 2 + panel1.Width / 100,panel1.Height / 2 - i * l );
                Point eight;
                eight = new Point(panel1.Width / 2 - panel1.Width / 100,panel1.Height/2 - i * l );


                Zeichenfläche.DrawLine(p1, three, four);
                Zeichenfläche.DrawLine(p1,one,two);
                Zeichenfläche.DrawLine(p1, five,six);
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

        }
    }
    }


    

