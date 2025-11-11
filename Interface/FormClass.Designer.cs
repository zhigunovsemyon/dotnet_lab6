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
		private void InitializeComponent ()
		{
			this.label1 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.textBoxName = new TextBox();
			this.numericUpDownLectionsInput = new NumericUpDown();
			this.numericUpDownPracticeInput = new NumericUpDown();
			this.numericUpDownLabsInput = new NumericUpDown();
			this.buttonOK = new Button();
			this.buttonClose = new Button();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownLectionsInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPracticeInput).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownLabsInput).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new Point(17, 9);
			this.label1.Name = "label1";
			this.label1.Size = new Size(114, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Название предмета";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new Point(17, 53);
			this.label2.Name = "label2";
			this.label2.Size = new Size(190, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Количество лекционных занятий";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new Point(223, 9);
			this.label3.Name = "label3";
			this.label3.Size = new Size(186, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Количество практических работ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new Point(222, 51);
			this.label4.Name = "label4";
			this.label4.Size = new Size(191, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Количество лабораторных работ";
			// 
			// textBoxName
			// 
			this.textBoxName.Location = new Point(17, 27);
			this.textBoxName.MaxLength = 60;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new Size(189, 23);
			this.textBoxName.TabIndex = 4;
			this.textBoxName.LostFocus += this.ClassNameBox_LostFocus;
			// 
			// numericUpDownLectionsInput
			// 
			this.numericUpDownLectionsInput.Location = new Point(17, 71);
			this.numericUpDownLectionsInput.Name = "numericUpDownLectionsInput";
			this.numericUpDownLectionsInput.Size = new Size(190, 23);
			this.numericUpDownLectionsInput.TabIndex = 5;
			// 
			// numericUpDownPracticeInput
			// 
			this.numericUpDownPracticeInput.Location = new Point(223, 27);
			this.numericUpDownPracticeInput.Name = "numericUpDownPracticeInput";
			this.numericUpDownPracticeInput.Size = new Size(190, 23);
			this.numericUpDownPracticeInput.TabIndex = 6;
			// 
			// numericUpDownLabsInput
			// 
			this.numericUpDownLabsInput.Location = new Point(222, 71);
			this.numericUpDownLabsInput.Name = "numericUpDownLabsInput";
			this.numericUpDownLabsInput.Size = new Size(190, 23);
			this.numericUpDownLabsInput.TabIndex = 7;
			// 
			// buttonOK
			// 
			this.buttonOK.Location = new Point(222, 115);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new Size(95, 23);
			this.buttonOK.TabIndex = 8;
			this.buttonOK.Text = "ОК";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += this.OkButton_Click;
			// 
			// buttonClose
			// 
			this.buttonClose.Location = new Point(323, 115);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new Size(89, 23);
			this.buttonClose.TabIndex = 9;
			this.buttonClose.Text = "Закрыть";
			this.buttonClose.UseVisualStyleBackColor = true;
			// 
			// FormClass
			// 
			this.AcceptButton = this.buttonOK;
			this.AutoScaleDimensions = new SizeF(7F, 15F);
			this.AutoScaleMode = AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new Size(433, 162);
			this.Controls.Add(this.buttonClose);
			this.Controls.Add(this.buttonOK);
			this.Controls.Add(this.numericUpDownLabsInput);
			this.Controls.Add(this.numericUpDownPracticeInput);
			this.Controls.Add(this.numericUpDownLectionsInput);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormClass";
			this.ShowIcon = false;
			this.Text = "Информация о предмете";
			((System.ComponentModel.ISupportInitialize)this.numericUpDownLectionsInput).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownPracticeInput).EndInit();
			((System.ComponentModel.ISupportInitialize)this.numericUpDownLabsInput).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
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