namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Black, 2);

            // Нарисуйте лицо Кирито
            g.DrawEllipse(pen, 100, 100, 200, 200);
            g.DrawLine(pen, 100, 200, 300, 200);
            g.DrawLine(pen, 200, 100, 200, 300);

            // Нарисуйте глаза Кирито
            g.DrawEllipse(pen, 150, 150, 30, 30);
            g.DrawEllipse(pen, 220, 150, 30, 30);

            // Нарисуйте волосы Кирито
            g.DrawLine(pen, 130, 110, 180, 155);
            g.DrawLine(pen, 270, 110, 220, 155);
            g.DrawLine(pen, 130, 290, 180, 245);
            g.DrawLine(pen, 270, 290, 220, 245);

            // Нарисуйте тело Кирито
            g.DrawRectangle(pen, 160, 300, 80, 100);
            g.DrawRectangle(pen, 145, 380, 110, 30);

            // Нарисуйте меч Кирито
            g.DrawLine(pen, 250, 380, 350, 300);
            g.DrawRectangle(pen, 350, 250, 30, 100);

            pen.Dispose();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

        }
    }
}