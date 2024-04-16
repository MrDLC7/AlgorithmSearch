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
        Numbers[]? numbers;
        long target = 0;

        //  Створення списку
        private void button_Generate_Visible_List_Click(object sender, EventArgs e)
        {
            //  Кількість номерів у списку
            int size_list = Convert.ToInt32(textBox_NumsCount.Text);

            //  Виділення пам'яті
            numbers = new Numbers[size_list];

            //  Створення списку
            Generate generate = new Generate(numbers, size_list);

            //  Завантаження списку в поле "Список"
            richTextBox_List.Text = Print.InfoList(numbers);

            //  Завантаження списку виконаних дій в поле "Лог"
            richTextBox_Log.Text = Print.InfoLog("Формування списку", "номерів", generate._Time, "мк");
        }

        //  Вибрати весь текст при натиску на поле ТекстБокс
        private void textBox_SellectAll_Click(object sender, EventArgs e)
        {
            TextBox? clickedTextBox = sender as TextBox;
            if (clickedTextBox != null)
            {
                clickedTextBox.SelectAll();
            }
        }

        //  Пошук номеру "Лінійним пошуком"
        private void button_LinearSearch_Click(object sender, EventArgs e)
        {
            //  Якщо введено номер в поле пошуку
            if (target != 0)
            {
                //  Створення об'єкта лінійного пошуку
                LinearSearch linearSearch = new LinearSearch(numbers, target);
                
                //  Виведення виконаних дій при пошуку
                richTextBox_Log.Text += Print.InfoLogSearch("Лінійний пошук", "+" + target.ToString(), linearSearch._Time, "мк", linearSearch._Result, linearSearch._Step);
                target = 0;
            }
        }

        //  Правильність введеного номеру
        private void button_ok_FindNumber_Search_Click(object sender, EventArgs e)
        {
            long result;                //  Правильний поточний номер
            long min = 380000000000;    //  Мінімальний номер
            long max = 381000000000;    //  Максимальний номер
            if (long.TryParse(textBox_FindNumber_LinearSearch.Text, out result))
            {
                
                if (result > min && result < max)
                {
                    //  Збереження правильного номеру
                    target = result;
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

