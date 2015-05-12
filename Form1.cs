using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        //koordinate
        public int x1;
        public int y1;

        public int x2;
        public int y2;
        
        //četka za punjenje grafičkih oblika

        SolidBrush cetka = new SolidBrush(Color.Black);
        SolidBrush cetka2 = new SolidBrush(Color.Black);
        
        //olovka i njena debljina

        Pen p = new Pen(Color.Black);
        int debljina_olovke;

        //predstavlja GDI+ površinu za crtanje, tj klasa u koju se spremaju grafički podaci

        Graphics g;

        // predstavlja točku, par x i y koordinata

        private Point _lastLoc; 

        //predstavlja bitmapu od GDI+, sadrži podatke o pikselima za grafičku sliku i njene atribute

        Bitmap stanje;

        Graphics pom;
        

        public Form1()
        {
            InitializeComponent(); 
        }


        

        private void Boja_ispune_Click(object sender, EventArgs e)  // za popunjavanje pozadine odabranom bojom
        {
           

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cetka.Color = colorDialog1.Color;
                Boja_ispune.BackColor = colorDialog1.Color;
            }
        }

        private void Boja_olovke_Click(object sender, EventArgs e)  //odabir boje olovke
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                p.Color = colorDialog1.Color;
                Boja_olovke.BackColor = colorDialog1.Color;
            }

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e) // bojanje oblika, događaj kada je botun miša pritisnut
        {
            _lastLoc = e.Location; //postavljanje koordinata točke

            x1 = e.X;
            y1 = e.Y;

            if (Kantica_boje.Checked == true)
            {
                FloodTools.FloodFill(stanje, e.X, e.Y, cetka2.Color);
                Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e) //događaj kada botun miša nije pritisnut; crtanje oblika
        {
            x2 = e.X;
            y2 = e.Y;

            


            if (Pravoukutnik.Checked == true && Kantica_boje.Checked==false) //crtanje pravokutnika
            {
                

                var width = x2 - x1;
                var height = y2 - y1;
                var pocetni_x = x1;
                var pocetni_y = y1;

                if (width < 0 && height < 0)
                {
                    width = width * (-1);
                    height = height * (-1);
                    pocetni_x = pocetni_x - width ;
                    pocetni_y = pocetni_y - height ;
                }

                else if (width > 0 && height < 0)
                {
  
                    height = height * (-1);
                    pocetni_y = pocetni_y - height ;
                }

                else if (width < 0 && height > 0)
                {

                    width = width * (-1);
                    pocetni_x = pocetni_x - width ;
                }

                Rectangle r = new Rectangle(pocetni_x, pocetni_y, width, height);

                g.DrawRectangle(p, r);

                pom.DrawRectangle(p, r);

                if (Ispuna.Checked == true) //ukoliko je označena ispuna oblika
                {
                    g.FillRectangle(cetka, pocetni_x + p.Width/2 , pocetni_y + p.Width/2 , width -  p.Width , height - p.Width );
                    pom.FillRectangle(cetka, pocetni_x + p.Width / 2, pocetni_y + p.Width / 2, width - p.Width, height - p.Width);
                }

            }

       

            else if (Elipsa.Checked == true && Kantica_boje.Checked == false) //crtanje elipse
            {
    


                g.SmoothingMode = SmoothingMode.AntiAlias; //zaglađivanje linije

                Rectangle r = new Rectangle(x1, y1, x2 - x1, y2 - y1);

                g.DrawEllipse(p, r); //crta elipsu specificiranu recktangle klasom

                pom.DrawEllipse(p, r);

                p.Width = 8.0F;

                if (Ispuna.Checked == true)
                {
                    g.FillEllipse(cetka, x1, y1, x2 - x1, y2 - y1);
                    pom.FillEllipse(cetka, x1, y1, x2 - x1, y2 - y1);
                }

            }

           

            else if (Linija.Checked == true && Kantica_boje.Checked == false)
            {
 

                g.SmoothingMode = SmoothingMode.AntiAlias;

                Point point1 = new Point(x1, y1);
                Point point2 = new Point(x2, y2);

                g.DrawLine(p, point1, point2);
                pom.DrawLine(p, point1, point2);
            }


            x1 = -1;
            y1 = -1;
            
        }

        
        private void pictureBox1_Paint(object sender, PaintEventArgs e) //definira pictureBox
        {     
                
                e.Graphics.DrawImage(stanje, new Point(0, 0));

          
        }

        private void Kanta_Click(object sender, EventArgs e) //definira alat za bojanje pozadine
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                cetka2.Color = colorDialog1.Color;
                Kanta.BackColor = colorDialog1.Color;
            }

        }



        private void Form1_Load(object sender, EventArgs e) //loadanje forme
        {
            p.Width = 8;

            x1 = -1;
            y1 = -1;

            y2 = -1;
            y2 = -1;

            stanje = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            pom = Graphics.FromImage(stanje);
            pictureBox1.BackColor = Color.White;

            for (int x = 0; x < stanje.Width; x++)
            {
                for (int y = 0; y < stanje.Height; y++)
                {

                    stanje.SetPixel(x, y, Color.White);

                }
            }

            p.Width = 1;
            g= pictureBox1.CreateGraphics();

          

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) //akcija na pomicanje miša, crtanje olovkom
        {

            if (Control.MouseButtons == MouseButtons.Left && Olovka.Checked==true) { paintCurrentPosition(e.Location); } 

        }

        private void textBox1_TextChanged(object sender, EventArgs e) //mijenjanje debljine olovke
        {
            debljina_olovke = Convert.ToInt32(textBox1.Text);
            debljina_olovke = int.Parse(textBox1.Text);

            p.Width = debljina_olovke;
        }

        private void paintCurrentPosition(Point loc)
        {
            /** this method is responsible for creating a single spot on the current position of the cursor.
                * The cursor position as indicated
                * by Cursor.Position is not accurately placed at the tip, so an offset is being employed to make sure that the spot appears at the tip of
                * the cursor*/ 
    
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pom.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            g.DrawLine(p, _lastLoc, loc);
            pom.DrawLine(p, _lastLoc, loc);
            _lastLoc = loc;

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) //save slike
        {
            

            /*if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(this.saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
            }*/
            pictureBox1.Image.Save(@"C:\image1.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
            MessageBox.Show("The created image has been exported to your local drive");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) //brisanje trenutne slike
        {
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
            pictureBox1.Refresh();


            /*Graphics objGraphics = Graphics.FromImage(pictureBox1.Image);
            //Brisanje iscrtanog sadržaja
            objGraphics.Clear(pictureBox1.BackColor);
            pictureBox1.Invalidate();
            objGraphics.Dispose();*/
            


        }

     
        private void newToolStripMenuItem_Click(object sender, EventArgs e) //generiranje nove forme
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       


      
    
    }
}
