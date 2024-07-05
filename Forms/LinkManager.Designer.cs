namespace SynergicFailureAftermath
{
    partial class LinkManager
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RB_Critical = new System.Windows.Forms.RadioButton();
            this.RB_Consumer = new System.Windows.Forms.RadioButton();
            this.RB_Source = new System.Windows.Forms.RadioButton();
            this.RB_Default = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeleteConnect = new System.Windows.Forms.Button();
            this.AddConnect = new System.Windows.Forms.Button();
            this.Connected_links = new System.Windows.Forms.ListBox();
            this.Avaliable_to_connect = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinksCombo = new System.Windows.Forms.ComboBox();
            this.ChangeTypeButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.показатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеУзлыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DeleteConnect);
            this.groupBox1.Controls.Add(this.AddConnect);
            this.groupBox1.Controls.Add(this.Connected_links);
            this.groupBox1.Controls.Add(this.Avaliable_to_connect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LinksCombo);
            this.groupBox1.Location = new System.Drawing.Point(12, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Редактор связей";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChangeTypeButton);
            this.groupBox2.Controls.Add(this.RB_Critical);
            this.groupBox2.Controls.Add(this.RB_Consumer);
            this.groupBox2.Controls.Add(this.RB_Source);
            this.groupBox2.Controls.Add(this.RB_Default);
            this.groupBox2.Location = new System.Drawing.Point(0, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(189, 151);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип узла";
            // 
            // RB_Critical
            // 
            this.RB_Critical.AutoSize = true;
            this.RB_Critical.Location = new System.Drawing.Point(9, 99);
            this.RB_Critical.Name = "RB_Critical";
            this.RB_Critical.Size = new System.Drawing.Size(113, 20);
            this.RB_Critical.TabIndex = 5;
            this.RB_Critical.TabStop = true;
            this.RB_Critical.Text = "Критический";
            this.RB_Critical.UseVisualStyleBackColor = true;
            // 
            // RB_Consumer
            // 
            this.RB_Consumer.AutoSize = true;
            this.RB_Consumer.Location = new System.Drawing.Point(9, 73);
            this.RB_Consumer.Name = "RB_Consumer";
            this.RB_Consumer.Size = new System.Drawing.Size(115, 20);
            this.RB_Consumer.TabIndex = 4;
            this.RB_Consumer.TabStop = true;
            this.RB_Consumer.Text = "Потребитель";
            this.RB_Consumer.UseVisualStyleBackColor = true;
            // 
            // RB_Source
            // 
            this.RB_Source.AutoSize = true;
            this.RB_Source.Location = new System.Drawing.Point(9, 47);
            this.RB_Source.Name = "RB_Source";
            this.RB_Source.Size = new System.Drawing.Size(91, 20);
            this.RB_Source.TabIndex = 3;
            this.RB_Source.TabStop = true;
            this.RB_Source.Text = "Источник";
            this.RB_Source.UseVisualStyleBackColor = true;
            // 
            // RB_Default
            // 
            this.RB_Default.AutoSize = true;
            this.RB_Default.Location = new System.Drawing.Point(9, 21);
            this.RB_Default.Name = "RB_Default";
            this.RB_Default.Size = new System.Drawing.Size(88, 20);
            this.RB_Default.TabIndex = 2;
            this.RB_Default.TabStop = true;
            this.RB_Default.Text = "Обычный";
            this.RB_Default.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(435, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Связанные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Доступные:";
            // 
            // DeleteConnect
            // 
            this.DeleteConnect.Location = new System.Drawing.Point(321, 77);
            this.DeleteConnect.Name = "DeleteConnect";
            this.DeleteConnect.Size = new System.Drawing.Size(101, 23);
            this.DeleteConnect.TabIndex = 5;
            this.DeleteConnect.Text = "Удалить";
            this.DeleteConnect.UseVisualStyleBackColor = true;
            // 
            // AddConnect
            // 
            this.AddConnect.Location = new System.Drawing.Point(321, 48);
            this.AddConnect.Name = "AddConnect";
            this.AddConnect.Size = new System.Drawing.Size(101, 23);
            this.AddConnect.TabIndex = 4;
            this.AddConnect.Text = "Добавить";
            this.AddConnect.UseVisualStyleBackColor = true;
            // 
            // Connected_links
            // 
            this.Connected_links.FormattingEnabled = true;
            this.Connected_links.ItemHeight = 16;
            this.Connected_links.Location = new System.Drawing.Point(428, 48);
            this.Connected_links.Name = "Connected_links";
            this.Connected_links.Size = new System.Drawing.Size(120, 180);
            this.Connected_links.TabIndex = 3;
            // 
            // Avaliable_to_connect
            // 
            this.Avaliable_to_connect.FormattingEnabled = true;
            this.Avaliable_to_connect.ItemHeight = 16;
            this.Avaliable_to_connect.Location = new System.Drawing.Point(195, 48);
            this.Avaliable_to_connect.Name = "Avaliable_to_connect";
            this.Avaliable_to_connect.Size = new System.Drawing.Size(120, 180);
            this.Avaliable_to_connect.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Узел:";
            // 
            // LinksCombo
            // 
            this.LinksCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LinksCombo.FormattingEnabled = true;
            this.LinksCombo.Location = new System.Drawing.Point(9, 48);
            this.LinksCombo.Name = "LinksCombo";
            this.LinksCombo.Size = new System.Drawing.Size(121, 24);
            this.LinksCombo.TabIndex = 0;
            this.LinksCombo.SelectedIndexChanged += new System.EventHandler(this.LinksCombo_SelectedIndexChanged);
            // 
            // ChangeTypeButton
            // 
            this.ChangeTypeButton.Location = new System.Drawing.Point(29, 122);
            this.ChangeTypeButton.Name = "ChangeTypeButton";
            this.ChangeTypeButton.Size = new System.Drawing.Size(101, 23);
            this.ChangeTypeButton.TabIndex = 9;
            this.ChangeTypeButton.Text = "Изменить";
            this.ChangeTypeButton.UseVisualStyleBackColor = true;
            this.ChangeTypeButton.Click += new System.EventHandler(this.ChangeTypeButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.показатьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // показатьToolStripMenuItem
            // 
            this.показатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеУзлыToolStripMenuItem});
            this.показатьToolStripMenuItem.Name = "показатьToolStripMenuItem";
            this.показатьToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.показатьToolStripMenuItem.Text = "Показать";
            // 
            // всеУзлыToolStripMenuItem
            // 
            this.всеУзлыToolStripMenuItem.Name = "всеУзлыToolStripMenuItem";
            this.всеУзлыToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.всеУзлыToolStripMenuItem.Text = "Все узлы";
            // 
            // LinkManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LinkManager";
            this.Text = "Диспетчер узлов";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddConnect;
        private System.Windows.Forms.ListBox Connected_links;
        private System.Windows.Forms.ListBox Avaliable_to_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox LinksCombo;
        private System.Windows.Forms.Button DeleteConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RB_Critical;
        private System.Windows.Forms.RadioButton RB_Consumer;
        private System.Windows.Forms.RadioButton RB_Source;
        private System.Windows.Forms.RadioButton RB_Default;
        private System.Windows.Forms.Button ChangeTypeButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem показатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеУзлыToolStripMenuItem;
    }
}