namespace esercizio04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox_name = new TextBox();
            textBox_surname = new TextBox();
            dateTimePicker_birthday = new DateTimePicker();
            textBox_city = new TextBox();
            label_name = new Label();
            label_Surname = new Label();
            label_city = new Label();
            label_date_birthday = new Label();
            button_calc = new Button();
            label_risultato = new Label();
            SuspendLayout();
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(24, 48);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(150, 31);
            textBox_name.TabIndex = 0;
            // 
            // textBox_surname
            // 
            textBox_surname.Location = new Point(216, 48);
            textBox_surname.Name = "textBox_surname";
            textBox_surname.Size = new Size(150, 31);
            textBox_surname.TabIndex = 1;
            // 
            // dateTimePicker_birthday
            // 
            dateTimePicker_birthday.Location = new Point(448, 48);
            dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            dateTimePicker_birthday.Size = new Size(300, 31);
            dateTimePicker_birthday.TabIndex = 2;
            dateTimePicker_birthday.ValueChanged += DateTimePickerBirthdayValueChanged;
            // 
            // textBox_city
            // 
            textBox_city.Location = new Point(24, 130);
            textBox_city.Name = "textBox_city";
            textBox_city.Size = new Size(150, 31);
            textBox_city.TabIndex = 3;
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(24, 20);
            label_name.Name = "label_name";
            label_name.Size = new Size(61, 25);
            label_name.TabIndex = 4;
            label_name.Text = "Nome";
            // 
            // label_Surname
            // 
            label_Surname.AutoSize = true;
            label_Surname.Location = new Point(216, 20);
            label_Surname.Name = "label_Surname";
            label_Surname.Size = new Size(91, 25);
            label_Surname.TabIndex = 5;
            label_Surname.Text = "Cognome";
            // 
            // label_city
            // 
            label_city.AutoSize = true;
            label_city.Location = new Point(24, 102);
            label_city.Name = "label_city";
            label_city.Size = new Size(127, 25);
            label_city.TabIndex = 6;
            label_city.Text = "Città di nascita";
            // 
            // label_date_birthday
            // 
            label_date_birthday.AutoSize = true;
            label_date_birthday.Location = new Point(448, 20);
            label_date_birthday.Name = "label_date_birthday";
            label_date_birthday.Size = new Size(128, 25);
            label_date_birthday.TabIndex = 7;
            label_date_birthday.Text = "Data di nascita";
            // 
            // button_calc
            // 
            button_calc.Location = new Point(648, 383);
            button_calc.Name = "button_calc";
            button_calc.Size = new Size(112, 34);
            button_calc.TabIndex = 8;
            button_calc.Text = "Mostra";
            button_calc.UseVisualStyleBackColor = true;
            button_calc.Click += ButtonCalcClick;
            // 
            // label_risultato
            // 
            label_risultato.AutoSize = true;
            label_risultato.Location = new Point(24, 188);
            label_risultato.Name = "label_risultato";
            label_risultato.Size = new Size(0, 25);
            label_risultato.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_risultato);
            Controls.Add(button_calc);
            Controls.Add(label_date_birthday);
            Controls.Add(label_city);
            Controls.Add(label_Surname);
            Controls.Add(label_name);
            Controls.Add(textBox_city);
            Controls.Add(dateTimePicker_birthday);
            Controls.Add(textBox_surname);
            Controls.Add(textBox_name);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_name;
        private TextBox textBox_surname;
        private DateTimePicker dateTimePicker_birthday;
        private TextBox textBox_city;
        private Label label_name;
        private Label label_Surname;
        private Label label_city;
        private Label label_date_birthday;
        private Button button_calc;
        private Label label_risultato;
    }
}