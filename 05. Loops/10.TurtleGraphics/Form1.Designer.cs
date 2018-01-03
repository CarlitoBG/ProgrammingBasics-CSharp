namespace TurtleGraphics
{
    partial class FormTurtleGraphics
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.buttonHexagon = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.buttonSpiral = new System.Windows.Forms.Button();
            this.buttonSun = new System.Windows.Forms.Button();
            this.buttonTriangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDraw.Location = new System.Drawing.Point(25, 52);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(111, 37);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = false;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReset.Location = new System.Drawing.Point(25, 107);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(111, 37);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonShowHideTurtle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(25, 161);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(111, 36);
            this.buttonShowHideTurtle.TabIndex = 2;
            this.buttonShowHideTurtle.Text = "Hide Turtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = false;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.buttonShowHideTurtle_Click);
            // 
            // buttonHexagon
            // 
            this.buttonHexagon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHexagon.Location = new System.Drawing.Point(25, 213);
            this.buttonHexagon.Name = "buttonHexagon";
            this.buttonHexagon.Size = new System.Drawing.Size(111, 38);
            this.buttonHexagon.TabIndex = 3;
            this.buttonHexagon.Text = "Hexagon";
            this.buttonHexagon.UseVisualStyleBackColor = true;
            this.buttonHexagon.Click += new System.EventHandler(this.buttonHexagon_Click);
            // 
            // buttonStar
            // 
            this.buttonStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStar.Location = new System.Drawing.Point(25, 267);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(111, 35);
            this.buttonStar.TabIndex = 4;
            this.buttonStar.Text = "Star";
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // buttonSpiral
            // 
            this.buttonSpiral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpiral.Location = new System.Drawing.Point(25, 318);
            this.buttonSpiral.Name = "buttonSpiral";
            this.buttonSpiral.Size = new System.Drawing.Size(111, 37);
            this.buttonSpiral.TabIndex = 5;
            this.buttonSpiral.Text = "Spiral";
            this.buttonSpiral.UseVisualStyleBackColor = true;
            this.buttonSpiral.Click += new System.EventHandler(this.buttonSpiral_Click);
            // 
            // buttonSun
            // 
            this.buttonSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSun.Location = new System.Drawing.Point(25, 372);
            this.buttonSun.Name = "buttonSun";
            this.buttonSun.Size = new System.Drawing.Size(111, 35);
            this.buttonSun.TabIndex = 6;
            this.buttonSun.Text = "Sun";
            this.buttonSun.UseVisualStyleBackColor = true;
            this.buttonSun.Click += new System.EventHandler(this.buttonSun_Click);
            // 
            // buttonTriangle
            // 
            this.buttonTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTriangle.Location = new System.Drawing.Point(25, 422);
            this.buttonTriangle.Name = "buttonTriangle";
            this.buttonTriangle.Size = new System.Drawing.Size(111, 36);
            this.buttonTriangle.TabIndex = 7;
            this.buttonTriangle.Text = "Triangle";
            this.buttonTriangle.UseVisualStyleBackColor = true;
            this.buttonTriangle.Click += new System.EventHandler(this.buttonTriangle_Click);
            // 
            // FormTurtleGraphics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 518);
            this.Controls.Add(this.buttonTriangle);
            this.Controls.Add(this.buttonSun);
            this.Controls.Add(this.buttonSpiral);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.buttonHexagon);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "FormTurtleGraphics";
            this.Text = "Turtle Graphics Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button buttonHexagon;
        private System.Windows.Forms.Button buttonStar;
        private System.Windows.Forms.Button buttonSpiral;
        private System.Windows.Forms.Button buttonSun;
        private System.Windows.Forms.Button buttonTriangle;
    }
}

