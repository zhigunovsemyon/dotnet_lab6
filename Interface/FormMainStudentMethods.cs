using Electives;
using System.Diagnostics;

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
			throw new Electives.Exception.InvalidStudentException("AddOrEditStudent: student is null");
		}

		var form = new FormStudent(student);
		if (DialogResult.OK != form.ShowDialog()) {
			return;
		}

		try {
			Journal.Get.AddStudent(form.Student);
		}
		catch (Electives.Exception.InvalidStudentException ex) {
			MessageBox.Show(
				"Не удалось добавить элемент!\n" + ex.Message,
				"Ошибка"
			);
		}
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
		
		this.AddOrEditStudent(student.Clone());
	}

	/// <summary> Ивент для нажатия на клавишу Delete в окне студентов </summary>
	/// <param name="sender">ListView со студентами</param>
	/// <param name="e">Нажатая клавиша</param>
	/// <exception cref="InvalidCastException">При элементе e, отличном от ListVIew</exception>
	/// <exception cref="NullReferenceException">Если Tag выбранного элемента не Electives.Student</exception>
	private void listViewStudents_KeyUp (object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Delete) {
			return;
		}

		var lvStudents = sender as ListView ?? throw new InvalidCastException("listViewStudents_KeyUp sender must be ListView");
		if (lvStudents.SelectedItems.Count <= 0) {
			return;
		}
		Debug.Assert(lvStudents.SelectedItems.Count == 1);

		var student = lvStudents.SelectedItems[0].Tag as Electives.Student ?? throw new InvalidCastException { };
		if (VerifyDeletion(student.ToString()) != DialogResult.Yes) {
			return;
		}

		Journal.Get.RemoveStudent(student);
	}
}