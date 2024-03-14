namespace HajosKviz
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
            dataGridView1 = new DataGridView();
            valaszGomb1 = new ValaszGomb();
            label1 = new Label();
            valaszGomb2 = new ValaszGomb();
            valaszGomb3 = new ValaszGomb();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-2, 399);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(859, 177);
            dataGridView1.TabIndex = 0;
            // 
            // valaszGomb1
            // 
            valaszGomb1.BackColor = Color.Fuchsia;
            valaszGomb1.BorderStyle = BorderStyle.None;
            valaszGomb1.Location = new Point(12, 39);
            valaszGomb1.Multiline = true;
            valaszGomb1.Name = "valaszGomb1";
            valaszGomb1.ReadOnly = true;
            valaszGomb1.Size = new Size(378, 97);
            valaszGomb1.TabIndex = 1;
            valaszGomb1.TextChanged += valaszGomb1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // valaszGomb2
            // 
            valaszGomb2.BackColor = Color.Fuchsia;
            valaszGomb2.BorderStyle = BorderStyle.None;
            valaszGomb2.Location = new Point(12, 165);
            valaszGomb2.Multiline = true;
            valaszGomb2.Name = "valaszGomb2";
            valaszGomb2.ReadOnly = true;
            valaszGomb2.Size = new Size(378, 97);
            valaszGomb2.TabIndex = 3;
            // 
            // valaszGomb3
            // 
            valaszGomb3.Anchor = AnchorStyles.None;
            valaszGomb3.BackColor = Color.Fuchsia;
            valaszGomb3.BorderStyle = BorderStyle.None;
            valaszGomb3.Location = new Point(12, 285);
            valaszGomb3.Multiline = true;
            valaszGomb3.Name = "valaszGomb3";
            valaszGomb3.ReadOnly = true;
            valaszGomb3.Size = new Size(378, 97);
            valaszGomb3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Location = new Point(396, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(448, 343);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(856, 577);
            Controls.Add(pictureBox1);
            Controls.Add(valaszGomb3);
            Controls.Add(valaszGomb2);
            Controls.Add(label1);
            Controls.Add(valaszGomb1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ValaszGomb valaszGomb1;
        private Label label1;
        private ValaszGomb valaszGomb2;
        private ValaszGomb valaszGomb3;
        private PictureBox pictureBox1;
    }
}