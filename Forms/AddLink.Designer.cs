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
            this.label1 = new System.Windows.Forms.Label();
            this.SelectLinkType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddNewLink
            // 
            this.AddNewLink.Location = new System.Drawing.Point(79, 397);
            this.AddNewLink.Name = "AddNewLink";
            this.AddNewLink.Size = new System.Drawing.Size(87, 23);
            this.AddNewLink.TabIndex = 0;
            this.AddNewLink.Text = "Добавить";
            this.AddNewLink.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AddNewLink);
            this.groupBox1.Controls.Add(this.SelectLinkType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 426);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип узла:";
            // 
            // SelectLinkType
            // 
            this.SelectLinkType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectLinkType.FormattingEnabled = true;
            this.SelectLinkType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.SelectLinkType.Items.AddRange(new object[] {
            "ОБЫЧНЫЙ",
            "ИСТОЧНИК",
            "ПОТРЕБИТЕЛЬ",
            "КРИТИЧЕСКИЙ"});
            this.SelectLinkType.Location = new System.Drawing.Point(79, 21);
            this.SelectLinkType.Name = "SelectLinkType";
            this.SelectLinkType.Size = new System.Drawing.Size(121, 23);
            this.SelectLinkType.TabIndex = 0;
            // AddLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 450);
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
        private System.Windows.Forms.ComboBox SelectLinkType;
        private System.Windows.Forms.Label label1;
    }
}