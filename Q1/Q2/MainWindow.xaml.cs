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
using System.Xml;

namespace Q2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Creating an instance of xml document
            XmlDocument doc = new XmlDocument();

            //loading in xml file
            doc.Load("Q2.xml");

            //created a string to not have to write the same text over and over 
            string docNode = "/InputDocument/DeclarationList/Declaration/DeclarationHeader/Reference";

            //Extracting each of the nodes to display
            XmlNode MWB = doc.SelectSingleNode(docNode + "[@RefCode='MWB']");
            XmlNode TRV = doc.SelectSingleNode(docNode + "[@RefCode='TRV']");
            XmlNode CAR = doc.SelectSingleNode(docNode + "[@RefCode='CAR']");

            //Displaying Refcodes in listbox
            listBox1.Items.Add(MWB.InnerText);
            listBox1.Items.Add(TRV.InnerText);
            listBox1.Items.Add(CAR.InnerText);
        }
    }
}
