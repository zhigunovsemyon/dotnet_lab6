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
	public Plan () { }

	/// <summary>Конструктор плана с уже заданной оценкой</summary>
	/// <param name="student">Студент</param>
	/// <param name="class">Предмет</param>
	/// <param name="mark">Оценка</param>
	public Plan (Student student, Class @class, Mark mark)
	{
		this.Student = student;
		this.Class = @class;
		this.Mark = mark;
	}

	/// <summary>Конструктор плана без оценки</summary>
	/// <param name="student">Студент</param>
	/// <param name="class">Предмет</param>
	public Plan (Student student, Class @class)
	{
		this.Student = student;
		this.Class = @class;
		this.Mark = new Mark();
	}

	public bool IsValid => (Student?.IsValid ?? false) && (Class?.IsValid ?? false);

	/// <summary> Создание копии текущего плана </summary>
	/// <returns>Копия плана</returns>
	public Plan Clone () => new(Student.Clone(), Class.Clone(), new Mark(this.Mark.Value));
}
