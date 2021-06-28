using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servicos
{
    public class ExpPorNDServico
    {
        private ExpPorNDDados _dao = new ExpPorNDDados();

        public DataTable carregaDtg()
        {
            return _dao.montaDt();
        }
    }
}
