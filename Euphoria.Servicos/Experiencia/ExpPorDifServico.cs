using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;


namespace Euphoria.Servicos
{
    public class ExpPorDifServico
    {
        private ExpPorDifDados _dao = new ExpPorDifDados();

        public DataTable carregaDtg()
        {
            return _dao.montaDt();
        }
    }
}
