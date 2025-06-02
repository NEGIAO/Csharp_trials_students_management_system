namespace 学生管理系统
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
            label_ID = new Label();
            label_name = new Label();
            label_score = new Label();
            input_ID = new TextBox();
            input_name = new TextBox();
            input_score = new TextBox();
            button_add_student = new Button();
            button_update_score = new Button();
            button_statistic_score = new Button();
            input_search = new TextBox();
            button_search = new Button();
            button_rank = new Button();
            label_display_outcome = new Label();
            listBox_information_dispaly = new ListBox();
            input_rank = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label_ID
            // 
            label_ID.AutoSize = true;
            label_ID.Location = new Point(79, 92);
            label_ID.Name = "label_ID";
            label_ID.Size = new Size(24, 20);
            label_ID.TabIndex = 0;
            label_ID.Text = "ID";
            // 
            // label_name
            // 
            label_name.AutoSize = true;
            label_name.Location = new Point(79, 155);
            label_name.Name = "label_name";
            label_name.Size = new Size(41, 20);
            label_name.TabIndex = 1;
            label_name.Text = "姓名";
            // 
            // label_score
            // 
            label_score.AutoSize = true;
            label_score.Location = new Point(79, 211);
            label_score.Name = "label_score";
            label_score.Size = new Size(41, 20);
            label_score.TabIndex = 2;
            label_score.Text = "成绩";
            // 
            // input_ID
            // 
            input_ID.Location = new Point(172, 90);
            input_ID.Name = "input_ID";
            input_ID.Size = new Size(112, 27);
            input_ID.TabIndex = 3;
            // 
            // input_name
            // 
            input_name.Location = new Point(172, 153);
            input_name.Name = "input_name";
            input_name.Size = new Size(112, 27);
            input_name.TabIndex = 4;
            // 
            // input_score
            // 
            input_score.Location = new Point(172, 209);
            input_score.Name = "input_score";
            input_score.Size = new Size(112, 27);
            input_score.TabIndex = 5;
            // 
            // button_add_student
            // 
            button_add_student.Location = new Point(79, 302);
            button_add_student.Name = "button_add_student";
            button_add_student.Size = new Size(84, 29);
            button_add_student.TabIndex = 6;
            button_add_student.Text = "添加学生";
            button_add_student.UseVisualStyleBackColor = true;
            button_add_student.Click += button1_add_student;
            // 
            // button_update_score
            // 
            button_update_score.Location = new Point(200, 302);
            button_update_score.Name = "button_update_score";
            button_update_score.Size = new Size(84, 29);
            button_update_score.TabIndex = 7;
            button_update_score.Text = "更新成绩";
            button_update_score.UseVisualStyleBackColor = true;
            button_update_score.Click += button2_update_score;
            // 
            // button_statistic_score
            // 
            button_statistic_score.Location = new Point(79, 479);
            button_statistic_score.Name = "button_statistic_score";
            button_statistic_score.Size = new Size(84, 29);
            button_statistic_score.TabIndex = 9;
            button_statistic_score.Text = "统计成绩";
            button_statistic_score.UseVisualStyleBackColor = true;
            button_statistic_score.Click += button3_Click_statistics;
            // 
            // input_search
            // 
            input_search.Location = new Point(336, 357);
            input_search.Name = "input_search";
            input_search.Size = new Size(215, 27);
            input_search.TabIndex = 10;
            // 
            // button_search
            // 
            button_search.Location = new Point(617, 357);
            button_search.Name = "button_search";
            button_search.Size = new Size(84, 29);
            button_search.TabIndex = 12;
            button_search.Text = "搜索";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_click_search;
            // 
            // button_rank
            // 
            button_rank.Location = new Point(617, 433);
            button_rank.Name = "button_rank";
            button_rank.Size = new Size(84, 29);
            button_rank.TabIndex = 13;
            button_rank.Text = "排序";
            button_rank.UseVisualStyleBackColor = true;
            button_rank.Click += button5_Click_rank;
            // 
            // label_display_outcome
            // 
            label_display_outcome.AutoSize = true;
            label_display_outcome.Location = new Point(92, 532);
            label_display_outcome.Name = "label_display_outcome";
            label_display_outcome.Size = new Size(50, 20);
            label_display_outcome.TabIndex = 14;
            label_display_outcome.Text = "label4";
            // 
            // listBox_information_dispaly
            // 
            listBox_information_dispaly.FormattingEnabled = true;
            listBox_information_dispaly.Location = new Point(329, 58);
            listBox_information_dispaly.Name = "listBox_information_dispaly";
            listBox_information_dispaly.Size = new Size(372, 264);
            listBox_information_dispaly.TabIndex = 16;
            // 
            // input_rank
            // 
            input_rank.FormattingEnabled = true;
            input_rank.Items.AddRange(new object[] { "ID", "成绩", "姓名" });
            input_rank.Location = new Point(336, 424);
            input_rank.Name = "input_rank";
            input_rank.Size = new Size(215, 28);
            input_rank.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 23);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 18;
            label5.Text = "ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(476, 23);
            label6.Name = "label6";
            label6.Size = new Size(41, 20);
            label6.TabIndex = 19;
            label6.Text = "姓名";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(585, 23);
            label7.Name = "label7";
            label7.Size = new Size(41, 20);
            label7.TabIndex = 20;
            label7.Text = "成绩";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 581);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(input_rank);
            Controls.Add(listBox_information_dispaly);
            Controls.Add(label_display_outcome);
            Controls.Add(button_rank);
            Controls.Add(button_search);
            Controls.Add(input_search);
            Controls.Add(button_statistic_score);
            Controls.Add(button_update_score);
            Controls.Add(button_add_student);
            Controls.Add(input_score);
            Controls.Add(input_name);
            Controls.Add(input_ID);
            Controls.Add(label_score);
            Controls.Add(label_name);
            Controls.Add(label_ID);
            Name = "Form1";
            Text = "学生成绩管理系统";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ID;
        private Label label_name;
        private Label label_score;
        private TextBox input_ID;
        private TextBox input_name;
        private TextBox input_score;
        private Button button_add_student;
        private Button button_update_score;
        private Button button_statistic_score;
        private TextBox input_search;
        private Button button_search;
        private Button button_rank;
        private Label label_display_outcome;
        private ListBox listBox_information_dispaly;
        private ComboBox input_rank;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}
