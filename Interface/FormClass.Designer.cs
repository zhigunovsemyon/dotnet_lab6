namespace Interface
{
	partial class FormClass
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			textBoxName = new TextBox();
			numericUpDownLectionsInput = new NumericUpDown();
			numericUpDownPracticeInput = new NumericUpDown();
			numericUpDownLabsInput = new NumericUpDown();
			buttonOK = new Button();
			buttonClose = new Button();
			((System.ComponentModel.ISupportInitialize)numericUpDownLectionsInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownPracticeInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownLabsInput).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(17, 9);
			label1.Name = "label1";
			label1.Size = new Size(114, 15);
			label1.TabIndex = 0;
			label1.Text = "Название предмета";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(17, 53);
			label2.Name = "label2";
			label2.Size = new Size(190, 15);
			label2.TabIndex = 1;
			label2.Text = "Количество лекционных занятий";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(223, 9);
			label3.Name = "label3";
			label3.Size = new Size(186, 15);
			label3.TabIndex = 2;
			label3.Text = "Количество практических работ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(222, 51);
			label4.Name = "label4";
			label4.Size = new Size(191, 15);
			label4.TabIndex = 3;
			label4.Text = "Количество лабораторных работ";
			// 
			// textBoxName
			// 
			textBoxName.Location = new Point(17, 27);
			textBoxName.MaxLength = 60;
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(189, 23);
			textBoxName.TabIndex = 4;
			textBoxName.LostFocus += ClassNameBox_LostFocus;
			// 
			// numericUpDownLectionsInput
			// 
			numericUpDownLectionsInput.Location = new Point(17, 71);
			numericUpDownLectionsInput.Name = "numericUpDownLectionsInput";
			numericUpDownLectionsInput.Size = new Size(190, 23);
			numericUpDownLectionsInput.TabIndex = 5;
			// 
			// numericUpDownPracticeInput
			// 
			numericUpDownPracticeInput.Location = new Point(223, 27);
			numericUpDownPracticeInput.Name = "numericUpDownPracticeInput";
			numericUpDownPracticeInput.Size = new Size(190, 23);
			numericUpDownPracticeInput.TabIndex = 6;
			// 
			// numericUpDownLabsInput
			// 
			numericUpDownLabsInput.Location = new Point(222, 71);
			numericUpDownLabsInput.Name = "numericUpDownLabsInput";
			numericUpDownLabsInput.Size = new Size(190, 23);
			numericUpDownLabsInput.TabIndex = 7;
			// 
			// buttonOK
			// 
			buttonOK.Location = new Point(222, 115);
			buttonOK.Name = "buttonOK";
			buttonOK.Size = new Size(95, 23);
			buttonOK.TabIndex = 8;
			buttonOK.Text = "ОК";
			buttonOK.UseVisualStyleBackColor = true;
			buttonOK.Click += OkButton_Click;
			// 
			// buttonClose
			// 
			buttonClose.Location = new Point(323, 115);
			buttonClose.Name = "buttonClose";
			buttonClose.Size = new Size(89, 23);
			buttonClose.TabIndex = 9;
			buttonClose.Text = "Закрыть";
			buttonClose.UseVisualStyleBackColor = true;
			// 
			// FormClass
			// 
			AcceptButton = buttonOK;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonClose;
			ClientSize = new Size(433, 162);
			Controls.Add(buttonClose);
			Controls.Add(buttonOK);
			Controls.Add(numericUpDownLabsInput);
			Controls.Add(numericUpDownPracticeInput);
			Controls.Add(numericUpDownLectionsInput);
			Controls.Add(textBoxName);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "FormClass";
			ShowIcon = false;
			Text = "Информация о предмете";
			Load += SetBoxes;
			((System.ComponentModel.ISupportInitialize)numericUpDownLectionsInput).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownPracticeInput).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownLabsInput).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox textBoxName;
		private NumericUpDown numericUpDownLectionsInput;
		private NumericUpDown numericUpDownPracticeInput;
		private NumericUpDown numericUpDownLabsInput;
		private Button buttonOK;
		private Button buttonClose;
	}
}