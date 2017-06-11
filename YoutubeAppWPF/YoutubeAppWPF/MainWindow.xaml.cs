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
using System.Net;
using Google.Apis;
using Google.Apis.YouTube;
using YoutubeAppWPF.BasicClasses;

namespace YoutubeAppWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Search searchObj = new Search();
            YoutubeInfoManagement wow = new YoutubeInfoManagement();
            wow.Test();
            List<List<string>> thing = searchObj.SearchBasedOnKeyword("rizzo and sizz");

        }
    }
}
