namespace Electives;

/// <summary> Класс, содержащий все необходимые коллекции </summary>
public class Journal
{
	/// <summary> Закрытый конструктор </summary>
	private Journal () { }

	/// <summary> Экземпляр класса </summary>
	private static Journal? _instance = null;

	/// <summary> Геттер класса  </summary>
	public static Journal Get => (_instance is null) ? (_instance = new Journal()) : _instance;


	/// <summary> Список студентов </summary>
	private readonly Dictionary<int, Electives.Student> _students = [];

	/// <summary> Список занятий </summary>
	private readonly Dictionary<int, Electives.Class> _classes = [];

	/// <summary> Список планов </summary>
	private readonly List<Electives.Plan> _plans = [];


	/// <summary> Коллекция студентов </summary>
	public IEnumerable<Electives.Student> ListStudents => _students.Values;

	/// <summary> Коллекция занятий </summary>
	public IEnumerable<Electives.Class> ListClasses => _classes.Values;

	/// <summary> Коллекция планов </summary>
	public IEnumerable<Electives.Plan> ListPlans => _plans;

	/// <summary> Ивент, возникающий по добавлении студента</summary>
	public event EventHandler? StudentAdded = null;

	/// <summary> Ивент, возникающий по удалении студента </summary>
	public event EventHandler? StudentRemoved = null;

	/// <summary> Ивент, возникающий по добавлении предмета</summary>
	public event EventHandler? ClassAdded = null;

	/// <summary> Ивент, возникающий по удалении предмета</summary>
	public event EventHandler? ClassRemoved = null;

	/// <summary> Ивент, возникающий по добавлении учебного плана</summary>
	public event EventHandler? PlanAdded = null;

	/// <summary> Ивент, возникающий по удалении учебного плана</summary>
	public event EventHandler? PlanRemoved = null;


	/// <summary> Добавление нового студента в коллекцию </summary>
	/// <param name="newStudent">Добавляемый студент</param>
	/// <exception cref="Exception.InvalidStudentException">Ошибка в случае неправильных данных</exception>
	public void AddStudent (Electives.Student? newStudent)
	{
		if (newStudent?.IsValid != true) {
			throw new Exception.InvalidStudentException("Неправильно указаны данные!");
		}

		try {
			if (this._students.TryAdd(newStudent.Id, newStudent)) {
				this.StudentAdded?.Invoke(newStudent, EventArgs.Empty);
			} else {
				var plansToUpdate = this._plans.FindAll(p => p.Student.Id == newStudent.Id).AsEnumerable();
				var oldStudent = this._students[newStudent.Id];

				this._students[newStudent.Id] = newStudent;
				this.StudentAdded?.Invoke(newStudent, EventArgs.Empty);

				UpdateStudentsInPlans(plansToUpdate, newStudent);

				this.StudentRemoved?.Invoke(oldStudent, EventArgs.Empty);
			}
		}
		catch (System.Exception ex) {
			throw new Exception.InvalidStudentException("При добавлении студента возникла ошибка!", ex);
		}
	}

	/// <summary> Обновление всех планов, содержащих заменённого студента </summary>
	/// <param name="plansToUpdate"></param>
	/// <param name="newStudent"></param>
	private static void UpdateStudentsInPlans(IEnumerable<Electives.Plan> plansToUpdate, Electives.Student newStudent)
	{
		foreach (var oldPlan in plansToUpdate) { 
			var updatedPlan = oldPlan.Clone();
			updatedPlan.Student = newStudent;

			Journal.Get.AddPlan(updatedPlan);
			Journal.Get.RemovePlan(oldPlan);
		}
	}

	/// <summary> Обновление всех планов, содержащих заменённый предмет </summary>
	/// <param name="plansToUpdate"></param>
	/// <param name="newClass"></param>
	private static void UpdateClassesInPlans(IEnumerable<Electives.Plan> plansToUpdate, Electives.Class newClass)
	{
		foreach (var oldPlan in plansToUpdate) { 
			var updatedPlan = oldPlan.Clone();
			updatedPlan.Class = newClass;

			Journal.Get.AddPlan(updatedPlan);
			Journal.Get.RemovePlan(oldPlan);
		}
	}

	/// <summary> Добавление нового предмета в коллекцию </summary>
	/// <param name="newClass"> Добавляемый предмет </param>
	/// <exception cref="Exception.InvalidClassException"> Ошибка в случае неправильных данных </exception>
	public void AddClass (Electives.Class? newClass)
	{
		if (newClass?.IsValid != true) {
			throw new Exception.InvalidClassException("Неправильно указаны данные!");
		}

		try {
			if (this._classes.TryAdd(newClass.Id, newClass)){
				this.ClassAdded?.Invoke(newClass, EventArgs.Empty);
			} else {
				var plansToUpdate = this._plans.FindAll(p => p.Class.Id == newClass.Id).AsEnumerable();
				var oldClass= this._classes[newClass.Id];

				this._classes[newClass.Id] = newClass;
				this.ClassAdded?.Invoke(newClass, EventArgs.Empty);

				UpdateClassesInPlans(plansToUpdate, newClass);

				this.ClassRemoved?.Invoke(oldClass, EventArgs.Empty);
			}
		}
		catch (System.Exception ex) {
			throw new Exception.InvalidClassException("При добавлении предмета возникла ошибка!", ex);
		}
	}

	/// <summary> Добавление нового учебного плана в коллекцию </summary>
	/// <param name="plan"> Добавляемый план </param>
	/// <exception cref="Exception.InvalidPlanException"> Ошибка в случае неправильных данных </exception>
	public void AddPlan (Electives.Plan? plan)
	{
		if (plan?.IsValid != true) {
			throw new Exception.InvalidPlanException("Неправильно указаны данные!");
		}

		this._plans.Add(plan);
		try {
			this.PlanAdded?.Invoke(plan, EventArgs.Empty);
		}
		catch (System.Exception ex) {
			throw new Exception.InvalidPlanException("При добавлении плана возникла ошибка!", ex);
		}
	}

	/// <summary> Удаление неактуального учебного плана </summary>
	/// <param name="plan"> Удаляемый план </param>
	public void RemovePlan (Electives.Plan? plan)
	{
		if (plan != null) {
			this.PlanRemoved?.Invoke(plan, EventArgs.Empty);
			this._plans.Remove(plan);
		}
	}

	/// <summary> Удаление неактуального занатия с очисткой планов </summary>
	/// <param name="class"> Удаляемое занятие </param>
	public void RemoveClass (Electives.Class? @class)
	{
		if (@class is null) {
			return;
		}

		this._classes.Remove(@class.Id);

		//todo: проверить на корректность (в примере обращаются через ListPlans, используется for loop)
		var plansToDelete = this._plans.FindAll(item => item.Class.Id == @class.Id);
		foreach (var item in plansToDelete) {
			this.RemovePlan(item);
		}
		this.ClassRemoved?.Invoke(@class, EventArgs.Empty);
	}

	/// <summary> Удаление неактуального студента с очисткой планов </summary>
	/// <param name="student"> Удаляемый студент </param>
	public void RemoveStudent (Electives.Student? student)
	{
		if (student is null) {
			return;
		}

		this._students.Remove(student.Id);

		//todo: проверить на корректность (в примере обращаются через ListPlans, используется for loop)
		var plansToDelete = this._plans.FindAll(item => item.Student.Id == student.Id);
		foreach (var item in plansToDelete) {
			this.RemovePlan(item);
		}
		this.StudentRemoved?.Invoke(student, EventArgs.Empty);
	}
}
