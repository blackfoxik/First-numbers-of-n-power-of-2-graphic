using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graphic
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void построитьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Clear();
           int numberOfPower;
           if(textBox.Text == "")
           {
                SetDefaultParametres();
                PrintParametres();
           }
           else if(int.TryParse(textBox.Text, out numberOfPower))
           {
                CountNumbers.FillCounters(numberOfPower);
                PrintParametres();
           }
        }
        

        private void очиститьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Выйти?","Внимание!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
        private void SetDefaultParametres()
        {
            for (int i = 0; i < 9; i++) CountNumbers.digitsArray[i] = 0;
        }
        private void PrintParametres()
        {
            for(int i = 0; i < 9; i++)
            {
                this.chart.Series[i].Points.Add(CountNumbers.digitsArray[i]);
                chart.Series[i]["PointWidth"] = "2.0";
                chart.Series[i].IsValueShownAsLabel = true;

            }
        }
        private void Clear()
        {
            for( int i = 0; i < 9; i++)
            {
                CountNumbers.digitsArray[i] = 0;
                this.chart.Series[i].Points.Clear();
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == (char)Keys.Enter)
            {
                построитьГрафикToolStripMenuItem_Click(sender, null);
            }
        }
    }
}
