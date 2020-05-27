namespace lab4
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing&&(components!=null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.draw = new System.Windows.Forms.Button();
			this.write = new System.Windows.Forms.Button();
			this.read = new System.Windows.Forms.Button();
			this.SuspendLayout();
			//
			// draw
			//
			this.draw.Location = new System.Drawing.Point(12, 649);
			this.draw.Name = "draw";
			this.draw.Size = new System.Drawing.Size(120, 40);
			this.draw.TabIndex = 0;
			this.draw.TabStop = false;
			this.draw.Text = "Построить";
			this.draw.UseVisualStyleBackColor = true;
			this.draw.Click += new System.EventHandler(this.Draw_Click);
			//
			// write
			//
			this.write.Location = new System.Drawing.Point(12, 12);
			this.write.Name = "write";
			this.write.Size = new System.Drawing.Size(120, 40);
			this.write.TabIndex = 1;
			this.write.TabStop = false;
			this.write.Text = "Записать";
			this.write.UseVisualStyleBackColor = true;
			this.write.Click += new System.EventHandler(this.Write_Click);
			//
			// read
			//
			this.read.Location = new System.Drawing.Point(12, 593);
			this.read.Name = "read";
			this.read.Size = new System.Drawing.Size(120, 40);
			this.read.TabIndex = 2;
			this.read.TabStop = false;
			this.read.Text = "Считать";
			this.read.UseVisualStyleBackColor = true;
			this.read.Click += new System.EventHandler(this.Read_Click);
			//
			// Form1
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1234, 711);
			this.Controls.Add(this.read);
			this.Controls.Add(this.write);
			this.Controls.Add(this.draw);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button draw;
		private System.Windows.Forms.Button write;
		private System.Windows.Forms.Button read;
	}
}

