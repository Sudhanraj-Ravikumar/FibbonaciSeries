using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibbonaciSeries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.Items?.Count != 0 )
            {
                listView1.Clear();
            }
            try
            {
                string number = textBox1.Text.ToString();
                int n = int.Parse(number);
                FibbonaciMethod fibonnaciseries = new FibbonaciMethod();
                List<int> FS = fibonnaciseries.GetFibbonnaciSolution(n);
                foreach (var item in FS)
                {
                    listView1.Items.Add(item.ToString());
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Enter Valid Number");
            }
            
        }
    }
}
