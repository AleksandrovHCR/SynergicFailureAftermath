namespace SynergicFailureAftermath.Forms
{
    partial class BreakOnSubsets
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
            groupBox1 = new System.Windows.Forms.GroupBox();
            ListOfSubsets = new System.Windows.Forms.DataGridView();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            SaveTheResults = new System.Windows.Forms.SaveFileDialog();
            groupBox2 = new System.Windows.Forms.GroupBox();
            StartTheBreakage = new System.Windows.Forms.Button();
            CLinks = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            результатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            OpenFile = new System.Windows.Forms.OpenFileDialog();
            groupBox3 = new System.Windows.Forms.GroupBox();
            TestOfDB = new System.Windows.Forms.DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ListOfSubsets).BeginInit();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TestOfDB).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(ListOfSubsets);
            groupBox1.Location = new System.Drawing.Point(10, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(365, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Подмножества";
            // 
            // ListOfSubsets
            // 
            ListOfSubsets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ListOfSubsets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1, Column2 });
            ListOfSubsets.Location = new System.Drawing.Point(5, 20);
            ListOfSubsets.Name = "ListOfSubsets";
            ListOfSubsets.ReadOnly = true;
            ListOfSubsets.RowHeadersWidth = 51;
            ListOfSubsets.RowTemplate.Height = 24;
            ListOfSubsets.Size = new System.Drawing.Size(354, 364);
            ListOfSubsets.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Индекс подмножества";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Подмножество";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(StartTheBreakage);
            groupBox2.Controls.Add(CLinks);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new System.Drawing.Point(10, 420);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(365, 92);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметры";
            // 
            // StartTheBreakage
            // 
            StartTheBreakage.Location = new System.Drawing.Point(5, 64);
            StartTheBreakage.Name = "StartTheBreakage";
            StartTheBreakage.Size = new System.Drawing.Size(354, 22);
            StartTheBreakage.TabIndex = 2;
            StartTheBreakage.Text = "Разбить";
            StartTheBreakage.UseVisualStyleBackColor = true;
            StartTheBreakage.Click += StartTheBreakage_Click;
            // 
            // CLinks
            // 
            CLinks.Location = new System.Drawing.Point(5, 38);
            CLinks.Name = "CLinks";
            CLinks.ReadOnly = true;
            CLinks.Size = new System.Drawing.Size(355, 23);
            CLinks.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(5, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Все узлы:";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { результатыToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            menuStrip1.Size = new System.Drawing.Size(837, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // результатыToolStripMenuItem
            // 
            результатыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { сохранитьToolStripMenuItem, загрузитьToolStripMenuItem });
            результатыToolStripMenuItem.Name = "результатыToolStripMenuItem";
            результатыToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            результатыToolStripMenuItem.Text = "Результаты";
            результатыToolStripMenuItem.Click += результатыToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // OpenFile
            // 
            OpenFile.FileName = "OpenFile";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TestOfDB);
            groupBox3.Location = new System.Drawing.Point(381, 27);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(444, 485);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Тестирование базы данных";
            // 
            // TestOfDB
            // 
            TestOfDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TestOfDB.Location = new System.Drawing.Point(6, 20);
            TestOfDB.Name = "TestOfDB";
            TestOfDB.Size = new System.Drawing.Size(432, 459);
            TestOfDB.TabIndex = 0;
            // 
            // BreakOnSubsets
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(837, 529);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "BreakOnSubsets";
            Text = "Разбиение на подмножества";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ListOfSubsets).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TestOfDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SaveFileDialog SaveTheResults;
        private System.Windows.Forms.DataGridView ListOfSubsets;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem результатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.Button StartTheBreakage;
        private System.Windows.Forms.TextBox CLinks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView TestOfDB;
    }
}