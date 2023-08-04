namespace FirstWindowsAPP
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            textBoxFee = new TextBox();
            textBoxCours = new TextBox();
            label4 = new Label();
            textBoxName = new TextBox();
            label3 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Editbutton = new DataGridViewButtonColumn();
            Deletebutton = new DataGridViewButtonColumn();
            button3 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(303, 9);
            label1.Name = "label1";
            label1.Size = new Size(361, 47);
            label1.TabIndex = 0;
            label1.Text = "Student Registration";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxFee);
            groupBox1.Controls.Add(textBoxCours);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(23, 99);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(358, 260);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Student registration";
            // 
            // textBoxFee
            // 
            textBoxFee.Location = new Point(126, 186);
            textBoxFee.Name = "textBoxFee";
            textBoxFee.Size = new Size(212, 25);
            textBoxFee.TabIndex = 2;
            // 
            // textBoxCours
            // 
            textBoxCours.Location = new Point(126, 124);
            textBoxCours.Name = "textBoxCours";
            textBoxCours.Size = new Size(212, 25);
            textBoxCours.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 186);
            label4.Name = "label4";
            label4.Size = new Size(28, 17);
            label4.TabIndex = 2;
            label4.Text = "Fee";
            label4.Click += label4_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(126, 50);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(212, 25);
            textBoxName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 124);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 1;
            label3.Text = "Cours";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 50);
            label2.Name = "label2";
            label2.Size = new Size(87, 17);
            label2.TabIndex = 0;
            label2.Text = "StudentName";
            // 
            // button1
            // 
            button1.Location = new Point(23, 365);
            button1.Name = "button1";
            button1.Size = new Size(173, 23);
            button1.TabIndex = 4;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 365);
            button2.Name = "button2";
            button2.Size = new Size(179, 23);
            button2.TabIndex = 5;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Editbutton, Deletebutton });
            dataGridView1.Location = new Point(403, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(643, 308);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Student name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Cours";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Fee";
            Column4.Name = "Column4";
            // 
            // Editbutton
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Green;
            Editbutton.DefaultCellStyle = dataGridViewCellStyle1;
            Editbutton.HeaderText = "Edit";
            Editbutton.Name = "Editbutton";
            Editbutton.Text = "Edit";
            Editbutton.UseColumnTextForButtonValue = true;
            // 
            // Deletebutton
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(192, 0, 0);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            Deletebutton.DefaultCellStyle = dataGridViewCellStyle2;
            Deletebutton.HeaderText = "Delete";
            Deletebutton.Name = "Deletebutton";
            Deletebutton.Text = "Delete";
            Deletebutton.UseColumnTextForButtonValue = true;
            // 
            // button3
            // 
            button3.Location = new Point(23, 394);
            button3.Name = "button3";
            button3.Size = new Size(358, 23);
            button3.TabIndex = 7;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1086, 450);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBoxFee;
        private TextBox textBoxCours;
        private TextBox textBoxName;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Editbutton;
        private DataGridViewButtonColumn Deletebutton;
        private Button button3;
    }
}