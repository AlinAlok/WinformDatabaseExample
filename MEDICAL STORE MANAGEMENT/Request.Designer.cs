namespace MEDICAL_STORE_MANAGEMENT
{
    partial class Request
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
            this.label_proReq = new System.Windows.Forms.Label();
            this.label_proName = new System.Windows.Forms.Label();
            this.label_proQT = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_proStat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_proReq
            // 
            this.label_proReq.AutoSize = true;
            this.label_proReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_proReq.Location = new System.Drawing.Point(12, 9);
            this.label_proReq.Name = "label_proReq";
            this.label_proReq.Size = new System.Drawing.Size(217, 31);
            this.label_proReq.TabIndex = 1;
            this.label_proReq.Text = "Product Request";
            // 
            // label_proName
            // 
            this.label_proName.AutoSize = true;
            this.label_proName.ForeColor = System.Drawing.Color.Peru;
            this.label_proName.Location = new System.Drawing.Point(14, 139);
            this.label_proName.Name = "label_proName";
            this.label_proName.Size = new System.Drawing.Size(131, 24);
            this.label_proName.TabIndex = 1;
            this.label_proName.Text = "Product Name";
            // 
            // label_proQT
            // 
            this.label_proQT.AutoSize = true;
            this.label_proQT.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label_proQT.Location = new System.Drawing.Point(190, 139);
            this.label_proQT.Name = "label_proQT";
            this.label_proQT.Size = new System.Drawing.Size(148, 24);
            this.label_proQT.TabIndex = 1;
            this.label_proQT.Text = "Product Quantity";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(504, 269);
            this.dataGridView1.TabIndex = 2;
            // 
            // label_proStat
            // 
            this.label_proStat.AutoSize = true;
            this.label_proStat.ForeColor = System.Drawing.SystemColors.Info;
            this.label_proStat.Location = new System.Drawing.Point(374, 139);
            this.label_proStat.Name = "label_proStat";
            this.label_proStat.Size = new System.Drawing.Size(130, 24);
            this.label_proStat.TabIndex = 1;
            this.label_proStat.Text = "Product Status";
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(753, 528);
            this.Controls.Add(this.label_proStat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_proQT);
            this.Controls.Add(this.label_proName);
            this.Controls.Add(this.label_proReq);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Request";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request";
            this.Load += new System.EventHandler(this.Request_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_proReq;
        private System.Windows.Forms.Label label_proName;
        private System.Windows.Forms.Label label_proQT;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label_proStat;
    }
}