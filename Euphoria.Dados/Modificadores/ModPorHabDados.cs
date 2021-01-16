using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ModPorHabDados
    {
        private DataTable dtNd = null;

        private List<Habilidade> list = new List<Habilidade>();

        public DataTable carregaDtg()
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Valor de Habilidade";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod.";
            dtNd.Columns.Add(column);

            list = preencheLista(list);

            int j = 25;

            foreach (Habilidade item in list)
            {
                DataRow linha = dtNd.NewRow();
                linha["Valor de Habilidade"] = item.valor;
                linha["Mod."] = item.modi;
                dtNd.Rows.Add(linha);

            }

            return dtNd;
        }
        private List<Habilidade> preencheLista(List<Habilidade> listItem)
        {
            listItem.Clear();
            listItem.Add(new Habilidade("-5", "1"));
            listItem.Add(new Habilidade("-4", "2-3"));
            listItem.Add(new Habilidade("-3", "4-5"));
            listItem.Add(new Habilidade("-2", "6-7"));
            listItem.Add(new Habilidade("-1", "8-9"));
            listItem.Add(new Habilidade("+0", "10-11"));
            listItem.Add(new Habilidade("+1", "12-13"));
            listItem.Add(new Habilidade("+2", "14-15"));
            listItem.Add(new Habilidade("+3", "16-17"));
            listItem.Add(new Habilidade("+4", "18-19"));
            listItem.Add(new Habilidade("+5", "20-21"));
            listItem.Add(new Habilidade("+6", "22-23"));
            listItem.Add(new Habilidade("+7", "24-25"));
            listItem.Add(new Habilidade("+8", "26-27"));
            listItem.Add(new Habilidade("+9", "28-29"));
            listItem.Add(new Habilidade("+10", "30"));

            return listItem;
        }
    }
    public partial class Habilidade
    {
        private string Valor;
        private string Modi;

        public string valor
        {
            get { return Valor; }
            set { Valor = value; }
        }

        public string modi
        {
            get { return Modi; }
            set { Modi = value; }
        }

        public Habilidade(string MODI, string VALOR)
        {
            modi = MODI;
            valor = VALOR;
        }

    }
}
