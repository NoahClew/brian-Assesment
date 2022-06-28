
namespace BrianV1
{
    partial class Level4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level4));
            this.tmrMove = new System.Windows.Forms.Timer(this.components);
            this.screen = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picNextLevel = new System.Windows.Forms.PictureBox();
            this.picDang = new System.Windows.Forms.PictureBox();
            this.picFloor1 = new System.Windows.Forms.PictureBox();
            this.tmrColl = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNdeaths = new System.Windows.Forms.Label();
            this.lblDeath = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloor1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            this.screen.Controls.Add(this.pictureBox8);
            this.screen.Controls.Add(this.pictureBox9);
            this.screen.Controls.Add(this.pictureBox6);
            this.screen.Controls.Add(this.pictureBox7);
            this.screen.Controls.Add(this.pictureBox4);
            this.screen.Controls.Add(this.pictureBox3);
            this.screen.Controls.Add(this.pictureBox1);
            this.screen.Controls.Add(this.picPlayer);
            this.screen.Controls.Add(this.picNextLevel);
            this.screen.Controls.Add(this.picDang);
            this.screen.Controls.Add(this.picFloor1);
            this.screen.Location = new System.Drawing.Point(0, 26);
            this.screen.Name = "screen";
            this.screen.Size = new System.Drawing.Size(800, 424);
            this.screen.TabIndex = 3;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(359, 284);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(70, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "danger";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(359, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "danger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 214);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "danger";
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
            // picDang
            // 
            this.picDang.Image = ((System.Drawing.Image)(resources.GetObject("picDang.Image")));
            this.picDang.Location = new System.Drawing.Point(216, 284);
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
            this.lblDeath.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeath.Location = new System.Drawing.Point(3, 3);
            this.lblDeath.Name = "lblDeath";
            this.lblDeath.Size = new System.Drawing.Size(61, 17);
            this.lblDeath.TabIndex = 49;
            this.lblDeath.Text = "Deaths : ";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(502, 284);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(70, 70);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 53;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "danger";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(502, 214);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(70, 70);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 52;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "danger";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(642, 284);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(70, 70);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 55;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "danger";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(642, 214);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(70, 70);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox9.TabIndex = 54;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "danger";
            // 
            // Level4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.screen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Level4";
            this.Text = "Level 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.screen.ResumeLayout(false);
            this.screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNextLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFloor1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Timer tmrMove;
        private System.Windows.Forms.Panel screen;
        private System.Windows.Forms.PictureBox picFloor1;
        private System.Windows.Forms.Timer tmrColl;
        private System.Windows.Forms.PictureBox picDang;
        private System.Windows.Forms.PictureBox picNextLevel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNdeaths;
        private System.Windows.Forms.Label lblDeath;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

