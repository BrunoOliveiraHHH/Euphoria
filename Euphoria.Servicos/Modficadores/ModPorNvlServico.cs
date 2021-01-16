using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servicos
{
    public class ModPorNvlServico
    {
        private ModPorNvlDados _dao = new ModPorNvlDados();

        public DataTable carregaDtg()
        {
            return _dao.carregaDtg();
        }
    }
}
