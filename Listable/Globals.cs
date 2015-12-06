using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listable
{
    public static class Globals
    {
        static bool m_isWin10 = false;

        public static bool IsWin10
        {
            get
            {
                return m_isWin10;
            }
            
            set
            {
                m_isWin10 = value;
            }
        }

    }
}
