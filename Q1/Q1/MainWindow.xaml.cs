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
using System.IO;

namespace Q1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Loading in text file
            StreamReader sr = new StreamReader("Q1.txt");

            //creating a list if each line in txt document
            List<string> lines = new List<string>();
            while (!sr.EndOfStream)
                lines.Add(sr.ReadLine());
            sr.Close();

            //populating textbox only with required lines
            txtBlocLOC.Text = lines[4] + "\n"
                + lines[5] + "\n"
                + lines[6] + "\n"
                + lines[7] + "\n"
                + lines[8];

            //Replacing all "+" with an empty space
            txtBlocSegments.Text = lines[4].Substring(4).Replace("+", " ").Remove(lines[4].Length -1,1) + "\n"
                + lines[5].Substring(4).Replace("+", " ") + "\n"
                + lines[6].Substring(4).Replace("+", " ") + "\n"
                + lines[7].Substring(4).Replace("+", " ") + "\n"
                + lines[8].Substring(4).Replace("+", " ");
        }
    }
}
