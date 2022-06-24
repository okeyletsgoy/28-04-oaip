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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// As I understand it, you need a hint...
        /// </summary>

        /// <param name="Hint"> To jump above your head, press the key combination... </param>
        public int Podskaz(string Hint) { return 0; }

        /// <code> 
        /// var index = 5;
        /// index++;
        /// </code>

        /// <summary>
        /// Enter description for delegate.
        /// ID string generated is "T:MyNamespace.MyClass.Del".
        /// </summary>
        /// <param name="i">Describe parameter.</param>
        public delegate void Del(int i);

        /// <summary>
        /// Enter description here for field message.
        /// ID string generated is "F:MyNamespace.MyClass.message".
        /// </summary>
        public string? message;
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
