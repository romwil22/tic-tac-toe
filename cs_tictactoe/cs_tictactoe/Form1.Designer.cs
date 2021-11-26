
namespace cs_tictactoe
{
    partial class tictactoe
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
            if (disposing && (components != null))
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
            this.tictactoeLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.box9 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.player1Score = new System.Windows.Forms.Label();
            this.player2Score = new System.Windows.Forms.Label();
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tictactoeLabel
            // 
            this.tictactoeLabel.AutoSize = true;
            this.tictactoeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tictactoeLabel.ForeColor = System.Drawing.Color.Black;
            this.tictactoeLabel.Location = new System.Drawing.Point(224, 0);
            this.tictactoeLabel.Name = "tictactoeLabel";
            this.tictactoeLabel.Size = new System.Drawing.Size(216, 42);
            this.tictactoeLabel.TabIndex = 0;
            this.tictactoeLabel.Text = "Tic Tac Toe";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tictactoeLabel);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 46);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.box9);
            this.panel2.Controls.Add(this.box8);
            this.panel2.Controls.Add(this.box7);
            this.panel2.Controls.Add(this.box6);
            this.panel2.Controls.Add(this.box5);
            this.panel2.Controls.Add(this.box4);
            this.panel2.Controls.Add(this.box3);
            this.panel2.Controls.Add(this.box2);
            this.panel2.Controls.Add(this.box1);
            this.panel2.Location = new System.Drawing.Point(198, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 368);
            this.panel2.TabIndex = 2;
            // 
            // box9
            // 
            this.box9.BackColor = System.Drawing.Color.LightGray;
            this.box9.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box9.Location = new System.Drawing.Point(310, 245);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(140, 115);
            this.box9.TabIndex = 8;
            this.box9.UseVisualStyleBackColor = false;
            this.box9.Click += new System.EventHandler(this.box9_Click);
            // 
            // box8
            // 
            this.box8.BackColor = System.Drawing.Color.LightGray;
            this.box8.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box8.Location = new System.Drawing.Point(164, 245);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(140, 115);
            this.box8.TabIndex = 7;
            this.box8.UseVisualStyleBackColor = false;
            this.box8.Click += new System.EventHandler(this.box8_Click);
            // 
            // box7
            // 
            this.box7.BackColor = System.Drawing.Color.LightGray;
            this.box7.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box7.Location = new System.Drawing.Point(18, 245);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(140, 115);
            this.box7.TabIndex = 6;
            this.box7.UseVisualStyleBackColor = false;
            this.box7.Click += new System.EventHandler(this.box7_Click);
            // 
            // box6
            // 
            this.box6.BackColor = System.Drawing.Color.LightGray;
            this.box6.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box6.Location = new System.Drawing.Point(310, 125);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(140, 115);
            this.box6.TabIndex = 5;
            this.box6.UseVisualStyleBackColor = false;
            this.box6.Click += new System.EventHandler(this.box6_Click);
            // 
            // box5
            // 
            this.box5.BackColor = System.Drawing.Color.LightGray;
            this.box5.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box5.Location = new System.Drawing.Point(163, 125);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(140, 115);
            this.box5.TabIndex = 4;
            this.box5.UseVisualStyleBackColor = false;
            this.box5.Click += new System.EventHandler(this.box5_Click);
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.Color.LightGray;
            this.box4.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box4.Location = new System.Drawing.Point(18, 124);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(140, 115);
            this.box4.TabIndex = 3;
            this.box4.UseVisualStyleBackColor = false;
            this.box4.Click += new System.EventHandler(this.box4_Click);
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.LightGray;
            this.box3.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box3.Location = new System.Drawing.Point(310, 3);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(140, 115);
            this.box3.TabIndex = 2;
            this.box3.UseVisualStyleBackColor = false;
            this.box3.Click += new System.EventHandler(this.box3_Click);
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.LightGray;
            this.box2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box2.Location = new System.Drawing.Point(164, 3);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(140, 115);
            this.box2.TabIndex = 1;
            this.box2.UseVisualStyleBackColor = false;
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.LightGray;
            this.box1.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box1.Location = new System.Drawing.Point(18, 3);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(140, 115);
            this.box1.TabIndex = 0;
            this.box1.UseVisualStyleBackColor = false;
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.exitButton);
            this.panel3.Controls.Add(this.resetButton);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.newGameButton);
            this.panel3.Location = new System.Drawing.Point(12, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 368);
            this.panel3.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(8, 285);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(162, 56);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(8, 223);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(162, 56);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.player1Score);
            this.panel4.Controls.Add(this.player2Score);
            this.panel4.Controls.Add(this.player1);
            this.panel4.Controls.Add(this.player2);
            this.panel4.Location = new System.Drawing.Point(8, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(162, 123);
            this.panel4.TabIndex = 7;
            // 
            // player1Score
            // 
            this.player1Score.BackColor = System.Drawing.SystemColors.Menu;
            this.player1Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Score.Location = new System.Drawing.Point(101, 36);
            this.player1Score.Name = "player1Score";
            this.player1Score.Size = new System.Drawing.Size(54, 29);
            this.player1Score.TabIndex = 2;
            this.player1Score.Text = "0";
            this.player1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player2Score
            // 
            this.player2Score.BackColor = System.Drawing.SystemColors.Menu;
            this.player2Score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Score.Location = new System.Drawing.Point(101, 83);
            this.player2Score.Name = "player2Score";
            this.player2Score.Size = new System.Drawing.Size(54, 29);
            this.player2Score.TabIndex = 6;
            this.player2Score.Text = "0";
            this.player2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1.Location = new System.Drawing.Point(-1, 34);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(106, 29);
            this.player1.TabIndex = 1;
            this.player1.Text = "Player 1:";
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2.Location = new System.Drawing.Point(-1, 81);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(106, 29);
            this.player2.TabIndex = 5;
            this.player2.Text = "Player 2:";
            // 
            // newGameButton
            // 
            this.newGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.Location = new System.Drawing.Point(8, 161);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(162, 56);
            this.newGameButton.TabIndex = 0;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // tictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(681, 435);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "tictactoe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.tictactoe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label tictactoeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button box9;
        private System.Windows.Forms.Button box8;
        private System.Windows.Forms.Button box7;
        private System.Windows.Forms.Button box6;
        private System.Windows.Forms.Button box5;
        private System.Windows.Forms.Button box4;
        private System.Windows.Forms.Button box3;
        private System.Windows.Forms.Button box2;
        private System.Windows.Forms.Button box1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Label player2Score;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label player1Score;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetButton;
    }
}

