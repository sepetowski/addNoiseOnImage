using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Threading.Tasks;


namespace Uniform
{
    public class UniformNoise
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
            double[] uniform = new double[256];
            Random rnd = new Random();

            double a = 32;
            double b = 64;
            double sum = 0;

            for (int i = 0; i < 256; i++)
            {
                double step = (double)i;
                if (step >= a && step <= b)
                {
                    uniform[i] = (double)(1 / (b - a));
                }
                else
                {
                    uniform[i] = 0;
                }
                sum += uniform[i];
            }

            for (int i = 0; i < 256; i++)
            {
                uniform[i] /= sum;
                uniform[i] *= bytes;
                uniform[i] = (int)Math.Floor(uniform[i]);
            }

            int count = 0;
            for (int i = 0; i < 256; i++)
            {
                for (int j = 0; j < (int)uniform[i]; j++)
                {
                    noise[j + count] = (byte)i;
                }
                count += (int)uniform[i];
            }

            for (int i = 0; i < bytes - count; i++)
            {
                noise[count + i] = 0;
            }
            for (int i = noise.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i + 1);
                var temp = noise[i];
                noise[i] = noise[j];
                noise[j] = temp;
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
