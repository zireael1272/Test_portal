namespace test_portal.forms
{
    partial class Change_test
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
            this.TableTests = new System.Windows.Forms.DataGridView();
            this.NameTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namegroupsort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableTests)).BeginInit();
            this.SuspendLayout();
            // 
            // TableTests
            // 
            this.TableTests.BackgroundColor = System.Drawing.Color.Snow;
            this.TableTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTest,
            this.NameGroup});
            this.TableTests.GridColor = System.Drawing.Color.Tan;
            this.TableTests.Location = new System.Drawing.Point(117, 104);
            this.TableTests.Name = "TableTests";
            this.TableTests.RowHeadersWidth = 51;
            this.TableTests.RowTemplate.Height = 24;
            this.TableTests.Size = new System.Drawing.Size(572, 319);
            this.TableTests.TabIndex = 0;
            this.TableTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableTests_CellContentClick);
            this.TableTests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableTests_CellDoubleClick);
            // 
            // NameTest
            // 
            this.NameTest.HeaderText = "Name test";
            this.NameTest.MinimumWidth = 6;
            this.NameTest.Name = "NameTest";
            this.NameTest.ReadOnly = true;
            this.NameTest.Width = 202;
            // 
            // NameGroup
            // 
            this.NameGroup.HeaderText = "Name group";
            this.NameGroup.MinimumWidth = 6;
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.Width = 170;
            // 
            // namegroupsort
            // 
            this.namegroupsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namegroupsort.FormattingEnabled = true;
            this.namegroupsort.Location = new System.Drawing.Point(526, 44);
            this.namegroupsort.Name = "namegroupsort";
            this.namegroupsort.Size = new System.Drawing.Size(163, 28);
            this.namegroupsort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(523, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort group";
            // 
            // Change_test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namegroupsort);
            this.Controls.Add(this.TableTests);
            this.Name = "Change_test";
            this.Text = "Change_test";
            ((System.ComponentModel.ISupportInitialize)(this.TableTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableTests;
        private System.Windows.Forms.ComboBox namegroupsort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroup;
    }
}