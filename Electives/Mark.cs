using System.Threading;

namespace Electives;

/// <summary>Оценка</summary>
/// <param name="t">Значение</param>
public class Mark (Mark.Type t = Mark.Type.None)
{
	/// <summary>Возможное значение оценки</summary>
	public enum Type : byte
	{
		/// <summary>Пустая ячейка</summary>
		None,
		/// <summary>Пропуск</summary>
		Skip,
		/// <summary>Два</summary>
		Two,
		/// <summary>Три</summary>
		Three,
		/// <summary>Четыре</summary>
		Four,
		/// <summary>Пять</summary>
		Five,
		/// <summary>Особое отличие</summary>
		Extra
	}

	/// <summary> Массив со всеми возможными значениями типов </summary>
	static public Mark[] Types { get; } = [
		new Mark(Type.None),
		new Mark(Type.Skip),
		new Mark(Type.Two),
		new Mark(Type.Three),
		new Mark(Type.Four),
		new Mark(Type.Five),
		new Mark(Type.Extra)
	];

	/// <summary> Свойство со значением оценки </summary>
	public Type Value { get; set; } = t;

	public override string ToString ()
	{
		return Value switch
		{
			Type.None => "-",
			Type.Skip => "н",
			Type.Two => "2",
			Type.Three => "3",
			Type.Four => "4",
			Type.Five => "5",
			Type.Extra => "5*",
			_ => throw new NotImplementedException()
		};
	}
}
