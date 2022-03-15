
namespace TPR_LR1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid = new System.Windows.Forms.DataGridView();
            this.numericUpDownN = new System.Windows.Forms.NumericUpDown();
            this.labelLegenda = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelS = new System.Windows.Forms.Label();
            this.numericUpDownS = new System.Windows.Forms.NumericUpDown();
            this.labelStages = new System.Windows.Forms.Label();
            this.numericUpDownStages = new System.Windows.Forms.NumericUpDown();
            this.buttonRecreateTable = new System.Windows.Forms.Button();
            this.buttonSaveData = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStages)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 198);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 50;
            this.grid.RowTemplate.Height = 29;
            this.grid.Size = new System.Drawing.Size(849, 515);
            this.grid.TabIndex = 0;
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(53, 164);
            this.numericUpDownN.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(51, 27);
            this.numericUpDownN.TabIndex = 1;
            this.numericUpDownN.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelLegenda
            // 
            this.labelLegenda.AutoSize = true;
            this.labelLegenda.Location = new System.Drawing.Point(14, 13);
            this.labelLegenda.Name = "labelLegenda";
            this.labelLegenda.Size = new System.Drawing.Size(412, 120);
            this.labelLegenda.TabIndex = 3;
            this.labelLegenda.Text = "N - число состояний системы.\r\nS - число стратегий.\r\nn - количество этапов моделир" +
    "ования.\r\n\r\nP - вероятность перехода от одного состояния к другому.\r\nR - доходнос" +
    "ть.";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(14, 166);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(34, 20);
            this.labelN.TabIndex = 4;
            this.labelN.Text = "N =";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(114, 166);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(31, 20);
            this.labelS.TabIndex = 6;
            this.labelS.Text = "S =";
            // 
            // numericUpDownS
            // 
            this.numericUpDownS.Location = new System.Drawing.Point(151, 164);
            this.numericUpDownS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownS.Name = "numericUpDownS";
            this.numericUpDownS.Size = new System.Drawing.Size(51, 27);
            this.numericUpDownS.TabIndex = 5;
            this.numericUpDownS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelStages
            // 
            this.labelStages.AutoSize = true;
            this.labelStages.Location = new System.Drawing.Point(218, 166);
            this.labelStages.Name = "labelStages";
            this.labelStages.Size = new System.Drawing.Size(31, 20);
            this.labelStages.TabIndex = 8;
            this.labelStages.Text = "n =";
            // 
            // numericUpDownStages
            // 
            this.numericUpDownStages.Location = new System.Drawing.Point(255, 164);
            this.numericUpDownStages.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownStages.Name = "numericUpDownStages";
            this.numericUpDownStages.Size = new System.Drawing.Size(51, 27);
            this.numericUpDownStages.TabIndex = 7;
            this.numericUpDownStages.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // buttonRecreateTable
            // 
            this.buttonRecreateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecreateTable.Location = new System.Drawing.Point(712, 162);
            this.buttonRecreateTable.Name = "buttonRecreateTable";
            this.buttonRecreateTable.Size = new System.Drawing.Size(149, 29);
            this.buttonRecreateTable.TabIndex = 9;
            this.buttonRecreateTable.Text = "Создать таблицу";
            this.buttonRecreateTable.UseVisualStyleBackColor = true;
            this.buttonRecreateTable.Click += new System.EventHandler(this.buttonRecreateTable_Click);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveData.Location = new System.Drawing.Point(507, 735);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(355, 29);
            this.buttonSaveData.TabIndex = 10;
            this.buttonSaveData.Text = "Вычислить";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(667, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 11;
            this.button1.Text = "Загрузить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(767, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "Входные данные |*.txt";
            // 
            // sfd
            // 
            this.sfd.FileName = "saved";
            this.sfd.Filter = "Входные данные |*.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 776);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSaveData);
            this.Controls.Add(this.buttonRecreateTable);
            this.Controls.Add(this.labelStages);
            this.Controls.Add(this.numericUpDownStages);
            this.Controls.Add(this.labelS);
            this.Controls.Add(this.numericUpDownS);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelLegenda);
            this.Controls.Add(this.numericUpDownN);
            this.Controls.Add(this.grid);
            this.MinimumSize = new System.Drawing.Size(18, 740);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дискретные марковские процессы";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label labelLegenda;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.Label labelStages;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Button buttonRecreateTable;
        private System.Windows.Forms.Button buttonSaveData;
        public System.Windows.Forms.NumericUpDown numericUpDownN;
        public System.Windows.Forms.NumericUpDown numericUpDownS;
        public System.Windows.Forms.NumericUpDown numericUpDownStages;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}

