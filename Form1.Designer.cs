namespace ticTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel2 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            btnNewGame = new Button();
            btnReset = new Button();
            btnExit = new Button();
            panel6 = new Panel();
            label3 = new Label();
            lblPlayerO = new Label();
            lblPlayerX = new Label();
            label2 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            btn9 = new Button();
            btn6 = new Button();
            btn3 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn2 = new Button();
            btn7 = new Button();
            btn4 = new Button();
            btn1 = new Button();
            label1 = new Label();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(12, 75);
            panel2.Name = "panel2";
            panel2.Size = new Size(1288, 646);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Location = new Point(658, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(623, 625);
            panel5.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.Fixed3D;
            panel7.Controls.Add(btnNewGame);
            panel7.Controls.Add(btnReset);
            panel7.Controls.Add(btnExit);
            panel7.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            panel7.Location = new Point(3, 294);
            panel7.Name = "panel7";
            panel7.Size = new Size(613, 314);
            panel7.TabIndex = 0;
            // 
            // btnNewGame
            // 
            btnNewGame.BackColor = SystemColors.ButtonFace;
            btnNewGame.Font = new Font("Ink Free", 47.9999962F, FontStyle.Bold);
            btnNewGame.Location = new Point(5, 19);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(598, 134);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = false;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.ButtonFace;
            btnReset.Font = new Font("Ink Free", 47.9999962F, FontStyle.Bold);
            btnReset.Location = new Point(5, 164);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(296, 142);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ButtonFace;
            btnExit.Font = new Font("Ink Free", 47.9999962F, FontStyle.Bold);
            btnExit.Location = new Point(307, 163);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(296, 142);
            btnExit.TabIndex = 0;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel6
            // 
            panel6.BorderStyle = BorderStyle.Fixed3D;
            panel6.Controls.Add(label3);
            panel6.Controls.Add(lblPlayerO);
            panel6.Controls.Add(lblPlayerX);
            panel6.Controls.Add(label2);
            panel6.Font = new Font("Ink Free", 47.9999962F, FontStyle.Bold);
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(613, 285);
            panel6.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(39, 154);
            label3.Name = "label3";
            label3.Size = new Size(205, 58);
            label3.TabIndex = 0;
            label3.Text = "Player 0:";
            // 
            // lblPlayerO
            // 
            lblPlayerO.BackColor = Color.White;
            lblPlayerO.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerO.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerO.ForeColor = SystemColors.ActiveCaptionText;
            lblPlayerO.Location = new Point(307, 154);
            lblPlayerO.Name = "lblPlayerO";
            lblPlayerO.Size = new Size(199, 58);
            lblPlayerO.TabIndex = 0;
            lblPlayerO.Text = "0";
            lblPlayerO.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPlayerX
            // 
            lblPlayerX.BackColor = Color.White;
            lblPlayerX.BorderStyle = BorderStyle.Fixed3D;
            lblPlayerX.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlayerX.ForeColor = SystemColors.ActiveCaptionText;
            lblPlayerX.Location = new Point(307, 56);
            lblPlayerX.Name = "lblPlayerX";
            lblPlayerX.Size = new Size(199, 58);
            lblPlayerX.TabIndex = 0;
            lblPlayerX.Text = "0";
            lblPlayerX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ink Free", 28.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(39, 56);
            label2.Name = "label2";
            label2.Size = new Size(196, 58);
            label2.TabIndex = 0;
            label2.Text = "Player X:";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Location = new Point(658, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(623, 625);
            panel4.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(btn9);
            panel3.Controls.Add(btn6);
            panel3.Controls.Add(btn3);
            panel3.Controls.Add(btn8);
            panel3.Controls.Add(btn5);
            panel3.Controls.Add(btn2);
            panel3.Controls.Add(btn7);
            panel3.Controls.Add(btn4);
            panel3.Controls.Add(btn1);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(649, 625);
            panel3.TabIndex = 0;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ButtonFace;
            btn9.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn9.Location = new Point(424, 417);
            btn9.Name = "btn9";
            btn9.Size = new Size(200, 200);
            btn9.TabIndex = 0;
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ButtonFace;
            btn6.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn6.Location = new Point(424, 213);
            btn6.Name = "btn6";
            btn6.Size = new Size(200, 200);
            btn6.TabIndex = 0;
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ButtonFace;
            btn3.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn3.Location = new Point(424, 6);
            btn3.Name = "btn3";
            btn3.Size = new Size(200, 200);
            btn3.TabIndex = 0;
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ButtonFace;
            btn8.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn8.Location = new Point(218, 418);
            btn8.Name = "btn8";
            btn8.Size = new Size(200, 200);
            btn8.TabIndex = 0;
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ButtonFace;
            btn5.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn5.Location = new Point(218, 212);
            btn5.Name = "btn5";
            btn5.Size = new Size(200, 200);
            btn5.TabIndex = 0;
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ButtonFace;
            btn2.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn2.Location = new Point(218, 6);
            btn2.Name = "btn2";
            btn2.Size = new Size(200, 200);
            btn2.TabIndex = 0;
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ButtonFace;
            btn7.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn7.Location = new Point(12, 418);
            btn7.Name = "btn7";
            btn7.Size = new Size(200, 200);
            btn7.TabIndex = 0;
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ButtonFace;
            btn4.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn4.Location = new Point(12, 212);
            btn4.Name = "btn4";
            btn4.Size = new Size(200, 200);
            btn4.TabIndex = 0;
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ButtonFace;
            btn1.Font = new Font("Segoe UI Symbol", 28.2F, FontStyle.Bold);
            btn1.Location = new Point(12, 5);
            btn1.Name = "btn1";
            btn1.Size = new Size(200, 200);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Snap ITC", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(527, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 48);
            label1.TabIndex = 1;
            label1.Text = "Tic Tae Toe";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(1312, 733);
            Controls.Add(label1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tic Tac Toe";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Button btn1;
        private Button btn3;
        private Button btn2;
        private Button btn9;
        private Button btn6;
        private Button btn8;
        private Button btn5;
        private Button btn7;
        private Button btn4;
        private Button btnReset;
        private Button btnExit;
        private Button btnNewGame;
        private Label label2;
        private Label label3;
        private Label lblPlayerO;
        private Label lblPlayerX;
        private Label label1;
    }
}
