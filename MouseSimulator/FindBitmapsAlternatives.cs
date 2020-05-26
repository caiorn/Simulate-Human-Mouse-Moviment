using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MouseSimulator
{
    class FindBitmapsAlternatives
    {
        public FindBitmapsAlternatives() {
            Bitmap search = null; // <- imagem a ser procurada
            Bitmap screenshot = null;// <-- print da tela

            ////metodo 2º mais rapido (2x mais lento) (requer codigo não seguro -unsafe-)
            //Rectangle location1 = Rectangle.Empty;
            //location1 = searchBitmap(search, screenshot, 0);

            //if (location1.Width != 0)
            //{
            //    MessageBox.Show("Achou! X:" + location1.X + " Y:" + location1.Y);
            //}

            //método 3º mais rapido (10x mais lento)
            Point location;
            bool sucess = FindBitmap(search, screenshot, out location);
            if (sucess)
            {
                MessageBox.Show("achou ");
            }

            //metodo 20x mais lento porem retorna lista de todos encontrados
            List<Point> lp = FindBitmapsEntry(screenshot, search);
            if (lp.Count > 0)
            {
                MessageBox.Show("achou ");
            }

            
        }


        ////Metodo 2º mais rapido (requer codigo não seguro -unsafe-)
        //private Rectangle searchBitmap(Bitmap smallBmp, Bitmap bigBmp, double tolerance)
        //{
        //    BitmapData smallData =
        //      smallBmp.LockBits(new Rectangle(0, 0, smallBmp.Width, smallBmp.Height),
        //               System.Drawing.Imaging.ImageLockMode.ReadOnly,
        //               System.Drawing.Imaging.PixelFormat.Format24bppRgb);
        //    BitmapData bigData =
        //      bigBmp.LockBits(new Rectangle(0, 0, bigBmp.Width, bigBmp.Height),
        //               System.Drawing.Imaging.ImageLockMode.ReadOnly,
        //               System.Drawing.Imaging.PixelFormat.Format24bppRgb);

        //    int smallStride = smallData.Stride;
        //    int bigStride = bigData.Stride;

        //    int bigWidth = bigBmp.Width;
        //    int bigHeight = bigBmp.Height - smallBmp.Height + 1;
        //    int smallWidth = smallBmp.Width * 3;
        //    int smallHeight = smallBmp.Height;

        //    Rectangle location = Rectangle.Empty;
        //    int margin = Convert.ToInt32(255.0 * tolerance);

        //    unsafe
        //    {
        //        byte* pSmall = (byte*)(void*)smallData.Scan0;
        //        byte* pBig = (byte*)(void*)bigData.Scan0;

        //        int smallOffset = smallStride - smallBmp.Width * 3;
        //        int bigOffset = bigStride - bigBmp.Width * 3;

        //        bool matchFound = true;

        //        for (int y = 0; y < bigHeight; y++)
        //        {
        //            for (int x = 0; x < bigWidth; x++)
        //            {
        //                byte* pBigBackup = pBig;
        //                byte* pSmallBackup = pSmall;

        //                //Look for the small picture.
        //                for (int i = 0; i < smallHeight; i++)
        //                {
        //                    int j = 0;
        //                    matchFound = true;
        //                    for (j = 0; j < smallWidth; j++)
        //                    {
        //                        //With tolerance: pSmall value should be between margins.
        //                        int inf = pBig[0] - margin;
        //                        int sup = pBig[0] + margin;
        //                        if (sup < pSmall[0] || inf > pSmall[0])
        //                        {
        //                            matchFound = false;
        //                            break;
        //                        }

        //                        pBig++;
        //                        pSmall++;
        //                    }

        //                    if (!matchFound) break;

        //                    //We restore the pointers.
        //                    pSmall = pSmallBackup;
        //                    pBig = pBigBackup;

        //                    //Next rows of the small and big pictures.
        //                    pSmall += smallStride * (1 + i);
        //                    pBig += bigStride * (1 + i);
        //                }

        //                //If match found, we return.
        //                if (matchFound)
        //                {
        //                    location.X = x;
        //                    location.Y = y;
        //                    location.Width = smallBmp.Width;
        //                    location.Height = smallBmp.Height;
        //                    break;
        //                }
        //                //If no match found, we restore the pointers and continue.
        //                else
        //                {
        //                    pBig = pBigBackup;
        //                    pSmall = pSmallBackup;
        //                    pBig += 3;
        //                }
        //            }

        //            if (matchFound) break;

        //            pBig += bigOffset;
        //        }
        //    }

        //    bigBmp.UnlockBits(bigData);
        //    smallBmp.UnlockBits(smallData);

        //    return location;
        //}

        //metodo 3 10x mais lento;
        /// <summary>
        /// Find the location of a bitmap within another bitmap and return if it was successfully found
        /// </summary>
        /// <param name="bmpNeedle">The image we want to find</param>
        /// <param name="bmpHaystack">Where we want to search for the image</param>
        /// <param name="location">Where we found the image</param>
        /// <returns>If the bmpNeedle was found successfully</returns>
        private bool FindBitmap(Bitmap bmpNeedle, Bitmap bmpHaystack, out Point location)
        {
            for (int outerX = 0; outerX < bmpHaystack.Width - bmpNeedle.Width; outerX++)
            {
                for (int outerY = 0; outerY < bmpHaystack.Height - bmpNeedle.Height; outerY++)
                {
                    for (int innerX = 0; innerX < bmpNeedle.Width; innerX++)
                    {
                        for (int innerY = 0; innerY < bmpNeedle.Height; innerY++)
                        {
                            Color cNeedle = bmpNeedle.GetPixel(innerX, innerY);
                            Color cHaystack = bmpHaystack.GetPixel(innerX + outerX, innerY + outerY);

                            if (cNeedle.R != cHaystack.R || cNeedle.G != cHaystack.G || cNeedle.B != cHaystack.B)
                            {
                                goto notFound;
                            }
                        }
                    }
                    location = new Point(outerX, outerY);
                    return true;
                    notFound:
                    continue;
                }
            }
            location = Point.Empty;
            return false;
        }

        //metodo 2 20x mais lento porem retorna duplicados
        public static List<Point> FindBitmapsEntry(Bitmap sourceBitmap, Bitmap serchingBitmap)
        {
            #region Arguments check

            if (sourceBitmap == null || serchingBitmap == null)
                throw new ArgumentNullException();

            if (sourceBitmap.PixelFormat != serchingBitmap.PixelFormat)
                throw new ArgumentException("Pixel formats arn't equal");

            if (sourceBitmap.Width < serchingBitmap.Width || sourceBitmap.Height < serchingBitmap.Height)
                throw new ArgumentException("Size of serchingBitmap bigger then sourceBitmap");

            #endregion

            var pixelFormatSize = Image.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;


            // Copy sourceBitmap to byte array
            var sourceBitmapData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height),
                ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
            var sourceBitmapBytesLength = sourceBitmapData.Stride * sourceBitmap.Height;
            var sourceBytes = new byte[sourceBitmapBytesLength];
            Marshal.Copy(sourceBitmapData.Scan0, sourceBytes, 0, sourceBitmapBytesLength);
            sourceBitmap.UnlockBits(sourceBitmapData);

            // Copy serchingBitmap to byte array
            var serchingBitmapData =
                serchingBitmap.LockBits(new Rectangle(0, 0, serchingBitmap.Width, serchingBitmap.Height),
                    ImageLockMode.ReadOnly, serchingBitmap.PixelFormat);
            var serchingBitmapBytesLength = serchingBitmapData.Stride * serchingBitmap.Height;
            var serchingBytes = new byte[serchingBitmapBytesLength];
            Marshal.Copy(serchingBitmapData.Scan0, serchingBytes, 0, serchingBitmapBytesLength);
            serchingBitmap.UnlockBits(serchingBitmapData);

            var pointsList = new List<Point>();

            // Serching entries
            // minimazing serching zone
            // sourceBitmap.Height - serchingBitmap.Height + 1
            for (var mainY = 0; mainY < sourceBitmap.Height - serchingBitmap.Height + 1; mainY++)
            {
                var sourceY = mainY * sourceBitmapData.Stride;

                for (var mainX = 0; mainX < sourceBitmap.Width - serchingBitmap.Width + 1; mainX++)
                {// mainY & mainX - pixel coordinates of sourceBitmap
                 // sourceY + sourceX = pointer in array sourceBitmap bytes
                    var sourceX = mainX * pixelFormatSize;

                    var isEqual = true;
                    for (var c = 0; c < pixelFormatSize; c++)
                    {// through the bytes in pixel
                        if (sourceBytes[sourceX + sourceY + c] == serchingBytes[c])
                            continue;
                        isEqual = false;
                        break;
                    }

                    if (!isEqual) continue;

                    var isStop = false;

                    // find fist equalation and now we go deeper) 
                    for (var secY = 0; secY < serchingBitmap.Height; secY++)
                    {
                        var serchY = secY * serchingBitmapData.Stride;

                        var sourceSecY = (mainY + secY) * sourceBitmapData.Stride;

                        for (var secX = 0; secX < serchingBitmap.Width; secX++)
                        {// secX & secY - coordinates of serchingBitmap
                         // serchX + serchY = pointer in array serchingBitmap bytes

                            var serchX = secX * pixelFormatSize;

                            var sourceSecX = (mainX + secX) * pixelFormatSize;

                            for (var c = 0; c < pixelFormatSize; c++)
                            {// through the bytes in pixel
                                if (sourceBytes[sourceSecX + sourceSecY + c] == serchingBytes[serchX + serchY + c]) continue;

                                // not equal - abort iteration
                                isStop = true;
                                break;
                            }

                            if (isStop) break;
                        }

                        if (isStop) break;
                    }

                    if (!isStop)
                    {// serching bitmap is founded!!
                        pointsList.Add(new Point(mainX, mainY));
                    }
                }
            }

            return pointsList;
        }
    }
}
