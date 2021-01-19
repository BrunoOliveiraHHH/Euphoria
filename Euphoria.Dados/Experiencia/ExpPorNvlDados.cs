using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ExpPorNvlDados
    {
        private DataTable dtNd = null;

        private List<ItemXP> list = new List<ItemXP>();

        #region XP por Nvl
        private List<ItemXP> preencheListaNvl(List<ItemXP> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemXP("0", "1"));
            listItem.Add(new ItemXP("300", "2"));
            listItem.Add(new ItemXP("900", "3"));
            listItem.Add(new ItemXP("2.700", "4"));
            listItem.Add(new ItemXP("6.500", "5"));
            listItem.Add(new ItemXP("14.000", "6"));
            listItem.Add(new ItemXP("23.000", "7"));
            listItem.Add(new ItemXP("34.000", "8"));
            listItem.Add(new ItemXP("48.000", "9"));
            listItem.Add(new ItemXP("64.000", "10"));
            listItem.Add(new ItemXP("85.000", "11"));
            listItem.Add(new ItemXP("100.000", "12"));
            listItem.Add(new ItemXP("120.000", "13"));
            listItem.Add(new ItemXP("140.000", "14"));
            listItem.Add(new ItemXP("165.000", "15"));
            listItem.Add(new ItemXP("195.000", "16"));
            listItem.Add(new ItemXP("225.000", "17"));
            listItem.Add(new ItemXP("265.000", "18"));
            listItem.Add(new ItemXP("305.000", "19"));
            listItem.Add(new ItemXP("355.000", "20"));
            listItem.Add(new ItemXP("410.000", "21"));
            listItem.Add(new ItemXP("470.000", "22"));
            listItem.Add(new ItemXP("540.000", "23"));
            listItem.Add(new ItemXP("620.000", "24"));
            listItem.Add(new ItemXP("710.000", "25"));
            listItem.Add(new ItemXP("810.000", "26"));
            listItem.Add(new ItemXP("950.000", "27"));
            listItem.Add(new ItemXP("1.200.000", "28"));
            listItem.Add(new ItemXP("1.500.000", "29"));
            listItem.Add(new ItemXP("1.800.000", "30"));

            return listItem;
        }
        public DataTable montaDtNvl()
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Nvl1";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP1";
            dtNd.Columns.Add(column);

            list = preencheListaNvl(list);

            int j = 20;

            for (int i = 0; i <= 19; i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["Nvl"] = list[i].nd;
                linha["XP"] = list[i].xp;
                if (list.Count > j)
                {
                    if (!String.IsNullOrEmpty(list[j].nd) && !String.IsNullOrEmpty(list[j].xp))
                    {
                        linha["Nvl1"] = list[j].nd;
                        linha["XP1"] = list[j].xp;
                        j++;
                    }
                }
                dtNd.Rows.Add(linha);

            }

            return dtNd;
        }
        #endregion
    }
}
