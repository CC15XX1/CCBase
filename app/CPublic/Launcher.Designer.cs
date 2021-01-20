namespace CPublic
{
    partial class Launcher
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.LaunchBtn = new System.Windows.Forms.Button();
            this.Samsung = new System.Windows.Forms.Button();
            this.Memenite = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.MinimizeBtn);
            this.panel1.Controls.Add(this.CloseBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 31);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.FlatAppearance.BorderSize = 0;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBtn.Location = new System.Drawing.Point(743, 3);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(28, 25);
            this.MinimizeBtn.TabIndex = 11;
            this.MinimizeBtn.Text = "-";
            this.MinimizeBtn.UseVisualStyleBackColor = true;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(768, 3);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(28, 25);
            this.CloseBtn.TabIndex = 10;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LaunchBtn.FlatAppearance.BorderSize = 0;
            this.LaunchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LaunchBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaunchBtn.Location = new System.Drawing.Point(12, 37);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.Size = new System.Drawing.Size(100, 30);
            this.LaunchBtn.TabIndex = 5;
            this.LaunchBtn.Text = "GeorgeFN";
            this.LaunchBtn.UseVisualStyleBackColor = false;
            this.LaunchBtn.Click += new System.EventHandler(this.LaunchBtn_Click);
            // 
            // Samsung
            // 
            this.Samsung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Samsung.FlatAppearance.BorderSize = 0;
            this.Samsung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Samsung.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Samsung.Location = new System.Drawing.Point(118, 37);
            this.Samsung.Name = "Samsung";
            this.Samsung.Size = new System.Drawing.Size(100, 30);
            this.Samsung.TabIndex = 6;
            this.Samsung.Text = "SamsungFN";
            this.Samsung.UseVisualStyleBackColor = false;
            this.Samsung.Click += new System.EventHandler(this.Samsung_Click);
            // 
            // Memenite
            // 
            this.Memenite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Memenite.FlatAppearance.BorderSize = 0;
            this.Memenite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Memenite.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memenite.Location = new System.Drawing.Point(224, 37);
            this.Memenite.Name = "Memenite";
            this.Memenite.Size = new System.Drawing.Size(100, 30);
            this.Memenite.TabIndex = 7;
            this.Memenite.Text = "Memenite";
            this.Memenite.UseVisualStyleBackColor = false;
            this.Memenite.Click += new System.EventHandler(this.Memenite_Click);
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Memenite);
            this.Controls.Add(this.Samsung);
            this.Controls.Add(this.LaunchBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Launcher";
            this.Text = "Launcher";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button LaunchBtn;
        private System.Windows.Forms.Button Samsung;
        private System.Windows.Forms.Button Memenite;
    }
}