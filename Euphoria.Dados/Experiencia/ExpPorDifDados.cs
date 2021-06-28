using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Euphoria.Dados
{
    public class ExpPorDifDados
    {
        private DataTable dtNd = null;

        private List<Personagem> list = new List<Personagem>();

        #region ND por Personagem
        public DataTable montaDt()
        {
            dtNd = new DataTable();

            DataColumn column;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "ND";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "FACIL";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "MEDIO";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "DIFICIL";
            dtNd.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "MORTAL";
            dtNd.Columns.Add(column);

            list = preencheLista(list);

            foreach (Personagem personagem in list)
            {
                DataRow linha = dtNd.NewRow();
                linha["ND"] = personagem.nd;
                linha["FACIL"] = personagem.facil;
                linha["MEDIO"] = personagem.medio;
                linha["DIFICIL"] = personagem.dificil;
                linha["MORTAL"] = personagem.mortal;

                dtNd.Rows.Add(linha);
            }

            return dtNd;
        }
        private List<Personagem> preencheLista(List<Personagem> listItem)
        {
            listItem.Add(new Personagem("1", "25", "50", "75", "100"));
            listItem.Add(new Personagem("2", "50", "100", "150", "200"));
            listItem.Add(new Personagem("3", "75", "150", "225", "400"));
            listItem.Add(new Personagem("4", "125", "250", "375", "500"));
            listItem.Add(new Personagem("5", "250", "500", "750", "1.100"));
            listItem.Add(new Personagem("6", "300", "600", "900", "1.400"));
            listItem.Add(new Personagem("7", "350", "750", "1.100", "1.700"));
            listItem.Add(new Personagem("8", "450", "900", "1.400", "2.100"));
            listItem.Add(new Personagem("9", "550", "1.100", "1.600", "2.400"));
            listItem.Add(new Personagem("10", "600", "1.200", "1.900", "2.800"));
            listItem.Add(new Personagem("11", "800", "1.600", "2.400", "3.600"));
            listItem.Add(new Personagem("12", "1.000", "2.000", "3.000", "4.500"));
            listItem.Add(new Personagem("13", "1.100", "2.200", "3.400", "5.100"));
            listItem.Add(new Personagem("14", "1.250", "2.500", "3.800", "5.700"));
            listItem.Add(new Personagem("15", "1.400", "2.800", "4.300", "6.400"));
            listItem.Add(new Personagem("16", "1.600", "3.200", "4.800", "7.200"));
            listItem.Add(new Personagem("17", "2.000", "3.900", "5.900", "8.800"));
            listItem.Add(new Personagem("18", "2.100", "4.200", "6.300", "9.500"));
            listItem.Add(new Personagem("19", "2.400", "4.900", "7.300", "10.900"));
            listItem.Add(new Personagem("20", "2.800", "5.700", "8.500", "12.700"));
            return listItem;
        }
        #endregion
    }
    public partial class Personagem
    {
        private String ND;
        private String FACIL;
        private String MEDIO;
        private String DIFICIL;
        private String MORTAL;

        public string nd
        {
            get { return ND; }
            set { ND = value; }
        }
        public string facil
        {
            get { return FACIL; }
            set { FACIL = value; }
        }
        public string medio
        {
            get { return MEDIO; }
            set { MEDIO = value; }

        }
        public string dificil
        {
            get { return DIFICIL; }
            set { DIFICIL = value; }

        }
        public string mortal
        {
            get { return MORTAL; }
            set { MORTAL = value; }

        }
        public Personagem(String ND, String FACIL, String MEDIO, String DIFICIL, String MORTAL)
        {
            nd = ND;
            facil = FACIL;
            medio = MEDIO;
            dificil = DIFICIL;
            mortal = MORTAL;
        }
    }
}
