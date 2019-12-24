namespace MEDICAL_STORE_MANAGEMENT
{
    partial class Product_List
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
            this.label_proList = new System.Windows.Forms.Label();
            this.label_proID = new System.Windows.Forms.Label();
            this.label_proName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_proList
            // 
            this.label_proList.AutoSize = true;
            this.label_proList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proList.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_proList.Location = new System.Drawing.Point(12, 9);
            this.label_proList.Name = "label_proList";
            this.label_proList.Size = new System.Drawing.Size(158, 31);
            this.label_proList.TabIndex = 0;
            this.label_proList.Text = "Product List";
            // 
            // label_proID
            // 
            this.label_proID.AutoSize = true;
            this.label_proID.ForeColor = System.Drawing.Color.DarkSalmon;
            this.label_proID.Location = new System.Drawing.Point(92, 120);
            this.label_proID.Name = "label_proID";
            this.label_proID.Size = new System.Drawing.Size(95, 24);
            this.label_proID.TabIndex = 1;
            this.label_proID.Text = "Product Id";
            this.label_proID.Click += new System.EventHandler(this.Label_proID_Click);
            // 
            // label_proName
            // 
            this.label_proName.AutoSize = true;
            this.label_proName.ForeColor = System.Drawing.Color.GhostWhite;
            this.label_proName.Location = new System.Drawing.Point(224, 120);
            this.label_proName.Name = "label_proName";
            this.label_proName.Size = new System.Drawing.Size(131, 24);
            this.label_proName.TabIndex = 1;
            this.label_proName.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(380, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(528, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(96, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 284);
            this.dataGridView1.TabIndex = 2;
            // 
            // Product_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(753, 528);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_proName);
            this.Controls.Add(this.label_proID);
            this.Controls.Add(this.label_proList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Product_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product_List";
            this.Load += new System.EventHandler(this.Product_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_proList;
        private System.Windows.Forms.Label label_proID;
        private System.Windows.Forms.Label label_proName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}