using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Лабораторная4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = "text1.txt";
        public MainWindow()
        {
            InitializeComponent();
            LoadNotes();

        }
        private void LoadNotes()
        {

            if (File.Exists("text1.txt"))
            {
                main.Text = File.ReadAllText("text1.txt");
                main.Text = string.Join(Environment.NewLine, main.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
            }
        }
        private void SaveNotes()
        {
            main.Text = string.Join(Environment.NewLine, main.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries));
            File.WriteAllText(path, main.Text);
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveNotes();
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string colorName = ((TextBlock)comboBox.SelectedItem).Name;

            switch (colorName)
            {
                case "red":
                    main.Background = Brushes.Red;
                    break;
                case "yellow":
                    main.Background = Brushes.Yellow;
                    break;
                case "green":
                    main.Background = Brushes.Green;
                    break;
                case "blue":
                    main.Background = Brushes.Blue;
                    break;
                case "white":
                    main.Background = Brushes.White;
                    break;
                default:
                    break;
            }
        }

        private void fonttypee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string colorName = ((TextBlock)comboBox.SelectedItem).Name;
            FontFamily customFontA = new("Arial");
            FontFamily customFontB = new("Dubai");
            FontFamily customFontC = new("Impact");
            FontFamily customFontD = new("Monotype Corsiva");

            switch (colorName)
            {
                case "Arial":
                    main.FontFamily = customFontA;
                    break;
                case "Dubai":
                    main.FontFamily = customFontB;
                    break;
                case "Impact":
                    main.FontFamily = customFontC;
                    break;
                case "Monotype_Corsiva":
                    main.FontFamily = customFontD;
                    break;
                default:
                    break;
            }
        }

        private void main_TextChanged(object sender, TextChangedEventArgs e)
        {
            Text_change();
        }
        private void Text_change()
        {
            File.WriteAllText(path, main.Text);
        }
        private void sizeshr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string colorName = ((TextBlock)comboBox.SelectedItem).Name;
            switch (colorName)
            {
                case "s11":
                    main.FontSize = 11;
                    break;
                case "s12":
                    main.FontSize = 12;
                    break;
                case "s13":
                    main.FontSize = 13;
                    break;
                case "s14":
                    main.FontSize = 14;
                    break;
                default:
                    break;
            }
        }


    }
}
