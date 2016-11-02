/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 30/10/2016
 * Time: 06:27 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MathApp
{
	partial class frmConfiguracion
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
			this.btnStatus = new System.Windows.Forms.Button();
			this.lblEstado = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStatus
			// 
			this.btnStatus.Location = new System.Drawing.Point(13, 85);
			this.btnStatus.Name = "btnStatus";
			this.btnStatus.Size = new System.Drawing.Size(259, 38);
			this.btnStatus.TabIndex = 0;
			this.btnStatus.Text = "Inciar/cerrar sesión";
			this.btnStatus.UseVisualStyleBackColor = true;
			// 
			// lblEstado
			// 
			this.lblEstado.Location = new System.Drawing.Point(13, 13);
			this.lblEstado.Name = "lblEstado";
			this.lblEstado.Size = new System.Drawing.Size(259, 38);
			this.lblEstado.TabIndex = 1;
			this.lblEstado.Text = "Inivta a regitrarse";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "¿Tienes un código? Ingrésalo aquí:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(13, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(259, 20);
			this.textBox1.TabIndex = 3;
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(13, 205);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(258, 44);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			// 
			// frmConfiguracion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblEstado);
			this.Controls.Add(this.btnStatus);
			this.Name = "frmConfiguracion";
			this.Text = "Configuración";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnAceptar;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEstado;
		private System.Windows.Forms.Button btnStatus;
	}
}
