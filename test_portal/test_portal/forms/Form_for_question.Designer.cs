namespace test_portal.forms
{
    partial class Form_for_question
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
            this.AddQuestion = new System.Windows.Forms.Button();
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddQuestion
            // 
            this.AddQuestion.BackColor = System.Drawing.Color.NavajoWhite;
            this.AddQuestion.FlatAppearance.BorderSize = 0;
            this.AddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddQuestion.Location = new System.Drawing.Point(314, 429);
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(145, 45);
            this.AddQuestion.TabIndex = 0;
            this.AddQuestion.Text = "Add question";
            this.AddQuestion.UseVisualStyleBackColor = false;
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // textQuestion
            // 
            this.textQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQuestion.Location = new System.Drawing.Point(71, 68);
            this.textQuestion.Multiline = true;
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textQuestion.Size = new System.Drawing.Size(645, 51);
            this.textQuestion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(71, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text question";
            // 
            // Form_for_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.AddQuestion);
            this.Name = "Form_for_question";
            this.Text = "Form_for_question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuestion;
        private System.Windows.Forms.TextBox textQuestion;
        private System.Windows.Forms.Label label1;
    }
}