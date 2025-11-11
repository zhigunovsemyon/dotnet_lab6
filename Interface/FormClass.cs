namespace Interface;

/// <summary> Форма изменения информации о занятии </summary>
public partial class FormClass : Form
{
	/// <summary> Конструктор формы </summary>
	public FormClass () => InitializeComponent();

	private Electives.Class _class = new();

	/// <summary> Свойство с занятием, обрабатываемым данной формой </summary>
	public Electives.Class Class
	{
		get => _class;
		set
		{
			_class = value;
			this.textBoxName.Text = value.Name;
			this.numericUpDownLectionsInput.Value = value.Lections;
			this.numericUpDownPracticeInput.Value = value.Practices;
			this.numericUpDownLabsInput.Value = value.LabWorks;
		}
	}

	/// <summary> Обработчик нажатия пользователем клавиши "ОК" </summary>
	private void OkButton_Click (object sender, EventArgs e)
	{
		this.Class.Name = this.textBoxName.Text;
		this.Class.Lections = ((int)this.numericUpDownLectionsInput.Value);
		this.Class.Practices = ((int)this.numericUpDownPracticeInput.Value);
		this.Class.LabWorks = ((int)this.numericUpDownLabsInput.Value);

		this.DialogResult = DialogResult.OK;
		this.Close();
	}

	/// <summary>
	/// Очистка поля названия предмета от пробелов в начале и конце.
	/// Вызывается при завершении работы с полем
	/// </summary>
	private void ClassNameBox_LostFocus (object sender, EventArgs e)
		=> this.textBoxName.Text = this.textBoxName.Text.Trim();
}
