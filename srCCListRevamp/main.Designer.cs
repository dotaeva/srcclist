namespace srCCListRevamp
{
    partial class main
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.addResistor = new System.Windows.Forms.Button();
            this.removeResistor = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.filter_checkBox = new System.Windows.Forms.CheckBox();
            this.filter_Name = new System.Windows.Forms.TextBox();
            this.filter_Value = new System.Windows.Forms.TextBox();
            this.filter_InThread = new System.Windows.Forms.TextBox();
            this.btn_exportCSV = new System.Windows.Forms.Button();
            this.btn_importCSV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btn_help = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_voltage = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_voltage)).BeginInit();
            this.SuspendLayout();
            // 
            // addResistor
            // 
            this.addResistor.Location = new System.Drawing.Point(12, 12);
            this.addResistor.Name = "addResistor";
            this.addResistor.Size = new System.Drawing.Size(104, 23);
            this.addResistor.TabIndex = 0;
            this.addResistor.Text = "Add Resistor";
            this.addResistor.UseVisualStyleBackColor = true;
            this.addResistor.Click += new System.EventHandler(this.addResistor_Click);
            // 
            // removeResistor
            // 
            this.removeResistor.Location = new System.Drawing.Point(122, 12);
            this.removeResistor.Name = "removeResistor";
            this.removeResistor.Size = new System.Drawing.Size(161, 23);
            this.removeResistor.TabIndex = 1;
            this.removeResistor.Text = "Remove Selected Resistors";
            this.removeResistor.UseVisualStyleBackColor = true;
            this.removeResistor.Click += new System.EventHandler(this.removeResistor_Click);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(289, 12);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(81, 23);
            this.calculate.TabIndex = 2;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // container
            // 
            this.container.AutoScroll = true;
            this.container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.container.Location = new System.Drawing.Point(12, 83);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(358, 442);
            this.container.TabIndex = 3;
            // 
            // filter_checkBox
            // 
            this.filter_checkBox.AutoSize = true;
            this.filter_checkBox.Location = new System.Drawing.Point(8, 10);
            this.filter_checkBox.Name = "filter_checkBox";
            this.filter_checkBox.Size = new System.Drawing.Size(15, 14);
            this.filter_checkBox.TabIndex = 4;
            this.filter_checkBox.UseVisualStyleBackColor = true;
            this.filter_checkBox.CheckedChanged += new System.EventHandler(this.filter_checkBox_CheckedChanged);
            // 
            // filter_Name
            // 
            this.filter_Name.Location = new System.Drawing.Point(28, 7);
            this.filter_Name.Name = "filter_Name";
            this.filter_Name.ReadOnly = true;
            this.filter_Name.Size = new System.Drawing.Size(105, 20);
            this.filter_Name.TabIndex = 5;
            this.filter_Name.Text = "Name";
            this.filter_Name.TextChanged += new System.EventHandler(this.filter_Name_TextChanged);
            // 
            // filter_Value
            // 
            this.filter_Value.Location = new System.Drawing.Point(139, 7);
            this.filter_Value.Name = "filter_Value";
            this.filter_Value.ReadOnly = true;
            this.filter_Value.Size = new System.Drawing.Size(56, 20);
            this.filter_Value.TabIndex = 6;
            this.filter_Value.Text = "Value [Ω]";
            this.filter_Value.TextChanged += new System.EventHandler(this.filter_Value_TextChanged);
            // 
            // filter_InThread
            // 
            this.filter_InThread.Location = new System.Drawing.Point(201, 7);
            this.filter_InThread.Name = "filter_InThread";
            this.filter_InThread.ReadOnly = true;
            this.filter_InThread.Size = new System.Drawing.Size(105, 20);
            this.filter_InThread.TabIndex = 7;
            this.filter_InThread.Text = "InThread : [X]";
            this.filter_InThread.TextChanged += new System.EventHandler(this.filter_InThread_TextChanged);
            // 
            // btn_exportCSV
            // 
            this.btn_exportCSV.Location = new System.Drawing.Point(12, 531);
            this.btn_exportCSV.Name = "btn_exportCSV";
            this.btn_exportCSV.Size = new System.Drawing.Size(75, 23);
            this.btn_exportCSV.TabIndex = 9;
            this.btn_exportCSV.Text = "Export CSV";
            this.btn_exportCSV.UseVisualStyleBackColor = true;
            this.btn_exportCSV.Click += new System.EventHandler(this.btn_exportCSV_Click);
            // 
            // btn_importCSV
            // 
            this.btn_importCSV.Location = new System.Drawing.Point(93, 531);
            this.btn_importCSV.Name = "btn_importCSV";
            this.btn_importCSV.Size = new System.Drawing.Size(75, 23);
            this.btn_importCSV.TabIndex = 10;
            this.btn_importCSV.Text = "Import CSV";
            this.btn_importCSV.UseVisualStyleBackColor = true;
            this.btn_importCSV.Click += new System.EventHandler(this.btn_importCSV_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.filter_checkBox);
            this.panel1.Controls.Add(this.filter_Name);
            this.panel1.Controls.Add(this.filter_Value);
            this.panel1.Controls.Add(this.filter_InThread);
            this.panel1.Location = new System.Drawing.Point(12, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 36);
            this.panel1.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(312, 7);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(24, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.Text = "ID";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(174, 531);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(42, 23);
            this.btn_help.TabIndex = 13;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Voltage [V] :";
            // 
            // tb_voltage
            // 
            this.tb_voltage.DecimalPlaces = 3;
            this.tb_voltage.Location = new System.Drawing.Point(288, 534);
            this.tb_voltage.Name = "tb_voltage";
            this.tb_voltage.Size = new System.Drawing.Size(81, 20);
            this.tb_voltage.TabIndex = 0;
            this.tb_voltage.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(381, 566);
            this.Controls.Add(this.tb_voltage);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_importCSV);
            this.Controls.Add(this.btn_exportCSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.container);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.removeResistor);
            this.Controls.Add(this.addResistor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(397, 605);
            this.Name = "main";
            this.Text = "srCCList Revamped ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_voltage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addResistor;
        private System.Windows.Forms.Button removeResistor;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.CheckBox filter_checkBox;
        private System.Windows.Forms.TextBox filter_Name;
        private System.Windows.Forms.TextBox filter_Value;
        private System.Windows.Forms.TextBox filter_InThread;
        private System.Windows.Forms.Button btn_exportCSV;
        private System.Windows.Forms.Button btn_importCSV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown tb_voltage;
    }
}

