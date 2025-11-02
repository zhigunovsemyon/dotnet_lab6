namespace Interface
{
	/// <summary> Форма изменения информации о занятии </summary>
	public partial class FormClass : Form
	{
		/// <summary> Конструктор формы </summary>
		/// <param name="class">Обрабатываемое занятие</param>
		public FormClass(Electives.Class @class)
		{
			InitializeComponent();
			this.Class = @class;
		}

		/// <summary>
		/// Обработчик по запуске формы. 
		/// Наполняет поля формы данными из предмета, переданного в конструкторе
		/// </summary>
		private void SetBoxes(object sender, EventArgs e)
		{
			this.textBoxName.Text = this.Class.Name;
			this.numericUpDownLectionsInput.Value = this.Class.Lections;
			this.numericUpDownPracticeInput.Value = this.Class.Practices;
			this.numericUpDownLabsInput.Value = this.Class.LabWorks;
		}

		/// <summary>
		/// Метод, заполняющий свойства предмета данными из полей формы.
		/// Вызывается при нажатии пользователем кнопки "ОК"
		/// </summary>
		private void GetFromBoxes()
		{
			this.Class.Name = this.textBoxName.Text;
			this.Class.Lections = ((int)this.numericUpDownLectionsInput.Value);
			this.Class.Practices = ((int)this.numericUpDownPracticeInput.Value);
			this.Class.LabWorks = ((int)this.numericUpDownLabsInput.Value);
		}

		/// <summary> Свойство с занятием, обрабатываемым данной формой </summary>
		public Electives.Class Class { get; set; }

		/// <summary> Обработчик нажатия пользователем клавиши "ОК" </summary>
		private void OkButton_Click(object sender, EventArgs e)
		{
			GetFromBoxes();

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		/// <summary>
		/// Очистка поля названия предмета от пробелов в начале и конце.
		/// Вызывается при завершении работы с полем
		/// </summary>
		private void ClassNameBox_LostFocus(object sender, EventArgs e)
		{
			this.textBoxName.Text = this.textBoxName.Text.Trim();
		}
	}
}
