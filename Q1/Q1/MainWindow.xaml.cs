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
using System.Text.RegularExpressions;

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

            //creating a list of each line in txt document
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

            //Replacing all "'" with an empty space
            lines[4] = lines[4].Replace("'", " ");
            lines[5] = lines[5].Replace("'", " ");
            lines[6] = lines[6].Replace("'", " ");
            lines[7] = lines[7].Replace("'", " ");
            lines[8] = lines[8].Replace("'", " ");

            //Replacing all "+" with an empty space
            txtBlocSegments.Text = lines[4].Replace("+", " ") + "\n"
                + lines[5].Replace("+", " ") + "\n"
                + lines[6].Replace("+", " ") + "\n"
                + lines[7].Replace("+", " ") + "\n"
                + lines[8].Replace("+", " ");


            //alternatively, could write a method that finds all lines containing "LOC" and display them

            //alternatively, could write a method to find all unwanted symbols in all lines and 
            //replace them instead of replacing each line individually

        }
    }
}
