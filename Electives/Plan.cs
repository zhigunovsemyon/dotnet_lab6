using System.Diagnostics;

namespace Electives;

/// <summary>
/// Учебный план для студента по предмету
/// </summary>
public class Plan : IValidatable
{
	/// <summary> Студент </summary>
	public Student Student { get; set; } = new Student();

	/// <summary> Предмет </summary>
	public Class Class { get; set; } = new Class();

	/// <summary> Оценка </summary>
	public Mark Mark { get; set; } = new Mark();

	public override string ToString () => $"{Student}, предмет: {Class.Name}, оценка {Mark}";

	/// <summary>
	/// Конструктор пустого плана. Содержит пустого студента и занятие.
	/// </summary>
	public Plan () {}

	/// <summary>Конструктор плана с уже заданной оценкой</summary>
	/// <param name="student">Студент</param>
	/// <param name="class">Предмет</param>
	/// <param name="mark">Оценка</param>
	public Plan (Student student, Class @class, Mark mark)
	{
		this.Student = student;
		this.Class = @class;
		this.Mark = mark;

		Journal.Get.ClassRemoved += this.ClassChangedOrRemoved;
		Journal.Get.StudentRemoved += this.StudentChangedOrRemoved;
	}

	public bool IsValid => (Student?.IsValid ?? false) && (Class?.IsValid ?? false);

	/// <summary> Создание копии текущего плана </summary>
	/// <returns>Копия плана</returns>
	public Plan Clone () => new(Student.Clone(), Class.Clone(), new Mark(this.Mark.Value));

	/// <summary> Проверка на наличие обновлённого студента в списке </summary>
	/// <param name="sender"> Старый студент (Electives.Student) </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentException"></exception>
	public void StudentChangedOrRemoved (object? sender, EventArgs e)
	{
		var oldStudent = sender as Electives.Student ?? 
			throw new ArgumentException("Plan.StudentChangedOrRemoved: sender null or not Student");

		if (this.Student.Id != oldStudent.Id) {
			return;
		}

		var journal = Journal.Get;
		var newStudent = FindNewStudent(journal.ListStudents, oldStudent.Id);

		if (newStudent is not null) {
			var newPlan = this.Clone();
			newPlan.Student = newStudent;
			journal.AddPlan(newPlan);
		}
		journal.RemovePlan(this);
	}

	/// <summary> Проверка на наличие обновлённого предмета в списке </summary>
	/// <param name="sender"> Старый предмет (Electives.Class) </param>
	/// <param name="e"></param>
	/// <exception cref="ArgumentException"></exception>
	public void ClassChangedOrRemoved (object? sender, EventArgs e)
	{
		var oldClass = sender as Electives.Class ?? 
			throw new ArgumentException("Plan.ClassChangedOrRemoved: sender null or not Class");

		if (this.Class.Id != oldClass.Id) {
			return;
		}

		var journal = Journal.Get;
		var newClass = FindNewClass(journal.ListClasses, oldClass.Id);

		if (newClass is not null) {
			var newPlan = this.Clone();
			newPlan.Class = newClass;
			journal.AddPlan(newPlan);
		}
		journal.RemovePlan(this);
	}

	/// <summary> Вспомогательная функция для поиска студента по id </summary>
	/// <param name="students">Список студентов</param>
	/// <param name="id">Идентификатор</param>
	/// <returns>Найденный студент или null</returns>
	private static Student? FindNewStudent (IEnumerable<Student> students, int id)
	{
		foreach (var student in students) {
			if (student.Id == id) {
				return student;
			}
		}
		return null;
	}

	/// <summary> Вспомогательная функция для поиска предмета по id </summary>
	/// <param name="classes">Список предметов</param>
	/// <param name="id">Идентификатор</param>
	/// <returns>Найденный предмет или null</returns>
	private static Class? FindNewClass (IEnumerable<Class> classes, int id)
	{
		foreach (var @class in classes) {
			if (@class.Id == id) {
				return @class;
			}
		}
		return null;
	}
}
