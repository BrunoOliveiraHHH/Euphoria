using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ModPorNvlDados
    {
        private DataTable dtNd = null;

        private List<Nivel> list = new List<Nivel>();

        public DataTable carregaDtg()
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod. BP";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl 1";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Mod. BP 1";
            dtNd.Columns.Add(column);

            list = preencheLista(list);

            int j = 20;

            for (int i = 0; i <= 19; i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["Nvl"] = list[i].nvl;
                linha["Mod. BP"] = list[i].mod;
                if (list.Count > j)
                {
                    if (!String.IsNullOrEmpty(list[j].nvl) && !String.IsNullOrEmpty(list[j].mod))
                    {
                        linha["Nvl 1"] = list[j].nvl;
                        linha["Mod. BP 1"] = list[j].mod;
                        j++;
                    }
                }
                dtNd.Rows.Add(linha);

            }

            return dtNd;
        }
        private List<Nivel> preencheLista(List<Nivel> listItem)
        {
            listItem.Clear();
            listItem.Add(new Nivel("+2", "1"));
            listItem.Add(new Nivel("+2", "2"));
            listItem.Add(new Nivel("+2", "3"));
            listItem.Add(new Nivel("+2", "4"));
            listItem.Add(new Nivel("+3", "5"));
            listItem.Add(new Nivel("+3", "6"));
            listItem.Add(new Nivel("+3", "7"));
            listItem.Add(new Nivel("+3", "8"));
            listItem.Add(new Nivel("+4", "9"));
            listItem.Add(new Nivel("+4", "10"));
            listItem.Add(new Nivel("+4", "11"));
            listItem.Add(new Nivel("+4", "12"));
            listItem.Add(new Nivel("+5", "13"));
            listItem.Add(new Nivel("+5", "14"));
            listItem.Add(new Nivel("+5", "15"));
            listItem.Add(new Nivel("+5", "16"));
            listItem.Add(new Nivel("+6", "17"));
            listItem.Add(new Nivel("+6", "18"));
            listItem.Add(new Nivel("+6", "19"));
            listItem.Add(new Nivel("+6", "20"));
            listItem.Add(new Nivel("+6", "21"));
            listItem.Add(new Nivel("+6", "22"));
            listItem.Add(new Nivel("+6", "23"));
            listItem.Add(new Nivel("+6", "24"));
            listItem.Add(new Nivel("+6", "25"));
            listItem.Add(new Nivel("+6", "26"));
            listItem.Add(new Nivel("+6", "27"));
            listItem.Add(new Nivel("+6", "28"));
            listItem.Add(new Nivel("+6", "29"));
            listItem.Add(new Nivel("+6", "30"));

            return listItem;
        }
    }
    public partial class Nivel
    {
        private string Nvl;
        private string Mod;

        public string nvl
        {
            get { return Nvl; }
            set { Nvl = value; }
        }
        public string mod
        {
            get { return Mod; }
            set { Mod = value; }
        }
        public Nivel(string MOD, string NVL)
        {
            nvl = NVL;
            mod = MOD;
        }
    }
}
