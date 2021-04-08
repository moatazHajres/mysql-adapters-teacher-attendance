
namespace tableadapter_csharp
{
    partial class Attendence
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendence));
            this.teacher_attendanceDataSet = new tableadapter_csharp.teacher_attendanceDataSet();
            this.attendance_managementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendance_managementTableAdapter = new tableadapter_csharp.teacher_attendanceDataSetTableAdapters.attendance_managementTableAdapter();
            this.tableAdapterManager = new tableadapter_csharp.teacher_attendanceDataSetTableAdapters.TableAdapterManager();
            this.attendance_managementBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.attendance_managementBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.attendance_managementDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starttimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leavetimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacheridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Leave = new System.Windows.Forms.DateTimePicker();
            this.Start = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.ShowCourse = new System.Windows.Forms.Button();
            this.ShowRoom = new System.Windows.Forms.Button();
            this.ShowTeacher = new System.Windows.Forms.Button();
            this.Courses = new System.Windows.Forms.ComboBox();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Rooms = new System.Windows.Forms.ComboBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Teachers = new System.Windows.Forms.ComboBox();
            this.teachersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherattendanceDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.attendancemanagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teachersTableAdapter = new tableadapter_csharp.teacher_attendanceDataSetTableAdapters.teachersTableAdapter();
            this.teacherattendanceDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new tableadapter_csharp.teacher_attendanceDataSetTableAdapters.roomsTableAdapter();
            this.coursesTableAdapter = new tableadapter_csharp.teacher_attendanceDataSetTableAdapters.coursesTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.Comment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingNavigator)).BeginInit();
            this.attendance_managementBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancemanagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // teacher_attendanceDataSet
            // 
            this.teacher_attendanceDataSet.DataSetName = "teacher_attendanceDataSet";
            this.teacher_attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendance_managementBindingSource
            // 
            this.attendance_managementBindingSource.DataMember = "attendance_management";
            this.attendance_managementBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // attendance_managementTableAdapter
            // 
            this.attendance_managementTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.attendance_managementTableAdapter = this.attendance_managementTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.coursesTableAdapter = null;
            this.tableAdapterManager.roomsTableAdapter = null;
            this.tableAdapterManager.teachersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = tableadapter_csharp.teacher_attendanceDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // attendance_managementBindingNavigator
            // 
            this.attendance_managementBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.attendance_managementBindingNavigator.BindingSource = this.attendance_managementBindingSource;
            this.attendance_managementBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.attendance_managementBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.attendance_managementBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.attendance_managementBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.attendance_managementBindingNavigatorSaveItem});
            this.attendance_managementBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.attendance_managementBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.attendance_managementBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.attendance_managementBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.attendance_managementBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.attendance_managementBindingNavigator.Name = "attendance_managementBindingNavigator";
            this.attendance_managementBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.attendance_managementBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.attendance_managementBindingNavigator.Size = new System.Drawing.Size(1238, 33);
            this.attendance_managementBindingNavigator.TabIndex = 0;
            this.attendance_managementBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // attendance_managementBindingNavigatorSaveItem
            // 
            this.attendance_managementBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.attendance_managementBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("attendance_managementBindingNavigatorSaveItem.Image")));
            this.attendance_managementBindingNavigatorSaveItem.Name = "attendance_managementBindingNavigatorSaveItem";
            this.attendance_managementBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.attendance_managementBindingNavigatorSaveItem.Text = "Save Data";
            this.attendance_managementBindingNavigatorSaveItem.Click += new System.EventHandler(this.attendance_managementBindingNavigatorSaveItem_Click);
            // 
            // attendance_managementDataGridView
            // 
            this.attendance_managementDataGridView.AutoGenerateColumns = false;
            this.attendance_managementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attendance_managementDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.starttimeDataGridViewTextBoxColumn,
            this.leavetimeDataGridViewTextBoxColumn,
            this.teacheridDataGridViewTextBoxColumn,
            this.roomidDataGridViewTextBoxColumn,
            this.courseidDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.attendance_managementDataGridView.DataSource = this.attendance_managementBindingSource;
            this.attendance_managementDataGridView.Location = new System.Drawing.Point(15, 246);
            this.attendance_managementDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.attendance_managementDataGridView.Name = "attendance_managementDataGridView";
            this.attendance_managementDataGridView.RowHeadersWidth = 62;
            this.attendance_managementDataGridView.Size = new System.Drawing.Size(1204, 322);
            this.attendance_managementDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // starttimeDataGridViewTextBoxColumn
            // 
            this.starttimeDataGridViewTextBoxColumn.DataPropertyName = "start_time";
            this.starttimeDataGridViewTextBoxColumn.HeaderText = "start_time";
            this.starttimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.starttimeDataGridViewTextBoxColumn.Name = "starttimeDataGridViewTextBoxColumn";
            this.starttimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // leavetimeDataGridViewTextBoxColumn
            // 
            this.leavetimeDataGridViewTextBoxColumn.DataPropertyName = "leave_time";
            this.leavetimeDataGridViewTextBoxColumn.HeaderText = "leave_time";
            this.leavetimeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.leavetimeDataGridViewTextBoxColumn.Name = "leavetimeDataGridViewTextBoxColumn";
            this.leavetimeDataGridViewTextBoxColumn.Width = 150;
            // 
            // teacheridDataGridViewTextBoxColumn
            // 
            this.teacheridDataGridViewTextBoxColumn.DataPropertyName = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.HeaderText = "teacher_id";
            this.teacheridDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.teacheridDataGridViewTextBoxColumn.Name = "teacheridDataGridViewTextBoxColumn";
            this.teacheridDataGridViewTextBoxColumn.Width = 150;
            // 
            // roomidDataGridViewTextBoxColumn
            // 
            this.roomidDataGridViewTextBoxColumn.DataPropertyName = "room_id";
            this.roomidDataGridViewTextBoxColumn.HeaderText = "room_id";
            this.roomidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.roomidDataGridViewTextBoxColumn.Name = "roomidDataGridViewTextBoxColumn";
            this.roomidDataGridViewTextBoxColumn.Width = 150;
            // 
            // courseidDataGridViewTextBoxColumn
            // 
            this.courseidDataGridViewTextBoxColumn.DataPropertyName = "course_id";
            this.courseidDataGridViewTextBoxColumn.HeaderText = "course_id";
            this.courseidDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.courseidDataGridViewTextBoxColumn.Name = "courseidDataGridViewTextBoxColumn";
            this.courseidDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.Width = 150;
            // 
            // Leave
            // 
            this.Leave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leave.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Leave.Location = new System.Drawing.Point(142, 158);
            this.Leave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(151, 31);
            this.Leave.TabIndex = 38;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.Start.Location = new System.Drawing.Point(142, 102);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(151, 31);
            this.Start.TabIndex = 37;
            // 
            // Date
            // 
            this.Date.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Date.Location = new System.Drawing.Point(142, 41);
            this.Date.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(151, 31);
            this.Date.TabIndex = 36;
            // 
            // ShowCourse
            // 
            this.ShowCourse.Location = new System.Drawing.Point(644, 161);
            this.ShowCourse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowCourse.Name = "ShowCourse";
            this.ShowCourse.Size = new System.Drawing.Size(50, 34);
            this.ShowCourse.TabIndex = 35;
            this.ShowCourse.Text = "Edit";
            this.ShowCourse.UseVisualStyleBackColor = true;
            this.ShowCourse.Click += new System.EventHandler(this.ShowCourse_Click);
            // 
            // ShowRoom
            // 
            this.ShowRoom.Location = new System.Drawing.Point(644, 104);
            this.ShowRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowRoom.Name = "ShowRoom";
            this.ShowRoom.Size = new System.Drawing.Size(50, 34);
            this.ShowRoom.TabIndex = 34;
            this.ShowRoom.Text = "Edit";
            this.ShowRoom.UseVisualStyleBackColor = true;
            this.ShowRoom.Click += new System.EventHandler(this.ShowRoom_Click);
            // 
            // ShowTeacher
            // 
            this.ShowTeacher.Location = new System.Drawing.Point(644, 45);
            this.ShowTeacher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShowTeacher.Name = "ShowTeacher";
            this.ShowTeacher.Size = new System.Drawing.Size(50, 34);
            this.ShowTeacher.TabIndex = 33;
            this.ShowTeacher.Text = "Edit";
            this.ShowTeacher.UseVisualStyleBackColor = true;
            this.ShowTeacher.Click += new System.EventHandler(this.ShowTeacher_Click);
            // 
            // Courses
            // 
            this.Courses.DataSource = this.coursesBindingSource;
            this.Courses.DisplayMember = "name";
            this.Courses.FormattingEnabled = true;
            this.Courses.Location = new System.Drawing.Point(458, 161);
            this.Courses.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(175, 27);
            this.Courses.TabIndex = 32;
            this.Courses.ValueMember = "id";
            this.Courses.SelectedIndexChanged += new System.EventHandler(this.Courses_SelectedIndexChanged);
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // Rooms
            // 
            this.Rooms.DataSource = this.roomsBindingSource;
            this.Rooms.DisplayMember = "name";
            this.Rooms.FormattingEnabled = true;
            this.Rooms.Location = new System.Drawing.Point(458, 105);
            this.Rooms.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Rooms.Name = "Rooms";
            this.Rooms.Size = new System.Drawing.Size(175, 27);
            this.Rooms.TabIndex = 31;
            this.Rooms.ValueMember = "id";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.teacher_attendanceDataSet;
            // 
            // Teachers
            // 
            this.Teachers.DataSource = this.teachersBindingSource;
            this.Teachers.DisplayMember = "name";
            this.Teachers.FormattingEnabled = true;
            this.Teachers.Location = new System.Drawing.Point(458, 45);
            this.Teachers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Teachers.Name = "Teachers";
            this.Teachers.Size = new System.Drawing.Size(175, 27);
            this.Teachers.TabIndex = 30;
            this.Teachers.ValueMember = "id";
            // 
            // teachersBindingSource
            // 
            this.teachersBindingSource.DataMember = "teachers";
            this.teachersBindingSource.DataSource = this.teacherattendanceDataSetBindingSource;
            // 
            // teacherattendanceDataSetBindingSource
            // 
            this.teacherattendanceDataSetBindingSource.DataSource = this.teacher_attendanceDataSet;
            this.teacherattendanceDataSetBindingSource.Position = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(310, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 29;
            this.label7.Text = "Course Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 24);
            this.label6.TabIndex = 28;
            this.label6.Text = "Room Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(310, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Teacher Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Leave Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Start Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Date";
            // 
            // attendancemanagementBindingSource
            // 
            this.attendancemanagementBindingSource.DataMember = "attendance_management";
            this.attendancemanagementBindingSource.DataSource = this.teacherattendanceDataSetBindingSource;
            // 
            // teachersTableAdapter
            // 
            this.teachersTableAdapter.ClearBeforeFill = true;
            // 
            // teacherattendanceDataSetBindingSource1
            // 
            this.teacherattendanceDataSetBindingSource1.DataSource = this.teacher_attendanceDataSet;
            this.teacherattendanceDataSetBindingSource1.Position = 0;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 208);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Comment";
            // 
            // Comment
            // 
            this.Comment.Location = new System.Drawing.Point(142, 208);
            this.Comment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Comment.Name = "Comment";
            this.Comment.Size = new System.Drawing.Size(548, 27);
            this.Comment.TabIndex = 40;
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 715);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Comment);
            this.Controls.Add(this.Leave);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.ShowCourse);
            this.Controls.Add(this.ShowRoom);
            this.Controls.Add(this.ShowTeacher);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.Rooms);
            this.Controls.Add(this.Teachers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attendance_managementDataGridView);
            this.Controls.Add(this.attendance_managementBindingNavigator);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Attendence";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teacher_attendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementBindingNavigator)).EndInit();
            this.attendance_managementBindingNavigator.ResumeLayout(false);
            this.attendance_managementBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attendance_managementDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendancemanagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherattendanceDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private teacher_attendanceDataSet teacher_attendanceDataSet;
        private System.Windows.Forms.BindingSource attendance_managementBindingSource;
        private teacher_attendanceDataSetTableAdapters.attendance_managementTableAdapter attendance_managementTableAdapter;
        private teacher_attendanceDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator attendance_managementBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton attendance_managementBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView attendance_managementDataGridView;
        private System.Windows.Forms.DateTimePicker Leave;
        private System.Windows.Forms.DateTimePicker Start;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Button ShowCourse;
        private System.Windows.Forms.Button ShowRoom;
        private System.Windows.Forms.Button ShowTeacher;
        private System.Windows.Forms.ComboBox Courses;
        private System.Windows.Forms.ComboBox Rooms;
        private System.Windows.Forms.ComboBox Teachers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource teacherattendanceDataSetBindingSource;
        private System.Windows.Forms.BindingSource attendancemanagementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starttimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leavetimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacheridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teachersBindingSource;
        private teacher_attendanceDataSetTableAdapters.teachersTableAdapter teachersTableAdapter;
        private System.Windows.Forms.BindingSource teacherattendanceDataSetBindingSource1;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private teacher_attendanceDataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private teacher_attendanceDataSetTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Comment;
    }
}

