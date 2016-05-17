using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace QLBanHang.Controls
{
    public static class GlobalValues
    {
        private static int _idNhanVien = 7;

        public static int IdNhanVien
        {
            get { return GlobalValues._idNhanVien; }
            set { GlobalValues._idNhanVien = value; }
        }


        private static Color _globalForeColor = Color.Blue;

        public static Color GlobalForeColor
        {
            get { return _globalForeColor; }
            set { _globalForeColor = value; }
        }

        private static Color _globalBackGroundColor = Color.LightCyan;

        public static Color GlobalBackGroundColor
        {
            get { return _globalBackGroundColor; }
            set { _globalBackGroundColor = value; }
        }

        private static Color _backGroundMenu_NonColor = Color.DeepSkyBlue;

        public static Color BackGroundMenu_NonColor
        {
            get { return GlobalValues._backGroundMenu_NonColor; }
            set { GlobalValues._backGroundMenu_NonColor = value; }
        }

        private static Color _backGroundMenu_SelectedColor = Color.DodgerBlue;

        public static Color BackGroundMenu_SelectedColor
        {
            get { return GlobalValues._backGroundMenu_SelectedColor; }
            set { GlobalValues._backGroundMenu_SelectedColor = value; }
        }
    }
}
