namespace gyakorlas_2_zhra
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            szamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kerdesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v1DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v2DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            v3DataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kepDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            helyesValaszDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egySorFejlecBindingSource = new BindingSource(components);
            open_button = new Button();
            save_button = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            delete_button = new Button();
            new_row_button = new Button();
            edit_row_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egySorFejlecBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { szamDataGridViewTextBoxColumn, kerdesDataGridViewTextBoxColumn, v1DataGridViewTextBoxColumn, v2DataGridViewTextBoxColumn, v3DataGridViewTextBoxColumn, kepDataGridViewTextBoxColumn, helyesValaszDataGridViewTextBoxColumn });
            dataGridView1.DataSource = egySorFejlecBindingSource;
            dataGridView1.Location = new Point(12, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(554, 482);
            dataGridView1.TabIndex = 0;
            // 
            // szamDataGridViewTextBoxColumn
            // 
            szamDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            szamDataGridViewTextBoxColumn.DataPropertyName = "Szam";
            szamDataGridViewTextBoxColumn.HeaderText = "Szam";
            szamDataGridViewTextBoxColumn.MinimumWidth = 8;
            szamDataGridViewTextBoxColumn.Name = "szamDataGridViewTextBoxColumn";
            szamDataGridViewTextBoxColumn.Width = 90;
            // 
            // kerdesDataGridViewTextBoxColumn
            // 
            kerdesDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            kerdesDataGridViewTextBoxColumn.DataPropertyName = "Kerdes";
            kerdesDataGridViewTextBoxColumn.HeaderText = "Kerdes";
            kerdesDataGridViewTextBoxColumn.MinimumWidth = 8;
            kerdesDataGridViewTextBoxColumn.Name = "kerdesDataGridViewTextBoxColumn";
            // 
            // v1DataGridViewTextBoxColumn
            // 
            v1DataGridViewTextBoxColumn.DataPropertyName = "V1";
            v1DataGridViewTextBoxColumn.HeaderText = "V1";
            v1DataGridViewTextBoxColumn.MinimumWidth = 8;
            v1DataGridViewTextBoxColumn.Name = "v1DataGridViewTextBoxColumn";
            v1DataGridViewTextBoxColumn.Visible = false;
            v1DataGridViewTextBoxColumn.Width = 150;
            // 
            // v2DataGridViewTextBoxColumn
            // 
            v2DataGridViewTextBoxColumn.DataPropertyName = "V2";
            v2DataGridViewTextBoxColumn.HeaderText = "V2";
            v2DataGridViewTextBoxColumn.MinimumWidth = 8;
            v2DataGridViewTextBoxColumn.Name = "v2DataGridViewTextBoxColumn";
            v2DataGridViewTextBoxColumn.Visible = false;
            v2DataGridViewTextBoxColumn.Width = 150;
            // 
            // v3DataGridViewTextBoxColumn
            // 
            v3DataGridViewTextBoxColumn.DataPropertyName = "V3";
            v3DataGridViewTextBoxColumn.HeaderText = "V3";
            v3DataGridViewTextBoxColumn.MinimumWidth = 8;
            v3DataGridViewTextBoxColumn.Name = "v3DataGridViewTextBoxColumn";
            v3DataGridViewTextBoxColumn.Visible = false;
            v3DataGridViewTextBoxColumn.Width = 150;
            // 
            // kepDataGridViewTextBoxColumn
            // 
            kepDataGridViewTextBoxColumn.DataPropertyName = "Kep";
            kepDataGridViewTextBoxColumn.HeaderText = "Kep";
            kepDataGridViewTextBoxColumn.MinimumWidth = 8;
            kepDataGridViewTextBoxColumn.Name = "kepDataGridViewTextBoxColumn";
            kepDataGridViewTextBoxColumn.Visible = false;
            kepDataGridViewTextBoxColumn.Width = 150;
            // 
            // helyesValaszDataGridViewTextBoxColumn
            // 
            helyesValaszDataGridViewTextBoxColumn.DataPropertyName = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.HeaderText = "HelyesValasz";
            helyesValaszDataGridViewTextBoxColumn.MinimumWidth = 8;
            helyesValaszDataGridViewTextBoxColumn.Name = "helyesValaszDataGridViewTextBoxColumn";
            helyesValaszDataGridViewTextBoxColumn.Visible = false;
            helyesValaszDataGridViewTextBoxColumn.Width = 150;
            // 
            // egySorFejlecBindingSource
            // 
            egySorFejlecBindingSource.DataSource = typeof(EgySorFejlec);
            // 
            // open_button
            // 
            open_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            open_button.Location = new Point(1003, 24);
            open_button.Name = "open_button";
            open_button.Size = new Size(108, 59);
            open_button.TabIndex = 1;
            open_button.Text = "Megnyitás";
            open_button.UseVisualStyleBackColor = true;
            open_button.Click += open_button_Click;
            // 
            // save_button
            // 
            save_button.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            save_button.Location = new Point(874, 24);
            save_button.Name = "save_button";
            save_button.Size = new Size(108, 59);
            save_button.TabIndex = 2;
            save_button.Text = "Mentés";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "Kerdes", true));
            textBox1.Location = new Point(640, 249);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(471, 108);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "V1", true));
            textBox2.Location = new Point(640, 395);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(471, 108);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "V2", true));
            textBox3.Location = new Point(640, 509);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(471, 108);
            textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox4.DataBindings.Add(new Binding("Text", egySorFejlecBindingSource, "V3", true));
            textBox4.Location = new Point(640, 623);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(471, 108);
            textBox4.TabIndex = 6;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(454, 182);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(112, 34);
            delete_button.TabIndex = 7;
            delete_button.Text = "Törlés";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // new_row_button
            // 
            new_row_button.Location = new Point(326, 182);
            new_row_button.Name = "new_row_button";
            new_row_button.Size = new Size(112, 34);
            new_row_button.TabIndex = 8;
            new_row_button.Text = "Új";
            new_row_button.UseVisualStyleBackColor = true;
            new_row_button.Click += new_row_button_Click;
            // 
            // edit_row_button
            // 
            edit_row_button.Location = new Point(195, 182);
            edit_row_button.Name = "edit_row_button";
            edit_row_button.Size = new Size(112, 34);
            edit_row_button.TabIndex = 9;
            edit_row_button.Text = "Szerkesztés";
            edit_row_button.UseVisualStyleBackColor = true;
            edit_row_button.Click += edit_row_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1141, 762);
            Controls.Add(edit_row_button);
            Controls.Add(new_row_button);
            Controls.Add(delete_button);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(save_button);
            Controls.Add(open_button);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)egySorFejlecBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button open_button;
        private Button save_button;
        private BindingSource egySorFejlecBindingSource;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn szamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kerdesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v1DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v2DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn v3DataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kepDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn helyesValaszDataGridViewTextBoxColumn;
        private Button delete_button;
        private Button new_row_button;
        private Button edit_row_button;
    }
}
