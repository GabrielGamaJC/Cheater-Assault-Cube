using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMenu2
{
    public partial class Menu2 : MaterialForm
    {
        Form1 formulado;
        public Menu2()
        {
            InitializeComponent();
             
            var skinmanager = MaterialSkinManager.Instance;

            skinmanager.Theme = MaterialSkinManager.Themes.LIGHT;

            skinmanager.ColorScheme = new ColorScheme(Primary.Indigo600, Primary.Indigo900, Primary.Red900, Accent.LightBlue700, TextShade.WHITE);
           
        }

        private void Menu2_Load(object sender, EventArgs e)
        {

        }

        private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            bool processo = Process.GetProcessesByName("ac_client").Length > 0;
                if (processo)
                {
                 formulado = new Form1();
                    formulado.Show();
                }
                else
                {
                    MessageBox.Show("Abra o game.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                variavel.ESPBOX = true;
            }
            else
            {
                variavel.ESPBOX = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                variavel.ESPLINE = true;
            }
            else
            {
                variavel.ESPLINE = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                variavel.ESPNAME = true;
            }
            else
            {
                variavel.ESPNAME = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                variavel.ESPVIDA = true;
            }
            else
            {
                variavel.ESPVIDA = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                variavel.ESPAmigo = true;
            }
            else
            {
                variavel.ESPAmigo = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                variavel.Aimbot = true;
            }
            else
            {
                variavel.Aimbot = false;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                variavel.fovaimbot = true;
            }
            else
            {
                variavel.fovaimbot = false;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                variavel.espfov = true;
            }
            else
            {
                variavel.espfov = false;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                formulado.vidain(true);
            }
            else
            {
                formulado.vidain(false);
            }

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                formulado.balasin(true);
            }
            else
            {
                formulado.balasin(false);
            }
        }
    }
}
