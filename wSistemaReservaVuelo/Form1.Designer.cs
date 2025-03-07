namespace wSistemaReservaVuelo
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
            this.btnReservarVuelo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantidadReservas = new System.Windows.Forms.TextBox();
            this.txtCodigoReserva = new System.Windows.Forms.TextBox();
            this.listBoxVuelos = new System.Windows.Forms.ListBox();
            this.btnAgregarVuelo = new System.Windows.Forms.Button();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.txtAsientosDisponibles = new System.Windows.Forms.TextBox();
            this.txtDestino = new System.Windows.Forms.TextBox();
            this.txtOrigen = new System.Windows.Forms.TextBox();
            this.txtCodigoVuelo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReservarVuelo
            // 
            this.btnReservarVuelo.Location = new System.Drawing.Point(614, 111);
            this.btnReservarVuelo.Name = "btnReservarVuelo";
            this.btnReservarVuelo.Size = new System.Drawing.Size(117, 25);
            this.btnReservarVuelo.TabIndex = 33;
            this.btnReservarVuelo.Text = "Reservar Vuelo";
            this.btnReservarVuelo.UseVisualStyleBackColor = true;
            this.btnReservarVuelo.Click += new System.EventHandler(this.btnReservarVuelo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(446, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Ingrese la cantidad de reservas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ingrese el código de reserva:";
            // 
            // txtCantidadReservas
            // 
            this.txtCantidadReservas.Location = new System.Drawing.Point(614, 59);
            this.txtCantidadReservas.Name = "txtCantidadReservas";
            this.txtCantidadReservas.Size = new System.Drawing.Size(117, 20);
            this.txtCantidadReservas.TabIndex = 30;
            // 
            // txtCodigoReserva
            // 
            this.txtCodigoReserva.Location = new System.Drawing.Point(614, 21);
            this.txtCodigoReserva.Name = "txtCodigoReserva";
            this.txtCodigoReserva.Size = new System.Drawing.Size(117, 20);
            this.txtCodigoReserva.TabIndex = 29;
            // 
            // listBoxVuelos
            // 
            this.listBoxVuelos.FormattingEnabled = true;
            this.listBoxVuelos.Location = new System.Drawing.Point(37, 252);
            this.listBoxVuelos.Name = "listBoxVuelos";
            this.listBoxVuelos.Size = new System.Drawing.Size(323, 95);
            this.listBoxVuelos.TabIndex = 28;
            // 
            // btnAgregarVuelo
            // 
            this.btnAgregarVuelo.Location = new System.Drawing.Point(160, 209);
            this.btnAgregarVuelo.Name = "btnAgregarVuelo";
            this.btnAgregarVuelo.Size = new System.Drawing.Size(128, 27);
            this.btnAgregarVuelo.TabIndex = 27;
            this.btnAgregarVuelo.Text = "Agregar Vuelo";
            this.btnAgregarVuelo.UseVisualStyleBackColor = true;
            this.btnAgregarVuelo.Click += new System.EventHandler(this.btnAgregarVuelo_Click);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Location = new System.Drawing.Point(160, 168);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaSalida.TabIndex = 26;
            // 
            // txtAsientosDisponibles
            // 
            this.txtAsientosDisponibles.Location = new System.Drawing.Point(160, 124);
            this.txtAsientosDisponibles.Name = "txtAsientosDisponibles";
            this.txtAsientosDisponibles.Size = new System.Drawing.Size(128, 20);
            this.txtAsientosDisponibles.TabIndex = 25;
            // 
            // txtDestino
            // 
            this.txtDestino.Location = new System.Drawing.Point(160, 88);
            this.txtDestino.Name = "txtDestino";
            this.txtDestino.Size = new System.Drawing.Size(128, 20);
            this.txtDestino.TabIndex = 24;
            // 
            // txtOrigen
            // 
            this.txtOrigen.Location = new System.Drawing.Point(160, 56);
            this.txtOrigen.Name = "txtOrigen";
            this.txtOrigen.Size = new System.Drawing.Size(128, 20);
            this.txtOrigen.TabIndex = 23;
            // 
            // txtCodigoVuelo
            // 
            this.txtCodigoVuelo.Location = new System.Drawing.Point(160, 18);
            this.txtCodigoVuelo.Name = "txtCodigoVuelo";
            this.txtCodigoVuelo.Size = new System.Drawing.Size(128, 20);
            this.txtCodigoVuelo.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de salida:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Asientos disponibles:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Destino:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Origen: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código del vuelo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReservarVuelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantidadReservas);
            this.Controls.Add(this.txtCodigoReserva);
            this.Controls.Add(this.listBoxVuelos);
            this.Controls.Add(this.btnAgregarVuelo);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.txtAsientosDisponibles);
            this.Controls.Add(this.txtDestino);
            this.Controls.Add(this.txtOrigen);
            this.Controls.Add(this.txtCodigoVuelo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Gestión de reserva vuelos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReservarVuelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidadReservas;
        private System.Windows.Forms.TextBox txtCodigoReserva;
        private System.Windows.Forms.ListBox listBoxVuelos;
        private System.Windows.Forms.Button btnAgregarVuelo;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.TextBox txtAsientosDisponibles;
        private System.Windows.Forms.TextBox txtDestino;
        private System.Windows.Forms.TextBox txtOrigen;
        private System.Windows.Forms.TextBox txtCodigoVuelo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

