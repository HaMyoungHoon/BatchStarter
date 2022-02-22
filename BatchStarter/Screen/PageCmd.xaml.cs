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

namespace BatchStarter.Screen
{
    /// <summary>
    /// PageCmd.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class PageCmd : Page
    {
        public PageCmd()
        {
            InitializeComponent();
            DataContext = new PageCmdViewModel(-1);
            tbResult.TextChanged += TbResult_TextChanged;
        }

        private void TbResult_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbResult.ScrollToEnd();
        }

        public PageCmd(int index)
        {
            InitializeComponent();
            DataContext = new PageCmdViewModel(index);
            tbResult.TextChanged += TbResult_TextChanged;
        }
    }
}
