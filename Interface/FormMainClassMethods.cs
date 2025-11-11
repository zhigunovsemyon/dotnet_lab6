using Electives;
using System.Diagnostics;

namespace Interface;

public partial class FormMain : Form
{
	/// <summary>
	/// Метод для вызова и обработки результата работы формы изменения занятия
	/// </summary>
	/// <param name="class">Обрабатываемое занятие</param>
	private void AddOrEditClass (Electives.Class? @class)
	{
		if (@class == null) {
			MessageBox.Show(
				"AddOrEditClass: class is null",
				"Внутренняя ошибка"
			);
			throw new Electives.Exception.InvalidClassException("AddOrEditClass: class is null");
		}

		var form = _formClass;
		form.Class = @class;
		if (DialogResult.OK != form.ShowDialog()) {
			return;
		}

		try {
			Journal.Get.AddClass(form.Class);
		}
		catch (Electives.Exception.InvalidClassException ex) {
			MessageBox.Show(
				"Не удалось добавить элемент!\n" + ex.Message,
				"Ошибка"
			);
		}
	}
	/// <summary> Обработчик создания нового занятия </summary>
	private void ClassAddStripMenuItem_Click (object sender, EventArgs e)
		=> this.AddOrEditClass(new Class());

	/// <summary> Обработчик редактирования существующего занятия </summary>
	private void ClassEditStripMenuItem_Click (object sender, EventArgs e)
	{
		if (listViewClasses.SelectedItems.Count <= 0) {
			MessageBox.Show("Не выбран редактируемый элемент");
			return;
		}
		this.AddOrEditClass(listViewClasses.SelectedItems[0].Tag as Electives.Class);

	}

	/// <summary> Создание элемента списка занятий для формы </summary>
	/// <param name="class">Предмет, из которого создаётся запись</param>
	/// <returns>Созданная запись</returns>
	private static ListViewItem CreateClassListViewItem (Electives.Class @class)
	{
		var item = new ListViewItem { Tag = @class, Text = @class.Name };

		item.SubItems.Add(@class.Lections.ToString());
		item.SubItems.Add(@class.LabWorks.ToString());
		item.SubItems.Add(@class.Practices.ToString());

		return item;
	}

	/// <summary> Ивент для двойного нажатия по предмету в форме </summary>
	/// <param name="sender"> Список предмету в форме </param>
	/// <param name="e"> Параметры мыши </param>
	private void listViewClasses_MouseDoubleClick (object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left) {
			return;
		}
		if (sender is not ListView list) {
			MessageBox.Show("sender is not ListView or null");
			return;
		}

		if (list.SelectedItems[0].Tag is not Electives.Class @class) {
			MessageBox.Show("selected list item is not class");
			return;
		}
		this.AddOrEditClass(@class);
	}

	/// <summary> Ивент для нажатия на клавишу Delete в окне предметов </summary>
	/// <param name="sender">ListView с предметами</param>
	/// <param name="e">Нажатая клавиша</param>
	/// <exception cref="InvalidCastException">При элементе e, отличном от ListVIew</exception>
	/// <exception cref="NullReferenceException">Если Tag выбранного элемента не Electives.Class</exception>
	private void listViewClasses_KeyUp (object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Delete) {
			return;
		}

		var lvClasses = sender as ListView ?? throw new InvalidCastException("listViewClasses_KeyUp sender must be ListView");
		if (lvClasses.SelectedItems.Count <= 0) {
			return;
		}
		Debug.Assert(lvClasses.SelectedItems.Count == 1);

		var @class = lvClasses.SelectedItems[0].Tag as Electives.Class ?? throw new InvalidCastException { };
		if (VerifyDeletion(@class.ToString()) != DialogResult.Yes) {
			return;
		}

		Journal.Get.RemoveClass(@class);
	}
}
