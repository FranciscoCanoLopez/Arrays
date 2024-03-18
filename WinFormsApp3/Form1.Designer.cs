namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            AgeColumn = new DataGridViewTextBoxColumn();
            TBName = new TextBox();
            TBAge = new TextBox();
            label1 = new Label();
            label2 = new Label();
            BTNSave = new Button();
            BTNExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, AgeColumn });
            dataGridView1.Location = new Point(386, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 194);
            dataGridView1.TabIndex = 0;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 6;
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            NameColumn.Width = 125;
            // 
            // AgeColumn
            // 
            AgeColumn.HeaderText = "Age";
            AgeColumn.MinimumWidth = 6;
            AgeColumn.Name = "AgeColumn";
            AgeColumn.ReadOnly = true;
            AgeColumn.Width = 125;
            // 
            // TBName
            // 
            TBName.Location = new Point(69, 55);
            TBName.Name = "TBName";
            TBName.Size = new Size(189, 27);
            TBName.TabIndex = 1;
            // 
            // TBAge
            // 
            TBAge.Location = new Point(69, 114);
            TBAge.Name = "TBAge";
            TBAge.Size = new Size(189, 27);
            TBAge.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 32);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 91);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(118, 165);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(94, 29);
            BTNSave.TabIndex = 5;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // BTNExit
            // 
            BTNExit.Location = new Point(342, 284);
            BTNExit.Name = "BTNExit";
            BTNExit.Size = new Size(94, 29);
            BTNExit.TabIndex = 6;
            BTNExit.Text = "Exit";
            BTNExit.UseVisualStyleBackColor = true;
            BTNExit.Click += BTNExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 358);
            Controls.Add(BTNExit);
            Controls.Add(BTNSave);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TBAge);
            Controls.Add(TBName);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox TBName;
        private TextBox TBAge;
        private Label label1;
        private Label label2;
        private Button BTNSave;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn AgeColumn;
        private Button BTNExit;
    }
}
