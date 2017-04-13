using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo7
{
    class Outils
    {

       
        
        public static Boolean EstEntier(string s)
        {
            int i;
            char c;
            Boolean code = true;

            if (s.Length < 10 && s.Length > 0)
            {
                for (i = 0; i < s.Length; i++)
                {
                    c = s[i];
                    if (!(Char.IsDigit(c))) { code = false; }
                }
            }
            else
            {
                code = false;
            }
            return code;
        }

    }
}
