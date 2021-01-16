using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servicos
{
    public class ModPorNDServico
    {
        private ModPorNDDados _dao = new ModPorNDDados();

        public DataTable carregaDtg()
        {
            return _dao.carregaDtg();
        }
    }
}
