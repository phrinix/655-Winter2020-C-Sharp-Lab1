using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class bar_form : Form
    {
        Technician[] arr;
        int x;
        public bar_form(int _x, Technician[] _arr)
        {
            InitializeComponent();
            arr = _arr;
            x = _x;
            chart_show_data();
        }

        private void chart_show_data()
        {
            for (int i = 0; i < x; i++)
            {
                CTech_data.Series[0].Points.AddXY(arr[i].Tech_name, arr[i].Time_average);
            }
            CTech_data.Series[0].IsValueShownAsLabel = true;
            CTech_data.Titles.Add("Technician Average Call Time Data");
            CTech_data.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
        }

        private void MS_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
