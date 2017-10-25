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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<string> tablasCreadas;

        string nombreU= "";
        string passU = "";
        string nameBD = "";
        string nameS = "";
        bool _login = false;

        List<Dictionary<int, object>> tablasConAtributos, tablasRenombre;

        public Form1()
        {
            InitializeComponent();
            tablasCreadas = new List<string>();
            tablasConAtributos = new List<Dictionary<int, object>>();
            tablasRenombre = new List<Dictionary<int, object>>();
        }

        private void selecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(1, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void proyecciónGeneralizadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(2, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void diferenciaDeConjuntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(3, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void productoCartesianoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(4, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void intersecciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(5, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void divisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(6, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void renombrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(12, nombreU, passU, nameBD, nameS, tablasConAtributos, ref tablasRenombre);
            OperacionesR.ShowDialog();
        }

        private void joinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(7, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void naturalJoinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(8, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void agregaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(9, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void agrupaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(10, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void uniónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IARVentana OperacionesR = new IARVentana(11, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private int esTablaOriginal(string nombreTabla)
        {
            for (int i = 0; i < tablasConAtributos.Count; i++)
            {
                if (tablasConAtributos.ElementAt(i).ElementAt(0).Value.ToString().Equals(nombreTabla))
                {
                    Console.WriteLine("es original");
                    return i;
                }
            }
            return -1;
        }

        private void reestablecerNombresTablas()
        {
            Connection_SQL_Server prueba = new Connection_SQL_Server(nameS, nameBD, nombreU, passU);

            List<string> columnas = null;
            string comando;

            foreach (var tabla in tablasRenombre)
            {
                string nombreTablaOriginal = tabla.ElementAt(0).Value.ToString();
                string nombreTablaRenombrada = tabla.ElementAt(1).Value.ToString();

                comando = "SP_RENAME '" + nombreTablaRenombrada + "', '" + nombreTablaOriginal + "'";
                prueba.ExecuteCommand(comando, ref columnas, false);

                int indiceTablaOriginal = esTablaOriginal(nombreTablaOriginal);
                if(indiceTablaOriginal != -1)
                {
                    Dictionary<int, object> tablaOriginal = tablasConAtributos.ElementAt(indiceTablaOriginal);

                    string atributoRenombrado, atributoOriginal;
                    for (int i = 2; i < tabla.Count(); i++)
                    {
                        atributoRenombrado = tabla.ElementAt(i).Value.ToString();
                        atributoOriginal = tablaOriginal.ElementAt(i - 1).Value.ToString();
                        comando = "SP_RENAME '" + nombreTablaOriginal + "." + atributoRenombrado + "', '" + atributoOriginal + "', 'COLUMN'";

                        prueba.ExecuteCommand(comando, ref columnas, false);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("¿Desea cerrar el programa?", "Cerrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                Connection_SQL_Server prueba = new Connection_SQL_Server(nameS, nameBD, nombreU, passU);

                reestablecerNombresTablas();

                foreach (var tabla in tablasCreadas)
                {
                    prueba.DropTable(tabla);
                }

            }
        }

        public bool Vacio(string evaluar)
        {
            evaluar = evaluar.Replace(" ", "");
            if (string.IsNullOrEmpty(evaluar))
                return true;

            return false;
        }

        //Salva los nombres de las tablas con los atributos que le corresponden
        private void salvarTablasAtributos()
        {
            Connection_SQL_Server temp = new Connection_SQL_Server(nameS, nameBD, nombreU, passU);
            List<Dictionary<int, object>> aux = temp.getTablesNamesAndAttributes();

            string nombre = aux.ElementAt(0).ElementAt(0).Value.ToString();
            Dictionary<int, object> fila = new Dictionary<int, object>();
            fila.Add(0, nombre);
            int a = 1;

            foreach (var campo in aux)
            {
                string atributo = campo.ElementAt(1).Value.ToString();

                if (fila.ElementAt(0).Value.Equals(campo.ElementAt(0).Value.ToString()))
                {
                    fila.Add(a, atributo);
                    a++;
                }
                else
                {
                    tablasConAtributos.Add(fila);
                    fila = new Dictionary<int, object>();
                    fila.Add(0, campo.ElementAt(0).Value.ToString());
                    fila.Add(1, campo.ElementAt(1).Value.ToString());
                    a = 2;
                    if (aux.Last().ElementAt(0).Value.ToString().Equals(campo.ElementAt(0).Value.ToString()))
                    {
                        tablasConAtributos.Add(fila);
                    }
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        { 
            nameBD = NBD.Text;
            nombreU = UserN.Text;
            passU = UserP.Text;
            nameS = NombreS.Text;

            if (!Vacio(nameBD))
            {
                if (!Vacio(nameS))
                {
                    Connection_SQL_Server prueba = new Connection_SQL_Server(nameS, nameBD, nombreU, passU);
                    _login = prueba.TestConnection();
                    if (_login)
                    {
                        btnLogin.Enabled = false;
                        btnLogin.Visible = false;
                        pDarth.Enabled = false;
                        pDarth.Visible = false;
                        Menus.Enabled = true;

                        salvarTablasAtributos();
                    }
                    else
                    {
                        DialogResult res = MessageBox.Show("Conexión Fallida, Datos Inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    DialogResult res = MessageBox.Show("Debe Escribir el Servidor a Utilizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                DialogResult res = MessageBox.Show("Debe Escribir el Nombre de la Base de Datos a Utilizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tablasOriginalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion OperacionesR = new Presentacion(1, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void tablasResultantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion OperacionesR = new Presentacion(2, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acerca about = new Acerca();
            about.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string pdfPath = Path.Combine(Application.StartupPath, "Manual de Usuario.pdf");
            Process.Start(pdfPath); 
        }

        private void atributosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Presentacion OperacionesR = new Presentacion(3, nombreU, passU, nameBD, nameS, ref tablasCreadas);
            OperacionesR.ShowDialog();
        }
    }
}
