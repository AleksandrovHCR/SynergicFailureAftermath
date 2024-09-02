namespace SynergicFailureAftermath.Forms
{
    partial class DatabaseViewer
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
            Links = new System.Windows.Forms.DataGridView();
            groupBox2 = new System.Windows.Forms.GroupBox();
            Subsets = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Links).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Subsets).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Links);
            groupBox1.Location = new System.Drawing.Point(14, 16);
            groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox1.Size = new System.Drawing.Size(390, 568);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Узлы";
            // 
            // Links
            // 
            Links.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Links.Location = new System.Drawing.Point(7, 29);
            Links.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Links.Name = "Links";
            Links.ReadOnly = true;
            Links.RowHeadersWidth = 51;
            Links.Size = new System.Drawing.Size(376, 531);
            Links.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(Subsets);
            groupBox2.Location = new System.Drawing.Point(410, 16);
            groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            groupBox2.Size = new System.Drawing.Size(390, 568);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Подмножества";
            // 
            // Subsets
            // 
            Subsets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Subsets.Location = new System.Drawing.Point(7, 29);
            Subsets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Subsets.Name = "Subsets";
            Subsets.ReadOnly = true;
            Subsets.RowHeadersWidth = 51;
            Subsets.Size = new System.Drawing.Size(376, 531);
            Subsets.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 588);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(98, 20);
            label1.TabIndex = 2;
            label1.Text = "Соединение:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(12, 591);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(788, 27);
            textBox1.TabIndex = 3;
            // 
            // DatabaseViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(807, 630);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "DatabaseViewer";
            Text = "Менеджер баз данных";
            Load += DatabaseVewer_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Links).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Subsets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Links;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Subsets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}