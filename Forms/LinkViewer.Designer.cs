namespace SynergicFailureAftermath.Forms
{
    partial class LinkViewer
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
            this.theListofLinks = new System.Windows.Forms.DataGridView();
            this.DGW_Link_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGW_Link_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGW_Connected_Links = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theListofLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.theListofLinks);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Узлы";
            // 
            // theListofLinks
            // 
            this.theListofLinks.AllowUserToDeleteRows = false;
            this.theListofLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.theListofLinks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGW_Link_Index,
            this.DGW_Link_Type,
            this.DGW_Connected_Links});
            this.theListofLinks.Location = new System.Drawing.Point(6, 19);
            this.theListofLinks.Name = "theListofLinks";
            this.theListofLinks.Size = new System.Drawing.Size(346, 401);
            this.theListofLinks.TabIndex = 0;
            // 
            // DGW_Link_Index
            // 
            this.DGW_Link_Index.HeaderText = "Индекс узла";
            this.DGW_Link_Index.Name = "DGW_Link_Index";
            this.DGW_Link_Index.ReadOnly = true;
            // 
            // DGW_Link_Type
            // 
            this.DGW_Link_Type.HeaderText = "Тип";
            this.DGW_Link_Type.Name = "DGW_Link_Type";
            this.DGW_Link_Type.ReadOnly = true;
            // 
            // DGW_Connected_Links
            // 
            this.DGW_Connected_Links.HeaderText = "Связанные узлы";
            this.DGW_Connected_Links.Name = "DGW_Connected_Links";
            this.DGW_Connected_Links.ReadOnly = true;
            // 
            // LinkViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LinkViewer";
            this.Text = "Просмотр узлов";
            this.Load += new System.EventHandler(this.LinkViewer_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.theListofLinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView theListofLinks;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGW_Link_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGW_Link_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGW_Connected_Links;
    }
}