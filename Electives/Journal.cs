namespace Electives;

/// <summary> Класс, содержащий все необходимые коллекции </summary>
public class Journal
{
	/// <summary> Закрытый конструктор </summary>
	private Journal() { }

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


	public void AddStudent(Electives.Student? student)
	{
		if (student == null){
			throw new Exception.InvalidStudentException("student is null");
		}
		if (!student.IsValid){
			throw new Exception.InvalidStudentException("Неправильно указаны данные!");
		}

		this._students[student.Id] =student;
	}

	public void AddClass (Electives.Class? @class)
	{
		if (@class == null) {
			throw new Exception.InvalidClassException("class is null");
		}
		if (!@class.IsValid) { 
			throw new Exception.InvalidClassException("Неправильно указаны данные!");
		}

		this._classes[@class.Id] = @class;
	}

	public void AddPlan (Electives.Plan? plan)
	{
		if (plan == null) {
			throw new Exception.InvalidPlanException("plan is null");
		}
		if (!plan.IsValid) {
			throw new Exception.InvalidPlanException("Неправильно указаны данные!");
		}

		// todo: так менять записи нельзя, старые не удаляются
		this._plans.Remove(plan);
		this._plans.Add(plan);
	}
}
