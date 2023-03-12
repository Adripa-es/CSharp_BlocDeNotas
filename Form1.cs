using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace Ejercicio12_MK1
{
    public partial class PantallaPrincipal : Form{
        public PantallaPrincipal() { 
            InitializeComponent();
            //cuando se abra el programa, se comprueba esto
            ComprobarPortaFolio();
            richTextBox_Escritura.Focus();
        }
        string Ruta;
 //actualizador de nombre de fichero REVISAR
        //https://www.codeproject.com/articles/1093889/creating-advanced-notepad-in-csharp
        private void richTextBox_Escritura_KeyPress(object sender, KeyPressEventArgs e){
            SetWindowTitle("*" + TituloFichero);
        }
        void SetWindowTitle(string fileName){
            this.Text = string.Format("{0} - Bloc de Notas 2.0", System.IO.Path.GetFileName(fileName));
        }
//--------------------------------------------
        /*Sugerencias:
        1-Contador de lineas
        */

        //Archivo
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ruta = string.Empty;
            richTextBox_Escritura.Clear();
        }   
        private void ventanaNuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Ejercicio12_MK1.exe");
        }
        String Filtro = "TODOS LOS ARCHIVOS(*.*)|*.*|ARCHIVOS DE TEXTO(.txt)|*.txt";
        private async void guardarComoToolStripMenuItem_Click(object sender, EventArgs e){
            /*
                        //METODO 1
             using (var GuardarComo = new SaveFileDialog()){
                GuardarComo.FileName = "Sin Titulo.txt";
                //FORMATO: NOMBRE DE FORMATO (PUEDE SER EL QUE SEA) + | + *.FORMATO
                GuardarComo.Filter = "TODOS LOS ARCHIVOS (*.*)|*.*|txt file (*.txt)|*.txt";
                GuardarComo.FilterIndex = 2;//numero de opciones en el desplegable
                GuardarComo.DefaultExt = ".txt";//extension por defecto

                //cuando se da al "OK" del guardado, se guarda, sino no ocurre nada
                if (GuardarComo.ShowDialog() == DialogResult.OK){
                    File.WriteAllText(GuardarComo.FileName, richTextBox1.Text);
                }
            }
            */
            /*
             //METODO 2
            SaveFileDialog GuardarComo = new SaveFileDialog();
            StreamWriter Escritura = null;
            //FORMATO: NOMBRE DE FORMATO (PUEDE SER EL QUE SEA) + | + *.FORMATO
            GuardarComo.Filter = "TODOS LOS ARCHIVOS (*.*)|*.*|ARCHIVOS DE TEXTO (.txt)|*.txt";//puede ser cualquier orden
            GuardarComo.DefaultExt = ".txt";//extension por defecto
            GuardarComo.Title = "Guardar Como...";
            GuardarComo.ShowDialog();
            
            String RutaFichero = GuardarComo.FileName;
            Escritura = File.AppendText(RutaFichero);
            Escritura.Write(richTextBox1.Text);
            Escritura.Flush();
            */

            /*
             //METODO 3
            
            saveFileDialog1.FileName = "Sin Titulo.txt";
            var sf = saveFileDialog1.ShowDialog();
            if (sf == DialogResult.OK){
                using (var GuardarArchivo = new System.IO.StreamWriter(saveFileDialog1.FileName)) {
                    GuardarArchivo.WriteLine(richTextBox1.Text);
                
                }
            }
            */
            //METODO 4
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = Filtro, ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteAsync(richTextBox_Escritura.Text);
                        }
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message, "Messaggen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
            }
        }//Guardar Como
        private async void guardarToolStripMenuItem_Click(object sender, EventArgs e){            
            if (string.IsNullOrEmpty(Ruta)){
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = Filtro, ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter(sfd.FileName))
                        {
                            await sw.WriteAsync(richTextBox_Escritura.Text);
                        }
                    }
                }
            }else {
                using (StreamWriter sw = new StreamWriter(Ruta)) {
                    await sw.WriteLineAsync(richTextBox_Escritura.Text);
                }
            }
        }//Guardar

        private void salirToolStripMenuItem_Click(object sender, EventArgs e){
            this.Close();
        }
        public String TituloFichero;
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e){
            /*
                        OpenFileDialog Abrir = new OpenFileDialog();
                        StreamReader Lectura = null;

                        Abrir.Filter = "TODOS LOS ARCHIVOS (*.*)|*.*|txt file (*.txt)|*.txt";
                        Abrir.Title = "Abrir Archivo ";

                        //usando If evitamos que al cancelar el proceso, no explote el programa
                        if (Abrir.ShowDialog() == DialogResult.OK){
                            Abrir.OpenFile();
                            String RutaFichero = Abrir.FileName;
                            Lectura = File.OpenText(RutaFichero);
                            richTextBox1.Text = Lectura.ReadToEnd();
                        }
            */
            /*
             //forma 2
            String Abrir2;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog1.FileName);
            Abrir2 = file.ReadLine();
            richTextBox1.Text = Abrir2.ToString();
            */
            //METODO 3
            using (OpenFileDialog ofd = new OpenFileDialog() { 
                Filter = "TODOS LOS ARCHIVOS (*.*)|*.*|ARCHIVOS DE TEXTO (.txt)|*.txt", 
                ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        Ruta = ofd.FileName;
                        Task<string> text = sr.ReadToEndAsync();
                        richTextBox_Escritura.Text = text.Result;
                        //al abrir el fichero, cogemos su nombre y lo mostramos arriba de la ventana
                        SetWindowTitle(ofd.FileName);
                        //guardaremos en una variable el nombre para añadirle un asterisco cuando haya cambios
                        TituloFichero = ofd.FileName;
                    }
                }
            }
        }

        //ECHAR UN OJO
        private void configurarPáginaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog1.Document = printDocument1;
            pageSetupDialog1.ShowDialog();
        }

        private void PrevisualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox_Escritura.Text, richTextBox_Escritura.Font, Brushes.Black, 100, 100);
        }

        //Edicion
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e){
            //richTextBox1.Redo(); //lo contrario a deshacer
            richTextBox_Escritura.Undo();
        }

        void ComprobarPortaFolio() {
            if (Clipboard.ContainsText() == true)
            {
                pegarToolStripMenuItem.Enabled = true;
            }
            else
            {
                pegarToolStripMenuItem.Enabled = false;
            }
        }

        //al escribir
        private void richTextBox_Escritura_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox_Escritura.Text.Length > 0){
                deshacerToolStripMenuItem.Enabled = true;
            }
            else{
                deshacerToolStripMenuItem.Enabled = false;
            }

            ComprobarPortaFolio();
        }
        //cuando la seleccion varía
        private void richTextBox_Escritura_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox_Escritura.SelectedText.Length > 0){
                cortarToolStripMenuItem.Enabled = true;
                copiarToolStripMenuItem.Enabled = true;
                eliminarToolStripMenuItem.Enabled = true;
                busquedaConGoogleToolStripMenuItem.Enabled = true;                
            }
            else{
                cortarToolStripMenuItem.Enabled = false;
                copiarToolStripMenuItem.Enabled = false;
                eliminarToolStripMenuItem.Enabled = false;
                busquedaConGoogleToolStripMenuItem.Enabled = false;
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e){
            richTextBox_Escritura.Cut();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e){
            richTextBox_Escritura.Copy();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e){
            richTextBox_Escritura.Paste();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e){
            richTextBox_Escritura.SelectedText = "";
        }

        private void busquedaConGoogleToolStripMenuItem_Click(object sender, EventArgs e){
                                            //el texto seleccionado se guarda
            String StringABuscar = richTextBox_Escritura.SelectedText;
        /*
        //por si se desea que de una cadena X a buscar, depurarla y buscar sólo los ultimos X caracteres
            int index = StringABuscar.IndexOf("for ") + 4;//sirve para decir apartir de qué caracter buscar la palabra
            //la cadena se sustituya a una que va desde el indice de arriba hasta el final de la palabra
            StringABuscar = StringABuscar.Substring(index, StringABuscar.Length - index);
        */
            System.Diagnostics.Process.Start("http://www.google.com.au/search?q=" + StringABuscar);

        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e){
            Form3 Buscar = new Form3();
            Buscar.Show();
        }
        int InicioPalabra = 0;
        int IndiceEncontrado = 0;
        string PalabraForm1 = "";
        public void BuscadorPalabras(String PalabraClave, String Direccion) {
            int InicioIndicePalabra = 0;
            PalabraForm1 = PalabraClave;
            buscarSiguienteToolStripMenuItem.Enabled = true;
            buscarAnteriorToolStripMenuItem.Enabled = true;
            if (PalabraClave.Length > 0){
                //se mandan: la palabra sin espacios, el indice de inicio de palabra y la longitud del texto
                if (Direccion == "abajo"){
                    InicioIndicePalabra = MotorBusquedaDelDerecho(PalabraClave.Trim(), InicioPalabra, richTextBox_Escritura.Text.Length);
                }
                if (Direccion == "arriba"){
                    InicioIndicePalabra = MotorBusquedaDelReves(PalabraClave.Trim(), InicioPalabra, richTextBox_Escritura.Text.Length );
                }
            }

            //si la palabra es encontrada, se marcará
            if (InicioIndicePalabra >= 0){
                // el color de seleccion rojo
                richTextBox_Escritura.SelectionColor = Color.Red;
                //richTextBox_Escritura.Focus();
                //encontrar el indice final, que es la longitud de la palabra
                int FinalIndicePalabra = PalabraClave.Length;
                // marcamos la palabra 
                richTextBox_Escritura.Select(InicioIndicePalabra, FinalIndicePalabra);
                //guardamos la posicion de inicio para la siguiente palabra a buscar
                InicioPalabra = InicioIndicePalabra + FinalIndicePalabra;
            }
            //si no hay coincidencias, reseteamos las variables e informamos de la busqueda fallida
            else if (InicioIndicePalabra < 0){
                //Buscar.Close();
                InicioPalabra = 0;
                IndiceEncontrado = 0;
                MessageBox.Show("No hay mas coincidencias de: " + PalabraForm1);
            }
        }

        public int MotorBusquedaDelDerecho(string PalabraObjetivo, int InicioPalabra, int IndiceFinTexto){
            // deseleccionamos la ultima seleccion
            if (InicioPalabra > 0 && IndiceFinTexto > 0 && IndiceEncontrado >= 0){
                richTextBox_Escritura.Undo();
            }
            // iniciamos el return en -1 por defecto
            int InicioIndicePalabraEncontrado = -1;
            //condiciones para la busqueda de la palabra, cuando el indice sea -1 se termina
            if (InicioPalabra >= 0 && IndiceEncontrado >= 0){
                if (IndiceFinTexto > InicioPalabra || IndiceFinTexto == -1){
                    //introducimos la informacion necesaria para hacer la busqueda, al completarla
                    //el metodo devolverá el indice de la busqueda
                    IndiceEncontrado = richTextBox_Escritura.Find(PalabraObjetivo, InicioPalabra, IndiceFinTexto, RichTextBoxFinds.None);
                    //IndiceFinTexto = IndiceEncontrado + PalabraObjetivo.Length;
                    // comprobar si el texto buscado fue encontrado
                    if (IndiceEncontrado != -1){
                        // guardamos el indice de la palabra para continuar la busqueda
                        InicioIndicePalabraEncontrado = IndiceEncontrado;
                    }
                    else{
                        MessageBox.Show("No hay mas coincidencias de: " + PalabraObjetivo);
                    }
                }
            }
            return InicioIndicePalabraEncontrado;
        }

        public void buscarSiguienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscadorPalabras(PalabraForm1, "abajo");
        }

        public int MotorBusquedaDelReves(string PalabraObjetivo, int InicioPalabra, int IndiceFinTexto){
            // deseleccionamos la ultima seleccion
            if (InicioPalabra > 0 && IndiceFinTexto > 0 && IndiceEncontrado >= 0){
                richTextBox_Escritura.Undo();
            }
            // iniciamos el return en -1 por defecto
            int InicioIndicePalabraEncontrado = -1;
            //condiciones para la busqueda de la palabra, cuando el indice sea -1 se termina
            if (InicioPalabra >= 0 && IndiceEncontrado >= 0){
                if (IndiceFinTexto > InicioPalabra || IndiceFinTexto == -1){
                    //introducimos la informacion necesaria para hacer la busqueda, al completarla
                    //el metodo devolverá el indice de la busqueda
                    IndiceEncontrado = richTextBox_Escritura.Find(PalabraObjetivo, 0, IndiceEncontrado, RichTextBoxFinds.Reverse);
                    IndiceFinTexto = IndiceEncontrado + PalabraObjetivo.Length;

                    // si el texto es encontrado
                    if (IndiceEncontrado != -1){
                        // guardamos el indice de la palabra para continuar la busqueda
                        InicioIndicePalabraEncontrado = IndiceEncontrado;
                    }else{
                        MessageBox.Show("No hay mas coincidencias de: " + PalabraObjetivo);
                    }
                }
            }
            //mandamos donde empieza la palabra para luego mostrarla
            return InicioIndicePalabraEncontrado;
        }



        private void buscarAnteriorToolStripMenuItem_Click(object sender, EventArgs e){
            //en linea 334, al final, cambiar el "none" por "reverse" hará que la busqueda sea en sentido contrario
            BuscadorPalabras(PalabraForm1, "arriba");
        }

        private void reemplazarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //es para ir a una linea específica
        private void irAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            public void Goto(int line)//Goto line function to navigate user to line number  
            {
                index = richTextBox1.GetFirstCharIndexFromLine(line - 1);
                richTextBox1.Select(index, 0);
                richTextBox1.Focus();
            }
            */
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Escritura.SelectAll();
        }

        private void fechaYHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime Fecha = DateTime.Now;
            richTextBox_Escritura.Text = Fecha.ToString();
        }
//Formato
//funciona regular
        private void ajusteDeLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ajusteDeLineaToolStripMenuItem.Checked == true)
            {
                ajusteDeLineaToolStripMenuItem.Checked = false;
                richTextBox_Escritura.WordWrap = false;
            }
            else {
                ajusteDeLineaToolStripMenuItem.Checked = true;
                richTextBox_Escritura.WordWrap = true;
            }
        }
        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e){
            /*
            //cambiar la fuente a todo el documento, incluso lo ya escrito
            FontDialog Fuente = new FontDialog();
            Fuente.Font = richTextBox1.Font;
            if (Fuente.ShowDialog() == DialogResult.OK){
                richTextBox1.Font = Fuente.Font;
            }
            */

            //cambiar la fuente a partir de lo siguiente que se escriba
            if (fontDialog1.ShowDialog() == DialogResult.OK){
                richTextBox_Escritura.SelectionFont = new Font(fontDialog1.Font.FontFamily, fontDialog1.Font.Size, fontDialog1.Font.Style);
            }
        }

        private void colorFuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ColorFuente = new ColorDialog();
            if (ColorFuente.ShowDialog() == DialogResult.OK)
            {
                richTextBox_Escritura.ForeColor = ColorFuente.Color;
            }
        }

        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ColorFondo = new ColorDialog();
            if (ColorFondo.ShowDialog() == DialogResult.OK)
            {
                richTextBox_Escritura.BackColor = ColorFondo.Color;
            }
        }
        private void subrayadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog ColorSubrayado = new ColorDialog();
            if (ColorSubrayado.ShowDialog() == DialogResult.OK)
            {
                richTextBox_Escritura.SelectionBackColor = ColorSubrayado.Color;
            }
        }
//VER
        private void acercarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Escritura.ZoomFactor = richTextBox_Escritura.ZoomFactor + 0.5f;
        }

        private void alejarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Escritura.ZoomFactor = richTextBox_Escritura.ZoomFactor - 0.5f;
        }

        private void restaurarZoomPredeterminadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox_Escritura.ZoomFactor = 1.0f;
        }

        private void barraDeEstadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-----En construcción-----");
        }

//AYUDA
        private void verLaAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-----En construcción-----");
        }

        private void enviarComentariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("-----En construcción-----");
        }

        private void acercaDelBlocDeNotas20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hecho por Adrian De Castro");
            Form2 Acerca = new Form2();
            Acerca.ShowDialog();
        }


    }
}
