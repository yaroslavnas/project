using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoaderScreens
{
	/// <summary>
	/// Interaction logic for Screen_1.xaml
	/// </summary>
	public partial class Screen_1 : UserControl
	{
		public Screen_1()
		{
			this.InitializeComponent();
		}

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            int n = rand.Next(1, 4);
            switch (n)
            {
                case 1:
                    {
                        type.Text = "Документ";
                        break;
                    }
                case 2:
                    {
                        type.Text = "Элемент";
                        break;
                    }
                case 3:
                    {
                        type.Text = "Изображение";
                        break;
                    }
            }
            add.IsEnabled = true;
        }
        List<string> names = new List<string>();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (type.Text == "")
            {
                MessageBox.Show("Не выбран объект!");
                return;
            }
            if (name.Text != "")
            {
                if (names.Contains(name.Text))
                    MessageBox.Show("Выбранный объект уже существует!");
                else
                {
                    names.Add(name.Text);
                    id.Text = "ID_" + name.Text;
                    string g = "Объект типа " + "<" + type.Text + "> " + name.Text + " " + id.Text + Environment.NewLine;
                    box.Items.Add(g);
                    type.Text = "";
                }
                
            }
            else
                MessageBox.Show("Задайте имя для обьекта");
          


            }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (box.SelectedIndex != -1)
            {
                MessageBox.Show("Элемент успешно загружен!");
                box.Items.Remove(box.SelectedItem);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (box.SelectedIndex != -1)
            {
                box.Items.Remove(box.SelectedItem);
                MessageBox.Show("Элемент успешно удален!");
            }
                       
        }

        }
	}
