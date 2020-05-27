// Column.cs
namespace lab4
{
	using System;
	using System.Linq;
	using System.Drawing;

	class Column
	{
		private int Height
		{
			get;
		}

		private Color Color
		{
			get;
		}

		static readonly Random rng=new Random();
		private Column(int height, Color color) => (Height, Color)=(height, color);

		public static Column GenerateRandom() => new Column(
			rng.Next(-100, 101),
			Color.FromArgb(rng.Next(256), rng.Next(256), rng.Next(256)));

		public override string ToString() => $"{Height}:{Color.R}:{Color.G}:{Color.B}";

		public void Draw(Graphics g, Rectangle rectangle)
		{
			var l=rectangle.Left;
			var w=rectangle.Width;
			var h=Math.Abs(Height)*rectangle.Height/200;
			var t=rectangle.Top+rectangle.Height/2-(Height>0 ? h : 0);
			var r=new Rectangle(l, t, w, h);
			g.FillRectangle(new SolidBrush(Color), r);
			var y=Height>0 ? t-20 : r.Bottom+10;
			g.DrawString($"{Height:N0}",
						 new Font(FontFamily.GenericSerif, 12),
						 new SolidBrush(Color.Black),
						 new PointF(l, y));
		}

		public static Column Parse(string line)
		{
			var s=line.Split(':')
					  .Select(int.Parse)
					  .ToList();
			return new Column(s[0], Color.FromArgb(s[1], s[2], s[3]));
		}
	}
}
