using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConverorImageToHexForOled
{
    public partial class Form1 : Form
    {
        //int IndexZoom = 1;
        int MyWidth = 240;         //ширина картинки по умолчанию
        int MyHeight = 128;        //высота картинки по умолчанию
        String StringOutKod = "";
        int ImagBlackLevel = 200;      // порог уровня черного для конвертации
        Boolean CkanPixlInvrs = false;  // сканер со старшего бита =false(прямой), сканер с младшего  бита =true(обратный),
        Boolean NegativImag = true;    // изображение на выходе негатив=false, позитив= trye
        int OutKod = 16;               // бинарный код=2, десятичный=10, шеснадцатиричный=16
        int NewStrKod = 0;
        int StrTabuliacia = 25;        // перенос строки через 24 символа 8 битных
        String StrTipCoda = "0x";      // "0x"=16ричный,  ""=10тичный , "B"= бинрный
        public Form1()
        {
            InitializeComponent();
            label1.Text = "240 x128";  // присваиваем при старте
            label2.Text = "16-й";
            label3.Text = "прямой";
            label4.Text = "позитив";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null) // если изображение в pictureBox1 имеется
            {
                // создаём Bitmap из изображения, находящегося в pictureBox1
                Bitmap input1 = new Bitmap(pictureBox1.Image);
                if (input1.Width >= MyWidth && input1.Height >= MyHeight)   // если картинка подходит по размрам
                {
                    ConvertImageText();
                    //  Bintext2 = Bintext2.Remove(Bintext2.Length - 1); // убираем последнию запятую
                    textBox1.Text = "{ " + StringOutKod + " };";
                }
                else
                {
                    MessageBox.Show("Изображение меньше требуемого", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                  //  labelTest.Text = "МЕЛКО";
                  //  labelWidth1.Text = input1.Width.ToString();
                  //  labelHeight1.Text = input1.Height.ToString();
                }
            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // диалог для выбора файла
            OpenFileDialog ofd = new OpenFileDialog();
            // фильтр форматов файлов
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            // если в диалоге была нажата кнопка ОК
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // загружаем изображение
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch // в случае ошибки выводим MessageBox
                {
                    MessageBox.Show("Невозможно открыть выбранный файл", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null) // если изображение в pictureBox2 имеется
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Сохранить картинку как...";
                sfd.OverwritePrompt = true; // показывать ли "Перезаписать файл" если пользователь указывает имя файла, который уже существует
                sfd.CheckPathExists = true; // отображает ли диалоговое окно предупреждение, если пользователь указывает путь, который не существует
                // фильтр форматов файлов
                sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true; // отображается ли кнопка Справка в диалоговом окне
                // если в диалоге была нажата кнопка ОК
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // сохраняем изображение
                        pictureBox2.Image.Save(sfd.FileName);
                    }
                    catch // в случае ошибки выводим MessageBox
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void copyТекстToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void z128x32ToolStripMenuItem_Click(object sender, EventArgs e)   { SizeImage(128, 32); }
        private void z128x64ToolStripMenuItem_Click(object sender, EventArgs e)   { SizeImage(128, 64); }
        private void z240x64ToolStripMenuItem1_Click(object sender, EventArgs e)  { SizeImage(240, 64); }
        private void z240x128ToolStripMenuItem_Click(object sender, EventArgs e) 
        {
           // z240x128ToolStripMenuItem_Click.CheckOnClick = true;
            SizeImage(240, 128);
         }
        private void zoomXyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SizeImage(128, 64);//----------------------------------------------
        }

        private void H16ToolStripMenuItem_Click(object sender, EventArgs e)      
        {
            OutKod = 16; label2.Text = "16-й"; StrTipCoda = "0x";
        }
        private void H10ToolStripMenuItem_Click(object sender, EventArgs e)       
        {
            OutKod = 10; label2.Text = "10-й"; StrTipCoda = "";
        }
        private void H2ToolStripMenuItem_Click(object sender, EventArgs e)       
        { 
            OutKod = 2; label2.Text = "2-й";  StrTipCoda = "B";
        }
        private void ckan1ToolStripMenuItem_Click(object sender, EventArgs e)     
        { 
            CkanPixlInvrs = true; label3.Text = "прямой";
        }
        private void ckan2ToolStripMenuItem_Click(object sender, EventArgs e)     
        {
            CkanPixlInvrs = false; label3.Text = "обратный";
        }
        private void positiveToolStripMenuItem_Click(object sender, EventArgs e)  
        {
            NegativImag = true; label4.Text = "позитив";
        }
        private void negativeToolStripMenuItem_Click(object sender, EventArgs e)  
        { 
            NegativImag = false; label4.Text = "негатив";
        }
        private void YouTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void linkToolStripMenuItem_Click(object sender, EventArgs e)
        {
       // https://www.drive2.ru/users/borzov161/#blog
        }

        private void readToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ConvertImageText()
        {
            int[] MyArray = new int[8];
            short Pixel_8bit = 0, val = 0;
            Bitmap input = new Bitmap(pictureBox1.Image);
            Bitmap output = new Bitmap(input.Width, input.Height);
            String StrBintext1 = "";  // чистим
            StringOutKod = "";         // чистим 
            output = new Bitmap(MyWidth, MyHeight);
            NewStrKod = 0;
            // перебираем в циклах все пиксели исходного изображения
            for (int j = 0; j < MyHeight; j++)
                for (int i = 0; i < MyWidth; i++)
                {
                    // получаем (i, j) пиксель
                    UInt32 pixel = (UInt32)(input.GetPixel(i, j).ToArgb());
                    // получаем компоненты цветов пикселя
                    float R = (float)((pixel & 0x00FF0000) >> 16); // красный
                    float G = (float)((pixel & 0x0000FF00) >> 8);  // зеленый
                    float B = (float)(pixel & 0x000000FF); // синий
                                                           // делаем цвет черно-белым (оттенки серого) - находим среднее арифметическое
                    R = (R + G + B) / 3.0f;
                    // собираем новый пиксель по частям (по каналам)
                    UInt32 newPixel = 0xFF000000 | ((UInt32)R << 16) | ((UInt32)G << 8) | ((UInt32)B);
                    // если уровень черного выше заданного уровня
                    if (R > ImagBlackLevel)
                    {
                        if (NegativImag)
                        {
                            newPixel = 0xFFFFFFFF; val = 0;
                        }
                        else
                        {
                            newPixel = 0xFF000000; val = 1;
                        }
                    }
                    else
                    {
                        if (NegativImag)
                        {
                            newPixel = 0xFF000000; val = 1;
                        }
                        else
                        {
                            newPixel = 0xFFFFFFFF; val = 0;
                        }
                    }
                    if (Pixel_8bit <= 7)
                    {
                        MyArray[Pixel_8bit] = val;
                        StrBintext1 = StrBintext1 + Convert.ToString(val);
                        if (Pixel_8bit == 7)
                        { 
                            int xx = 0;
                           if( CkanPixlInvrs == false)
                           {
                                for (int z = 1, m = 0; m <= 7; m++)
                                {
                                    xx = xx + MyArray[m] * z;
                                    z = z * 2;
                                }
                           }
                           else
                            {
                                for (int z = 1, m = 7; m >= 0; m--)
                                {
                                    xx = xx + MyArray[m] * z;
                                    z = z * 2;
                                }
                            }
                            StrBintext1 = Convert.ToString(xx, OutKod);
                            NewStrKod++;
                            //  int strLen = StringOutKod.Length;
                            //  if (strLen % StrTabuliacia <= 4)
                            if ( NewStrKod % StrTabuliacia == 0 )
                            {
                                StringOutKod = StringOutKod + StrTipCoda + StrBintext1 + ", " + "\r\n"; // перенос строки добавляем
                            }
                           else StringOutKod = StringOutKod + StrTipCoda + StrBintext1 + ", ";

                            Pixel_8bit = 0; StrBintext1 = "";   //чистим
                        }
                        else Pixel_8bit++;
                    }
                    // добавляем его в Bitmap нового изображения
                    output.SetPixel(i, j, Color.FromArgb((int)newPixel));
                }
            // выводим черно-белый Bitmap в pictureBox2
            pictureBox2.Image = output; 
        }
        private void SizeImage(int x, int y)
        {
            MyWidth = x; MyHeight = y;
            label1.Text = Convert.ToString(x)+" x"+ Convert.ToString(y); // выводим размер на экран под меню
            pictureBox2.Image = null; textBox1.Text = "";                // чистим 2 экран и стираем старый текст, при смене размера картинки
            pictureBox1.Width = x; pictureBox1.Height = y;
            pictureBox2.Width = x; pictureBox2.Height = y;
        }
       
    }
}
