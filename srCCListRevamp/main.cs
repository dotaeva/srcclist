using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srCCListRevamp
{
    public partial class main : Form
    {
        /// <summary>
        /// USER MANUAL:
        /// 
        /// Resistor name: w/e
        /// Value: float, in ohm
        /// Inthread: Either base, or the resistor it's tied to + ":letter" (e.g. R2 & R3 are in parallel from R1, which is in BASE -- R1 = BASE, R2 = R1:A, R3 = R1:B)
        /// 
        /// </summary>

        //data
        #region data
        public static bool debug = false;

        public float c_voltage;
        public float c_amperage;
        public float c_resistance;

        public class resistor
        {
            public int ID;
            public string name;
            public float value;
            public string inthread;
            public int distance;

            public float voltage;
            public float amperage;

            //calc values
            public bool SP; // s(erial) -- true | p(ararel) -- false
            public bool single;
            public int[] contains;
            public int locatedIn;

            public string formula; //aneb jak to spočítat normálně
        }

        // data lists
        List<resistor> resistorList = new List<resistor>();
        public static List<resistor> workList = new List<resistor>();
        public static List<int> recurseList = new List<int>();
        #endregion

        public main()
        {
            InitializeComponent();

            // adding BASE resistor, so paralel circuits can be made without an empty resistor (practically a dummy)
            resistorList.Add(new resistor { name = "BASE", value = 0, inthread = "BASE:", ID = 0 });
            refreshContainer();
        }

        // filtering of displayed resistors
        #region FILTERING
        private void filter_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (resistorList.Count > 1) // cosmetic edit
            {
                foreach (Control c in container.Controls)
                {
                    if (c is CheckBox)
                    {
                        ((CheckBox)c).Checked = filter_checkBox.Checked ? true : false;
                    }
                }
            } else { filter_checkBox.Checked = false; }
        }

        private void filter_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void filter_Value_TextChanged(object sender, EventArgs e)
        {

        }

        private void filter_Thread_TextChanged(object sender, EventArgs e)
        {

        }

        private void filter_InThread_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        // add or remove resistors
        #region MANAGE RESISTORS
        private void addResistor_Click(object sender, EventArgs e)
        {
            // search for lowest ID available
            for (int i = 0; i < resistorList.Count + 1; i++)
            {
                if (!resistorList.Contains(resistorList.Find(x => x.ID == i))) 
                {
                    resistorList.Add(new resistor { ID = i });
                    refreshContainer();
                    return;
                }
            }
        }

        private void removeResistor_Click(object sender, EventArgs e)
        {
            foreach (Control c in container.Controls)
            {
                if (c is CheckBox && ((CheckBox) c).Checked)
                {
                    resistorList.RemoveAll(x => x.ID == Convert.ToInt32(c.Name.Replace("resCHECK:", "")));
                }
            }

            filter_checkBox.Checked = false;
            refreshContainer();
        }
        #endregion

        // controls + displaying
        #region DISPLAYING
        private void refreshContainer()
        {
            container.Controls.Clear();

            for (int i = 0; i < resistorList.Count; i++)
            {
                // resistor checkbox
                CheckBox cb_resCHECK = new CheckBox
                {
                    Size = new Size(15, 14),
                    Location = new Point(8, 27 * (i + 1) - 17),
                    Name = "resCHECK:" + resistorList[i].ID.ToString()
                };
                container.Controls.Add(cb_resCHECK);

                // resistor name
                TextBox tb_resNAME = new TextBox
                {
                    Size = new Size(105, 20),
                    Location = new Point(28, 27 * (i + 1) - 20),
                    Text = resistorList[i].name != null ? resistorList[i].name : resistorList[i].name = "Resistor " + resistorList[i].ID.ToString(),
                    Name = "resNAME:" + resistorList[i].ID.ToString()
                };
                container.Controls.Add(tb_resNAME);
                tb_resNAME.TextChanged += new EventHandler(tb_resINFO_TextChanged);
                tb_resNAME.LostFocus += new EventHandler(tb_resINFO_LoseFocus);

                // resistor value
                NumericUpDown tb_resVALUE = new NumericUpDown
                {
                    Size = new Size(56, 20),
                    Location = new Point(139, 27 * (i + 1) - 20),
                    Text = resistorList[i].value != 0 ? resistorList[i].value.ToString() : (resistorList[i].value = 0).ToString(),
                    Name = "resVALUE:" + resistorList[i].ID.ToString(),
                    Maximum = Decimal.MaxValue
                };
                container.Controls.Add(tb_resVALUE);
                tb_resVALUE.TextChanged += new EventHandler(tb_resINFO_TextChanged);
                tb_resVALUE.LostFocus += new EventHandler(tb_resINFO_LoseFocus);

                // resistor inthread
                TextBox tb_resINTHREAD = new TextBox
                {
                    Size = new Size(105, 20),
                    Location = new Point(201, 27 * (i + 1) - 20),
                    Text = resistorList[i].inthread != null ? resistorList[i].inthread : resistorList[i].inthread = "BASE:",
                    Name = "resINTHREAD:" + resistorList[i].ID.ToString()
                };
                container.Controls.Add(tb_resINTHREAD);
                tb_resINTHREAD.TextChanged += new EventHandler(tb_resINFO_TextChanged);
                tb_resINTHREAD.LostFocus += new EventHandler(tb_resINFO_LoseFocus);

                // resistor ID
                TextBox tb_resID = new TextBox
                {
                    ReadOnly = true,
                    TextAlign = HorizontalAlignment.Center,
                    Size = new Size(24, 20),
                    Location = new Point(312, 27 * (i + 1) - 20),
                    Text = resistorList[i].ID.ToString(),
                    Name = "resID:" + resistorList[i].ID.ToString()
                };
                container.Controls.Add(tb_resID);

                // block editing base thread (ID 0)
                if (resistorList[i].ID == 0) 
                {
                    container.Controls.Remove(cb_resCHECK);
                    tb_resNAME.ReadOnly = true;
                    tb_resVALUE.ReadOnly = true;
                    tb_resVALUE.Increment = 0;
                    tb_resINTHREAD.ReadOnly = true;
                } 
            }
        }

        // controls
        private void tb_resINFO_TextChanged(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.TrimEnd(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }))
            {
                case "resNAME:":
                    {
                        int ID = int.Parse(((TextBox)sender).Name.ToString().Replace("resNAME:", ""));
                        resistorList.Find(x => x.ID == ID).name = ((TextBox)sender).Text;
                        break;
                    }
                case "resVALUE:":
                    {
                        int ID = int.Parse(((NumericUpDown)sender).Name.ToString().Replace("resVALUE:", ""));
                        resistorList.Find(x => x.ID == ID).value = String.IsNullOrEmpty(((NumericUpDown)sender).Text) ? 0 : int.Parse(((NumericUpDown)sender).Text);
                        break;
                    }
                case "resINTHREAD:":
                    {
                        int ID = int.Parse(((TextBox)sender).Name.ToString().Replace("resINTHREAD:", ""));
                        resistorList.Find(x => x.ID == ID).inthread = ((TextBox)sender).Text;
                        break;
                    }
            }
        }

        // fix on lose focus, so the whole list isn't getting reloaded
        private void tb_resINFO_LoseFocus(object sender, EventArgs e)
        {
            switch (((Control)sender).Name.TrimEnd(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }))
            {
                case "resNAME:":
                    {
                        int ID = int.Parse(((TextBox)sender).Name.ToString().Replace("resNAME:", ""));
                        ((TextBox)sender).Text = String.IsNullOrEmpty(resistorList.Find(x => x.ID == ID).name) ? 
                                                 resistorList.Find(x => x.ID == ID).name = "Resistor " + ID :
                                                 resistorList.Find(x => x.ID == ID).name;
                           
                        break;
                    }
                case "resVALUE:":
                    {
                        int ID = int.Parse(((NumericUpDown)sender).Name.ToString().Replace("resVALUE:", ""));
                        ((NumericUpDown)sender).Text = ((NumericUpDown)sender).Text == String.Empty ?
                                                       "0" :
                                                       resistorList.Find(x => x.ID == ID).value.ToString();
                        break;
                    }
                case "resINTHREAD:":
                    {
                        int ID = int.Parse(((TextBox)sender).Name.ToString().Replace("resINTHREAD:", ""));
                        ((TextBox)sender).Text = String.IsNullOrEmpty(resistorList.Find(x => x.ID == ID).inthread) ?
                                                 resistorList.Find(x => x.ID == ID).inthread = "BASE:":
                                                 resistorList.Find(x => x.ID == ID).inthread;
                        break;
                    }
            }
        }
        #endregion

        // import and export of resistor info into csv file
        #region CSV
        private void btn_importCSV_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.SpecialFolder.Personal.ToString();
                openFileDialog.RestoreDirectory = true;
                openFileDialog.DefaultExt = "csv";
                openFileDialog.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    resistorList.Clear();

                    foreach (string line in File.ReadLines(openFileDialog.FileName))
                    {
                        string[] ri = line.Split(',');
                        resistorList.Add(new resistor { ID =        Convert.ToInt32(ri[0]),
                                                        name =      ri[1],
                                                        value =     float.Parse(ri[2]),
                                                        inthread =  ri[3]});

                    }
                }
            }
            refreshContainer();
        }

        private void btn_exportCSV_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = Environment.SpecialFolder.Personal.ToString();
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.DefaultExt = "csv";
                saveFileDialog.Filter = "CSV (*.csv)|*.csv|All files (*.*)|*.*";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog.FileName);
                    foreach (resistor r in resistorList)
                    {
                        string tw = string.Format("{0},{1},{2},{3}", r.ID, r.name, r.value, r.inthread);
                        sw.WriteLine(tw);
                    }
                    sw.Close();
                }
            }
        }
        #endregion

        // whole calculation process
        #region calculation

        // calculation
        private void calculate_Click(object sender, EventArgs e)
        {
            if (resistorList.Count <= 1 || resistorList.Sum(x => x.value) <= 0) { System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ"); }
            else { calculation(); }
        }

        private void calculation()
        {
            string debug_output = "";
            string debug_output2 = "";
            c_voltage = float.Parse(tb_voltage.Text);
            workList.Clear(); //reset worklist before filling it

            try
            {
                var validDistance = distance(resistorList);
                if (validDistance != 0) { MessageBox.Show(String.Format("Invalid InThread (ID: {0})", validDistance.ToString())); return; }
                int distance_max = resistorList.Max(x => x.distance);

                // working list, separate from the main one - just for calculating purposes
                foreach (resistor x in resistorList) { workList.Add(new resistor { name = x.name, value = x.value, distance = x.distance, inthread = x.inthread, ID = x.ID, single = true, SP = false}); }

                #region RESISTANCE
                // calculating based on the distance from main thread, highest to lowest -- resistance
                for (int i = distance_max; i > -1; i--)
                {
                    debug_output2 += "DIST " + i + "\n\n";

                    // list only with resistors that have the current working distance
                    List<resistor> distanceList = new List<resistor>();
                    foreach (resistor x in workList)
                    {
                        if (x.distance == i)
                        { distanceList.Add(new resistor { name = x.name, value = x.value, distance = x.distance, ID = x.ID, inthread = x.inthread }); }
                    }

                    //string debug_output1 = "";
                    //foreach (resistor x in distanceList)
                    //{
                    //    debug_output1 += x.name + " WITH " + x.value + " IN " + x.inthread + " AT " + x.distance + " IS " + x.SP.ToString() + " AS " + x.ID + "\n";
                    //}
                    //MessageBox.Show(debug_output1);

                    List<resistor> serialList = new List<resistor>(); // another list since u cant just add entry into the current working list

                    // serial
                    foreach (resistor x in distanceList) if (x.ID != -1)
                    {
                            string nformulaTEXT = String.Format("{0}", x.name);
                            string nformulaCALC = String.Format("{0}", x.value);

                            bool pass = false;
                            string nname = x.name;
                            float nvalue = x.value;
                            List<int> cont_List = new List<int>();
                            cont_List.Add(x.ID);
                            debug_output2 += "LOGON SERI=" + x.name + " " + x.value + " " + x.inthread + " " + x.distance + " " + x.SP.ToString() + " " + x.ID + "\n";

                            foreach (resistor y in distanceList)
                            {
                                if (x.inthread == y.inthread && x.ID != -1 && y.ID != -1 && x.ID != y.ID)
                                {
                                    nformulaTEXT += String.Format(" + {0}", y.name);
                                    nformulaCALC += String.Format(" + {0}", y.value);

                                    nname += "+" + y.name;
                                    nvalue += y.value;
                                    cont_List.Add(y.ID);
                                    pass = true;
                                    debug_output2 += "PAIRED SERI=" + y.name + " " + y.value + " " + y.inthread + " " + y.distance + " " + y.SP.ToString() + " " + y.ID + "\n";
                                    y.ID = -1;
                                }
                            }
                            if (pass)
                            {
                                int nID = workList.Count();
                                int[] cont_arr = cont_List.ToArray();
                                workList.Add(new resistor 
                                { 
                                    name = nname, 
                                    value = nvalue, 
                                    distance = i, 
                                    inthread = x.inthread, 
                                    SP = true, 
                                    contains = cont_arr, 
                                    ID = nID, 
                                    locatedIn = -1337, 
                                    single = false,
                                    formula = String.Format("{0} = {1}\n{0} = {2}\n\n", nname, nformulaTEXT, nformulaCALC)
                                });
                                serialList.Add(new resistor { name = nname, value = nvalue, distance = i, inthread = x.inthread, ID = nID });
                                x.ID = -1;
                                debug_output2 += "ADDED SERI=" + nname + " " + nvalue + " " + x.inthread + " " + i + " " + nID + "\n";
                                foreach (var y in cont_List)
                                {
                                    workList.Find(z => z.ID == y).locatedIn = nID;
                                }
                            }
                    }

                    // adding seriallist into distancelist (R1 + R2 == R1R2)
                    foreach (resistor x in serialList) { distanceList.Add(new resistor { name = x.name, value = x.value, distance = i, inthread = x.inthread, ID = x.ID, SP = x.SP }); }

                    // paralel
                    foreach (resistor x in distanceList) if (x.ID != -1)
                    {
                            string nformulaTEXT = String.Format("1/((1/{0})", x.name);
                            string nformulaCALC = String.Format("1/((1/{0})", x.value);

                            bool pass = false;
                            string nname = x.name;
                            float nvalue = 1 / x.value;
                            List<int> cont_List = new List<int>();
                            cont_List.Add(x.ID);
                            debug_output2 += "LOGON PARA=" + x.name + " " + x.value + " " + x.inthread + " " + x.distance + " " + x.SP.ToString() + " " + x.ID + "\n";

                            foreach (resistor y in distanceList)
                            {
                                if (x.inthread.Split(':')[0] == y.inthread.Split(':')[0] && x.ID != -1 && y.ID != -1 && x.ID != y.ID)
                                {
                                    workList.Find(z => z.ID == x.ID).SP = true;
                                    workList.Find(z => z.ID == y.ID).SP = true;

                                    nformulaTEXT += String.Format(" + 1/({0})", y.name);
                                    nformulaCALC += String.Format(" + 1/({0})", y.name);

                                    nname += "/" + y.name;
                                    nvalue += 1 / y.value;
                                    cont_List.Add(y.ID);
                                    pass = true;
                                    debug_output2 += "PAIRED PARA=" + y.name + " " + y.value + " " + y.inthread + " " + y.distance + " " + y.SP.ToString() + " " + y.ID + "\n";
                                    y.ID = -1;
                                }
                            }
                            if (pass)
                            {
                                int nID = workList.Count();
                                int[] cont_arr = cont_List.ToArray();
                                string ninthread = workList.Find(z => z.name == x.inthread.Split(':')[0]).inthread;
                                workList.Add(new resistor 
                                { 
                                    name = String.Format("p({0})", nname), 
                                    value = 1 / nvalue, 
                                    distance = i - 1, 
                                    inthread = ninthread, SP = false, 
                                    contains = cont_arr, ID = nID, 
                                    locatedIn = -1337, 
                                    single = false,
                                    formula = String.Format("{0} = {1})\n{0} = {2})\n\n", String.Format("p({0})", nname), nformulaTEXT, nformulaCALC)
                                });
                                x.ID = -1;
                                debug_output2 += "ADDED PARA=" + String.Format("p({0})", nname) + " " + nvalue + " " + ninthread + " " + (i - 1) + " " + nID + "\n";
                                foreach (var y in cont_List)
                                {
                                    workList.Find(z => z.ID == y).locatedIn = nID;
                                }
                            }
                    }

                    // capture debug/result data
                    debug_output = "ROUND " + i + "\n";
                }
                #endregion

                c_resistance = workList.Find(x => x.locatedIn == -1337).value;
                c_amperage = c_voltage / c_resistance;
                //-1337 = whole circuit
                workList.Find(x => x.locatedIn == -1337).amperage = c_amperage;
                workList.Find(x => x.locatedIn == -1337).voltage = c_voltage;

                foreach (resistor x in workList)
                {
                    recurseList.Clear();
                    getAV(x.ID, false);
                }

                // show debug
                if (debug)
                {
                    foreach (resistor x in workList)
                    {
                        debug_output += x.name + " WITH " + x.value + " IN " + x.inthread + " AT " + x.distance + " IS " + x.SP.ToString() + " AS " + x.ID + " LOCIN " + x.locatedIn + "; A"
                            + x.amperage + " V" + x.voltage + " SINGLE: " + x.single + "\n";
                    }
                    MessageBox.Show("VOLTAGE " + c_voltage + "\n AMPERAGE " + c_amperage);
                    MessageBox.Show(debug_output);
                    MessageBox.Show(debug_output2);
                }

                //show results
                results ShowResults = new results();
                ShowResults.ShowDialog();

            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
        }

        // how far is the resistor from base thread
        public static int distance(List<resistor> resList)
        {
            foreach (resistor r in resList)
            {
                int distanceFromBASE = 0;
                string temp_inthread = r.inthread;
                if (!resList.Contains(resList.Find(x => x.name == temp_inthread.Split(':')[0])))
                {
                    return r.ID;
                }

                while (temp_inthread != "BASE:") 
                {
                    var res = resList.Find(x => x.name == temp_inthread.Split(':')[0]);
                    if (resList.Contains(res))
                    {
                        temp_inthread = res.inthread;
                        distanceFromBASE++;
                    }
                    else { break; }
                }

                r.distance = distanceFromBASE;
            }
            return 0;
        }
        public static int getAV(int resID, bool recurse)
        {   
            try
            {
                var resFIND = recurse ? workList.Find(x => x.ID == recurseList[recurseList.Count - 1]) : workList.Find(x => x.ID == resID);
                var resPARENT = workList.Find(y => y.ID == resFIND.locatedIn);

                if (workList.Contains(resPARENT))
                {
                    if (resPARENT.amperage == 0 || resPARENT.voltage == 0)
                    {
                        if (!recurse) { recurseList.Add(resFIND.ID); }
                        recurseList.Add(resFIND.locatedIn);
                        return getAV(recurseList[recurseList.Count - 1], true);
                    }
                    else
                    {
                        if (resFIND.SP) //p
                        {
                            resFIND.voltage = resPARENT.voltage;
                            resFIND.amperage = resPARENT.voltage / resFIND.value;

                            resFIND.formula += String.Format("U({0}) = U({1}) ({2}[V]) (parallel, parent voltage)\n\n", resFIND.name, resPARENT.name, resPARENT.voltage);
                            resFIND.formula += String.Format("I({0}) = U({3}) / ({0})[Ω]\nI({0}) = {1}V / {2}Ω", resFIND.name, resPARENT.voltage, resFIND.value, resPARENT.name);
                        }
                        else //s
                        {
                            resFIND.voltage = resPARENT.amperage * resFIND.value;
                            resFIND.amperage = resPARENT.amperage;

                            resFIND.formula += String.Format("U({0}) = I({1}) * ({0})[Ω]\nU({0}) = {2}A * {3}Ω\n\n", resFIND.name, resPARENT.name, resPARENT.amperage, resFIND.value);
                            resFIND.formula += String.Format("I({0}) = I({1}) ({2}A) (serial, parent amperage)", resFIND.name, resPARENT.name, resPARENT.amperage);
                        }
                        if (recurse) { recurseList.Remove(recurseList[recurseList.Count - 1]); }
                    }
                }
                if (recurseList.Count > 0) { return getAV(recurseList[recurseList.Count - 1], true); }
            }
            catch { MessageBox.Show("An error has occured while calculating Voltage and/or Amperage"); }
            return 0;
        }

        #endregion

        private void btn_help_Click(object sender, EventArgs e)
        {
            helpform HelpForm = new helpform();
            HelpForm.ShowDialog();
        }
    }
}