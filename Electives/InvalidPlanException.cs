namespace Electives.Exception;

//SYSLIB0051: Legacy serialization support APIs are obsolete since .NET 8

public class InvalidPlanException : System.Exception
{
	/// <summary> Пустой конструктор </summary>
	public InvalidPlanException() : base() { }

	/// <summary> Конструктор с сообщением </summary>
	/// <param name="msg">Сообщение</param>
	public InvalidPlanException(string msg) : base(msg) { }
	
	/// <summary> Конструктор со вложенным исключением и сообщением </summary>
	/// <param name="msg">Сообщение</param>
	/// <param name="inner">Вложенное исключение</param>
	public InvalidPlanException(string msg, System.Exception? inner) : base(msg, inner) { }
}
