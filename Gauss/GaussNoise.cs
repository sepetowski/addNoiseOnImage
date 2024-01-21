using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Gauss
{
    public class GaussNoise
    {
        private Bitmap noiseImage=null;


        public Bitmap getImage(Bitmap image, int threadsNumber)
        {
           generateNoise(image, threadsNumber);
            return noiseImage;
        }

        private void generateNoise(Bitmap image, int threadsNumber)
        {
            int w = image.Width;
            int h = image.Height;

            BitmapData imageData = image.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.ReadOnly,
                PixelFormat.Format24bppRgb);
            int bytes = imageData.Stride * imageData.Height;
            byte[] buffer = new byte[bytes];
            byte[] result = new byte[bytes];
            Marshal.Copy(imageData.Scan0, buffer, 0, bytes);
            image.UnlockBits(imageData);

            byte[] noise = new byte[bytes];
            double[] gaussian = new double[256];

            int std = 20;
            Random rnd = new Random();
            double sum = 0;

            for (int i = 0; i < 256; i++)
            {
                gaussian[i] = (double)((1 / (Math.Sqrt(2 * Math.PI) * std)) * Math.Exp(-Math.Pow(i, 2) / (2 * Math.Pow(std, 2))));
                sum += gaussian[i];
            }

            for (int i = 0; i < 256; i++)
            {
                gaussian[i] /= sum;
                gaussian[i] *= bytes;
                gaussian[i] = (int)Math.Floor(gaussian[i]);
            }

            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)gaussian[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)gaussian[i];
            }

            for (int i = 0; i < bytes - count; i++)
            {
                noise[count + i] = 0;
            }

            for (int i = noise.Length - 1; i > 0; i--)
            {
                int randomIndex = rnd.Next(i + 1);
                byte temp = noise[i];
                noise[i] = noise[randomIndex];
                noise[randomIndex] = temp;
            }

          
            Parallel.For(0, threadsNumber, t =>
            {
                int segmentSize = bytes / threadsNumber;
                int start = t * segmentSize;
                int end = (t == threadsNumber - 1) ? bytes : start + segmentSize;
                for (int i = start; i < end; i++)
                {
                    result[i] = (byte)(buffer[i] + noise[i]);
                }
            });

            Bitmap resultImage = new Bitmap(w, h);
            BitmapData resultData = resultImage.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);

            noiseImage = resultImage;
        }
    }
}
