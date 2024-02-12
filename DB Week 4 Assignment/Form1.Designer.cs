namespace DB_Week_4_Assignment
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReadOnlyID = new System.Windows.Forms.TextBox();
            this.ReadOnlyFirstName = new System.Windows.Forms.TextBox();
            this.ReadOnlyLastName = new System.Windows.Forms.TextBox();
            this.ReadOnlyDOB = new System.Windows.Forms.TextBox();
            this.ReadOnlyPhoneAllowed = new System.Windows.Forms.TextBox();
            this.InputID = new System.Windows.Forms.TextBox();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.InputLastName = new System.Windows.Forms.TextBox();
            this.InputDOB = new System.Windows.Forms.TextBox();
            this.InputAcceptsCalls = new System.Windows.Forms.RadioButton();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnCreate = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ReadOnlyID
            // 
            this.ReadOnlyID.Location = new System.Drawing.Point(12, 168);
            this.ReadOnlyID.Name = "ReadOnlyID";
            this.ReadOnlyID.ReadOnly = true;
            this.ReadOnlyID.Size = new System.Drawing.Size(100, 20);
            this.ReadOnlyID.TabIndex = 1;
            this.ReadOnlyID.TabStop = false;
            this.ReadOnlyID.Text = "ID";
            this.ReadOnlyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReadOnlyFirstName
            // 
            this.ReadOnlyFirstName.Location = new System.Drawing.Point(12, 195);
            this.ReadOnlyFirstName.Name = "ReadOnlyFirstName";
            this.ReadOnlyFirstName.ReadOnly = true;
            this.ReadOnlyFirstName.Size = new System.Drawing.Size(100, 20);
            this.ReadOnlyFirstName.TabIndex = 2;
            this.ReadOnlyFirstName.TabStop = false;
            this.ReadOnlyFirstName.Text = "First Name";
            this.ReadOnlyFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReadOnlyLastName
            // 
            this.ReadOnlyLastName.Location = new System.Drawing.Point(12, 221);
            this.ReadOnlyLastName.Name = "ReadOnlyLastName";
            this.ReadOnlyLastName.ReadOnly = true;
            this.ReadOnlyLastName.Size = new System.Drawing.Size(100, 20);
            this.ReadOnlyLastName.TabIndex = 3;
            this.ReadOnlyLastName.TabStop = false;
            this.ReadOnlyLastName.Text = "Last Name";
            this.ReadOnlyLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReadOnlyDOB
            // 
            this.ReadOnlyDOB.Location = new System.Drawing.Point(12, 247);
            this.ReadOnlyDOB.Name = "ReadOnlyDOB";
            this.ReadOnlyDOB.ReadOnly = true;
            this.ReadOnlyDOB.Size = new System.Drawing.Size(100, 20);
            this.ReadOnlyDOB.TabIndex = 4;
            this.ReadOnlyDOB.TabStop = false;
            this.ReadOnlyDOB.Text = "DOB";
            this.ReadOnlyDOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReadOnlyPhoneAllowed
            // 
            this.ReadOnlyPhoneAllowed.Location = new System.Drawing.Point(12, 273);
            this.ReadOnlyPhoneAllowed.Name = "ReadOnlyPhoneAllowed";
            this.ReadOnlyPhoneAllowed.ReadOnly = true;
            this.ReadOnlyPhoneAllowed.Size = new System.Drawing.Size(100, 20);
            this.ReadOnlyPhoneAllowed.TabIndex = 5;
            this.ReadOnlyPhoneAllowed.TabStop = false;
            this.ReadOnlyPhoneAllowed.Text = "Accepts calls";
            this.ReadOnlyPhoneAllowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InputID
            // 
            this.InputID.Location = new System.Drawing.Point(119, 169);
            this.InputID.Name = "InputID";
            this.InputID.Size = new System.Drawing.Size(200, 20);
            this.InputID.TabIndex = 7;
            this.InputID.TextChanged += new System.EventHandler(this.InputID_TextChanged);
            // 
            // inputFirstName
            // 
            this.inputFirstName.Location = new System.Drawing.Point(119, 195);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(200, 20);
            this.inputFirstName.TabIndex = 8;
            this.inputFirstName.TextChanged += new System.EventHandler(this.inputFirstName_TextChanged);
            // 
            // InputLastName
            // 
            this.InputLastName.Location = new System.Drawing.Point(118, 221);
            this.InputLastName.Name = "InputLastName";
            this.InputLastName.Size = new System.Drawing.Size(200, 20);
            this.InputLastName.TabIndex = 9;
            this.InputLastName.TextChanged += new System.EventHandler(this.InputLastName_TextChanged);
            // 
            // InputDOB
            // 
            this.InputDOB.Location = new System.Drawing.Point(118, 247);
            this.InputDOB.Name = "InputDOB";
            this.InputDOB.Size = new System.Drawing.Size(200, 20);
            this.InputDOB.TabIndex = 10;
            // 
            // InputAcceptsCalls
            // 
            this.InputAcceptsCalls.AutoSize = true;
            this.InputAcceptsCalls.Location = new System.Drawing.Point(118, 276);
            this.InputAcceptsCalls.Name = "InputAcceptsCalls";
            this.InputAcceptsCalls.Size = new System.Drawing.Size(14, 13);
            this.InputAcceptsCalls.TabIndex = 11;
            this.InputAcceptsCalls.TabStop = true;
            this.InputAcceptsCalls.UseVisualStyleBackColor = true;
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(348, 197);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(75, 23);
            this.BtnRead.TabIndex = 12;
            this.BtnRead.Text = "Read";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCreate
            // 
            this.BtnCreate.Location = new System.Drawing.Point(348, 168);
            this.BtnCreate.Name = "BtnCreate";
            this.BtnCreate.Size = new System.Drawing.Size(75, 23);
            this.BtnCreate.TabIndex = 13;
            this.BtnCreate.Text = "Create";
            this.BtnCreate.UseVisualStyleBackColor = true;
            this.BtnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(348, 226);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdate.TabIndex = 14;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(348, 255);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 15;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnCreate);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.InputAcceptsCalls);
            this.Controls.Add(this.InputDOB);
            this.Controls.Add(this.InputLastName);
            this.Controls.Add(this.inputFirstName);
            this.Controls.Add(this.InputID);
            this.Controls.Add(this.ReadOnlyPhoneAllowed);
            this.Controls.Add(this.ReadOnlyDOB);
            this.Controls.Add(this.ReadOnlyLastName);
            this.Controls.Add(this.ReadOnlyFirstName);
            this.Controls.Add(this.ReadOnlyID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ReadOnlyID;
        private System.Windows.Forms.TextBox ReadOnlyFirstName;
        private System.Windows.Forms.TextBox ReadOnlyLastName;
        private System.Windows.Forms.TextBox ReadOnlyDOB;
        private System.Windows.Forms.TextBox ReadOnlyPhoneAllowed;
        private System.Windows.Forms.TextBox InputID;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.TextBox InputLastName;
        private System.Windows.Forms.TextBox InputDOB;
        private System.Windows.Forms.RadioButton InputAcceptsCalls;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnCreate;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnDelete;
    }
}

