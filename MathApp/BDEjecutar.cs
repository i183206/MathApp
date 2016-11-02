using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MathApp
{
	public partial class BDEjecutar : UserControl
	{
		public BDEjecutar()
		{
			InitializeComponent();
		}
		
		public static int doit (string comando){
			MySqlConnection conexion = BDConect.ObtenerConexion();
			if (conexion==null){
				//No se pudo conectar, no hay nada que hacer.
				//MessageBox.Show("NO se actualizó con éxito");
				return 0;
			}
			//Se crea el comando
			MySqlCommand update = new MySqlCommand(comando,conexion);
			//Se ejecuta el comando
			try{
				MySqlDataReader updated = update.ExecuteReader();
			}catch(MySql.Data.MySqlClient.MySqlException){
				return 0;
			}
			//Se cierra la conexión
			conexion.Close();
			//MessageBox.Show("Se actualizó con éxito");
			return 1;
		}
		
	}
}
