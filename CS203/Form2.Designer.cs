namespace CS203
{
    partial class USC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(USC));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncreatenodes = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbEdge2 = new System.Windows.Forms.ComboBox();
            this.cmbEdge1 = new System.Windows.Forms.ComboBox();
            this.btnadjacentnodes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTraversal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();
            this.cmbSource = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.picgraph = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblpath = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cost = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.lblpath.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btncreatenodes);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 55);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(163, 134);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Nodes";
            // 
            // btncreatenodes
            // 
            this.btncreatenodes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btncreatenodes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncreatenodes.ForeColor = System.Drawing.Color.Black;
            this.btncreatenodes.Location = new System.Drawing.Point(8, 33);
            this.btncreatenodes.Margin = new System.Windows.Forms.Padding(4);
            this.btncreatenodes.Name = "btncreatenodes";
            this.btncreatenodes.Size = new System.Drawing.Size(137, 88);
            this.btncreatenodes.TabIndex = 0;
            this.btncreatenodes.Text = "Create Nodes";
            this.btncreatenodes.UseVisualStyleBackColor = false;
            this.btncreatenodes.Click += new System.EventHandler(this.btncreatenodes_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.cmbEdge2);
            this.groupBox3.Controls.Add(this.cmbEdge1);
            this.groupBox3.Controls.Add(this.btnadjacentnodes);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(193, 55);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(394, 134);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graph Details";
            // 
            // cmbEdge2
            // 
            this.cmbEdge2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbEdge2.FormattingEnabled = true;
            this.cmbEdge2.Location = new System.Drawing.Point(225, 74);
            this.cmbEdge2.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEdge2.Name = "cmbEdge2";
            this.cmbEdge2.Size = new System.Drawing.Size(144, 31);
            this.cmbEdge2.TabIndex = 7;
            // 
            // cmbEdge1
            // 
            this.cmbEdge1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbEdge1.FormattingEnabled = true;
            this.cmbEdge1.Location = new System.Drawing.Point(225, 33);
            this.cmbEdge1.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEdge1.Name = "cmbEdge1";
            this.cmbEdge1.Size = new System.Drawing.Size(144, 31);
            this.cmbEdge1.TabIndex = 7;
            // 
            // btnadjacentnodes
            // 
            this.btnadjacentnodes.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnadjacentnodes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadjacentnodes.ForeColor = System.Drawing.Color.Black;
            this.btnadjacentnodes.Location = new System.Drawing.Point(12, 33);
            this.btnadjacentnodes.Margin = new System.Windows.Forms.Padding(4);
            this.btnadjacentnodes.Name = "btnadjacentnodes";
            this.btnadjacentnodes.Size = new System.Drawing.Size(130, 85);
            this.btnadjacentnodes.TabIndex = 1;
            this.btnadjacentnodes.Text = "Adjacent Nodes";
            this.btnadjacentnodes.UseVisualStyleBackColor = false;
            this.btnadjacentnodes.Click += new System.EventHandler(this.btnadjacentnodes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Edge 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edge 1";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnTraversal);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbDestination);
            this.groupBox2.Controls.Add(this.cmbSource);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(601, 55);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(477, 134);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BFS Traversal";
            // 
            // btnTraversal
            // 
            this.btnTraversal.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTraversal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraversal.ForeColor = System.Drawing.Color.Black;
            this.btnTraversal.Location = new System.Drawing.Point(254, 22);
            this.btnTraversal.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraversal.Name = "btnTraversal";
            this.btnTraversal.Size = new System.Drawing.Size(187, 85);
            this.btnTraversal.TabIndex = 13;
            this.btnTraversal.Text = "Traverse";
            this.btnTraversal.UseVisualStyleBackColor = false;
            this.btnTraversal.Click += new System.EventHandler(this.btnTraversal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Destination";
            // 
            // cmbDestination
            // 
            this.cmbDestination.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Location = new System.Drawing.Point(131, 70);
            this.cmbDestination.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(115, 31);
            this.cmbDestination.TabIndex = 6;
            // 
            // cmbSource
            // 
            this.cmbSource.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Location = new System.Drawing.Point(131, 27);
            this.cmbSource.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(115, 31);
            this.cmbSource.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Source";
            // 
            // picgraph
            // 
            this.picgraph.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picgraph.Location = new System.Drawing.Point(13, 197);
            this.picgraph.Margin = new System.Windows.Forms.Padding(4);
            this.picgraph.Name = "picgraph";
            this.picgraph.Size = new System.Drawing.Size(565, 296);
            this.picgraph.TabIndex = 20;
            this.picgraph.TabStop = false;
            this.picgraph.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picgraph_MouseClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(601, 197);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(477, 296);
            this.dataGridView1.TabIndex = 21;
            // 
            // lblpath
            // 
            this.lblpath.BackColor = System.Drawing.Color.Transparent;
            this.lblpath.Controls.Add(this.label5);
            this.lblpath.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpath.ForeColor = System.Drawing.Color.Black;
            this.lblpath.Location = new System.Drawing.Point(152, 493);
            this.lblpath.Margin = new System.Windows.Forms.Padding(4);
            this.lblpath.Name = "lblpath";
            this.lblpath.Padding = new System.Windows.Forms.Padding(4);
            this.lblpath.Size = new System.Drawing.Size(466, 53);
            this.lblpath.TabIndex = 22;
            this.lblpath.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "The Traversal Path is : ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.cost);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(647, 493);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(308, 53);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cost: ";
            // 
            // cost
            // 
            this.cost.AutoSize = true;
            this.cost.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost.ForeColor = System.Drawing.Color.Black;
            this.cost.Location = new System.Drawing.Point(8, 21);
            this.cost.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(66, 18);
            this.cost.TabIndex = 0;
            this.cost.Text = "Cost is : ";
            // 
            // USC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 577);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblpath);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.picgraph);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "USC";
            this.Text = "Uniform Cost Search";
            this.Load += new System.EventHandler(this.USC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.lblpath.ResumeLayout(false);
            this.lblpath.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncreatenodes;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbEdge2;
        private System.Windows.Forms.ComboBox cmbEdge1;
        private System.Windows.Forms.Button btnadjacentnodes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnTraversal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDestination;
        private System.Windows.Forms.ComboBox cmbSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picgraph;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox lblpath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label cost;
    }
}