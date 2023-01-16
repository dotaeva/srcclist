using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srCCListRevamp
{
    public partial class helpform : Form
    {
        public helpform()
        {
            InitializeComponent();
            this.Height = (this.Height - this.ClientSize.Height) + tw_selector.Height;
            cb_debug.Checked = main.debug ? true : false;
        }

        private void tw_selector_AfterSelect(object sender, TreeViewEventArgs e)
        {
            cb_debug.Visible = tw_selector.SelectedNode.Text == "Home" ? true : false;
            lbl_title.Text = tw_selector.SelectedNode.Text;

            switch (tw_selector.SelectedNode.Text)
            {
                case "Home":
                    {
                        lbl_text.Text = "Welcome to the help page.";
                        break;
                    }
                case "Calculate":
                    {
                        lbl_text.Text = "Calculates the circuit.\n\n" +
                                        "In order to do so, you need at least one (1) resistor with a total resistance greater than 0 and a valid circuit.\n\n" +
                                        "*Valid circuit equals to any circuit that has a valid InThread values and can be calculated.";
                        break;
                    }
                case "Voltage":
                    {
                        lbl_text.Text = "Allows user to set the voltage of the circuit. This value has to be greater than 0 in order for the calculation to work.";
                        break;
                    }
                case "Resistor":
                    {
                        lbl_text.Text = "Resistor has four (4) main values:\n" +
                                        "   - Name\n" +
                                        "   - Value\n" +
                                        "   - InThread\n" +
                                        "   - ID";
                        break;
                    }
                case "Remove Selected Resistors":
                    {
                        lbl_text.Text = "Allows the user to remove resistors that are checked.";
                        break;
                    }
                case "Add Resistor":
                    {
                        lbl_text.Text = "Allows the user to create a new resistor.";
                        break;
                    }
                case "Name":
                    {
                        lbl_text.Text = "Allows the user to set a custom name to the resistor.";
                        break;
                    }
                case "Value":
                    {
                        lbl_text.Text = "Allows the user to set Value (Resistance, Ω) to the resistor.";
                        break;
                    }
                case "InThread":
                    {
                        lbl_text.Text = "Allows the user to set where is the exact resistor placed.\n\n" +
                                        "InThread is divided into 2 parts: [Parent Name]:[Thread]\n\n" +
                                        "Parent Name: Name of the parent the resistor is located in.\n" +
                                        "Thread: Thread the resistor is located it.\n\n" +
                                        "In order to create serial connection, both resistors have to have the same parent and the same InThread.\n" +
                                        "E.g. Resistor 1 has InThread [BASE:], Resistor 2 has also InThread [BASE:]. These 2 are now in serial connection.\n\n" +
                                        "In order to create parallel connection, both resistors have to have the same parent, but different InThread.\n" +
                                        "E.g. Resistor 1 has InThread[BASE:A], Resistor 2 has also InThread[BASE:B].These 2 are now in parallel connection.\n\n" +
                                        "Examples of InThreads can be found in folders \"Serial\" and \"Parallel\" in the program directory.";
                        break;
                    }
                case "BASE:":
                    {
                        lbl_text.Text = "A dummy.\n\n" +
                                        "This object is used as main thread and allows user to place other resistors on it.\n" +
                                        "This object has no calculating value and only serves as a dummy.\n" +
                                        "Resistors placed in BASE: do not have to specify thread and can leave their InThread at [BASE:], unless they are meant to be calculated in parallel;" +
                                        " then their InThreads would, for example, equal to [BASE:A] and [BASE:B].";
                        break;
                    }
                case "ID":
                    {
                        lbl_text.Text = "Automagically generated value used for calculation. Allows each resistor to be unique.";
                        break;
                    }
                case "CSV":
                    {
                        lbl_text.Text = "CSV options of the program.";
                        break;
                    }
                case "Import":
                    {
                        lbl_text.Text = "Allows the user to import .csv file of the circuit generated by the program.";
                        break;
                    }
                case "Export":
                    {
                        lbl_text.Text = "Allows the user to export created circuit into .csv file.";
                        break;
                    }
            }
        }

        private void cb_debug_CheckedChanged(object sender, EventArgs e)
        {
            main.debug = cb_debug.Checked;
        }
    }
}
