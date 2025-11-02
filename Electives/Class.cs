namespace Electives;

/// <summary> Предмет </summary>
public class Class : IValidatable
{
	/// <summary> Счётчик идентификаторов  </summary>
	private static int s_newId = 0;

	/// <summary> Свойство, возвращающее новый идентификатор для объекта </summary>
	private static int NewId => s_newId++;

	/// <summary> Идентификатор </summary>
	public int Id { get; init; }

	/// <summary>
	/// Конструктор пустого предмета.
	/// Все свойства занулены
	/// </summary>
	public Class () => this.Id = NewId;

	/// <summary>
	/// Параметризованный конструктор предмета
	/// </summary>
	/// <param name="name">Название предмета</param>
	/// <param name="lections">Объём лекционных занятий</param>
	/// <param name="practices">Объём практик</param>
	/// <param name="lab_works">Объём лабораторных работ</param>
	public Class (string name, int lections, int practices, int lab_works)
	{
		this.Id = NewId;
		this.Name = name;
		this.Lections = lections;
		this.Practices = practices;
		this.LabWorks = lab_works;
	}

	/// <summary>
	/// Должно быть имя и хотя бы одно занятие любого типа
	/// </summary>
	public bool IsValid => !(string.IsNullOrWhiteSpace(this.Name) ||
				(this.Lections + this.LabWorks + this.Practices) == 0);

	/// <summary> Название предмета </summary>
	public string Name { get; set; } = "";

	/// <summary> Количество лекций </summary>
	public int Lections { get; set; } = 0;

	/// <summary> Количество практик </summary>
	public int Practices { get; set; } = 0;

	/// <summary> Количество лабораторных работ </summary>
	public int LabWorks { get; set; } = 0;

	public override string ToString ()
		=> $"{Name}: лекций:{Lections}, " +
			$"практик {Practices}, " +
			$"лабораторных работ {LabWorks}";


	/// <summary> Создаёт копию данного занятия </summary>
	/// <returns>Идентичное независимое занятие</returns>
	public Class Clone ()
	{
		return new Class
		{
			Name = this.Name,
			LabWorks = this.LabWorks,
			Lections = this.Lections,
			Practices = this.Practices,
			Id = this.Id
		};
	}
}
