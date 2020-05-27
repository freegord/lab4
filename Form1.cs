// Form1.cs
namespace lab4
{
	using System;
	using System.Windows.Forms;
	using System.Drawing;
	using System.Drawing.Drawing2D;

	public partial class Form1 : Form
	{
		private readonly string fn=Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+@"\1.txt";
		private Diagram diag;
		private const int Number=12;
		private readonly Graphics g;

		public Form1()
		{
			InitializeComponent();
			g=CreateGraphics();
			g.SmoothingMode=SmoothingMode.HighQuality;
		}

		private void Write_Click(object sender, EventArgs e) => diag?.Save(fn);

		private void Draw_Click(object sender, EventArgs e) => diag=Diagram.GenerateRandom(Number);

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			SuspendLayout();
			g.Clear(Color.White);
			diag?.Draw(g, new Rectangle(200, 50, Width-300, Height-100));
			ResumeLayout(false);
		}

		private void Read_Click(object sender, EventArgs e) => diag=Diagram.Load(fn);
	}
}
