using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RegistrySetter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblStatus.Text = "Ready to Set Values";
        }

        private void btnSetRegistry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboSelectList.SelectedItem.ToString()))
            {
                SetRegistry(cboSelectList.SelectedItem.ToString());
            }
        }

        private void SetRegistry(string toString)
        {
            // The name of the key must include a valid root.
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "RegistrySetValueExample";
            const string keyName = userRoot + "\\" + subkey;

            // An int value can be stored without specifying the
            // registry data type, but long values will be stored
            // as strings unless you specify the type. Note that
            // the int is stored in the default name/value
            // pair.

            // uncomment to actually save
            //Registry.SetValue(keyName, "Bob", toString, RegistryValueKind.String);
            lblStatus.Text = "Registry Value: " + toString + " Saved!";
        }
    }
}
