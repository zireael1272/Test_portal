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
            this.numberQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberAnswers = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // createTest
            // 
            this.createTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createTest.Location = new System.Drawing.Point(352, 238);
            this.createTest.Name = "createTest";
            this.createTest.Size = new System.Drawing.Size(99, 32);
            this.createTest.TabIndex = 0;
            this.createTest.Text = "button1";
            this.createTest.UseVisualStyleBackColor = true;
            this.createTest.Click += new System.EventHandler(this.createTest_Click);
            // 
            // numberQuestion
            // 
            this.numberQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberQuestion.Location = new System.Drawing.Point(69, 57);
            this.numberQuestion.Multiline = true;
            this.numberQuestion.Name = "numberQuestion";
            this.numberQuestion.Size = new System.Drawing.Size(132, 30);
            this.numberQuestion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Number question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number answer";
            // 
            // numberAnswers
            // 
            this.numberAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberAnswers.Location = new System.Drawing.Point(69, 140);
            this.numberAnswers.Name = "numberAnswers";
            this.numberAnswers.ReadOnly = true;
            this.numberAnswers.Size = new System.Drawing.Size(132, 24);
            this.numberAnswers.TabIndex = 2;
            this.numberAnswers.Text = "0";
            // 
            // Create_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberAnswers);
            this.Controls.Add(this.numberQuestion);
            this.Controls.Add(this.createTest);
            this.Name = "Create_test";
            this.Text = "Create_test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTest;
        private System.Windows.Forms.TextBox numberQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown numberAnswers;
    }
}