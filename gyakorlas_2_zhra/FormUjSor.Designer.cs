namespace gyakorlas_2_zhra
{
    partial class FormUjSor
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
            cancel_button = new Button();
            egySorFejlecBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)egySorFejlecBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ok_button
            // 
            ok_button.DialogResult = DialogResult.OK;
            ok_button.Location = new Point(1041, 705);
            ok_button.Name = "ok_button";
            ok_button.Size = new Size(126, 44);
            ok_button.TabIndex = 0;
            ok_button.Text = "&OK";
            ok_button.UseVisualStyleBackColor = true;
            // 
            // cancel_button
            // 
            cancel_button.DialogResult = DialogResult.Cancel;
            cancel_button.Location = new Point(909, 705);
            cancel_button.Name = "cancel_button";
            cancel_button.Size = new Size(126, 44);
            cancel_button.TabIndex = 1;
            cancel_button.Text = "&Cancel";
            cancel_button.UseVisualStyleBackColor = true;
            // 
            // egySorFejlecBindingSource
            // 
            egySorFejlecBindingSource.DataSource = typeof(EgySorFejlec);
            // 
            // FormUjSor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 761);
            Controls.Add(cancel_button);
            Controls.Add(ok_button);
            Name = "FormUjSor";
            Text = "FormUjSor";
            ((System.ComponentModel.ISupportInitialize)egySorFejlecBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button ok_button;
        private Button cancel_button;
        private BindingSource egySorFejlecBindingSource;
    }
}