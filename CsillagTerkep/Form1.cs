using CsillagTerkep.Models;

namespace CsillagTerkep
{
    public partial class Form1 : Form
    {
        Models.hajosContext context = new Models.hajosContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var stars = (from s in context.StarData select new { s.Hip, s.X, s.Y, s.Magnitude }).ToList();

            Graphics g = this.CreateGraphics();
            g.Clear(Color.FromArgb(200,10,20,30));
            Color c = Color.Goldenrod;
            Pen pen = new Pen(Color.White, (1/1000));
            Brush brush = new SolidBrush(c);

            float cx = ClientRectangle.Width / 2;
            float cy = ClientRectangle.Height / 2;
            double nagyitas = 300;

            foreach (var star in stars)
            {
                if (star.Magnitude > 10) continue;
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1) continue;

                float x = (float)(star.X * nagyitas + cx);
                float y = (float)(star.Y * nagyitas + cy);

                double size = 15* Math.Pow(10,star.Magnitude/-2.5);

                g.FillEllipse(brush, x, y, (float)size, (float)size);
            }

            var lines = context.ConstellationLines.ToList();
            foreach (var line in lines)
            {
                var star1 = (from x in stars
                             where x.Hip == line.Star1
                             select x).FirstOrDefault(); //csak egy csillagot ad vissza
                var star2 = (from x in stars
                             where x.Hip == line.Star2
                             select x).FirstOrDefault();

                if (Math.Sqrt(Math.Pow(star1.X, 2) + Math.Pow(star1.Y, 2)) > 1) continue;
                if (Math.Sqrt(Math.Pow(star2.X, 2) + Math.Pow(star2.Y, 2)) > 1) continue;

                if (star1 == null || star2 == null) continue;

                float x1 = (float)(star1.X * nagyitas + cx);
                float y1 = (float)(star1.Y * nagyitas + cy);
                float x2 = (float)(star2.X * nagyitas + cx);
                float y2 = (float)(star2.Y * nagyitas + cy);

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}