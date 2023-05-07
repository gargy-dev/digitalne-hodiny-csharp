using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace korabsky_digitalne_hodiny
{
    public partial class Form_HO_PK : Form
    {
        int h, m, s;
        public Form_HO_PK()
        {
            InitializeComponent();
            h = m = s = 0;
        }

        private void textBox_hodiny_TextChanged(object sender, EventArgs e)
        {
            chyby.SetError(textBox_hodiny, "");
            if(textBox_hodiny.Text!="")
            {
                if(int.Parse(textBox_hodiny.Text) >= 24)
                {
                    chyby.SetError(textBox_hodiny, "Neplatná hodina!");
                }
            }
        }

        private void textBox_minuty_TextChanged(object sender, EventArgs e)
        {
            chyby.SetError(textBox_minuty, "");
            if (textBox_minuty.Text != "")
            {
                if (int.Parse(textBox_minuty.Text) >= 60)
                {
                    chyby.SetError(textBox_minuty, "Neplatná minúta!");
                }
            }
        }

        private void textBox_sekundy_TextChanged(object sender, EventArgs e)
        {
            chyby.SetError(textBox_sekundy, "");
            if (textBox_sekundy.Text != "")
            {
                if (int.Parse(textBox_sekundy.Text) >= 60)
                {
                    chyby.SetError(textBox_sekundy, "Neplatná sekunda!");
                }
            }
        }

        private void textBox_hodiny_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.ConvertToUtf32(e.KeyChar + "", 0) !=8 )
            {
                e.Handled = true;
            }
        }

        private void textBox_minuty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.ConvertToUtf32(e.KeyChar + "", 0) != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox_sekundy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && char.ConvertToUtf32(e.KeyChar + "", 0) != 8)
            {
                e.Handled = true;
            }
        }

        private void Form_HO_PK_Load(object sender, EventArgs e)
        {
            textBox_hodiny.Enabled = false;
            textBox_minuty.Enabled = false;
            textBox_sekundy.Enabled = false;
            button_start.Visible = false;
            button_uprava.Visible = true;
            button_reset.Visible = false;
        }

        private void button_uprava_Click(object sender, EventArgs e)
        {
            textBox_hodiny.Enabled = true;
            textBox_minuty.Enabled = true;
            textBox_sekundy.Enabled = true;
            button_start.Visible = true;
            button_uprava.Visible = false;
            button_reset.Visible = false;
            casovac.Stop();
        }

        private void casovac_Tick(object sender, EventArgs e)
        {
            try
            {
                h = int.Parse(textBox_hodiny.Text);
                m = int.Parse(textBox_minuty.Text);
                s = int.Parse(textBox_sekundy.Text);
            }

            catch 
            {
                return;
            }

            s++;

            // ak bude 60 s prirata sa 1 minuta a sekundy sa zacnu znovu ratat od 0
            if (s >= 60)
            {
                m += 1;
                s = 0;
            }

            // ak bude 60 min prirata sa 1 hodina a minuty sa zacnu ratat od nuly
            if (m >= 60)
            {
                h += 1;
                m = 0;
            }

            //ak bude 24 hodin tak sa hodiny vynuluju
            if (h >= 24)
            {
                h = 0;
            }

            // pridanie 0 k hodinam ak hodin bude viac ako 10
            if (h >= 10)
            {
                textBox_hodiny.Text = h + "";
            }

            else
            {
                textBox_hodiny.Text = "0" + h + "";
            }

            // pridanie 0 k minutam ak minut bude viac ako 10
            if (m >= 10)
            {
                textBox_minuty.Text = m + "";
            }

            else
            {
                textBox_minuty.Text = "0" + m + "";
            }

            // pridanie 0 k sekundam ak sekund bude viac ako 10
            if (s >= 10)
            {
                textBox_sekundy.Text = s + "";
            }

            else
            {
                textBox_sekundy.Text = "0" + s + "";
            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            if (textBox_hodiny.Text != "" && textBox_minuty.Text != "" && textBox_sekundy.Text != "")
            {
                textBox_hodiny.Enabled = false;
                textBox_minuty.Enabled = false;
                textBox_sekundy.Enabled = false;
                button_start.Visible = true;
                button_uprava.Visible = true;
                button_reset.Visible = true;
                casovac.Start();
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox_hodiny.Text = "";
            textBox_minuty.Text = "";
            textBox_sekundy.Text = "";
            button_start.Visible = false;
            button_uprava.Visible = true;
            button_reset.Visible = false;
            casovac.Stop();
        }
    }
}
