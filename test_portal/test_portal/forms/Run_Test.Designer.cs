namespace test_portal.forms
{
    partial class Run_Test
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
            this.textQuestion = new System.Windows.Forms.TextBox();
            this.questionbyquestions = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textQuestion
            // 
            this.textQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQuestion.Location = new System.Drawing.Point(144, 63);
            this.textQuestion.Multiline = true;
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textQuestion.Size = new System.Drawing.Size(574, 51);
            this.textQuestion.TabIndex = 0;
            // 
            // questionbyquestions
            // 
            this.questionbyquestions.AutoSize = true;
            this.questionbyquestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionbyquestions.Location = new System.Drawing.Point(66, 71);
            this.questionbyquestions.Name = "questionbyquestions";
            this.questionbyquestions.Size = new System.Drawing.Size(41, 20);
            this.questionbyquestions.TabIndex = 1;
            this.questionbyquestions.Text = "0/20";
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.PeachPuff;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.next.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.next.Location = new System.Drawing.Point(332, 423);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(161, 44);
            this.next.TabIndex = 2;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Run_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.next);
            this.Controls.Add(this.questionbyquestions);
            this.Controls.Add(this.textQuestion);
            this.Name = "Run_Test";
            this.Text = "Run_Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textQuestion;
        private System.Windows.Forms.Label questionbyquestions;
        private System.Windows.Forms.Button next;
    }
}