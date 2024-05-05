using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace problema3
{
    public partial class Form3 : Form
    {

        // Declaración de objetos para conexión y adaptador de datos
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Form3()
        {
            InitializeComponent();
            // Configura la conexión a la base de datos
            con.ConnectionString = "server=(local);user=sa;pwd=12345678;database=DBLuis";

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            ada.SelectCommand = new SqlCommand("SELECT * FROM transaccion", con);


            panel1.Enabled = true;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = false;
            panel4.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Vaciar el DataGridView eliminando todas las filas
            dataGridView1.Rows.Clear();

            // Limpiar las columnas del DataGridView
            dataGridView1.Columns.Clear();

            // Restablecer cualquier otra configuración necesaria, como la selección de celdas
            dataGridView1.ClearSelection();

            ada.SelectCommand.CommandText = "Select * from transaccion";
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];



            panel1.Enabled = true;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = false;
            panel4.Visible = false;

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;

            panel2.Enabled = true;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = false;
            panel4.Visible = false;

            llenar_comboBox_nro_cta();

        }

        private void comboBoxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNro_cuenta.SelectedIndex != -1) {

            }

        }

        private void comboBoxNro_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void enviar_agrega_Click(object sender, EventArgs e)
        {
            if (comboBoxNro_cuenta.SelectedIndex != -1 && comboBoxDestino.SelectedIndex != -1)
            {
                string nro_tr = textBoxNro_transaccion.Text;
                string fecha = textBoxFecha.Text;
                string transaccion = textBoxTransaccion.Text;
                decimal monto = Convert.ToDecimal(textBoxMonto.Text);
                string descripcion = textBoxDescripcion.Text;
                string destino = comboBoxDestino.Text;
                string nro_cuenta = comboBoxNro_cuenta.Text;

                try
                {
                    if (VerificarInputs())
                    {
                        // Abre la conexión a la base de datos
                        con.Open();

                        // Prepara la consulta SQL para insertar datos
                        string insertQuery = "INSERT INTO transaccion ( fecha, tipo_tr, monto, descripcion, destino, nro_cuenta) VALUES ( @fecha, @tipo_tr, @monto, @descripcion, @destino, @nro_cuenta)";

                        SqlCommand comando = new SqlCommand(insertQuery, con);
                        comando.Parameters.Add("@fecha", SqlDbType.DateTime).Value = DateTime.ParseExact(fecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        comando.Parameters.AddWithValue("@tipo_tr", transaccion);
                        comando.Parameters.AddWithValue("@monto", monto);
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@destino", destino);
                        comando.Parameters.AddWithValue("@nro_cuenta", nro_cuenta);



                        // Ejecuta la consulta para agregar datos
                        comando.ExecuteNonQuery();

                        // Cierra la conexión a la base de datos
                        con.Close();

                        MessageBox.Show("Datos agregados correctamente.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            else
            {
                MessageBox.Show("Seleccione un nro de cuenta");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = true;
            panel3.Visible = true;
            panel3.Dock = DockStyle.Fill;

            panel4.Enabled = false;
            panel4.Visible = false;

            llenar_comboBox_nro_tr();


        }

        private void comboBoxNro_tr_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNro_tr.SelectedIndex != -1) {
                string nro_transaccion_s = comboBoxNro_tr.SelectedItem.ToString();

                try
                {

                    // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                    string selectQuery = "SELECT * FROM transaccion WHERE nro_tr = @nro_tr";

                    // Crea un SqlCommand con la consulta SELECT y la conexión
                    SqlCommand comando = new SqlCommand(selectQuery, con);

                    // Agrega el parámetro para la CI seleccionada
                    comando.Parameters.AddWithValue("@nro_tr", nro_transaccion_s);

                    // Crea un SqlDataAdapter para ejecutar la consulta y llenar un DataTable con los resultados
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    // Crea un DataTable para contener los datos de la persona seleccionada
                    DataTable datosPersona = new DataTable();

                    // Llena el DataTable con los datos de la persona seleccionada utilizando el SqlDataAdapter
                    adaptador.Fill(datosPersona);

                    // Asigna el DataTable como DataSource del DataGridView para mostrar los datos en la interfaz de usuario
                    dataGridView2.DataSource = datosPersona;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
        private void eliminar_transaccion_Click(object sender, EventArgs e)
        {
            if (comboBoxNro_tr.SelectedIndex != -1)
            {
                string nro_transaccion_s = comboBoxNro_tr.SelectedItem.ToString();

                try
                {

                    // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                    string selectQuery = "DELETE FROM transaccion WHERE nro_tr = @nro_tr";

                    // Crea un SqlCommand con la consulta SELECT y la conexión
                    SqlCommand comando = new SqlCommand(selectQuery, con);

                    // Agrega el parámetro para la CI seleccionada
                    comando.Parameters.AddWithValue("@nro_tr", nro_transaccion_s);

                    // Crea un SqlDataAdapter para ejecutar la consulta y llenar un DataTable con los resultados
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                    // Crea un DataTable para contener los datos de la persona seleccionada
                    DataTable datosPersona = new DataTable();

                    // Llena el DataTable con los datos de la persona seleccionada utilizando el SqlDataAdapter
                    adaptador.Fill(datosPersona);

                    // Asigna el DataTable como DataSource del DataGridView para mostrar los datos en la interfaz de usuario
                    dataGridView2.DataSource = datosPersona;


                    MessageBox.Show("El registro se eliminó correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }


        }


        private void btn_editar_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Visible = false;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = true;
            panel4.Visible = true;
            panel4.Dock = DockStyle.Fill;
            textBoxFecha2.ReadOnly = true;


            llenar_comboBox_nro_tr();
            llenar_comboBox_nro_cta();
        }

        private void comboBoxNro_tr2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNro_tr2.SelectedIndex != -1)
            {
                try
                {
                    string nro_tr = comboBoxNro_tr2.SelectedItem.ToString();
                    List<string> datos = obtener_datos_transaccion(nro_tr);
                    textBoxFecha2.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    textBoxTransaccion2.Text = datos[2];
                    textBoxMonto2.Text = datos[3];
                    textBoxDescripcion2.Text = datos[4];
                    comboBoxNro_cuenta2.SelectedItem = datos[6];
                    comboBoxDestino2.SelectedItem = datos[5];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        private void enviar_editar_Click(object sender, EventArgs e)
        {

            if (comboBoxNro_tr2.SelectedIndex != -1)
            {

                try
                {

                    // Obtener la CI seleccionada
                    string nro_tr_s = comboBoxNro_tr2.SelectedItem.ToString();



                    // Construir la consulta SQL para actualizar los datos en la base de datos
                    string updateQuery = @"
                    UPDATE transaccion 
                    SET 
                        fecha = @fecha, 
                        tipo_tr = @tipo_tr, 
                        monto = @monto, 
                        descripcion = @descripcion, 
                        destino = @destino,
                        nro_cuenta = @nro_cuenta
                    WHERE nro_tr = @nro_tr";


                    SqlCommand comando = new SqlCommand(updateQuery, con);

                    comando.Parameters.AddWithValue("@fecha", DateTime.Now);
                    comando.Parameters.AddWithValue("@tipo_tr", textBoxTransaccion2.Text);
                    comando.Parameters.AddWithValue("@monto", Convert.ToDecimal(textBoxMonto2.Text));
                    comando.Parameters.AddWithValue("@descripcion", textBoxDescripcion2.Text);
                    comando.Parameters.AddWithValue("@destino", comboBoxDestino2.SelectedItem);
                    comando.Parameters.AddWithValue("@nro_cuenta", comboBoxNro_cuenta2.SelectedItem);
                    comando.Parameters.AddWithValue("@nro_tr", nro_tr_s);


                    // Abre la conexión a la base de datos
                    con.Open();

                    // Ejecuta la consulta SQL para eliminar el registro
                    comando.ExecuteNonQuery();

                    MessageBox.Show("El registro se modifico correctamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al modificar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cierra la conexión a la base de datos
                    con.Close();
                }
            }
        }


        public void llenar_comboBox_nro_cta()
        {
            // Crea una consulta SQL para seleccionar solo la columna "ci" de la tabla "persona"
            string selectQuery = "SELECT nro_cuenta FROM cuenta";

            // Crea un SqlCommand con la consulta SELECT y la conexión
            SqlCommand comando = new SqlCommand(selectQuery, con);

            // Abre la conexión a la base de datos
            con.Open();

            // Crea un SqlDataReader para leer los resultados de la consulta
            SqlDataReader lector = comando.ExecuteReader();

            // Limpia el ComboBox para asegurarse de que esté vacío antes de agregar nuevos elementos
            comboBoxNro_cuenta.Items.Clear();
            comboBoxDestino.Items.Clear();

            comboBoxNro_cuenta2.Items.Clear();
            comboBoxDestino2.Items.Clear();
            //comboBoxCI2.Items.Clear();

            // Itera sobre los resultados del SqlDataReader y agrega cada valor al ComboBox
            while (lector.Read())
            {
                // Agrega el valor de la columna "ci" al ComboBox
                comboBoxNro_cuenta.Items.Add(lector["nro_cuenta"]);
                comboBoxDestino.Items.Add(lector["nro_cuenta"]);

                comboBoxDestino2.Items.Add(lector["nro_cuenta"]);
                comboBoxNro_cuenta2.Items.Add(lector["nro_cuenta"]);

            }

            // Cierra el SqlDataReader
            lector.Close();

            // Cierra la conexión a la base de datos
            con.Close();
        }

        public bool VerificarInputs()
        {
            // Verificar si los TextBox y ComboBox están llenos
            if (string.IsNullOrWhiteSpace(textBoxNro_transaccion.Text) ||
                string.IsNullOrWhiteSpace(textBoxFecha.Text) ||
                string.IsNullOrWhiteSpace(textBoxTransaccion.Text) ||
                string.IsNullOrWhiteSpace(textBoxMonto.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescripcion.Text) ||
                string.IsNullOrWhiteSpace(comboBoxDestino.Text) ||
                string.IsNullOrWhiteSpace(comboBoxNro_cuenta.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si el monto tiene un formato válido (decimal)
            if (!decimal.TryParse(textBoxMonto.Text, out _))
            {
                MessageBox.Show("El monto debe ser un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si la fecha tiene el formato adecuado (dd/mm/aaaa)
            if (!EsFechaValida(textBoxFecha.Text))
            {
                MessageBox.Show("La fecha debe estar en el formato dd/mm/aaaa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todos los campos están llenos y el monto tiene un formato válido, retornar true
            return true;
        }

        private bool EsFechaValida(string fecha)
        {
            // Intentar convertir la cadena a un objeto DateTime con el formato dd/mm/aaaa
            if (DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out _))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void llenar_comboBox_nro_tr()
        {
            // Crea una consulta SQL para seleccionar solo la columna "ci" de la tabla "persona"
            string selectQuery = "SELECT nro_tr FROM transaccion";

            // Crea un SqlCommand con la consulta SELECT y la conexión
            SqlCommand comando = new SqlCommand(selectQuery, con);

            // Abre la conexión a la base de datos
            con.Open();

            // Crea un SqlDataReader para leer los resultados de la consulta
            SqlDataReader lector = comando.ExecuteReader();

            // Limpia el ComboBox para asegurarse de que esté vacío antes de agregar nuevos elementos
            comboBoxNro_tr.Items.Clear();
            comboBoxNro_tr2.Items.Clear();

            // Itera sobre los resultados del SqlDataReader y agrega cada valor al ComboBox
            while (lector.Read())
            {
                // Agrega el valor de la columna "ci" al ComboBox
                comboBoxNro_tr.Items.Add(lector["nro_tr"]);
                comboBoxNro_tr2.Items.Add(lector["nro_tr"]);
            }

            // Cierra el SqlDataReader
            lector.Close();

            // Cierra la conexión a la base de datos
            con.Close();
        }


        private List<string> obtener_datos_transaccion(string nro_tr_s)
        {
            // Crea una lista para contener los datos de la persona
            List<string> datosTRansaccion = new List<string>();

            try
            {
                // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                string selectQuery = "SELECT * FROM transaccion WHERE nro_tr = @nro_tr";

                // Crea un SqlCommand con la consulta SELECT y la conexión
                using (SqlCommand comando = new SqlCommand(selectQuery, con))
                {
                    // Agrega el parámetro para la CI seleccionada
                    comando.Parameters.AddWithValue("@nro_tr", nro_tr_s);

                    // Crea un SqlDataAdapter para ejecutar la consulta y llenar un DataTable con los resultados
                    using (SqlDataAdapter adaptador = new SqlDataAdapter(comando))
                    {
                        // Crea un DataTable para contener los datos de la persona seleccionada
                        DataTable tablaPersona = new DataTable();

                        // Llena el DataTable con los datos de la persona seleccionada utilizando el SqlDataAdapter
                        adaptador.Fill(tablaPersona);

                        // Verifica si se encontraron datos
                        if (tablaPersona.Rows.Count > 0)
                        {
                            // Itera sobre las columnas del primer registro y agrega los datos a la lista
                            foreach (DataColumn columna in tablaPersona.Rows[0].Table.Columns)
                            {
                                datosTRansaccion.Add(tablaPersona.Rows[0][columna].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de la cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return datosTRansaccion;
        }


    }
}
