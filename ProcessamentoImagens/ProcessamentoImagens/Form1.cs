/* Colegio Técnico Antônio Teixeira Fernandes (Univap)
 * Curso Técnico em Informática - Data de Entrega: 01 / 09 / 2024
 * Autores do Projeto: Evelin Visoto Carneiro Fernandes
 *
 * Turma: 3F
 * Atividade Proposta em aula
 * Observação: < Projeto do terceiro bimestre >
 * ******************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProcessamentoImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void processButton_Click_1(object sender, EventArgs e)
        {
            Bitmap imgA = new Bitmap(@"C:\Users\inais\Pictures\projetoICG\Im.jpg");
            Bitmap imgB = new Bitmap(@"C:\Users\inais\Pictures\projetoICG\Balao.jpg");
            Bitmap imgC = new Bitmap(@"C:\Users\inais\Pictures\projetoICG\Aviao2.jpg");
            Bitmap imgD = new Bitmap(@"C:\Users\inais\Pictures\projetoICG\homem.jpg");

            imgB = RemoverFundo(imgB, Color.FromArgb(83, 144, 203));
            imgC = RemoverFundo(imgC, Color.FromArgb(64, 146, 214));
            imgD = RemoverFundo(imgD, Color.FromArgb(166, 144, 107));

            Bitmap imgE = CombinarImagens(imgA, imgB, imgC, imgD);

            Bitmap imgBrilho = AumentarBrilho(new Bitmap(imgE), 85);
            Bitmap imgGray = ConverterParaGrayLevel(new Bitmap(imgE));
            Bitmap imgBinaria = ConverterParaBinario(imgGray, 126);
            Bitmap imgRotacionada = RotacionarImagem(new Bitmap(imgE), 90);

            imgE.Save(@"C:\Users\inais\Pictures\imgE_Combinada.jpg");
            imgBrilho.Save(@"C:\Users\inais\Pictures\imgE_Brilho.jpg");
            imgGray.Save(@"C:\Users\inais\Pictures\imgE_Gray.jpg");
            imgBinaria.Save(@"C:\Users\inais\Pictures\imgE_Binaria.jpg");
            imgRotacionada.Save(@"C:\Users\inais\Pictures\imgE_Rotacionada.jpg");

            ExibirImagens(imgE, imgBrilho, imgGray, imgBinaria, imgRotacionada);
        }

        private Bitmap RemoverFundo(Bitmap imagem, Color corFundo)
        {
            Bitmap imagemSemFundo = new Bitmap(imagem.Width, imagem.Height);

            for (int i = 0; i < imagem.Width; i++)
            {
                for (int j = 0; j < imagem.Height; j++)
                {
                    Color pixel = imagem.GetPixel(i, j);

                    if ((pixel.R >= corFundo.R - 20 && pixel.R <= corFundo.R + 20) &&
                        (pixel.G >= corFundo.G - 20 && pixel.G <= corFundo.G + 20) &&
                        (pixel.B >= corFundo.B - 20 && pixel.B <= corFundo.B + 20))
                    {
                        imagemSemFundo.SetPixel(i, j, Color.FromArgb(0, 0, 0, 0));
                    }
                    else
                    {
                        imagemSemFundo.SetPixel(i, j, pixel);
                    }
                }
            }

            return imagemSemFundo;
        }


        private Bitmap CombinarImagens(Bitmap imagemBase, Bitmap imagemSB, Bitmap imagemSC, Bitmap imagemSD)
        {
            Bitmap imagemFinal = new Bitmap(imagemBase);

            imagemFinal = InserirImagem(imagemFinal, imagemSB, 500, 100);
            imagemFinal = InserirImagem(imagemFinal, imagemSC, 100, 60);
            imagemFinal = InserirImagem(imagemFinal, imagemSD, 300, 500);

            return imagemFinal;
        }

        private Bitmap InserirImagem(Bitmap imagemBase, Bitmap imagemSobreposta, int x, int y)
        {
            Bitmap imagemE = new Bitmap(imagemBase);

            for (int i = 0; i < imagemSobreposta.Width; i++)
            {
                for (int j = 0; j < imagemSobreposta.Height; j++)
                {
                    Color pixel = imagemSobreposta.GetPixel(i, j);
                    if (pixel.A > 0)
                    {
                        imagemE.SetPixel(i + x, j + y, pixel);
                    }
                }
            }
            return imagemE;
        }

        private Bitmap AumentarBrilho(Bitmap img, int brilho)
        {
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int r = Math.Min(Math.Max(pixel.R + brilho, 0), 255);
                    int g = Math.Min(Math.Max(pixel.G + brilho, 0), 255);
                    int b = Math.Min(Math.Max(pixel.B + brilho, 0), 255);
                    img.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }
            return img;
        }

        private Bitmap ConverterParaGrayLevel(Bitmap img)
        {
            Bitmap grayImg = new Bitmap(img.Width, img.Height);
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int gray = (int)(pixel.R * 0.30 + pixel.G * 0.59 + pixel.B * 0.11);
                    grayImg.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return grayImg;
        }

        private Bitmap ConverterParaBinario(Bitmap img, int threshold)
        {
            Bitmap binariaImg = new Bitmap(img.Width, img.Height);
            for (int y = 0; y < img.Height; y++)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    Color pixel = img.GetPixel(x, y);
                    int gray = pixel.R;
                    int bin = gray <= threshold ? 0 : 255;
                    binariaImg.SetPixel(x, y, Color.FromArgb(bin, bin, bin));
                }
            }
            return binariaImg;
        }

        private Bitmap RotacionarImagem(Bitmap img, float angulo)
        {
            double radian = angulo * Math.PI / 180;

            int novaLargura = (int)(img.Width * Math.Abs(Math.Cos(radian)) + img.Height * Math.Abs(Math.Sin(radian)));
            int novaAltura = (int)(img.Width * Math.Abs(Math.Sin(radian)) + img.Height * Math.Abs(Math.Cos(radian)));

            Bitmap rotatedImg = new Bitmap(novaLargura, novaAltura);

            int centroXOriginal = img.Width / 2;
            int centroYOriginal = img.Height / 2;
            int centroXRotacionada = novaLargura / 2;
            int centroYRotacionada = novaAltura / 2;

            for (int x = 0; x < novaLargura; x++)
            {
                for (int y = 0; y < novaAltura; y++)
                {
                    int xOriginal = (int)((x - centroXRotacionada) * Math.Cos(-radian) - (y - centroYRotacionada) * Math.Sin(-radian) + centroXOriginal);
                    int yOriginal = (int)((x - centroXRotacionada) * Math.Sin(-radian) + (y - centroYRotacionada) * Math.Cos(-radian) + centroYOriginal);

                    if (xOriginal >= 0 && xOriginal < img.Width && yOriginal >= 0 && yOriginal < img.Height)
                    {
                        Color pixel = img.GetPixel(xOriginal, yOriginal);
                        rotatedImg.SetPixel(x, y, pixel);
                    }
                    else
                    {
                        rotatedImg.SetPixel(x, y, Color.FromArgb(0, 0, 0, 0));
                    }
                }
            }

            return rotatedImg;
        }



        private void ExibirImagens(Bitmap imgOriginal, Bitmap imgBrilho, Bitmap imgGray, Bitmap imgBinaria, Bitmap imgRotacionada)
        {
            pbOriginal.Image = imgOriginal;
            pbOriginal.SizeMode = PictureBoxSizeMode.StretchImage;

            pbBrilho.Image = imgBrilho;
            pbBrilho.SizeMode = PictureBoxSizeMode.StretchImage;

            pbGray.Image = imgGray;
            pbGray.SizeMode = PictureBoxSizeMode.StretchImage;

            pbBinaria.Image = imgBinaria;
            pbBinaria.SizeMode = PictureBoxSizeMode.StretchImage;

            pbRotacionada.Image = imgRotacionada;
            pbRotacionada.SizeMode = PictureBoxSizeMode.StretchImage;
        }

       
    }
}