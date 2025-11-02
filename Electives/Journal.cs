namespace Electives;

/// <summary> Класс, содержащий все необходимые коллекции </summary>
public static class Journal
{
	/// <summary> Список студентов </summary>
	public static Dictionary<int, Electives.Student> ListStudents { get; } = [];

	/// <summary> Список занятий </summary>
	public static Dictionary<int, Electives.Class> ListClasses { get; } = [];

	/// <summary> Список планов </summary>
	public static List<Electives.Plan> ListPlans { get; } = [];
}
