namespace test_portal.forms
{
    partial class Tests_View
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
            this.label1 = new System.Windows.Forms.Label();
            this.namegroupsort = new System.Windows.Forms.ComboBox();
            this.TableTests = new System.Windows.Forms.DataGridView();
            this.NameTest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableTests)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(366, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort group by";
            // 
            // namegroupsort
            // 
            this.namegroupsort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.namegroupsort.FormattingEnabled = true;
            this.namegroupsort.Location = new System.Drawing.Point(369, 60);
            this.namegroupsort.Name = "namegroupsort";
            this.namegroupsort.Size = new System.Drawing.Size(178, 28);
            this.namegroupsort.TabIndex = 4;
            this.namegroupsort.SelectedIndexChanged += new System.EventHandler(this.namegroupsort_SelectedIndexChanged);
            // 
            // TableTests
            // 
            this.TableTests.BackgroundColor = System.Drawing.Color.Snow;
            this.TableTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameTest,
            this.NameGroup,
            this.completed});
            this.TableTests.GridColor = System.Drawing.Color.Tan;
            this.TableTests.Location = new System.Drawing.Point(48, 114);
            this.TableTests.Name = "TableTests";
            this.TableTests.RowHeadersWidth = 51;
            this.TableTests.RowTemplate.Height = 24;
            this.TableTests.Size = new System.Drawing.Size(709, 319);
            this.TableTests.TabIndex = 3;
            this.TableTests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableTests_CellContentClick);
            this.TableTests.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableTests_CellDoubleClick);
            // 
            // NameTest
            // 
            this.NameTest.HeaderText = "Name test";
            this.NameTest.MinimumWidth = 6;
            this.NameTest.Name = "NameTest";
            this.NameTest.ReadOnly = true;
            this.NameTest.Width = 180;
            // 
            // NameGroup
            // 
            this.NameGroup.HeaderText = "Name group";
            this.NameGroup.MinimumWidth = 6;
            this.NameGroup.Name = "NameGroup";
            this.NameGroup.ReadOnly = true;
            this.NameGroup.Width = 150;
            // 
            // completed
            // 
            this.completed.HeaderText = "Completed";
            this.completed.MinimumWidth = 6;
            this.completed.Name = "completed";
            this.completed.ReadOnly = true;
            this.completed.Width = 110;
            // 
            // Tests_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(790, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namegroupsort);
            this.Controls.Add(this.TableTests);
            this.Name = "Tests_View";
            this.Text = "Tests_View";
            ((System.ComponentModel.ISupportInitialize)(this.TableTests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox namegroupsort;
        private System.Windows.Forms.DataGridView TableTests;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameTest;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn completed;
    }
}