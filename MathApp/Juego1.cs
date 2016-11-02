using System;
using System.Drawing;
using System.Windows.Forms;

namespace MathApp
{
	public partial class Juego1 : Form
	{
		public Juego1()
		{
			InitializeComponent();
		}
		
		void Juego1Load(object sender, EventArgs e)
		{
			generaTabla();
		}
		
		//Método que genera una nueva solución
		void generaTabla(){
			Random r = new Random(DateTime.Now.Millisecond);
			do{
				lblNumero1.Text = (r.Next(1, 11)).ToString();
				lblNumero2.Text = (r.Next(0, 11)).ToString();
			}while(lblNumero1.Text=="11" && lblNumero2.Text=="11");
			int resultadoMultipicacion = Int32.Parse(lblNumero1.Text) * Int32.Parse(lblNumero2.Text);
			int correcta = r.Next(1, 3);
			if(correcta==1){
				btnResultado1.Text = resultadoMultipicacion.ToString();
			}else{
				do{
					btnResultado1.Text = (Int32.Parse(lblNumero1.Text) * r.Next(1, 10)).ToString();
				}while((resultadoMultipicacion == Int32.Parse(btnResultado1.Text)) );
			}
			
			if(correcta==2){
				btnResultado2.Text = resultadoMultipicacion.ToString();
			}else{
				do{
					btnResultado2.Text = (Int32.Parse(lblNumero1.Text) * r.Next(1, 10)).ToString();
				}while((resultadoMultipicacion == Int32.Parse(btnResultado2.Text)) && (Int32.Parse(btnResultado2.Text) == Int32.Parse(btnResultado1.Text)) );
			}
			
			if(correcta==3){
				btnResultado3.Text = resultadoMultipicacion.ToString();
			}else{
				do{
					btnResultado3.Text = (Int32.Parse(lblNumero1.Text) * r.Next(1, 10)).ToString();
				}while((resultadoMultipicacion == Int32.Parse(btnResultado3.Text)) && (Int32.Parse(btnResultado3.Text) == Int32.Parse(btnResultado2.Text)) && (Int32.Parse(btnResultado3.Text) == Int32.Parse(btnResultado1.Text)));
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			generaTabla(); 
		}
	}
}
