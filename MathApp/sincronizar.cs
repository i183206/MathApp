using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace MathApp
{
	public partial class sincronizar : Form
	{
		public sincronizar()
		{
			InitializeComponent();
		}
		
		void SincronizarLoad(object sender, EventArgs e)
		{
			//Verifica que exista un usuario y/o contraseña
			try{
				string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				System.IO.Directory.CreateDirectory(mydocpath + @"\MathApp");
				String usuario = File.ReadAllText(mydocpath + @"\MathApp\" + @"\usuario.ma");
				String contrasenna = File.ReadAllText(mydocpath + @"\MathApp\" + @"\contrasenna.ma");
				estado.Value=25;
				
				//Verificando que tanto usuario o contraseña tengan algo
				if(usuario==""||contrasenna==""){
					//Usuario y/o constraseña vacíos nada que sincronizar
					estado.Value=100;
					this.Close();
					return;
				}
				
				//Sincronizando Archivos hacia la BD si existen.
				try{
					String correctas = File.ReadAllText(mydocpath + @"\MathApp\" + @"\correctas.ma");
					String incorrectas = File.ReadAllText(mydocpath + @"\MathApp\" + @"\incorrectas.ma");
					String tiempo = File.ReadAllText(mydocpath + @"\MathApp\" + @"\tiempo.ma");
					String puntaje = File.ReadAllText(mydocpath + @"\MathApp\" + @"\puntaje.ma");
					
					//Actualizando en la BD
					
					//Creando string para actualizar en la BD
					String actualizarDatos = "update talumno set respuestascorrectas='"+correctas+"', respuestasincorrectas='"+
						incorrectas+"',tiempo='"+tiempo+"',puntaje='"+puntaje+"' where usuario='"+usuario+"'AND pasword='"+
						contrasenna+"';";
					
					//Se pasa el comando al código que esta en BDEjecutar.cs
					int respuesta = BDEjecutar.doit(actualizarDatos);
					if(respuesta==0){
						//Este mensaje NUNCA lo tenría que ver el usuario, si aparece es error del comando anterior
						MessageBox.Show("Ocurrió un error al sincronizar.");
						this.Close();
						return;
					}
					
					//Se cierra la ventana
					estado.Value=100;
					this.Close();
					
				}catch(System.IO.FileNotFoundException){
					MessageBox.Show("¡Ocurrió un error desconicido! \n"+"Cierre sesión y vuelva a inciar.");
					
				}
				
				
			}catch(System.IO.FileNotFoundException){
				//No se encontró el directorio, nada que sincronizar
				estado.Value=100;
				this.Close();
			}
			
		}
		
	}
}
