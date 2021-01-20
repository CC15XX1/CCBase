namespace CPublic
{
    partial class Main
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LightMode = new System.Windows.Forms.RadioButton();
            this.DefaultMode = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.NotepadBtn = new System.Windows.Forms.Button();
            this.FileExplorerBtn = new System.Windows.Forms.Button();
            this.ChromeBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LauncherBtn = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 1;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(722, 424);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(74, 20);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "TopMost";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LightMode
            // 
            this.LightMode.AutoSize = true;
            this.LightMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LightMode.Location = new System.Drawing.Point(743, 372);
            this.LightMode.Name = "LightMode";
            this.LightMode.Size = new System.Drawing.Size(53, 20);
            this.LightMode.TabIndex = 3;
            this.LightMode.Text = "Light";
            this.LightMode.UseVisualStyleBackColor = true;
            this.LightMode.CheckedChanged += new System.EventHandler(this.LightMode_CheckedChanged);
            // 
            // DefaultMode
            // 
            this.DefaultMode.AutoSize = true;
            this.DefaultMode.Checked = true;
            this.DefaultMode.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DefaultMode.Location = new System.Drawing.Point(701, 398);
            this.DefaultMode.Name = "DefaultMode";
            this.DefaultMode.Size = new System.Drawing.Size(98, 20);
            this.DefaultMode.TabIndex = 4;
            this.DefaultMode.TabStop = true;
            this.DefaultMode.Text = "Dark (default)";
            this.DefaultMode.UseVisualStyleBackColor = true;
            this.DefaultMode.CheckedChanged += new System.EventHandler(this.DefaultMode_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "-- Settings --";
            // 
            // NotepadBtn
            // 
            this.NotepadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.NotepadBtn.FlatAppearance.BorderSize = 0;
            this.NotepadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NotepadBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotepadBtn.Location = new System.Drawing.Point(12, 421);
            this.NotepadBtn.Name = "NotepadBtn";
            this.NotepadBtn.Size = new System.Drawing.Size(88, 23);
            this.NotepadBtn.TabIndex = 6;
            this.NotepadBtn.Text = "Notepad";
            this.NotepadBtn.UseVisualStyleBackColor = false;
            this.NotepadBtn.Click += new System.EventHandler(this.NotepadBtn_Click);
            // 
            // FileExplorerBtn
            // 
            this.FileExplorerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FileExplorerBtn.FlatAppearance.BorderSize = 0;
            this.FileExplorerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileExplorerBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileExplorerBtn.Location = new System.Drawing.Point(12, 392);
            this.FileExplorerBtn.Name = "FileExplorerBtn";
            this.FileExplorerBtn.Size = new System.Drawing.Size(88, 23);
            this.FileExplorerBtn.TabIndex = 7;
            this.FileExplorerBtn.Text = "FIle Explorer";
            this.FileExplorerBtn.UseVisualStyleBackColor = false;
            this.FileExplorerBtn.Click += new System.EventHandler(this.FileExplorerBtn_Click);
            // 
            // ChromeBtn
            // 
            this.ChromeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ChromeBtn.FlatAppearance.BorderSize = 0;
            this.ChromeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChromeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChromeBtn.Location = new System.Drawing.Point(12, 363);
            this.ChromeBtn.Name = "ChromeBtn";
            this.ChromeBtn.Size = new System.Drawing.Size(88, 23);
            this.ChromeBtn.TabIndex = 8;
            this.ChromeBtn.Text = "Chrome";
            this.ChromeBtn.UseVisualStyleBackColor = false;
            this.ChromeBtn.Click += new System.EventHandler(this.ChromeBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "-- Proccesses --";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(106, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Credits";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LauncherBtn
            // 
            this.LauncherBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LauncherBtn.FlatAppearance.BorderSize = 0;
            this.LauncherBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LauncherBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LauncherBtn.Location = new System.Drawing.Point(106, 392);
            this.LauncherBtn.Name = "LauncherBtn";
            this.LauncherBtn.Size = new System.Drawing.Size(88, 23);
            this.LauncherBtn.TabIndex = 11;
            this.LauncherBtn.Text = "Launcher";
            this.LauncherBtn.UseVisualStyleBackColor = false;
            this.LauncherBtn.Click += new System.EventHandler(this.LauncherBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LauncherBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChromeBtn);
            this.Controls.Add(this.FileExplorerBtn);
            this.Controls.Add(this.NotepadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DefaultMode);
            this.Controls.Add(this.LightMode);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton LightMode;
        private System.Windows.Forms.RadioButton DefaultMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NotepadBtn;
        private System.Windows.Forms.Button FileExplorerBtn;
        private System.Windows.Forms.Button ChromeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button LauncherBtn;
    }
}