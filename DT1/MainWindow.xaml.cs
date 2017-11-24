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
        public List<X> MyList { get; set; } = new List<X>();
        public MainWindow()
        {
            InitializeComponent();
            MyList.Add(new X());
            MyList.Add(new X());
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var key = new System.Windows.DataTemplateKey(typeof(X));
            var dataTemplate = (DataTemplate)this.FindResource(key);
            if (dataTemplate != null)
            {
                var tc = dataTemplate.LoadContent().GetType();
                System.Console.WriteLine();
            }

            var items = icontrol1.Items;
            for (var i = 0; i < items.Count; ++i)
            {
                var item = icontrol1.ItemContainerGenerator.ContainerFromIndex(i);

                if (item is ContentPresenter cp)
                {
                    var template = cp.ContentTemplate;
                    System.Diagnostics.Debug.WriteLine($"template is {template?.ToString() ?? "NULL"}");
                }

            }
        }
    }
}
