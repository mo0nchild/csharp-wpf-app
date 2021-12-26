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
using System.Diagnostics;
namespace WPF_App;

public partial class MainWindow : Window
{
    public MainWindow() 
    {
        InitializeComponent();
        
    }

    private void ExitAction(object sender, RoutedEventArgs e)
    {
        Trace.WriteLine(this.TextShit.Text );
        this.Close();
    }

}

