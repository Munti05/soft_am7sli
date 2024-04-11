namespace AdatKotes
{
    partial class Form2
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
            if (disposing && (components != null))
            {
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
            components = new System.ComponentModel.Container();
            textBox1 = new TextBox();
            countryDataBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            CountryName = new Label();
            Population = new Label();
            SquareArea = new Label();
            ok_button = new Button();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", countryDataBindingSource, "Name", true));
            textBox1.Location = new Point(12, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(302, 23);
            textBox1.TabIndex = 0;
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", countryDataBindingSource, "AreaInSquareKm", true));
            textBox2.Location = new Point(12, 217);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(302, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", countryDataBindingSource, "Population", true));
            textBox3.Location = new Point(12, 148);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(302, 23);
            textBox3.TabIndex = 2;
            // 
            // CountryName
            // 
            CountryName.AutoSize = true;
            CountryName.Location = new Point(12, 62);
            CountryName.Name = "CountryName";
            CountryName.Size = new Size(82, 15);
            CountryName.TabIndex = 3;
            CountryName.Text = "CountryName";
            // 
            // Population
            // 
            Population.AutoSize = true;
            Population.Location = new Point(12, 130);
            Population.Name = "Population";
            Population.Size = new Size(65, 15);
            Population.TabIndex = 4;
            Population.Text = "Population";
            // 
            // SquareArea
            // 
            SquareArea.AutoSize = true;
            SquareArea.Location = new Point(12, 199);
            SquareArea.Name = "SquareArea";
            SquareArea.Size = new Size(64, 15);
            SquareArea.TabIndex = 5;
            SquareArea.Text = "Area in km";
            // 
            // ok_button
            // 
            ok_button.Location = new Point(239, 296);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(75, 23);
            ok_button.TabIndex = 6;
            ok_button.Text = "OK";
            ok_button.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(327, 339);
            Controls.Add(ok_button);
            Controls.Add(SquareArea);
            Controls.Add(Population);
            Controls.Add(CountryName);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label CountryName;
        private Label Population;
        private Label SquareArea;
        private Button ok_button;
        private BindingSource countryDataBindingSource;
    }
}