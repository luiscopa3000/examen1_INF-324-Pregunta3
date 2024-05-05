using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace problema3
{
    public partial class Cuentas : Form
    {

        // Declaración de objetos para conexión y adaptador de datos
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public Cuentas()
        {
            InitializeComponent();
            // Configura la conexión a la base de datos
            con.ConnectionString = "server=(local);user=sa;pwd=12345678;database=DBLuis";
            ada.SelectCommand = new SqlCommand("SELECT * FROM persona", con);
            btn_listar.PerformClick();


            ada.SelectCommand.CommandText = "Select * from cuenta";
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

        private void btn_listar_Click(object sender, EventArgs e)
        {
            ada.SelectCommand.CommandText = "Select * from cuenta";
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
            
            llenar_comboBox_CI();

            panel1.Enabled = false;
            panel1.Visible = false;

            panel2.Enabled = true;
            panel2.Visible = true;
            panel2.Dock = DockStyle.Fill;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = false;
            panel4.Visible = false;

        }

        private void agregar_cuenta_Click(object sender, EventArgs e)
        {
            if (comboBoxCI.SelectedIndex != -1)
            {
                try
                {
                    if (VerificarInputs())
                    {
                        // Asignar los valores de los TextBox a las variables
                        string nro_cuenta = textBoxNro_cuenta.Text;
                        string tipo = textBoxTipo.Text;
                        decimal saldo = decimal.Parse(textBoxSaldo.Text); // Convertir a decimal
                        DateTime fecha_exp = DateTime.ParseExact(textBoxFecha_exp.Text, "dd/MM/yyyy", null); // Convertir a DateTime
                        string status = textBoxStatus.Text;
                        string ci = comboBoxCI.SelectedItem.ToString();

                        // Abre la conexión a la base de datos
                        con.Open();

                        // Prepara la consulta SQL para insertar datos
                        string insertQuery = "INSERT INTO cuenta ( nro_cuenta, tipo, saldo, fecha_exp, ci, status) VALUES ( @nro_cuenta, @tipo, @saldo, @fecha_exp, @ci, @status)";

                        SqlCommand comando = new SqlCommand(insertQuery, con);
                        comando.Parameters.AddWithValue("@nro_cuenta", nro_cuenta);
                        comando.Parameters.AddWithValue("@tipo", tipo);
                        comando.Parameters.AddWithValue("@saldo", saldo);
                        comando.Parameters.AddWithValue("@fecha_exp", fecha_exp);
                        comando.Parameters.AddWithValue("@ci", ci);
                        comando.Parameters.AddWithValue("@status", status);

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
                MessageBox.Show("Seleccione un CI");
            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            llenar_comboBox_Nro_cuenta();

            panel1.Enabled = false;
            panel1.Visible = false;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = true;
            panel3.Visible = true;
            panel3.Dock = DockStyle.Fill;

            panel4.Enabled = false;
            panel4.Visible = false;

        }
        private void comboBoxNro_cuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNro_cuenta.SelectedIndex != -1) {
                string nro_cuenta = comboBoxNro_cuenta.SelectedItem.ToString();


                // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                string selectQuery = "SELECT * FROM cuenta WHERE nro_cuenta = @nro_cuenta";

                // Crea un SqlCommand con la consulta SELECT y la conexión
                SqlCommand comando = new SqlCommand(selectQuery, con);

                // Agrega el parámetro para la CI seleccionada
                comando.Parameters.AddWithValue("@nro_cuenta", nro_cuenta);

                // Crea un SqlDataAdapter para ejecutar la consulta y llenar un DataTable con los resultados
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                // Crea un DataTable para contener los datos de la persona seleccionada
                DataTable datosPersona = new DataTable();

                // Llena el DataTable con los datos de la persona seleccionada utilizando el SqlDataAdapter
                adaptador.Fill(datosPersona);

                // Asigna el DataTable como DataSource del DataGridView para mostrar los datos en la interfaz de usuario
                dataGridView2.DataSource = datosPersona;
            }

        }

        private void eliminar_cuenta_Click(object sender, EventArgs e)
        {
            if (comboBoxNro_cuenta.SelectedIndex != -1)
            {
                string nro_cuenta = comboBoxNro_cuenta.SelectedItem.ToString();


                // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                string selectQuery = "DELETE FROM cuenta WHERE nro_cuenta = @nro_cuenta";

                // Crea un SqlCommand con la consulta SELECT y la conexión
                SqlCommand comando = new SqlCommand(selectQuery, con);

                // Agrega el parámetro para la CI seleccionada
                comando.Parameters.AddWithValue("@nro_cuenta", nro_cuenta);

                // Crea un SqlDataAdapter para ejecutar la consulta y llenar un DataTable con los resultados
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                // Crea un DataTable para contener los datos de la persona seleccionada
                DataTable datosPersona = new DataTable();

                // Llena el DataTable con los datos de la persona seleccionada utilizando el SqlDataAdapter
                adaptador.Fill(datosPersona);



                MessageBox.Show("El registro se eliminó correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_listar.PerformClick();

            }
        }


        private void btn_editar_Click(object sender, EventArgs e)
        {

            llenar_comboBox_CI();
            llenar_comboBox_Nro_cuenta();

            panel1.Enabled = false;
            panel1.Visible = false;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = true;
            panel4.Visible = true;
            panel4.Dock = DockStyle.Fill;


        }
        private void comboBoxNro_cuenta2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNro_cuenta2.SelectedIndex != -1)
            {
                string nro_cuenta_s = comboBoxNro_cuenta2.SelectedItem.ToString();
                List<string> cuenta = obtener_datos_cuenta(nro_cuenta_s);
                textBoxTipo2.Text = cuenta[1];
                textBoxSaldo2.Text = cuenta[2];
                comboBoxCI2.SelectedItem = cuenta[4];
                textBoxFecha2.Text = cuenta[3];
                textBoxStatus2.Text = cuenta[5];
            }
            else {
                MessageBox.Show("Seleccione una cuenta");
            }
        }

        private void Editar_enviar_Click(object sender, EventArgs e)
        {
            if (comboBoxNro_cuenta2.SelectedIndex != -1)
            {
                // Obtener la CI seleccionada
                string nro_cuenta_s = comboBoxNro_cuenta2.SelectedItem.ToString();



                // Construir la consulta SQL para actualizar los datos en la base de datos
                string updateQuery = @"
                    UPDATE cuenta 
                    SET 
                        tipo = @tipo, 
                        saldo = @saldo, 
                        fecha_exp = @fecha_exp, 
                        ci = @ci, 
                        status = @status
                    WHERE nro_cuenta = @nro_cuenta";


                // Crea un SqlCommand con la consulta DELETE y la conexión
                SqlCommand comando = new SqlCommand(updateQuery, con);

                // Agrega el parámetro para la CI seleccionada

                // Agregar parámetros para los nuevos valores y la CI seleccionada
                comando.Parameters.AddWithValue("@tipo", textBoxTipo2.Text);
                comando.Parameters.AddWithValue("@saldo", Convert.ToDecimal(textBoxSaldo2.Text));
                comando.Parameters.AddWithValue("@fecha_exp", convertirFecha(textBoxFecha2.Text));
                comando.Parameters.AddWithValue("@ci", comboBoxCI2.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@status", textBoxStatus2.Text);
                comando.Parameters.AddWithValue("@nro_cuenta", comboBoxNro_cuenta2.SelectedItem.ToString());

                try
                {
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



        public void llenar_comboBox_CI()
        {
            // Crea una consulta SQL para seleccionar solo la columna "ci" de la tabla "persona"
            string selectQuery = "SELECT ci FROM persona";

            // Crea un SqlCommand con la consulta SELECT y la conexión
            SqlCommand comando = new SqlCommand(selectQuery, con);

            // Abre la conexión a la base de datos
            con.Open();

            // Crea un SqlDataReader para leer los resultados de la consulta
            SqlDataReader lector = comando.ExecuteReader();

            // Limpia el ComboBox para asegurarse de que esté vacío antes de agregar nuevos elementos
            comboBoxCI.Items.Clear();
            comboBoxCI2.Items.Clear();

            // Itera sobre los resultados del SqlDataReader y agrega cada valor al ComboBox
            while (lector.Read())
            {
                // Agrega el valor de la columna "ci" al ComboBox
                comboBoxCI.Items.Add(lector["ci"]);
                comboBoxCI2.Items.Add(lector["ci"]);
            }

            // Cierra el SqlDataReader
            lector.Close();

            // Cierra la conexión a la base de datos
            con.Close();
        }
        public void llenar_comboBox_Nro_cuenta()
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
            comboBoxNro_cuenta2.Items.Clear();

            // Itera sobre los resultados del SqlDataReader y agrega cada valor al ComboBox
            while (lector.Read())
            {
                // Agrega el valor de la columna "ci" al ComboBox
                comboBoxNro_cuenta.Items.Add(lector["nro_cuenta"]);
                comboBoxNro_cuenta2.Items.Add(lector["nro_cuenta"]);
            }

            // Cierra el SqlDataReader
            lector.Close();

            // Cierra la conexión a la base de datos
            con.Close();
        }
        public bool VerificarInputs()
        {
            // Verificar si los TextBox están llenos
            if (string.IsNullOrWhiteSpace(textBoxNro_cuenta.Text) ||
                string.IsNullOrWhiteSpace(textBoxTipo.Text) ||
                string.IsNullOrWhiteSpace(textBoxSaldo.Text) ||
                string.IsNullOrWhiteSpace(textBoxFecha_exp.Text) ||
                string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                MessageBox.Show("Todos los campos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar si la fecha tiene el formato adecuado (dd/mm/aaaa)
            if (!EsFechaValida(textBoxFecha_exp.Text))
            {
                MessageBox.Show("La fecha debe estar en el formato dd/mm/aaaa.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Si todos los campos están llenos y la fecha tiene el formato adecuado, retornar true
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
        private string convertirFecha(string fecha)
        {
            // Fecha original
            DateTime fechaOriginal = DateTime.Parse(fecha);

            // Formatear la fecha en el formato deseado (dd/MM/yyyy)
            string fechaFormateada = fechaOriginal.ToString("dd/MM/yyyy");

            return fechaFormateada;
        }
        private List<string> obtener_datos_cuenta(string nro_cuenta_s)
        {
            // Crea una lista para contener los datos de la persona
            List<string> datosPersona = new List<string>();

            try
            {
                // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                string selectQuery = "SELECT * FROM cuenta WHERE nro_cuenta = @nro_cuenta";

                // Crea un SqlCommand con la consulta SELECT y la conexión
                using (SqlCommand comando = new SqlCommand(selectQuery, con))
                {
                    // Agrega el parámetro para la CI seleccionada
                    comando.Parameters.AddWithValue("@nro_cuenta", nro_cuenta_s);

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
                                datosPersona.Add(tablaPersona.Rows[0][columna].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener datos de la cuenta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return datosPersona;
        }
    }
}
