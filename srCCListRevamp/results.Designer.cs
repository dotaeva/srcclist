
namespace srCCListRevamp
{
    partial class results
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
            this.tw_results = new System.Windows.Forms.TreeView();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_resistance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_voltage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_amperage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_formula = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_showformula = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tw_results
            // 
            this.tw_results.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tw_results.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tw_results.Location = new System.Drawing.Point(0, 0);
            this.tw_results.Name = "tw_results";
            this.tw_results.Size = new System.Drawing.Size(400, 400);
            this.tw_results.TabIndex = 0;
            this.tw_results.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tw_results_AfterSelect);
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(612, 25);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(20, 20);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(406, 25);
            this.tb_name.Name = "tb_name";
            this.tb_name.ReadOnly = true;
            this.tb_name.Size = new System.Drawing.Size(200, 20);
            this.tb_name.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Resistor Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resistance [Ω]:";
            // 
            // tb_resistance
            // 
            this.tb_resistance.Location = new System.Drawing.Point(406, 64);
            this.tb_resistance.Name = "tb_resistance";
            this.tb_resistance.ReadOnly = true;
            this.tb_resistance.Size = new System.Drawing.Size(226, 20);
            this.tb_resistance.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 10;
            // 
            // tb_voltage
            // 
            this.tb_voltage.Location = new System.Drawing.Point(406, 103);
            this.tb_voltage.Name = "tb_voltage";
            this.tb_voltage.ReadOnly = true;
            this.tb_voltage.Size = new System.Drawing.Size(226, 20);
            this.tb_voltage.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Voltage [V]:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(406, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Amperage [A]:";
            // 
            // tb_amperage
            // 
            this.tb_amperage.Location = new System.Drawing.Point(406, 142);
            this.tb_amperage.Name = "tb_amperage";
            this.tb_amperage.ReadOnly = true;
            this.tb_amperage.Size = new System.Drawing.Size(226, 20);
            this.tb_amperage.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "ID:";
            // 
            // tb_formula
            // 
            this.tb_formula.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_formula.Location = new System.Drawing.Point(406, 181);
            this.tb_formula.Multiline = true;
            this.tb_formula.Name = "tb_formula";
            this.tb_formula.ReadOnly = true;
            this.tb_formula.Size = new System.Drawing.Size(226, 186);
            this.tb_formula.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Calculation:";
            // 
            // btn_showformula
            // 
            this.btn_showformula.Location = new System.Drawing.Point(406, 373);
            this.btn_showformula.Name = "btn_showformula";
            this.btn_showformula.Size = new System.Drawing.Size(226, 23);
            this.btn_showformula.TabIndex = 18;
            this.btn_showformula.Text = "Show Formula (New Window)";
            this.btn_showformula.UseVisualStyleBackColor = true;
            this.btn_showformula.Click += new System.EventHandler(this.btn_showformula_Click);
            // 
            // results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 434);
            this.Controls.Add(this.btn_showformula);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tb_formula);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_amperage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_voltage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_resistance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tw_results);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "results";
            this.Text = "Results";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tw_results;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_resistance;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_voltage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_amperage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_formula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_showformula;
    }
}