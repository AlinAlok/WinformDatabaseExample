namespace MEDICAL_STORE_MANAGEMENT
{
    partial class Customer_Form
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
            this.button_shopPro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_proCart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_shopPro
            // 
            this.button_shopPro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.button_shopPro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_shopPro.ForeColor = System.Drawing.Color.Transparent;
            this.button_shopPro.Location = new System.Drawing.Point(229, 216);
            this.button_shopPro.Name = "button_shopPro";
            this.button_shopPro.Size = new System.Drawing.Size(137, 91);
            this.button_shopPro.TabIndex = 1;
            this.button_shopPro.Text = "Shop Product ";
            this.button_shopPro.UseVisualStyleBackColor = false;
            this.button_shopPro.Click += new System.EventHandler(this.Button_shopPro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Panel";
            // 
            // button_proCart
            // 
            this.button_proCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button_proCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_proCart.ForeColor = System.Drawing.Color.Transparent;
            this.button_proCart.Location = new System.Drawing.Point(372, 216);
            this.button_proCart.Name = "button_proCart";
            this.button_proCart.Size = new System.Drawing.Size(137, 91);
            this.button_proCart.TabIndex = 1;
            this.button_proCart.Text = "Shoping Cart";
            this.button_proCart.UseVisualStyleBackColor = false;
            this.button_proCart.Click += new System.EventHandler(this.Button_proCart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(89)))), ((int)(((byte)(203)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 175);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(89)))), ((int)(((byte)(203)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 175);
            this.panel2.TabIndex = 4;
            // 
            // Customer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(118)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(753, 528);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_proCart);
            this.Controls.Add(this.button_shopPro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Customer_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_shopPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_proCart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}