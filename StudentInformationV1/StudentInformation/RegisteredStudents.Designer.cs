namespace StudentInformation
{
    partial class RegisteredStudents
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
            this.gvStudentList = new System.Windows.Forms.DataGridView();
            this.btnViewDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStudentList
            // 
            this.gvStudentList.AllowUserToAddRows = false;
            this.gvStudentList.AllowUserToDeleteRows = false;
            this.gvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudentList.Location = new System.Drawing.Point(0, 0);
            this.gvStudentList.Name = "gvStudentList";
            this.gvStudentList.ReadOnly = true;
            this.gvStudentList.Size = new System.Drawing.Size(740, 542);
            this.gvStudentList.TabIndex = 0;
            this.gvStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudentList_CellClick);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Location = new System.Drawing.Point(665, 565);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(75, 23);
            this.btnViewDetails.TabIndex = 1;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // RegisteredStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 600);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.gvStudentList);
            this.Name = "RegisteredStudents";
            this.Text = "RegisteredStudents";
            this.Load += new System.EventHandler(this.RegisteredStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvStudentList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvStudentList;
        private System.Windows.Forms.Button btnViewDetails;
    }
}