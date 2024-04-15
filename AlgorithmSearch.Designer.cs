namespace AlgorithmSearch
{
    partial class AlgorithmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlgorithmSearch));
            panelMain = new Panel();
            textBox_NumsCount = new TextBox();
            lbl_log = new Label();
            lbl_list = new Label();
            richTextBox_Log = new RichTextBox();
            btn_ok_Key = new Button();
            lbl_key = new Label();
            textBox_Key = new TextBox();
            btn_Generate_Visible_List = new Button();
            button_HashTableSearch = new Button();
            lbl_numsCount = new Label();
            button_BinarySearch = new Button();
            button_LineSearch = new Button();
            richTextBox_List = new RichTextBox();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(textBox_NumsCount);
            panelMain.Controls.Add(lbl_log);
            panelMain.Controls.Add(lbl_list);
            panelMain.Controls.Add(richTextBox_Log);
            panelMain.Controls.Add(btn_ok_Key);
            panelMain.Controls.Add(lbl_key);
            panelMain.Controls.Add(textBox_Key);
            panelMain.Controls.Add(btn_Generate_Visible_List);
            panelMain.Controls.Add(button_HashTableSearch);
            panelMain.Controls.Add(lbl_numsCount);
            panelMain.Controls.Add(button_BinarySearch);
            panelMain.Controls.Add(button_LineSearch);
            panelMain.Controls.Add(richTextBox_List);
            panelMain.Location = new Point(2, 1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1178, 525);
            panelMain.TabIndex = 0;
            // 
            // textBox_NumsCount
            // 
            textBox_NumsCount.Location = new Point(189, 32);
            textBox_NumsCount.Name = "textBox_NumsCount";
            textBox_NumsCount.Size = new Size(126, 27);
            textBox_NumsCount.TabIndex = 14;
            textBox_NumsCount.Text = "10";
            textBox_NumsCount.TextAlign = HorizontalAlignment.Center;
            textBox_NumsCount.Click += textBox_SellectAll_Click;
            // 
            // lbl_log
            // 
            lbl_log.AutoSize = true;
            lbl_log.Location = new Point(943, 35);
            lbl_log.Name = "lbl_log";
            lbl_log.Size = new Size(35, 20);
            lbl_log.TabIndex = 13;
            lbl_log.Text = "Лог";
            // 
            // lbl_list
            // 
            lbl_list.AutoSize = true;
            lbl_list.Location = new Point(519, 35);
            lbl_list.Name = "lbl_list";
            lbl_list.Size = new Size(60, 20);
            lbl_list.TabIndex = 12;
            lbl_list.Text = "Список";
            // 
            // richTextBox_Log
            // 
            richTextBox_Log.BackColor = SystemColors.InactiveBorder;
            richTextBox_Log.Location = new Point(761, 67);
            richTextBox_Log.Name = "richTextBox_Log";
            richTextBox_Log.ReadOnly = true;
            richTextBox_Log.Size = new Size(380, 428);
            richTextBox_Log.TabIndex = 11;
            richTextBox_Log.Text = "";
            // 
            // btn_ok_Key
            // 
            btn_ok_Key.AutoSize = true;
            btn_ok_Key.Image = (Image)resources.GetObject("btn_ok_Key.Image");
            btn_ok_Key.Location = new Point(286, 156);
            btn_ok_Key.Name = "btn_ok_Key";
            btn_ok_Key.Size = new Size(29, 29);
            btn_ok_Key.TabIndex = 10;
            btn_ok_Key.UseVisualStyleBackColor = true;
            // 
            // lbl_key
            // 
            lbl_key.AutoSize = true;
            lbl_key.Location = new Point(41, 160);
            lbl_key.Name = "lbl_key";
            lbl_key.Size = new Size(55, 20);
            lbl_key.TabIndex = 9;
            lbl_key.Text = "Ключ:";
            // 
            // textBox_Key
            // 
            textBox_Key.Location = new Point(102, 157);
            textBox_Key.Name = "textBox_Key";
            textBox_Key.Size = new Size(178, 27);
            textBox_Key.TabIndex = 8;
            textBox_Key.Text = "Key";
            textBox_Key.TextAlign = HorizontalAlignment.Center;
            textBox_Key.Click += textBox_SellectAll_Click;
            // 
            // btn_Generate_Visible_List
            // 
            btn_Generate_Visible_List.Location = new Point(41, 86);
            btn_Generate_Visible_List.Name = "btn_Generate_Visible_List";
            btn_Generate_Visible_List.Size = new Size(275, 45);
            btn_Generate_Visible_List.TabIndex = 7;
            btn_Generate_Visible_List.Text = "Сформувати і відобразити список";
            btn_Generate_Visible_List.UseVisualStyleBackColor = true;
            btn_Generate_Visible_List.Click += button_Generate_Visible_List_Click;
            // 
            // button_HashTableSearch
            // 
            button_HashTableSearch.Location = new Point(80, 332);
            button_HashTableSearch.Name = "button_HashTableSearch";
            button_HashTableSearch.Size = new Size(200, 45);
            button_HashTableSearch.TabIndex = 6;
            button_HashTableSearch.Text = "Пошук по хеш-таблиці";
            button_HashTableSearch.UseVisualStyleBackColor = true;
            // 
            // lbl_numsCount
            // 
            lbl_numsCount.AutoSize = true;
            lbl_numsCount.Location = new Point(41, 35);
            lbl_numsCount.Name = "lbl_numsCount";
            lbl_numsCount.Size = new Size(142, 20);
            lbl_numsCount.TabIndex = 4;
            lbl_numsCount.Text = "Кількість номерів:";
            // 
            // button_BinarySearch
            // 
            button_BinarySearch.Location = new Point(80, 270);
            button_BinarySearch.Name = "button_BinarySearch";
            button_BinarySearch.Size = new Size(200, 45);
            button_BinarySearch.TabIndex = 2;
            button_BinarySearch.Text = "Бінарний пошук";
            button_BinarySearch.UseVisualStyleBackColor = true;
            // 
            // button_LineSearch
            // 
            button_LineSearch.Location = new Point(80, 208);
            button_LineSearch.Name = "button_LineSearch";
            button_LineSearch.Size = new Size(200, 45);
            button_LineSearch.TabIndex = 1;
            button_LineSearch.Text = "Лінійний пошук";
            button_LineSearch.UseVisualStyleBackColor = true;
            // 
            // richTextBox_List
            // 
            richTextBox_List.BackColor = SystemColors.InactiveBorder;
            richTextBox_List.Location = new Point(350, 67);
            richTextBox_List.Name = "richTextBox_List";
            richTextBox_List.ReadOnly = true;
            richTextBox_List.Size = new Size(380, 428);
            richTextBox_List.TabIndex = 0;
            richTextBox_List.Text = "";
            // 
            // AlgorithmSearch
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 528);
            Controls.Add(panelMain);
            MaximumSize = new Size(1200, 575);
            MinimumSize = new Size(1200, 575);
            Name = "AlgorithmSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AlgorithmSearch";
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Button button_BinarySearch;
        private Button button_LineSearch;
        private Label lbl_numsCount;
        private Button button_HashTableSearch;
        private Button btn_Generate_Visible_List;
        private TextBox textBox_Key;
        private Label lbl_key;
        private Button btn_ok_Key;
        private Label lbl_log;
        private Label lbl_list;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private TextBox textBox_NumsCount;
        public RichTextBox richTextBox_Log;
        public RichTextBox richTextBox_List;
    }
}