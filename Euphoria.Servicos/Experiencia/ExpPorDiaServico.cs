using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Euphoria.Dados;
using System.Data;


namespace Euphoria.Servicos
{
    public class ExpPorDiaServico
    {
        private ExpPorDiaDados _dao = new ExpPorDiaDados();

        public DataTable carregaDtg()
        {
            return _dao.montaDtNvl();
        }
    }
}
