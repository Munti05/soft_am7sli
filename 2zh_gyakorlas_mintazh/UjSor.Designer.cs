namespace _2zh_gyakorlas_mintazh
{
    partial class UjSor
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
            bindingSource1 = new BindingSource(components);
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "VersenyzoID", true));
            textBox1.Location = new Point(64, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 47);
            textBox1.TabIndex = 0;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Egysor);
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "Nev", true));
            textBox2.Location = new Point(270, 76);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(428, 47);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "Nemzetiseg", true));
            textBox3.Location = new Point(64, 174);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(293, 47);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "EredmenyPerc", true));
            textBox4.Location = new Point(64, 289);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(293, 47);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "Kategoria", true));
            textBox5.Location = new Point(64, 405);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(293, 47);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 44);
            label1.Name = "label1";
            label1.Size = new Size(93, 25);
            label1.TabIndex = 5;
            label1.Text = "Azonosító";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 44);
            label2.Name = "label2";
            label2.Size = new Size(43, 25);
            label2.TabIndex = 6;
            label2.Text = "Név";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 146);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 7;
            label3.Text = "Nemzetiség";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 261);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 8;
            label4.Text = "Eredmény (p)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(64, 377);
            label5.Name = "label5";
            label5.Size = new Size(87, 25);
            label5.TabIndex = 9;
            label5.Text = "Kategória";
            // 
            // buttonOK
            // 
            buttonOK.DialogResult = DialogResult.OK;
            buttonOK.Location = new Point(458, 226);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(240, 156);
            buttonOK.TabIndex = 10;
            buttonOK.Text = "&Ok";
            buttonOK.UseVisualStyleBackColor = true;
            // 
            // UjSor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 496);
            Controls.Add(buttonOK);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "UjSor";
            Text = "UjSor";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonOK;
        private BindingSource bindingSource1;
    }
}