
namespace BrianV1
{
    partial class Level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.tmrColl = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNdeaths = new System.Windows.Forms.Label();
            this.lblDeath = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picNextLevel = new System.Windows.Forms.PictureBox();
            this.picSpring1 = new System.Windows.Forms.PictureBox();
            this.picDang = new System.Windows.Forms.PictureBox();
            this.picFloor1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpring1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrMove
            // 
            this.tmrMove.Enabled = true;
            this.tmrMove.Interval = 1;
            this.tmrMove.Tick += new System.EventHandler(this.tmrMove_Tick);
            // 
            // screen
            // 
            this.screen.Controls.Add(this.pictureBox2);
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.picPlayer);
            this.screen.Controls.Add(this.picNextLevel);
            this.screen.Controls.Add(this.picSpring1);
            this.screen.Controls.Add(this.picDang);
            this.screen.Controls.Add(this.picFloor1);
            this.screen.Location = new System.Drawing.Point(0, 26);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(800, 424);
            this.screen.TabIndex = 3;
            // 
            // tmrColl
            // 
            this.tmrColl.Enabled = true;
            this.tmrColl.Interval = 1;
            this.tmrColl.Tick += new System.EventHandler(this.tmrColl_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblNdeaths);
            this.panel1.Controls.Add(this.lblDeath);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 20);
            this.panel1.TabIndex = 49;
            // 
            // lblNdeaths
            // 
            this.lblNdeaths.AutoSize = true;
            this.lblNdeaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdeaths.Location = new System.Drawing.Point(59, 2);
            this.lblNdeaths.Name = "lblNdeaths";
            this.lblNdeaths.Size = new System.Drawing.Size(16, 18);
            this.lblNdeaths.TabIndex = 50;
            this.lblNdeaths.Text = "0";
            // 
            // lblDeath
            // 
            this.lblDeath.AutoSize = true;
            this.lblDeath.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeath.Location = new System.Drawing.Point(3, 3);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(61, 17);
            this.lblDeath.TabIndex = 49;
            this.lblDeath.Text = "Deaths : ";
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Black;
            this.picPlayer.Location = new System.Drawing.Point(73, 118);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(32, 32);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            this.picPlayer.Tag = "";
            // 
            // picNextLevel
            // 
            this.picNextLevel.Location = new System.Drawing.Point(777, 48);
            this.picNextLevel.Name = "picNextLevel";
            this.picNextLevel.Size = new System.Drawing.Size(23, 306);
            this.picNextLevel.TabIndex = 4;
            this.picNextLevel.TabStop = false;
            // 
            // picSpring1
            // 
            this.picSpring1.Image = global::BrianV1.Properties.Resources.springboardDown;
            this.picSpring1.Location = new System.Drawing.Point(320, 304);
            this.picSpring1.Name = "picSpring1";
            this.picSpring1.Size = new System.Drawing.Size(42, 48);
            this.picSpring1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSpring1.TabIndex = 45;
            this.picSpring1.TabStop = false;
            this.picSpring1.Tag = "spring";
            // 
            // picDang
            // 
            this.picDang.Image = ((System.Drawing.Image)(resources.GetObject("picDang.Image")));
            this.picDang.Location = new System.Drawing.Point(368, 282);
            this.picDang.Name = "picDang";
            this.picDang.Size = new System.Drawing.Size(70, 70);
            this.picDang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDang.TabIndex = 44;
            this.picDang.TabStop = false;
            this.picDang.Tag = "danger";
            // 
            // picFloor1
            // 
            this.picFloor1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFloor1.BackgroundImage")));
            this.picFloor1.Image = ((System.Drawing.Image)(resources.GetObject("picFloor1.Image")));
            this.picFloor1.Location = new System.Drawing.Point(-43, 353);
            this.picFloor1.Name = "picFloor1";
            this.picFloor1.Size = new System.Drawing.Size(908, 71);
            this.picFloor1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFloor1.TabIndex = 43;
            this.picFloor1.TabStop = false;
            this.picFloor1.Tag = "collide";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(368, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "danger";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(368, 142);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "danger";
            // 
            // Level2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.screen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level2";
            this.Text = "Level 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpring1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox picFloor1;
        private System.Windows.Forms.Timer tmrColl;
        private System.Windows.Forms.PictureBox picDang;
        private System.Windows.Forms.PictureBox picSpring1;
        private System.Windows.Forms.PictureBox picNextLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNdeaths;
        private System.Windows.Forms.Label lblDeath;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

