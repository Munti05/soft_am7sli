namespace gyakorla_az_elso_zhra
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
            gomb1 = new Button();
            szovegDoboz = new TextBox();
            szovegDoboz2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(605, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(108, 88);
            dataGridView1.TabIndex = 0;
            // 
            // gomb1
            // 
            gomb1.Location = new Point(563, 121);
            gomb1.Name = "gomb1";
            gomb1.Size = new Size(112, 34);
            gomb1.TabIndex = 1;
            gomb1.Text = "Gomba";
            gomb1.UseVisualStyleBackColor = true;
            // 
            // szovegDoboz
            // 
            szovegDoboz.Location = new Point(622, 245);
            szovegDoboz.Name = "szovegDoboz";
            szovegDoboz.Size = new Size(150, 31);
            szovegDoboz.TabIndex = 2;
            // 
            // szovegDoboz2
            // 
            szovegDoboz2.Enabled = false;
            szovegDoboz2.Location = new Point(622, 328);
            szovegDoboz2.Name = "szovegDoboz2";
            szovegDoboz2.Size = new Size(150, 31);
            szovegDoboz2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(szovegDoboz2);
            Controls.Add(szovegDoboz);
            Controls.Add(gomb1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button gomb1;
        private TextBox szovegDoboz;
        private TextBox szovegDoboz2;
    }
}
