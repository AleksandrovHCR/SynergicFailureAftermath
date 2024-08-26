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
            toolStrip1 = new System.Windows.Forms.ToolStrip();
            StartButton = new System.Windows.Forms.ToolStripButton();
            toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            добавитьУзелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            удалитьузелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            загрузитьГрафToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            менеджерБазДанныхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            LinkManager = new System.Windows.Forms.ToolStripButton();
            ModellingButton = new System.Windows.Forms.ToolStripButton();
            AboutButton = new System.Windows.Forms.ToolStripButton();
            Graph_box = new System.Windows.Forms.GroupBox();
            Graph_datagrid = new System.Windows.Forms.DataGridView();
            NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Savefile = new System.Windows.Forms.SaveFileDialog();
            OpenFile = new System.Windows.Forms.OpenFileDialog();
            CreateDBDialog = new System.Windows.Forms.SaveFileDialog();
            toolStrip1.SuspendLayout();
            Graph_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Graph_datagrid).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { StartButton, toolStripDropDownButton1, LinkManager, ModellingButton, AboutButton });
            toolStrip1.Location = new System.Drawing.Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new System.Drawing.Size(1009, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // StartButton
            // 
            StartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            StartButton.Image = (System.Drawing.Image)resources.GetObject("StartButton.Image");
            StartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            StartButton.Name = "StartButton";
            StartButton.Size = new System.Drawing.Size(24, 24);
            StartButton.Text = "Начать работу";
            StartButton.Click += StartButton_Click;
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { добавитьУзелToolStripMenuItem, удалитьузелToolStripMenuItem, выходToolStripMenuItem, загрузитьГрафToolStripMenuItem, менеджерБазДанныхToolStripMenuItem });
            toolStripDropDownButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
            toolStripDropDownButton1.Text = "Программа";
            // 
            // добавитьУзелToolStripMenuItem
            // 
            добавитьУзелToolStripMenuItem.Enabled = false;
            добавитьУзелToolStripMenuItem.Name = "добавитьУзелToolStripMenuItem";
            добавитьУзелToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            добавитьУзелToolStripMenuItem.Text = "Добавить узел";
            добавитьУзелToolStripMenuItem.Click += добавитьУзелToolStripMenuItem_Click;
            // 
            // удалитьузелToolStripMenuItem
            // 
            удалитьузелToolStripMenuItem.Enabled = false;
            удалитьузелToolStripMenuItem.Name = "удалитьузелToolStripMenuItem";
            удалитьузелToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            удалитьузелToolStripMenuItem.Text = "Очистить";
            удалитьузелToolStripMenuItem.Click += удалитьузелToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Enabled = false;
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            выходToolStripMenuItem.Text = "Сохранить граф";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // загрузитьГрафToolStripMenuItem
            // 
            загрузитьГрафToolStripMenuItem.Enabled = false;
            загрузитьГрафToolStripMenuItem.Name = "загрузитьГрафToolStripMenuItem";
            загрузитьГрафToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            загрузитьГрафToolStripMenuItem.Text = "Загрузить граф";
            загрузитьГрафToolStripMenuItem.Click += загрузитьГрафToolStripMenuItem_Click;
            // 
            // менеджерБазДанныхToolStripMenuItem
            // 
            менеджерБазДанныхToolStripMenuItem.Enabled = false;
            менеджерБазДанныхToolStripMenuItem.Name = "менеджерБазДанныхToolStripMenuItem";
            менеджерБазДанныхToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            менеджерБазДанныхToolStripMenuItem.Text = "Менеджер баз данных";
            менеджерБазДанныхToolStripMenuItem.Click += менеджерБазДанныхToolStripMenuItem_Click;
            // 
            // LinkManager
            // 
            LinkManager.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            LinkManager.Enabled = false;
            LinkManager.Image = (System.Drawing.Image)resources.GetObject("LinkManager.Image");
            LinkManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            LinkManager.Name = "LinkManager";
            LinkManager.Size = new System.Drawing.Size(24, 24);
            LinkManager.Text = "Диспетчер узлов";
            LinkManager.Click += LinkManager_Click;
            // 
            // ModellingButton
            // 
            ModellingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            ModellingButton.Enabled = false;
            ModellingButton.Image = (System.Drawing.Image)resources.GetObject("ModellingButton.Image");
            ModellingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            ModellingButton.Name = "ModellingButton";
            ModellingButton.Size = new System.Drawing.Size(24, 24);
            ModellingButton.Text = "Моделирование работы системы";
            ModellingButton.Click += ModellingButton_Click;
            // 
            // AboutButton
            // 
            AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            AboutButton.Image = (System.Drawing.Image)resources.GetObject("AboutButton.Image");
            AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            AboutButton.Name = "AboutButton";
            AboutButton.Size = new System.Drawing.Size(24, 24);
            AboutButton.Text = "О программе";
            AboutButton.Click += AboutButton_Click;
            // 
            // Graph_box
            // 
            Graph_box.Controls.Add(Graph_datagrid);
            Graph_box.Enabled = false;
            Graph_box.Location = new System.Drawing.Point(15, 34);
            Graph_box.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Graph_box.Name = "Graph_box";
            Graph_box.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Graph_box.Size = new System.Drawing.Size(993, 588);
            Graph_box.TabIndex = 1;
            Graph_box.TabStop = false;
            Graph_box.Text = "Граф";
            // 
            // Graph_datagrid
            // 
            Graph_datagrid.AllowUserToDeleteRows = false;
            Graph_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Graph_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { NameColumn });
            Graph_datagrid.Location = new System.Drawing.Point(7, 21);
            Graph_datagrid.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            Graph_datagrid.Name = "Graph_datagrid";
            Graph_datagrid.ReadOnly = true;
            Graph_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            Graph_datagrid.RowHeadersWidth = 20;
            Graph_datagrid.RowTemplate.Height = 24;
            Graph_datagrid.Size = new System.Drawing.Size(982, 561);
            Graph_datagrid.TabIndex = 0;
            Graph_datagrid.ColumnAdded += Graph_datagrid_ColumnAdded;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "";
            NameColumn.MinimumWidth = 10;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 20;
            // 
            // OpenFile
            // 
            OpenFile.FileName = "openFileDialog1";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            ClientSize = new System.Drawing.Size(1009, 625);
            Controls.Add(Graph_box);
            Controls.Add(toolStrip1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            MaximizeBox = false;
            Name = "MainWindow";
            Text = "Синергетические последствия отказа";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            Graph_box.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Graph_datagrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.SaveFileDialog CreateDBDialog;
        private System.Windows.Forms.ToolStripMenuItem менеджерБазДанныхToolStripMenuItem;
    }
}

