using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ModPorNDDados
    {
        private DataTable dtNd = null;

        private List<ND> list = new List<ND>();

        public DataTable carregaDtg()
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod. BP";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND 1";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod. BP 1";
            dtNd.Columns.Add(column);

            list = preencheLista(list);

            int j = 25;

            for (int i = 0; i <= 24; i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["ND"] = list[i].nd;
                linha["Mod. BP"] = list[i].mod;
                if (list.Count > j)
                {
                    if (!String.IsNullOrEmpty(list[j].nd) && !String.IsNullOrEmpty(list[j].mod))
                    {
                        linha["ND 1"] = list[j].nd;
                        linha["Mod. BP 1"] = list[j].mod;
                        j++;
                    }
                }
                dtNd.Rows.Add(linha);

            }

            return dtNd;
        }
        private List<ND> preencheLista(List<ND> listItem)
        {
            listItem.Clear();
            listItem.Add(new ND("+2", "0"));
            listItem.Add(new ND("+2", "1/8"));
            listItem.Add(new ND("+2", "1/4"));
            listItem.Add(new ND("+2", "1/2"));
            listItem.Add(new ND("+2", "1"));
            listItem.Add(new ND("+2", "2"));
            listItem.Add(new ND("+2", "3"));
            listItem.Add(new ND("+2", "4"));
            listItem.Add(new ND("+3", "5"));
            listItem.Add(new ND("+3", "6"));
            listItem.Add(new ND("+3", "7"));
            listItem.Add(new ND("+3", "8"));
            listItem.Add(new ND("+4", "9"));
            listItem.Add(new ND("+4", "10"));
            listItem.Add(new ND("+4", "11"));
            listItem.Add(new ND("+4", "12"));
            listItem.Add(new ND("+5", "13"));
            listItem.Add(new ND("+5", "14"));
            listItem.Add(new ND("+5", "15"));
            listItem.Add(new ND("+5", "16"));
            listItem.Add(new ND("+6", "17"));
            listItem.Add(new ND("+6", "18"));
            listItem.Add(new ND("+6", "19"));
            listItem.Add(new ND("+6", "20"));
            listItem.Add(new ND("+7", "21"));
            listItem.Add(new ND("+7", "22"));
            listItem.Add(new ND("+7", "23"));
            listItem.Add(new ND("+7", "24"));
            listItem.Add(new ND("+8", "25"));
            listItem.Add(new ND("+8", "26"));
            listItem.Add(new ND("+8", "27"));
            listItem.Add(new ND("+8", "28"));
            listItem.Add(new ND("+9", "29"));
            listItem.Add(new ND("+9", "30"));

            return listItem;
        }
    }
    public partial class ND
    {
        private string Nd;
        private string Mod;

        public string nd
        {
            get { return Nd; }
            set { Nd = value; }
        }
        public string mod
        {
            get { return Mod; }
            set { Mod = value; }
        }
        public ND(string MOD, string ND)
        {
            nd = ND;
            mod = MOD;
        }
    }
}
