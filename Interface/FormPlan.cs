using Electives;
using System.Diagnostics;

namespace Interface;

/// <summary> Форма редактирования плана </summary>
public partial class FormPlan : Form
{
	public Electives.Plan _plan = new();

	/// <summary> Поле с редактируемым планом </summary>
	public Electives.Plan Plan
	{
		get => _plan;
		set 
		{
			this._plan = value;
			this.comboBoxClasses.SelectedItem = this.Plan.Class;
			this.comboBoxStudents.SelectedItem = this.Plan.Student;
			this.comboBoxMarks.SelectedIndex = (int)(this.Plan.Mark.Value);
		}
	}

	/// <summary> Конструктор </summary>
	/// <param name="plan">Редактируемый план</param>
	public FormPlan ()
	{
		this.InitializeComponent();

		Journal.Get.StudentAdded += this.AddPossibleItem;
		Journal.Get.ClassAdded += this.AddPossibleItem;
		Journal.Get.StudentRemoved += this.RemoveInvalidItem;
		Journal.Get.ClassRemoved += this.RemoveInvalidItem;

		foreach (var pv in Electives.Mark.Types) { 
			this.comboBoxMarks.Items.Add(pv);
		}
	}

	private void RemoveInvalidItem (object? sender, EventArgs e)
	{
		var cbox = sender switch
		{
			Electives.Student => this.comboBoxStudents,
			Electives.Class => this.comboBoxClasses,

			null => throw new ArgumentNullException("AddPossibleItem: sender is null"),
			_ => throw new InvalidDataException("AddPossibleItem: sender is unknown type")
		};

		cbox.Items.Remove(sender);
	}

	private void AddPossibleItem(object? sender, EventArgs e)
	{
		var cbox = sender switch
		{
			Electives.Student => this.comboBoxStudents,
			Electives.Class => this.comboBoxClasses,
			null => throw new ArgumentNullException("AddPossibleItem: sender is null"),
			_ => throw new InvalidDataException("AddPossibleItem: sender is unknown type")
		};
		cbox.Items.Add(sender);
	}

	/// <summary> Обработчик нажатия кнопки "Закрыть" </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void buttonClose_Click (object sender, EventArgs e) => this.Close();


	/// <summary> Обработчик нажатия кнопки "ОК" </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void buttonOK_Click (object sender, EventArgs e)
	{
		var selectedStudent = this.comboBoxStudents.SelectedItem as Electives.Student;
		var selectedClass = this.comboBoxClasses.SelectedItem as Electives.Class;
		var selectedMark = this.comboBoxMarks.SelectedItem as Electives.Mark;
		if (null == selectedClass || selectedStudent == null || selectedMark == null) {

			this.DialogResult = DialogResult.Retry;
			return;
		}

		this.Plan.Class = selectedClass;
		this.Plan.Student = selectedStudent;
		this.Plan.Mark = selectedMark;

		this.DialogResult = DialogResult.OK;
		this.Close();
	}

	/// <summary> Наполнение и установка элементов формы </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	//private void FormPlan_SetBoxes (object sender, EventArgs e)
	//{
	//	foreach (var item in Journal.Get.ListClasses) {
	//		var idx = this.comboBoxClasses.Items.Add(item);
	//		if (item.Id == this.Plan.Class.Id) {
	//			this.comboBoxClasses.SelectedIndex = idx;
	//		}
	//	}
	//
	//	foreach (var item in Journal.Get.ListStudents) {
	//		var idx = this.comboBoxStudents.Items.Add(item);
	//		if (item.Id == this.Plan.Student.Id) {
	//			this.comboBoxStudents.SelectedIndex = idx;
	//		}
	//	}
	//
	//	foreach (var posMark in Electives.Mark.Types) {
	//		this.comboBoxMarks.Items.Add(posMark);
	//	}
	//
	//	this.comboBoxMarks.SelectedIndex = (int)this.Plan.Mark.Value;
	//}
}
