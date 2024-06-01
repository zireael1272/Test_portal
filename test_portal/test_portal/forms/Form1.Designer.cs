namespace test_portal
{
    partial class login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_in = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.title_log = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Avtorizate = new System.Windows.Forms.Button();
            this.sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_in
            // 
            this.log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log_in.Location = new System.Drawing.Point(105, 202);
            this.log_in.Multiline = true;
            this.log_in.Name = "log_in";
            this.log_in.Size = new System.Drawing.Size(243, 34);
            this.log_in.TabIndex = 0;
            this.log_in.KeyDown += new System.Windows.Forms.KeyEventHandler(this.log_in_KeyDown);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password.Location = new System.Drawing.Point(105, 271);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(243, 34);
            this.password.TabIndex = 1;
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.password_KeyDown);
            // 
            // title_log
            // 
            this.title_log.AutoSize = true;
            this.title_log.BackColor = System.Drawing.Color.PeachPuff;
            this.title_log.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_log.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title_log.Location = new System.Drawing.Point(193, 48);
            this.title_log.Name = "title_log";
            this.title_log.Size = new System.Drawing.Size(65, 25);
            this.title_log.TabIndex = 2;
            this.title_log.Text = "Log in";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "password";
            // 
            // Avtorizate
            // 
            this.Avtorizate.BackColor = System.Drawing.Color.PeachPuff;
            this.Avtorizate.FlatAppearance.BorderSize = 0;
            this.Avtorizate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Avtorizate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Avtorizate.Location = new System.Drawing.Point(144, 401);
            this.Avtorizate.Name = "Avtorizate";
            this.Avtorizate.Size = new System.Drawing.Size(169, 44);
            this.Avtorizate.TabIndex = 5;
            this.Avtorizate.Text = "Log in";
            this.Avtorizate.UseVisualStyleBackColor = false;
            this.Avtorizate.Click += new System.EventHandler(this.Avtorizate_Click);
            // 
            // sign_in
            // 
            this.sign_in.FlatAppearance.BorderSize = 0;
            this.sign_in.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sign_in.ForeColor = System.Drawing.SystemColors.Highlight;
            this.sign_in.Location = new System.Drawing.Point(144, 451);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(169, 44);
            this.sign_in.TabIndex = 6;
            this.sign_in.Text = "Sign in";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(452, 523);
            this.Controls.Add(this.sign_in);
            this.Controls.Add(this.Avtorizate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_log);
            this.Controls.Add(this.password);
            this.Controls.Add(this.log_in);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox log_in;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label title_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Avtorizate;
        private System.Windows.Forms.Button sign_in;
    }
}

