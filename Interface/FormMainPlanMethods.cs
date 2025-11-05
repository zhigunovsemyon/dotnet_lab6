using Electives;
using System.Diagnostics;

namespace Interface;

public partial class FormMain : Form
{
	/// <summary> Обработчик создания нового плана </summary>
	private void PlanAddStripMenuItem_Click (object sender, EventArgs e)
		=> this.AddOrEditPlan(new Electives.Plan());

	/// <summary> Обработчик редактирования плана </summary>
	private void PlanEditStripMenuItem_Click (object sender, EventArgs e)
	{
		if (listViewPlans.SelectedItems.Count <= 0) {
			MessageBox.Show("Не выбран редактируемый элемент");
			return;
		}
		if (listViewPlans.SelectedItems[0].Tag is not Electives.Plan origPlan) {
			MessageBox.Show("selected list item is not plan");
			return;
		}

		this.AddOrEditPlan(origPlan);
	}

	/// <summary> Обработчик редактирования плана по двойному нажатию </summary>
	/// <param name="sender"> Список планов в форме </param>
	/// <param name="e"> Параметры мыши </param>
	private void listViewPlans_MouseDoubleClick (object sender, MouseEventArgs e)
	{
		if (e.Button != MouseButtons.Left) {
			return;
		}
		if (sender is not ListView list) {
			MessageBox.Show("sender is not ListView or null");
			return;
		}
		if (list.SelectedItems[0].Tag is not Electives.Plan origPlan) {
			MessageBox.Show("selected list item is not plan");
			return;
		}

		this.AddOrEditPlan(origPlan);
	}

	/// <summary>
	/// Метод для вызова и обработки результата работы формы изменения плана
	/// </summary>
	/// <param name="plan">Обрабатываемый план</param>
	/// <returns> Изменённый план при успехе, null при неудаче </returns>
	private void AddOrEditPlan (Electives.Plan? oldPlan)
	{
		if (oldPlan == null) {
			MessageBox.Show(
				"AddOrEditPlan: plan is null",
				"Внутренняя ошибка"
			);
			throw new Electives.Exception.InvalidPlanException("AddOrEditPlan: plan is null");
		}

		this._formPlan.Plan = oldPlan.Clone();
		DialogResult res = this._formPlan.ShowDialog();

		if (DialogResult.Retry == res) {
			MessageBox.Show("Неправильно указаны данные!");
			return;
		}

		if (DialogResult.OK != res) {
			return;
		}

		try {
			Journal.Get.AddPlan(this._formPlan.Plan);
			Journal.Get.RemovePlan(oldPlan);
		}
		catch (Electives.Exception.InvalidPlanException ex) {
			MessageBox.Show(
				"Не удалось добавить элемент!\n" + ex.Message,
				"Ошибка"
			);
		}
	}

	//todo: коменты
	private static ListViewItem CreatePlanListViewItem (Electives.Plan plan)
	{
		ListViewItem item = new() { Tag = plan, Text = plan.Student.ToString() };

		item.SubItems.Add(plan.Class.ToString());
		item.SubItems.Add(plan.Mark.ToString());

		return item;
	}

	private void listViewPlans_KeyUp (object sender, KeyEventArgs e)
	{
		if (e.KeyCode != Keys.Delete) {
			return;
		}

		var lvPlans = sender as ListView ?? throw new InvalidCastException("listViewPlans_KeyUp sender must be ListView");
		if (lvPlans.SelectedItems.Count <= 0) {
			return;
		}
		Debug.Assert(lvPlans.SelectedItems.Count == 1);

		var plan = lvPlans.SelectedItems[0].Tag as Electives.Plan ?? throw new NullReferenceException { };
		if (VerifyDeletion(plan.ToString()) != DialogResult.Yes) {
			return;
		}

		//todo: очистка формы от планов по удалению элементов из плана (вероятно закроется ивентами)
		Journal.Get.RemovePlan(plan);
	}
}