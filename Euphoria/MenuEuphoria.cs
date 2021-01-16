using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Euphoria
{
    public partial class MenuEuphoria : Form
    {
        private Modificadores modficadores = new Modificadores();

        public MenuEuphoria()
        {
            InitializeComponent();
        }

        private void modPorNDSubMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.DataSource = modficadores.carregaDtgND();
            dgTelaInicial.Visible = true;

        }

        private void inicioMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.Visible = false;
        }

        private void modPorNivelSubMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.DataSource = modficadores.carregaDtgNvl();

            if (dgTelaInicial.Visible == false)
            {
                dgTelaInicial.Visible = true;
            }
        }

        private void modPorHabilidadeSubMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.DataSource = modficadores.carregaDtgHab();            

            if (dgTelaInicial.Visible == false)
            {
                dgTelaInicial.Visible = true;
            }
        }

        
    }
}
