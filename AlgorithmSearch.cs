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
            public long value;
            public int index;
            public int hash;
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

        //  Правильність введеного номеру
        private void button_ok_FindNumber_Search_Click(object sender, EventArgs e)
        {
            long result = 0;                //  Правильний поточний номер
            long min = 380000000000;        //  Мінімальний номер
            long max = 381000000000;        //  Максимальний номер

            Button? clickedButton = sender as Button;

            if (clickedButton == button_ok_FindNumber_LinearSearch && long.TryParse(textBox_FindNumber_LinearSearch.Text, out result))
            {
            }
            else if (clickedButton == button_ok_FindNumber_BinarySearch && long.TryParse(textBox_FindNumber_BinarySearch.Text, out result))
            {
            }
            else if (clickedButton == button_ok_FindNumber_HashTableSearch && long.TryParse(textBox_FindNumber_HashTableSearch.Text, out result))
            {
            }
            else
            {
                MessageBox.Show("Шукати тільки номер\nЗразок: 380*********");
                return;
            }

            if (result > min && result < max)
            {
                //  Збереження правильного номеру
                target = result;
                richTextBox_Log.Text += $"Номер: +{result}\n";
            }
            else
            {
                MessageBox.Show("Невірний номер\nЗразок: 380*********");
            }
        }

        //  "Лінійний пошук"
        private void button_LinearSearch_Click(object sender, EventArgs e)
        {
            //  Якщо введено номер в поле пошуку
            if (target != 0)
            {
                //  Створення об'єкта лінійного пошуку
                LinearSearch linearSearch = new LinearSearch(numbers, target);

                //  Виведення виконаних дій при пошуку
                richTextBox_Log.Text += Print.InfoLog("Лінійний пошук", "+" + target.ToString(),
                    linearSearch._Time, "мк", linearSearch._Result, linearSearch._Step);
                target = 0;
            }
        }

        //  "Бінарний пошук"
        private void button_BinarySearch_Click(object sender, EventArgs e)
        {
            //  Якщо введено номер в поле пошуку
            if (target != 0)
            {
                //  Створення об'єкта лінійного пошуку
                BinarySearch binarySearch = new BinarySearch(numbers, target);

                //  Оновити "Список"
                richTextBox_List.Text = Print.InfoList(numbers);

                //  Виведення дії "Cортування"
                richTextBox_Log.Text += Print.InfoLog("Сортування номерів", "за зростанням",
                    binarySearch._Time_Sort, "мк");

                //  Виведення виконаних дій при пошуку
                richTextBox_Log.Text += Print.InfoLog("Бінарний пошук", "+" + target.ToString(),
                    binarySearch._Time, "мк", binarySearch._Result, binarySearch._Step);
                target = 0;
            }
        }

        //  "Пошук хеш-таблицею"
        private void button_HashTableSearch_Click(object sender, EventArgs e)
        {
            //  Якщо введено номер в поле пошуку
            if (target != 0)
            {
                //  Створення об'єкта лінійного пошуку
                HashTableSearch hashTableSearch = new HashTableSearch(numbers, target);

                //  Оновити "Список"
                richTextBox_List.Text = Print.InfoList(numbers);

                //  Виведення виконаних дій при пошуку
                richTextBox_Log.Text += Print.InfoLog("Пошук хеш-таблицею", "+" + target.ToString(),
                    hashTableSearch._Time, "мк", hashTableSearch._Result, hashTableSearch._Step);
                target = 0;
            }
        }
        
        //  Очищення "Список"
        private void button_Clear_List_Click(object sender, EventArgs e)
        {
            richTextBox_List.Text = Print.InfoListReset();
        }

        //  Очищення "Лог"
        private void button_Clear_Log_Click(object sender, EventArgs e)
        {
            richTextBox_Log.Text = Print.InfoLogReset();
        }
    }
}

