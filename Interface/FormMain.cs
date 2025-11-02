using Electives;

namespace Interface;

/// <summary> Основная форма </summary>
public partial class FormMain : Form
{
	public FormMain () => this.InitializeComponent();

	/// <summary> Метод для закрытия приложения через пункт меню </summary>
	private void CloseButton_Click (object sender, EventArgs e) => this.Close();
}
