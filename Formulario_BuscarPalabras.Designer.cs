
namespace Ejercicio12_MK1
{
    partial class Formulario_BuscarPalabras
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_PalabraBuscar = new System.Windows.Forms.TextBox();
            this.button_BuscarSiguiente = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Abajo = new System.Windows.Forms.RadioButton();
            this.radioButton_Arriba = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar: ";
            // 
            // textBox_PalabraBuscar
            // 
            this.textBox_PalabraBuscar.Location = new System.Drawing.Point(64, 6);
            this.textBox_PalabraBuscar.Name = "textBox_PalabraBuscar";
            this.textBox_PalabraBuscar.Size = new System.Drawing.Size(290, 20);
            this.textBox_PalabraBuscar.TabIndex = 1;
            // 
            // button_BuscarSiguiente
            // 
            this.button_BuscarSiguiente.Location = new System.Drawing.Point(360, 4);
            this.button_BuscarSiguiente.Name = "button_BuscarSiguiente";
            this.button_BuscarSiguiente.Size = new System.Drawing.Size(122, 23);
            this.button_BuscarSiguiente.TabIndex = 2;
            this.button_BuscarSiguiente.Text = "Buscar Siguiente";
            this.button_BuscarSiguiente.UseVisualStyleBackColor = true;
            this.button_BuscarSiguiente.Click += new System.EventHandler(this.button_BuscarSiguiente_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(360, 33);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(122, 23);
            this.button_Cancelar.TabIndex = 3;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Abajo);
            this.groupBox1.Controls.Add(this.radioButton_Arriba);
            this.groupBox1.Location = new System.Drawing.Point(232, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 45);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dirección";
            // 
            // radioButton_Abajo
            // 
            this.radioButton_Abajo.AutoSize = true;
            this.radioButton_Abajo.Checked = true;
            this.radioButton_Abajo.Location = new System.Drawing.Point(64, 19);
            this.radioButton_Abajo.Name = "radioButton_Abajo";
            this.radioButton_Abajo.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Abajo.TabIndex = 1;
            this.radioButton_Abajo.TabStop = true;
            this.radioButton_Abajo.Text = "Abajo";
            this.radioButton_Abajo.UseVisualStyleBackColor = true;
            // 
            // radioButton_Arriba
            // 
            this.radioButton_Arriba.AutoSize = true;
            this.radioButton_Arriba.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Arriba.Name = "radioButton_Arriba";
            this.radioButton_Arriba.Size = new System.Drawing.Size(52, 17);
            this.radioButton_Arriba.TabIndex = 0;
            this.radioButton_Arriba.Text = "Arriba";
            this.radioButton_Arriba.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 32);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Coincidir Mayúsculas y Minúsculas";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 55);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(111, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Ajuste Automático";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 85);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_BuscarSiguiente);
            this.Controls.Add(this.textBox_PalabraBuscar);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Buscar";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_PalabraBuscar;
        private System.Windows.Forms.Button button_BuscarSiguiente;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Abajo;
        private System.Windows.Forms.RadioButton radioButton_Arriba;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}