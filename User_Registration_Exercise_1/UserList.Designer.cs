namespace User_Registration_Exercise_1
{
    partial class UserList
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
            this.userLisDataGridView1 = new System.Windows.Forms.DataGridView();
            this.userRegistration = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.userLisDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // userLisDataGridView1
            // 
            this.userLisDataGridView1.AllowUserToAddRows = false;
            this.userLisDataGridView1.AllowUserToDeleteRows = false;
            this.userLisDataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.userLisDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userLisDataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userLisDataGridView1.Location = new System.Drawing.Point(22, 23);
            this.userLisDataGridView1.Name = "userLisDataGridView1";
            this.userLisDataGridView1.ReadOnly = true;
            this.userLisDataGridView1.Size = new System.Drawing.Size(929, 290);
            this.userLisDataGridView1.TabIndex = 0;
            this.userLisDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userLisDataGridView1_CellContentClick);
            // 
            // userRegistration
            // 
            this.userRegistration.AutoSize = true;
            this.userRegistration.LinkColor = System.Drawing.Color.Black;
            this.userRegistration.Location = new System.Drawing.Point(596, 380);
            this.userRegistration.Name = "userRegistration";
            this.userRegistration.Size = new System.Drawing.Size(99, 19);
            this.userRegistration.TabIndex = 1;
            this.userRegistration.TabStop = true;
            this.userRegistration.Text = "Add new user";
            this.userRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.userRegistration_LinkClicked);
            // 
            // UserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(975, 533);
            this.Controls.Add(this.userRegistration);
            this.Controls.Add(this.userLisDataGridView1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UserList";
            this.Text = "User List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserList_FormClosing);
            this.Load += new System.EventHandler(this.UserList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userLisDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userLisDataGridView1;
        private System.Windows.Forms.LinkLabel userRegistration;
    }
}