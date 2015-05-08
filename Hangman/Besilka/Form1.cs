using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Besilka
{
    public partial class Form1 : Form
    {
        string tekovenZbor { get; set; }
        Level.IzbravMoznosti Izbra = Level.IzbravMoznosti.NISTO;
        Level.NivoTezina nivo = Level.NivoTezina.NISTO;
        
        int besilka;
        Graphics g { get; set; }
        public Form1()
        {
            besilka = 0;
            InitializeComponent();
        }

       

        private void button33_Click(object sender, EventArgs e)
        {
            Level l = new Level();

            l.ShowDialog();
            Izbra = l.Izbrav;
            nivo = l.Nivo; 

            PolniSiteMozniListi();
        }

        private void lbWord_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           g = panel1.CreateGraphics();
           Brush p = new SolidBrush(Color.White);
           
           g.FillRectangle(p, 0, 0, panel1.Width,  panel1.Height);
          // g.Clear(Color.White);


           PolniSiteMozniListi();
        }
        
        private void PolniSiteMozniListi()
        {
            makeEnabled();

            besilka = 0;
            List<string> words = new List<string>();

            //******** NAUKA *********************
            if (Izbra == Level.IzbravMoznosti.NAUKA)
            {
                if (nivo == Level.NivoTezina.LESNO)
                {
                    //ovde se lesni
                    words.Add("атом");
                    words.Add("магнет");
                    words.Add("река");
                    words.Add("призма");
                    words.Add("конус");
                    words.Add("вода");
                    words.Add("водород");
                    words.Add("програма");
                    words.Add("топка");
                    words.Add("објект");
                    words.Add("класа");
                    words.Add("флуид");
                }
                else if (nivo == Level.NivoTezina.SREDNO)
                {
                    //ovde se sredni
                    words.Add("радиологија");
                    words.Add("метафизика");
                    words.Add("генетика");
                    words.Add("геофизика");
                    words.Add("геологија");
                    words.Add("стакларија");
                    words.Add("гравитација");
                    words.Add("микроскоп");
                    words.Add("метеоролог");
                    words.Add("Аристотел");
                    words.Add("девијација");
                    words.Add("мобилен");
                    words.Add("математика");
                    words.Add("телескоп");
                    words.Add("термометар");
                    words.Add("биологија");
                    words.Add("програмирање");
                }
                else //ovde tesko
                {
                    words.Add("електрична енергија");
                    words.Add("ентомологија");
                    words.Add("Чарлс Дарвин");
                    words.Add("микробиологија");
                    words.Add("пресметување на облак");
                    words.Add("раздели и владеј");
                    words.Add("рекурентна равенка");
                    words.Add("тригонометрија");
                    words.Add("синхроно секвенцијално коло");
                    words.Add("комбинаторика");
                    words.Add("бинарно дрво");
                }
               
                
            }
            
            //******** SPORT *********************
            if (Izbra == Level.IzbravMoznosti.SPORT)
            {

                if (nivo == Level.NivoTezina.LESNO)
                {
                    words.Add("голф");
                    words.Add("челзи");
                    words.Add("хокеј");
                    words.Add("пирло");
                    words.Add("топка");
                    words.Add("ракет");
                    words.Add("играч");
                    words.Add("победа");
                 
                }
                else if (nivo == Level.NivoTezina.SREDNO)
                {
                    words.Add("фудбал");
                    words.Add("кошаркa");
                    words.Add("карате");
                    words.Add("аикидо");
                    words.Add("роналдо");
                    words.Add("ракомет");
                    words.Add("одбојка");
                    words.Add("стадион");
                    words.Add("голман");
                    words.Add("арсенал");
                    words.Add("торонто");
                    words.Add("игралиште");
                    words.Add("барселона");
                   
                }
                else
                {
                    words.Add("фудбалски терен");
                    words.Add("ристо ангелов");
                    words.Add("кире лазаров");
                    words.Add("реал мадрид");
                    words.Add("дидиер дрогба");
                    words.Add("најдобар тим");
                    words.Add("ана ивановиќ");

                }
             
            }

            //******** FILMOVI *********************
            if (Izbra == Level.IzbravMoznosti.FILMOVI)
            {
                if(nivo == Level.NivoTezina.LESNO)
                {
                    words.Add("флинг");
                    words.Add("арго");
                    words.Add("акира");
                    words.Add("хобит");
                    words.Add("платно");
                    words.Add("кино");
                    words.Add("глумец");
                    words.Add("комедија");
                    words.Add("трагедија");
                    words.Add("хорор");
                }
                else if(nivo == Level.NivoTezina.SREDNO)
                {
                    words.Add("соседи");
                    words.Add("бетмен");
                    words.Add("супермен");
                    words.Add("триста");
                    words.Add("блокада");
                    words.Add("убијци");
                    words.Add("тарзан");
                    words.Add("пепелашка");
                    words.Add("титаник");

                }
                else
                {
                    words.Add("колумбиана");
                    words.Add("игра на имитација");
                    words.Add("ѕвездени патеки");
                    words.Add("трето полувреме");
                    words.Add("руски рулет");
                    words.Add("лош дедо мраз");
                    words.Add("господар на прстените");
                    words.Add("лош дедо мраз");
                    words.Add("ана каренина");
                    words.Add("господар на прстените");
                }
               
                
            }
            if (Izbra == Level.IzbravMoznosti.NISTO)
            {
                words.Add("генерал");
                words.Add("индонезија");
                words.Add("магнет");
                words.Add("мотика");
                words.Add("леб");
                words.Add("ламба");
                words.Add("микроорганизам");
                words.Add("индукција");
                words.Add("велосипед");
                words.Add("планина");
                words.Add("концерт");
                words.Add("боја");
                words.Add("супермен");
                words.Add("триста");
                words.Add("блокада");
                words.Add("ентомологија");
                words.Add("Чарлс Дарвин");
            }
      
            Random r = new Random();
            int a = r.Next(0, words.Count); 
            int length = words[a].Length;
            tekovenZbor = words[a];
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (words[a].Contains(" ")&&(words[a].IndexOf(" ")==i))
                {
                    sb.Append(" ");
                }
                else sb.Append("-");
            }

            
            lbWord.Text = sb.ToString();
            zbor.Text = words[a];
           
           
        }

        private void makeEnabled()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;

            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;

            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;

            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;

            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;

            button26.Enabled = true;
            button27.Enabled = true;
            button28.Enabled = true;
            button29.Enabled = true;
            button30.Enabled = true;

            button31.Enabled = true;
        }

        private void DrawBodyPart(int broj)
        {
            
            Pen p = new Pen(Color.Blue, 2);

            if (broj == 1)
            {
                g.DrawEllipse(p, 40, 50, 40, 40);
            }
            else if (broj == 2)
            {

                g.DrawLine(p, new Point(60, 90), new Point(60, 170));
            }
            else if (broj == 3)
            {
                g.DrawLine(p, new Point(60, 100), new Point(30, 85));

            }
            else if (broj == 4)
            {
                g.DrawLine(p, new Point(60, 100), new Point(90, 85));
            }
            else if (broj == 5)
            {
                g.DrawLine(p, new Point(60, 170), new Point(30, 190));
            }
            else if (broj == 6)
            {
                g.DrawLine(p, new Point(60, 170), new Point(90, 190));

                
                MessageBox.Show("Не го погодивте зборот. Обидете се повторно");
               
                g.Clear(Control.DefaultBackColor);
                PolniSiteMozniListi();
            }
        }

        private void proveriBukva(string bukva)
        {
           
            StringBuilder sb = new StringBuilder();
            char[] bla = bukva.ToCharArray();

            char[] wordot = tekovenZbor.ToUpper().ToCharArray();
            char[] word = lbWord.Text.ToCharArray();
            char buk = bukva.ToCharArray()[0];
            bool isDone = true;
            bool Guess = false;
            for (int i = 0; i < tekovenZbor.Length; i++)
            {
                
                if (wordot[i] == buk)
                {
                    sb.Append(buk);
                    Guess = true;
                }
                else if (word[i] == '-')
                {
                    sb.Append("-");
                    isDone = false;
                }
                else
                {
                    sb.Append(word[i]);
                }
               
            }


                lbWord.Text = sb.ToString();
                if (!Guess)
                {
                    besilka++;
                    DrawBodyPart(besilka);
                }
                if (isDone)
                {
                    //disable na svi kopcinja

                    MessageBox.Show("Погодок!!!");
                    g.Clear(Control.DefaultBackColor);
                    PolniSiteMozniListi();
                }
        }

        public void Draw(Brush brush, Graphics g)
        {
            brush = new SolidBrush(Color.Blue);
            g.FillEllipse(brush,50, 50, 50, 50);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button23.Enabled = false;

            proveriBukva(button23.Text);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.button17.Enabled = false;
            proveriBukva(button17.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            proveriBukva(button4.Text);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button18.Enabled = false;
            proveriBukva(button18.Text);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button28.Enabled = false;
            proveriBukva(button28.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Enabled = false;
            proveriBukva(button14.Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Enabled = false;
            proveriBukva(button11.Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button22.Enabled = false;
            proveriBukva(button22.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Enabled = false;
            proveriBukva(button13.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            proveriBukva(button1.Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button24.Enabled = false;
            proveriBukva(button24.Text);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button21.Enabled = false;
            proveriBukva(button21.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Enabled = false;
            proveriBukva(button15.Text);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            proveriBukva(button26.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button31.Enabled = false;
            proveriBukva(button31.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            proveriBukva(button10.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Enabled = false;
            proveriBukva(button9.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            proveriBukva(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            proveriBukva(button3.Text);
           
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button25.Enabled = false;
            proveriBukva(button25.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.Enabled = false;
            proveriBukva(button16.Text);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            button27.Enabled = false;
            proveriBukva(button27.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button30.Enabled = false;
            proveriBukva(button30.Text);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button29.Enabled = false;
            proveriBukva(button29.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            proveriBukva(button8.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Enabled = false;
            proveriBukva(button7.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            proveriBukva(button6.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Enabled = false;
            proveriBukva(button5.Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Enabled = false;
            proveriBukva(button12.Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button19.Enabled = false;
            proveriBukva(button19.Text);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button20.Enabled = false;
            proveriBukva(button20.Text);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void zbor_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
