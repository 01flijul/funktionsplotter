using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FunktionsPlotter
{
    public partial class PlotterGUI : Form
    {
        QuadratischeFunktion funktion;
        public PlotterGUI()
        {
            this.funktion = new QuadratischeFunktion();
            InitializeComponent();
        }

        private void PlotterGUI_Load(object sender, EventArgs e)
        {

        }


        private void btnPlot_Click(object sender, EventArgs e)
        {

            plot();

            //clear messages
            this.tbMessages.Text = "";

            //Remove all items from the listbox
            this.lbXvalues.Items.Clear();

            double[] xval = funktion.getXValues();
            double[] yval = funktion.getYValues();

            this.lbXvalues.Items.Add("x | y");

            for (int i = 0; i < xval.Length; i++)
            {
                String eintrag = xval[i] + " | " + yval[i];
                this.lbXvalues.Items.Add(eintrag);
            }
        }

     
        private void tbA_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(this.tbA.Text);
                this.funktion.setA(val);
                this.tbMessages.Text = "";
            }
            catch (FormatException fex)
            {
                this.tbMessages.Text = fex.Message;
            }

        }

        private void tbB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(this.tbB.Text);
                this.funktion.setB(val);
                this.tbMessages.Text = "";
            }
            catch (FormatException fex)
            {
                this.tbMessages.Text = fex.Message;
            }
        }

        private void tbC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(this.tbC.Text);
                this.funktion.setC(val);
                this.tbMessages.Text = "";
            }
            catch (FormatException fex)
            {
                this.tbMessages.Text = fex.Message;
            }

        }

        private void tbStep_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double val = Convert.ToDouble(this.tbStep.Text);
                this.funktion.setStepWidth(val);
                this.tbMessages.Text = "";
            }
            catch (FormatException fex)
            {
                this.tbMessages.Text = fex.Message;
            }

        }

        private void tbXmin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double val = Convert.ToDouble(this.tbXmin.Text);
                this.funktion.setXmin(val);
                this.tbMessages.Text = "";
            }
            catch (FormatException fex)
            {
                this.tbMessages.Text = fex.Message;
            }
        }

        private void tbXmax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double val = Convert.ToDouble(this.tbXmax.Text);
                this.funktion.setXmax(val);
                this.tbMessages.Text = "";
            }
            catch (FormatException fex)
            {
                this.tbMessages.Text = fex.Message;
            }

        }



        public void plot()
        {

            Graphics functionsplot;
            functionsplot = pnl_ausgabe.CreateGraphics();
            Pen stift = new Pen(Color.Aqua, 3);
            functionsplot.DrawLine(stift, 10, 10, 100, 100);


        }

    }
}
