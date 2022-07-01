using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[,] R = new int[9,9];

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = dataGridView2.RowCount = 9;
            dataGridView1.ColumnCount = dataGridView2.ColumnCount = 9;
            Random rnd = new Random();
            for (int i = 0; i < 9; i++)
            {
                int jmin = 0;
                for (int j = 0; j < 9; j++)
                {
                    R[i, j] = rnd.Next(-10, 10);
                    dataGridView1.Rows[i].Cells[j].Value = R[i, j];
                    if (R[i, jmin] > R[i, j])
                        jmin = j;
                }
                R[i, 0] = R[i, jmin];
            }
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    dataGridView2.Rows[i].Cells[j].Value = R[i, j];
                }
            }
        }
    }
}
