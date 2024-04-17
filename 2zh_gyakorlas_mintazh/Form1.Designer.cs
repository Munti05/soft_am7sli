namespace _2zh_gyakorlas_mintazh
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
            versenyzoIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nevDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nemzetisegDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            eredmenyPercDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            egysorBindingSource = new BindingSource(components);
            buttonOpen = new Button();
            buttonSave = new Button();
            buttonDelete = new Button();
            buttonNew = new Button();
            buttonEdit = new Button();
            buttonGift = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)egysorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { versenyzoIDDataGridViewTextBoxColumn, nevDataGridViewTextBoxColumn, nemzetisegDataGridViewTextBoxColumn, eredmenyPercDataGridViewTextBoxColumn, kategoriaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = egysorBindingSource;
            dataGridView1.Location = new Point(40, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1170, 448);
            dataGridView1.TabIndex = 0;
            // 
            // versenyzoIDDataGridViewTextBoxColumn
            // 
            versenyzoIDDataGridViewTextBoxColumn.DataPropertyName = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.HeaderText = "VersenyzoID";
            versenyzoIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            versenyzoIDDataGridViewTextBoxColumn.Name = "versenyzoIDDataGridViewTextBoxColumn";
            versenyzoIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // nevDataGridViewTextBoxColumn
            // 
            nevDataGridViewTextBoxColumn.DataPropertyName = "Nev";
            nevDataGridViewTextBoxColumn.HeaderText = "Nev";
            nevDataGridViewTextBoxColumn.MinimumWidth = 8;
            nevDataGridViewTextBoxColumn.Name = "nevDataGridViewTextBoxColumn";
            nevDataGridViewTextBoxColumn.Width = 150;
            // 
            // nemzetisegDataGridViewTextBoxColumn
            // 
            nemzetisegDataGridViewTextBoxColumn.DataPropertyName = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.HeaderText = "Nemzetiseg";
            nemzetisegDataGridViewTextBoxColumn.MinimumWidth = 8;
            nemzetisegDataGridViewTextBoxColumn.Name = "nemzetisegDataGridViewTextBoxColumn";
            nemzetisegDataGridViewTextBoxColumn.Width = 150;
            // 
            // eredmenyPercDataGridViewTextBoxColumn
            // 
            eredmenyPercDataGridViewTextBoxColumn.DataPropertyName = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.HeaderText = "EredmenyPerc";
            eredmenyPercDataGridViewTextBoxColumn.MinimumWidth = 8;
            eredmenyPercDataGridViewTextBoxColumn.Name = "eredmenyPercDataGridViewTextBoxColumn";
            eredmenyPercDataGridViewTextBoxColumn.Width = 150;
            // 
            // kategoriaDataGridViewTextBoxColumn
            // 
            kategoriaDataGridViewTextBoxColumn.DataPropertyName = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.HeaderText = "Kategoria";
            kategoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            kategoriaDataGridViewTextBoxColumn.Name = "kategoriaDataGridViewTextBoxColumn";
            kategoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // egysorBindingSource
            // 
            egysorBindingSource.DataSource = typeof(Egysor);
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(964, 53);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(200, 59);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Megnyitás";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(738, 53);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(200, 59);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Mentés";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(964, 147);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(200, 59);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "&Törlés";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonNew
            // 
            buttonNew.Location = new Point(738, 147);
            buttonNew.Name = "buttonNew";
            buttonNew.Size = new Size(200, 59);
            buttonNew.TabIndex = 4;
            buttonNew.Text = "Új";
            buttonNew.UseVisualStyleBackColor = true;
            buttonNew.Click += buttonNew_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(507, 147);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(200, 59);
            buttonEdit.TabIndex = 5;
            buttonEdit.Text = "Szerkesztés";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonGift
            // 
            buttonGift.Location = new Point(507, 53);
            buttonGift.Name = "buttonGift";
            buttonGift.Size = new Size(200, 59);
            buttonGift.TabIndex = 6;
            buttonGift.Text = "Meglepi";
            buttonGift.UseVisualStyleBackColor = true;
            buttonGift.Click += buttonGift_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 804);
            Controls.Add(buttonGift);
            Controls.Add(buttonEdit);
            Controls.Add(buttonNew);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)egysorBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonOpen;
        private Button buttonSave;
        private DataGridViewTextBoxColumn versenyzoIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nevDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nemzetisegDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn eredmenyPercDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn kategoriaDataGridViewTextBoxColumn;
        private BindingSource egysorBindingSource;
        private Button buttonDelete;
        private Button buttonNew;
        private Button buttonEdit;
        private Button buttonGift;
    }
}
