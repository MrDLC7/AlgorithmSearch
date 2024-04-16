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
        long target = 0;

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

        private void button_LinearSearch_Click(object sender, EventArgs e)
        {
            if (target != 0)
            {
                LinearSearch linearSearch = new LinearSearch(numbers, target);

                richTextBox_List.Text = Print.InfoList(numbers);
                richTextBox_Log.Text += Print.InfoLogSearch("Лінійний пошук", "+" + target.ToString(), linearSearch._Time, "мк", linearSearch._Result, linearSearch._Step);
                target = 0;
            }
        }

        private void button_ok_FindNumber_LinearSearch_Click(object sender, EventArgs e)
        {
            long result;
            long min = 380000000000;
            long max = 381000000000;
            if (long.TryParse(textBox_FindNumber_LinearSearch.Text, out result))
            {
                target = result;
                if (result > min && result < max)
                {
                    richTextBox_Log.Text += $"Шукати: +{textBox_FindNumber_LinearSearch.Text}\n";
                }
                else
                {
                    MessageBox.Show("Невірний номер\nЗразок: 380*********");
                }

            }
            else
            {
                MessageBox.Show("Шукати тільки номер");
            }
        }
    }
}

