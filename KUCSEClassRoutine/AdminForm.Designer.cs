namespace KUCSEClassRoutine
{
    partial class AdminForm
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
            this.Add = new System.Windows.Forms.Button();
            this.ViewRoutine = new System.Windows.Forms.Button();
            this.PrintRoutine = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.Location = new System.Drawing.Point(187, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(150, 35);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // ViewRoutine
            // 
            this.ViewRoutine.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewRoutine.Location = new System.Drawing.Point(22, 12);
            this.ViewRoutine.Name = "ViewRoutine";
            this.ViewRoutine.Size = new System.Drawing.Size(150, 35);
            this.ViewRoutine.TabIndex = 0;
            this.ViewRoutine.Text = "View Routine";
            this.ViewRoutine.UseVisualStyleBackColor = true;
            this.ViewRoutine.Click += new System.EventHandler(this.ViewRoutine_Click);
            // 
            // PrintRoutine
            // 
            this.PrintRoutine.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintRoutine.Location = new System.Drawing.Point(527, 12);
            this.PrintRoutine.Name = "PrintRoutine";
            this.PrintRoutine.Size = new System.Drawing.Size(150, 35);
            this.PrintRoutine.TabIndex = 4;
            this.PrintRoutine.Text = "Make Pdf";
            this.PrintRoutine.UseVisualStyleBackColor = true;
            this.PrintRoutine.Click += new System.EventHandler(this.PrintRoutine_Click);
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(357, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(150, 35);
            this.Generate.TabIndex = 3;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1020, 480);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KUCSEClassRoutine.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 563);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.PrintRoutine);
            this.Controls.Add(this.ViewRoutine);
            this.Controls.Add(this.Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button ViewRoutine;
        private System.Windows.Forms.Button PrintRoutine;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}