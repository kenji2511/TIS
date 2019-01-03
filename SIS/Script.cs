using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIS
{
    class Script
    {
        public void CheckNumber(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public string GetAroundName(string around_id)
        {
            switch (around_id)
            {
                case "1":
                    return "ผลัดที่ 1 เวลา 22:00 น. - 06:00 น.";
                    break;
                case "2":
                    return "ผลัดที่ 2 เวลา 06:00 น. - 14:00 น.";
                    break;
                case "3":
                    return "ผลัดที่ 3 เวลา 14:00 น. - 22:00 น.";
                    break;
                default: return null;
            }

        }

    }
}
