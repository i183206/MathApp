/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 31/10/2016
 * Time: 03:05 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MathApp
{
	partial class sincronizar
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
			this.label1 = new System.Windows.Forms.Label();
			this.estado = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sincronizando por favor espere...";
			// 
			// estado
			// 
			this.estado.Location = new System.Drawing.Point(13, 40);
			this.estado.Name = "estado";
			this.estado.Size = new System.Drawing.Size(259, 23);
			this.estado.TabIndex = 1;
			
			// 
			// sincronizar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 86);
			this.Controls.Add(this.estado);
			this.Controls.Add(this.label1);
			this.Name = "sincronizar";
			this.Text = "Sinconizando...";
			this.Load += new System.EventHandler(this.SincronizarLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ProgressBar estado;
		private System.Windows.Forms.Label label1;
	}
}
