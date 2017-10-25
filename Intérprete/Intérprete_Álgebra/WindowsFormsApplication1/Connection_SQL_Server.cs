using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Connection_SQL_Server
    {
        private string server;
        private string dataBase;
        private string userId;
        private string password;

        public Connection_SQL_Server(string s, string d, string u, string p)
        {
            this.server = s;
            this.dataBase = d;
            this.userId = u;
            this.password = p;
        }

        private string ConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(userId) || userId.Trim().Equals(string.Empty))
                {
                    return string.Format("Data Source={0};Initial Catalog={1};Integrated Security=yes", server, dataBase);
                }
                else
                {
                    return string.Format("Data Source={0};Initial Catalog={1};User ID={2};Pwd={3}", server, dataBase, userId, password);
                }

            }
        }

        public bool TestConnection()
        {
            SqlConnection cn;
            cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                if (cn != null)
                {
                    cn.Close();
                    return true;
                }
                else
                {
                    cn.Close();
                    return false;
                }
            }
            catch
            {
                cn.Close();
                return false;
            }
        }

        public List<Dictionary<int, object>> ExecuteCommand(string statement, ref List<string> nombreColumnas, bool mostrarMensajeError)
        {

            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();
            nombreColumnas = new List<string>();

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(statement);
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;

                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    if (nombreColumnas.Count == 0)
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            nombreColumnas.Add(dr.GetName(i));
                        }
                    }

                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                if (mostrarMensajeError)
                {
                    DialogResult res = MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return null;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public bool ExistTable(string tableName)
        {
            List<string> columns = null;

            List<Dictionary<int, object>> datos = this.ExecuteCommand(string.Format("select 1 from sys.tables where name = '{0}'", tableName), ref columns, true);
            return datos.Count > 0;
        }

        public void DropTable(string tableName)
        {
            if (this.ExistTable(tableName))
            {
                Console.WriteLine("Aiuda");
                SqlConnection cn = new SqlConnection(ConnectionString);
                try
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(string.Format("drop table {0}", tableName));
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.Connection = cn;

                    cm.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cn.State == System.Data.ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }

            }
        }

        public int GetQuantityAttribute(string tableName)
        {
            int numAttributes = 0;
            if (this.ExistTable(tableName))
            {
                SqlConnection cn = new SqlConnection(ConnectionString);
                try
                {
                    cn.Open();
                    SqlCommand cm = new SqlCommand(string.Format("select count(*) from sysobjects, syscolumns where sysobjects.id = syscolumns.id and sysobjects.name = '{0}'", tableName));
                    cm.CommandType = System.Data.CommandType.Text;
                    cm.Connection = cn;
                    numAttributes = (int)(cm.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (cn.State == System.Data.ConnectionState.Open)
                    {
                        cn.Close();
                    }
                }
            }
            return numAttributes;
        }

        public List<Dictionary<int, object>> getTableDomain(string tableName)
        {

            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(string.Format("select COLUMN_NAME,  DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, NUMERIC_PRECISION FROM INFORMATION_SCHEMA.COLUMNS AS c1 where c1.table_name = '{0}'", tableName));
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;

                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public List<Dictionary<int, object>> getTableNames()
        {
            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(string.Format("SELECT DISTINCT TABLE_NAME FROM INFORMATION_SCHEMA.COLUMNS"));
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;

                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        //Tablas con los atributos
        public List<Dictionary<int, object>> getTablesNamesAndAttributes()
        {
            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(string.Format("SELECT TABLE_NAME, COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS ORDER BY TABLE_NAME, ORDINAL_POSITION"));
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;

                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public List<Dictionary<int, object>> ExecuteTablesDates(ref List<string> nombreColumnas, List<string> tables)
        {

            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();
            nombreColumnas = new List<string>();
            List<string> tablesInformation = null;
            tablesInformation = tables;
            string tablesToShow = "";

            if (tablesInformation.Count == 1)
            {
                tablesToShow = tablesInformation[0].ToString();
            }
            else
            {
                for (int i = 0; i < tablesInformation.Count; i++)
                {
                    if (i == tablesInformation.Count - 1)
                    {
                        tablesToShow += "'" + tablesInformation[i].ToString();
                    }
                    else
                    {
                        if (i == 0)
                        {
                            tablesToShow += tablesInformation[i].ToString() + "'" + ",";
                        }
                        else
                        {
                            tablesToShow += "'" + tablesInformation[i].ToString() + "'" + ",";
                        }
                    }
                }
            }

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(String.Format("SELECT Object_name(c.object_id) AS Tabla, c.NAME 'Columna', t.NAME 'Tipo', CASE  WHEN c.max_length = 0 THEN '' ELSE c.max_length END AS Largo, CASE WHEN c.is_nullable = 0 THEN 'No' ELSE 'Si' END AS PermiteNulo, CASE WHEN Isnull(i.is_primary_key, 0) = 0 THEN 'No' ELSE 'Si' END AS 'LlavePrimaria', CASE WHEN Isnull(fk.[table], '') = '' THEN 'No' ELSE 'Si' END AS LlaveForanea, Isnull(fk.referenced_table, '') AS TablaReferenciada, Isnull(fk.referenced_column, '') AS ColumnaReferenciada FROM sys.columns c INNER JOIN sys.tables tbl ON c.object_id = tbl.object_id INNER JOIN sys.types t ON c.user_type_id = t.user_type_id LEFT OUTER JOIN sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id LEFT OUTER JOIN sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id LEFT OUTER JOIN(SELECT obj.NAME  AS FK_NAME, sch.NAME  AS[schema_name], tab1.NAME AS[table], col1.NAME AS[column], tab2.NAME AS[referenced_table], col2.NAME AS[referenced_column] FROM   sys.foreign_key_columns fkc INNER JOIN sys.objects obj ON obj.object_id = fkc.constraint_object_id INNER JOIN sys.tables tab1 ON tab1.object_id = fkc.parent_object_id INNER JOIN sys.schemas sch ON tab1.schema_id = sch.schema_id INNER JOIN sys.columns col1 ON col1.column_id = parent_column_id AND col1.object_id = tab1.object_id INNER JOIN sys.tables tab2 ON tab2.object_id = fkc.referenced_object_id INNER JOIN sys.columns col2 ON col2.column_id = referenced_column_id AND col2.object_id = tab2.object_id) fk ON Schema_name(tbl.schema_id) = fk.schema_name AND Object_name(c.object_id) = fk.[table] AND c.NAME = fk.[column] where Object_name(c.object_id) in ('{0}') order by Tabla, c.column_id", tablesToShow));
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    if (nombreColumnas.Count == 0)
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            nombreColumnas.Add(dr.GetName(i));
                        }
                    }

                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public List<Dictionary<int, object>> ExecuteAttributesTablesDates(ref List<string> nombreColumnas)
        {
            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();
            nombreColumnas = new List<string>();

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT c.NAME 'Columna', Object_name(c.object_id) AS Tabla, t.NAME 'Tipo', CASE  WHEN c.max_length = 0 THEN '' ELSE c.max_length END AS Largo, CASE WHEN c.is_nullable = 0 THEN 'No' ELSE 'Si' END AS PermiteNulo, CASE WHEN Isnull(i.is_primary_key, 0) = 0 THEN 'No' ELSE 'Si' END AS 'LlavePrimaria', CASE WHEN Isnull(fk.[table], '') = '' THEN 'No' ELSE 'Si' END AS LlaveForanea, Isnull(fk.referenced_table, '') AS TablaReferenciada, Isnull(fk.referenced_column, '') AS ColumnaReferenciada FROM sys.columns c INNER JOIN sys.tables tbl ON c.object_id = tbl.object_id INNER JOIN sys.types t ON c.user_type_id = t.user_type_id LEFT OUTER JOIN sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id LEFT OUTER JOIN sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id LEFT OUTER JOIN(SELECT obj.NAME  AS FK_NAME, sch.NAME  AS[schema_name], tab1.NAME AS[table], col1.NAME AS[column], tab2.NAME AS[referenced_table], col2.NAME AS[referenced_column] FROM   sys.foreign_key_columns fkc INNER JOIN sys.objects obj ON obj.object_id = fkc.constraint_object_id INNER JOIN sys.tables tab1 ON tab1.object_id = fkc.parent_object_id INNER JOIN sys.schemas sch ON tab1.schema_id = sch.schema_id INNER JOIN sys.columns col1 ON col1.column_id = parent_column_id AND col1.object_id = tab1.object_id INNER JOIN sys.tables tab2 ON tab2.object_id = fkc.referenced_object_id INNER JOIN sys.columns col2 ON col2.column_id = referenced_column_id AND col2.object_id = tab2.object_id) fk ON Schema_name(tbl.schema_id) = fk.schema_name AND Object_name(c.object_id) = fk.[table] AND c.NAME = fk.[column] order by c.NAME ");
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    if (nombreColumnas.Count == 0)
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            nombreColumnas.Add(dr.GetName(i));
                        }
                    }

                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public List<Dictionary<int, object>> Division(ref RichTextBox text, ref List<string> nombreColumnas, string tablename1, string tablename2)
        {
            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();
            nombreColumnas = new List<string>();

            List<string> nombreColumnas1 = null;
            List<string> nombreColumnastable1 = getAtrributes(tablename1, ref nombreColumnas1);

            List<string> nombreColumnas2 = null;
            List<string> nombreColumnasTable2 = getAtrributes(tablename2, ref nombreColumnas2);

            List<string> nombreComlumnasCompartidas = new List<string>();
            List<string> nombreTableComlumnasCompartidas = getAttributesCommon(ref nombreColumnastable1, ref nombreColumnasTable2, ref nombreComlumnasCompartidas);

            string parameters = "";
            parameters = getString(ref nombreComlumnasCompartidas);

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(string.Format("select distinct {3} from {1} group by {3} having count(distinct {0}) >= (select count(distinct {0}) from {2})", parameters, tablename1, tablename2, nombreColumnas1[0].ToString()));
                text.Text = string.Format("select distinct {3} from {1} group by {3} having count(distinct {0}) >= (select count(distinct {0}) from {2})", parameters, tablename1, tablename2, nombreColumnas1[0].ToString());
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    if (nombreColumnas.Count == 0)
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            nombreColumnas.Add(dr.GetName(i));
                        }
                    }

                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public List<string> getAtrributes(string table, ref List<string> nombreColumnas)
        {

            nombreColumnas = new List<string>();

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(string.Format("SELECT c.Name FROM sys.columns c JOIN sys.objects o ON o.object_id = c.object_id WHERE o.type = 'U' AND o.name = '{0}' ORDER BY c.Name", table));
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;

                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        nombreColumnas.Add(dr[i].ToString());
                    }
                }
                dr.Close();

                return nombreColumnas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

        public List<string> getAttributesCommon(ref List<string> nombreColumnas1, ref List<string> nombreColumnas2, ref List<string> nombreComlumnasCompartidas)
        {
            foreach (var valor in nombreColumnas1)
            {
                foreach (var comparador in nombreColumnas2)
                {
                    if (valor == comparador)
                    {
                        nombreComlumnasCompartidas.Add(valor);
                    }
                }
            }
            return nombreComlumnasCompartidas;
        }

        public string getString(ref List<string> sameAttributes)
        {
            List<string> columns = null;
            columns = sameAttributes;

            string command = "";
            for (int i = 0; i < columns.Count; i++)
            {
                if (i == columns.Count - 1)
                    command += "convert(varchar(max)," + columns[i].ToString() + ")";
                else
                {
                    command += "convert(varchar(max)," + columns[i].ToString() + ")" + " + '**@**' + ";
                }
            }
            return command;
        }

        public string getParameters(ref List<string> sameAttributes, string table1, string table2)
        {
            List<string> columns = null;
            columns = sameAttributes;

            string command = "";
            for (int i = 0; i < columns.Count; i++)
            {
                if (i == columns.Count - 1)
                    command += table1 + "." + columns[i].ToString() + " = " + table2 + "." + columns[i].ToString();
                else
                {
                    command += table1 + "." + columns[i].ToString() + " = " + table2 + "." + columns[i].ToString() + "AND";
                }
            }
            return command;
        }

        public List<Dictionary<int, object>> ExecuteTablesDatesDB(ref List<string> nombreColumnas, List<string> tables)
        {

            List<Dictionary<int, object>> resultado = new List<Dictionary<int, object>>();
            nombreColumnas = new List<string>();
            List<string> tablesInformation = null;
            tablesInformation = tables;
            string tablesToShow = "";

            if (tablesInformation.Count == 1)
            {
                tablesToShow = tablesInformation[0].ToString();
            }
            else
            {
                for (int i = 0; i < tablesInformation.Count; i++)
                {
                    if (i == tablesInformation.Count - 1)
                    {
                        tablesToShow += "'" + tablesInformation[i].ToString();
                    }
                    else
                    {
                        if (i == 0)
                        {
                            tablesToShow += tablesInformation[i].ToString() + "'" + ",";
                        }
                        else
                        {
                            tablesToShow += "'" + tablesInformation[i].ToString() + "'" + ",";
                        }
                    }
                }
            }

            SqlConnection cn = new SqlConnection(ConnectionString);
            try
            {
                cn.Open();
                SqlCommand cm = new SqlCommand(String.Format("SELECT Object_name(c.object_id) AS Tabla, c.NAME 'Columna', t.NAME 'Tipo', CASE  WHEN c.max_length = 0 THEN '' ELSE c.max_length END AS Largo, CASE WHEN c.is_nullable = 0 THEN 'No' ELSE 'Si' END AS PermiteNulo, CASE WHEN Isnull(i.is_primary_key, 0) = 0 THEN 'No' ELSE 'Si' END AS 'LlavePrimaria', CASE WHEN Isnull(fk.[table], '') = '' THEN 'No' ELSE 'Si' END AS LlaveForanea, Isnull(fk.referenced_table, '') AS TablaReferenciada, Isnull(fk.referenced_column, '') AS ColumnaReferenciada FROM sys.columns c INNER JOIN sys.tables tbl ON c.object_id = tbl.object_id INNER JOIN sys.types t ON c.user_type_id = t.user_type_id LEFT OUTER JOIN sys.index_columns ic ON ic.object_id = c.object_id AND ic.column_id = c.column_id LEFT OUTER JOIN sys.indexes i ON ic.object_id = i.object_id AND ic.index_id = i.index_id LEFT OUTER JOIN(SELECT obj.NAME  AS FK_NAME, sch.NAME  AS[schema_name], tab1.NAME AS[table], col1.NAME AS[column], tab2.NAME AS[referenced_table], col2.NAME AS[referenced_column] FROM   sys.foreign_key_columns fkc INNER JOIN sys.objects obj ON obj.object_id = fkc.constraint_object_id INNER JOIN sys.tables tab1 ON tab1.object_id = fkc.parent_object_id INNER JOIN sys.schemas sch ON tab1.schema_id = sch.schema_id INNER JOIN sys.columns col1 ON col1.column_id = parent_column_id AND col1.object_id = tab1.object_id INNER JOIN sys.tables tab2 ON tab2.object_id = fkc.referenced_object_id INNER JOIN sys.columns col2 ON col2.column_id = referenced_column_id AND col2.object_id = tab2.object_id) fk ON Schema_name(tbl.schema_id) = fk.schema_name AND Object_name(c.object_id) = fk.[table] AND c.NAME = fk.[column] where Object_name(c.object_id) not in ('{0}') order by Tabla, c.column_id", tablesToShow));
                cm.CommandType = System.Data.CommandType.Text;
                cm.Connection = cn;
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    if (nombreColumnas.Count == 0)
                    {
                        for (int i = 0; i < dr.FieldCount; i++)
                        {
                            nombreColumnas.Add(dr.GetName(i));
                        }
                    }

                    Dictionary<int, object> fila = new Dictionary<int, object>();

                    for (int i = 0; i < dr.FieldCount; i++)
                    {
                        fila.Add(i, dr[i]);
                    }

                    resultado.Add(fila);
                }
                dr.Close();

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == System.Data.ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }

    }
}
