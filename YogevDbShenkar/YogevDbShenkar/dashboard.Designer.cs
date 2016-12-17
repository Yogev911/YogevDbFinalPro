namespace YogevDbShenkar
{
    partial class dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lable1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(764, 9);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(222, 32);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "im the new form!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_number,
            this.building,
            this.floor});
            this.dataGridView1.Location = new System.Drawing.Point(12, 667);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(458, 529);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // room_number
            // 
            this.room_number.HeaderText = "room_number";
            this.room_number.Name = "room_number";
            // 
            // building
            // 
            this.building.HeaderText = "building";
            this.building.Name = "building";
            // 
            // floor
            // 
            this.floor.HeaderText = "floor";
            this.floor.Name = "floor";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.First_name,
            this.Last_name,
            this.phone_number,
            this.address});
            this.dataGridView2.Location = new System.Drawing.Point(476, 667);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.Size = new System.Drawing.Size(647, 529);
            this.dataGridView2.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_number,
            this.name,
            this.year,
            this.semester,
            this.hours});
            this.dataGridView3.Location = new System.Drawing.Point(1154, 667);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.Size = new System.Drawing.Size(560, 529);
            this.dataGridView3.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // First_name
            // 
            this.First_name.HeaderText = "First name";
            this.First_name.Name = "First_name";
            // 
            // Last_name
            // 
            this.Last_name.HeaderText = "Last name";
            this.Last_name.Name = "Last_name";
            // 
            // phone_number
            // 
            this.phone_number.HeaderText = "Phone number";
            this.phone_number.Name = "phone_number";
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // course_number
            // 
            this.course_number.HeaderText = "Course number";
            this.course_number.Name = "course_number";
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // year
            // 
            this.year.HeaderText = "Year";
            this.year.Name = "year";
            // 
            // semester
            // 
            this.semester.HeaderText = "Semester";
            this.semester.Name = "semester";
            // 
            // hours
            // 
            this.hours.HeaderText = "Hours";
            this.hours.Name = "hours";
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(176, 372);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(217, 149);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 1208);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lable1);
            this.Name = "dashboard";
            this.Text = "dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn First_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn course_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.DataGridViewTextBoxColumn semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours;
        private System.Windows.Forms.Button Refresh;
    }
}