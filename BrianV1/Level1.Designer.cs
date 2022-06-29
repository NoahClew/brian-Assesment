
namespace BrianV1
{
    partial class Level1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level1));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picNextLevel = new System.Windows.Forms.PictureBox();
            this.picTut = new System.Windows.Forms.PictureBox();
            this.picNot = new System.Windows.Forms.PictureBox();
            this.picBounc = new System.Windows.Forms.PictureBox();
            this.picSpring1 = new System.Windows.Forms.PictureBox();
            this.picDang = new System.Windows.Forms.PictureBox();
            this.picFloor1 = new System.Windows.Forms.PictureBox();
            this.tmrColl = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNdeaths = new System.Windows.Forms.Label();
            this.lblDeath = new System.Windows.Forms.Label();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBounc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpring1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloor1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.screen.Controls.Add(this.picPlayer);
            this.screen.Controls.Add(this.picNextLevel);
            this.screen.Controls.Add(this.picTut);
            this.screen.Controls.Add(this.picNot);
            this.screen.Controls.Add(this.picBounc);
            this.screen.Controls.Add(this.picSpring1);
            this.screen.Controls.Add(this.picDang);
            this.screen.Controls.Add(this.picFloor1);
            this.screen.Location = new System.Drawing.Point(0, 26);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(800, 424);
            this.screen.TabIndex = 3;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Black;
            this.picPlayer.Location = new System.Drawing.Point(43, 320);
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
            // picTut
            // 
            this.picTut.Image = global::BrianV1.Properties.Resources.f53da492d29d6afd2f4260f2b1b163cd;
            this.picTut.Location = new System.Drawing.Point(12, 28);
            this.picTut.Name = "picTut";
            this.picTut.Size = new System.Drawing.Size(547, 84);
            this.picTut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTut.TabIndex = 48;
            this.picTut.TabStop = false;
            // 
            // picNot
            // 
            this.picNot.Image = ((System.Drawing.Image)(resources.GetObject("picNot.Image")));
            this.picNot.Location = new System.Drawing.Point(352, 206);
            this.picNot.Name = "picNot";
            this.picNot.Size = new System.Drawing.Size(105, 60);
            this.picNot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNot.TabIndex = 47;
            this.picNot.TabStop = false;
            // 
            // picBounc
            // 
            this.picBounc.Image = ((System.Drawing.Image)(resources.GetObject("picBounc.Image")));
            this.picBounc.Location = new System.Drawing.Point(195, 254);
            this.picBounc.Name = "picBounc";
            this.picBounc.Size = new System.Drawing.Size(151, 46);
            this.picBounc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBounc.TabIndex = 46;
            this.picBounc.TabStop = false;
            // 
            // picSpring1
            // 
            this.picSpring1.Image = global::BrianV1.Properties.Resources.springboardDown;
            this.picSpring1.Location = new System.Drawing.Point(255, 304);
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
            this.lblDeath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeath.Location = new System.Drawing.Point(3, 3);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(67, 18);
            this.lblDeath.TabIndex = 49;
            this.lblDeath.Text = "Deaths : ";
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.screen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level1";
            this.Text = "Tutorial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBounc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSpring1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloor1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.PictureBox picTut;
        private System.Windows.Forms.PictureBox picNot;
        private System.Windows.Forms.PictureBox picBounc;
        private System.Windows.Forms.PictureBox picNextLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNdeaths;
        private System.Windows.Forms.Label lblDeath;
    }
}

