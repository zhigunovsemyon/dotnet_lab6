using Electives;

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

		var form = new FormPlan(oldPlan.Clone());
		DialogResult res = form.ShowDialog();

		if (DialogResult.Retry == res) {
			MessageBox.Show("Неправильно указаны данные!");
			return;
		}

		if (DialogResult.OK != res) {
			return;
		}

		try {
			Journal.Get.AddPlan(form.Plan);
			Journal.Get.RemovePlan(oldPlan);
		}
		catch (Electives.Exception.InvalidPlanException ex) {
			MessageBox.Show(
				"Не удалось добавить элемент!\n" + ex.Message,
				"Ошибка"
			);
		}
		this.UpdatePlanListView();
	}

	//todo: коменты
	private void UpdatePlanListView ()
	{
		this.listViewPlans.Items.Clear();

		foreach (var plan in Journal.Get.ListPlans) {
			this.listViewPlans.Items.Add(CreatePlanListViewItem(plan));
		}
	}

	private static ListViewItem CreatePlanListViewItem (Electives.Plan plan)
	{
		ListViewItem item = new() { Tag = plan, Text = plan.Student.ToString() };

		item.SubItems.Add(plan.Class.ToString());
		item.SubItems.Add(plan.Mark.ToString());

		return item;
	}
}