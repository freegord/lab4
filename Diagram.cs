// Diagram.cs
namespace lab4
{
	using System.Collections.Generic;
	using System.Drawing;
	using System.IO;

	class Diagram
	{
		private readonly List<Column> data = new List<Column>();

		public static Diagram GenerateRandom(int n)
		{
			var res = new Diagram();
			for (var i=0; i<n; i++)
				res.data.Add(Column.GenerateRandom());
			return res;
		}

		public void Save(string filename)
		{
			using (var sw = new StreamWriter(filename))
				foreach (var column in data)
					sw.Write(column+"\r\n");
		}


		public void Draw(Graphics g, Rectangle boundaries)
		{
			var colWidth=boundaries.Width/2/data.Count;
			for (var i=0; i<2*data.Count; i++)
				if (i%2==0)
					data[i/2]
					   .Draw(g, new Rectangle(
								 new Point(i*colWidth+boundaries.Left+10, boundaries.Top),
								 new Size(colWidth-1, boundaries.Height-2)));


			var p = new Pen(Color.Black, 1);

			g.DrawLine(p, new Point(boundaries.Left+8, boundaries.Top+1), new Point(boundaries.Left+8, boundaries.Bottom-1));
			g.DrawLine(p, new Point(boundaries.Left+8, boundaries.Top+1), new Point(boundaries.Left, boundaries.Top+17));
			g.DrawLine(p, new Point(boundaries.Left+8, boundaries.Top+1), new Point(boundaries.Left+20, boundaries.Top+17));

			g.DrawLine(p, new Point(boundaries.Right, boundaries.Top+boundaries.Height/2),
					   new Point(boundaries.Left, boundaries.Top+boundaries.Height/2));
			g.DrawLine(p, new Point(boundaries.Right, boundaries.Top+boundaries.Height/2),
					   new Point(boundaries.Right-20, boundaries.Top+boundaries.Height/2+8));
			g.DrawLine(p, new Point(boundaries.Right, boundaries.Top+boundaries.Height/2),
					   new Point(boundaries.Right-20, boundaries.Top+boundaries.Height/2-8));
		}

		public static Diagram Load(string fn)
		{
			var res = new Diagram();
			string line;
			using (var sr = new StreamReader(fn))
				while ((line=sr.ReadLine())!=null)
					res.data.Add(Column.Parse(line));
			return res;
		}
	}
}
