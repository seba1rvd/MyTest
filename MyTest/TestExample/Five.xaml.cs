﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MyTest.TestExample
{
    /// <summary>
    /// Логика взаимодействия для Five.xaml
    /// </summary>
    public partial class Five : Page
    {
        public Five()
        {
            InitializeComponent();
        }
        private void SaveAnswer_Click(object sender, RoutedEventArgs e)
        {
            // получаем ответ из TextBox
            string answer = answerTextBox.Text;

            // сохраняем ответ в файл
            string filePath = "answer5.txt";
            File.WriteAllText(filePath, answer);
        }
        private void Five_Loaded(object sender, RoutedEventArgs e)
        {
            string filename = "answer5.txt";

            // Проверить наличие файла
            if (File.Exists(filename))
            {
                // Получить сохраненный ответ из файла
                string answer = File.ReadAllText(filename);

                // Установить сохраненный ответ в TextBox
                answerTextBox.Text = answer;
            }
        }
    }
}
