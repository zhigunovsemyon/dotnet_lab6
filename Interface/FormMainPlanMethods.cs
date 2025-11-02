using Electives;

namespace Interface;

public partial class FormMain : Form
{
	/// <summary> Обработчик создания нового плана </summary>
	private void PlanAddStripMenuItem_Click (object sender, EventArgs e)
	{
		var newPlan = AddOrEditPlan(new Electives.Plan());
		if (newPlan == null) {
			return;
		}

		Journal.ListPlans.Add(newPlan);
		UpdatePlanListView();
	}

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

		var newPlan = AddOrEditPlan(origPlan.Clone());
		if (newPlan == null) {
			return;
		}

		Journal.ListPlans.Remove(origPlan);
		Journal.ListPlans.Add(newPlan);
		UpdatePlanListView();
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

		var newPlan = AddOrEditPlan(origPlan.Clone());
		if (newPlan == null) {
			return;
		}

		Journal.ListPlans.Remove(origPlan);
		Journal.ListPlans.Add(newPlan);
		UpdatePlanListView();
	}

	/// <summary>
	/// Метод для вызова и обработки результата работы формы изменения плана
	/// </summary>
	/// <param name="plan">Обрабатываемый план</param>
	/// <returns> Изменённый план при успехе, null при неудаче </returns>
	private static Electives.Plan? AddOrEditPlan (Electives.Plan? plan)
	{
		if (plan == null) {
			MessageBox.Show(
				"AddOrEditPlan: plan is null",
				"Внутренняя ошибка"
			);
			return null;
		}

		var form = new FormPlan(plan);
		DialogResult res = form.ShowDialog();

		if (DialogResult.Retry == res) {
			MessageBox.Show("Неправильно указаны данные!");
			return null;
		}

		if (DialogResult.OK != res) {
			return null;
		}

		if (form.Plan == null) {
			MessageBox.Show(
				"PlanEditForm вернула null",
				"Внутренняя ошибка"
			);
			return null;
		}
		if (!form.Plan.IsValid) {
			MessageBox.Show("Неправильно указаны данные!");
			return null;
		}

		return form.Plan;
	}

	private void UpdatePlanListView ()
	{
		this.listViewPlans.Items.Clear();

		foreach (var plan in Journal.ListPlans) {
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