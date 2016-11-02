/*
 * Created by SharpDevelop.
 * User: JoGarWeb
 * Date: 30/10/2016
 * Time: 07:03 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace MathApp
{
	partial class Juego1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego1));
			this.label1 = new System.Windows.Forms.Label();
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.btnResultado1 = new System.Windows.Forms.Button();
			this.btnResultado2 = new System.Windows.Forms.Button();
			this.btnResultado3 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(98, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 47);
			this.label1.TabIndex = 0;
			this.label1.Text = "¿Cuánto es?";
			// 
			// lblNumero1
			// 
			this.lblNumero1.BackColor = System.Drawing.Color.Transparent;
			this.lblNumero1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero1.Location = new System.Drawing.Point(98, 121);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(195, 217);
			this.lblNumero1.TabIndex = 1;
			this.lblNumero1.Text = "10";
			this.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(299, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 217);
			this.label3.TabIndex = 2;
			this.label3.Text = "x";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero2
			// 
			this.lblNumero2.BackColor = System.Drawing.Color.Transparent;
			this.lblNumero2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero2.Location = new System.Drawing.Point(370, 121);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(195, 217);
			this.lblNumero2.TabIndex = 3;
			this.lblNumero2.Text = "10";
			this.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(571, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 217);
			this.label5.TabIndex = 4;
			this.label5.Text = "=";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnResultado1
			// 
			this.btnResultado1.Location = new System.Drawing.Point(663, 154);
			this.btnResultado1.Name = "btnResultado1";
			this.btnResultado1.Size = new System.Drawing.Size(239, 44);
			this.btnResultado1.TabIndex = 5;
			this.btnResultado1.Text = "button1";
			this.btnResultado1.UseVisualStyleBackColor = true;
			// 
			// btnResultado2
			// 
			this.btnResultado2.Location = new System.Drawing.Point(663, 204);
			this.btnResultado2.Name = "btnResultado2";
			this.btnResultado2.Size = new System.Drawing.Size(239, 44);
			this.btnResultado2.TabIndex = 6;
			this.btnResultado2.Text = "button2";
			this.btnResultado2.UseVisualStyleBackColor = true;
			// 
			// btnResultado3
			// 
			this.btnResultado3.Location = new System.Drawing.Point(663, 254);
			this.btnResultado3.Name = "btnResultado3";
			this.btnResultado3.Size = new System.Drawing.Size(239, 44);
			this.btnResultado3.TabIndex = 7;
			this.btnResultado3.Text = "button3";
			this.btnResultado3.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(83, 9);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(381, 47);
			this.label6.TabIndex = 8;
			this.label6.Text = "Tiempo Restante:";
			// 
			// label7
			// 
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(702, 9);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(219, 47);
			this.label7.TabIndex = 9;
			this.label7.Text = "Puntaje: 000000000000";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(370, 401);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 10;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Juego1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.btnResultado3);
			this.Controls.Add(this.btnResultado2);
			this.Controls.Add(this.btnResultado1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblNumero1);
			this.Controls.Add(this.label1);
			this.Name = "Juego1";
			this.Text = "Juego1";
			this.Load += new System.EventHandler(this.Juego1Load);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnResultado3;
		private System.Windows.Forms.Button btnResultado2;
		private System.Windows.Forms.Button btnResultado1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblNumero1;
		private System.Windows.Forms.Label label1;
	}
}
