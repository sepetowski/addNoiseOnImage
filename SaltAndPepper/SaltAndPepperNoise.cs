using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading;


namespace SaltAndPepper
{
    public class SaltAndPepperNoise
    {
        private Bitmap noiseImage = null;


        public Bitmap getImage(Bitmap image, int threadsNumber)
        {
            generateNoise(image, threadsNumber);
            return noiseImage;
        }

        private void generateNoise(Bitmap image, int threadsNumber)
        {
            int w = image.Width;
            int h = image.Height;

            System.Drawing.Imaging.BitmapData imageData = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = imageData.Stride * imageData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(imageData.Scan0, buffer, 0, bytes);
            image.UnlockBits(imageData);


            int noise_chance = 10;

            int threadCount = threadsNumber;
            Thread[] threads = new Thread[threadCount];

            for (int t = 0; t < threadCount; t++)
            {
                int start = t * (bytes / threadCount);
                int end = (t == threadCount - 1) ? bytes : start + (bytes / threadCount);

                threads[t] = new Thread(() =>
                {
                    Random rnd = new Random();
                    int max = (int)(1000 / noise_chance);

                    for (int i = start; i < end; i += 3)
                    {
                        int tmp = rnd.Next(max + 1);
                        for (int j = 0; j < 3; j++)
                        {
                            if (tmp == 0 || tmp == max)
                            {
                                int sorp = tmp / max;
                                result[i + j] = (byte)(sorp * 255);
                            }
                            else
                            {
                                result[i + j] = buffer[i + j];
                            }
                        }
                    }
                });
                threads[t].Start();
            }

            foreach (var thread in threads)
            {
                thread.Join();
            }


            Bitmap resultImage = new Bitmap(w, h);
            BitmapData resultData = resultImage.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);

          noiseImage= resultImage;
        }

    }
}
