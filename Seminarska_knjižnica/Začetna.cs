using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminarska_knjižnica
{
    public partial class Začetna : Form
    {
        public Začetna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Član članInfo = new Član();
            članInfo.Show();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Knjiga knjigaInfo = new Knjiga();
            knjigaInfo.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Izhod izhodInfo = new Izhod();
            izhodInfo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Knjižničar knjižničarInfo = new Knjižničar();
            knjižničarInfo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Izposoja izposojaInfo = new Izposoja();
            izposojaInfo.Show();
        }
    }
}
