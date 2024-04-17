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
            label3 = new Label();
            label4 = new Label();
            BTNSaveUnidimensional = new Button();
            TBunidimensional = new TextBox();
            label5 = new Label();
            ShowArray3D = new Button();
            label6 = new Label();
            label7 = new Label();
            TBresult = new TextBox();
            BTClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NameColumn, AgeColumn });
            dataGridView1.Location = new Point(831, 12);
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
            TBName.Location = new Point(621, 35);
            TBName.Name = "TBName";
            TBName.Size = new Size(189, 27);
            TBName.TabIndex = 1;
            // 
            // TBAge
            // 
            TBAge.Location = new Point(621, 102);
            TBAge.Name = "TBAge";
            TBAge.Size = new Size(189, 27);
            TBAge.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(621, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(621, 79);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 4;
            label2.Text = "Age";
            // 
            // BTNSave
            // 
            BTNSave.Location = new Point(664, 165);
            BTNSave.Name = "BTNSave";
            BTNSave.Size = new Size(94, 29);
            BTNSave.TabIndex = 5;
            BTNSave.Text = "Save";
            BTNSave.UseVisualStyleBackColor = true;
            BTNSave.Click += BTNSave_Click;
            // 
            // BTNExit
            // 
            BTNExit.Location = new Point(446, 411);
            BTNExit.Name = "BTNExit";
            BTNExit.Size = new Size(94, 29);
            BTNExit.TabIndex = 6;
            BTNExit.Text = "Exit";
            BTNExit.UseVisualStyleBackColor = true;
            BTNExit.Click += BTNExit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(925, 218);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 7;
            label3.Text = "Bidimensional";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 146);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 8;
            label4.Text = "Unidimensional";
            // 
            // BTNSaveUnidimensional
            // 
            BTNSaveUnidimensional.Location = new Point(152, 102);
            BTNSaveUnidimensional.Name = "BTNSaveUnidimensional";
            BTNSaveUnidimensional.Size = new Size(94, 29);
            BTNSaveUnidimensional.TabIndex = 9;
            BTNSaveUnidimensional.Text = "Save";
            BTNSaveUnidimensional.UseVisualStyleBackColor = true;
            BTNSaveUnidimensional.Click += BTNSaveUnidimensional_Click;
            // 
            // TBunidimensional
            // 
            TBunidimensional.Location = new Point(137, 53);
            TBunidimensional.Name = "TBunidimensional";
            TBunidimensional.Size = new Size(125, 27);
            TBunidimensional.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(144, 21);
            label5.Name = "label5";
            label5.Size = new Size(118, 20);
            label5.TabIndex = 11;
            label5.Text = "Write 5 numbers";
            // 
            // ShowArray3D
            // 
            ShowArray3D.Location = new Point(137, 271);
            ShowArray3D.Name = "ShowArray3D";
            ShowArray3D.Size = new Size(109, 29);
            ShowArray3D.TabIndex = 12;
            ShowArray3D.Text = "Show";
            ShowArray3D.UseVisualStyleBackColor = true;
            ShowArray3D.Click += ShowArray3D_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(216, 383);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 13;
            label6.Text = "Tridimensional";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(140, 238);
            label7.Name = "label7";
            label7.Size = new Size(105, 20);
            label7.TabIndex = 14;
            label7.Text = "Show array 3D";
            // 
            // TBresult
            // 
            TBresult.Location = new Point(294, 238);
            TBresult.Multiline = true;
            TBresult.Name = "TBresult";
            TBresult.ReadOnly = true;
            TBresult.Size = new Size(178, 114);
            TBresult.TabIndex = 15;
            // 
            // BTClear
            // 
            BTClear.Location = new Point(134, 306);
            BTClear.Name = "BTClear";
            BTClear.Size = new Size(109, 29);
            BTClear.TabIndex = 16;
            BTClear.Text = "Clear";
            BTClear.UseVisualStyleBackColor = true;
            BTClear.Click += BTClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 470);
            Controls.Add(BTClear);
            Controls.Add(TBresult);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ShowArray3D);
            Controls.Add(label5);
            Controls.Add(TBunidimensional);
            Controls.Add(BTNSaveUnidimensional);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Button BTNSaveUnidimensional;
        private TextBox TBunidimensional;
        private Label label5;
        private Button ShowArray3D;
        private Label label6;
        private Label label7;
        private TextBox TBresult;
        private Button BTClear;
    }
}
