namespace test_portal.forms
{
    partial class Create_acc
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
            this.create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.title_createacc = new System.Windows.Forms.Label();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // create
            // 
            this.create.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.create.FlatAppearance.BorderSize = 0;
            this.create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.create.Location = new System.Drawing.Point(142, 391);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(169, 44);
            this.create.TabIndex = 21;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = false;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(105, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Last name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(105, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "First name";
            // 
            // title_createacc
            // 
            this.title_createacc.AutoSize = true;
            this.title_createacc.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.title_createacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title_createacc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title_createacc.Location = new System.Drawing.Point(155, 48);
            this.title_createacc.Name = "title_createacc";
            this.title_createacc.Size = new System.Drawing.Size(145, 25);
            this.title_createacc.TabIndex = 18;
            this.title_createacc.Text = "Create account";
            // 
            // last_name
            // 
            this.last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.last_name.Location = new System.Drawing.Point(105, 215);
            this.last_name.Multiline = true;
            this.last_name.Name = "last_name";
            this.last_name.PasswordChar = '*';
            this.last_name.Size = new System.Drawing.Size(243, 34);
            this.last_name.TabIndex = 17;
            // 
            // first_name
            // 
            this.first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.first_name.Location = new System.Drawing.Point(105, 146);
            this.first_name.Multiline = true;
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(243, 34);
            this.first_name.TabIndex = 16;
            // 
            // Create_acc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(452, 523);
            this.Controls.Add(this.create);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title_createacc);
            this.Controls.Add(this.last_name);
            this.Controls.Add(this.first_name);
            this.Name = "Create_acc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_acc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Create_acc_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label title_createacc;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
    }
}