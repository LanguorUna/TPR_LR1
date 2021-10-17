using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPR_LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            labelLegenda.Text = "N - число состояний системы.\nS - число стратегий.\nn - количество этапов моделирования";
        }
        private void RecreateTable(int N, int S)
        {
            // столбцы (стратегии)
            grid.Columns.Clear();

            var template = new DataGridViewTextBoxColumn();

            for (int i = 1; i <= S; i++)
            {
                grid.Columns.Add($"P{i}", $"P{i}");
                grid.Columns.Add($"R{i}", $"R{i}");
            }
            grid.RowHeadersWidth = 80;
            // строки (стратегии)
            grid.Rows.Clear();
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= N; j++)
                {
                    var idx = grid.Rows.Add();
                    grid.Rows[idx].HeaderCell.Value = $"{i}->{j}";
                }
            }
        }

        private void buttonRecreateTable_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(numericUpDownN.Value);
            int S = Convert.ToInt32(numericUpDownS.Value);
            int n = Convert.ToInt32(numericUpDownStages.Value);
     
            RecreateTable(N, S);
        }

        private double[,] createModel()
        {
            double[,] model = new double[grid.Rows.Count-1, grid.Columns.Count]; 

            for (int i = 0; i < grid.Rows.Count-1; i++)
            {
                for (int j = 0; j < grid.Rows[i].Cells.Count; j++)
                {
                    model[i, j] = Convert.ToDouble(grid.Rows[i].Cells[j].Value);
                }
            }
            return model;
        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            double[,] model = createModel();
            MessageBox.Show(model.ToString());
        }
    }
}
