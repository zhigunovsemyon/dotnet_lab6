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
		//todo: InvalidStudentException
		if (student == null){
			throw new NotImplementedException("todo: InvalidStudentException");
		}
		if (!student.IsValid){
			throw new NotImplementedException("todo: InvalidStudentException");
		}

		this._students[student.Id] =student;
	}

	public void AddClass (Electives.Class? @class)
	{
		//todo: InvalidClassException
		if (@class == null) {
			throw new NotImplementedException("todo: InvalidClassException");
		}
		if (!@class.IsValid) { 
			throw new NotImplementedException("todo: InvalidClassException");
		}

		this._classes[@class.Id] = @class;
	}

	public void AddPlan (Electives.Plan? plan)
	{
		// todo: InvalidPlanException
		if (plan == null) {
			throw new NotImplementedException("todo: InvalidPlanException");
		}
		if (!plan.IsValid) {
			throw new NotImplementedException("todo: InvalidPlanException");
		}

		// todo: так ли будем менять существующие записи?
		this._plans.Remove(plan);
		this._plans.Add(plan);
	}
}
