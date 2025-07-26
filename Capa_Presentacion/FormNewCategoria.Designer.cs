namespace Capa_Presentacion
{
    partial class FormNewCategoria
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
            label1 = new Label();
            btnNewCategoria = new Button();
            txtNewCategoria = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 35);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 0;
            label1.Text = "Nueva Categoria:";
            // 
            // btnNewCategoria
            // 
            btnNewCategoria.Location = new Point(141, 82);
            btnNewCategoria.Name = "btnNewCategoria";
            btnNewCategoria.Size = new Size(75, 23);
            btnNewCategoria.TabIndex = 1;
            btnNewCategoria.Text = "Guardar";
            btnNewCategoria.UseVisualStyleBackColor = true;
            btnNewCategoria.Click += btnNewCategoria_Click;
            // 
            // txtNewCategoria
            // 
            txtNewCategoria.Location = new Point(141, 32);
            txtNewCategoria.Name = "txtNewCategoria";
            txtNewCategoria.Size = new Size(127, 23);
            txtNewCategoria.TabIndex = 2;
            // 
            // FormNewCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 146);
            Controls.Add(txtNewCategoria);
            Controls.Add(btnNewCategoria);
            Controls.Add(label1);
            Name = "FormNewCategoria";
            Text = "FormNewCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNewCategoria;
        private TextBox txtNewCategoria;
    }
}