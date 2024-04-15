using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgorithmSearch;
using Microsoft.VisualBasic.Logging;

namespace AlgorithmSearch
{
    public partial class AlgorithmSearch : Form
    {
        public AlgorithmSearch()
        {
            InitializeComponent();
        }

        public struct Numbers
        {
            public long key;
            public int index;
            public string value;
            public string hash;
        }
        Numbers[] numbers;
        long target_linearSearch = 0;

        private void button_Generate_Visible_List_Click(object sender, EventArgs e)
        {
            int size_list = Convert.ToInt32(textBox_NumsCount.Text);
            numbers = new Numbers[size_list];

            Generate generate = new Generate(numbers, size_list);
            richTextBox_List.Text = Print.InfoList(numbers);
            richTextBox_Log.Text = Print.InfoLog("Формування списку", "номерів", generate._Time, "мк");
        }

        private void textBox_SellectAll_Click(object sender, EventArgs e)
        {
            TextBox? clickedTextBox = sender as TextBox;
            if (clickedTextBox != null)
            {
                clickedTextBox.SelectAll();
            }
        }

        private void button_LineSearch_Click(object sender, EventArgs e)
        {
            if (target_linearSearch != 0)
            {
                LinearSearch linearSearch = new LinearSearch(numbers, target_linearSearch);

                richTextBox_List.Text = Print.InfoList(numbers);
                richTextBox_Log.Text = Print.InfoLog("Лінійний пошук", target_linearSearch.ToString(), linearSearch._Time, "мк");
                target_linearSearch = 0;
            }
        }

        private void button_ok_FindNumber_LinearSearch_Click(object sender, EventArgs e)
        {
            long result;
            if (long.TryParse(textBox_FindNumber_LinearSearch.Text, out result))
            {
                target_linearSearch = result;
            }
            else
            {
                MessageBox.Show("Шукати тільки номер");
                textBox_FindNumber_LinearSearch.SelectAll();
            }
        }
    }
}

