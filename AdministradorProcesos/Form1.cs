using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministradorProcesos
{
	public partial class Form1 : Form
	{
		public Form1()
		{	InitializeComponent();
			actualizarProcesos();
            crearCarpeta();



        }
		private void actualizarProcesos() {
			lstProcesos.Items.Clear();
			lstid.Items.Clear();
			lstRam.Items.Clear();
			lstVirtual.Items.Clear();
			lstNucleos.Items.Clear();

			int count = 1;
			foreach (Process procesos in Process.GetProcesses()) {
				lstProcesos.Items.Add(count+":"+procesos.ProcessName);
				lstid.Items.Add(count+": "+procesos.Id);
				lstRam.Items.Add(count+": "+(procesos.WorkingSet64/1024f)/1024f+" MB");
				lstVirtual.Items.Add(count+": "+(procesos.VirtualMemorySize64/1024f)/1024f+" MB");
				lstNucleos.Items.Add(count + ": " + procesos.SessionId);
				count++;
			}
			lblnprocesos.Text = "Numero de Procesos: "+lstProcesos.Items.Count.ToString();
		}


        private void crearCarpeta() {
            //string carpeta = Application.StartupPath + @"\Carpeta"; me permite crear una carpeta en la direccion de la aplicacion, el problema es el sistema deniega el axceso
            string carpeta = "C:\\archivos";
            try
            {
                if (Directory.Exists(carpeta))
                {
                    MessageBox.Show("carpeta existe");
                }
                else
                {
                    Directory.CreateDirectory(carpeta);
                }

            }

            catch(Exception ex)
            {
                MessageBox.Show("error al crear carpeta"+ ex);
            }

        }

		private void BtnActualizar_Click(object sender, EventArgs e)
		{
			actualizarProcesos();
		}

		private void BtnSalir_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "Desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				Close();
			}
			
		}

		private void BtnCerrar_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (Process proc in Process.GetProcesses()) {

					String seleccion = lstProcesos.SelectedItem.ToString();
					String[] procesos = seleccion.Split(':');
                    
                    if (proc.ProcessName == procesos[1]) {
                        proc.Kill();
                        MessageBox.Show(procesos[1]+" Eliminado");
					}

                   
                }
                actualizarProcesos();
			}
			catch (Exception ex)
			{
				MessageBox.Show("No selecciono ningun proceso " + ex, "error al eliminar", 
                    MessageBoxButtons.OK);
			}
		}


     

        private void Cpu0_Click_1(object sender, EventArgs e)
        {
           
            string lineas = "bcdedit /set onecpu on > onecpu.txt \r\n" +
                "shutdown -r -t 5 -c ReiniciandoSistema";
           
            using (StreamWriter outputfile = new StreamWriter("C:\\archivos\\onecpu.bat"))
            {
                outputfile.WriteLine(lineas);
            }

            try
            {
                using (Process cpu0 = new Process())
                {

                   
                    cpu0.StartInfo.UseShellExecute = false;
                    cpu0.StartInfo.FileName = "C:\\archivos\\onecpu.bat";
                    //cpu0.StartInfo.FileName = "C:\\Program Files\\CCleaner\\CCleaner.exe";  
                    cpu0.StartInfo.Verb = "runas";
                    cpu0.StartInfo.CreateNoWindow = true;
                    cpu0.Start();
                    
                   
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Defecto_Click(object sender, EventArgs e)
        {
            string lineas = "bcdedit /deletevalue {default} numproc \r\n" +
                "bcdedit /deletevalue {default} truncatememory > vpredeterminados.txt \r\n" +
                "shutdown -r -t 5 -c ReiniciandoSistema";
            using (StreamWriter outputfile = new StreamWriter("C:\\archivos\\vpredeterminados.bat"))
            {
                outputfile.WriteLine(lineas);
            }

            try
            {
                using (Process defecto = new Process())

                {
                    
                    defecto.StartInfo.UseShellExecute = false;
                    defecto.StartInfo.FileName = "C:\\archivos\\vpredeterminados.bat";
                    //defecto.StartInfo.FileName = "C:\\Program Files\\CCleaner\\CCleaner.exe";
                    defecto.StartInfo.Verb = "runas";
                    defecto.StartInfo.CreateNoWindow = true;
                    defecto.Start();

                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error al determinar valores por defecto"+ ex);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (Process cmd = new Process())
            {
         
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                
                cmd.Start();


                //cmd.StandardInput.WriteLine("bcdedit /set onecpu on > archivo.txt");
                cmd.StandardInput.WriteLine("bcdedit /set onecpu on > onecpucmd.txt \r\n" +
                    "shutdown -r -t 5 -c ReiniciandoSistema");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                Console.Read();
            
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (Process cmd = new Process())
            {
                    

                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;

                cmd.Start();


                cmd.StandardInput.WriteLine("bcdedit /set numproc 2 > 2nucleoscmd.txt \r\n" +
                    "shutdown -r -t 5 -c ReiniciandoSistema");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                Console.Read();
                
            }

        }

   
      

        private void Enucleos_Click(object sender, EventArgs e)
        {
            string numNucleos = Nnucleos.Text;

            string lineas = "bcdedit /set numproc " + numNucleos + " > Enucleos.txt \r\n" +
                "shutdown -r -t 5 -c ReiniciandoSistema";

            using (StreamWriter outputfile = new StreamWriter("C:\\archivos\\Enucleos.bat"))
            {
                outputfile.WriteLine(lineas);
            }

            try
            {
                if (!(numNucleos.Length == 0))
                {
                    using (Process Ncpu = new Process())
                    {


                        Ncpu.StartInfo.UseShellExecute = false;
                        Ncpu.StartInfo.FileName = "C:\\archivos\\Enucleos.bat";
                        //Ncpu.StartInfo.FileName = "C:\\Program Files\\CCleaner\\CCleaner.exe";  
                        Ncpu.StartInfo.Verb = "runas";
                        Ncpu.StartInfo.CreateNoWindow = true;
                        Ncpu.Start();
                        MessageBox.Show("completado con exito reiniciar el sistema");
                    }                 

                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero");
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error\n" + ex.Message);
            }



        }

    

        
    }
}

/*using (Process cmd = new Process())
            {
                cmd.StartInfo.Verb = "runas";
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = false;
                cmd.StartInfo.UseShellExecute = false;
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
                cmd.Start();

cmd.StandardInput.WriteLine("bcdedit /set onecpu on");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                Console.Read();
            }*/
