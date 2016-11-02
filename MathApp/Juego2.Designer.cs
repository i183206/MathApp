
namespace MathApp
{
	partial class Juego2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego2));
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblNumero2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblNumero1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnNo = new System.Windows.Forms.Button();
			this.btnSi = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(99, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(179, 47);
			this.label1.TabIndex = 1;
			this.label1.Text = "¿Es correcto?";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(572, 125);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 217);
			this.label5.TabIndex = 8;
			this.label5.Text = "=";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero2
			// 
			this.lblNumero2.BackColor = System.Drawing.Color.Transparent;
			this.lblNumero2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero2.Location = new System.Drawing.Point(371, 125);
			this.lblNumero2.Name = "lblNumero2";
			this.lblNumero2.Size = new System.Drawing.Size(195, 217);
			this.lblNumero2.TabIndex = 7;
			this.lblNumero2.Text = "10";
			this.lblNumero2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(300, 125);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 217);
			this.label3.TabIndex = 6;
			this.label3.Text = "x";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblNumero1
			// 
			this.lblNumero1.BackColor = System.Drawing.Color.Transparent;
			this.lblNumero1.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumero1.Location = new System.Drawing.Point(99, 125);
			this.lblNumero1.Name = "lblNumero1";
			this.lblNumero1.Size = new System.Drawing.Size(195, 217);
			this.lblNumero1.TabIndex = 5;
			this.lblNumero1.Text = "10";
			this.lblNumero1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(643, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(195, 217);
			this.label2.TabIndex = 9;
			this.label2.Text = "10";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnNo
			// 
			this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnNo.Location = new System.Drawing.Point(507, 387);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(402, 62);
			this.btnNo.TabIndex = 11;
			this.btnNo.Text = "NO";
			this.btnNo.UseVisualStyleBackColor = false;
			// 
			// btnSi
			// 
			this.btnSi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.btnSi.Location = new System.Drawing.Point(99, 387);
			this.btnSi.Name = "btnSi";
			this.btnSi.Size = new System.Drawing.Size(402, 62);
			this.btnSi.TabIndex = 12;
			this.btnSi.Text = "SI";
			this.btnSi.UseVisualStyleBackColor = false;
			// 
			// Juego2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(984, 461);
			this.Controls.Add(this.btnSi);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblNumero2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblNumero1);
			this.Controls.Add(this.label1);
			this.Name = "Juego2";
			this.Text = "Juego2";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnSi;
		private System.Windows.Forms.Button btnNo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblNumero1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblNumero2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label1;
	}
}
