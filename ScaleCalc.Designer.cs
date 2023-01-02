namespace ScaleCalc
{
    partial class ScaleCalc
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
            this.label_scale_1to = new System.Windows.Forms.Label();
            this.comboBox_input_units = new System.Windows.Forms.ComboBox();
            this.comboBox_output_units = new System.Windows.Forms.ComboBox();
            this.label_result = new System.Windows.Forms.Label();
            this.numericUpDown_scale = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_input_measure = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_input_measure)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_scale_1to
            // 
            this.label_scale_1to.AutoSize = true;
            this.label_scale_1to.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_scale_1to.Location = new System.Drawing.Point(14, 26);
            this.label_scale_1to.Name = "label_scale_1to";
            this.label_scale_1to.Size = new System.Drawing.Size(33, 24);
            this.label_scale_1to.TabIndex = 0;
            this.label_scale_1to.Text = "1 :";
            this.label_scale_1to.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_input_units
            // 
            this.comboBox_input_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_input_units.FormattingEnabled = true;
            this.comboBox_input_units.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "km"});
            this.comboBox_input_units.Location = new System.Drawing.Point(182, 19);
            this.comboBox_input_units.Name = "comboBox_input_units";
            this.comboBox_input_units.Size = new System.Drawing.Size(59, 32);
            this.comboBox_input_units.TabIndex = 3;
            this.comboBox_input_units.SelectedIndexChanged += new System.EventHandler(this.comboBox_input_units_SelectedIndexChanged);
            // 
            // comboBox_output_units
            // 
            this.comboBox_output_units.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_output_units.FormattingEnabled = true;
            this.comboBox_output_units.Items.AddRange(new object[] {
            "mm",
            "cm",
            "m",
            "km"});
            this.comboBox_output_units.Location = new System.Drawing.Point(182, 20);
            this.comboBox_output_units.Name = "comboBox_output_units";
            this.comboBox_output_units.Size = new System.Drawing.Size(59, 32);
            this.comboBox_output_units.TabIndex = 4;
            this.comboBox_output_units.SelectedIndexChanged += new System.EventHandler(this.comboBox_output_units_SelectedIndexChanged);
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_result.Location = new System.Drawing.Point(14, 23);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(17, 24);
            this.label_result.TabIndex = 6;
            this.label_result.Text = "-";
            // 
            // numericUpDown_scale
            // 
            this.numericUpDown_scale.DecimalPlaces = 1;
            this.numericUpDown_scale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_scale.Location = new System.Drawing.Point(53, 24);
            this.numericUpDown_scale.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_scale.Name = "numericUpDown_scale";
            this.numericUpDown_scale.Size = new System.Drawing.Size(80, 29);
            this.numericUpDown_scale.TabIndex = 2;
            this.numericUpDown_scale.ValueChanged += new System.EventHandler(this.numericUpDown_scale_ValueChanged);
            this.numericUpDown_scale.Enter += new System.EventHandler(this.numericUpDown_scale_Enter);
            this.numericUpDown_scale.Leave += new System.EventHandler(this.numericUpDown_scale_Leave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown_input_measure);
            this.groupBox1.Controls.Add(this.comboBox_input_units);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Measure";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown_scale);
            this.groupBox2.Controls.Add(this.label_scale_1to);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 65);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scale";
            // 
            // numericUpDown_input_measure
            // 
            this.numericUpDown_input_measure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_input_measure.Location = new System.Drawing.Point(18, 20);
            this.numericUpDown_input_measure.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_input_measure.Name = "numericUpDown_input_measure";
            this.numericUpDown_input_measure.Size = new System.Drawing.Size(158, 29);
            this.numericUpDown_input_measure.TabIndex = 3;
            this.numericUpDown_input_measure.ValueChanged += new System.EventHandler(this.numericUpDown_input_measure_ValueChanged);
            this.numericUpDown_input_measure.Enter += new System.EventHandler(this.numericUpDown_input_measure_Enter);
            this.numericUpDown_input_measure.Leave += new System.EventHandler(this.numericUpDown_input_measure_Leave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_result);
            this.groupBox3.Controls.Add(this.comboBox_output_units);
            this.groupBox3.Location = new System.Drawing.Point(12, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 67);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // ScaleCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 231);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScaleCalc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ScaleCalc";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_scale)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_input_measure)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_scale_1to;
        private System.Windows.Forms.ComboBox comboBox_input_units;
        private System.Windows.Forms.ComboBox comboBox_output_units;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.NumericUpDown numericUpDown_scale;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown_input_measure;
    }
}

