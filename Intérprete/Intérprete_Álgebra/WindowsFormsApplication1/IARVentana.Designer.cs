namespace WindowsFormsApplication1
{
    partial class IARVentana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IARVentana));
            this.label1 = new System.Windows.Forms.Label();
            this.lt1 = new System.Windows.Forms.Label();
            this.lt2 = new System.Windows.Forms.Label();
            this.tabla1 = new System.Windows.Forms.TextBox();
            this.tabla2 = new System.Windows.Forms.TextBox();
            this.tablaR = new System.Windows.Forms.TextBox();
            this.ltr = new System.Windows.Forms.Label();
            this.ExpresionAR = new System.Windows.Forms.RichTextBox();
            this.ResultGrid = new System.Windows.Forms.DataGridView();
            this.Contenido = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Ops = new System.Windows.Forms.Label();
            this.tContenido = new System.Windows.Forms.TextBox();
            this.tOps = new System.Windows.Forms.TextBox();
            this.ExpresionSQL = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operacion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lt1
            // 
            this.lt1.AutoSize = true;
            this.lt1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lt1.Location = new System.Drawing.Point(41, 80);
            this.lt1.Name = "lt1";
            this.lt1.Size = new System.Drawing.Size(43, 13);
            this.lt1.TabIndex = 1;
            this.lt1.Text = "Tabla 1";
            // 
            // lt2
            // 
            this.lt2.AutoSize = true;
            this.lt2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lt2.Location = new System.Drawing.Point(235, 80);
            this.lt2.Name = "lt2";
            this.lt2.Size = new System.Drawing.Size(43, 13);
            this.lt2.TabIndex = 2;
            this.lt2.Text = "Tabla 2";
            // 
            // tabla1
            // 
            this.tabla1.Location = new System.Drawing.Point(93, 77);
            this.tabla1.Name = "tabla1";
            this.tabla1.Size = new System.Drawing.Size(100, 20);
            this.tabla1.TabIndex = 3;
            // 
            // tabla2
            // 
            this.tabla2.Location = new System.Drawing.Point(284, 77);
            this.tabla2.Name = "tabla2";
            this.tabla2.Size = new System.Drawing.Size(100, 20);
            this.tabla2.TabIndex = 4;
            // 
            // tablaR
            // 
            this.tablaR.Location = new System.Drawing.Point(519, 77);
            this.tablaR.Name = "tablaR";
            this.tablaR.Size = new System.Drawing.Size(100, 20);
            this.tablaR.TabIndex = 6;
            // 
            // ltr
            // 
            this.ltr.AutoSize = true;
            this.ltr.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ltr.Location = new System.Drawing.Point(425, 80);
            this.ltr.Name = "ltr";
            this.ltr.Size = new System.Drawing.Size(88, 13);
            this.ltr.TabIndex = 5;
            this.ltr.Text = "Tabla Resultante";
            // 
            // ExpresionAR
            // 
            this.ExpresionAR.Location = new System.Drawing.Point(93, 240);
            this.ExpresionAR.Name = "ExpresionAR";
            this.ExpresionAR.ReadOnly = true;
            this.ExpresionAR.Size = new System.Drawing.Size(526, 35);
            this.ExpresionAR.TabIndex = 8;
            this.ExpresionAR.Text = "";
            // 
            // ResultGrid
            // 
            this.ResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGrid.Location = new System.Drawing.Point(93, 404);
            this.ResultGrid.Name = "ResultGrid";
            this.ResultGrid.ReadOnly = true;
            this.ResultGrid.Size = new System.Drawing.Size(526, 196);
            this.ResultGrid.TabIndex = 9;
            // 
            // Contenido
            // 
            this.Contenido.AutoSize = true;
            this.Contenido.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Contenido.Location = new System.Drawing.Point(29, 121);
            this.Contenido.Name = "Contenido";
            this.Contenido.Size = new System.Drawing.Size(55, 13);
            this.Contenido.TabIndex = 10;
            this.Contenido.Text = "Predicado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(25, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Álgebra\r\nRelacional\r\n";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(56, 332);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SQL";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(29, 493);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resultado";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 196);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Operar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ops
            // 
            this.Ops.AutoSize = true;
            this.Ops.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Ops.Location = new System.Drawing.Point(17, 162);
            this.Ops.Name = "Ops";
            this.Ops.Size = new System.Drawing.Size(67, 13);
            this.Ops.TabIndex = 17;
            this.Ops.Text = "Operaciones";
            // 
            // tContenido
            // 
            this.tContenido.Location = new System.Drawing.Point(93, 118);
            this.tContenido.Name = "tContenido";
            this.tContenido.Size = new System.Drawing.Size(526, 20);
            this.tContenido.TabIndex = 18;
            // 
            // tOps
            // 
            this.tOps.Location = new System.Drawing.Point(93, 159);
            this.tOps.Name = "tOps";
            this.tOps.Size = new System.Drawing.Size(526, 20);
            this.tOps.TabIndex = 19;
            // 
            // ExpresionSQL
            // 
            this.ExpresionSQL.Location = new System.Drawing.Point(93, 297);
            this.ExpresionSQL.Name = "ExpresionSQL";
            this.ExpresionSQL.ReadOnly = true;
            this.ExpresionSQL.Size = new System.Drawing.Size(526, 85);
            this.ExpresionSQL.TabIndex = 20;
            this.ExpresionSQL.Text = "";
            // 
            // IARVentana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.ClientSize = new System.Drawing.Size(667, 636);
            this.Controls.Add(this.ExpresionSQL);
            this.Controls.Add(this.tOps);
            this.Controls.Add(this.tContenido);
            this.Controls.Add(this.Ops);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Contenido);
            this.Controls.Add(this.ResultGrid);
            this.Controls.Add(this.ExpresionAR);
            this.Controls.Add(this.tablaR);
            this.Controls.Add(this.ltr);
            this.Controls.Add(this.tabla2);
            this.Controls.Add(this.tabla1);
            this.Controls.Add(this.lt2);
            this.Controls.Add(this.lt1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IARVentana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IAR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IARVentana_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lt1;
        private System.Windows.Forms.Label lt2;
        private System.Windows.Forms.TextBox tabla1;
        private System.Windows.Forms.TextBox tabla2;
        private System.Windows.Forms.TextBox tablaR;
        private System.Windows.Forms.Label ltr;
        private System.Windows.Forms.RichTextBox ExpresionAR;
        private System.Windows.Forms.DataGridView ResultGrid;
        private System.Windows.Forms.Label Contenido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Ops;
        private System.Windows.Forms.TextBox tContenido;
        private System.Windows.Forms.TextBox tOps;
        private System.Windows.Forms.RichTextBox ExpresionSQL;
    }
}