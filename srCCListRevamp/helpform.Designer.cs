
namespace srCCListRevamp
{
    partial class helpform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Calculate");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Voltage");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("BASE:");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Add Resistor");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Remove Selected Resistors");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Name");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Value");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("InThread");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ID");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Resistor", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Import");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Export");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("CSV", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Home", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode10,
            treeNode13});
            this.tw_selector = new System.Windows.Forms.TreeView();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_text = new System.Windows.Forms.Label();
            this.cb_debug = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tw_selector
            // 
            this.tw_selector.Location = new System.Drawing.Point(0, 0);
            this.tw_selector.Name = "tw_selector";
            treeNode1.Name = "Uzel21";
            treeNode1.Text = "Calculate";
            treeNode2.Name = "Uzel14";
            treeNode2.Text = "Voltage";
            treeNode3.Name = "Uzel22";
            treeNode3.Text = "BASE:";
            treeNode4.Name = "Uzel0";
            treeNode4.Text = "Add Resistor";
            treeNode5.Name = "Uzel1";
            treeNode5.Text = "Remove Selected Resistors";
            treeNode6.Name = "Uzel6";
            treeNode6.Text = "Name";
            treeNode7.Name = "Uzel7";
            treeNode7.Text = "Value";
            treeNode8.Name = "Uzel8";
            treeNode8.Text = "InThread";
            treeNode9.Name = "Uzel9";
            treeNode9.Text = "ID";
            treeNode10.Name = "Uzel2";
            treeNode10.Text = "Resistor";
            treeNode11.Name = "Uzel10";
            treeNode11.Text = "Import";
            treeNode12.Name = "Uzel11";
            treeNode12.Text = "Export";
            treeNode13.Name = "Uzel3";
            treeNode13.Text = "CSV";
            treeNode14.Name = "Uzel13";
            treeNode14.Text = "Home";
            this.tw_selector.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode14});
            this.tw_selector.Size = new System.Drawing.Size(207, 344);
            this.tw_selector.TabIndex = 0;
            this.tw_selector.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tw_selector_AfterSelect);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_title.Location = new System.Drawing.Point(212, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(108, 24);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "Help Page";
            // 
            // lbl_text
            // 
            this.lbl_text.Location = new System.Drawing.Point(213, 48);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(389, 296);
            this.lbl_text.TabIndex = 2;
            this.lbl_text.Text = "Welcome to the help page.";
            // 
            // cb_debug
            // 
            this.cb_debug.AutoSize = true;
            this.cb_debug.Location = new System.Drawing.Point(216, 78);
            this.cb_debug.Name = "cb_debug";
            this.cb_debug.Size = new System.Drawing.Size(124, 17);
            this.cb_debug.TabIndex = 5;
            this.cb_debug.Text = "Enable Debug Mode";
            this.cb_debug.UseVisualStyleBackColor = true;
            this.cb_debug.CheckedChanged += new System.EventHandler(this.cb_debug_CheckedChanged);
            // 
            // helpform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 445);
            this.Controls.Add(this.cb_debug);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tw_selector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "helpform";
            this.Text = "Help";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tw_selector;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.CheckBox cb_debug;
    }
}