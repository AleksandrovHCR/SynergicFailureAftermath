namespace SynergicFailureAftermath
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.StartButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.добавитьУзелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьузелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьГрафToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LinkManager = new System.Windows.Forms.ToolStripButton();
            this.ModellingButton = new System.Windows.Forms.ToolStripButton();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.Graph_box = new System.Windows.Forms.GroupBox();
            this.Graph_datagrid = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Savefile = new System.Windows.Forms.SaveFileDialog();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1.SuspendLayout();
            this.Graph_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Graph_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartButton,
            this.toolStripDropDownButton1,
            this.LinkManager,
            this.ModellingButton,
            this.AboutButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1009, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // StartButton
            // 
            this.StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(29, 24);
            this.StartButton.Text = "Начать работу";
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьУзелToolStripMenuItem,
            this.удалитьузелToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.загрузитьГрафToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "Программа";
            // 
            // добавитьУзелToolStripMenuItem
            // 
            this.добавитьУзелToolStripMenuItem.Enabled = false;
            this.добавитьУзелToolStripMenuItem.Name = "добавитьУзелToolStripMenuItem";
            this.добавитьУзелToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.добавитьУзелToolStripMenuItem.Text = "Добавить узел";
            this.добавитьУзелToolStripMenuItem.Click += new System.EventHandler(this.добавитьУзелToolStripMenuItem_Click);
            // 
            // удалитьузелToolStripMenuItem
            // 
            this.удалитьузелToolStripMenuItem.Enabled = false;
            this.удалитьузелToolStripMenuItem.Name = "удалитьузелToolStripMenuItem";
            this.удалитьузелToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.удалитьузелToolStripMenuItem.Text = "Очистить";
            this.удалитьузелToolStripMenuItem.Click += new System.EventHandler(this.удалитьузелToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Enabled = false;
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.выходToolStripMenuItem.Text = "Сохранить граф";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // загрузитьГрафToolStripMenuItem
            // 
            this.загрузитьГрафToolStripMenuItem.Enabled = false;
            this.загрузитьГрафToolStripMenuItem.Name = "загрузитьГрафToolStripMenuItem";
            this.загрузитьГрафToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.загрузитьГрафToolStripMenuItem.Text = "Загрузить граф";
            this.загрузитьГрафToolStripMenuItem.Click += new System.EventHandler(this.загрузитьГрафToolStripMenuItem_Click);
            // 
            // LinkManager
            // 
            this.LinkManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LinkManager.Enabled = false;
            this.LinkManager.Image = ((System.Drawing.Image)(resources.GetObject("LinkManager.Image")));
            this.LinkManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LinkManager.Name = "LinkManager";
            this.LinkManager.Size = new System.Drawing.Size(29, 24);
            this.LinkManager.Text = "Диспетчер узлов";
            this.LinkManager.Click += new System.EventHandler(this.LinkManager_Click);
            // 
            // ModellingButton
            // 
            this.ModellingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ModellingButton.Enabled = false;
            this.ModellingButton.Image = ((System.Drawing.Image)(resources.GetObject("ModellingButton.Image")));
            this.ModellingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ModellingButton.Name = "ModellingButton";
            this.ModellingButton.Size = new System.Drawing.Size(29, 24);
            this.ModellingButton.Text = "Моделирование работы системы";
            this.ModellingButton.Click += new System.EventHandler(this.ModellingButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(29, 24);
            this.AboutButton.Text = "О программе";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Graph_box
            // 
            this.Graph_box.Controls.Add(this.Graph_datagrid);
            this.Graph_box.Enabled = false;
            this.Graph_box.Location = new System.Drawing.Point(15, 34);
            this.Graph_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Graph_box.Name = "Graph_box";
            this.Graph_box.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Graph_box.Size = new System.Drawing.Size(993, 588);
            this.Graph_box.TabIndex = 1;
            this.Graph_box.TabStop = false;
            this.Graph_box.Text = "Граф";
            // 
            // Graph_datagrid
            // 
            this.Graph_datagrid.AllowUserToDeleteRows = false;
            this.Graph_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Graph_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn});
            this.Graph_datagrid.Location = new System.Drawing.Point(7, 21);
            this.Graph_datagrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Graph_datagrid.Name = "Graph_datagrid";
            this.Graph_datagrid.ReadOnly = true;
            this.Graph_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Graph_datagrid.RowHeadersWidth = 20;
            this.Graph_datagrid.RowTemplate.Height = 24;
            this.Graph_datagrid.Size = new System.Drawing.Size(982, 561);
            this.Graph_datagrid.TabIndex = 0;
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "";
            this.NameColumn.MinimumWidth = 10;
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Width = 20;
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1009, 625);
            this.Controls.Add(this.Graph_box);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Синергетические последствия отказа";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.Graph_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Graph_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton AboutButton;
        private System.Windows.Forms.ToolStripMenuItem удалитьузелToolStripMenuItem;
        private System.Windows.Forms.GroupBox Graph_box;
        private System.Windows.Forms.ToolStripMenuItem добавитьУзелToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton StartButton;
        private System.Windows.Forms.ToolStripButton LinkManager;
        public System.Windows.Forms.DataGridView Graph_datagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.ToolStripButton ModellingButton;
        private System.Windows.Forms.SaveFileDialog Savefile;
        private System.Windows.Forms.ToolStripMenuItem загрузитьГрафToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFile;
    }
}

