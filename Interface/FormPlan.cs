using Electives;

namespace Interface;

/// <summary> Форма редактирования плана </summary>
public partial class FormPlan : Form
{
	/// <summary> Поле с редактируемым планом </summary>
	public Electives.Plan Plan { get; init; }

	/// <summary> Конструктор </summary>
	/// <param name="plan">Редактируемый план</param>
	public FormPlan (Electives.Plan plan)
	{
		this.Plan = plan;
		this.InitializeComponent();
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
		// todo: разобраться с корректностью null присвоений		
		this.Plan.Student = this.comboBoxStudents.SelectedItem as Electives.Student;
		this.Plan.Class = this.comboBoxClasses.SelectedItem as Electives.Class;
		this.Plan.Mark = this.comboBoxMarks.SelectedItem as Electives.Mark;

		this.DialogResult = DialogResult.OK;
		this.Close();
	}

	/// <summary> Наполнение и установка элементов формы </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void FormPlan_SetBoxes (object sender, EventArgs e)
	{
		foreach (var item in Journal.Get.ListClasses) { 
			var idx = this.comboBoxClasses.Items.Add(item);
			if (item.Id == this.Plan.Class.Id){
				this.comboBoxClasses.SelectedIndex = idx;
			}
		}

		foreach (var item in Journal.Get.ListStudents) {
			var idx = this.comboBoxStudents.Items.Add(item);
			if (item.Id == this.Plan.Student.Id) {
				this.comboBoxStudents.SelectedIndex = idx;
			}
		}

		foreach (var posMark in Electives.Mark.Types){
			this.comboBoxMarks.Items.Add(posMark);
		}

		this.comboBoxMarks.SelectedIndex = (int)this.Plan.Mark.Value;
	}
}
