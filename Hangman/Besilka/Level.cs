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
    public partial class Level : Form  
    {
        
        public enum IzbravMoznosti {NAUKA, SPORT, FILMOVI, NISTO};
        public enum NivoTezina {NISTO, LESNO, SREDNO, TESKO };
        private IzbravMoznosti _Izbrav;
        private NivoTezina _nivo;

        public Level()
        {
            
            InitializeComponent();

        }
       
        private void Level_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbnauka.Checked == true)
            {
                _Izbrav = IzbravMoznosti.NAUKA;
                if (rbeasy.Checked == true) _nivo = NivoTezina.LESNO;
                else if (rbnormal.Checked == true) _nivo = NivoTezina.SREDNO;
                else _nivo = NivoTezina.TESKO;
            }
            else if (cbsport.Checked == true)
            {
                _Izbrav = IzbravMoznosti.SPORT;
                if (rbeasy.Checked == true) _nivo = NivoTezina.LESNO;
                else if (rbnormal.Checked == true) _nivo = NivoTezina.SREDNO;
                else _nivo = NivoTezina.TESKO;
            }
            else if (cbfilmovi.Checked == true)
            {
                _Izbrav = IzbravMoznosti.FILMOVI;
                if (rbeasy.Checked == true) _nivo = NivoTezina.LESNO;
                else if (rbnormal.Checked == true) _nivo = NivoTezina.SREDNO;
                else _nivo = NivoTezina.TESKO;
            }


            this.Close();

        }

        private void cbnauka_CheckedChanged(object sender, EventArgs e)
        {
            
        }

       
        public IzbravMoznosti Izbrav {
            get 
            {
                return this._Izbrav;
            }
        
        }

        public NivoTezina Nivo
        {
            get
            {
                return this._nivo;
            }

        } 
 
    }
}
