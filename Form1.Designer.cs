namespace tic_tac_toe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltop = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblMid = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltop
            // 
            this.lbltop.AutoSize = true;
            this.lbltop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbltop.Font = new System.Drawing.Font("Urdu Typesetting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltop.ForeColor = System.Drawing.Color.Yellow;
            this.lbltop.Location = new System.Drawing.Point(71, 53);
            this.lbltop.Name = "lbltop";
            this.lbltop.Size = new System.Drawing.Size(68, 42);
            this.lbltop.TabIndex = 9;
            this.lbltop.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTurn.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTurn.Location = new System.Drawing.Point(55, 101);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(107, 32);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Tag = "X";
            this.lblTurn.Text = "PlayerX";
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMid.Font = new System.Drawing.Font("Urdu Typesetting", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMid.ForeColor = System.Drawing.Color.Yellow;
            this.lblMid.Location = new System.Drawing.Point(66, 143);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(96, 42);
            this.lblMid.TabIndex = 11;
            this.lblMid.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWinner.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWinner.Location = new System.Drawing.Point(55, 188);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(148, 32);
            this.lblWinner.TabIndex = 12;
            this.lblWinner.Tag = "None";
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestart.Font = new System.Drawing.Font("Times New Roman", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRestart.Location = new System.Drawing.Point(29, 305);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(174, 68);
            this.btnRestart.TabIndex = 13;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Transparent;
            this.pnlGame.Controls.Add(this.btn3);
            this.pnlGame.Controls.Add(this.btn2);
            this.pnlGame.Controls.Add(this.btn1);
            this.pnlGame.Controls.Add(this.btn6);
            this.pnlGame.Controls.Add(this.btn5);
            this.pnlGame.Controls.Add(this.btn4);
            this.pnlGame.Controls.Add(this.btn9);
            this.pnlGame.Controls.Add(this.btn8);
            this.pnlGame.Controls.Add(this.btn7);
            this.pnlGame.Location = new System.Drawing.Point(289, 12);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(439, 404);
            this.pnlGame.TabIndex = 14;
            // 
            // btn7
            // 
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn7.Location = new System.Drawing.Point(16, 274);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(125, 108);
            this.btn7.TabIndex = 9;
            this.btn7.Tag = "?";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btnClick);
            // 
            // btn8
            // 
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn8.Location = new System.Drawing.Point(170, 274);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(125, 108);
            this.btn8.TabIndex = 10;
            this.btn8.Tag = "?";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btnClick);
            // 
            // btn9
            // 
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn9.Location = new System.Drawing.Point(301, 274);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(125, 108);
            this.btn9.TabIndex = 11;
            this.btn9.Tag = "?";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btnClick);
            // 
            // btn4
            // 
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn4.Location = new System.Drawing.Point(16, 131);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(125, 108);
            this.btn4.TabIndex = 12;
            this.btn4.Tag = "?";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btnClick);
            // 
            // btn5
            // 
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn5.Location = new System.Drawing.Point(157, 131);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(125, 108);
            this.btn5.TabIndex = 13;
            this.btn5.Tag = "?";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btnClick);
            // 
            // btn6
            // 
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn6.Location = new System.Drawing.Point(301, 141);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(125, 108);
            this.btn6.TabIndex = 14;
            this.btn6.Tag = "?";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btnClick);
            // 
            // btn1
            // 
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn1.Location = new System.Drawing.Point(16, 3);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(125, 108);
            this.btn1.TabIndex = 15;
            this.btn1.Tag = "?";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btnClick);
            // 
            // btn2
            // 
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn2.Location = new System.Drawing.Point(157, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(125, 108);
            this.btn2.TabIndex = 16;
            this.btn2.Tag = "?";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btnClick);
            // 
            // btn3
            // 
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Image = global::tic_tac_toe.Properties.Resources.question_mark_96;
            this.btn3.Location = new System.Drawing.Point(301, 0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(125, 108);
            this.btn3.TabIndex = 17;
            this.btn3.Tag = "?";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.lblMid);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lbltop);
            this.Controls.Add(this.pnlGame);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Tec Tac Toe";
            this.pnlGame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbltop;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
    }
}

