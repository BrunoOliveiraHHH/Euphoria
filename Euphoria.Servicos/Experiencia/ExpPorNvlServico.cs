using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servicos
{
    public class ExpPorNvlServico
    {
        private ExpPorNvlDados _dao = new ExpPorNvlDados();

        public DataTable carregaDtg()
        {
            return _dao.montaDtNvl();
        }
    }
}
