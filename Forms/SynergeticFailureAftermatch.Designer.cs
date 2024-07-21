namespace SynergicFailureAftermath.Forms
{
    partial class SynergeticFailureAftermatch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FailureLog = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SFA_Result = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FinalCalculate = new System.Windows.Forms.Button();
            this.Calculation = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveFromSumm = new System.Windows.Forms.Button();
            this.CalculatableNotes = new System.Windows.Forms.ListBox();
            this.AddToSumm = new System.Windows.Forms.Button();
            this.SelectableNotes = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultLog = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FailureLog)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultLog)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FailureLog);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Журнал отказов";
            // 
            // FailureLog
            // 
            this.FailureLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FailureLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.FailureLog.Location = new System.Drawing.Point(6, 21);
            this.FailureLog.Name = "FailureLog";
            this.FailureLog.ReadOnly = true;
            this.FailureLog.RowHeadersWidth = 51;
            this.FailureLog.RowTemplate.Height = 24;
            this.FailureLog.Size = new System.Drawing.Size(426, 399);
            this.FailureLog.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SFA_Result);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.FinalCalculate);
            this.groupBox2.Controls.Add(this.Calculation);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.RemoveFromSumm);
            this.groupBox2.Controls.Add(this.CalculatableNotes);
            this.groupBox2.Controls.Add(this.AddToSumm);
            this.groupBox2.Controls.Add(this.SelectableNotes);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(456, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(858, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Расчёт последствий";
            // 
            // SFA_Result
            // 
            this.SFA_Result.Location = new System.Drawing.Point(297, 396);
            this.SFA_Result.Name = "SFA_Result";
            this.SFA_Result.ReadOnly = true;
            this.SFA_Result.Size = new System.Drawing.Size(100, 22);
            this.SFA_Result.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 399);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Синергетические последствия отказа:";
            // 
            // FinalCalculate
            // 
            this.FinalCalculate.Location = new System.Drawing.Point(13, 361);
            this.FinalCalculate.Name = "FinalCalculate";
            this.FinalCalculate.Size = new System.Drawing.Size(353, 23);
            this.FinalCalculate.TabIndex = 13;
            this.FinalCalculate.Text = "Рассчитать синергетические последствия отказа";
            this.FinalCalculate.UseVisualStyleBackColor = true;
            this.FinalCalculate.Click += new System.EventHandler(this.FinalCalculate_Click);
            // 
            // Calculation
            // 
            this.Calculation.Location = new System.Drawing.Point(13, 332);
            this.Calculation.Name = "Calculation";
            this.Calculation.Size = new System.Drawing.Size(353, 23);
            this.Calculation.TabIndex = 12;
            this.Calculation.Text = "Рассчитать последствия";
            this.Calculation.UseVisualStyleBackColor = true;
            this.Calculation.Click += new System.EventHandler(this.Calculation_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(245, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Записи на расчёт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Доступные записи:";
            // 
            // RemoveFromSumm
            // 
            this.RemoveFromSumm.Location = new System.Drawing.Point(141, 74);
            this.RemoveFromSumm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveFromSumm.Name = "RemoveFromSumm";
            this.RemoveFromSumm.Size = new System.Drawing.Size(101, 23);
            this.RemoveFromSumm.TabIndex = 9;
            this.RemoveFromSumm.Text = "Удалить";
            this.RemoveFromSumm.UseVisualStyleBackColor = true;
            this.RemoveFromSumm.Click += new System.EventHandler(this.RemoveFromSumm_Click);
            // 
            // CalculatableNotes
            // 
            this.CalculatableNotes.FormattingEnabled = true;
            this.CalculatableNotes.ItemHeight = 16;
            this.CalculatableNotes.Location = new System.Drawing.Point(248, 35);
            this.CalculatableNotes.Name = "CalculatableNotes";
            this.CalculatableNotes.Size = new System.Drawing.Size(120, 292);
            this.CalculatableNotes.TabIndex = 2;
            // 
            // AddToSumm
            // 
            this.AddToSumm.Location = new System.Drawing.Point(141, 44);
            this.AddToSumm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddToSumm.Name = "AddToSumm";
            this.AddToSumm.Size = new System.Drawing.Size(101, 23);
            this.AddToSumm.TabIndex = 8;
            this.AddToSumm.Text = "Добавить";
            this.AddToSumm.UseVisualStyleBackColor = true;
            this.AddToSumm.Click += new System.EventHandler(this.AddToSumm_Click);
            // 
            // SelectableNotes
            // 
            this.SelectableNotes.FormattingEnabled = true;
            this.SelectableNotes.ItemHeight = 16;
            this.SelectableNotes.Location = new System.Drawing.Point(15, 35);
            this.SelectableNotes.Name = "SelectableNotes";
            this.SelectableNotes.Size = new System.Drawing.Size(120, 292);
            this.SelectableNotes.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ResultLog);
            this.groupBox3.Location = new System.Drawing.Point(403, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 410);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результаты";
            // 
            // ResultLog
            // 
            this.ResultLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.ResultLog.Location = new System.Drawing.Point(6, 21);
            this.ResultLog.Name = "ResultLog";
            this.ResultLog.ReadOnly = true;
            this.ResultLog.RowHeadersWidth = 51;
            this.ResultLog.RowTemplate.Height = 24;
            this.ResultLog.Size = new System.Drawing.Size(430, 371);
            this.ResultLog.TabIndex = 0;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Индекс результатов";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Множества";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Масштаб отказа";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Индекс записи";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Критические узлы";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отключенные потребители";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // SynergeticFailureAftermatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SynergeticFailureAftermatch";
            this.Text = "Поиск последствий отказа";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FailureLog)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView FailureLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox SelectableNotes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView ResultLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ListBox CalculatableNotes;
        private System.Windows.Forms.Button RemoveFromSumm;
        private System.Windows.Forms.Button AddToSumm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculation;
        private System.Windows.Forms.Button FinalCalculate;
        private System.Windows.Forms.TextBox SFA_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}