namespace test_portal.forms
{
    partial class Create_test
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
            this.createTest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numberAnswers = new System.Windows.Forms.DomainUpDown();
            this.namegroup = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NameTest = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTest
            // 
            this.createTest.BackColor = System.Drawing.Color.Bisque;
            this.createTest.FlatAppearance.BorderSize = 0;
            this.createTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTest.Location = new System.Drawing.Point(309, 346);
            this.createTest.Name = "createTest";
            this.createTest.Size = new System.Drawing.Size(157, 47);
            this.createTest.TabIndex = 0;
            this.createTest.Text = "Create test";
            this.createTest.UseVisualStyleBackColor = false;
            this.createTest.Click += new System.EventHandler(this.createTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(112, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number answer on question\r\n";
            // 
            // numberAnswers
            // 
            this.numberAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberAnswers.Location = new System.Drawing.Point(115, 213);
            this.numberAnswers.Name = "numberAnswers";
            this.numberAnswers.ReadOnly = true;
            this.numberAnswers.Size = new System.Drawing.Size(178, 26);
            this.numberAnswers.TabIndex = 2;
            this.numberAnswers.Text = "0";
            // 
            // namegroup
            // 
            this.namegroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namegroup.FormattingEnabled = true;
            this.namegroup.Location = new System.Drawing.Point(504, 213);
            this.namegroup.Name = "namegroup";
            this.namegroup.Size = new System.Drawing.Size(180, 28);
            this.namegroup.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(500, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name group ";
            // 
            // NameTest
            // 
            this.NameTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTest.Location = new System.Drawing.Point(115, 83);
            this.NameTest.Multiline = true;
            this.NameTest.Name = "NameTest";
            this.NameTest.Size = new System.Drawing.Size(569, 34);
            this.NameTest.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(112, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name test";
            // 
            // Create_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NameTest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namegroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numberAnswers);
            this.Controls.Add(this.createTest);
            this.Name = "Create_test";
            this.Text = "Create_test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown numberAnswers;
        private System.Windows.Forms.ComboBox namegroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameTest;
        private System.Windows.Forms.Label label4;
    }
}