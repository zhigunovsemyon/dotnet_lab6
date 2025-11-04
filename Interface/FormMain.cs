using Electives;

namespace Interface;

/// <summary> Основная форма </summary>
public partial class FormMain : Form
{
	public FormMain () => this.InitializeComponent();

	/// <summary> Метод для закрытия приложения через пункт меню </summary>
	private void CloseButton_Click (object sender, EventArgs e) => this.Close();

	/// <summary> Запрос подтверждения от пользователя удаления </summary>
	/// <param name="text">Текст в окне</param>
	/// <returns>Ответ пользователя</returns>
	private static DialogResult VerifyDeletion (string item)
		=> MessageBox.Show($"Удалить {item}?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
}
