namespace gyakorlas_2_zhra
{
    partial class FormEditRow
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
            ok_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            egySorFejlecBindingSource = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)egySorFejlecBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ok_button
            // 
            ok_button.Location = new Point(966, 693);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(112, 34);
            ok_button.TabIndex = 0;
            ok_button.Text = "&OK";
            ok_button.UseVisualStyleBackColor = true;
            ok_button.Click += ok_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "Sorszám";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 2;
            label2.Text = "Kérdés";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 3;
            label3.Text = "1. Válasz";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 176);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 4;
            label4.Text = "2. Válasz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(732, 176);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 5;
            label5.Text = "3. Válasz";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 438);
            label6.Name = "label6";
            label6.Size = new Size(42, 25);
            label6.TabIndex = 6;
            label6.Text = "Kép";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(373, 438);
            label7.Name = "label7";
            label7.Size = new Size(117, 25);
            label7.TabIndex = 7;
            label7.Text = "Helyes Válasz";
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "Szam", true));
            textBox1.Location = new Point(107, 9);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 31);
            textBox1.TabIndex = 8;
            // 
            // egySorFejlecBindingSource
            // 
            egySorFejlecBindingSource.DataSource = typeof(EgySorFejlec);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "Kerdes", true));
            textBox2.Location = new Point(12, 86);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(1066, 75);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "V1", true));
            textBox3.Location = new Point(12, 204);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(346, 231);
            textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "V2", true));
            textBox4.Location = new Point(373, 204);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(346, 231);
            textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "V3", true));
            textBox5.Location = new Point(732, 204);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(346, 231);
            textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "Kep", true));
            textBox6.Location = new Point(12, 466);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(346, 231);
            textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            textBox7.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "HelyesValasz", true));
            textBox7.Location = new Point(373, 466);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(705, 118);
            textBox7.TabIndex = 14;
            // 
            // FormEditRow
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 739);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ok_button);
            Name = "FormEditRow";
            Text = "FormEditRow";
            Load += FormEditRow_Load;
            ((System.ComponentModel.ISupportInitialize)egySorFejlecBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private BindingSource egySorFejlecBindingSource;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}