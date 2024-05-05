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

namespace problema3
{
    public partial class Form1 : Form
    {

        // Declaración de objetos para conexión y adaptador de datos
        SqlConnection con = new SqlConnection();
        SqlDataAdapter ada = new SqlDataAdapter();
        DataSet ds = new DataSet();


        public Form1()
        {
            InitializeComponent();


            //Conectar a la base de datos:

            panel1.Enabled = true;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = false;
            panel4.Visible = false;



            comboBoxDepartamento.Items.Clear();
            comboBoxgenero.Items.Clear();
            comboBoxRol.Items.Clear();


            comboBoxDepartamento.Items.AddRange(LlenarComboBoxDepartamentos());
            comboBoxgenero.Items.AddRange(cargarGenero());
            comboBoxRol.Items.AddRange(cargarRol());


            comboBoxDEpartamento2.Items.Clear();
            comboBoxGenero2.Items.Clear();
            comboBoxRol2.Items.Clear();


            comboBoxDEpartamento2.Items.AddRange(LlenarComboBoxDepartamentos());
            comboBoxGenero2.Items.AddRange(cargarGenero());
            comboBoxRol2.Items.AddRange(cargarRol());


            // Configura la conexión a la base de datos
            con.ConnectionString = "server=(local);user=sa;pwd=12345678;database=DBLuis";
            ada.SelectCommand = new SqlCommand("SELECT * FROM persona", con);


        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ada.SelectCommand.CommandText = "Select * from persona";
            ada.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void listar_btn_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
            panel1.Enabled = true;
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;
            ada.SelectCommand.CommandText = "Select * from persona";
            ada.Fill(ds);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = ds.Tables[0];

            panel2.Enabled = false;
            panel2.Visible = false;

            panel3.Enabled = false;
            panel3.Visible = false;

            panel4.Enabled = false;
            panel4.Visible = false;

        }
        private void alta_btn_Click(object sender, EventArgs e)
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

        }

        private void button_enviar_alta_Click(object sender, EventArgs e)
        {
            // Valida los datos antes de agregar
            if (!ValidarDatosAgregar())
                return;

            // Convierte la fecha de nacimiento a un formato adecuado para la base de datos
            DateTime fechaNacimientoDateTime;
            if (!DateTime.TryParse(textBoxFecha_nac.Text, out fechaNacimientoDateTime))
            {
                MessageBox.Show("Por favor, ingrese una fecha de nacimiento válida.");
                return;
            }
            string fechaNacimiento = fechaNacimientoDateTime.ToString("yyyy-MM-dd");

            // Obtiene los valores de las variables locales
            string ci = textBoxCI.Text;
            string nombres = textBoxNombres.Text;
            string paterno = TextBoxPaterno.Text;
            string materno = textBoxMaterno.Text;
            string genero = comboBoxgenero.SelectedItem.ToString();
            string direccion = textBoxDireccion_dom.Text;
            string telefono = textBoxTelefono.Text;
            string celular = textBoxCelular.Text;
            string correo = textBoxCorreo.Text;
            string password = textBoxPassword.Text;
            string rol = comboBoxRol.SelectedItem.ToString();
            string departamento = comboBoxDepartamento.SelectedItem.ToString();



            // Abre la conexión a la base de datos
            con.Open();


            // Prepara la consulta SQL para insertar datos
            string insertQuery = "INSERT INTO persona (ci, nombres, paterno, materno, fecha_nac, genero, direccion_dom, telefono, celular, correo, password, rol, departamento) VALUES (@ci, @nombres, @paterno, @materno, @fecha_nac, @genero, @direccion_dom, @telefono, @celular, @correo, @password, @rol, @departamento)";
            SqlCommand comando = new SqlCommand(insertQuery, con);
            comando.Parameters.AddWithValue("@ci", ci);
            comando.Parameters.AddWithValue("@nombres", nombres);
            comando.Parameters.AddWithValue("@paterno", paterno);
            comando.Parameters.AddWithValue("@materno", materno);
            comando.Parameters.AddWithValue("@fecha_nac", fechaNacimiento);
            int gen = 0;
            if (genero.Equals("Masculino")) {
                gen = 1;
            }
            comando.Parameters.AddWithValue("@genero", gen);
            comando.Parameters.AddWithValue("@direccion_dom", direccion);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@correo", correo);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@rol", rol);
            comando.Parameters.AddWithValue("@departamento", departamento);

            // Ejecuta la consulta para agregar datos
            comando.ExecuteNonQuery();

            // Cierra la conexión a la base de datos
            con.Close();

            MessageBox.Show("Datos agregados correctamente.");

        }
        private bool ValidarDatosAgregar()
        {
            // Validación básica para campos obligatorios
            if (string.IsNullOrEmpty(textBoxCI.Text) || string.IsNullOrEmpty(textBoxNombres.Text) || string.IsNullOrEmpty(TextBoxPaterno.Text) || string.IsNullOrEmpty(textBoxMaterno.Text) || string.IsNullOrEmpty(textBoxFecha_nac.Text) || comboBoxgenero.SelectedItem == null || string.IsNullOrEmpty(textBoxDireccion_dom.Text) || string.IsNullOrEmpty(textBoxTelefono.Text) || string.IsNullOrEmpty(textBoxCelular.Text) || string.IsNullOrEmpty(textBoxCorreo.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || comboBoxRol.SelectedItem == null || comboBoxDepartamento.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos antes de agregar.");
                return false;
            }


            return true;
        }


        private void baja_btn_Click(object sender, EventArgs e)
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


            llenar_comboBox_elimnar();
            comboBoxCi_elimnar.SelectedIndex = 0;

        }
        public void llenar_comboBox_elimnar() {
            // Crea una consulta SQL para seleccionar solo la columna "ci" de la tabla "persona"
            string selectQuery = "SELECT ci FROM persona";

            // Crea un SqlCommand con la consulta SELECT y la conexión
            SqlCommand comando = new SqlCommand(selectQuery, con);

            // Abre la conexión a la base de datos
            con.Open();

            // Crea un SqlDataReader para leer los resultados de la consulta
            SqlDataReader lector = comando.ExecuteReader();

            // Limpia el ComboBox para asegurarse de que esté vacío antes de agregar nuevos elementos
            comboBoxCi_elimnar.Items.Clear();

            // Itera sobre los resultados del SqlDataReader y agrega cada valor al ComboBox
            while (lector.Read())
            {
                // Agrega el valor de la columna "ci" al ComboBox
                comboBoxCi_elimnar.Items.Add(lector["ci"]);
            }

            // Cierra el SqlDataReader
            lector.Close();

            // Cierra la conexión a la base de datos
            con.Close();
        }

        private void comboBoxCi_elimnar_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Verifica si se ha seleccionado un ítem en el ComboBox
            if (comboBoxCi_elimnar.SelectedIndex != -1)
            {
                // Obtiene el valor seleccionado en el ComboBox
                string ciSeleccionado = comboBoxCi_elimnar.SelectedItem.ToString();

                // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                string selectQuery = "SELECT * FROM persona WHERE ci = @ci";

                // Crea un SqlCommand con la consulta SELECT y la conexión
                SqlCommand comando = new SqlCommand(selectQuery, con);

                // Agrega el parámetro para la CI seleccionada
                comando.Parameters.AddWithValue("@ci", ciSeleccionado);

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

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un ítem en el ComboBox
            if (comboBoxCi_elimnar.SelectedIndex != -1)
            {
                // Obtiene el valor seleccionado en el ComboBox
                string ciSeleccionado = comboBoxCi_elimnar.SelectedItem.ToString();

                // Pregunta al usuario para confirmar si realmente quiere eliminar el registro
                DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar el registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirma la eliminación
                if (resultado == DialogResult.Yes)
                {
                    // Crea una consulta SQL para eliminar el registro de la persona con la CI seleccionada
                    string deleteQuery = "DELETE FROM persona WHERE ci = @ci";

                    // Crea un SqlCommand con la consulta DELETE y la conexión
                    SqlCommand comando = new SqlCommand(deleteQuery, con);

                    // Agrega el parámetro para la CI seleccionada
                    comando.Parameters.AddWithValue("@ci", ciSeleccionado);

                    try
                    {
                        // Abre la conexión a la base de datos
                        con.Open();

                        // Ejecuta la consulta SQL para eliminar el registro
                        comando.ExecuteNonQuery();

                        MessageBox.Show("El registro se eliminó correctamente.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        listar_btn.PerformClick();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        // Cierra la conexión a la base de datos
                        con.Close();
                    }
                }
            }

        }

        private void cambio_btn_Click(object sender, EventArgs e)
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

            llenar_comboBox_CI();

        }



        private void comboBoxCI_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCI_Selector.SelectedIndex != -1)
            {
                // Obtener la CI seleccionada
                string ciSeleccionada = comboBoxCI_Selector.SelectedItem.ToString();
                List<string> persona = obtener_datos_persona(ciSeleccionada);
                textBoxNombres2.Text = persona[1];
                textBoxPaterno2.Text = persona[2];
                textBoxMaterno2.Text = persona[3];
                textBoxFecha_nac2.Text = convertirFecha(persona[4]);
                int genero = persona[5] == "0" ? 2 : 1;

                comboBoxGenero2.SelectedIndex = genero;
                textBoxDireccion_com2.Text = persona[6];
                textBoxTelefono2.Text = persona[7];
                textBoxCelular2.Text = persona[8];
                textBoxCorreo2.Text = persona[9];
                comboBoxDEpartamento2.SelectedItem = persona[12];
                comboBoxRol2.SelectedItem = persona[11];
                textBoxPassword2.Text = persona[10];


            }
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            // Verifica si se ha seleccionado un ítem en el ComboBox
            if (comboBoxCI_Selector.SelectedIndex != -1)
            {
                // Obtener la CI seleccionada
                string ciSeleccionada = comboBoxCI_Selector.SelectedItem.ToString();



                // Construir la consulta SQL para actualizar los datos en la base de datos
                string updateQuery = @"
                    UPDATE persona 
                    SET 
                        nombres = @nuevosNombres, 
                        paterno = @nuevoPaterno, 
                        materno = @nuevoMaterno, 
                        fecha_nac = @nuevaFechaNacimiento, 
                        genero = @nuevoGenero, 
                        direccion_dom = @nuevaDireccion, 
                        telefono = @nuevoTelefono, 
                        celular = @nuevoCelular, 
                        correo = @nuevoCorreo, 
                        password = @nuevoPassword, 
                        rol = @nuevoRol, 
                        departamento = @nuevoDepartamento 
                    WHERE ci = @ci";


                // Crea un SqlCommand con la consulta DELETE y la conexión
                SqlCommand comando = new SqlCommand(updateQuery, con);

                // Agrega el parámetro para la CI seleccionada

                // Agregar parámetros para los nuevos valores y la CI seleccionada
                comando.Parameters.AddWithValue("@nuevosNombres", textBoxNombres2.Text);
                comando.Parameters.AddWithValue("@nuevoPaterno", textBoxPaterno2.Text);
                comando.Parameters.AddWithValue("@nuevoMaterno", textBoxMaterno2.Text);
                comando.Parameters.AddWithValue("@nuevaFechaNacimiento", textBoxFecha_nac2.Text);
                comando.Parameters.AddWithValue("@nuevoGenero", (comboBoxGenero2.SelectedItem.ToString()) == "Masculino" ? 1 : 0);
                comando.Parameters.AddWithValue("@nuevaDireccion", textBoxDireccion_com2.Text);
                comando.Parameters.AddWithValue("@nuevoTelefono", textBoxTelefono2.Text);
                comando.Parameters.AddWithValue("@nuevoCelular", textBoxCelular2.Text);
                comando.Parameters.AddWithValue("@nuevoCorreo", textBoxCorreo2.Text);
                comando.Parameters.AddWithValue("@nuevoPassword", textBoxPassword2.Text);
                comando.Parameters.AddWithValue("@nuevoRol", comboBoxRol2.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@nuevoDepartamento", comboBoxDEpartamento2.SelectedItem.ToString());
                comando.Parameters.AddWithValue("@ci", ciSeleccionada);

                try
                {
                    // Abre la conexión a la base de datos
                    con.Open();

                    // Ejecuta la consulta SQL para eliminar el registro
                    comando.ExecuteNonQuery();

                    MessageBox.Show("El registro se modifico correctamente.", "Modificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    listar_btn.PerformClick();

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
            comboBoxCI_Selector.Items.Clear();

            // Itera sobre los resultados del SqlDataReader y agrega cada valor al ComboBox
            while (lector.Read())
            {
                // Agrega el valor de la columna "ci" al ComboBox
                comboBoxCI_Selector.Items.Add(lector["ci"]);
            }

            // Cierra el SqlDataReader
            lector.Close();

            // Cierra la conexión a la base de datos
            con.Close();
        }


        private string[] LlenarComboBoxDepartamentos()
        {
            // Lista de nombres de departamentos de Bolivia
            string[] departamentosBolivia = { "Seleccion un departamento", "La Paz", "Cochabamba", "Santa Cruz", "Potosí", "Oruro", "Tarija", "Chuquisaca", "Beni", "Pando" };
            return departamentosBolivia;
        }
        private string[] cargarGenero()
        {
            string[] generos = { "Seleccione un genero", "Masculino", "Femenino" };
            return generos;
        }
        private string[] cargarRol()
        {
            string[] rol = { "Seleccione un rol", "gerente", "cliente", "cajero" };
            return rol;
        }
        private string convertirFecha(string fecha) {
            // Fecha original
            DateTime fechaOriginal = DateTime.Parse(fecha);

            // Formatear la fecha en el formato deseado (dd/MM/yyyy)
            string fechaFormateada = fechaOriginal.ToString("dd/MM/yyyy");

            return fechaFormateada;
        }
        private List<string> obtener_datos_persona(string ciSeleccionado)
        {
            // Crea una lista para contener los datos de la persona
            List<string> datosPersona = new List<string>();

            try
            {
                // Crea una consulta SQL para seleccionar el registro de la persona con la CI seleccionada
                string selectQuery = "SELECT * FROM persona WHERE ci = @ci";

                // Crea un SqlCommand con la consulta SELECT y la conexión
                using (SqlCommand comando = new SqlCommand(selectQuery, con))
                {
                    // Agrega el parámetro para la CI seleccionada
                    comando.Parameters.AddWithValue("@ci", ciSeleccionado);

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
                MessageBox.Show("Error al obtener datos de la persona: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return datosPersona;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cuentas_Click(object sender, EventArgs e)
        {
            Cuentas cuentasForm = new Cuentas(); // Crear una instancia del formulario Cuentas
            cuentasForm.ShowDialog(); // Mostrar el formulario Cuentas como un diálogo modal

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 transaccionForm = new Form3();
            transaccionForm.ShowDialog();
        }
    }
}
