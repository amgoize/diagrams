namespace diagrams2
{
    public partial class Form1 : Form
    {
        int x0 = 100, y0 = 300;
        int n0, n1;
        int lenght1, R1, G1, B1;
        Graphics g;
        public string[] diagr1 = new string[31];
        public string[,] diagr2 = new string[31, 4];

        public Form1()
        {
            Random rand = new Random();
            StreamWriter sr = new StreamWriter("1.txt");
            n0 = rand.Next(5, 20);
            for (int i = 0; i < n0; i++)
            {
                int R = rand.Next(0, 255), G = rand.Next(0, 255), B = rand.Next(0, 255);
                int lenght = rand.Next(-100, 100);
                sr.Write("Cтолбец" + (i + 1) + ":" + lenght + ":" + R + ":" + G + ":" + B + "\n");
            }
            sr.Close();
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            int x = this.Width;
            int y = this.Height;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(SystemColors.Control);
            Random rand = new Random();
            n1 = rand.Next(5, 20);
            g.TranslateTransform(x0, y0);
            g.DrawLine(new Pen(Color.Black), 0, -200, 0, 200);
            g.DrawLine(new Pen(Color.Black), 0, 0, 800, 0);
            int width = 400 / n1;
            int mn = 1;
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];
                if (control is Label)
                {
                    this.Controls.RemoveAt(i);
                }
            }
            for (int i = 0; i < n1; i++)
            {

                int lenght = rand.Next(-200, 200);
                R1 = rand.Next(0, 255);
                G1 = rand.Next(0, 255);
                B1 = rand.Next(0, 255);
                diagr1[i] = "Столбец" + (i + 1) + ":" + lenght.ToString() + ":" + R1.ToString() + ":" + G1.ToString() + ":" + B1.ToString();
                SolidBrush mySolidBrush = new SolidBrush(Color.FromArgb(R1, G1, B1));
                if (lenght >= 0)
                {
                    g.FillRectangle(mySolidBrush, width * mn, -lenght, width, Math.Abs(lenght));
                    Label label = new Label();
                    label.Text = lenght.ToString();
                    label.Location = new Point(x0 + width * mn, y0 - lenght - 40);
                    label.Size = new Size(width + 5, 30);
                    this.Controls.Add(label);

                }
                else
                {
                    Label label = new Label();
                    label.Text = lenght.ToString();
                    g.FillRectangle(mySolidBrush, width * mn, 0, width, Math.Abs(lenght));
                    label.Location = new Point(x0 + width * mn, y0 - lenght + 40);
                    label.Size = new Size(width + 10, 30);
                    this.Controls.Add(label);


                }
                mn = mn + 2;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter("2.txt");
            for (int i = 0; i < n1; i++)
            {
                sr.Write(diagr1[i] + "\n");
            }
            sr.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InitializeComponent();
            StreamReader streamread = new StreamReader("1.txt");
            string line;
            int j = -1;
            while ((line = streamread.ReadLine()) != null)
            {
                j++;
                string[] s = line.Split(":");
                for (int i = 1; i < 5; i++)
                {
                    diagr2[j, i - 1] = s[i];
                }
            }
            streamread.Close();
            g.Clear(SystemColors.Control);
            Random rand = new Random();
            n1 = rand.Next(5, 20);
            g.TranslateTransform(x0, y0);
            g.DrawLine(new Pen(Color.Black), 0, -200, 0, 200);
            g.DrawLine(new Pen(Color.Black), 0, 0, 800, 0);
            int width = 400 / n0;
            int mn = 1;
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                Control control = this.Controls[i];
                if (control is Label)
                {
                    this.Controls.RemoveAt(i);
                }
            }
            for (int i = 0; i < n0; i++)
            {
                int lenght = int.Parse(diagr2[i, 0]);
                R1 = int.Parse(diagr2[i, 1]);
                G1 = int.Parse(diagr2[i, 2]);
                B1 = int.Parse(diagr2[i, 3]);
                SolidBrush mySolidBrush = new SolidBrush(Color.FromArgb(R1, G1, B1));

                if (lenght >= 0)
                {
                    g.FillRectangle(mySolidBrush, width * mn, -lenght, width, Math.Abs(lenght));
                    Label label = new Label();
                    label.Text = lenght.ToString();
                    label.Location = new Point(x0 + width * mn, y0 - lenght - 40);
                    label.Size = new Size(width + 5, 30);
                    this.Controls.Add(label);
                }
                else
                {
                    Label label = new Label();
                    label.Text = lenght.ToString();
                    g.FillRectangle(mySolidBrush, width * mn, 0, width, Math.Abs(lenght));
                    label.Location = new Point(x0 + width * mn, y0 - lenght + 40);
                    label.Size = new Size(width + 5, 30);
                    this.Controls.Add(label);
                }
                mn = mn + 2;
            }

        }
    }
}