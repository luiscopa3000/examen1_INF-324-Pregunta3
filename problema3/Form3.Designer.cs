namespace problema3
{
    partial class Form3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.navBar = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxNro_tr = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eliminar_transaccion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.enviar_agrega = new System.Windows.Forms.Button();
            this.textBoxNro_transaccion = new System.Windows.Forms.TextBox();
            this.textBoxFecha = new System.Windows.Forms.TextBox();
            this.textBoxTransaccion = new System.Windows.Forms.TextBox();
            this.textBoxMonto = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.comboBoxNro_cuenta = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.enviar_editar = new System.Windows.Forms.Button();
            this.textBoxFecha2 = new System.Windows.Forms.TextBox();
            this.textBoxTransaccion2 = new System.Windows.Forms.TextBox();
            this.textBoxMonto2 = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion2 = new System.Windows.Forms.TextBox();
            this.comboBoxNro_cuenta2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDestino2 = new System.Windows.Forms.ComboBox();
            this.comboBoxNro_tr2 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.navBar.SuspendLayout();
            this.panelPrincipal.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.navBar, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelPrincipal, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // navBar
            // 
            this.navBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navBar.Controls.Add(this.btn_editar);
            this.navBar.Controls.Add(this.btn_eliminar);
            this.navBar.Controls.Add(this.btn_agregar);
            this.navBar.Controls.Add(this.button1);
            this.navBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBar.Location = new System.Drawing.Point(3, 3);
            this.navBar.Name = "navBar";
            this.navBar.Size = new System.Drawing.Size(194, 444);
            this.navBar.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(9, 147);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(170, 40);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(9, 101);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(170, 40);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(9, 55);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(170, 40);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "LISTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.panel4);
            this.panelPrincipal.Controls.Add(this.panel3);
            this.panelPrincipal.Controls.Add(this.panel2);
            this.panelPrincipal.Controls.Add(this.panel1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(203, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(594, 444);
            this.panelPrincipal.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tableLayoutPanel4);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 129);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(594, 293);
            this.panel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "EDITAR TRANSACCIONES";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 106);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(594, 23);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxNro_tr, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dataGridView2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.eliminar_transaccion, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 41);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(548, 0);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Seleccione una transaccion";
            // 
            // comboBoxNro_tr
            // 
            this.comboBoxNro_tr.FormattingEnabled = true;
            this.comboBoxNro_tr.Location = new System.Drawing.Point(3, 23);
            this.comboBoxNro_tr.Name = "comboBoxNro_tr";
            this.comboBoxNro_tr.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNro_tr.TabIndex = 1;
            this.comboBoxNro_tr.SelectedIndexChanged += new System.EventHandler(this.comboBoxNro_tr_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(542, 94);
            this.dataGridView2.TabIndex = 2;
            // 
            // eliminar_transaccion
            // 
            this.eliminar_transaccion.Location = new System.Drawing.Point(3, 153);
            this.eliminar_transaccion.Name = "eliminar_transaccion";
            this.eliminar_transaccion.Size = new System.Drawing.Size(75, 2);
            this.eliminar_transaccion.TabIndex = 3;
            this.eliminar_transaccion.Text = "Eliminar";
            this.eliminar_transaccion.UseVisualStyleBackColor = true;
            this.eliminar_transaccion.Click += new System.EventHandler(this.eliminar_transaccion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 18);
            this.label2.TabIndex = 12;
            this.label2.Text = "ELIMINAR TRANSACCIONES";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 70);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label10, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label11, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.enviar_agrega, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNro_transaccion, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxFecha, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTransaccion, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxMonto, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDescripcion, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxNro_cuenta, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxDestino, 1, 5);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(17, 65);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(557, 0);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nro. de transasccion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(281, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Fecha de operacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Transaccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(281, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Monto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Descripcion";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(281, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Destino";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nro. de cuenta";
            // 
            // enviar_agrega
            // 
            this.enviar_agrega.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.enviar_agrega.Location = new System.Drawing.Point(281, 173);
            this.enviar_agrega.Name = "enviar_agrega";
            this.enviar_agrega.Size = new System.Drawing.Size(75, 23);
            this.enviar_agrega.TabIndex = 7;
            this.enviar_agrega.Text = "Enviar";
            this.enviar_agrega.UseVisualStyleBackColor = true;
            this.enviar_agrega.Click += new System.EventHandler(this.enviar_agrega_Click);
            // 
            // textBoxNro_transaccion
            // 
            this.textBoxNro_transaccion.Location = new System.Drawing.Point(3, 23);
            this.textBoxNro_transaccion.Name = "textBoxNro_transaccion";
            this.textBoxNro_transaccion.Size = new System.Drawing.Size(260, 20);
            this.textBoxNro_transaccion.TabIndex = 8;
            // 
            // textBoxFecha
            // 
            this.textBoxFecha.Location = new System.Drawing.Point(281, 23);
            this.textBoxFecha.Name = "textBoxFecha";
            this.textBoxFecha.Size = new System.Drawing.Size(273, 20);
            this.textBoxFecha.TabIndex = 9;
            // 
            // textBoxTransaccion
            // 
            this.textBoxTransaccion.Location = new System.Drawing.Point(3, 73);
            this.textBoxTransaccion.Name = "textBoxTransaccion";
            this.textBoxTransaccion.Size = new System.Drawing.Size(260, 20);
            this.textBoxTransaccion.TabIndex = 10;
            // 
            // textBoxMonto
            // 
            this.textBoxMonto.Location = new System.Drawing.Point(281, 73);
            this.textBoxMonto.Name = "textBoxMonto";
            this.textBoxMonto.Size = new System.Drawing.Size(273, 20);
            this.textBoxMonto.TabIndex = 11;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(3, 123);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(260, 20);
            this.textBoxDescripcion.TabIndex = 12;
            // 
            // comboBoxNro_cuenta
            // 
            this.comboBoxNro_cuenta.FormattingEnabled = true;
            this.comboBoxNro_cuenta.Location = new System.Drawing.Point(3, 173);
            this.comboBoxNro_cuenta.Name = "comboBoxNro_cuenta";
            this.comboBoxNro_cuenta.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNro_cuenta.TabIndex = 14;
            this.comboBoxNro_cuenta.SelectedIndexChanged += new System.EventHandler(this.comboBoxNro_cuenta_SelectedIndexChanged);
            // 
            // comboBoxDestino
            // 
            this.comboBoxDestino.FormattingEnabled = true;
            this.comboBoxDestino.Location = new System.Drawing.Point(281, 123);
            this.comboBoxDestino.Name = "comboBoxDestino";
            this.comboBoxDestino.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestino.TabIndex = 15;
            this.comboBoxDestino.SelectedIndexChanged += new System.EventHandler(this.comboBoxDestino_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "AGREGAR TRANSACCIONES";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 36);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(568, 0);
            this.dataGridView1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "LISTAR TRANSACCIONES";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label14, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label16, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label17, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label18, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.enviar_editar, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.textBoxFecha2, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.textBoxTransaccion2, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxMonto2, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxDescripcion2, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxNro_cuenta2, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxDestino2, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxNro_tr2, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(19, 65);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 8;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(557, 202);
            this.tableLayoutPanel4.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Nro. de transasccion";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(281, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Fecha de operacion";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(66, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Transaccion";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(281, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Monto";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Descripcion";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(281, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 5;
            this.label18.Text = "Destino";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 6;
            this.label19.Text = "Nro. de cuenta";
            // 
            // enviar_editar
            // 
            this.enviar_editar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.enviar_editar.Location = new System.Drawing.Point(281, 173);
            this.enviar_editar.Name = "enviar_editar";
            this.enviar_editar.Size = new System.Drawing.Size(75, 23);
            this.enviar_editar.TabIndex = 7;
            this.enviar_editar.Text = "Enviar";
            this.enviar_editar.UseVisualStyleBackColor = true;
            this.enviar_editar.Click += new System.EventHandler(this.enviar_editar_Click);
            // 
            // textBoxFecha2
            // 
            this.textBoxFecha2.Location = new System.Drawing.Point(281, 23);
            this.textBoxFecha2.Name = "textBoxFecha2";
            this.textBoxFecha2.Size = new System.Drawing.Size(273, 20);
            this.textBoxFecha2.TabIndex = 9;
            // 
            // textBoxTransaccion2
            // 
            this.textBoxTransaccion2.Location = new System.Drawing.Point(3, 73);
            this.textBoxTransaccion2.Name = "textBoxTransaccion2";
            this.textBoxTransaccion2.Size = new System.Drawing.Size(260, 20);
            this.textBoxTransaccion2.TabIndex = 10;
            // 
            // textBoxMonto2
            // 
            this.textBoxMonto2.Location = new System.Drawing.Point(281, 73);
            this.textBoxMonto2.Name = "textBoxMonto2";
            this.textBoxMonto2.Size = new System.Drawing.Size(273, 20);
            this.textBoxMonto2.TabIndex = 11;
            // 
            // textBoxDescripcion2
            // 
            this.textBoxDescripcion2.Location = new System.Drawing.Point(3, 123);
            this.textBoxDescripcion2.Name = "textBoxDescripcion2";
            this.textBoxDescripcion2.Size = new System.Drawing.Size(260, 20);
            this.textBoxDescripcion2.TabIndex = 12;
            // 
            // comboBoxNro_cuenta2
            // 
            this.comboBoxNro_cuenta2.FormattingEnabled = true;
            this.comboBoxNro_cuenta2.Location = new System.Drawing.Point(3, 173);
            this.comboBoxNro_cuenta2.Name = "comboBoxNro_cuenta2";
            this.comboBoxNro_cuenta2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNro_cuenta2.TabIndex = 14;
            // 
            // comboBoxDestino2
            // 
            this.comboBoxDestino2.FormattingEnabled = true;
            this.comboBoxDestino2.Location = new System.Drawing.Point(281, 123);
            this.comboBoxDestino2.Name = "comboBoxDestino2";
            this.comboBoxDestino2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDestino2.TabIndex = 15;
            // 
            // comboBoxNro_tr2
            // 
            this.comboBoxNro_tr2.FormattingEnabled = true;
            this.comboBoxNro_tr2.Location = new System.Drawing.Point(3, 23);
            this.comboBoxNro_tr2.Name = "comboBoxNro_tr2";
            this.comboBoxNro_tr2.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNro_tr2.TabIndex = 16;
            this.comboBoxNro_tr2.SelectedIndexChanged += new System.EventHandler(this.comboBoxNro_tr2_SelectedIndexChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.navBar.ResumeLayout(false);
            this.panelPrincipal.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel navBar;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button enviar_agrega;
        private System.Windows.Forms.TextBox textBoxNro_transaccion;
        private System.Windows.Forms.TextBox textBoxFecha;
        private System.Windows.Forms.TextBox textBoxTransaccion;
        private System.Windows.Forms.TextBox textBoxMonto;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.ComboBox comboBoxNro_cuenta;
        private System.Windows.Forms.ComboBox comboBoxDestino;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxNro_tr;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button eliminar_transaccion;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button enviar_editar;
        private System.Windows.Forms.TextBox textBoxFecha2;
        private System.Windows.Forms.TextBox textBoxTransaccion2;
        private System.Windows.Forms.TextBox textBoxMonto2;
        private System.Windows.Forms.TextBox textBoxDescripcion2;
        private System.Windows.Forms.ComboBox comboBoxNro_cuenta2;
        private System.Windows.Forms.ComboBox comboBoxDestino2;
        private System.Windows.Forms.ComboBox comboBoxNro_tr2;
    }
}