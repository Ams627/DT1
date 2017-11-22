using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace DT1
{
    public class X
    {
    }

    public partial class MainWindow : Window
    {
        public List<X> List { get; set; } = new List<X>();
        public MainWindow()
        {
            InitializeComponent();
            List.Add(new X());
            List.Add(new X());
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var items = icontrol1.Items;
            for (var i = 0; i < items.Count; ++i)
            {
                var item = (UIElement)icontrol1.ItemContainerGenerator.ContainerFromIndex(i);
                var cp2 = VisualTreeHelper.GetChild
                if (item is ContentPresenter cp)
                {
                    cp.ApplyTemplate();
                    var template = cp.ContentTemplate;
                    System.Diagnostics.Debug.WriteLine($"template is {template?.ToString() ?? "NULL"}");
                }
            }
        }
    }
}
