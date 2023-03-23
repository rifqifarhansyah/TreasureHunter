using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
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
using TreasureHunterAlgo;
using System.ComponentModel.Design;
using System.Windows.Threading;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace TreasureHunterApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Maze m;
        string txtFileName;
        bool chooseFileWithDialog;
        string startDir;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void visualizeButton_Click(object sender, RoutedEventArgs e)
        {
            mazeGrid.Children.Clear();
            mazeGrid.RowDefinitions.Clear();
            mazeGrid.ColumnDefinitions.Clear();
            imageGrid.Children.Clear();
            imageGrid.RowDefinitions.Clear();
            imageGrid.ColumnDefinitions.Clear();
            if (!chooseFileWithDialog)
            {
                string curFilePath = startDir + "\\" + txtFileName;
                if (System.IO.File.Exists(curFilePath))
                {
                    if (System.IO.Path.GetExtension(curFilePath) != ".txt")
                    {
                        this.fileName.Text = "Invalid extension";
                    }
                    else
                    {
                        m = new Maze(curFilePath);
                        if (!this.m.Valid)
                        {
                            this.fileName.Text = "File content not valid";
                        }
                        else
                        {
                            this.fileName.Text = System.IO.Path.GetFileName(curFilePath);
                        }
                    }
                }
                else
                {
                    this.fileName.Text = "File doesn't exist";
                }
            }
            if (this.m != null && this.m.Valid)
            {
                for (int i = 0; i < this.m.Width; i++)
                {
                    mazeGrid.RowDefinitions.Add(new RowDefinition());
                    imageGrid.RowDefinitions.Add(new RowDefinition());
                }
                for (int i = 0; i < this.m.Length; i++)
                {
                    mazeGrid.ColumnDefinitions.Add(new ColumnDefinition());
                    imageGrid.ColumnDefinitions.Add(new ColumnDefinition());
                }
                TextBox cell;
                for (int i = 0; i < this.m.Width; i++)
                {
                    for (int j = 0; j < this.m.Length; j++)
                    {
                        cell = new TextBox();
                        SolidColorBrush brush;
                        if (this.m.Content[i][j] == "X")
                        {
                            Color backBlack = (Color)ColorConverter.ConvertFromString("#FF16151A");
                            brush = new SolidColorBrush(backBlack);
                        }
                        else
                        {
                            brush = new SolidColorBrush(Colors.White);
                        }
                        Color backGrey = (Color)ColorConverter.ConvertFromString("#FF7A7776");
                        SolidColorBrush border = new SolidColorBrush(backGrey);
                        cell.Background = brush;
                        cell.BorderBrush = border;
                        mazeGrid.Children.Add(cell);
                        Grid.SetColumn(cell, j);
                        Grid.SetRow(cell, i);
                        if (this.m.Content[i][j] == "K" || this.m.Content[i][j] == "T")
                        {
                            var image = new Image();
                            if (this.m.Content[i][j] == "K")
                            {
                                image.Source = new BitmapImage(new Uri("D:\\ITB\\Semester 4\\Strategi Algoritma\\Tubes2_13521099\\img\\KrustyKrab.png", UriKind.RelativeOrAbsolute));
                            }
                            else if (this.m.Content[i][j] == "T")
                            {
                                image.Source = new BitmapImage(new Uri("D:\\ITB\\Semester 4\\Strategi Algoritma\\Tubes2_13521099\\img\\Treasure.png", UriKind.RelativeOrAbsolute));
                            }
                            imageGrid.Children.Add(image);
                            Grid.SetColumn(image, j);
                            Grid.SetRow(image, i);
                        }
                    }
                }
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        public void changeLightGray(int i, int j)
        {
            TextBox element = mazeGrid.Children
                                .Cast<TextBox>()
                                .FirstOrDefault(ez => Grid.GetRow(ez) == i && Grid.GetColumn(ez) == j);
            SolidColorBrush white = new SolidColorBrush(Colors.White);
            SolidColorBrush gray = new SolidColorBrush(Colors.Gray);
            bool isWhite = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, white);
            if (isWhite)
            {
                element.Background = gray;
            }
        }
        public void changeGreen(int i, int j)
        {
            TextBox element = mazeGrid.Children
                                .Cast<TextBox>()
                                .FirstOrDefault(ez => Grid.GetRow(ez) == i && Grid.GetColumn(ez) == j);
            Color green1 = (Color)ColorConverter.ConvertFromString("#FFCE64C0");
            Color green2 = (Color)ColorConverter.ConvertFromString("#FFA63FBE");
            Color green3 = (Color)ColorConverter.ConvertFromString("#FF8510B7");
            Color green4 = (Color)ColorConverter.ConvertFromString("#FF6226F0");
            Color green5 = (Color)ColorConverter.ConvertFromString("#FF333DE6");
            Color green6 = (Color)ColorConverter.ConvertFromString("#FF0B00ED");
            Color green7 = (Color)ColorConverter.ConvertFromString("#FF0710A0");
            SolidColorBrush greenBrush_1 = new SolidColorBrush(green1);
            SolidColorBrush greenBrush_2 = new SolidColorBrush(green2);
            SolidColorBrush greenBrush_3 = new SolidColorBrush(green3);
            SolidColorBrush greenBrush_4 = new SolidColorBrush(green4);
            SolidColorBrush greenBrush_5 = new SolidColorBrush(green5);
            SolidColorBrush greenBrush_6 = new SolidColorBrush(green6);
            SolidColorBrush greenBrush_7 = new SolidColorBrush(green7);
            SolidColorBrush white = new SolidColorBrush(Colors.White);
            SolidColorBrush gray = new SolidColorBrush(Colors.Gray);
            bool isGray = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, gray);
            bool isWhite = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, white);
            bool isGreenBrush_1 = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, greenBrush_1);
            bool isGreenBrush_2 = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, greenBrush_2);
            bool isGreenBrush_3 = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, greenBrush_3);
            bool isGreenBrush_4 = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, greenBrush_4);
            bool isGreenBrush_5 = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, greenBrush_5);
            bool isGreenBrush_6 = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, greenBrush_6);
            bool isGreenBrush_7 = new SolidColorBrushComparer().Equals((SolidColorBrush)element.Background, greenBrush_7);
            if ((isGray || isWhite))
            {
                element.Background = greenBrush_1;
            } 
            else if (isGreenBrush_1) 
            {
                element.Background = greenBrush_2;
            }
            else if (isGreenBrush_2)
            {
                element.Background = greenBrush_3;
            }
            else if (isGreenBrush_3)
            {
                element.Background = greenBrush_4;
            }
            else if (isGreenBrush_4)
            {
                element.Background = greenBrush_5;
            }
            else if (isGreenBrush_5)
            {
                element.Background = greenBrush_6;
            }
            else if (isGreenBrush_6)
            {
                element.Background = greenBrush_7;
            }
        }
        public void changeWhite(int i, int j)
        {
            TextBox element = mazeGrid.Children
                                .Cast<TextBox>()
                                .FirstOrDefault(ez => Grid.GetRow(ez) == i && Grid.GetColumn(ez) == j);
            SolidColorBrush white = new SolidColorBrush(Colors.White);
            element.Background = white;
        }
        public void turnGreen(int i, int j)
        {
            TextBox element = mazeGrid.Children
                                .Cast<TextBox>()
                                .FirstOrDefault(ez => Grid.GetRow(ez) == i && Grid.GetColumn(ez) == j);
            SolidColorBrush darkGreen = new SolidColorBrush(Colors.DarkGreen);
            element.Background = darkGreen;
        }
        public void turnBlue(int i, int j)
        {
            TextBox element = mazeGrid.Children
                                .Cast<TextBox>()
                                .FirstOrDefault(ez => Grid.GetRow(ez) == i && Grid.GetColumn(ez) == j);
            SolidColorBrush darkBlue = new SolidColorBrush(Colors.DarkBlue);
            element.Background = darkBlue;
        }
        public void turnPurple(int i, int j)
        {
            TextBox element = mazeGrid.Children
                                .Cast<TextBox>()
                                .FirstOrDefault(ez => Grid.GetRow(ez) == i && Grid.GetColumn(ez) == j);
            SolidColorBrush purple = new SolidColorBrush(Colors.Purple);
            element.Background = purple;
        }
        public void turnGreenShade(int i, int j, int shade)
        {
            TextBox element = mazeGrid.Children
                                .Cast<TextBox>()
                                .FirstOrDefault(ez => Grid.GetRow(ez) == i && Grid.GetColumn(ez) == j);
            Color green1 = (Color)ColorConverter.ConvertFromString("#FFCE64C0");
            Color green2 = (Color)ColorConverter.ConvertFromString("#FFA63FBE");
            Color green3 = (Color)ColorConverter.ConvertFromString("#FF8510B7");
            Color green4 = (Color)ColorConverter.ConvertFromString("#FF6226F0");
            Color green5 = (Color)ColorConverter.ConvertFromString("#FF333DE6");
            Color green6 = (Color)ColorConverter.ConvertFromString("#FF0B00ED");
            Color green7 = (Color)ColorConverter.ConvertFromString("#FF0710A0");
            SolidColorBrush greenBrush_1 = new SolidColorBrush(green1);
            SolidColorBrush greenBrush_2 = new SolidColorBrush(green2);
            SolidColorBrush greenBrush_3 = new SolidColorBrush(green3);
            SolidColorBrush greenBrush_4 = new SolidColorBrush(green4);
            SolidColorBrush greenBrush_5 = new SolidColorBrush(green5);
            SolidColorBrush greenBrush_6 = new SolidColorBrush(green6);
            SolidColorBrush greenBrush_7 = new SolidColorBrush(green7);
            if (shade == 1)
            {
                element.Background = greenBrush_1;
            }
            else if (shade == 2)
            {
                element.Background = greenBrush_2;
            }
            else if (shade == 3)
            {
                element.Background = greenBrush_3;
            }
            else if (shade == 4)
            {
                element.Background = greenBrush_4;
            }
            else if (shade == 5)
            {
                element.Background = greenBrush_5;
            }
            else if (shade == 6)
            {
                element.Background = greenBrush_6;
            }
            else if (shade == 7)
            {
                element.Background = greenBrush_7;
            }
        }
        private void fileButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*txt)|*.txt";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                if (System.IO.File.Exists(filePath))
                {
                    if (System.IO.Path.GetExtension(filePath) != ".txt")
                    {
                        this.fileName.Text = "Invalid extension";
                    }
                    else
                    {
                        chooseFileWithDialog = true;
                        m = new Maze(filePath);
                        if (!this.m.Valid)
                        {
                            this.fileName.Text = "File content not valid";
                        }
                        else
                        {
                            this.fileName.Text = System.IO.Path.GetFileName(filePath);
                        }
               
                    }
                }
                else
                {
                    this.fileName.Text = "File does't exist";
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            if (bfs_radio.IsChecked == true)
            {
                BFS bFS = new BFS(this.m, this);
                bFS.GetOneWay();
                Node solutionNode = bFS.DoAction(tsp_check.IsChecked == true, this, (int)this.searchSpeed.Value);
            }
            else if (dfs_radio.IsChecked == true) 
            {
                DFS dFS = new DFS(this.m, this);
                dFS.GetOneWay();
                Node solutionNode = dFS.doAction(tsp_check.IsChecked == true, this, (int)this.searchSpeed.Value);
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        public void updateUI()
        {
            Dispatcher.Invoke(() =>
            {
                this.UpdateLayout();
            });
        }

        private void searchSpeed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (searchSpeed != null && delayValue != null)
            {
                this.delayValue.Text = ((int)this.searchSpeed.Value).ToString() + " ms";
            }
        }

        private void textFileInputField_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.txtFileName = textFileInputField.Text;
            
        }

        private void startingDir_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dirDialog = new System.Windows.Forms.FolderBrowserDialog();
            dirDialog.ShowDialog();
            startDir = dirDialog.SelectedPath;
            chooseFileWithDialog = false;
        }
    }
}
