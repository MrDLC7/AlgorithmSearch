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
            button_ok_FindNumber_BinarySearch = new Button();
            lbl_find_Binary = new Label();
            textBox_FindNumber_BinarySearch = new TextBox();
            button_ok_FindNumber_LinearSearch = new Button();
            lbl_find_Linear = new Label();
            textBox_FindNumber_LinearSearch = new TextBox();
            textBox_NumsCount = new TextBox();
            lbl_log = new Label();
            lbl_list = new Label();
            richTextBox_Log = new RichTextBox();
            button_ok_KeyFind_HashTableSearch = new Button();
            lbl_keyFind_HashTableSearch = new Label();
            textBox_KeyFind_HashTableSearch = new TextBox();
            btn_Generate_Visible_List = new Button();
            button_HashTableSearch = new Button();
            lbl_numsCount = new Label();
            button_BinarySearch = new Button();
            button_LineSearch = new Button();
            richTextBox_List = new RichTextBox();
            panel_List = new Panel();
            panel_Linear = new Panel();
            panel_HashTable = new Panel();
            panel_Binary = new Panel();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(button_ok_FindNumber_BinarySearch);
            panelMain.Controls.Add(lbl_find_Binary);
            panelMain.Controls.Add(textBox_FindNumber_BinarySearch);
            panelMain.Controls.Add(button_ok_FindNumber_LinearSearch);
            panelMain.Controls.Add(lbl_find_Linear);
            panelMain.Controls.Add(textBox_FindNumber_LinearSearch);
            panelMain.Controls.Add(textBox_NumsCount);
            panelMain.Controls.Add(lbl_log);
            panelMain.Controls.Add(lbl_list);
            panelMain.Controls.Add(richTextBox_Log);
            panelMain.Controls.Add(button_ok_KeyFind_HashTableSearch);
            panelMain.Controls.Add(lbl_keyFind_HashTableSearch);
            panelMain.Controls.Add(textBox_KeyFind_HashTableSearch);
            panelMain.Controls.Add(btn_Generate_Visible_List);
            panelMain.Controls.Add(button_HashTableSearch);
            panelMain.Controls.Add(lbl_numsCount);
            panelMain.Controls.Add(button_BinarySearch);
            panelMain.Controls.Add(button_LineSearch);
            panelMain.Controls.Add(richTextBox_List);
            panelMain.Controls.Add(panel_List);
            panelMain.Controls.Add(panel_Linear);
            panelMain.Controls.Add(panel_HashTable);
            panelMain.Controls.Add(panel_Binary);
            panelMain.Location = new Point(2, 1);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1178, 525);
            panelMain.TabIndex = 0;
            // 
            // button_ok_FindNumber_BinarySearch
            // 
            button_ok_FindNumber_BinarySearch.AutoSize = true;
            button_ok_FindNumber_BinarySearch.Image = (Image)resources.GetObject("button_ok_FindNumber_BinarySearch.Image");
            button_ok_FindNumber_BinarySearch.Location = new Point(286, 279);
            button_ok_FindNumber_BinarySearch.Name = "button_ok_FindNumber_BinarySearch";
            button_ok_FindNumber_BinarySearch.Size = new Size(29, 29);
            button_ok_FindNumber_BinarySearch.TabIndex = 20;
            button_ok_FindNumber_BinarySearch.UseVisualStyleBackColor = true;
            button_ok_FindNumber_BinarySearch.Click += button_ok_FindNumber_Search_Click;
            // 
            // lbl_find_Binary
            // 
            lbl_find_Binary.AutoSize = true;
            lbl_find_Binary.Location = new Point(41, 283);
            lbl_find_Binary.Name = "lbl_find_Binary";
            lbl_find_Binary.Size = new Size(68, 20);
            lbl_find_Binary.TabIndex = 19;
            lbl_find_Binary.Text = "Шукати:";
            // 
            // textBox_FindNumber_BinarySearch
            // 
            textBox_FindNumber_BinarySearch.Location = new Point(115, 280);
            textBox_FindNumber_BinarySearch.Name = "textBox_FindNumber_BinarySearch";
            textBox_FindNumber_BinarySearch.Size = new Size(165, 27);
            textBox_FindNumber_BinarySearch.TabIndex = 18;
            textBox_FindNumber_BinarySearch.Text = "Номер";
            textBox_FindNumber_BinarySearch.TextAlign = HorizontalAlignment.Center;
            textBox_FindNumber_BinarySearch.Click += textBox_SellectAll_Click;
            // 
            // button_ok_FindNumber_LinearSearch
            // 
            button_ok_FindNumber_LinearSearch.AutoSize = true;
            button_ok_FindNumber_LinearSearch.Image = (Image)resources.GetObject("button_ok_FindNumber_LinearSearch.Image");
            button_ok_FindNumber_LinearSearch.Location = new Point(286, 158);
            button_ok_FindNumber_LinearSearch.Name = "button_ok_FindNumber_LinearSearch";
            button_ok_FindNumber_LinearSearch.Size = new Size(29, 29);
            button_ok_FindNumber_LinearSearch.TabIndex = 17;
            button_ok_FindNumber_LinearSearch.UseVisualStyleBackColor = true;
            button_ok_FindNumber_LinearSearch.Click += button_ok_FindNumber_Search_Click;
            // 
            // lbl_find_Linear
            // 
            lbl_find_Linear.AutoSize = true;
            lbl_find_Linear.Location = new Point(41, 162);
            lbl_find_Linear.Name = "lbl_find_Linear";
            lbl_find_Linear.Size = new Size(68, 20);
            lbl_find_Linear.TabIndex = 16;
            lbl_find_Linear.Text = "Шукати:";
            // 
            // textBox_FindNumber_LinearSearch
            // 
            textBox_FindNumber_LinearSearch.Location = new Point(115, 159);
            textBox_FindNumber_LinearSearch.Name = "textBox_FindNumber_LinearSearch";
            textBox_FindNumber_LinearSearch.Size = new Size(165, 27);
            textBox_FindNumber_LinearSearch.TabIndex = 15;
            textBox_FindNumber_LinearSearch.Text = "Номер";
            textBox_FindNumber_LinearSearch.TextAlign = HorizontalAlignment.Center;
            textBox_FindNumber_LinearSearch.Click += textBox_SellectAll_Click;
            // 
            // textBox_NumsCount
            // 
            textBox_NumsCount.Location = new Point(189, 37);
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
            // button_ok_KeyFind_HashTableSearch
            // 
            button_ok_KeyFind_HashTableSearch.AutoSize = true;
            button_ok_KeyFind_HashTableSearch.Image = (Image)resources.GetObject("button_ok_KeyFind_HashTableSearch.Image");
            button_ok_KeyFind_HashTableSearch.Location = new Point(286, 402);
            button_ok_KeyFind_HashTableSearch.Name = "button_ok_KeyFind_HashTableSearch";
            button_ok_KeyFind_HashTableSearch.Size = new Size(29, 29);
            button_ok_KeyFind_HashTableSearch.TabIndex = 10;
            button_ok_KeyFind_HashTableSearch.UseVisualStyleBackColor = true;
            // 
            // lbl_keyFind_HashTableSearch
            // 
            lbl_keyFind_HashTableSearch.AutoSize = true;
            lbl_keyFind_HashTableSearch.Location = new Point(41, 406);
            lbl_keyFind_HashTableSearch.Name = "lbl_keyFind_HashTableSearch";
            lbl_keyFind_HashTableSearch.Size = new Size(68, 20);
            lbl_keyFind_HashTableSearch.TabIndex = 9;
            lbl_keyFind_HashTableSearch.Text = "Шукати:";
            // 
            // textBox_KeyFind_HashTableSearch
            // 
            textBox_KeyFind_HashTableSearch.Location = new Point(115, 403);
            textBox_KeyFind_HashTableSearch.Name = "textBox_KeyFind_HashTableSearch";
            textBox_KeyFind_HashTableSearch.Size = new Size(165, 27);
            textBox_KeyFind_HashTableSearch.TabIndex = 8;
            textBox_KeyFind_HashTableSearch.Text = "Ключ";
            textBox_KeyFind_HashTableSearch.TextAlign = HorizontalAlignment.Center;
            textBox_KeyFind_HashTableSearch.Click += textBox_SellectAll_Click;
            // 
            // btn_Generate_Visible_List
            // 
            btn_Generate_Visible_List.Location = new Point(41, 81);
            btn_Generate_Visible_List.Name = "btn_Generate_Visible_List";
            btn_Generate_Visible_List.Size = new Size(275, 45);
            btn_Generate_Visible_List.TabIndex = 7;
            btn_Generate_Visible_List.Text = "Сформувати і відобразити список";
            btn_Generate_Visible_List.UseVisualStyleBackColor = true;
            btn_Generate_Visible_List.Click += button_Generate_Visible_List_Click;
            // 
            // button_HashTableSearch
            // 
            button_HashTableSearch.Location = new Point(41, 446);
            button_HashTableSearch.Name = "button_HashTableSearch";
            button_HashTableSearch.Size = new Size(274, 45);
            button_HashTableSearch.TabIndex = 6;
            button_HashTableSearch.Text = "Пошук по хеш-таблиці";
            button_HashTableSearch.UseVisualStyleBackColor = true;
            // 
            // lbl_numsCount
            // 
            lbl_numsCount.AutoSize = true;
            lbl_numsCount.Location = new Point(41, 40);
            lbl_numsCount.Name = "lbl_numsCount";
            lbl_numsCount.Size = new Size(142, 20);
            lbl_numsCount.TabIndex = 4;
            lbl_numsCount.Text = "Кількість номерів:";
            // 
            // button_BinarySearch
            // 
            button_BinarySearch.Location = new Point(41, 324);
            button_BinarySearch.Name = "button_BinarySearch";
            button_BinarySearch.Size = new Size(274, 45);
            button_BinarySearch.TabIndex = 2;
            button_BinarySearch.Text = "Бінарний пошук";
            button_BinarySearch.UseVisualStyleBackColor = true;
            // 
            // button_LineSearch
            // 
            button_LineSearch.Location = new Point(41, 203);
            button_LineSearch.Name = "button_LineSearch";
            button_LineSearch.Size = new Size(274, 45);
            button_LineSearch.TabIndex = 1;
            button_LineSearch.Text = "Лінійний пошук";
            button_LineSearch.UseVisualStyleBackColor = true;
            button_LineSearch.Click += button_LinearSearch_Click;
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
            // panel_List
            // 
            panel_List.BackColor = SystemColors.Window;
            panel_List.Location = new Point(19, 23);
            panel_List.Name = "panel_List";
            panel_List.Size = new Size(316, 116);
            panel_List.TabIndex = 21;
            // 
            // panel_Linear
            // 
            panel_Linear.BackColor = SystemColors.Window;
            panel_Linear.Location = new Point(19, 145);
            panel_Linear.Name = "panel_Linear";
            panel_Linear.Size = new Size(316, 116);
            panel_Linear.TabIndex = 22;
            // 
            // panel_HashTable
            // 
            panel_HashTable.BackColor = SystemColors.Window;
            panel_HashTable.Location = new Point(19, 388);
            panel_HashTable.Name = "panel_HashTable";
            panel_HashTable.Size = new Size(316, 116);
            panel_HashTable.TabIndex = 23;
            // 
            // panel_Binary
            // 
            panel_Binary.BackColor = SystemColors.Window;
            panel_Binary.Location = new Point(19, 266);
            panel_Binary.Name = "panel_Binary";
            panel_Binary.Size = new Size(316, 116);
            panel_Binary.TabIndex = 24;
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
        private TextBox textBox_KeyFind_HashTableSearch;
        private Label lbl_keyFind_HashTableSearch;
        private Button button_ok_KeyFind_HashTableSearch;
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
        private Button button_ok_FindNumber_LinearSearch;
        private Label lbl_find_Linear;
        private TextBox textBox_FindNumber_LinearSearch;
        private Button button_ok_FindNumber_BinarySearch;
        private Label lbl_find_Binary;
        private TextBox textBox_FindNumber_BinarySearch;
        private Panel panel_List;
        private Panel panel_Linear;
        private Panel panel_HashTable;
        private Panel panel_Binary;
    }
}