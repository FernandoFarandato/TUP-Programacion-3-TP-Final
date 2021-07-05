using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public static class Utils
    {
        public static void messageError(Form actual, string message)
        {
            MessageBox.Show(actual, message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void messageWarning(Form actual, string message)
        {
            MessageBox.Show(actual, message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void messageOk(Form actual, string message)
        {
            MessageBox.Show(actual, message, "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
