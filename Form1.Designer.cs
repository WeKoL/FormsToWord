namespace wordInter
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
            TIMEVACATION = new Label();
            FULLNAME = new Label();
            POST = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            REASON = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            WithLabel = new Label();
            dateTimePicker4 = new DateTimePicker();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TIMEVACATION
            // 
            TIMEVACATION.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            TIMEVACATION.AutoSize = true;
            TIMEVACATION.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TIMEVACATION.Location = new Point(83, 120);
            TIMEVACATION.Name = "TIMEVACATION";
            TIMEVACATION.Padding = new Padding(5);
            TIMEVACATION.Size = new Size(114, 26);
            TIMEVACATION.TabIndex = 2;
            TIMEVACATION.Text = "Период отпуска";
            // 
            // FULLNAME
            // 
            FULLNAME.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            FULLNAME.AutoSize = true;
            FULLNAME.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FULLNAME.Location = new Point(151, 60);
            FULLNAME.Name = "FULLNAME";
            FULLNAME.Padding = new Padding(5);
            FULLNAME.Size = new Size(46, 26);
            FULLNAME.TabIndex = 1;
            FULLNAME.Text = "ФИО";
            // 
            // POST
            // 
            POST.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            POST.AutoSize = true;
            POST.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            POST.Location = new Point(51, 0);
            POST.Name = "POST";
            POST.Padding = new Padding(5);
            POST.Size = new Size(146, 26);
            POST.TabIndex = 0;
            POST.Text = "От кого(должность)";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(textBox3, 1, 7);
            tableLayoutPanel1.Controls.Add(label1, 0, 6);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(POST, 0, 0);
            tableLayoutPanel1.Controls.Add(FULLNAME, 0, 1);
            tableLayoutPanel1.Controls.Add(TIMEVACATION, 0, 2);
            tableLayoutPanel1.Controls.Add(REASON, 0, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBox1, 1, 3);
            tableLayoutPanel1.Controls.Add(dateTimePicker1, 1, 5);
            tableLayoutPanel1.Controls.Add(dateTimePicker2, 1, 2);
            tableLayoutPanel1.Controls.Add(dateTimePicker3, 1, 4);
            tableLayoutPanel1.Controls.Add(WithLabel, 0, 5);
            tableLayoutPanel1.Controls.Add(dateTimePicker4, 1, 6);
            tableLayoutPanel1.Controls.Add(button1, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.Size = new Size(844, 484);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ButtonHighlight;
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(203, 423);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(638, 23);
            textBox3.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(162, 360);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(35, 26);
            label1.TabIndex = 18;
            label1.Text = "ДО";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 240);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(194, 26);
            label2.TabIndex = 17;
            label2.Text = "Дата заполнения заявления";
            // 
            // REASON
            // 
            REASON.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            REASON.AutoSize = true;
            REASON.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            REASON.Location = new Point(130, 180);
            REASON.Name = "REASON";
            REASON.Padding = new Padding(5);
            REASON.Size = new Size(67, 26);
            REASON.TabIndex = 5;
            REASON.Text = "Причина";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Dock = DockStyle.Top;
            textBox1.Location = new Point(203, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(638, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "мастера ТСО";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Dock = DockStyle.Top;
            textBox2.Location = new Point(203, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(638, 23);
            textBox2.TabIndex = 6;
            textBox2.Text = "Иванова Ивана Ивановича";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ButtonHighlight;
            richTextBox1.Dock = DockStyle.Top;
            richTextBox1.Location = new Point(203, 183);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(638, 42);
            richTextBox1.TabIndex = 8;
            richTextBox1.Text = "по семейным обстоятельствам";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Dock = DockStyle.Top;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(203, 303);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(638, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Dock = DockStyle.Top;
            dateTimePicker2.Location = new Point(203, 123);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(638, 23);
            dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Dock = DockStyle.Top;
            dateTimePicker3.Location = new Point(203, 243);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(638, 23);
            dateTimePicker3.TabIndex = 15;
            // 
            // WithLabel
            // 
            WithLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            WithLabel.AutoSize = true;
            WithLabel.Font = new Font("SimSun-ExtB", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WithLabel.Location = new Point(164, 300);
            WithLabel.Name = "WithLabel";
            WithLabel.Padding = new Padding(5);
            WithLabel.Size = new Size(33, 26);
            WithLabel.TabIndex = 3;
            WithLabel.Text = "C ";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Dock = DockStyle.Top;
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker4.Location = new Point(203, 363);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(638, 23);
            dateTimePicker4.TabIndex = 19;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 423);
            button1.Name = "button1";
            button1.Size = new Size(194, 58);
            button1.TabIndex = 20;
            button1.Text = "Сохранить по указанному адрессу";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(854, 497);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Padding = new Padding(5);
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TIMEVACATION;
        private Label FULLNAME;
        private Label POST;
        private TableLayoutPanel tableLayoutPanel1;
        private Label WithLabel;
        private Label label5;
        private Label REASON;
        private TextBox textBox1;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private TextBox textBox3;
        private Button button1;
    }
}
