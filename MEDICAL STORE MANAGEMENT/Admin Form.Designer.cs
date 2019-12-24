namespace MEDICAL_STORE_MANAGEMENT
{
    partial class Admin_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_pro = new System.Windows.Forms.Button();
            this.button_addPro = new System.Windows.Forms.Button();
            this.button_req = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Panel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button_pro);
            this.panel1.Controls.Add(this.button_addPro);
            this.panel1.Controls.Add(this.button_req);
            this.panel1.Location = new System.Drawing.Point(1, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 309);
            this.panel1.TabIndex = 1;
            // 
            // button_pro
            // 
            this.button_pro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_pro.ForeColor = System.Drawing.Color.Transparent;
            this.button_pro.Location = new System.Drawing.Point(330, 104);
            this.button_pro.Name = "button_pro";
            this.button_pro.Size = new System.Drawing.Size(108, 91);
            this.button_pro.TabIndex = 0;
            this.button_pro.Text = "Products";
            this.button_pro.UseVisualStyleBackColor = true;
            this.button_pro.Click += new System.EventHandler(this.Button_pro_Click);
            // 
            // button_addPro
            // 
            this.button_addPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_addPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addPro.ForeColor = System.Drawing.Color.Transparent;
            this.button_addPro.Location = new System.Drawing.Point(206, 104);
            this.button_addPro.Name = "button_addPro";
            this.button_addPro.Size = new System.Drawing.Size(118, 91);
            this.button_addPro.TabIndex = 0;
            this.button_addPro.Text = "Add Product";
            this.button_addPro.UseVisualStyleBackColor = false;
            this.button_addPro.Click += new System.EventHandler(this.Button_addPro_Click);
            // 
            // button_req
            // 
            this.button_req.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button_req.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_req.ForeColor = System.Drawing.Color.Transparent;
            this.button_req.Location = new System.Drawing.Point(444, 104);
            this.button_req.Name = "button_req";
            this.button_req.Size = new System.Drawing.Size(111, 91);
            this.button_req.TabIndex = 0;
            this.button_req.Text = "Requests";
            this.button_req.UseVisualStyleBackColor = false;
            this.button_req.Click += new System.EventHandler(this.Button_req_Click);
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(82)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(753, 528);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Admin_Form";
            this.Text = "Admin_Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_pro;
        private System.Windows.Forms.Button button_addPro;
        private System.Windows.Forms.Button button_req;
    }
}