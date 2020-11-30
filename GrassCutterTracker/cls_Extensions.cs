using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrassCutterTracker
{
    public class cls_Extensions
    {
        public static bool InputErrorCheck(Dictionary<string, string> prInput)
        {
            foreach (var item in prInput)
            {
                if (string.IsNullOrEmpty(item.Value) | item.Value == "0")
                {
                    MessageBox.Show("Must have a valid " + item.Key, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
            }
            return false;
        }
    }
}
