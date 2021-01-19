using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Servicos;
using System.Data;

namespace Euphoria
{
    public class Experiencia
    {
        private ExpPorNDServico _servicoNd = new ExpPorNDServico();
        private ExpPorNvlServico _servicoNvl = new ExpPorNvlServico();
        private ExpPorDifServico _servicoDif = new ExpPorDifServico();

        public DataTable carregaDtgND()
        {
            return _servicoNd.carregaDtg();
        }

        public DataTable carregaDtgNvl()
        {
            return _servicoNvl.carregaDtg();
        }

        public DataTable carregaDtgDif()
        {
            return _servicoDif.carregaDtg();
        }
    }
}
