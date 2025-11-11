namespace Interface
{
	partial class FormStudent
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.textBoxSurname = new TextBox();
			this.textBoxName = new TextBox();
			this.textBoxPatronim = new TextBox();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label5 = new Label();
			this.buttonOK = new Button();
			this.buttonClose = new Button();
			this.AddressBox = new GroupBox();
			this.label9 = new Label();
			this.textBoxBuilding = new TextBox();
			this.label8 = new Label();
			this.textBoxHouse = new TextBox();
			this.label7 = new Label();
			this.textBoxStreet = new TextBox();
			this.label6 = new Label();
			this.textBoxCity = new TextBox();
			this.label4 = new Label();
			this.textBoxRegion = new TextBox();
			this.maskedTextBoxPhone = new MaskedTextBox();
			this.AddressBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxSurname
			// 
			this.textBoxSurname.Location = new Point(12, 35);
			this.textBoxSurname.MaxLength = 40;
			this.textBoxSurname.Name = "textBoxSurname";
			this.textBoxSurname.Size = new Size(178, 23);
			this.textBoxSurname.TabIndex = 0;
			this.textBoxSurname.LostFocus += this.TextBoxTrimAll;
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new Point(12, 82);
			this.textBoxName.MaxLength = 28;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new Size(178, 23);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.LostFocus += this.TextBoxTrimAll;
			// 
			// textBoxPatronim
			// 
			this.textBoxPatronim.Location = new Point(12, 132);
			this.textBoxPatronim.MaxLength = 28;
			this.textBoxPatronim.Name = "textBoxPatronim";
			this.textBoxPatronim.Size = new Size(178, 23);
			this.textBoxPatronim.TabIndex = 2;
			this.textBoxPatronim.LostFocus += this.TextBoxTrimAll;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new Size(58, 15);
			this.label1.TabIndex = 5;
			this.label1.Text = "&Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new Point(12, 64);
			this.label2.Name = "label2";
			this.label2.Size = new Size(31, 15);
			this.label2.TabIndex = 6;
			this.label2.Text = "&Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new Point(12, 114);
			this.label3.Name = "label3";
			this.label3.Size = new Size(151, 15);
			this.label3.TabIndex = 7;
			this.label3.Text = "&Отчество (необязательно)";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new Point(12, 167);
			this.label5.Name = "label5";
			this.label5.Size = new Size(55, 15);
			this.label5.TabIndex = 9;
			this.label5.Text = "&Телефон";
			// 
			// buttonOK
			// 
			this.buttonOK.DialogResult = DialogResult.OK;
			this.buttonOK.Location = new Point(280, 243);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new Size(75, 23);
			this.buttonOK.TabIndex = 11;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += this.ok_button_Click;
			// 
			// buttonClose
			// 
			this.buttonClose.DialogResult = DialogResult.Cancel;
			this.buttonClose.Location = new Point(361, 243);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new Size(75, 23);
			this.buttonClose.TabIndex = 12;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			// 
			// AddressBox
			// 
			this.AddressBox.Controls.Add(this.label9);
			this.AddressBox.Controls.Add(this.textBoxBuilding);
			this.AddressBox.Controls.Add(this.label8);
			this.AddressBox.Controls.Add(this.textBoxHouse);
			this.AddressBox.Controls.Add(this.label7);
			this.AddressBox.Controls.Add(this.textBoxStreet);
			this.AddressBox.Controls.Add(this.label6);
			this.AddressBox.Controls.Add(this.textBoxCity);
			this.AddressBox.Controls.Add(this.label4);
			this.AddressBox.Controls.Add(this.textBoxRegion);
			this.AddressBox.Location = new Point(205, 0);
			this.AddressBox.Name = "AddressBox";
			this.AddressBox.Size = new Size(250, 226);
			this.AddressBox.TabIndex = 10;
			this.AddressBox.TabStop = false;
			this.AddressBox.Text = "Адрес студента";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new Point(88, 168);
			this.label9.Name = "label9";
			this.label9.Size = new Size(153, 15);
			this.label9.TabIndex = 21;
			this.label9.Text = "&Строение (необязательно)";
			// 
			// textBoxBuilding
			// 
			this.textBoxBuilding.Location = new Point(88, 186);
			this.textBoxBuilding.MaxLength = 5;
			this.textBoxBuilding.Name = "textBoxBuilding";
			this.textBoxBuilding.Size = new Size(146, 23);
			this.textBoxBuilding.TabIndex = 20;
			this.textBoxBuilding.LostFocus += this.TextBoxTrimAll;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new Point(6, 168);
			this.label8.Name = "label8";
			this.label8.Size = new Size(76, 15);
			this.label8.TabIndex = 19;
			this.label8.Text = "&Номер дома";
			// 
			// textBoxHouse
			// 
			this.textBoxHouse.Location = new Point(6, 186);
			this.textBoxHouse.MaxLength = 5;
			this.textBoxHouse.Name = "textBoxHouse";
			this.textBoxHouse.Size = new Size(76, 23);
			this.textBoxHouse.TabIndex = 18;
			this.textBoxHouse.LostFocus += this.TextBoxTrimAll;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new Point(6, 115);
			this.label7.Name = "label7";
			this.label7.Size = new Size(41, 15);
			this.label7.TabIndex = 17;
			this.label7.Text = "&Улица";
			// 
			// textBoxStreet
			// 
			this.textBoxStreet.Location = new Point(6, 133);
			this.textBoxStreet.MaxLength = 40;
			this.textBoxStreet.Name = "textBoxStreet";
			this.textBoxStreet.Size = new Size(228, 23);
			this.textBoxStreet.TabIndex = 16;
			this.textBoxStreet.LostFocus += this.TextBoxTrimAll;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new Point(6, 65);
			this.label6.Name = "label6";
			this.label6.Size = new Size(40, 15);
			this.label6.TabIndex = 15;
			this.label6.Text = "&Город";
			// 
			// textBoxCity
			// 
			this.textBoxCity.Location = new Point(6, 83);
			this.textBoxCity.MaxLength = 40;
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new Size(228, 23);
			this.textBoxCity.TabIndex = 14;
			this.textBoxCity.LostFocus += this.TextBoxTrimAll;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new Point(6, 18);
			this.label4.Name = "label4";
			this.label4.Size = new Size(46, 15);
			this.label4.TabIndex = 13;
			this.label4.Text = "&Регион";
			// 
			// textBoxRegion
			// 
			this.textBoxRegion.Location = new Point(6, 36);
			this.textBoxRegion.MaxLength = 40;
			this.textBoxRegion.Name = "textBoxRegion";
			this.textBoxRegion.Size = new Size(228, 23);
			this.textBoxRegion.TabIndex = 0;
			this.textBoxRegion.LostFocus += this.TextBoxTrimAll;
			// 
			// maskedTextBoxPhone
			// 
			this.maskedTextBoxPhone.Location = new Point(12, 185);
			this.maskedTextBoxPhone.Mask = "(999) 000-0000";
			this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
			this.maskedTextBoxPhone.Size = new Size(178, 23);
			this.maskedTextBoxPhone.TabIndex = 3;
			// 
			// FormStudent
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new Size(458, 278);
			this.Controls.Add(this.maskedTextBoxPhone);
			this.Controls.Add(this.AddressBox);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPatronim);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxSurname);
			this.FormBorderStyle = FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "FormStudent";
			this.ShowIcon = false;
			this.Text = "Информация о студенте";
			this.AddressBox.ResumeLayout(false);
			this.AddressBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		#endregion

		private TextBox textBoxSurname;
		private TextBox textBoxName;
		private TextBox textBoxPatronim;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label5;
		private Button buttonOK;
		private Button buttonClose;
		private GroupBox AddressBox;
		private Label label6;
		private TextBox textBoxCity;
		private Label label4;
		private TextBox textBoxRegion;
		private Label label9;
		private TextBox textBoxBuilding;
		private Label label8;
		private TextBox textBoxHouse;
		private Label label7;
		private TextBox textBoxStreet;
		private MaskedTextBox maskedTextBoxPhone;
	}
}