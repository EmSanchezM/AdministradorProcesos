namespace AdministradorProcesos
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
            this.lstProcesos = new System.Windows.Forms.ListBox();
            this.lstid = new System.Windows.Forms.ListBox();
            this.lstRam = new System.Windows.Forms.ListBox();
            this.lstVirtual = new System.Windows.Forms.ListBox();
            this.lstNucleos = new System.Windows.Forms.ListBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblnprocesos = new System.Windows.Forms.Label();
            this.cpu0 = new System.Windows.Forms.Button();
            this.defecto = new System.Windows.Forms.Button();
            this.OnecpuCmd = new System.Windows.Forms.Button();
            this.E2nucleoscmd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Nnucleos = new System.Windows.Forms.TextBox();
            this.Enucleos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProcesos
            // 
            this.lstProcesos.FormattingEnabled = true;
            this.lstProcesos.Location = new System.Drawing.Point(13, 40);
            this.lstProcesos.Name = "lstProcesos";
            this.lstProcesos.Size = new System.Drawing.Size(120, 316);
            this.lstProcesos.TabIndex = 0;
            // 
            // lstid
            // 
            this.lstid.FormattingEnabled = true;
            this.lstid.Location = new System.Drawing.Point(148, 37);
            this.lstid.Name = "lstid";
            this.lstid.Size = new System.Drawing.Size(120, 316);
            this.lstid.TabIndex = 1;
            // 
            // lstRam
            // 
            this.lstRam.FormattingEnabled = true;
            this.lstRam.Location = new System.Drawing.Point(287, 37);
            this.lstRam.Name = "lstRam";
            this.lstRam.Size = new System.Drawing.Size(120, 316);
            this.lstRam.TabIndex = 2;
            // 
            // lstVirtual
            // 
            this.lstVirtual.FormattingEnabled = true;
            this.lstVirtual.Location = new System.Drawing.Point(419, 37);
            this.lstVirtual.Name = "lstVirtual";
            this.lstVirtual.Size = new System.Drawing.Size(120, 316);
            this.lstVirtual.TabIndex = 3;
            // 
            // lstNucleos
            // 
            this.lstNucleos.FormattingEnabled = true;
            this.lstNucleos.Location = new System.Drawing.Point(555, 37);
            this.lstNucleos.Name = "lstNucleos";
            this.lstNucleos.Size = new System.Drawing.Size(120, 316);
            this.lstNucleos.TabIndex = 4;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(12, 392);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(121, 392);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Eliminar Proceso";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(332, 503);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "ldentificador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Memoria RAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(416, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Memoria Virtual";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nucleos Procesador";
            // 
            // lblnprocesos
            // 
            this.lblnprocesos.AutoSize = true;
            this.lblnprocesos.Location = new System.Drawing.Point(13, 444);
            this.lblnprocesos.Name = "lblnprocesos";
            this.lblnprocesos.Size = new System.Drawing.Size(35, 13);
            this.lblnprocesos.TabIndex = 13;
            this.lblnprocesos.Text = "label6";
            // 
            // cpu0
            // 
            this.cpu0.Location = new System.Drawing.Point(234, 392);
            this.cpu0.Name = "cpu0";
            this.cpu0.Size = new System.Drawing.Size(115, 23);
            this.cpu0.TabIndex = 14;
            this.cpu0.Text = "OneCpu On";
            this.cpu0.UseVisualStyleBackColor = true;
            this.cpu0.Click += new System.EventHandler(this.Cpu0_Click_1);
            // 
            // defecto
            // 
            this.defecto.Location = new System.Drawing.Point(234, 434);
            this.defecto.Name = "defecto";
            this.defecto.Size = new System.Drawing.Size(115, 38);
            this.defecto.TabIndex = 15;
            this.defecto.Text = "Valores Predeterminados";
            this.defecto.UseVisualStyleBackColor = true;
            this.defecto.Click += new System.EventHandler(this.Defecto_Click);
            // 
            // OnecpuCmd
            // 
            this.OnecpuCmd.Location = new System.Drawing.Point(395, 392);
            this.OnecpuCmd.Name = "OnecpuCmd";
            this.OnecpuCmd.Size = new System.Drawing.Size(135, 23);
            this.OnecpuCmd.TabIndex = 16;
            this.OnecpuCmd.Text = "OneCpu On";
            this.OnecpuCmd.UseVisualStyleBackColor = true;
            this.OnecpuCmd.Click += new System.EventHandler(this.Button1_Click);
            // 
            // E2nucleoscmd
            // 
            this.E2nucleoscmd.Location = new System.Drawing.Point(395, 434);
            this.E2nucleoscmd.Name = "E2nucleoscmd";
            this.E2nucleoscmd.Size = new System.Drawing.Size(135, 38);
            this.E2nucleoscmd.TabIndex = 17;
            this.E2nucleoscmd.Text = "Establecer 2 Nucleos";
            this.E2nucleoscmd.UseVisualStyleBackColor = true;
            this.E2nucleoscmd.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Mediante CMD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 373);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Mediante Archivos .Bat";
            // 
            // Nnucleos
            // 
            this.Nnucleos.Location = new System.Drawing.Point(555, 394);
            this.Nnucleos.Name = "Nnucleos";
            this.Nnucleos.Size = new System.Drawing.Size(120, 20);
            this.Nnucleos.TabIndex = 20;
            // 
            // Enucleos
            // 
            this.Enucleos.Location = new System.Drawing.Point(555, 434);
            this.Enucleos.Name = "Enucleos";
            this.Enucleos.Size = new System.Drawing.Size(120, 38);
            this.Enucleos.TabIndex = 21;
            this.Enucleos.Text = "Establecer Numero de  Nucleos";
            this.Enucleos.UseVisualStyleBackColor = true;
            this.Enucleos.Click += new System.EventHandler(this.Enucleos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 579);
            this.Controls.Add(this.Enucleos);
            this.Controls.Add(this.Nnucleos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.E2nucleoscmd);
            this.Controls.Add(this.OnecpuCmd);
            this.Controls.Add(this.defecto);
            this.Controls.Add(this.cpu0);
            this.Controls.Add(this.lblnprocesos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lstNucleos);
            this.Controls.Add(this.lstVirtual);
            this.Controls.Add(this.lstRam);
            this.Controls.Add(this.lstid);
            this.Controls.Add(this.lstProcesos);
            this.Name = "Form1";
            this.Text = "ManipuladorProcesos";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstProcesos;
		private System.Windows.Forms.ListBox lstid;
		private System.Windows.Forms.ListBox lstRam;
		private System.Windows.Forms.ListBox lstVirtual;
		private System.Windows.Forms.ListBox lstNucleos;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.Button btnCerrar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblnprocesos;
        private System.Windows.Forms.Button cpu0;
        private System.Windows.Forms.Button defecto;
        private System.Windows.Forms.Button OnecpuCmd;
        private System.Windows.Forms.Button E2nucleoscmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Nnucleos;
        private System.Windows.Forms.Button Enucleos;
    }
}

