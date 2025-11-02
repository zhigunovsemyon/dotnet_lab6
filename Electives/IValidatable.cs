namespace Electives;

/// <summary>
/// Интерфейс позволяет внедрить в класс метод проверки на корректность
/// </summary>
internal interface IValidatable
{
	/// <summary> Проверка класса на корректность </summary>
	bool IsValid { get; }
}
