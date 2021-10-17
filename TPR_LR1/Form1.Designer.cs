
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
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStages)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.Color.Ivory;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 182);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 50;
            this.grid.RowTemplate.Height = 29;
            this.grid.Size = new System.Drawing.Size(849, 515);
            this.grid.TabIndex = 0;
            // 
            // numericUpDownN
            // 
            this.numericUpDownN.Location = new System.Drawing.Point(53, 149);
            this.numericUpDownN.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownN.Name = "numericUpDownN";
            this.numericUpDownN.Size = new System.Drawing.Size(51, 27);
            this.numericUpDownN.TabIndex = 1;
            this.numericUpDownN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelLegenda
            // 
            this.labelLegenda.AutoSize = true;
            this.labelLegenda.Location = new System.Drawing.Point(14, 13);
            this.labelLegenda.Name = "labelLegenda";
            this.labelLegenda.Size = new System.Drawing.Size(36, 20);
            this.labelLegenda.TabIndex = 3;
            this.labelLegenda.Text = "Text";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(14, 151);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(34, 20);
            this.labelN.TabIndex = 4;
            this.labelN.Text = "N =";
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Location = new System.Drawing.Point(114, 151);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(31, 20);
            this.labelS.TabIndex = 6;
            this.labelS.Text = "S =";
            // 
            // numericUpDownS
            // 
            this.numericUpDownS.Location = new System.Drawing.Point(151, 149);
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
            this.labelStages.Location = new System.Drawing.Point(218, 151);
            this.labelStages.Name = "labelStages";
            this.labelStages.Size = new System.Drawing.Size(31, 20);
            this.labelStages.TabIndex = 8;
            this.labelStages.Text = "n =";
            // 
            // numericUpDownStages
            // 
            this.numericUpDownStages.Location = new System.Drawing.Point(255, 149);
            this.numericUpDownStages.Minimum = new decimal(new int[] {
            3,
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
            this.buttonRecreateTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecreateTable.Location = new System.Drawing.Point(713, 142);
            this.buttonRecreateTable.Name = "buttonRecreateTable";
            this.buttonRecreateTable.Size = new System.Drawing.Size(148, 29);
            this.buttonRecreateTable.TabIndex = 9;
            this.buttonRecreateTable.Text = "Создать таблицу";
            this.buttonRecreateTable.UseVisualStyleBackColor = true;
            this.buttonRecreateTable.Click += new System.EventHandler(this.buttonRecreateTable_Click);
            // 
            // buttonSaveData
            // 
            this.buttonSaveData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveData.Location = new System.Drawing.Point(713, 735);
            this.buttonSaveData.Name = "buttonSaveData";
            this.buttonSaveData.Size = new System.Drawing.Size(148, 29);
            this.buttonSaveData.TabIndex = 10;
            this.buttonSaveData.Text = "Ок";
            this.buttonSaveData.UseVisualStyleBackColor = true;
            this.buttonSaveData.Click += new System.EventHandler(this.buttonSaveData_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 776);
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.NumericUpDown numericUpDownN;
        private System.Windows.Forms.Label labelLegenda;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.NumericUpDown numericUpDownS;
        private System.Windows.Forms.Label labelStages;
        private System.Windows.Forms.NumericUpDown numericUpDownStages;
        private System.Windows.Forms.Label S;
        private System.Windows.Forms.Button buttonRecreateTable;
        private System.Windows.Forms.Button buttonSaveData;
    }
}

