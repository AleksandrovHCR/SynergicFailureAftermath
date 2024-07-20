namespace SynergicFailureAftermath
{
    partial class AddLink
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
            this.AddNewLink = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.HowMuchToAdd = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AddAndExit = new System.Windows.Forms.Button();
            this.LinkTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewLink
            // 
            this.AddNewLink.Location = new System.Drawing.Point(6, 97);
            this.AddNewLink.Name = "AddNewLink";
            this.AddNewLink.Size = new System.Drawing.Size(87, 23);
            this.AddNewLink.TabIndex = 0;
            this.AddNewLink.Text = "Добавить";
            this.AddNewLink.UseVisualStyleBackColor = true;
            this.AddNewLink.Click += new System.EventHandler(this.AddNewLink_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.HowMuchToAdd);
            this.groupBox1.Controls.Add(this.InfoLabel);
            this.groupBox1.Controls.Add(this.AddAndExit);
            this.groupBox1.Controls.Add(this.LinkTypeComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddNewLink);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Число добавляемых узлов:";
            // 
            // HowMuchToAdd
            // 
            this.HowMuchToAdd.Location = new System.Drawing.Point(208, 54);
            this.HowMuchToAdd.Name = "HowMuchToAdd";
            this.HowMuchToAdd.Size = new System.Drawing.Size(71, 22);
            this.HowMuchToAdd.TabIndex = 5;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(6, 78);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(141, 16);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Количество узлов: 0";
            // 
            // AddAndExit
            // 
            this.AddAndExit.Location = new System.Drawing.Point(99, 97);
            this.AddAndExit.Name = "AddAndExit";
            this.AddAndExit.Size = new System.Drawing.Size(167, 23);
            this.AddAndExit.TabIndex = 3;
            this.AddAndExit.Text = "Добавить и выйти";
            this.AddAndExit.UseVisualStyleBackColor = true;
            this.AddAndExit.Click += new System.EventHandler(this.AddAndExit_Click);
            // 
            // LinkTypeComboBox
            // 
            this.LinkTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LinkTypeComboBox.FormattingEnabled = true;
            this.LinkTypeComboBox.Location = new System.Drawing.Point(79, 24);
            this.LinkTypeComboBox.Name = "LinkTypeComboBox";
            this.LinkTypeComboBox.Size = new System.Drawing.Size(131, 24);
            this.LinkTypeComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип узла:";
            // 
            // AddLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 148);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddLink";
            this.Text = "Новый узел";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox LinkTypeComboBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button AddAndExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox HowMuchToAdd;
    }
}