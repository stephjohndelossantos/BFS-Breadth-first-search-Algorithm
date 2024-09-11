namespace CS203
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUCS = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnUCS);
            this.groupBox1.Controls.Add(this.btnDFS);
            this.groupBox1.Controls.Add(this.btnBFS);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(343, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 343);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Traversals";
            // 
            // btnUCS
            // 
            this.btnUCS.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUCS.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUCS.Location = new System.Drawing.Point(108, 206);
            this.btnUCS.Name = "btnUCS";
            this.btnUCS.Size = new System.Drawing.Size(154, 118);
            this.btnUCS.TabIndex = 2;
            this.btnUCS.Text = "UCS";
            this.btnUCS.UseVisualStyleBackColor = false;
            this.btnUCS.Click += new System.EventHandler(this.btnUCS_Click);
            // 
            // btnDFS
            // 
            this.btnDFS.BackColor = System.Drawing.Color.Chocolate;
            this.btnDFS.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.Location = new System.Drawing.Point(193, 69);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(154, 118);
            this.btnDFS.TabIndex = 1;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = false;
            this.btnDFS.Click += new System.EventHandler(this.btnDFS_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.BackColor = System.Drawing.Color.Gainsboro;
            this.btnBFS.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.Location = new System.Drawing.Point(23, 69);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(154, 118);
            this.btnBFS.TabIndex = 0;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = false;
            this.btnBFS.Click += new System.EventHandler(this.btnBFS_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 578);
            this.Controls.Add(this.groupBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.Button btnUCS;
    }
}