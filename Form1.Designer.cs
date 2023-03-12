
namespace Ejercicio12_MK1
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            this.richTextBox_Escritura = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventanaNuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.configurarPáginaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrevisualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.busquedaConGoogleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSiguienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAnteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reemplazarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fechaYHoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajusteDeLineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDeFondoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subrayadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alejarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarZoomPredeterminadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLaAyudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarComentariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDelBlocDeNotas20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox_Escritura
            // 
            this.richTextBox_Escritura.EnableAutoDragDrop = true;
            this.richTextBox_Escritura.Location = new System.Drawing.Point(0, 27);
            this.richTextBox_Escritura.Name = "richTextBox_Escritura";
            this.richTextBox_Escritura.Size = new System.Drawing.Size(800, 424);
            this.richTextBox_Escritura.TabIndex = 7;
            this.richTextBox_Escritura.Text = "";
            this.richTextBox_Escritura.SelectionChanged += new System.EventHandler(this.richTextBox_Escritura_SelectionChanged);
            this.richTextBox_Escritura.TextChanged += new System.EventHandler(this.richTextBox_Escritura_TextChanged);
            this.richTextBox_Escritura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.richTextBox_Escritura_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.ventanaNuevaToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.configurarPáginaToolStripMenuItem,
            this.PrevisualizarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // ventanaNuevaToolStripMenuItem
            // 
            this.ventanaNuevaToolStripMenuItem.Name = "ventanaNuevaToolStripMenuItem";
            this.ventanaNuevaToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Mayús + N";
            this.ventanaNuevaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.ventanaNuevaToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.ventanaNuevaToolStripMenuItem.Text = "Ventana Nueva";
            this.ventanaNuevaToolStripMenuItem.Click += new System.EventHandler(this.ventanaNuevaToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + A";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.abrirToolStripMenuItem.Text = "Abrir...";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + G";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Mayús + G";
            this.guardarComoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como....";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(256, 6);
            // 
            // configurarPáginaToolStripMenuItem
            // 
            this.configurarPáginaToolStripMenuItem.Name = "configurarPáginaToolStripMenuItem";
            this.configurarPáginaToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.configurarPáginaToolStripMenuItem.Text = "Configurar página";
            this.configurarPáginaToolStripMenuItem.Click += new System.EventHandler(this.configurarPáginaToolStripMenuItem_Click);
            // 
            // PrevisualizarToolStripMenuItem
            // 
            this.PrevisualizarToolStripMenuItem.Name = "PrevisualizarToolStripMenuItem";
            this.PrevisualizarToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.PrevisualizarToolStripMenuItem.Text = "Previsualizar Impresión";
            this.PrevisualizarToolStripMenuItem.Click += new System.EventHandler(this.PrevisualizarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(259, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(256, 6);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(259, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.toolStripMenuItem3,
            this.busquedaConGoogleToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.buscarSiguienteToolStripMenuItem,
            this.buscarAnteriorToolStripMenuItem,
            this.reemplazarToolStripMenuItem,
            this.irAToolStripMenuItem,
            this.toolStripMenuItem5,
            this.seleccionarTodoToolStripMenuItem,
            this.fechaYHoraToolStripMenuItem});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Enabled = false;
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Z";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.deshacerToolStripMenuItem.Text = "Deshacer";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(233, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Enabled = false;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + X";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.cortarToolStripMenuItem.Text = "Cortar";
            this.cortarToolStripMenuItem.Click += new System.EventHandler(this.cortarToolStripMenuItem_Click);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Enabled = false;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + C";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Enabled = false;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + V";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.pegarToolStripMenuItem.Text = "Pegar";
            this.pegarToolStripMenuItem.Click += new System.EventHandler(this.pegarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Enabled = false;
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.ShortcutKeyDisplayString = "Supr";
            this.eliminarToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(233, 6);
            // 
            // busquedaConGoogleToolStripMenuItem
            // 
            this.busquedaConGoogleToolStripMenuItem.Enabled = false;
            this.busquedaConGoogleToolStripMenuItem.Name = "busquedaConGoogleToolStripMenuItem";
            this.busquedaConGoogleToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + F";
            this.busquedaConGoogleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.busquedaConGoogleToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.busquedaConGoogleToolStripMenuItem.Text = "Búsqueda con Google";
            this.busquedaConGoogleToolStripMenuItem.Click += new System.EventHandler(this.busquedaConGoogleToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.buscarToolStripMenuItem.Text = "Buscar...";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // buscarSiguienteToolStripMenuItem
            // 
            this.buscarSiguienteToolStripMenuItem.Enabled = false;
            this.buscarSiguienteToolStripMenuItem.Name = "buscarSiguienteToolStripMenuItem";
            this.buscarSiguienteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.buscarSiguienteToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.buscarSiguienteToolStripMenuItem.Text = "Buscar Siguiente";
            this.buscarSiguienteToolStripMenuItem.Click += new System.EventHandler(this.buscarSiguienteToolStripMenuItem_Click);
            // 
            // buscarAnteriorToolStripMenuItem
            // 
            this.buscarAnteriorToolStripMenuItem.Enabled = false;
            this.buscarAnteriorToolStripMenuItem.Name = "buscarAnteriorToolStripMenuItem";
            this.buscarAnteriorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.buscarAnteriorToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.buscarAnteriorToolStripMenuItem.Text = "Buscar Anterior";
            this.buscarAnteriorToolStripMenuItem.Click += new System.EventHandler(this.buscarAnteriorToolStripMenuItem_Click);
            // 
            // reemplazarToolStripMenuItem
            // 
            this.reemplazarToolStripMenuItem.Name = "reemplazarToolStripMenuItem";
            this.reemplazarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.reemplazarToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.reemplazarToolStripMenuItem.Text = "Reemplazar";
            this.reemplazarToolStripMenuItem.Click += new System.EventHandler(this.reemplazarToolStripMenuItem_Click);
            // 
            // irAToolStripMenuItem
            // 
            this.irAToolStripMenuItem.Enabled = false;
            this.irAToolStripMenuItem.Name = "irAToolStripMenuItem";
            this.irAToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.irAToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.irAToolStripMenuItem.Text = "Ir a...";
            this.irAToolStripMenuItem.Click += new System.EventHandler(this.irAToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(233, 6);
            // 
            // seleccionarTodoToolStripMenuItem
            // 
            this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
            this.seleccionarTodoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.seleccionarTodoToolStripMenuItem.Text = "Seleccionar Todo";
            this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.seleccionarTodoToolStripMenuItem_Click);
            // 
            // fechaYHoraToolStripMenuItem
            // 
            this.fechaYHoraToolStripMenuItem.Name = "fechaYHoraToolStripMenuItem";
            this.fechaYHoraToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.fechaYHoraToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.fechaYHoraToolStripMenuItem.Text = "Hora y Fecha";
            this.fechaYHoraToolStripMenuItem.Click += new System.EventHandler(this.fechaYHoraToolStripMenuItem_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajusteDeLineaToolStripMenuItem,
            this.fuenteToolStripMenuItem,
            this.colorFuenteToolStripMenuItem,
            this.colorDeFondoToolStripMenuItem,
            this.subrayadoToolStripMenuItem});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // ajusteDeLineaToolStripMenuItem
            // 
            this.ajusteDeLineaToolStripMenuItem.Checked = true;
            this.ajusteDeLineaToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ajusteDeLineaToolStripMenuItem.Name = "ajusteDeLineaToolStripMenuItem";
            this.ajusteDeLineaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.ajusteDeLineaToolStripMenuItem.Text = "Ajuste de línea";
            this.ajusteDeLineaToolStripMenuItem.Click += new System.EventHandler(this.ajusteDeLineaToolStripMenuItem_Click);
            // 
            // fuenteToolStripMenuItem
            // 
            this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
            this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fuenteToolStripMenuItem.Text = "Estilo Fuente";
            this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.fuenteToolStripMenuItem_Click);
            // 
            // colorFuenteToolStripMenuItem
            // 
            this.colorFuenteToolStripMenuItem.Name = "colorFuenteToolStripMenuItem";
            this.colorFuenteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.colorFuenteToolStripMenuItem.Text = "Color Fuente";
            this.colorFuenteToolStripMenuItem.Click += new System.EventHandler(this.colorFuenteToolStripMenuItem_Click);
            // 
            // colorDeFondoToolStripMenuItem
            // 
            this.colorDeFondoToolStripMenuItem.Name = "colorDeFondoToolStripMenuItem";
            this.colorDeFondoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.colorDeFondoToolStripMenuItem.Text = "Color de Fondo";
            this.colorDeFondoToolStripMenuItem.Click += new System.EventHandler(this.colorDeFondoToolStripMenuItem_Click);
            // 
            // subrayadoToolStripMenuItem
            // 
            this.subrayadoToolStripMenuItem.Name = "subrayadoToolStripMenuItem";
            this.subrayadoToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.subrayadoToolStripMenuItem.Text = "Subrayado";
            this.subrayadoToolStripMenuItem.Click += new System.EventHandler(this.subrayadoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToolStripMenuItem,
            this.barraDeEstadoToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercarToolStripMenuItem,
            this.alejarToolStripMenuItem,
            this.restaurarZoomPredeterminadoToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            // 
            // acercarToolStripMenuItem
            // 
            this.acercarToolStripMenuItem.Name = "acercarToolStripMenuItem";
            this.acercarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + signo más";
            this.acercarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.acercarToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.acercarToolStripMenuItem.Text = "Acercar";
            this.acercarToolStripMenuItem.Click += new System.EventHandler(this.acercarToolStripMenuItem_Click);
            // 
            // alejarToolStripMenuItem
            // 
            this.alejarToolStripMenuItem.Name = "alejarToolStripMenuItem";
            this.alejarToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + signo menos";
            this.alejarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.alejarToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.alejarToolStripMenuItem.Text = "Alejar";
            this.alejarToolStripMenuItem.Click += new System.EventHandler(this.alejarToolStripMenuItem_Click);
            // 
            // restaurarZoomPredeterminadoToolStripMenuItem
            // 
            this.restaurarZoomPredeterminadoToolStripMenuItem.Name = "restaurarZoomPredeterminadoToolStripMenuItem";
            this.restaurarZoomPredeterminadoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + 0";
            this.restaurarZoomPredeterminadoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.restaurarZoomPredeterminadoToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.restaurarZoomPredeterminadoToolStripMenuItem.Text = "Restaurar zoom predeterminado";
            this.restaurarZoomPredeterminadoToolStripMenuItem.Click += new System.EventHandler(this.restaurarZoomPredeterminadoToolStripMenuItem_Click);
            // 
            // barraDeEstadoToolStripMenuItem
            // 
            this.barraDeEstadoToolStripMenuItem.Checked = true;
            this.barraDeEstadoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeEstadoToolStripMenuItem.Name = "barraDeEstadoToolStripMenuItem";
            this.barraDeEstadoToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.barraDeEstadoToolStripMenuItem.Text = "Barra de estado";
            this.barraDeEstadoToolStripMenuItem.Click += new System.EventHandler(this.barraDeEstadoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLaAyudaToolStripMenuItem,
            this.enviarComentariosToolStripMenuItem,
            this.toolStripMenuItem4,
            this.acercaDelBlocDeNotas20ToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // verLaAyudaToolStripMenuItem
            // 
            this.verLaAyudaToolStripMenuItem.Name = "verLaAyudaToolStripMenuItem";
            this.verLaAyudaToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.verLaAyudaToolStripMenuItem.Text = "Ver la Ayuda";
            this.verLaAyudaToolStripMenuItem.Click += new System.EventHandler(this.verLaAyudaToolStripMenuItem_Click);
            // 
            // enviarComentariosToolStripMenuItem
            // 
            this.enviarComentariosToolStripMenuItem.Name = "enviarComentariosToolStripMenuItem";
            this.enviarComentariosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.enviarComentariosToolStripMenuItem.Text = "Enviar comentarios";
            this.enviarComentariosToolStripMenuItem.Click += new System.EventHandler(this.enviarComentariosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(220, 6);
            // 
            // acercaDelBlocDeNotas20ToolStripMenuItem
            // 
            this.acercaDelBlocDeNotas20ToolStripMenuItem.Name = "acercaDelBlocDeNotas20ToolStripMenuItem";
            this.acercaDelBlocDeNotas20ToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.acercaDelBlocDeNotas20ToolStripMenuItem.Text = "Acerca del Bloc de Notas 2.0";
            this.acercaDelBlocDeNotas20ToolStripMenuItem.Click += new System.EventHandler(this.acercaDelBlocDeNotas20ToolStripMenuItem_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox_Escritura);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PantallaPrincipal";
            this.Text = "Bloc de Notas 2.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Escritura;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventanaNuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem busquedaConGoogleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajusteDeLineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alejarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaurarZoomPredeterminadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barraDeEstadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLaAyudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarComentariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem acercaDelBlocDeNotas20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSiguienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAnteriorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reemplazarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem seleccionarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fechaYHoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorFuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorDeFondoToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem subrayadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurarPáginaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrevisualizarToolStripMenuItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
    }
}

