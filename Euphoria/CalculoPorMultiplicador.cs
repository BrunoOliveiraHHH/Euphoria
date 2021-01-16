using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Servicos;

namespace Euphoria
{
    public class CalculoPorMultiplicador
    {
        private Multiplicadores multi = new Multiplicadores();

        public string CalculoXP(string xp, string QtdMonstro)
        {
            try
            {
                int XP = int.Parse(xp);
                int Monstro = int.Parse(QtdMonstro);
                double total = 0;
                if (Monstro == 2)
                {
                    total = XP * multi.MULTI_1_5;
                    return total.ToString();
                }
                else if (Monstro >= 3 && Monstro <= 6)
                {
                    total = XP * multi.MULTI_2;
                    return total.ToString();
                }
                else if (Monstro >= 7 && Monstro <= 10)
                {
                    total = XP * multi.MULTI_2_5;
                    return total.ToString();
                }
                else if (Monstro >= 11 && Monstro <= 14)
                {
                    total = XP * multi.MULTI_3;
                    return total.ToString();
                }
                else if (Monstro >= 15)
                {
                    total = XP * multi.MULTI_4;
                    return total.ToString();
                }
                else
                {
                    total = XP;
                    return total.ToString();
                }
            }
            catch
            {
                return "Preenchimento invalido, preencher apenas com numeros.";
            }
        }
        public string CalcularJogador(string xp, string  QtdJogador)
        {
            try
            {
                int XP = int.Parse(xp);
                int Jogadores = int.Parse(QtdJogador);
                double total = XP / Jogadores;
                return total.ToString();
            }
            catch
            {
                return "Calcular o valor total primeiro.";
            }
        }
    }
}
