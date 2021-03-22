using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_praktika_7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void button1_Click(object sender, EventArgs e)
        {
          dataGridView1.RowCount = 5; 
          dataGridView1.ColumnCount = 5; 
          int[,] a = new int[5, 5]; 
          int i,j,i_n,j_n;
          i_n = 0;
          j_n = 0;
          Random rand = new Random();
          for (i = 0; i < 5; i++)
            for (j = 0; j < 5; j++)
              a[i, j] = rand.Next(-100, 100);
          for (i = 0; i < 5; i++)
            for (j = 0; j < 5; j++)
              dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(a[i, j]);
          int m = int.MinValue;
          for (i = 0; i < 5; i++)
            for (j = 0; j < 5; j++)
              if ((a[i, j] > m) && (i < j)) 
              { 
                m = a[i, j];
                i_n = i;
                j_n = j;
              }
          textBox1.Text = '[' + Convert.ToString(i_n) + ',' + Convert.ToString(j_n) + ']';

        }
  }
}
