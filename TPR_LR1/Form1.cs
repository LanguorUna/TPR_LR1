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

        private void createModel()
        {
            int N = Convert.ToInt32(numericUpDownN.Value);
            int S = Convert.ToInt32(numericUpDownS.Value);

            var strategies = new List<Strategy>();
            for (int str = 0; str < S; str++)
            {
                var P = new double[N, N];
                var R = new double[N, N];
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        P[i, j] = Convert.ToDouble(grid.Rows[i * N + j].Cells[str * 2].Value);
                        R[i, j] = Convert.ToDouble(grid.Rows[i * N + j].Cells[str * 2 + 1].Value);
                    }
                }

                strategies.Add(new Strategy(R, P, N));
            }
            
            var model = new Model() { stages = Convert.ToInt32(numericUpDownStages.Value), strategies = strategies };
            model.calculate();

        }

        private void buttonSaveData_Click(object sender, EventArgs e)
        {
            createModel();
        }
    }
}
