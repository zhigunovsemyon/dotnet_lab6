using Electives;

namespace Interface;

/// <summary> Основная форма </summary>
public partial class FormMain : Form
{
	private FormPlan _formPlan = new();

	public FormMain ()
	{
		this.InitializeComponent();

		Journal.Get.PlanAdded += this.ItemAdded;
		Journal.Get.PlanRemoved += this.ItemRemoved;

		Journal.Get.StudentAdded += this.ItemAdded;
		Journal.Get.StudentRemoved += this.ItemRemoved;

		Journal.Get.ClassAdded += this.ItemAdded;
		Journal.Get.ClassRemoved += this.ItemRemoved;
	}

	/// <summary> Метод для закрытия приложения через пункт меню </summary>
	private void CloseButton_Click (object sender, EventArgs e) => this.Close();

	/// <summary> Запрос подтверждения от пользователя удаления </summary>
	/// <param name="text">Текст в окне</param>
	/// <returns>Ответ пользователя</returns>
	private static DialogResult VerifyDeletion (string item)
		=> MessageBox.Show($"Удалить {item}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

	/// <summary> Добавление нового элемента в нужные списки формы </summary>
	/// <param name="sender">Новый элемент</param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">При sender null</exception>
	/// <exception cref="InvalidDataException">При sender неправильного типа</exception>
	private void ItemAdded(object? sender, EventArgs e)
	{
		_ = sender switch {
			Electives.Plan => this.listViewPlans.Items.Add(CreatePlanListViewItem((Electives.Plan)sender)),
			Electives.Student => this.listViewStudents.Items.Add(CreateStudentListViewItem((Electives.Student)sender)),
			Electives.Class => this.listViewClasses.Items.Add(CreateClassListViewItem((Electives.Class)sender)),

			null => throw new ArgumentNullException("FormMain.ItemAdded: sender is null"),
			_ => throw new InvalidDataException("FormMain.ItemAdded: sender is unknown")
		};		
	}

	/// <summary> Удаление элемента элемента из соответствующего списка формы </summary>
	/// <param name="sender">Удаляемый элемент</param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentNullException">При sender null</exception>
	/// <exception cref="InvalidDataException">При sender неправильного типа</exception>
	private void ItemRemoved (object? sender, EventArgs e)
	{
		var lv = sender switch
		{
			Electives.Plan => this.listViewPlans,
			Electives.Student => this.listViewStudents,
			Electives.Class => this.listViewClasses,
		
			null => throw new ArgumentNullException("FormMain.ItemAdded: sender is null"),
			_ => throw new InvalidDataException("FormMain.ItemAdded: sender is unknown")
		};

		for (int i = 0; i < lv.Items.Count; i++) {
			if (lv.Items[i].Tag == sender){
				lv.Items.RemoveAt(i);
			}
		}
	}
}
