namespace Interface
{
	/// <summary> Форма изменения данных о студенте </summary>
	public partial class FormStudent : Form
	{
		/// <summary> Конструктор формы </summary>
		/// <param name="student">Обрабатываемый студент</param>
		public FormStudent(Electives.Student student)
		{
			InitializeComponent();
			this.Student = student;		
		}

		/// <summary>
		/// Метод, наполняющий все поля формы данными из переданного студента.
		/// Вызывается автоматически при запуске формы
		/// </summary>
		private void SetBoxes(object sender, EventArgs e)
		{
			this.textBoxSurname.Text = this.Student.Surname;
			this.textBoxName.Text = this.Student.Name;
			this.textBoxPatronim.Text = this.Student.Patronim;
			this.maskedTextBoxPhone.Text = this.Student.Phone;

			this.textBoxRegion.Text = this.Student.Address.Region;
			this.textBoxCity.Text = this.Student.Address.City;
			this.textBoxStreet.Text = this.Student.Address.Street;
			this.textBoxHouse.Text = this.Student.Address.House;
			this.textBoxBuilding.Text = this.Student.Address.Building;
		}

		/// <summary>
		/// Метод, заполняющий свойства студента данными из полей формы.
		/// Вызывается при нажатии пользователем кнопки "ОК"
		/// </summary>
		private void GetFromBoxes()
		{
			this.Student.Surname = this.textBoxSurname.Text;
			this.Student.Name = this.textBoxName.Text;
			this.Student.Patronim = this.textBoxPatronim.Text;
			this.Student.Phone = this.maskedTextBoxPhone.Text;

			this.Student.Address.Region = this.textBoxRegion.Text;
			this.Student.Address.City = this.textBoxCity.Text;
			this.Student.Address.Street = this.textBoxStreet.Text;
			this.Student.Address.House = this.textBoxHouse.Text;
			this.Student.Address.Building = this.textBoxBuilding.Text;
		}

		/// <summary> Обрабатываемый формой студент </summary>
		public Electives.Student Student { get; private set; }

		/// <summary> Обработчик нажатия на кнопку "ОК" </summary>
		private void ok_button_Click(object sender, EventArgs e)
		{
			GetFromBoxes();
			Close();
		}

		/// <summary>
		/// Обработчик по завершению изменения поля формы.
		/// Убирает в каждом текстовом поле пробелы перед и после содержимым.
		/// </summary>
		private void TextBoxTrimAll(object sender, EventArgs e)
		{
			this.textBoxSurname.Text = this.textBoxSurname.Text.Trim();
			this.textBoxName.Text = this.textBoxName.Text.Trim();
			this.textBoxPatronim.Text = this.textBoxPatronim.Text.Trim();
			this.maskedTextBoxPhone.Text = this.maskedTextBoxPhone.Text.Trim();

			this.textBoxRegion.Text = this.textBoxRegion.Text.Trim();
			this.textBoxCity.Text = this.textBoxCity.Text.Trim();
			this.textBoxStreet.Text = this.textBoxStreet.Text.Trim();
			this.textBoxHouse.Text = this.textBoxHouse.Text.Trim();
			this.textBoxBuilding.Text = this.textBoxBuilding.Text.Trim();
		}
	}

}
