using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bbeOdev1
{
    public partial class FrmTopla : Form
    {
        private float Topla(float sayi1, float sayi2)
        {
            sayi1 = float.Parse(txtSayi1.Text);
            sayi2 = float.Parse(txtSayi2.Text);
            float Toplam = sayi1 + sayi2;
            txtSonuc.Text = Toplam.ToString();
            return Toplam;           
        }

        private void EkranSilme()
        {

            txtSonuc.Clear();
            txtSayi1.Text = txtSayi2.Text = "";
            txtSayi1.Focus();
        }
        private void OncekiSonuclar()
        {
            if (btnOncekiSonuclar.Text == "Önceki Sonuçları Göster")
            {
                GrpBoxSonuclar.Visible = true;
                btnOncekiSonuclar.Text = "Önceki Sonuçları Gizle";
            }
            else
            {
                GrpBoxSonuclar.Visible = false;
                btnOncekiSonuclar.Text = "Önceki Sonuçları Göster";
            }
            
        }

        public FrmTopla()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {
            float Toplam = Topla(float.Parse(txtSayi1.Text), float.Parse(txtSayi2.Text));
            txtSonuc.Text = Toplam.ToString();
            listSonuclar.Items.Add(txtSonuc.Text);
        }

        private void TxtSonuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSayi1_TextChanged(object sender, EventArgs e)
        {
        }

        private void TxtSayi1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
                e.Handled = true;
            
        }

        private void TxtSayi2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08 && e.KeyChar != (char)44)
                e.Handled = true;           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            EkranSilme();           
        }

        private void BtnOncekiSonuclar_Click(object sender, EventArgs e)
        {
            OncekiSonuclar();                       
        }

        private void ListSonuclar_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }
    }
}
