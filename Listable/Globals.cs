using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Listable
{
    public static class Globals
    {
        static bool m_isWin10 = false;
        static Color m_archColor = Color.FromArgb(220, 200, 80);

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
        public static Color ArchiveColor
        {
            get
            {
                return m_archColor;
            }

            set
            {
                m_archColor = value;
            }
        }

    }
}
