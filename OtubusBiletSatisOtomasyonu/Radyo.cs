using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtubusBiletSatisOtomasyonu
{
    public partial class Radyo : Form
    {
        public Radyo()
        {
            InitializeComponent();
        }

        private void btnAlemFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://turkmedya.radyotvonline.com/turkmedya/alemfm.stream/playlist.m3u8";
        }

        private void btnPowerFm_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerfm.listenpowerapp.com/powerfm/abr/playlist.m3u8";
        }

        private void btnRadyoEge_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://stream2.taksimbilisim.com:8010/;";
        }

        private void btnShowRadyo_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://windows.showradyo.com.tr";
        }

        private void btnShowTurk_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radyo.dogannet.tv/slowturk";
        }

        private void btnRadyoKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
