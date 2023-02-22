
namespace WindowsFormsAppej1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numero1label = new System.Windows.Forms.Label();
            this.numero1textBox = new System.Windows.Forms.TextBox();
            this.confirmarbutton = new System.Windows.Forms.Button();
            this.numero2textBox = new System.Windows.Forms.TextBox();
            this.numero2label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.salirbutton = new System.Windows.Forms.Button();
            this.sumaradioButton = new System.Windows.Forms.RadioButton();
            this.restaradioButton = new System.Windows.Forms.RadioButton();
            this.productoradioButton = new System.Windows.Forms.RadioButton();
            this.divisionradioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numero1label
            // 
            this.numero1label.AutoSize = true;
            this.numero1label.Location = new System.Drawing.Point(23, 34);
            this.numero1label.Name = "numero1label";
            this.numero1label.Size = new System.Drawing.Size(54, 13);
            this.numero1label.TabIndex = 0;
            this.numero1label.Text = " número 1";
            this.numero1label.Click += new System.EventHandler(this.label1_Click);
            // 
            // numero1textBox
            // 
            this.numero1textBox.Location = new System.Drawing.Point(98, 34);
            this.numero1textBox.Name = "numero1textBox";
            this.numero1textBox.Size = new System.Drawing.Size(100, 20);
            this.numero1textBox.TabIndex = 1;
            this.numero1textBox.TextChanged += new System.EventHandler(this.numero1textBox_TextChanged);
            // 
            // confirmarbutton
            // 
            this.confirmarbutton.Location = new System.Drawing.Point(26, 146);
            this.confirmarbutton.Name = "confirmarbutton";
            this.confirmarbutton.Size = new System.Drawing.Size(86, 23);
            this.confirmarbutton.TabIndex = 2;
            this.confirmarbutton.Text = "CONFIRMAR";
            this.confirmarbutton.UseVisualStyleBackColor = true;
            this.confirmarbutton.Click += new System.EventHandler(this.confirmarbutton_Click);
            // 
            // numero2textBox
            // 
            this.numero2textBox.Location = new System.Drawing.Point(98, 85);
            this.numero2textBox.Name = "numero2textBox";
            this.numero2textBox.Size = new System.Drawing.Size(100, 20);
            this.numero2textBox.TabIndex = 4;
            // 
            // numero2label
            // 
            this.numero2label.AutoSize = true;
            this.numero2label.Location = new System.Drawing.Point(23, 88);
            this.numero2label.Name = "numero2label";
            this.numero2label.Size = new System.Drawing.Size(54, 13);
            this.numero2label.TabIndex = 5;
            this.numero2label.Text = " número 2";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // salirbutton
            // 
            this.salirbutton.Location = new System.Drawing.Point(328, 179);
            this.salirbutton.Name = "salirbutton";
            this.salirbutton.Size = new System.Drawing.Size(75, 23);
            this.salirbutton.TabIndex = 6;
            this.salirbutton.Text = "SALIR";
            this.salirbutton.UseVisualStyleBackColor = true;
            this.salirbutton.Click += new System.EventHandler(this.salirbutton_Click);
            // 
            // sumaradioButton
            // 
            this.sumaradioButton.AutoSize = true;
            this.sumaradioButton.Checked = true;
            this.sumaradioButton.Location = new System.Drawing.Point(238, 32);
            this.sumaradioButton.Name = "sumaradioButton";
            this.sumaradioButton.Size = new System.Drawing.Size(56, 17);
            this.sumaradioButton.TabIndex = 8;
            this.sumaradioButton.TabStop = true;
            this.sumaradioButton.Text = "SUMA";
            this.sumaradioButton.UseVisualStyleBackColor = true;
            this.sumaradioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // restaradioButton
            // 
            this.restaradioButton.AutoSize = true;
            this.restaradioButton.Location = new System.Drawing.Point(238, 64);
            this.restaradioButton.Name = "restaradioButton";
            this.restaradioButton.Size = new System.Drawing.Size(61, 17);
            this.restaradioButton.TabIndex = 9;
            this.restaradioButton.Text = "RESTA";
            this.restaradioButton.UseVisualStyleBackColor = true;
            // 
            // productoradioButton
            // 
            this.productoradioButton.AutoSize = true;
            this.productoradioButton.Location = new System.Drawing.Point(238, 98);
            this.productoradioButton.Name = "productoradioButton";
            this.productoradioButton.Size = new System.Drawing.Size(86, 17);
            this.productoradioButton.TabIndex = 10;
            this.productoradioButton.Text = "PRODUCTO";
            this.productoradioButton.UseVisualStyleBackColor = true;
            // 
            // divisionradioButton
            // 
            this.divisionradioButton.AutoSize = true;
            this.divisionradioButton.Location = new System.Drawing.Point(238, 132);
            this.divisionradioButton.Name = "divisionradioButton";
            this.divisionradioButton.Size = new System.Drawing.Size(72, 17);
            this.divisionradioButton.TabIndex = 11;
            this.divisionradioButton.Text = "DIVISION";
            this.divisionradioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 228);
            this.ControlBox = false;
            this.Controls.Add(this.divisionradioButton);
            this.Controls.Add(this.productoradioButton);
            this.Controls.Add(this.restaradioButton);
            this.Controls.Add(this.sumaradioButton);
            this.Controls.Add(this.salirbutton);
            this.Controls.Add(this.numero2label);
            this.Controls.Add(this.numero2textBox);
            this.Controls.Add(this.confirmarbutton);
            this.Controls.Add(this.numero1textBox);
            this.Controls.Add(this.numero1label);
            this.MaximumSize = new System.Drawing.Size(447, 267);
            this.MinimumSize = new System.Drawing.Size(447, 267);
            this.Name = "Form1";
            this.Text = "Operaciones basicas";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numero1label;
        private System.Windows.Forms.TextBox numero1textBox;
        private System.Windows.Forms.Button confirmarbutton;
        private System.Windows.Forms.TextBox numero2textBox;
        private System.Windows.Forms.Label numero2label;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button salirbutton;
        private System.Windows.Forms.RadioButton divisionradioButton;
        private System.Windows.Forms.RadioButton productoradioButton;
        private System.Windows.Forms.RadioButton restaradioButton;
        private System.Windows.Forms.RadioButton sumaradioButton;
    }
}

