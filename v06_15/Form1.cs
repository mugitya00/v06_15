namespace v06_15
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int[] vx = new int[3];
        int[] vy = new int[3];

        public Form1()
        {
            InitializeComponent();

            vx[0] = rand.Next(-10, 11);
            vy[0] = rand.Next(-10, 11);
            vx[1] = rand.Next(-10, 11);
            vy[1] = rand.Next(-10, 11);
            vx[2] = rand.Next(-10, 11);
            vy[2] = rand.Next(-10, 11);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx[0];
            label1.Top += vy[0];
            if (label1.Left < 0)
            {
                vx[0] = Math.Abs(vx[0]);
            }
            else if (label1.Right > ClientSize.Width)
            {
                vx[0] = -Math.Abs(vx[0]);
            }
            if (label1.Top < 0)
            {
                vy[0] = Math.Abs(vy[0]);
            }
            else if (label1.Bottom > ClientSize.Height)
            {
                vy[0] = -Math.Abs(vy[0]);
            }



            label2.Left += vx[1];
            label2.Top += vy[1];
            if (label2.Left < 0)
            {
                vx[1] = Math.Abs(vx[1]);
            }
            else if (label2.Right > ClientSize.Width)
            {
                vx[1] = -Math.Abs(vx[1]);
            }
            if (label2.Top < 0)
            {
                vy[1] = Math.Abs(vy[1]);
            }
            else if (label2.Bottom > ClientSize.Height)
            {
                vy[1] = -Math.Abs(vy[1]);
            }

            label3.Left += vx[2];
            label3.Top += vy[2];
            if (label3.Left < 0)
            {
                vx[2] = Math.Abs(vx[2]);
            }
            else if (label3.Right > ClientSize.Width)
            {
                vx[2] = -Math.Abs(vx[2]);
            }
            if (label3.Top < 0)
            {
                vy[2] = Math.Abs(vy[2]);
            }
            else if (label3.Bottom > ClientSize.Height)
            {
                vy[2] = -Math.Abs(vy[2]);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (; a < 10; a++)
            {
                MessageBox.Show($"{a}");
            }
            MessageBox.Show($"done{a}");
        }
    }
}