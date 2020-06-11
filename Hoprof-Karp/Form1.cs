using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoprof_Karp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            (Controls["data"] as DataGridView).RowHeadersWidth = 40;
            (Controls["size"] as NumericUpDown).ValueChanged += Form1_ValueChanged;
            (Controls["data"] as DataGridView).EditingControlShowing += Form1_EditingControlShowing;
            initData();
        }

        private void Form1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
        }

        private void Form1_ValueChanged(object sender, EventArgs e)
        {
            initData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<int>> a = new List<List<int>>();
            var g = (Controls["data"] as DataGridView);
            int n = g.Columns.Count;
            for (int i =0; i < n; i++)
            {
                a.Add(new List<int>());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int y = 0;
                    int.TryParse(g.Rows[i].Cells[j].Value.ToString(), out y);
                    if (y != 0) {
                        if (!a[i].Contains(j))
                            a[i].Add(j);
                        if (!a[j].Contains(i))
                            a[j].Add(i);
                    }
                }
            }
            try
            {
                Controls["answer"].Text = HoproftCarp.Solve(a).ToString();
            }
            catch (ArgumentException f)
            {
                Controls["answer"].Text = "";

                Controls["Error"].Text = f.Message;
            }
            catch
            {

            }
        }

        private void initData() {
            (Controls["data"] as DataGridView).Columns.Clear();
            int size = (int)(Controls["size"] as NumericUpDown).Value;
            var data = (Controls["data"] as DataGridView).Columns;
            for (int i = 1; i <= size; i++)
            {
                data.Add(i.ToString(), i.ToString());
                if (i == size)
                {
                    data[data.Count - 1].Width = 300 - ((300 / size) * (size - 1));

                } else
                    data[data.Count - 1].Width = 300 / size;
            }
            var r = (Controls["data"] as DataGridView).Rows;

            for (int j = 0; j < size; j++)
            {
                (Controls["data"] as DataGridView).Rows.Add();
                r[j].Height = 300 / size;
                for (int i = 0; i < size; i++)
                {
                    r[j].Cells[i].Value = 0;
                    if ((i + j) % 2 == 0)
                    {
                        r[j].Cells[i].Style.BackColor = Color.White;
                    }
                    else
                    {
                        r[j].Cells[i].Style.BackColor = Color.LightGray;
                    }
                }
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar == '1' || e.KeyChar == '0' || e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
