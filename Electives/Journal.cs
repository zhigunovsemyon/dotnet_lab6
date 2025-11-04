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
	private Dictionary<int, Electives.Student> _students = [];

	/// <summary> Список занятий </summary>
	private Dictionary<int, Electives.Class> _classes = [];

	/// <summary> Список планов </summary>
	private List<Electives.Plan> _plans = [];


	/// <summary> Коллекция студентов </summary>
	public IEnumerable<Electives.Student> ListStudents => _students.Values;

	/// <summary> Коллекция занятий </summary>
	public IEnumerable<Electives.Class> ListClasses => _classes.Values;

	/// <summary> Коллекция планов </summary>
	public IEnumerable<Electives.Plan> ListPlans => _plans;


	/// <summary> Добавление нового студента в коллекцию </summary>
	/// <param name="student">Добавляемый студент</param>
	/// <exception cref="Exception.InvalidStudentException">Ошибка в случае неправильных данных</exception>
	public void AddStudent (Electives.Student? student)
	{
		if (student?.IsValid != true) {
			throw new Exception.InvalidStudentException("Неправильно указаны данные!");
		}

		this._students[student.Id] = student;
	}

	/// <summary> Добавление нового предмета в коллекцию </summary>
	/// <param name="class"> Добавляемый предмет </param>
	/// <exception cref="Exception.InvalidClassException"> Ошибка в случае неправильных данных </exception>
	public void AddClass (Electives.Class? @class)
	{
		if (@class?.IsValid != true) {
			throw new Exception.InvalidClassException("Неправильно указаны данные!");
		}

		this._classes[@class.Id] = @class;
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
	}

	/// <summary> Удаление неактуального учебного плана </summary>
	/// <param name="plan"> Удаляемый план </param>
	public void RemovePlan (Electives.Plan? plan)
	{
		if (plan != null) {
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
		var plansToDelete = this._plans.FindAll( item => item.Class.Id == @class.Id);
		foreach ( var item in plansToDelete ) {
			this.RemovePlan(item);
		}
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
		var plansToDelete = this._plans.FindAll( item => item.Student.Id == student.Id);
		foreach ( var item in plansToDelete ) {
			this.RemovePlan(item);
		}
	}
}
