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
    public partial class FirstNumberOfNPowerOfTwoGraphicForm : Form
    {
        public FirstNumberOfNPowerOfTwoGraphicForm()
        {
            InitializeComponent();
        }

        private void BuildGraphicToolStripMenuItemClick(object sender, EventArgs e)
        {
           ClearGraphic();
           int numberOfPower;
           if(IsNeedToBuildEmptyGraphic)
           {
                SetDefaultParametresOfNumbers();
           }
           else if(int.TryParse(textBox.Text, out numberOfPower))
           {
                CountNumbers.FillCounters(numberOfPower);
           }
           PrintParametres();
        }
        
        private void ClearGraphicToolStripMenuItemClick(object sender, EventArgs e)
        {
            ClearGraphic();
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            if(MessageBox.Show(Config.EXIT_CLARIFICATION_TEXT,Config.WARNING_WINDOW_NAME_TEXT,MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void TextBoxKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
            {
                BuildGraphicToolStripMenuItemClick(sender, null);
            }
        }

        private void ClearGraphic()
        {
            for (int i = 0; i < 9; i++)
            {
                CountNumbers.digitsArray[i] = 0;
                this.chart.Series[i].Points.Clear();
            }
        }

        private bool IsNeedToBuildEmptyGraphic()
        {
            return textBox.Text == Config.RESET_COMMAND_TEXT ? true : false;
        }
        private void SetDefaultParametresOfNumbers()
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
    }
    struct Config
    {
        public static string RESET_COMMAND_TEXT = "";
        public static string EXIT_CLARIFICATION_TEXT = "Exit?";
        public static string WARNING_WINDOW_NAME_TEXT = "Warning!";
    }
}