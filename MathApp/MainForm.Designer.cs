/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 26/10/2016
 * Time: 12:39 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MathApp
{
	partial class frmMainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnConfiguracion = new System.Windows.Forms.Button();
			this.btnsalir = new System.Windows.Forms.Button();
			this.btnJugar = new System.Windows.Forms.Button();
			this.lblPuntaje = new System.Windows.Forms.Label();
			this.lblBienvenido = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnConfiguracion
			// 
			this.btnConfiguracion.BackColor = System.Drawing.Color.LightGray;
			this.btnConfiguracion.Location = new System.Drawing.Point(12, 130);
			this.btnConfiguracion.Name = "btnConfiguracion";
			this.btnConfiguracion.Size = new System.Drawing.Size(259, 36);
			this.btnConfiguracion.TabIndex = 9;
			this.btnConfiguracion.Text = "Opciones";
			this.btnConfiguracion.UseVisualStyleBackColor = false;
			this.btnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracionClick);
			// 
			// btnsalir
			// 
			this.btnsalir.BackColor = System.Drawing.Color.LightGray;
			this.btnsalir.Location = new System.Drawing.Point(12, 172);
			this.btnsalir.Name = "btnsalir";
			this.btnsalir.Size = new System.Drawing.Size(259, 36);
			this.btnsalir.TabIndex = 8;
			this.btnsalir.Text = "Salir del juego";
			this.btnsalir.UseVisualStyleBackColor = false;
			this.btnsalir.Click += new System.EventHandler(this.BtnsalirClick);
			// 
			// btnJugar
			// 
			this.btnJugar.BackColor = System.Drawing.Color.LightGray;
			this.btnJugar.Location = new System.Drawing.Point(12, 88);
			this.btnJugar.Name = "btnJugar";
			this.btnJugar.Size = new System.Drawing.Size(259, 36);
			this.btnJugar.TabIndex = 7;
			this.btnJugar.Text = "Jugar Ahora";
			this.btnJugar.UseVisualStyleBackColor = false;
			this.btnJugar.Click += new System.EventHandler(this.BtnJugarClick);
			// 
			// lblPuntaje
			// 
			this.lblPuntaje.Location = new System.Drawing.Point(12, 36);
			this.lblPuntaje.Name = "lblPuntaje";
			this.lblPuntaje.Size = new System.Drawing.Size(259, 23);
			this.lblPuntaje.TabIndex = 6;
			this.lblPuntaje.Text = "Tu puntaje es de: ";
			// 
			// lblBienvenido
			// 
			this.lblBienvenido.Location = new System.Drawing.Point(12, 9);
			this.lblBienvenido.Name = "lblBienvenido";
			this.lblBienvenido.Size = new System.Drawing.Size(259, 23);
			this.lblBienvenido.TabIndex = 5;
			this.lblBienvenido.Text = "¡Bienvenido de nuevo!";
			// 
			// frmMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(278, 236);
			this.Controls.Add(this.btnConfiguracion);
			this.Controls.Add(this.btnsalir);
			this.Controls.Add(this.btnJugar);
			this.Controls.Add(this.lblPuntaje);
			this.Controls.Add(this.lblBienvenido);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmMainForm";
			this.Text = "MathApp - ¡Aprende a multipicar ya!";
			this.Load += new System.EventHandler(this.FrmMainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblBienvenido;
		private System.Windows.Forms.Label lblPuntaje;
		private System.Windows.Forms.Button btnJugar;
		private System.Windows.Forms.Button btnsalir;
		private System.Windows.Forms.Button btnConfiguracion;
	}
}
