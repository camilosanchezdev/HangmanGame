namespace UTNHangman
{
    partial class Hangout
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Horca = new System.Windows.Forms.PictureBox();
            this.testLetter = new System.Windows.Forms.TextBox();
            this.btnTry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.letra1 = new System.Windows.Forms.Label();
            this.letra2 = new System.Windows.Forms.Label();
            this.letra3 = new System.Windows.Forms.Label();
            this.letra4 = new System.Windows.Forms.Label();
            this.gameOver = new System.Windows.Forms.Label();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Horca)).BeginInit();
            this.SuspendLayout();
            // 
            // Horca
            // 
            this.Horca.BackColor = System.Drawing.Color.SeaGreen;
            this.Horca.Image = global::UTNHangman.Properties.Resources.img1;
            this.Horca.Location = new System.Drawing.Point(366, 50);
            this.Horca.Name = "Horca";
            this.Horca.Size = new System.Drawing.Size(262, 356);
            this.Horca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Horca.TabIndex = 0;
            this.Horca.TabStop = false;
            // 
            // testLetter
            // 
            this.testLetter.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.testLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLetter.Location = new System.Drawing.Point(119, 298);
            this.testLetter.MaxLength = 1;
            this.testLetter.Name = "testLetter";
            this.testLetter.Size = new System.Drawing.Size(33, 38);
            this.testLetter.TabIndex = 1;
            this.testLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnTry
            // 
            this.btnTry.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnTry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTry.Location = new System.Drawing.Point(172, 298);
            this.btnTry.Name = "btnTry";
            this.btnTry.Size = new System.Drawing.Size(107, 37);
            this.btnTry.TabIndex = 2;
            this.btnTry.Text = "TRY";
            this.btnTry.UseVisualStyleBackColor = false;
            this.btnTry.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 73);
            this.label2.TabIndex = 4;
            this.label2.Text = "_ _ _ _";
            // 
            // letra1
            // 
            this.letra1.AutoSize = true;
            this.letra1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letra1.ForeColor = System.Drawing.Color.White;
            this.letra1.Location = new System.Drawing.Point(103, 120);
            this.letra1.Name = "letra1";
            this.letra1.Size = new System.Drawing.Size(49, 46);
            this.letra1.TabIndex = 6;
            this.letra1.Text = "H";
            this.letra1.Visible = false;
            // 
            // letra2
            // 
            this.letra2.AutoSize = true;
            this.letra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letra2.ForeColor = System.Drawing.Color.White;
            this.letra2.Location = new System.Drawing.Point(158, 120);
            this.letra2.Name = "letra2";
            this.letra2.Size = new System.Drawing.Size(51, 46);
            this.letra2.TabIndex = 7;
            this.letra2.Text = "O";
            this.letra2.Visible = false;
            // 
            // letra3
            // 
            this.letra3.AutoSize = true;
            this.letra3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letra3.ForeColor = System.Drawing.Color.White;
            this.letra3.Location = new System.Drawing.Point(211, 120);
            this.letra3.Name = "letra3";
            this.letra3.Size = new System.Drawing.Size(53, 46);
            this.letra3.TabIndex = 8;
            this.letra3.Text = "M";
            this.letra3.Visible = false;
            // 
            // letra4
            // 
            this.letra4.AutoSize = true;
            this.letra4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.letra4.ForeColor = System.Drawing.Color.White;
            this.letra4.Location = new System.Drawing.Point(264, 120);
            this.letra4.Name = "letra4";
            this.letra4.Size = new System.Drawing.Size(47, 46);
            this.letra4.TabIndex = 9;
            this.letra4.Text = "E";
            this.letra4.Visible = false;
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOver.ForeColor = System.Drawing.Color.White;
            this.gameOver.Location = new System.Drawing.Point(65, 36);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(0, 46);
            this.gameOver.TabIndex = 10;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnPlayAgain.Enabled = false;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgain.Location = new System.Drawing.Point(119, 369);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(160, 45);
            this.btnPlayAgain.TabIndex = 11;
            this.btnPlayAgain.Text = "Play again";
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // Hangout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(640, 450);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.gameOver);
            this.Controls.Add(this.letra4);
            this.Controls.Add(this.letra3);
            this.Controls.Add(this.letra2);
            this.Controls.Add(this.letra1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTry);
            this.Controls.Add(this.testLetter);
            this.Controls.Add(this.Horca);
            this.Name = "Hangout";
            this.Text = "Hangout";
            ((System.ComponentModel.ISupportInitialize)(this.Horca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Horca;
        private System.Windows.Forms.TextBox testLetter;
        private System.Windows.Forms.Button btnTry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label letra1;
        private System.Windows.Forms.Label letra2;
        private System.Windows.Forms.Label letra3;
        private System.Windows.Forms.Label letra4;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.Button btnPlayAgain;
    }
}

