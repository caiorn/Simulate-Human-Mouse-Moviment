using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MouseSimulator
{
    public partial class printcut : Form
    {
        Form1 form1;
        PictureBox pb;
        public printcut(Form1 form1, ref PictureBox pb)
        {
            this.form1 = form1;
            this.pb = pb;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
             
                if (pictureBox1.Image == null)
                {
                    pictureBox1.Image = CapturePart();
                    pictureBox1.Cursor = Cursors.No;
                    BackColor = Color.Green;
                }
                else
                {
                    pictureBox1.Image = null;
                    pictureBox1.Cursor = Cursors.Hand;
                    BackColor = Color.Red;
                }      
        }        

        private Bitmap CapturePart() {
            
            //cria uma imagem com as medidas do picture box
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

            Graphics g = Graphics.FromImage(bitmap);
            //capturo as cordenadas X e Y do componente na tela inteira
            Point loc = pictureBox1.PointToScreen(Point.Empty);
            //captura um print com as cordenadas e o tamanho do picturebox
            g.CopyFromScreen(loc, Point.Empty, pictureBox1.Size);            

            return bitmap;

        }

        private void printcut_FormClosed(object sender, FormClosedEventArgs e)
        {
             pb.Image = pictureBox1.Image;
             //pb.Image = LessOpacity(pictureBox1.Image, 99.7f);
        }

        private Image LessOpacity(Image image, float PorcentagemOpacidade)
        {
             int val = Convert.ToInt32(PorcentagemOpacidade / 100 * 255);

            Bitmap pic = new Bitmap(image);
            for (int w = 0; w < pic.Width; w++)
            {
                for (int h = 0; h < pic.Height; h++)
                {
                    Color c = pic.GetPixel(w, h);
                    Color newC = Color.FromArgb(val, c);
                    pic.SetPixel(w, h, newC);
                }
            }
            return pic;
        }
    }
}