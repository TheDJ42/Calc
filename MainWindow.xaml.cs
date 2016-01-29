﻿using System;
using System.Collections.Generic;
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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { // Create a Varible Called Total and set it to Zero 
        int total = 0;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Value0_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            // Read Values from Text
            int value0 = Convert.ToInt32(textBoxValue0.Text);
            int value1 = Convert.ToInt32(textBoxValue1.Text);
            int value2 = Convert.ToInt32(textBoxValue2.Text);

            // Add the Three Answers
            int sum = value0 + value1 + value2;

            // Display Answer
            Answer.Text = Convert.ToString(sum);

            // Update Total
            total = total + sum;

            // Display Total in textbox
            Text_Total.Text = Convert.ToString(total); 
            
        }

        private void Subtact_Click(object sender, RoutedEventArgs e)
        {
            // Read Values from Text
            int value0 = Convert.ToInt32(textBoxValue0.Text);
            int value1 = Convert.ToInt32(textBoxValue1.Text);
            int value2 = Convert.ToInt32(textBoxValue2.Text);

            // Add the Three Answers
            int difference = value0 - value1 - value2;

            // Display Answer
            Answer.Text = Convert.ToString(difference);
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            // Read Values from Text
            int value0 = Convert.ToInt32(textBoxValue0.Text);
            int value1 = Convert.ToInt32(textBoxValue1.Text);
            int value2 = Convert.ToInt32(textBoxValue2.Text);

            // Add the Three Answers
            int Product = value0 * value1 * value2;

            // Display Answer
            Answer.Text = Convert.ToString(Product);
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            // Read Values from Text
            int value0 = Convert.ToInt32(textBoxValue0.Text);
            int value1 = Convert.ToInt32(textBoxValue1.Text);
            int value2 = Convert.ToInt32(textBoxValue2.Text);

            // Add the Three Answers
            int quotient = value0 / value1 / value2;

            // Display Answer
            Answer.Text = Convert.ToString(quotient);
        }

        private void Average_Click(object sender, RoutedEventArgs e)
        {
            // Read Values from Text
            int value0 = Convert.ToInt32(textBoxValue0.Text);
            int value1 = Convert.ToInt32(textBoxValue1.Text);
            int value2 = Convert.ToInt32(textBoxValue2.Text);

            // Add the Three Answers
            int Average = (value0 + value1 + value2) / 3;

            // Display Answer
            Answer.Text = Convert.ToString(Average);
        }
    }
}
