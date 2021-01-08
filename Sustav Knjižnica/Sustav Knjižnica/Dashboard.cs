using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sustav_Knjižnica
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Jeste li sigurni da želite izaći?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dodajNovuKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_knjige dk = new Dodaj_knjige();
            dk.Show();
        }

        private void pregledajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pogledaj_knjige pk = new Pogledaj_knjige();
            pk.Show();
        }

        private void dodajStudentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dodaj_studenta ds = new Dodaj_studenta();
            ds.Show();
        }

        private void pogledajInformacijeOStudentuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pogledaj_Studente ps = new Pogledaj_Studente();
            ps.Show();
        }

        private void izdajKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Izdaj_knjige ik = new Izdaj_knjige();
            ik.Show();
        }

        private void vratiKnjiguToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vrati_knjigu vk = new Vrati_knjigu();
            vk.Show();
        }

        private void informacijeOKnjigamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Informacije_knjige ik = new Informacije_knjige();
            ik.Show();
        }
    }
}
