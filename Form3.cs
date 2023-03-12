using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12_MK1
{
    public partial class Form3 : Form
    {
        public int index;

        public Form3()
        {
            InitializeComponent();
        }

        

        public void button_BuscarSiguiente_Click(object sender, EventArgs e){
            string Direccion = "";
                            //forma para poder invocar metodos de otro formulario
            var FormularioPrincipal = Application.OpenForms.OfType<PantallaPrincipal>().Single();
            if (radioButton_Arriba.Checked == true){
                Direccion = "arriba";
            }
            if (radioButton_Abajo.Checked == true)
            {
                Direccion = "abajo";
            }
            FormularioPrincipal.BuscadorPalabras(textBox_PalabraBuscar.Text,Direccion);
        }

        private void button_Cancelar_Click(object sender, EventArgs e){
            this.Close();
        }

        private void textBox_PalabraBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
