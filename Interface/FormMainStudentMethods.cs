using Electives;

namespace Interface;

public partial class FormMain : Form
{
	/// <summary>
	/// Метод для вызова и обработки результата работы формы изменения студента
	/// </summary>
	/// <param name="student">Обрабатываемый студент</param>
	private void AddOrEditStudent (Electives.Student? student)
	{
		if (student == null) {
			MessageBox.Show(
				"AddOrEditStudent: student is null",
				"Внутренняя ошибка"
			);
			return;
		}

		var form = new FormStudent(student);
		if (DialogResult.OK != form.ShowDialog()) {
			return;
		}

		Journal.Get.AddStudent(form.Student);
		UpdateStudentListView();
	}

	/// <summary> Обработчик поля создания нового студента </summary>
	private void StudentAddtoolStripMenuItem_Click (object sender, EventArgs e)
		=> this.AddOrEditStudent(new Student()); //Вызов формы на чистом студенте

	/// <summary> Обработчик редактирования существующего студента </summary>
	private void StudentEditToolStripMenuItem_Click (object sender, EventArgs e)
	{
		var selectedItemsList = listViewStudents.SelectedItems;
		if (selectedItemsList.Count <= 0) {
			MessageBox.Show("Не выбран редактируемый элемент");
			return;
		}
		//Вызов формы на копии исходного студента
		this.AddOrEditStudent(selectedItemsList[0].Tag as Electives.Student);
	}

	/// <summary> Обновление списка студентов в форме </summary>
	private void UpdateStudentListView ()
	{
		this.listViewStudents.Items.Clear();

		foreach (var item in Journal.Get.ListStudents) {
			this.listViewStudents.Items.Add(CreateStudentListViewItem(item));
		}
	}

	/// <summary> Создание записи со студентом для списка в форме </summary>
	/// <param name="student">Студент из которого создаётся запись</param>
	/// <returns> Запись для добавления </returns>
	private static ListViewItem CreateStudentListViewItem (Electives.Student student)
	{
		ListViewItem item = new() { Tag = student, Text = student.Surname };

		item.SubItems.Add(student.Name);
		item.SubItems.Add(student.Patronim);
		item.SubItems.Add(student.Phone);
		item.SubItems.Add(student.Address.ToString());

		return item;
	}

	/// <summary> Ивент для двойного нажатия по студенту в форме </summary>
	/// <param name="sender"> Список студентов в форме </param>
	/// <param name="e"> Параметры мыши </param>
	private void listViewStudents_MouseDoubleClick (object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left) {
			return;
		}
		if (sender is not ListView list) {
			MessageBox.Show("sender is not ListView or null");
			return;
		}
		if (list.SelectedItems[0].Tag is not Electives.Student student) {
			MessageBox.Show("selected list item is not student");
			return;
		}
		;
		this.AddOrEditStudent(student.Clone());
	}
}