using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;

namespace Euphoria.Servicos
{
    public class ModPorHabServico
    {
        private ModPorHabDados _dao = new ModPorHabDados();

        public DataTable carregaDtg()
        {
            return _dao.carregaDtg();
        }
    }
}
