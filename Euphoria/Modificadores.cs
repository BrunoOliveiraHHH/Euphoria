using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Servicos;
using System.Data;

namespace Euphoria
{
    public class Modificadores
    {
        private ModPorNDServico _servicoNd = new ModPorNDServico();
        private ModPorNvlServico _servicoNvl = new ModPorNvlServico();
        private ModPorHabServico _servicoHab = new ModPorHabServico();

        public DataTable carregaDtgND()
        {
            return _servicoNd.carregaDtg();
        }

        public DataTable carregaDtgNvl()
        {
            return _servicoNvl.carregaDtg();
        }

        public DataTable carregaDtgHab()
        {
            return _servicoHab.carregaDtg();
        }
    }
}
