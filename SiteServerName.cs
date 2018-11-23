using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatchMaster
{
    public partial class f_siteserverName : Form
    {
        public f_siteserverName()
        {
            InitializeComponent();
        }

        private void setRegistry(string registryValue, object Value)
        {
            Microsoft.Win32.RegistryKey key;

            try
            {
                key = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("Software\\SMSMarshall\\PatchMaster");
                key.SetValue(registryValue, Value);
                key.Close();
            }
            catch (Exception e)
            {

            }
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            globalObjects.GlobalClass.serverName = tb_siteserverName.Text;

            setRegistry("PatchSiteServer", globalObjects.GlobalClass.serverName); // Store the site server name in the registry

            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
