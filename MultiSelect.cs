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
    public partial class MultiSelect : Form
    {
        public List<string> manifestList;

        public List<string> selectedItems;

        public MultiSelect()
        {
            InitializeComponent();
        }

        private void MultiSelect_Load(object sender, EventArgs e)
        {
            // Seperate out the items in selectedItems

            // Get the contents of manifestList and add it to the form

            foreach (string manifestItem in manifestList)
            {
                if (selectedItems != null)
                {
                    if (selectedItems.Count > 0)
                    {
                        if (selectedItems.Contains(manifestItem))
                        {
                            int ret = cbl_Items.Items.Add(manifestItem);

                            cbl_Items.SetItemChecked(ret, true);
                        }
                        else
                        {
                            cbl_Items.Items.Add(manifestItem);
                        }
                    }
                    else
                    {
                        cbl_Items.Items.Add(manifestItem);
                    }
                }
                else
                {
                    cbl_Items.Items.Add(manifestItem);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Return the selected items as string values

            List<string> returnList = new List<string>();

            foreach(string itemChecked in cbl_Items.CheckedItems)
            {                
                returnList.Add(itemChecked);
            }

            //globalObjects.GlobalClass.popupformManifest.Clear();

            globalObjects.GlobalClass.popupformManifest = returnList;           

            this.Close();            
        }
    }
}
