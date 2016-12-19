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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lable1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.room_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.building = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.floor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.First_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.course_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassInsert = new System.Windows.Forms.Button();
            this.ClassesLabel1 = new System.Windows.Forms.Label();
            this.ClassesRoomNumber = new System.Windows.Forms.Label();
            this.ClassesBuilding = new System.Windows.Forms.Label();
            this.ClassesFloorNumber = new System.Windows.Forms.Label();
            this.tbBuilding = new System.Windows.Forms.TextBox();
            this.tbFloorNumber = new System.Windows.Forms.TextBox();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(620, 31);
            this.lable1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(157, 23);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "im the new form!";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.room_number,
            this.building,
            this.floor});
            this.dataGridView1.Location = new System.Drawing.Point(11, 514);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(441, 673);
            this.dataGridView1.TabIndex = 1;
            // 
            // room_number
            // 
            this.room_number.HeaderText = "Room number";
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
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.First_name,
            this.Last_name,
            this.phone_number,
            this.address});
            this.dataGridView2.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView2.Location = new System.Drawing.Point(1123, 514);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView2.RowHeadersWidth = 25;
            this.dataGridView2.RowTemplate.Height = 40;
            this.dataGridView2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView2.Size = new System.Drawing.Size(689, 673);
            this.dataGridView2.TabIndex = 2;
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
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.course_number,
            this.name,
            this.year,
            this.semester,
            this.hours});
            this.dataGridView3.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView3.Location = new System.Drawing.Point(456, 514);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView3.Name = "dataGridView3";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView3.RowHeadersWidth = 25;
            this.dataGridView3.RowTemplate.Height = 40;
            this.dataGridView3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView3.Size = new System.Drawing.Size(663, 673);
            this.dataGridView3.TabIndex = 3;
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
            // ClassInsert
            // 
            this.ClassInsert.Location = new System.Drawing.Point(237, 265);
            this.ClassInsert.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ClassInsert.Name = "ClassInsert";
            this.ClassInsert.Size = new System.Drawing.Size(214, 47);
            this.ClassInsert.TabIndex = 4;
            this.ClassInsert.Text = "Insert new row";
            this.ClassInsert.UseVisualStyleBackColor = true;
            this.ClassInsert.Click += new System.EventHandler(this.ClassInsert_Click);
            // 
            // ClassesLabel1
            // 
            this.ClassesLabel1.AutoSize = true;
            this.ClassesLabel1.Location = new System.Drawing.Point(12, 67);
            this.ClassesLabel1.Name = "ClassesLabel1";
            this.ClassesLabel1.Size = new System.Drawing.Size(80, 23);
            this.ClassesLabel1.TabIndex = 5;
            this.ClassesLabel1.Text = "Classes";
            // 
            // ClassesRoomNumber
            // 
            this.ClassesRoomNumber.AutoSize = true;
            this.ClassesRoomNumber.Location = new System.Drawing.Point(12, 210);
            this.ClassesRoomNumber.Name = "ClassesRoomNumber";
            this.ClassesRoomNumber.Size = new System.Drawing.Size(133, 23);
            this.ClassesRoomNumber.TabIndex = 6;
            this.ClassesRoomNumber.Text = "Room number";
            // 
            // ClassesBuilding
            // 
            this.ClassesBuilding.AutoSize = true;
            this.ClassesBuilding.Location = new System.Drawing.Point(12, 138);
            this.ClassesBuilding.Name = "ClassesBuilding";
            this.ClassesBuilding.Size = new System.Drawing.Size(77, 23);
            this.ClassesBuilding.TabIndex = 7;
            this.ClassesBuilding.Text = "Building";
            // 
            // ClassesFloorNumber
            // 
            this.ClassesFloorNumber.AutoSize = true;
            this.ClassesFloorNumber.Location = new System.Drawing.Point(12, 174);
            this.ClassesFloorNumber.Name = "ClassesFloorNumber";
            this.ClassesFloorNumber.Size = new System.Drawing.Size(129, 23);
            this.ClassesFloorNumber.TabIndex = 8;
            this.ClassesFloorNumber.Text = "Floor Number";
            // 
            // tbBuilding
            // 
            this.tbBuilding.Location = new System.Drawing.Point(237, 131);
            this.tbBuilding.Name = "tbBuilding";
            this.tbBuilding.Size = new System.Drawing.Size(215, 30);
            this.tbBuilding.TabIndex = 9;
            // 
            // tbFloorNumber
            // 
            this.tbFloorNumber.Location = new System.Drawing.Point(237, 167);
            this.tbFloorNumber.Name = "tbFloorNumber";
            this.tbFloorNumber.Size = new System.Drawing.Size(215, 30);
            this.tbFloorNumber.TabIndex = 10;
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Location = new System.Drawing.Point(237, 203);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(215, 30);
            this.tbRoomNumber.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 122);
            this.button1.TabIndex = 13;
            this.button1.Text = "Add rows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1821, 1193);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.tbFloorNumber);
            this.Controls.Add(this.tbBuilding);
            this.Controls.Add(this.ClassesFloorNumber);
            this.Controls.Add(this.ClassesBuilding);
            this.Controls.Add(this.ClassesRoomNumber);
            this.Controls.Add(this.ClassesLabel1);
            this.Controls.Add(this.ClassInsert);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lable1);
            this.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button ClassInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn room_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn building;
        private System.Windows.Forms.DataGridViewTextBoxColumn floor;
        private System.Windows.Forms.Label ClassesLabel1;
        private System.Windows.Forms.Label ClassesRoomNumber;
        private System.Windows.Forms.Label ClassesBuilding;
        private System.Windows.Forms.Label ClassesFloorNumber;
        private System.Windows.Forms.TextBox tbBuilding;
        private System.Windows.Forms.TextBox tbFloorNumber;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}