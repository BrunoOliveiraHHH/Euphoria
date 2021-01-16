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
        private CalculoPorMultiplicador calculo = new CalculoPorMultiplicador();

        public MenuEuphoria()
        {
            InitializeComponent();
        }

        private void modPorNDSubMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.DataSource = modficadores.carregaDtgND();

            if (dgTelaInicial.Visible == false)
            {
                gpCalculoPlay.Visible = false;
                gpCalculoXP.Visible = false;
                dgTelaInicial.Visible = true;
            }

        }

        private void inicioMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.Visible = false;
            gpCalculoPlay.Visible = false;
            gpCalculoXP.Visible = false;
        }

        private void modPorNivelSubMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.DataSource = modficadores.carregaDtgNvl();

            if (dgTelaInicial.Visible == false)
            {
                gpCalculoPlay.Visible = false;
                gpCalculoXP.Visible = false;
                dgTelaInicial.Visible = true;
            }
        }

        private void modPorHabilidadeSubMenu_Click(object sender, EventArgs e)
        {
            dgTelaInicial.DataSource = modficadores.carregaDtgHab();

            if (dgTelaInicial.Visible == false)
            {
                gpCalculoPlay.Visible = false;
                gpCalculoXP.Visible = false;
                dgTelaInicial.Visible = true;
            }
        }

        private void multDeExpSubMenu_Click(object sender, EventArgs e)
        {
            if (dgTelaInicial.Visible == true)
            {
                dgTelaInicial.Visible = false;
                gpCalculoPlay.Visible = true;
                gpCalculoXP.Visible = true;
            }
            else
            {
                gpCalculoPlay.Visible = true;
                gpCalculoXP.Visible = true;
            }
        }

        private void btnCacular_Click(object sender, EventArgs e)
        {
            lblResultado.Text = calculo.CalculoXP(txtQtdXP.Text.ToString(), txtQtdMon.Text.ToString());

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void btnLimpaPlay_Click(object sender, EventArgs e)
        {
            lblResultJogador.Text = "";
        }

        private void btnCalcularJogador_Click(object sender, EventArgs e)
        {
            lblResultJogador.Text = calculo.CalcularJogador(lblResultado.Text.ToString(), txtQtdPlay.Text.ToString());
        }




    }
}
