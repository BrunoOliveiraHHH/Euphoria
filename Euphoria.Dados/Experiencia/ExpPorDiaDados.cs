using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ExpPorDiaDados
    {
    
        private DataTable dtNd = null;

        private List<ItemXP> list = new List<ItemXP>();

        #region XP por Dia
        private List<ItemXP> preencheListaNvl(List<ItemXP> listItem)
        {
            listItem.Clear();
            listItem.Add(new ItemXP("300", "1"));
            listItem.Add(new ItemXP("600", "2"));
            listItem.Add(new ItemXP("1.200", "3"));
            listItem.Add(new ItemXP("1.700", "4"));
            listItem.Add(new ItemXP("3.500", "5"));
            listItem.Add(new ItemXP("4.000", "6"));
            listItem.Add(new ItemXP("5.000", "7"));
            listItem.Add(new ItemXP("6.000", "8"));
            listItem.Add(new ItemXP("7.500", "9"));
            listItem.Add(new ItemXP("9.000", "10"));
            listItem.Add(new ItemXP("10.500", "11"));
            listItem.Add(new ItemXP("11.500", "12"));
            listItem.Add(new ItemXP("13.500", "13"));
            listItem.Add(new ItemXP("15.000", "14"));
            listItem.Add(new ItemXP("18.000", "15"));
            listItem.Add(new ItemXP("20.000", "16"));
            listItem.Add(new ItemXP("25.000", "17"));
            listItem.Add(new ItemXP("27.000", "18"));
            listItem.Add(new ItemXP("30.000", "19"));
            listItem.Add(new ItemXP("40.000", "20"));

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
            column.ColumnName = "XP por Dia";
            dtNd.Columns.Add(column);

            list = preencheListaNvl(list);

            
            for (int i = 0; i < list.Count(); i++)
            {
                DataRow linha = dtNd.NewRow();
                linha["Nvl"] = list[i].nd;
                linha["XP por Dia"] = list[i].xp;
                
                dtNd.Rows.Add(linha);

            }

            return dtNd;
        }
        #endregion
    }
}
