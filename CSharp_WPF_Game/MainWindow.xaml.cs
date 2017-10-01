using System;
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

namespace CSharp_WPF_Game
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        private uint MaxTextBox = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TextBox tb = new TextBox();
            var workArea = System.Windows.SystemParameters.WorkArea;
            tb.Text = string.Format("textbox {0}", MaxTextBox);
            tb.Name = "Textbox" + MaxTextBox.ToString();
            tb.Height = 50;
            tb.Width = 100;
            tb.Margin = new Thickness(0,0,0,0);
            MainGrid.Children.Add(tb);
            MaxTextBox++;
            IInputElement a = 2;
            Point position = Mouse.GetPosition(txtBoxMousePosition.Text = "X: " + position.X + "\n" + "Y: " + position.Y;
        }

        private void textBox_DragOver(object sender, DragEventArgs e)
        {
            //Point position = Mouse.GetPosition(MainGrid);
        }
    }
}
