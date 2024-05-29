namespace BrickBreaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            playground = new Panel();
            brick10 = new PictureBox();
            pictureBox1 = new PictureBox();
            brick8 = new PictureBox();
            brick7 = new PictureBox();
            brick6 = new PictureBox();
            brick5 = new PictureBox();
            pictureBox6 = new PictureBox();
            brick4 = new PictureBox();
            brick3 = new PictureBox();
            brick2 = new PictureBox();
            brick1 = new PictureBox();
            brick = new PictureBox();
            GameOver_lbl = new Label();
            Point_lbl = new Label();
            score_lbl = new Label();
            ball = new PictureBox();
            Racket = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            playground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)brick10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)brick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ball).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Racket).BeginInit();
            SuspendLayout();
            // 
            // playground
            // 
            playground.BackgroundImageLayout = ImageLayout.Center;
            playground.Controls.Add(brick10);
            playground.Controls.Add(pictureBox1);
            playground.Controls.Add(brick8);
            playground.Controls.Add(brick7);
            playground.Controls.Add(brick6);
            playground.Controls.Add(brick5);
            playground.Controls.Add(pictureBox6);
            playground.Controls.Add(brick4);
            playground.Controls.Add(brick3);
            playground.Controls.Add(brick2);
            playground.Controls.Add(brick1);
            playground.Controls.Add(brick);
            playground.Controls.Add(GameOver_lbl);
            playground.Controls.Add(Point_lbl);
            playground.Controls.Add(score_lbl);
            playground.Controls.Add(ball);
            playground.Controls.Add(Racket);
            playground.Dock = DockStyle.Fill;
            playground.Location = new Point(0, 0);
            playground.Name = "playground";
            playground.Size = new Size(1173, 497);
            playground.TabIndex = 0;
            playground.Paint += playground_Paint;
            playground.PreviewKeyDown += playground_PreviewKeyDown;
            // 
            // brick10
            // 
            brick10.BackColor = Color.Maroon;
            brick10.Location = new Point(1000, 220);
            brick10.Name = "brick10";
            brick10.Size = new Size(120, 37);
            brick10.TabIndex = 16;
            brick10.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Maroon;
            pictureBox1.Location = new Point(800, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 37);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // brick8
            // 
            brick8.BackColor = Color.Maroon;
            brick8.Location = new Point(600, 220);
            brick8.Name = "brick8";
            brick8.Size = new Size(120, 37);
            brick8.TabIndex = 14;
            brick8.TabStop = false;
            // 
            // brick7
            // 
            brick7.BackColor = Color.Maroon;
            brick7.Location = new Point(400, 220);
            brick7.Name = "brick7";
            brick7.Size = new Size(120, 37);
            brick7.TabIndex = 13;
            brick7.TabStop = false;
            // 
            // brick6
            // 
            brick6.BackColor = Color.Maroon;
            brick6.Location = new Point(200, 220);
            brick6.Name = "brick6";
            brick6.Size = new Size(120, 37);
            brick6.TabIndex = 12;
            brick6.TabStop = false;
            // 
            // brick5
            // 
            brick5.BackColor = Color.Maroon;
            brick5.Location = new Point(1110, 120);
            brick5.Name = "brick5";
            brick5.Size = new Size(120, 37);
            brick5.TabIndex = 11;
            brick5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Location = new Point(1110, 120);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(120, 37);
            pictureBox6.TabIndex = 10;
            pictureBox6.TabStop = false;
            // 
            // brick4
            // 
            brick4.BackColor = Color.Maroon;
            brick4.Location = new Point(900, 120);
            brick4.Name = "brick4";
            brick4.Size = new Size(120, 37);
            brick4.TabIndex = 9;
            brick4.TabStop = false;
            // 
            // brick3
            // 
            brick3.BackColor = Color.Maroon;
            brick3.Location = new Point(700, 120);
            brick3.Name = "brick3";
            brick3.Size = new Size(120, 37);
            brick3.TabIndex = 8;
            brick3.TabStop = false;
            // 
            // brick2
            // 
            brick2.BackColor = Color.Maroon;
            brick2.Location = new Point(502, 120);
            brick2.Name = "brick2";
            brick2.Size = new Size(120, 37);
            brick2.TabIndex = 7;
            brick2.TabStop = false;
            brick2.Click += brick2_Click;
            // 
            // brick1
            // 
            brick1.BackColor = Color.Maroon;
            brick1.Location = new Point(300, 120);
            brick1.Name = "brick1";
            brick1.Size = new Size(120, 37);
            brick1.TabIndex = 6;
            brick1.TabStop = false;
            // 
            // brick
            // 
            brick.BackColor = Color.Maroon;
            brick.Location = new Point(100, 120);
            brick.Name = "brick";
            brick.Size = new Size(120, 37);
            brick.TabIndex = 5;
            brick.TabStop = false;
            // 
            // GameOver_lbl
            // 
            GameOver_lbl.AutoSize = true;
            GameOver_lbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            GameOver_lbl.Location = new Point(139, 43);
            GameOver_lbl.Name = "GameOver_lbl";
            GameOver_lbl.Size = new Size(257, 260);
            GameOver_lbl.TabIndex = 4;
            GameOver_lbl.Text = "Game over\r\n\r\nF1-Restart\r\nEsc-Exit";
            GameOver_lbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Point_lbl
            // 
            Point_lbl.AutoSize = true;
            Point_lbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            Point_lbl.Location = new Point(141, 0);
            Point_lbl.Name = "Point_lbl";
            Point_lbl.Size = new Size(54, 65);
            Point_lbl.TabIndex = 3;
            Point_lbl.Text = "0";
            // 
            // score_lbl
            // 
            score_lbl.AutoSize = true;
            score_lbl.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            score_lbl.Location = new Point(3, 0);
            score_lbl.Name = "score_lbl";
            score_lbl.Size = new Size(156, 65);
            score_lbl.TabIndex = 2;
            score_lbl.Text = "Score:";
            // 
            // ball
            // 
            ball.BackColor = Color.Blue;
            ball.Location = new Point(21, 85);
            ball.Name = "ball";
            ball.Size = new Size(30, 30);
            ball.TabIndex = 1;
            ball.TabStop = false;
            // 
            // Racket
            // 
            Racket.BackColor = Color.Black;
            Racket.Location = new Point(422, 351);
            Racket.Name = "Racket";
            Racket.Size = new Size(150, 20);
            Racket.TabIndex = 0;
            Racket.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 497);
            Controls.Add(playground);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            playground.ResumeLayout(false);
            playground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)brick10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick8).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick7).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick6).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick4).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick3).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick2).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick1).EndInit();
            ((System.ComponentModel.ISupportInitialize)brick).EndInit();
            ((System.ComponentModel.ISupportInitialize)ball).EndInit();
            ((System.ComponentModel.ISupportInitialize)Racket).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel playground;
        private PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private Label score_lbl;
        private PictureBox Racket;
        private Label Point_lbl;
        private Label GameOver_lbl;
        private PictureBox brick1;
        private PictureBox brick;
        private PictureBox pictureBox6;
        private PictureBox brick4;
        private PictureBox brick3;
        private PictureBox brick2;
        private PictureBox brick5;
        private PictureBox brick7;
        private PictureBox brick6;
        private PictureBox brick10;
        private PictureBox pictureBox1;
        private PictureBox brick8;
    }
}