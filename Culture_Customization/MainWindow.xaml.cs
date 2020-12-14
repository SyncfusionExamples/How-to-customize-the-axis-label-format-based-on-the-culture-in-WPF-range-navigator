using Syncfusion.UI.Xaml.Charts;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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

namespace GettingStartedDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RangeNavigator_LowerBarLabelsCreated(object sender, Syncfusion.UI.Xaml.Charts.LowerBarLabelsCreatedEventArgs e)
        {
            var lowerBarLabels = e.LowerBarLabels;
            foreach (var item in lowerBarLabels)
            {
                var actualContent = DateTime.Parse(item.Content.ToString());
                (item as RangeNavigatorLabel).Content = actualContent.ToString("hhtt", new CultureInfo("zh-hk"));
            }
        }
    }

    
}
