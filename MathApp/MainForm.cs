using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace MathApp
{
	public partial class frmMainForm : Form
	{
		public frmMainForm()
		{
			InitializeComponent();
			sincronizar sincronizar = new sincronizar();
			sincronizar.Show();
		}
		
		
		void FrmMainFormLoad(object sender, EventArgs e)
		{
			try{
				string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
				System.IO.Directory.CreateDirectory(mydocpath + @"\MathApp");
				String nombre = File.ReadAllText(mydocpath + @"\MathApp\" + @"\nombre.ma");
				String puntaje = File.ReadAllText(mydocpath + @"\MathApp\" + @"\puntaje.ma");
				
				lblBienvenido.Text = "¡Bienvenido de nuevo "+nombre+"!";
				lblPuntaje.Text = "Tu puntaje hasta ahora es de: "+puntaje;
				
			}catch(System.IO.FileNotFoundException){}
			
		}
		
		void BtnJugarClick(object sender, EventArgs e)
		{
			Juego1 Juego1 = new Juego1();
			Juego1.Show();
		}
		
		void BtnConfiguracionClick(object sender, EventArgs e)
		{
			frmConfiguracion frmConfiguracion = new frmConfiguracion();
			frmConfiguracion.Show();
		}
		
		void BtnsalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
