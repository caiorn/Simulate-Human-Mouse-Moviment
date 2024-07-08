using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MouseSimulator
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData,
          int dwExtraInfo);

        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010,
            WHEEL = 0x00000800,
            XDOWN = 0x00000080,
            XUP = 0x00000100
        }

        private void MouseClick()
        {
            mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
            Thread.Sleep((new Random()).Next(20, 30));
            mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
        }

        private void MouseLeftDown()
        {
            mouse_event((uint)MouseEventFlags.LEFTDOWN, 0, 0, 0, 0);
        }

        private void MouseLeftUp()
        {
            mouse_event((uint)MouseEventFlags.LEFTUP, 0, 0, 0, 0);
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblCordX.Text = "X: " + Cursor.Position.X.ToString();
            lblCordY.Text = "Y: " + Cursor.Position.Y.ToString();
        }

        private bool cronometrar_e_procurar(ref Point? finded, Bitmap screenshot, Bitmap picscreen) {
            if (picscreen == null) return false; ;

            //inicia cronometro
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Reset();
            stopWatch.Start();
            this.Cursor = Cursors.WaitCursor;

            //procura na screenshot da tela a parte da imagem picscreen
            finded = Find(screenshot, picscreen);

            this.Cursor = Cursors.Default;
            stopWatch.Stop();
            //se nao encontrar
            if (finded != null)
            {
                label6.Text += "Imagem encontrada em " + "X:" + finded.Value.X + " Y:" + finded.Value.Y + "  " + stopWatch.ElapsedMilliseconds + "ms.\n";
                return true;
            }
            else
            {
                label6.Text += "Imagem não encontrada.\n";
                return false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";            
            HWMM.mouseSpeed = trackBar1.Value;

            Point? inicio = null;
            Point? destino = null;
            Bitmap screenshot = captureScreen();

            //definindo posicao inicial do cursor
            if (rdoDeCord.Checked) {
                int x = 0, y = 0;
                if (int.TryParse(txtXgo.Text, out x) && int.TryParse(txtYgo.Text, out y)) {
                    inicio = new Point(x, y);
                } 
            } else if (rdoDeImg.Checked) {
                bool achouImagemInicio = cronometrar_e_procurar(ref inicio, screenshot, (Bitmap)pictureBox1.Image);
            }
            
            // destino do cursor
            if (rdoParaCord.Checked) {
                int x = 0, y = 0;
                if (int.TryParse(txtXend.Text, out x) && int.TryParse(txtYend.Text, out y)) {
                    destino = new Point(x, y);
                }
            } else if (rdoParaImg.Checked) {
                bool achouImagemDestino = cronometrar_e_procurar(ref destino, screenshot, (Bitmap)pictureBox2.Image);
            }

            // execução
            if(destino != null) {
                if (inicio != null) {
                    HWMM.SetCursorPos(inicio.Value.X, inicio.Value.Y);
                }
                mover_e_clicar(destino.Value);
            }   
        }

        private void mover_e_clicar(Point destino) {
            if (chkArrastarClique.Checked)
            {
                MouseLeftDown();
                HWMM.MoveMouse(destino);
                MouseLeftUp();
            }
            else
            {
                HWMM.MoveMouse(destino);
            }

            if (chkClicarFimMovimento.Checked)
            {
                MouseClick();
                MouseClick();
            }
        }

        private void txtXgo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && txtXgo.Text != "")
                {
                    int x = int.Parse(txtXgo.Text);
                    HWMM.SetCursorPos(x, Cursor.Position.Y);
                }
            }
            catch (Exception) { /*throw;*/ }
            


        }

        private void txtYgo_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    int y = int.Parse(txtYgo.Text);
                    HWMM.SetCursorPos(Cursor.Position.X, y);
                }
            }
            catch (Exception) { /*throw;*/  }
            
        }

        private void btnSearchImg_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "BMP and PNG files (*.bmp, *.png)|*.bmp;*.png";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            lblVelocidade.Text = "Velocidade: " + trackBar1.Value;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new printcut(this, ref pictureBox2).Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new printcut(this, ref pictureBox1).Show();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Visible = pictureBox2.Visible = !checkBox1.Checked;
        }

        //CODIGO RELEVANTES ABAIXO.

        /// <summary>
        /// Captura uma screen da tela completa
        /// </summary>
        /// <returns>screen da tela</returns>
        private Bitmap captureScreen()
        {
                Bitmap bmpScreenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height,PixelFormat.Format32bppArgb);
                Graphics g = Graphics.FromImage(bmpScreenShot);
                g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size);
                return bmpScreenShot;
   
        }

        //metodo3 solução Mais rapida
        /// <summary>
        /// Procurar em um screnshot uma bitmap
        /// </summary>
        /// <param name="haystack">Screen a ser procurada</param>
        /// <param name="needle">bitmap a ser achado</param>
        /// <returns>Posição do bitmap se achado</returns>
        public Point? Find(Bitmap haystack, Bitmap needle)
        {
            if (null == haystack || null == needle)
            {
                return null;
            }
            if (haystack.Width < needle.Width || haystack.Height < needle.Height)
            {
                return null;
            }

            var haystackArray = GetPixelArray(haystack);
            var needleArray = GetPixelArray(needle);

            foreach (var firstLineMatchPoint in FindMatch(haystackArray.Take(haystack.Height - needle.Height), needleArray[0]))
            {
                if (IsNeedlePresentAtLocation(haystackArray, needleArray, firstLineMatchPoint, 1))
                {
                    return firstLineMatchPoint;
                }
            }

            return null;
        }

        private int[][] GetPixelArray(Bitmap bitmap)
        {
            var result = new int[bitmap.Height][];
            var bitmapData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly,
                PixelFormat.Format32bppArgb);

            for (int y = 0; y < bitmap.Height; ++y)
            {
                result[y] = new int[bitmap.Width];
                Marshal.Copy(AddToPointer(bitmapData.Scan0, y , bitmapData.Stride), result[y], 0, result[y].Length);
            }

            bitmap.UnlockBits(bitmapData);

            return result;
        }

        private IEnumerable<Point> FindMatch(IEnumerable<int[]> haystackLines, int[] needleLine)
        {
            var y = 0;
            foreach (var haystackLine in haystackLines)
            {
                for (int x = 0, n = haystackLine.Length - needleLine.Length; x < n; ++x)
                {
                    if (ContainSameElements(haystackLine, x, needleLine, 0, needleLine.Length))
                    {
                        yield return new Point(x, y);
                    }
                }
                y += 1;
            }
        }

        private bool ContainSameElements(int[] first, int firstStart, int[] second, int secondStart, int length)
        {
            for (int i = 0; i < length; ++i)
            {
                if (first[i + firstStart] != second[i + secondStart])
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNeedlePresentAtLocation(int[][] haystack, int[][] needle, Point point, int alreadyVerified)
        {
            //we already know that "alreadyVerified" lines already match, so skip them
            for (int y = alreadyVerified; y < needle.Length; ++y)
            {
                if (!ContainSameElements(haystack[y + point.Y], point.X, needle[y], 0, needle.Length))
                {
                    return false;
                }
            }
            return true;
        }
        private static IntPtr AddToPointer(IntPtr ptr, int offset, int offset2)
        {
            return new IntPtr(ptr.ToInt64() + offset * offset2);
        }
        
    }

}