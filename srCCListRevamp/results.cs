using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srCCListRevamp
{
    public partial class results : Form
    {
        public results()
        {
            InitializeComponent();

            this.Height = (this.Height - this.ClientSize.Height) + tw_results.Height;

            main.workList[main.workList.Count - 1].name = "Circuit";     //rename whole circuit to "circuit" for clarity reasons
            main.workList.RemoveAt(0);                                   //remove base

            main.resistor[] arrayWorkList = main.workList.ToArray();     //create array out of list

            for (int i = arrayWorkList.Count() - 1; i > -1; i--)
            {
                string tw_label = string.Format("[{0}] {1}", arrayWorkList[i].ID.ToString(), arrayWorkList[i].name);
                if (arrayWorkList[i].locatedIn == -1337) { tw_results.Nodes.Add(arrayWorkList[i].ID.ToString(), tw_label); }
                else { SearchAndAdd(arrayWorkList[i].locatedIn.ToString(), arrayWorkList[i].ID.ToString(), tw_label); }
            }

        }

        public void SearchAndAdd(string searchKey, string newValue, string newText)
        {
            TreeNode[] list = tw_results.Nodes.Find(searchKey, true);
            if (list.Length != 0)
            {
                list[0].Nodes.Add(newValue, newText);
            }
        }

        private void tw_results_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tw_results.SelectedNode != null)
            {
                var rinfo = main.workList.Find(x => x.ID == int.Parse(tw_results.SelectedNode.Name));

                tb_name.Text = rinfo.name;
                tb_resistance.Text = rinfo.value.ToString();
                tb_voltage.Text = rinfo.voltage.ToString();
                tb_amperage.Text = rinfo.amperage.ToString();
                tb_id.Text = rinfo.ID.ToString();
                tb_formula.Text = rinfo.formula;
            }
        }

        private void btn_showformula_Click(object sender, EventArgs e)
        {
            var rinfo = main.workList.Find(x => x.ID == int.Parse(tw_results.SelectedNode.Name));
            MessageBox.Show(this, rinfo.formula, rinfo.name + " [Calculation process]");
        }
    }
}
