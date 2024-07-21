namespace SynergicFailureAftermath.Forms
{
    partial class Modelling
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
            this.UseSubsets = new System.Windows.Forms.CheckBox();
            this.CriticalLinks = new System.Windows.Forms.GroupBox();
            this.RepairLink = new System.Windows.Forms.Button();
            this.BreakLink = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Critical_broken = new System.Windows.Forms.ListBox();
            this.Critical_working = new System.Windows.Forms.ListBox();
            this.CancelModelling = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SourceList = new System.Windows.Forms.DataGridView();
            this.DGWSourceIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGWConnectedToSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartModelling = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LinksInstanceGrid = new System.Windows.Forms.DataGridView();
            this.LinkInstanceIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkInstanceType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LinkInstanceInstance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.расчитатьПоследствияОтказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.провестиРазбиениеМножестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.CriticalLinks.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceList)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LinksInstanceGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.UseSubsets);
            this.groupBox1.Controls.Add(this.CriticalLinks);
            this.groupBox1.Controls.Add(this.CancelModelling);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.StartModelling);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные по узлам";
            // 
            // UseSubsets
            // 
            this.UseSubsets.AutoSize = true;
            this.UseSubsets.Location = new System.Drawing.Point(276, 356);
            this.UseSubsets.Name = "UseSubsets";
            this.UseSubsets.Size = new System.Drawing.Size(126, 36);
            this.UseSubsets.TabIndex = 5;
            this.UseSubsets.Text = "Использовать \r\nподмножества";
            this.UseSubsets.UseVisualStyleBackColor = true;
            this.UseSubsets.CheckedChanged += new System.EventHandler(this.UseSubsets_CheckedChanged);
            // 
            // CriticalLinks
            // 
            this.CriticalLinks.Controls.Add(this.RepairLink);
            this.CriticalLinks.Controls.Add(this.BreakLink);
            this.CriticalLinks.Controls.Add(this.label2);
            this.CriticalLinks.Controls.Add(this.label1);
            this.CriticalLinks.Controls.Add(this.Critical_broken);
            this.CriticalLinks.Controls.Add(this.Critical_working);
            this.CriticalLinks.Location = new System.Drawing.Point(6, 201);
            this.CriticalLinks.Name = "CriticalLinks";
            this.CriticalLinks.Size = new System.Drawing.Size(400, 149);
            this.CriticalLinks.TabIndex = 4;
            this.CriticalLinks.TabStop = false;
            this.CriticalLinks.Text = "Критические узлы";
            // 
            // RepairLink
            // 
            this.RepairLink.Location = new System.Drawing.Point(149, 73);
            this.RepairLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepairLink.Name = "RepairLink";
            this.RepairLink.Size = new System.Drawing.Size(101, 23);
            this.RepairLink.TabIndex = 7;
            this.RepairLink.Text = "Удалить";
            this.RepairLink.UseVisualStyleBackColor = true;
            this.RepairLink.Click += new System.EventHandler(this.RepairLink_Click);
            // 
            // BreakLink
            // 
            this.BreakLink.Location = new System.Drawing.Point(149, 43);
            this.BreakLink.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BreakLink.Name = "BreakLink";
            this.BreakLink.Size = new System.Drawing.Size(101, 23);
            this.BreakLink.TabIndex = 6;
            this.BreakLink.Text = "Добавить";
            this.BreakLink.UseVisualStyleBackColor = true;
            this.BreakLink.Click += new System.EventHandler(this.BreakLink_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Сломанные:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Работающие:";
            // 
            // Critical_broken
            // 
            this.Critical_broken.FormattingEnabled = true;
            this.Critical_broken.ItemHeight = 16;
            this.Critical_broken.Location = new System.Drawing.Point(274, 43);
            this.Critical_broken.Name = "Critical_broken";
            this.Critical_broken.Size = new System.Drawing.Size(120, 100);
            this.Critical_broken.TabIndex = 1;
            // 
            // Critical_working
            // 
            this.Critical_working.FormattingEnabled = true;
            this.Critical_working.ItemHeight = 16;
            this.Critical_working.Location = new System.Drawing.Point(6, 43);
            this.Critical_working.Name = "Critical_working";
            this.Critical_working.Size = new System.Drawing.Size(120, 100);
            this.Critical_working.TabIndex = 0;
            // 
            // CancelModelling
            // 
            this.CancelModelling.Location = new System.Drawing.Point(6, 388);
            this.CancelModelling.Name = "CancelModelling";
            this.CancelModelling.Size = new System.Drawing.Size(264, 26);
            this.CancelModelling.TabIndex = 3;
            this.CancelModelling.Text = "Откатить состояние\r\n";
            this.CancelModelling.UseVisualStyleBackColor = true;
            this.CancelModelling.Click += new System.EventHandler(this.CancelModelling_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SourceList);
            this.groupBox3.Location = new System.Drawing.Point(6, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 174);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Источники";
            // 
            // SourceList
            // 
            this.SourceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SourceList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGWSourceIndex,
            this.DGWConnectedToSource});
            this.SourceList.Location = new System.Drawing.Point(6, 21);
            this.SourceList.Name = "SourceList";
            this.SourceList.ReadOnly = true;
            this.SourceList.RowHeadersWidth = 51;
            this.SourceList.RowTemplate.Height = 24;
            this.SourceList.Size = new System.Drawing.Size(394, 150);
            this.SourceList.TabIndex = 0;
            // 
            // DGWSourceIndex
            // 
            this.DGWSourceIndex.HeaderText = "Индекс узла-источника";
            this.DGWSourceIndex.MinimumWidth = 6;
            this.DGWSourceIndex.Name = "DGWSourceIndex";
            this.DGWSourceIndex.ReadOnly = true;
            this.DGWSourceIndex.Width = 125;
            // 
            // DGWConnectedToSource
            // 
            this.DGWConnectedToSource.HeaderText = "Подключенные узлы";
            this.DGWConnectedToSource.MinimumWidth = 6;
            this.DGWConnectedToSource.Name = "DGWConnectedToSource";
            this.DGWConnectedToSource.ReadOnly = true;
            this.DGWConnectedToSource.Width = 125;
            // 
            // StartModelling
            // 
            this.StartModelling.Location = new System.Drawing.Point(6, 356);
            this.StartModelling.Name = "StartModelling";
            this.StartModelling.Size = new System.Drawing.Size(264, 26);
            this.StartModelling.TabIndex = 1;
            this.StartModelling.Text = "Начать моделирование";
            this.StartModelling.UseVisualStyleBackColor = true;
            this.StartModelling.Click += new System.EventHandler(this.StartModelling_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LinksInstanceGrid);
            this.groupBox2.Location = new System.Drawing.Point(418, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 426);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Состояние";
            // 
            // LinksInstanceGrid
            // 
            this.LinksInstanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LinksInstanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LinkInstanceIndex,
            this.LinkInstanceType,
            this.LinkInstanceInstance});
            this.LinksInstanceGrid.Location = new System.Drawing.Point(0, 21);
            this.LinksInstanceGrid.Name = "LinksInstanceGrid";
            this.LinksInstanceGrid.ReadOnly = true;
            this.LinksInstanceGrid.RowHeadersWidth = 51;
            this.LinksInstanceGrid.RowTemplate.Height = 24;
            this.LinksInstanceGrid.Size = new System.Drawing.Size(527, 399);
            this.LinksInstanceGrid.TabIndex = 0;
            // 
            // LinkInstanceIndex
            // 
            this.LinkInstanceIndex.HeaderText = "Индекс узла";
            this.LinkInstanceIndex.MinimumWidth = 6;
            this.LinkInstanceIndex.Name = "LinkInstanceIndex";
            this.LinkInstanceIndex.ReadOnly = true;
            this.LinkInstanceIndex.Width = 125;
            // 
            // LinkInstanceType
            // 
            this.LinkInstanceType.HeaderText = "Тип узла";
            this.LinkInstanceType.MinimumWidth = 6;
            this.LinkInstanceType.Name = "LinkInstanceType";
            this.LinkInstanceType.ReadOnly = true;
            this.LinkInstanceType.Width = 125;
            // 
            // LinkInstanceInstance
            // 
            this.LinkInstanceInstance.HeaderText = "Состояние узла";
            this.LinkInstanceInstance.MinimumWidth = 6;
            this.LinkInstanceInstance.Name = "LinkInstanceInstance";
            this.LinkInstanceInstance.ReadOnly = true;
            this.LinkInstanceInstance.Width = 125;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.расчитатьПоследствияОтказовToolStripMenuItem,
            this.провестиРазбиениеМножестваToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // расчитатьПоследствияОтказовToolStripMenuItem
            // 
            this.расчитатьПоследствияОтказовToolStripMenuItem.Name = "расчитатьПоследствияОтказовToolStripMenuItem";
            this.расчитатьПоследствияОтказовToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.расчитатьПоследствияОтказовToolStripMenuItem.Text = "Расчитать последствия отказов";
            this.расчитатьПоследствияОтказовToolStripMenuItem.Click += new System.EventHandler(this.расчитатьПоследствияОтказовToolStripMenuItem_Click);
            // 
            // провестиРазбиениеМножестваToolStripMenuItem
            // 
            this.провестиРазбиениеМножестваToolStripMenuItem.Name = "провестиРазбиениеМножестваToolStripMenuItem";
            this.провестиРазбиениеМножестваToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.провестиРазбиениеМножестваToolStripMenuItem.Text = "Провести разбиение множества";
            this.провестиРазбиениеМножестваToolStripMenuItem.Click += new System.EventHandler(this.провестиРазбиениеМножестваToolStripMenuItem_Click);
            // 
            // Modelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Modelling";
            this.Text = "Моделирование работы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.CriticalLinks.ResumeLayout(false);
            this.CriticalLinks.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SourceList)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LinksInstanceGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView LinksInstanceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkInstanceIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkInstanceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LinkInstanceInstance;
        private System.Windows.Forms.Button StartModelling;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView SourceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGWSourceIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGWConnectedToSource;
        private System.Windows.Forms.Button CancelModelling;
        private System.Windows.Forms.GroupBox CriticalLinks;
        private System.Windows.Forms.ListBox Critical_broken;
        private System.Windows.Forms.ListBox Critical_working;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RepairLink;
        private System.Windows.Forms.Button BreakLink;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem расчитатьПоследствияОтказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem провестиРазбиениеМножестваToolStripMenuItem;
        private System.Windows.Forms.CheckBox UseSubsets;
    }
}