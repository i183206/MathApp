using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MathApp
{
	public partial class BDConect : UserControl
	{
		public BDConect()
		{
			InitializeComponent();
		}
		
		//Método para conectar una base de datos.
		public static MySqlConnection ObtenerConexion()
        {
			//string que conecta a la BD
           	MySqlConnection conectar = new MySqlConnection("server=sql9.freesqldatabase.com; database=sql9142391; Uid=sql9142391; pwd=1tAQPiw28A;");
           	
           	//Si existe una conexión exitoa con la BD regresa conectar, y si no regresa NULL.
           	try{
          		conectar.Open();
          		return conectar;
           	}catch(MySql.Data.MySqlClient.MySqlException){
           		return null;
           	}
           	
        }
		
	}
}
