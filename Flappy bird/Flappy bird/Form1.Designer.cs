namespace Flappy_bird
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.downerPipe = new System.Windows.Forms.PictureBox();
            this.upperPipe = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.sky = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.downerPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Score : 0";
            // 
            // downerPipe
            // 
            this.downerPipe.Image = ((System.Drawing.Image)(resources.GetObject("downerPipe.Image")));
            this.downerPipe.Location = new System.Drawing.Point(613, 402);
            this.downerPipe.Name = "downerPipe";
            this.downerPipe.Size = new System.Drawing.Size(100, 273);
            this.downerPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.downerPipe.TabIndex = 1;
            this.downerPipe.TabStop = false;
            // 
            // upperPipe
            // 
            this.upperPipe.Image = ((System.Drawing.Image)(resources.GetObject("upperPipe.Image")));
            this.upperPipe.Location = new System.Drawing.Point(420, -15);
            this.upperPipe.Name = "upperPipe";
            this.upperPipe.Size = new System.Drawing.Size(100, 225);
            this.upperPipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.upperPipe.TabIndex = 2;
            this.upperPipe.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-12, 620);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(821, 112);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(74, 222);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.flappyBird.Size = new System.Drawing.Size(86, 78);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 4;
            this.flappyBird.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // sky
            // 
            this.sky.Location = new System.Drawing.Point(0, 0);
            this.sky.Name = "sky";
            this.sky.Size = new System.Drawing.Size(811, 10);
            this.sky.TabIndex = 5;
            this.sky.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 716);
            this.Controls.Add(this.upperPipe);
            this.Controls.Add(this.sky);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.downerPipe);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "  Flappy bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.downerPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sky)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox downerPipe;
        private System.Windows.Forms.PictureBox upperPipe;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox sky;
    }
}

