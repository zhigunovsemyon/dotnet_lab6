namespace Interface
{
	partial class FormMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.menuStrip1 = new MenuStrip();
			this.toolStripMenuItemFile = new ToolStripMenuItem();
			this.toolStripMenuItemClose = new ToolStripMenuItem();
			this.toolStripMenuItemStudents = new ToolStripMenuItem();
			this.toolStripMenuItemAddStudent = new ToolStripMenuItem();
			this.toolStripMenuItemEditStudent = new ToolStripMenuItem();
			this.ClassesToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripMenuItemAddClass = new ToolStripMenuItem();
			this.toolStripMenuItemEditClass = new ToolStripMenuItem();
			this.планToolStripMenuItem = new ToolStripMenuItem();
			this.ToolStripMenuItemAddPlan = new ToolStripMenuItem();
			this.ToolStripMenuItemEditPlan = new ToolStripMenuItem();
			this.tabControlMain = new TabControl();
			this.tabPageStudents = new TabPage();
			this.listViewStudents = new ListView();
			this.surnameHeader = new ColumnHeader();
			this.nameHeader = new ColumnHeader();
			this.patronimHeader = new ColumnHeader();
			this.phoneHeader = new ColumnHeader();
			this.addressHeader = new ColumnHeader();
			this.tabPageClasses = new TabPage();
			this.listViewClasses = new ListView();
			this.classNameHeader = new ColumnHeader();
			this.lectionsHeader = new ColumnHeader();
			this.labsHeader = new ColumnHeader();
			this.practicesHeader = new ColumnHeader();
			this.tabPagePlans = new TabPage();
			this.listViewPlans = new ListView();
			this.planStudentHeader = new ColumnHeader();
			this.planClassHeader = new ColumnHeader();
			this.planMarkHeader = new ColumnHeader();
			this.menuStrip1.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			this.tabPageClasses.SuspendLayout();
			this.tabPagePlans.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.toolStripMenuItemFile, this.toolStripMenuItemStudents, this.ClassesToolStripMenuItem, this.планToolStripMenuItem });
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItemFile
			// 
			this.toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItemClose });
			this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			this.toolStripMenuItemFile.Size = new Size(48, 20);
			this.toolStripMenuItemFile.Text = "&Файл";
			// 
			// toolStripMenuItemClose
			// 
			this.toolStripMenuItemClose.Name = "toolStripMenuItemClose";
			this.toolStripMenuItemClose.Size = new Size(109, 22);
			this.toolStripMenuItemClose.Text = "&Выйти";
			this.toolStripMenuItemClose.Click += this.CloseButton_Click;
			// 
			// toolStripMenuItemStudents
			// 
			this.toolStripMenuItemStudents.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItemAddStudent, this.toolStripMenuItemEditStudent });
			this.toolStripMenuItemStudents.Name = "toolStripMenuItemStudents";
			this.toolStripMenuItemStudents.Size = new Size(71, 20);
			this.toolStripMenuItemStudents.Text = "&Студенты";
			// 
			// toolStripMenuItemAddStudent
			// 
			this.toolStripMenuItemAddStudent.Name = "toolStripMenuItemAddStudent";
			this.toolStripMenuItemAddStudent.Size = new Size(154, 22);
			this.toolStripMenuItemAddStudent.Text = "&Добавить";
			this.toolStripMenuItemAddStudent.Click += this.StudentAddtoolStripMenuItem_Click;
			// 
			// toolStripMenuItemEditStudent
			// 
			this.toolStripMenuItemEditStudent.Name = "toolStripMenuItemEditStudent";
			this.toolStripMenuItemEditStudent.Size = new Size(154, 22);
			this.toolStripMenuItemEditStudent.Text = "&Редактировать";
			this.toolStripMenuItemEditStudent.Click += this.StudentEditToolStripMenuItem_Click;
			// 
			// ClassesToolStripMenuItem
			// 
			this.ClassesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.toolStripMenuItemAddClass, this.toolStripMenuItemEditClass });
			this.ClassesToolStripMenuItem.Name = "ClassesToolStripMenuItem";
			this.ClassesToolStripMenuItem.Size = new Size(63, 20);
			this.ClassesToolStripMenuItem.Text = "&Занятия";
			// 
			// toolStripMenuItemAddClass
			// 
			this.toolStripMenuItemAddClass.Name = "toolStripMenuItemAddClass";
			this.toolStripMenuItemAddClass.Size = new Size(154, 22);
			this.toolStripMenuItemAddClass.Text = "&Добавить";
			this.toolStripMenuItemAddClass.Click += this.ClassAddStripMenuItem_Click;
			// 
			// toolStripMenuItemEditClass
			// 
			this.toolStripMenuItemEditClass.Name = "toolStripMenuItemEditClass";
			this.toolStripMenuItemEditClass.Size = new Size(154, 22);
			this.toolStripMenuItemEditClass.Text = "&Редактировать";
			this.toolStripMenuItemEditClass.Click += this.ClassEditStripMenuItem_Click;
			// 
			// планToolStripMenuItem
			// 
			this.планToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.ToolStripMenuItemAddPlan, this.ToolStripMenuItemEditPlan });
			this.планToolStripMenuItem.Name = "планToolStripMenuItem";
			this.планToolStripMenuItem.Size = new Size(48, 20);
			this.планToolStripMenuItem.Text = "&План";
			// 
			// ToolStripMenuItemAddPlan
			// 
			this.ToolStripMenuItemAddPlan.Name = "ToolStripMenuItemAddPlan";
			this.ToolStripMenuItemAddPlan.Size = new Size(154, 22);
			this.ToolStripMenuItemAddPlan.Text = "&Добавить";
			this.ToolStripMenuItemAddPlan.Click += this.PlanAddStripMenuItem_Click;
			// 
			// ToolStripMenuItemEditPlan
			// 
			this.ToolStripMenuItemEditPlan.Name = "ToolStripMenuItemEditPlan";
			this.ToolStripMenuItemEditPlan.Size = new Size(154, 22);
			this.ToolStripMenuItemEditPlan.Text = "&Редактировать";
			this.ToolStripMenuItemEditPlan.Click += this.PlanEditStripMenuItem_Click;
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageStudents);
			this.tabControlMain.Controls.Add(this.tabPageClasses);
			this.tabControlMain.Controls.Add(this.tabPagePlans);
			this.tabControlMain.Dock = DockStyle.Fill;
			this.tabControlMain.Location = new Point(0, 24);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new Size(800, 426);
			this.tabControlMain.TabIndex = 1;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.listViewStudents);
			this.tabPageStudents.Location = new Point(4, 24);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new Padding(3);
			this.tabPageStudents.Size = new Size(792, 398);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Студенты";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// listViewStudents
			// 
			this.listViewStudents.Columns.AddRange(new ColumnHeader[] { this.surnameHeader, this.nameHeader, this.patronimHeader, this.phoneHeader, this.addressHeader });
			this.listViewStudents.Dock = DockStyle.Fill;
			this.listViewStudents.FullRowSelect = true;
			this.listViewStudents.Location = new Point(3, 3);
			this.listViewStudents.MultiSelect = false;
			this.listViewStudents.Name = "listViewStudents";
			this.listViewStudents.Size = new Size(786, 392);
			this.listViewStudents.TabIndex = 0;
			this.listViewStudents.UseCompatibleStateImageBehavior = false;
			this.listViewStudents.View = View.Details;
			this.listViewStudents.MouseDoubleClick += this.listViewStudents_MouseDoubleClick;
			// 
			// surnameHeader
			// 
			this.surnameHeader.Text = "Фамилия";
			this.surnameHeader.Width = 80;
			// 
			// nameHeader
			// 
			this.nameHeader.Text = "Имя";
			// 
			// patronimHeader
			// 
			this.patronimHeader.Text = "Отчество";
			this.patronimHeader.Width = 80;
			// 
			// phoneHeader
			// 
			this.phoneHeader.Text = "Телефон";
			this.phoneHeader.Width = 80;
			// 
			// addressHeader
			// 
			this.addressHeader.Text = "Адрес";
			this.addressHeader.Width = 120;
			// 
			// tabPageClasses
			// 
			this.tabPageClasses.Controls.Add(this.listViewClasses);
			this.tabPageClasses.Location = new Point(4, 24);
			this.tabPageClasses.Name = "tabPageClasses";
			this.tabPageClasses.Padding = new Padding(3);
			this.tabPageClasses.Size = new Size(792, 398);
			this.tabPageClasses.TabIndex = 1;
			this.tabPageClasses.Text = "Занятия";
			this.tabPageClasses.UseVisualStyleBackColor = true;
			// 
			// listViewClasses
			// 
			this.listViewClasses.Columns.AddRange(new ColumnHeader[] { this.classNameHeader, this.lectionsHeader, this.labsHeader, this.practicesHeader });
			this.listViewClasses.Dock = DockStyle.Fill;
			this.listViewClasses.FullRowSelect = true;
			this.listViewClasses.Location = new Point(3, 3);
			this.listViewClasses.MultiSelect = false;
			this.listViewClasses.Name = "listViewClasses";
			this.listViewClasses.Size = new Size(786, 392);
			this.listViewClasses.TabIndex = 0;
			this.listViewClasses.UseCompatibleStateImageBehavior = false;
			this.listViewClasses.View = View.Details;
			this.listViewClasses.MouseDoubleClick += this.listViewClasses_MouseDoubleClick;
			// 
			// classNameHeader
			// 
			this.classNameHeader.Text = "Название";
			this.classNameHeader.Width = 80;
			// 
			// lectionsHeader
			// 
			this.lectionsHeader.Text = "Лекции";
			// 
			// labsHeader
			// 
			this.labsHeader.Text = "Лабораторные занятия";
			this.labsHeader.Width = 140;
			// 
			// practicesHeader
			// 
			this.practicesHeader.Text = "Практические занятия";
			this.practicesHeader.Width = 140;
			// 
			// tabPagePlans
			// 
			this.tabPagePlans.Controls.Add(this.listViewPlans);
			this.tabPagePlans.Location = new Point(4, 24);
			this.tabPagePlans.Name = "tabPagePlans";
			this.tabPagePlans.Padding = new Padding(3);
			this.tabPagePlans.Size = new Size(792, 398);
			this.tabPagePlans.TabIndex = 2;
			this.tabPagePlans.Text = "Планы";
			this.tabPagePlans.UseVisualStyleBackColor = true;
			// 
			// listViewPlans
			// 
			this.listViewPlans.Columns.AddRange(new ColumnHeader[] { this.planStudentHeader, this.planClassHeader, this.planMarkHeader });
			this.listViewPlans.Dock = DockStyle.Fill;
			this.listViewPlans.FullRowSelect = true;
			this.listViewPlans.Location = new Point(3, 3);
			this.listViewPlans.MultiSelect = false;
			this.listViewPlans.Name = "listViewPlans";
			this.listViewPlans.Size = new Size(786, 392);
			this.listViewPlans.TabIndex = 0;
			this.listViewPlans.UseCompatibleStateImageBehavior = false;
			this.listViewPlans.View = View.Details;
			this.listViewPlans.MouseDoubleClick += this.listViewPlans_MouseDoubleClick;
			// 
			// planStudentHeader
			// 
			this.planStudentHeader.Text = "Студент";
			this.planStudentHeader.Width = 100;
			// 
			// planClassHeader
			// 
			this.planClassHeader.Text = "Предмет";
			this.planClassHeader.Width = 80;
			// 
			// planMarkHeader
			// 
			this.planMarkHeader.Text = "Оценка";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.ClientSize = new Size(800, 450);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "FormMain";
			this.Text = "Факультативы";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageClasses.ResumeLayout(false);
			this.tabPagePlans.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem toolStripMenuItemFile;
		private ToolStripMenuItem toolStripMenuItemClose;
		private ToolStripMenuItem toolStripMenuItemStudents;
		private ToolStripMenuItem ClassesToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItemAddStudent;
		private ToolStripMenuItem toolStripMenuItemEditStudent;
		private ToolStripMenuItem toolStripMenuItemAddClass;
		private ToolStripMenuItem toolStripMenuItemEditClass;
		private TabControl tabControlMain;
		private TabPage tabPageStudents;
		private TabPage tabPageClasses;
		private TabPage tabPagePlans;
		private ToolStripMenuItem планToolStripMenuItem;
		private ToolStripMenuItem ToolStripMenuItemAddPlan;
		private ToolStripMenuItem ToolStripMenuItemEditPlan;
		private ListView listViewClasses;
		private ListView listViewPlans;
		private ColumnHeader surnameHeader;
		private ColumnHeader nameHeader;
		private ColumnHeader patronimHeader;
		private ColumnHeader phoneHeader;
		private ColumnHeader addressHeader;
		protected ListView listViewStudents;
		private ColumnHeader classNameHeader;
		private ColumnHeader lectionsHeader;
		private ColumnHeader labsHeader;
		private ColumnHeader practicesHeader;
		private ColumnHeader planStudentHeader;
		private ColumnHeader planClassHeader;
		private ColumnHeader planMarkHeader;
	}
}
