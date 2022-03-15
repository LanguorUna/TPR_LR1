
namespace TPR_LR1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridQ = new System.Windows.Forms.DataGridView();
            this.gridF = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.legend = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridF)).BeginInit();
            this.SuspendLayout();
            // 
            // gridQ
            // 
            this.gridQ.AllowUserToAddRows = false;
            this.gridQ.AllowUserToDeleteRows = false;
            this.gridQ.BackgroundColor = System.Drawing.Color.White;
            this.gridQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridQ.Location = new System.Drawing.Point(12, 25);
            this.gridQ.Name = "gridQ";
            this.gridQ.ReadOnly = true;
            this.gridQ.RowHeadersWidth = 51;
            this.gridQ.RowTemplate.Height = 29;
            this.gridQ.Size = new System.Drawing.Size(436, 588);
            this.gridQ.TabIndex = 0;
            // 
            // gridF
            // 
            this.gridF.AllowUserToAddRows = false;
            this.gridF.AllowUserToDeleteRows = false;
            this.gridF.BackgroundColor = System.Drawing.Color.White;
            this.gridF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridF.Location = new System.Drawing.Point(469, 48);
            this.gridF.Name = "gridF";
            this.gridF.ReadOnly = true;
            this.gridF.RowHeadersWidth = 51;
            this.gridF.RowTemplate.Height = 29;
            this.gridF.Size = new System.Drawing.Size(718, 286);
            this.gridF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(731, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Итоговая таблица выбора стратегий";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Location = new System.Drawing.Point(469, 457);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(553, 307);
            this.panel.TabIndex = 3;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(615, 423);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(206, 28);
            this.comboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите переход";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1061, 423);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Легенда";
            // 
            // legend
            // 
            this.legend.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.legend.FormattingEnabled = true;
            this.legend.ItemHeight = 20;
            this.legend.Location = new System.Drawing.Point(1037, 457);
            this.legend.Name = "legend";
            this.legend.Size = new System.Drawing.Size(150, 304);
            this.legend.TabIndex = 7;
            this.legend.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.legend_DrawItem_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 776);
            this.Controls.Add(this.legend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridF);
            this.Controls.Add(this.gridQ);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TPR-1";
            ((System.ComponentModel.ISupportInitialize)(this.gridQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridQ;
        private System.Windows.Forms.DataGridView gridF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox legend;
    }
}