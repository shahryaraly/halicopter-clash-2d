namespace HalicopterGame
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
            this.timr_bg = new System.Windows.Forms.Timer(this.components);
            this.timr_enemy = new System.Windows.Forms.Timer(this.components);
            this.timr_fire = new System.Windows.Forms.Timer(this.components);
            this.lbl_fire = new System.Windows.Forms.Label();
            this.lbl_enemy1 = new System.Windows.Forms.Label();
            this.lbl_enemy2 = new System.Windows.Forms.Label();
            this.lbl_enemy6 = new System.Windows.Forms.Label();
            this.lbl_enemy3 = new System.Windows.Forms.Label();
            this.lbl_enemy4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_crash = new System.Windows.Forms.Label();
            this.enemy1_collision = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_points = new System.Windows.Forms.Label();
            this.lbl_escapepoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hero_collsion = new System.Windows.Forms.Timer(this.components);
            this.lbl_chances = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_hero = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timr_bg
            // 
            this.timr_bg.Enabled = true;
            this.timr_bg.Interval = 20;
            this.timr_bg.Tick += new System.EventHandler(this.timr_bg_Tick_1);
            // 
            // timr_enemy
            // 
            this.timr_enemy.Enabled = true;
            this.timr_enemy.Interval = 50;
            this.timr_enemy.Tick += new System.EventHandler(this.timr_enemy_Tick);
            // 
            // timr_fire
            // 
            this.timr_fire.Enabled = true;
            this.timr_fire.Interval = 10;
            this.timr_fire.Tick += new System.EventHandler(this.timr_fire_Tick);
            // 
            // lbl_fire
            // 
            this.lbl_fire.AutoSize = true;
            this.lbl_fire.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_fire.Image = global::HalicopterGame.Properties.Resources.bullet;
            this.lbl_fire.Location = new System.Drawing.Point(489, 288);
            this.lbl_fire.Name = "lbl_fire";
            this.lbl_fire.Padding = new System.Windows.Forms.Padding(20, 5, 35, 5);
            this.lbl_fire.Size = new System.Drawing.Size(55, 23);
            this.lbl_fire.TabIndex = 10;
            // 
            // lbl_enemy1
            // 
            this.lbl_enemy1.AutoSize = true;
            this.lbl_enemy1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_enemy1.Image = global::HalicopterGame.Properties.Resources.enemy;
            this.lbl_enemy1.Location = new System.Drawing.Point(500, 100);
            this.lbl_enemy1.Name = "lbl_enemy1";
            this.lbl_enemy1.Padding = new System.Windows.Forms.Padding(30, 20, 40, 10);
            this.lbl_enemy1.Size = new System.Drawing.Size(70, 43);
            this.lbl_enemy1.TabIndex = 9;
            // 
            // lbl_enemy2
            // 
            this.lbl_enemy2.AutoSize = true;
            this.lbl_enemy2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_enemy2.Image = global::HalicopterGame.Properties.Resources.enemy;
            this.lbl_enemy2.Location = new System.Drawing.Point(500, 200);
            this.lbl_enemy2.Name = "lbl_enemy2";
            this.lbl_enemy2.Padding = new System.Windows.Forms.Padding(30, 20, 40, 10);
            this.lbl_enemy2.Size = new System.Drawing.Size(70, 43);
            this.lbl_enemy2.TabIndex = 7;
            // 
            // lbl_enemy6
            // 
            this.lbl_enemy6.AutoSize = true;
            this.lbl_enemy6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_enemy6.Image = global::HalicopterGame.Properties.Resources.enemy;
            this.lbl_enemy6.Location = new System.Drawing.Point(650, 150);
            this.lbl_enemy6.Name = "lbl_enemy6";
            this.lbl_enemy6.Padding = new System.Windows.Forms.Padding(30, 20, 40, 10);
            this.lbl_enemy6.Size = new System.Drawing.Size(70, 43);
            this.lbl_enemy6.TabIndex = 5;
            // 
            // lbl_enemy3
            // 
            this.lbl_enemy3.AutoSize = true;
            this.lbl_enemy3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_enemy3.Image = global::HalicopterGame.Properties.Resources.enemy;
            this.lbl_enemy3.Location = new System.Drawing.Point(500, 300);
            this.lbl_enemy3.Name = "lbl_enemy3";
            this.lbl_enemy3.Padding = new System.Windows.Forms.Padding(30, 20, 40, 10);
            this.lbl_enemy3.Size = new System.Drawing.Size(70, 43);
            this.lbl_enemy3.TabIndex = 3;
            // 
            // lbl_enemy4
            // 
            this.lbl_enemy4.AutoSize = true;
            this.lbl_enemy4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_enemy4.Image = global::HalicopterGame.Properties.Resources.enemy;
            this.lbl_enemy4.Location = new System.Drawing.Point(550, 250);
            this.lbl_enemy4.Name = "lbl_enemy4";
            this.lbl_enemy4.Padding = new System.Windows.Forms.Padding(30, 20, 40, 10);
            this.lbl_enemy4.Size = new System.Drawing.Size(70, 43);
            this.lbl_enemy4.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::HalicopterGame.Properties.Resources.hi_img01;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 350);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_crash
            // 
            this.lbl_crash.AutoSize = true;
            this.lbl_crash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_crash.Image = global::HalicopterGame.Properties.Resources.crash;
            this.lbl_crash.Location = new System.Drawing.Point(682, 235);
            this.lbl_crash.Name = "lbl_crash";
            this.lbl_crash.Padding = new System.Windows.Forms.Padding(30, 25, 20, 20);
            this.lbl_crash.Size = new System.Drawing.Size(50, 58);
            this.lbl_crash.TabIndex = 11;
            // 
            // enemy1_collision
            // 
            this.enemy1_collision.Enabled = true;
            this.enemy1_collision.Interval = 1;
            this.enemy1_collision.Tick += new System.EventHandler(this.enemy1_collision_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(196, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Points : ";
            // 
            // lbl_points
            // 
            this.lbl_points.AutoSize = true;
            this.lbl_points.Location = new System.Drawing.Point(268, 377);
            this.lbl_points.Name = "lbl_points";
            this.lbl_points.Size = new System.Drawing.Size(0, 13);
            this.lbl_points.TabIndex = 13;
            // 
            // lbl_escapepoints
            // 
            this.lbl_escapepoints.AutoSize = true;
            this.lbl_escapepoints.Location = new System.Drawing.Point(130, 377);
            this.lbl_escapepoints.Name = "lbl_escapepoints";
            this.lbl_escapepoints.Size = new System.Drawing.Size(0, 13);
            this.lbl_escapepoints.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Escape Points";
            // 
            // hero_collsion
            // 
            this.hero_collsion.Enabled = true;
            this.hero_collsion.Interval = 10;
            this.hero_collsion.Tick += new System.EventHandler(this.hero_collsion_Tick);
            // 
            // lbl_chances
            // 
            this.lbl_chances.AutoSize = true;
            this.lbl_chances.Location = new System.Drawing.Point(390, 377);
            this.lbl_chances.Name = "lbl_chances";
            this.lbl_chances.Size = new System.Drawing.Size(0, 13);
            this.lbl_chances.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 377);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Chances  : ";
            // 
            // lbl_hero
            // 
            this.lbl_hero.AutoSize = true;
            this.lbl_hero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_hero.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_hero.Image = global::HalicopterGame.Properties.Resources.hero;
            this.lbl_hero.Location = new System.Drawing.Point(24, 180);
            this.lbl_hero.Name = "lbl_hero";
            this.lbl_hero.Padding = new System.Windows.Forms.Padding(30, 20, 40, 10);
            this.lbl_hero.Size = new System.Drawing.Size(70, 43);
            this.lbl_hero.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 399);
            this.Controls.Add(this.lbl_chances);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_escapepoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_points);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_crash);
            this.Controls.Add(this.lbl_fire);
            this.Controls.Add(this.lbl_enemy1);
            this.Controls.Add(this.lbl_enemy2);
            this.Controls.Add(this.lbl_enemy6);
            this.Controls.Add(this.lbl_enemy3);
            this.Controls.Add(this.lbl_enemy4);
            this.Controls.Add(this.lbl_hero);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timr_bg;
        private System.Windows.Forms.Label lbl_enemy4;
        private System.Windows.Forms.Label lbl_enemy3;
        private System.Windows.Forms.Label lbl_enemy6;
        private System.Windows.Forms.Label lbl_enemy2;
        private System.Windows.Forms.Label lbl_enemy1;
        private System.Windows.Forms.Timer timr_enemy;
        private System.Windows.Forms.Label lbl_fire;
        private System.Windows.Forms.Timer timr_fire;
        private System.Windows.Forms.Label lbl_crash;
        private System.Windows.Forms.Timer enemy1_collision;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_points;
        private System.Windows.Forms.Label lbl_escapepoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer hero_collsion;
        private System.Windows.Forms.Label lbl_chances;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_hero;
    }
}

