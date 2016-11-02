/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 30/10/2016
 * Time: 06:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MathApp
{
	partial class Registro
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblemail = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.lblcontrasenna = new System.Windows.Forms.Label();
			this.txtContrasenna = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(13, 13);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(259, 23);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "Ingresa tu nombre:";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(13, 40);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(259, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// lblemail
			// 
			this.lblemail.Location = new System.Drawing.Point(13, 67);
			this.lblemail.Name = "lblemail";
			this.lblemail.Size = new System.Drawing.Size(259, 31);
			this.lblemail.TabIndex = 2;
			this.lblemail.Text = "Ingresa tu correo electrónico (Lo puedes dejar en blanco):";
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(13, 102);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(259, 20);
			this.txtEmail.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Ingresa algún usuario:";
			// 
			// txtUsuario
			// 
			this.txtUsuario.Location = new System.Drawing.Point(13, 156);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(259, 20);
			this.txtUsuario.TabIndex = 3;
			// 
			// lblcontrasenna
			// 
			this.lblcontrasenna.Location = new System.Drawing.Point(13, 183);
			this.lblcontrasenna.Name = "lblcontrasenna";
			this.lblcontrasenna.Size = new System.Drawing.Size(259, 23);
			this.lblcontrasenna.TabIndex = 6;
			this.lblcontrasenna.Text = "Ingresa una contraseña:";
			// 
			// txtContrasenna
			// 
			this.txtContrasenna.Location = new System.Drawing.Point(13, 210);
			this.txtContrasenna.Name = "txtContrasenna";
			this.txtContrasenna.Size = new System.Drawing.Size(259, 20);
			this.txtContrasenna.TabIndex = 4;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(12, 241);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(258, 36);
			this.btnAceptar.TabIndex = 7;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.BtnAceptarClick);
			// 
			// Registro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 289);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtContrasenna);
			this.Controls.Add(this.lblcontrasenna);
			this.Controls.Add(this.txtUsuario);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.lblemail);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblNombre);
			this.Name = "Registro";
			this.Text = "Registro";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox txtContrasenna;
		private System.Windows.Forms.Label lblcontrasenna;
		private System.Windows.Forms.TextBox txtUsuario;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label lblemail;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblNombre;
	}
}
