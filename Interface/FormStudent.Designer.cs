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
		private void InitializeComponent()
		{
			textBoxSurname = new TextBox();
			textBoxName = new TextBox();
			textBoxPatronim = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label5 = new Label();
			buttonOK = new Button();
			buttonClose = new Button();
			AddressBox = new GroupBox();
			label9 = new Label();
			textBoxBuilding = new TextBox();
			label8 = new Label();
			textBoxHouse = new TextBox();
			label7 = new Label();
			textBoxStreet = new TextBox();
			label6 = new Label();
			textBoxCity = new TextBox();
			label4 = new Label();
			textBoxRegion = new TextBox();
			maskedTextBoxPhone = new MaskedTextBox();
			AddressBox.SuspendLayout();
			SuspendLayout();
			// 
			// textBoxSurname
			// 
			textBoxSurname.Location = new Point(12, 35);
			textBoxSurname.MaxLength = 40;
			textBoxSurname.Name = "textBoxSurname";
			textBoxSurname.Size = new Size(178, 23);
			textBoxSurname.TabIndex = 0;
			textBoxSurname.LostFocus += TextBoxTrimAll;
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(12, 82);
			textBoxName.MaxLength = 28;
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(178, 23);
			textBoxName.TabIndex = 1;
			textBoxName.LostFocus += TextBoxTrimAll;
			// 
			// textBoxPatronim
			// 
			textBoxPatronim.Location = new Point(12, 132);
			textBoxPatronim.MaxLength = 28;
			textBoxPatronim.Name = "textBoxPatronim";
			textBoxPatronim.Size = new Size(178, 23);
			textBoxPatronim.TabIndex = 2;
			textBoxPatronim.LostFocus += TextBoxTrimAll;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 17);
			label1.Name = "label1";
			label1.Size = new Size(58, 15);
			label1.TabIndex = 5;
			label1.Text = "&Фамилия";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 64);
			label2.Name = "label2";
			label2.Size = new Size(31, 15);
			label2.TabIndex = 6;
			label2.Text = "&Имя";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 114);
			label3.Name = "label3";
			label3.Size = new Size(151, 15);
			label3.TabIndex = 7;
			label3.Text = "&Отчество (необязательно)";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(12, 167);
			label5.Name = "label5";
			label5.Size = new Size(55, 15);
			label5.TabIndex = 9;
			label5.Text = "&Телефон";
			// 
			// buttonOK
			// 
			buttonOK.DialogResult = DialogResult.OK;
			buttonOK.Location = new Point(280, 243);
			buttonOK.Name = "buttonOK";
			buttonOK.Size = new Size(75, 23);
			buttonOK.TabIndex = 11;
			buttonOK.Text = "OK";
			buttonOK.UseVisualStyleBackColor = true;
			buttonOK.Click += ok_button_Click;
			// 
			// buttonClose
			// 
			buttonClose.DialogResult = DialogResult.Cancel;
			buttonClose.Location = new Point(361, 243);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(75, 23);
			buttonClose.TabIndex = 12;
			buttonClose.Text = "Закрыть";
			buttonClose.UseVisualStyleBackColor = true;
			// 
			// AddressBox
			// 
			AddressBox.Controls.Add(label9);
			AddressBox.Controls.Add(textBoxBuilding);
			AddressBox.Controls.Add(label8);
			AddressBox.Controls.Add(textBoxHouse);
			AddressBox.Controls.Add(label7);
			AddressBox.Controls.Add(textBoxStreet);
			AddressBox.Controls.Add(label6);
			AddressBox.Controls.Add(textBoxCity);
			AddressBox.Controls.Add(label4);
			AddressBox.Controls.Add(textBoxRegion);
			AddressBox.Location = new Point(205, 0);
			AddressBox.Name = "AddressBox";
			AddressBox.Size = new Size(250, 226);
			AddressBox.TabIndex = 10;
			AddressBox.TabStop = false;
			AddressBox.Text = "Адрес студента";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(88, 168);
			label9.Name = "label9";
			label9.Size = new Size(153, 15);
			label9.TabIndex = 21;
			label9.Text = "&Строение (необязательно)";
			// 
			// textBoxBuilding
			// 
			textBoxBuilding.Location = new Point(88, 186);
			textBoxBuilding.MaxLength = 5;
			textBoxBuilding.Name = "textBoxBuilding";
			textBoxBuilding.Size = new Size(146, 23);
			textBoxBuilding.TabIndex = 20;
			textBoxBuilding.LostFocus += TextBoxTrimAll;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(6, 168);
			label8.Name = "label8";
			label8.Size = new Size(76, 15);
			label8.TabIndex = 19;
			label8.Text = "&Номер дома";
			// 
			// textBoxHouse
			// 
			textBoxHouse.Location = new Point(6, 186);
			textBoxHouse.MaxLength = 5;
			textBoxHouse.Name = "textBoxHouse";
			textBoxHouse.Size = new Size(76, 23);
			textBoxHouse.TabIndex = 18;
			textBoxHouse.LostFocus += TextBoxTrimAll;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(6, 115);
			label7.Name = "label7";
			label7.Size = new Size(41, 15);
			label7.TabIndex = 17;
			label7.Text = "&Улица";
			// 
			// textBoxStreet
			// 
			textBoxStreet.Location = new Point(6, 133);
			textBoxStreet.MaxLength = 40;
			textBoxStreet.Name = "textBoxStreet";
			textBoxStreet.Size = new Size(228, 23);
			textBoxStreet.TabIndex = 16;
			textBoxStreet.LostFocus += TextBoxTrimAll;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(6, 65);
			label6.Name = "label6";
			label6.Size = new Size(40, 15);
			label6.TabIndex = 15;
			label6.Text = "&Город";
			// 
			// textBoxCity
			// 
			textBoxCity.Location = new Point(6, 83);
			textBoxCity.MaxLength = 40;
			textBoxCity.Name = "textBoxCity";
			textBoxCity.Size = new Size(228, 23);
			textBoxCity.TabIndex = 14;
			textBoxCity.LostFocus += TextBoxTrimAll;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(6, 18);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 13;
			label4.Text = "&Регион";
			// 
			// textBoxRegion
			// 
			textBoxRegion.Location = new Point(6, 36);
			textBoxRegion.MaxLength = 40;
			textBoxRegion.Name = "textBoxRegion";
			textBoxRegion.Size = new Size(228, 23);
			textBoxRegion.TabIndex = 0;
			textBoxRegion.LostFocus += TextBoxTrimAll;
			// 
			// maskedTextBoxPhone
			// 
			maskedTextBoxPhone.Location = new Point(12, 185);
			maskedTextBoxPhone.Mask = "(999) 000-0000";
			maskedTextBoxPhone.Name = "maskedTextBoxPhone";
			maskedTextBoxPhone.Size = new Size(178, 23);
			maskedTextBoxPhone.TabIndex = 3;
			// 
			// FormStudent
			// 
			AcceptButton = buttonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonClose;
			ClientSize = new Size(458, 278);
			Controls.Add(maskedTextBoxPhone);
			Controls.Add(AddressBox);
			Controls.Add(buttonClose);
			Controls.Add(buttonOK);
			Controls.Add(label5);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBoxPatronim);
			Controls.Add(textBoxName);
			Controls.Add(textBoxSurname);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			Name = "FormStudent";
			ShowIcon = false;
			Text = "Информация о студенте";
			Load += SetBoxes;
			AddressBox.ResumeLayout(false);
			AddressBox.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
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