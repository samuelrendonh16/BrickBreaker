/*namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        private int speed_left = 4; // Velocidad de la bola
        private int speed_top = 4;
        private int points = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            timer1.Interval = 20;  // Configura el intervalo del temporizador
            timer1.Tick += new EventHandler(timer1_Tick);  // Conecta el evento Tick
            timer1.Enabled = true; // Habilita el temporizador
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None; // Remueve cualquier borde
            this.TopMost = true; // Coloca la ventana encima de otras ventanas
            this.Bounds = Screen.PrimaryScreen.Bounds; // Hace que ocupe toda la pantalla

            // Coloca la raqueta en la posición inicial
            Racket.Top = playground.Bottom - (playground.Bottom / 10);
            Racket.Left = (playground.Width / 2) - (Racket.Width / 2);

            GameOver_lbl.Left = (playground.Width / 2) - (GameOver_lbl.Width / 2);
            GameOver_lbl.Top = (playground.Height / 2) - (GameOver_lbl.Height / 2);
            GameOver_lbl.Visible = false;

            // Coloca la bola en la posición inicial
            ball.Left = (playground.Width / 2) - (ball.Width / 2);
            ball.Top = playground.Height / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mueve la raqueta
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);

            // Mueve la bola
            ball.Left += speed_left;
            ball.Top += speed_top;

            // Colisión de la bola con la raqueta
            if (ball.Bottom >= Racket.Top && ball.Bottom <= Racket.Bottom && ball.Left >= Racket.Left && ball.Right <= Racket.Right)
            {
                speed_top = -speed_top;
                points += 1;
                Point_lbl.Text = points.ToString();

                Random rnd = new Random();
                playground.BackColor = Color.FromArgb(rnd.Next(150, 255), rnd.Next(150, 255), rnd.Next(150, 255));

                // Incrementa la velocidad con un límite
                if (Math.Abs(speed_top) < 20 && Math.Abs(speed_left) < 20)
                {
                    speed_top += (speed_top > 0) ? 2 : -2;
                    speed_left += (speed_left > 0) ? 2 : -2;

                }
            }

            // Colisión de la bola con las paredes
            if (ball.Left <= playground.Left || ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            // Si la bola toca la parte inferior del playground, termina el juego
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                GameOver_lbl.Visible = true;
            }
        }

        private void playground_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } // Presionar la tecla Esc para abandonar
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                Point_lbl.Text = "0";
                timer1.Enabled = true;
                GameOver_lbl.Visible = false;

            }

        }

        private void brick2_Click(object sender, EventArgs e)
        {

        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }
       
    }
}
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        private int speed_left = 4; // Velocidad de la bola
        private int speed_top = 4;
        private int points = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            timer1.Interval = 20;  // Configura el intervalo del temporizador
            timer1.Tick += new EventHandler(timer1_Tick);  // Conecta el evento Tick
            timer1.Enabled = true; // Habilita el temporizador
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None; // Remueve cualquier borde
            this.TopMost = true; // Coloca la ventana encima de otras ventanas
            this.Bounds = Screen.PrimaryScreen.Bounds; // Hace que ocupe toda la pantalla

            // Coloca la raqueta en la posición inicial
            Racket.Top = playground.Bottom - (playground.Bottom / 10);
            Racket.Left = (playground.Width / 2) - (Racket.Width / 2);

            GameOver_lbl.Left = (playground.Width / 2) - (GameOver_lbl.Width / 2);
            GameOver_lbl.Top = (playground.Height / 2) - (GameOver_lbl.Height / 2);
            GameOver_lbl.Visible = false;

            // Coloca la bola en la posición inicial
            ball.Left = (playground.Width / 2) - (ball.Width / 2);
            ball.Top = playground.Height / 2;

            // Inicializar los bloques
            InitializeBricks();
        }

        private void InitializeBricks()
        {
            // Asegúrate de que todos los bloques estén visibles al inicio del juego
            brick.Visible = true;
            brick1.Visible = true;
            brick2.Visible = true;
            brick3.Visible = true;
            brick4.Visible = true;
            brick5.Visible = true;
            brick6.Visible = true;
            brick7.Visible = true;
            brick8.Visible = true;
            brick10.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Mueve la raqueta
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);

            // Mueve la bola
            ball.Left += speed_left;
            ball.Top += speed_top;

            // Colisión de la bola con la raqueta
            if (ball.Bottom >= Racket.Top && ball.Bottom <= Racket.Bottom && ball.Left >= Racket.Left && ball.Right <= Racket.Right)
            {
                speed_top = -speed_top;
                points += 1;
                Point_lbl.Text = points.ToString();

                Random rnd = new Random();
                playground.BackColor = Color.FromArgb(rnd.Next(150, 255), rnd.Next(150, 255), rnd.Next(150, 255));

                // Incrementa la velocidad con un límite
                if (Math.Abs(speed_top) < 20 && Math.Abs(speed_left) < 20)
                {
                    speed_top += (speed_top > 0) ? 2 : -2;
                    speed_left += (speed_left > 0) ? 2 : -2;
                }
            }

            // Colisión de la bola con las paredes
            if (ball.Left <= playground.Left || ball.Right >= playground.Right)
            {
                speed_left = -speed_left;
            }

            if (ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }

            // Si la bola toca la parte inferior del playground, termina el juego
            if (ball.Bottom >= playground.Bottom)
            {
                timer1.Enabled = false;
                GameOver_lbl.Visible = true;
            }

            // Colisión de la bola con los bloques
            CheckBrickCollision(brick);
            CheckBrickCollision(brick1);
            CheckBrickCollision(brick2);
            CheckBrickCollision(brick3);
            CheckBrickCollision(brick4);
            CheckBrickCollision(brick5);
            CheckBrickCollision(brick6);
            CheckBrickCollision(brick7);
            CheckBrickCollision(brick8);
            CheckBrickCollision(brick10);
        }

        private void CheckBrickCollision(PictureBox brick)
        {
            if (brick.Visible && ball.Bounds.IntersectsWith(brick.Bounds))
            {
                speed_top = -speed_top;
                brick.Visible = false; // Eliminar el bloque
                points += 5;
                Point_lbl.Text = points.ToString();
            }
        }

        private void playground_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { this.Close(); } // Presionar la tecla Esc para abandonar
            if (e.KeyCode == Keys.F1)
            {
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                Point_lbl.Text = "0";
                timer1.Enabled = true;
                GameOver_lbl.Visible = false;
                InitializeBricks(); // Reiniciar bloques
            }
        }

        private void brick2_Click(object sender, EventArgs e)
        {

        }

        private void playground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

