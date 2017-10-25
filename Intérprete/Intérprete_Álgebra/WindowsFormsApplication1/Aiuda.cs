using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Presentacion : Form
    {

        string nombreU = "";
        string passU = "";
        string nameBD = "";
        string nameS = "";
        bool _login = false;

        string table1;
        string table2;
        string tableR;
        string predicado;
        string operaciones;

        List<string> tablasCreadas;

        int tipoOperacion;

        List<Dictionary<int, object>> nombresTablas;

        public Presentacion(int ptipoOperacion, string NU, string PU, string NB, string NS, ref List<string> ptablasCreadas)
        {
            InitializeComponent();

            nombreU = NU;
            passU = PU;
            nameBD = NB;
            nameS = NS;
            tipoOperacion = ptipoOperacion;
            tablasCreadas = ptablasCreadas;

            switch (tipoOperacion)
            {
                case 1:
                    realizarConsultaSQL3(ref tablasCreadas);
                    break;
                //*******************************************************
                case 2:
                    realizarConsultaSQL2(ref tablasCreadas);
                    break;
                //*******************************************************
                case 3:
                    realizarConsultaSQL4();
                    break;
                    //*******************************************************
            }
        }

        private void realizarConsultaSQL2(ref List<string> tables)
        {
            Connection_SQL_Server db = new Connection_SQL_Server(nameS, nameBD, nombreU, passU);

            List<string> columns = null;

            List<Dictionary<int, object>> datos = db.ExecuteTablesDates(ref columns, tables);

            if (datos != null)
            {
                ResultGrid.Columns.Clear();
                ResultGrid.Rows.Clear();

                foreach (var columna in columns)
                {
                    ResultGrid.Columns.Add(columna, columna);
                }

                int campos = columns.Count;

                foreach (var fila in datos)
                {
                    int campo = 0;
                    string[] datas = new string[campos];
                    foreach (var espacio in fila.Values)
                    {
                        datas[campo] = espacio.ToString();
                        campo++;
                    }
                    ResultGrid.Rows.Add(datas);
                }
            }
        }

        private void realizarConsultaSQL3(ref List<string> tables)
        {
            Connection_SQL_Server db = new Connection_SQL_Server(nameS, nameBD, nombreU, passU);

            List<string> columns = null;

            List<Dictionary<int, object>> datos = db.ExecuteTablesDatesDB(ref columns, tables);

            if (datos != null)
            {
                ResultGrid.Columns.Clear();
                ResultGrid.Rows.Clear();

                foreach (var columna in columns)
                {
                    ResultGrid.Columns.Add(columna, columna);
                }

                int campos = columns.Count;

                foreach (var fila in datos)
                {
                    int campo = 0;
                    string[] datas = new string[campos];
                    foreach (var espacio in fila.Values)
                    {
                        datas[campo] = espacio.ToString();
                        campo++;
                    }
                    ResultGrid.Rows.Add(datas);
                }
            }
        }

        private void realizarConsultaSQL4()
        {
            Connection_SQL_Server db = new Connection_SQL_Server(nameS, nameBD, nombreU, passU);

            List<string> columns = null;

            List<Dictionary<int, object>> datos = db.ExecuteAttributesTablesDates(ref columns);

            if (datos != null)
            {
                ResultGrid.Columns.Clear();
                ResultGrid.Rows.Clear();

                foreach (var columna in columns)
                {
                    ResultGrid.Columns.Add(columna, columna);
                }

                int campos = columns.Count;

                foreach (var fila in datos)
                {
                    int campo = 0;
                    string[] datas = new string[campos];
                    foreach (var espacio in fila.Values)
                    {
                        datas[campo] = espacio.ToString();
                        campo++;
                    }
                    ResultGrid.Rows.Add(datas);
                }
            }
        }
    }
}
