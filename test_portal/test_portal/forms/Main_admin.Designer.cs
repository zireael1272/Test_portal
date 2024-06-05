namespace test_portal
{
    partial class Main_admin
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
            this.paneltitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.create_test = new System.Windows.Forms.Button();
            this.panelacc = new System.Windows.Forms.Panel();
            this.nametitle = new System.Windows.Forms.Label();
            this.change_test = new System.Windows.Forms.Button();
            this.paneltitle.SuspendLayout();
            this.panelmenu.SuspendLayout();
            this.panelacc.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneltitle
            // 
            this.paneltitle.BackColor = System.Drawing.Color.SandyBrown;
            this.paneltitle.Controls.Add(this.label1);
            this.paneltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneltitle.Location = new System.Drawing.Point(0, 0);
            this.paneltitle.Name = "paneltitle";
            this.paneltitle.Size = new System.Drawing.Size(808, 79);
            this.paneltitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(358, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main";
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 79);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(808, 514);
            this.panelDesktop.TabIndex = 3;
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.PeachPuff;
            this.panelmenu.Controls.Add(this.exit);
            this.panelmenu.Controls.Add(this.change_test);
            this.panelmenu.Controls.Add(this.create_test);
            this.panelmenu.Controls.Add(this.panelacc);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelmenu.Location = new System.Drawing.Point(808, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(224, 593);
            this.panelmenu.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(0, 201);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(224, 61);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // create_test
            // 
            this.create_test.Dock = System.Windows.Forms.DockStyle.Top;
            this.create_test.FlatAppearance.BorderSize = 0;
            this.create_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create_test.Location = new System.Drawing.Point(0, 79);
            this.create_test.Name = "create_test";
            this.create_test.Size = new System.Drawing.Size(224, 61);
            this.create_test.TabIndex = 4;
            this.create_test.Text = "Create test";
            this.create_test.UseVisualStyleBackColor = true;
            this.create_test.Click += new System.EventHandler(this.create_test_Click_1);
            // 
            // panelacc
            // 
            this.panelacc.BackColor = System.Drawing.Color.SandyBrown;
            this.panelacc.Controls.Add(this.nametitle);
            this.panelacc.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelacc.Location = new System.Drawing.Point(0, 0);
            this.panelacc.Name = "panelacc";
            this.panelacc.Size = new System.Drawing.Size(224, 79);
            this.panelacc.TabIndex = 0;
            // 
            // nametitle
            // 
            this.nametitle.AutoSize = true;
            this.nametitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nametitle.Location = new System.Drawing.Point(52, 21);
            this.nametitle.Name = "nametitle";
            this.nametitle.Size = new System.Drawing.Size(70, 20);
            this.nametitle.TabIndex = 0;
            this.nametitle.Text = "Account";
            this.nametitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // change_test
            // 
            this.change_test.Dock = System.Windows.Forms.DockStyle.Top;
            this.change_test.FlatAppearance.BorderSize = 0;
            this.change_test.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.change_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.change_test.Location = new System.Drawing.Point(0, 140);
            this.change_test.Name = "change_test";
            this.change_test.Size = new System.Drawing.Size(224, 61);
            this.change_test.TabIndex = 5;
            this.change_test.Text = "Change test";
            this.change_test.UseVisualStyleBackColor = true;
            this.change_test.Click += new System.EventHandler(this.settings_Click_1);
            // 
            // Main_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1032, 593);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.paneltitle);
            this.Controls.Add(this.panelmenu);
            this.Name = "Main_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_admin_FormClosing);
            this.paneltitle.ResumeLayout(false);
            this.paneltitle.PerformLayout();
            this.panelmenu.ResumeLayout(false);
            this.panelacc.ResumeLayout(false);
            this.panelacc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneltitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button create_test;
        private System.Windows.Forms.Panel panelacc;
        private System.Windows.Forms.Label nametitle;
        private System.Windows.Forms.Button change_test;
    }
}