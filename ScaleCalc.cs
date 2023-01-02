using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ScaleCalc
{
    public partial class ScaleCalc : Form
    {
        
        enum MetricUnits { mm, cm, m, km}

        MetricUnits input;
        MetricUnits output;

        double inputMeasure;
        double metricMeasure;
        double scale = 1.0;
        double outputScaledMeasure;

        public ScaleCalc()
        {
            InitializeComponent();
            //setting some defaults
            this.comboBox_input_units.Text = "m";
            this.comboBox_output_units.Text = "mm";
            this.numericUpDown_input_measure.Value = 100;
            this.numericUpDown_scale.Value = 75;
            //hide numericupdown arrows
            this.numericUpDown_input_measure.Controls[0].Visible = false;
        }

        private void comboBox_input_units_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox_input_units.Text)
            {
                case "mm":
                    this.input = MetricUnits.mm;
                    break;
                case "cm":
                    this.input = MetricUnits.cm;
                    break;
                case "m":
                    this.input = MetricUnits.m;
                    break;
                case "km":
                    this.input = MetricUnits.km;
                    break;
            }

            this.calculateScale();

        }

        private void comboBox_output_units_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBox_output_units.Text)
            {
                case "mm":
                    this.output = MetricUnits.mm;
                    break;
                case "cm":
                    this.output = MetricUnits.cm;
                    break;
                case "m":
                    this.output = MetricUnits.m;
                    break;
                case "km":
                    this.output = MetricUnits.km;
                    break;
                default:
                    this.output = MetricUnits.mm;
                    break;
            }

            this.calculateScale();
        }

        private void calculateScale()
        {
            switch (this.input)
            {
                case (MetricUnits.mm):
                    this.metricMeasure = this.inputMeasure * 0.001;
                    break;
                case (MetricUnits.cm):
                    this.metricMeasure = this.inputMeasure * 0.01;
                    break;
                case (MetricUnits.m):
                    this.metricMeasure = this.inputMeasure;
                    break;
                case (MetricUnits.km):
                    this.metricMeasure = this.inputMeasure * 1000;
                    break;
                default:
                    this.metricMeasure = this.inputMeasure;
                    break;
            }

            this.outputScaledMeasure = this.metricMeasure / this.scale;

            switch (this.output)
            {
                case (MetricUnits.mm):
                    this.outputScaledMeasure = this.outputScaledMeasure * 1000;
                    break;
                case (MetricUnits.cm):
                    this.outputScaledMeasure = this.outputScaledMeasure * 100;
                    break;
                case (MetricUnits.km):
                    this.outputScaledMeasure = this.outputScaledMeasure / 1000;
                    break;
                default:
                    break;

            }
            
            this.outputScaledMeasure = Math.Round(this.outputScaledMeasure, 2, MidpointRounding.ToEven);

            this.label_result.Text = outputScaledMeasure.ToString();
        }


        private void numericUpDown_scale_ValueChanged(object sender, EventArgs e)
        {
            this.scale = Convert.ToDouble(this.numericUpDown_scale.Value);

            calculateScale();
        }

        private void numericUpDown_input_measure_ValueChanged(object sender, EventArgs e)
        {
            this.inputMeasure = Convert.ToDouble(this.numericUpDown_input_measure.Value);

            this.calculateScale();
        }

        private void numericUpDown_input_measure_Enter(object sender, EventArgs e)
        {
            this.numericUpDown_input_measure.Select(0, this.numericUpDown_input_measure.Text.Length);
        }

        private void numericUpDown_scale_Enter(object sender, EventArgs e)
        {
            this.numericUpDown_scale.Select(0, this.numericUpDown_scale.Text.Length);
        }

        private void numericUpDown_input_measure_Leave(object sender, EventArgs e)
        {
            this.calculateScale();
        }

        private void numericUpDown_scale_Leave(object sender, EventArgs e)
        {
            this.calculateScale();
        }
    }
}
