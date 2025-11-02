namespace Electives;

/// <summary> Адрес </summary>
public class Address : IValidatable
{
	/// <summary>Параметризованный конструктор</summary>
	/// <param name="region">Административный субъект</param>
	/// <param name="city">Город</param>
	/// <param name="street">Улица</param>
	/// <param name="house">Дом</param>
	/// <param name="building">Строение (опционально)</param>
	public Address (string region, string city, string street,
		string house, string building = "")
	{
		this.Region = region;
		this.City = city;
		this.Street = street;
		this.House = house;
		this.Building = building;
	}

	/// <summary>
	/// Конструктор пустого адреса.
	/// Заполняет всё пустыми строками
	/// </summary>
	public Address () { }

	/// <summary>Административный субъект</summary>
	public string Region { get; set; } = "";

	/// <summary>Город</summary>
	public string City { get; set; } = "";

	/// <summary>Улица</summary>
	public string Street { get; set; } = "";

	/// <summary>Дом</summary>
	public string House { get; set; } = "";

	/// <summary>Строение (пустое всё ещё корректно)</summary>
	public string Building { get; set; } = "";

	public bool IsValid => !(string.IsNullOrWhiteSpace(Region) ||
		string.IsNullOrWhiteSpace(City) ||
		string.IsNullOrWhiteSpace(Street) ||
		string.IsNullOrWhiteSpace(House) ||
		(Building == null));

	/// <summary>Создание копии данного адреса</summary>
	/// <returns>Копия исходного адреса</returns>
	public Address Clone ()
	{
		return new Address
		{
			Region = this.Region,
			City = this.City,
			Street = this.Street,
			House = this.House,
			Building = this.Building
		};
	}

	public override string ToString ()
		=> $"{Region}, {City}, улица {Street}, дом {House}"
		+ (string.IsNullOrWhiteSpace(this.Building) ? "" : $", строение {Building}");
}
