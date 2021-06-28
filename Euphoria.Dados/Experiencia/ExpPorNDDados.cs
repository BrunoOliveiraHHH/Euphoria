using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ExpPorNDDados
    {
        private DataTable dtNd = null;

        private List<ItemXP> list = new List<ItemXP>();

        #region XP por ND
        public DataTable montaDt()
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND 1";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "XP 1";
            dtNd.Columns.Add(column);

            list = preencheLista(list);

            int j = 20;

            for (int i = 0; i <= 19; i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["ND"] = list[i].nd;
                linha["XP"] = list[i].xp;
                if (list.Count > j)
                {
                    if (!String.IsNullOrEmpty(list[j].nd) && !String.IsNullOrEmpty(list[j].xp))
                    {
                        linha["ND 1"] = list[j].nd;
                        linha["XP 1"] = list[j].xp;
                        j++;
                    }
                }

                dtNd.Rows.Add(linha);
            }

            return dtNd;
        }
        private List<ItemXP> preencheLista(List<ItemXP> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemXP("0 ou 10", "0"));
            listItem.Add(new ItemXP("25", "1/8"));
            listItem.Add(new ItemXP("50", "1/4"));
            listItem.Add(new ItemXP("100", "1/2"));
            listItem.Add(new ItemXP("200", "1"));
            listItem.Add(new ItemXP("450", "2"));
            listItem.Add(new ItemXP("700", "3"));
            listItem.Add(new ItemXP("1.100", "4"));
            listItem.Add(new ItemXP("1.800", "5"));
            listItem.Add(new ItemXP("2.300", "6"));
            listItem.Add(new ItemXP("2.900", "7"));
            listItem.Add(new ItemXP("3.900", "8"));
            listItem.Add(new ItemXP("5.000", "9"));
            listItem.Add(new ItemXP("5.900", "10"));
            listItem.Add(new ItemXP("7.200", "11"));
            listItem.Add(new ItemXP("8.400", "12"));
            listItem.Add(new ItemXP("10.000", "13"));
            listItem.Add(new ItemXP("11.500", "14"));
            listItem.Add(new ItemXP("13.000", "15"));
            listItem.Add(new ItemXP("15.000", "16"));
            listItem.Add(new ItemXP("18.000", "17"));
            listItem.Add(new ItemXP("20.000", "18"));
            listItem.Add(new ItemXP("22.000", "19"));
            listItem.Add(new ItemXP("25.000", "20"));
            listItem.Add(new ItemXP("33.000", "21"));
            listItem.Add(new ItemXP("41.000", "22"));
            listItem.Add(new ItemXP("50.000", "23"));
            listItem.Add(new ItemXP("62.000", "24"));
            listItem.Add(new ItemXP("75.000", "25"));
            listItem.Add(new ItemXP("90.000", "26"));
            listItem.Add(new ItemXP("105.000", "27"));
            listItem.Add(new ItemXP("120.000", "28"));
            listItem.Add(new ItemXP("135.000", "29"));
            listItem.Add(new ItemXP("155.000", "30"));

            return listItem;
        }
        #endregion



    }
}
