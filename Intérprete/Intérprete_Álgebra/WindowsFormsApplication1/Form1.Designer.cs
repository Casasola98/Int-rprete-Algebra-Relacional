namespace WindowsFormsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Menus = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrupaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.naturalJoinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.joinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renombrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intersecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoCartesianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diferenciaDeConjuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uniónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyecciónGeneralizadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presentacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atributosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasResultantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasOriginalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titulo = new System.Windows.Forms.Label();
            this.pDarth = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserP = new System.Windows.Forms.TextBox();
            this.UserN = new System.Windows.Forms.TextBox();
            this.NBD = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menus.SuspendLayout();
            this.pDarth.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menus
            // 
            this.Menus.BackColor = System.Drawing.Color.DarkGray;
            this.Menus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Menus.Enabled = false;
            this.Menus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.presentacionesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.Menus.Location = new System.Drawing.Point(0, 460);
            this.Menus.Name = "Menus";
            this.Menus.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menus.Size = new System.Drawing.Size(819, 24);
            this.Menus.TabIndex = 0;
            this.Menus.Text = "Menus";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrupaciónToolStripMenuItem,
            this.agregaciónToolStripMenuItem,
            this.naturalJoinToolStripMenuItem,
            this.joinToolStripMenuItem,
            this.renombrarToolStripMenuItem,
            this.divisiónToolStripMenuItem,
            this.intersecciónToolStripMenuItem,
            this.productoCartesianoToolStripMenuItem,
            this.diferenciaDeConjuntosToolStripMenuItem,
            this.uniónToolStripMenuItem,
            this.proyecciónGeneralizadaToolStripMenuItem,
            this.selecciónToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // agrupaciónToolStripMenuItem
            // 
            this.agrupaciónToolStripMenuItem.Name = "agrupaciónToolStripMenuItem";
            this.agrupaciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agrupaciónToolStripMenuItem.Text = "Agrupación";
            this.agrupaciónToolStripMenuItem.Click += new System.EventHandler(this.agrupaciónToolStripMenuItem_Click);
            // 
            // agregaciónToolStripMenuItem
            // 
            this.agregaciónToolStripMenuItem.Name = "agregaciónToolStripMenuItem";
            this.agregaciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.agregaciónToolStripMenuItem.Text = "Agregación";
            this.agregaciónToolStripMenuItem.Click += new System.EventHandler(this.agregaciónToolStripMenuItem_Click);
            // 
            // naturalJoinToolStripMenuItem
            // 
            this.naturalJoinToolStripMenuItem.Name = "naturalJoinToolStripMenuItem";
            this.naturalJoinToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.naturalJoinToolStripMenuItem.Text = "Natural Join";
            this.naturalJoinToolStripMenuItem.Click += new System.EventHandler(this.naturalJoinToolStripMenuItem_Click);
            // 
            // joinToolStripMenuItem
            // 
            this.joinToolStripMenuItem.Name = "joinToolStripMenuItem";
            this.joinToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.joinToolStripMenuItem.Text = "Join";
            this.joinToolStripMenuItem.Click += new System.EventHandler(this.joinToolStripMenuItem_Click);
            // 
            // renombrarToolStripMenuItem
            // 
            this.renombrarToolStripMenuItem.Name = "renombrarToolStripMenuItem";
            this.renombrarToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.renombrarToolStripMenuItem.Text = "Renombramiento";
            this.renombrarToolStripMenuItem.Click += new System.EventHandler(this.renombrarToolStripMenuItem_Click);
            // 
            // divisiónToolStripMenuItem
            // 
            this.divisiónToolStripMenuItem.Name = "divisiónToolStripMenuItem";
            this.divisiónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.divisiónToolStripMenuItem.Text = "División";
            this.divisiónToolStripMenuItem.Click += new System.EventHandler(this.divisiónToolStripMenuItem_Click);
            // 
            // intersecciónToolStripMenuItem
            // 
            this.intersecciónToolStripMenuItem.Name = "intersecciónToolStripMenuItem";
            this.intersecciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.intersecciónToolStripMenuItem.Text = "Intersección";
            this.intersecciónToolStripMenuItem.Click += new System.EventHandler(this.intersecciónToolStripMenuItem_Click);
            // 
            // productoCartesianoToolStripMenuItem
            // 
            this.productoCartesianoToolStripMenuItem.Name = "productoCartesianoToolStripMenuItem";
            this.productoCartesianoToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.productoCartesianoToolStripMenuItem.Text = "Producto Cartesiano";
            this.productoCartesianoToolStripMenuItem.Click += new System.EventHandler(this.productoCartesianoToolStripMenuItem_Click);
            // 
            // diferenciaDeConjuntosToolStripMenuItem
            // 
            this.diferenciaDeConjuntosToolStripMenuItem.Name = "diferenciaDeConjuntosToolStripMenuItem";
            this.diferenciaDeConjuntosToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.diferenciaDeConjuntosToolStripMenuItem.Text = "Diferencia de Conjuntos";
            this.diferenciaDeConjuntosToolStripMenuItem.Click += new System.EventHandler(this.diferenciaDeConjuntosToolStripMenuItem_Click);
            // 
            // uniónToolStripMenuItem
            // 
            this.uniónToolStripMenuItem.Name = "uniónToolStripMenuItem";
            this.uniónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.uniónToolStripMenuItem.Text = "Unión";
            this.uniónToolStripMenuItem.Click += new System.EventHandler(this.uniónToolStripMenuItem_Click);
            // 
            // proyecciónGeneralizadaToolStripMenuItem
            // 
            this.proyecciónGeneralizadaToolStripMenuItem.Name = "proyecciónGeneralizadaToolStripMenuItem";
            this.proyecciónGeneralizadaToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.proyecciónGeneralizadaToolStripMenuItem.Text = "Proyección Generalizada";
            this.proyecciónGeneralizadaToolStripMenuItem.Click += new System.EventHandler(this.proyecciónGeneralizadaToolStripMenuItem_Click);
            // 
            // selecciónToolStripMenuItem
            // 
            this.selecciónToolStripMenuItem.Name = "selecciónToolStripMenuItem";
            this.selecciónToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.selecciónToolStripMenuItem.Text = "Selección";
            this.selecciónToolStripMenuItem.Click += new System.EventHandler(this.selecciónToolStripMenuItem_Click);
            // 
            // presentacionesToolStripMenuItem
            // 
            this.presentacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atributosToolStripMenuItem,
            this.tablasResultantesToolStripMenuItem,
            this.tablasOriginalesToolStripMenuItem});
            this.presentacionesToolStripMenuItem.Name = "presentacionesToolStripMenuItem";
            this.presentacionesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.presentacionesToolStripMenuItem.Text = "Presentaciones";
            // 
            // atributosToolStripMenuItem
            // 
            this.atributosToolStripMenuItem.Name = "atributosToolStripMenuItem";
            this.atributosToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.atributosToolStripMenuItem.Text = "Atributos";
            this.atributosToolStripMenuItem.Click += new System.EventHandler(this.atributosToolStripMenuItem_Click);
            // 
            // tablasResultantesToolStripMenuItem
            // 
            this.tablasResultantesToolStripMenuItem.Name = "tablasResultantesToolStripMenuItem";
            this.tablasResultantesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tablasResultantesToolStripMenuItem.Text = "Tablas Resultantes";
            this.tablasResultantesToolStripMenuItem.Click += new System.EventHandler(this.tablasResultantesToolStripMenuItem_Click);
            // 
            // tablasOriginalesToolStripMenuItem
            // 
            this.tablasOriginalesToolStripMenuItem.Name = "tablasOriginalesToolStripMenuItem";
            this.tablasOriginalesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.tablasOriginalesToolStripMenuItem.Text = "Tablas Originales";
            this.tablasOriginalesToolStripMenuItem.Click += new System.EventHandler(this.tablasOriginalesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.BackColor = System.Drawing.Color.DarkGreen;
            this.titulo.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.titulo.Location = new System.Drawing.Point(29, 32);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(266, 87);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "Intérprete\r\nde \r\nÁlgebra Relacional";
            // 
            // pDarth
            // 
            this.pDarth.BackColor = System.Drawing.Color.Black;
            this.pDarth.Controls.Add(this.label5);
            this.pDarth.Controls.Add(this.NombreS);
            this.pDarth.Controls.Add(this.label4);
            this.pDarth.Controls.Add(this.label3);
            this.pDarth.Controls.Add(this.label2);
            this.pDarth.Controls.Add(this.UserP);
            this.pDarth.Controls.Add(this.UserN);
            this.pDarth.Controls.Add(this.NBD);
            this.pDarth.Controls.Add(this.btnLogin);
            this.pDarth.Location = new System.Drawing.Point(329, 244);
            this.pDarth.Name = "pDarth";
            this.pDarth.Size = new System.Drawing.Size(192, 157);
            this.pDarth.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(34, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Server";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NombreS
            // 
            this.NombreS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NombreS.Location = new System.Drawing.Point(78, 94);
            this.NombreS.Name = "NombreS";
            this.NombreS.Size = new System.Drawing.Size(100, 20);
            this.NombreS.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(11, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contraseña";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(29, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Usuario";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre\r\nBD";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserP
            // 
            this.UserP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UserP.Location = new System.Drawing.Point(78, 66);
            this.UserP.Name = "UserP";
            this.UserP.Size = new System.Drawing.Size(100, 20);
            this.UserP.TabIndex = 12;
            // 
            // UserN
            // 
            this.UserN.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UserN.Location = new System.Drawing.Point(78, 38);
            this.UserN.Name = "UserN";
            this.UserN.Size = new System.Drawing.Size(100, 20);
            this.UserN.TabIndex = 11;
            // 
            // NBD
            // 
            this.NBD.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NBD.Location = new System.Drawing.Point(78, 10);
            this.NBD.Name = "NBD";
            this.NBD.Size = new System.Drawing.Size(100, 20);
            this.NBD.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Salmon;
            this.btnLogin.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(14, 121);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(164, 27);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 484);
            this.Controls.Add(this.pDarth);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.Menus);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menus;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "I.A.R";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Menus.ResumeLayout(false);
            this.Menus.PerformLayout();
            this.pDarth.ResumeLayout(false);
            this.pDarth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menus;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrupaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem naturalJoinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem joinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renombrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intersecciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoCartesianoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diferenciaDeConjuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyecciónGeneralizadaToolStripMenuItem;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.ToolStripMenuItem uniónToolStripMenuItem;
        private System.Windows.Forms.Panel pDarth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserP;
        private System.Windows.Forms.TextBox UserN;
        private System.Windows.Forms.TextBox NBD;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreS;
        private System.Windows.Forms.ToolStripMenuItem presentacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atributosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasResultantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasOriginalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

