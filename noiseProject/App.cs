using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Diagnostics;
//biblioteki klas c#
using Gauss;
using Uniform;
using SaltAndPepper;
namespace noiseProject
{
    public partial class App : Form
    {


        [DllImport(@"C:\Users\Bushmeen\Desktop\nosieV3\x64\Debug\asmLibrary.dll")]
        static extern void addNoise(byte[] result, byte[] buffer, byte[] noise, int bytes);

        [DllImport(@"C:\Users\Bushmeen\Desktop\nosieV3\x64\Debug\asmLibrary.dll")]
        static extern void calcGaussian(double[] gaussian, int std);

        private int choosenAlgortihm = 0;
        private Stopwatch stopwatch = new Stopwatch();
        private short invokeNoiseGeneratorAlgorithmCounter = 0;
        private double algorithmAvgTime = 0;
        private double totalTime = 0;
        private int threadsNumber = 1;
        private GaussNoise gaussNoiseImage = new GaussNoise();
        private UniformNoise uniformNoiseImage = new UniformNoise();
        private SaltAndPepperNoise saltAndPepperImage = new SaltAndPepperNoise();

        public App()
        {
            InitializeComponent();
            customDesign();
        }

        private void customDesign()
        {
            hideSumMenu();
            previewImageTitle.Visible = false;
            generateImageTitle.Visible = false;
            genearteNosieOnImageBtn.Visible = false;
            genearteNosieOnImageBtn.Enabled = false;
            addImageText.Visible = false;
            timeLabelDesc.Visible = false;
            avgTimeLabel.Visible = false;
            operationTime.Visible = false;
            avgOperationTime.Visible = false;
            downloadGeneartedImg.Visible = false;
            downloadGeneartedImg.Enabled = false;
            timesPanel.Visible = false;



        }

        private void hideSumMenu()
        {
            alogithmsSubmenu.Visible = false;
        }

        private void App_Load(object sender, EventArgs e)
        {
        }

        private void chooseAlgorithm_Click(object sender, EventArgs e)
        {
            if (alogithmsSubmenu.Visible == true)
                alogithmsSubmenu.Visible = false;
            else alogithmsSubmenu.Visible = true;
        }

        private void algorithmSelection_Click(object sender, EventArgs e)
        {
            resetTimeInfo();

            if (welcomingText.Visible == true)
                welcomingText.Visible = false;


            Button clickedButton = (Button)sender;
            toogleAlgorithmSubmenu.Text = clickedButton.Text;
            genearteNosieOnImageBtn.Text = "Generate " + "(" + clickedButton.Text + ")";
            genearteNosieOnImageBtn.Enabled = true;
            hideSumMenu();



            switch (clickedButton.Name)
            {
                case "uniformNoiseOptionBtn":
                    choosenAlgortihm = 1;
                    break;

                case "noiseSaltAndPepperOptionBtn":
                    choosenAlgortihm = 2;
                    break;

                case "gaussianNoiseOptionBtn":
                    choosenAlgortihm = 3;
                    break;

                default:
                    choosenAlgortihm = 0;
                    break;



            }

            if (genearteNosieOnImageBtn.Visible == false && welcomingText.Visible == false)
            {
                addImageText.Visible = true;
            }

        }

        private void importImageBtn_Click(object sender, EventArgs e)
        {

            imageFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";

            if (imageFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {

                    selectedImage.Image = new System.Drawing.Bitmap(imageFileDialog.FileName);
                    previewImageTitle.Visible = true;
                    genearteNosieOnImageBtn.Visible = true;
                    generateImageTitle.Visible = false;
                    addImageText.Visible = false;
                    generatedImage.Image = null;
                    downloadGeneartedImg.Visible = false;
                    downloadGeneartedImg.Enabled = false;
                    resetTimeInfo();

                    if (welcomingText.Visible == true)
                        welcomingText.Visible = false;

                }
                catch (Exception)
                {
                    MessageBox.Show("Please select an image", "Wrong file", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void generateAlgorithmBtn_Click(object sender, EventArgs e)
        {
            if (choosenAlgortihm == 0)
                MessageBox.Show("Please select an algortihm", "no algortihm selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                generateAlgorithm();
        }

        private void generateAlgorithm()
        {
            generateImageTitle.Visible = true;
            stopwatch.Reset();
            invokeNoiseGeneratorAlgorithmCounter++;



            if (useAsm.Checked == false)
            {


                switch (choosenAlgortihm)
                {
                    case 1:
                        {

                            stopwatch.Start();
                            generatedImage.Image = new System.Drawing.Bitmap(uniformNoiseImage.getImage((Bitmap)selectedImage.Image, threadsNumber));
                            stopwatch.Stop();


                            break;
                        }

                    case 2:
                        {

                            stopwatch.Start();
                            generatedImage.Image = new System.Drawing.Bitmap(saltAndPepperImage.getImage((Bitmap)selectedImage.Image, threadsNumber));
                            stopwatch.Stop();
                            break;
                        }

                    case 3:
                        {



                            stopwatch.Start();
                            generatedImage.Image = new System.Drawing.Bitmap(gaussNoiseImage.getImage((Bitmap)selectedImage.Image, threadsNumber));
                            stopwatch.Stop();
                            break;
                        }
                }
            }
            else
            {
                switch (choosenAlgortihm)
                {
                    case 1:
                        {

                            stopwatch.Start();
                            generatedImage.Image = new System.Drawing.Bitmap(uniformNoiseAsm((Bitmap)selectedImage.Image));
                            stopwatch.Stop();


                            break;
                        }

                    case 2:
                        {

                            stopwatch.Start();
                            generatedImage.Image = new System.Drawing.Bitmap(saltAndPepperImage.getImage((Bitmap)selectedImage.Image, threadsNumber));
                            stopwatch.Stop();
                            break;
                        }

                    case 3:
                        {

                            stopwatch.Start();
                            generatedImage.Image = new System.Drawing.Bitmap(gaussianNoiseASM((Bitmap)selectedImage.Image));
                            stopwatch.Stop();
                            break;
                        }
                }
            }

            showTimeInfo();
            downloadGeneartedImg.Visible = true;
            downloadGeneartedImg.Enabled = true;


        }

        private Bitmap uniformNoiseAsm(Bitmap image)
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
            double a = 32;
            double b = 64;
            Random rnd = new Random();
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

            noise = noise.OrderBy(x => rnd.Next()).ToArray();



            addNoise(result, buffer, noise, bytes);


            Bitmap resultImage = new Bitmap(w, h);
            BitmapData resultData = resultImage.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }

        private Bitmap gaussianNoiseASM(Bitmap image)
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

            noise = noise.OrderBy(x => rnd.Next()).ToArray();

            addNoise(result, buffer, noise, bytes);

            Bitmap resultImage = new Bitmap(w, h);
            BitmapData resultData = resultImage.LockBits(
                new Rectangle(0, 0, w, h),
                ImageLockMode.WriteOnly,
                PixelFormat.Format24bppRgb);
            Marshal.Copy(result, 0, resultData.Scan0, bytes);
            resultImage.UnlockBits(resultData);
            return resultImage;
        }

        private void resetTimeInfo()
        {
            totalTime = 0;
            invokeNoiseGeneratorAlgorithmCounter = 0;
        }

        private void showTimeInfo()
        {

            double elapsedMilliseconds = Math.Floor(stopwatch.Elapsed.TotalMilliseconds);
            totalTime += elapsedMilliseconds;
            algorithmAvgTime = Math.Floor(totalTime / invokeNoiseGeneratorAlgorithmCounter);


            timesPanel.Visible = true;
            timeLabelDesc.Visible = true;
            avgTimeLabel.Visible = true;
            operationTime.Visible = true;
            avgOperationTime.Visible = true;

            operationTime.Text = elapsedMilliseconds.ToString() + "ms";
            avgTimeLabel.Text = "Average time of " + invokeNoiseGeneratorAlgorithmCounter + "\n" + "operations";

            avgOperationTime.Text = algorithmAvgTime.ToString() + "ms";
        }

        private void downloadGeneratedBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Pliki obrazów (*.png)|*.png|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Save image";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    Bitmap bmp = new Bitmap(generatedImage.Image);
                    bmp.Save(saveFileDialog.FileName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong", "Saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void threadTrackBar_Scroll(object sender, EventArgs e)
        {
            int exponent = threadTrackBar.Value;
            threadsNumber = (int)Math.Pow(2, exponent);


            threadLabel.Text = "Thread: " + threadsNumber.ToString();
            resetTimeInfo();

        }

        private void useAsm_CheckedChanged(object sender, EventArgs e)
        {
            resetTimeInfo();
        }
    }

}