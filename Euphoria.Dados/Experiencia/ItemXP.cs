using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euphoria.Dados
{
    public class ItemXP
    {
        private String XP;
        private String ND;

        public string xp
        {
            get { return XP; }
            set { XP = value; }
        }
        public string nd
        {
            get { return ND; }
            set { ND = value; }
        }

        public ItemXP(String XP, String ND)
        {
            xp = XP;
            nd = ND;
        }
    }
}
