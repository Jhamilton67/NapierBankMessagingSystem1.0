using NapierBankMessagingSystem1._0.ViewModels;
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

namespace NapierBankMessagingSystem1._0.Views
{
    /// <summary>
    /// Interaction logic for IncidentsReportView.xaml
    /// </summary>
    public partial class IncidentsReportView : UserControl
    {
        public IncidentsReportView()
        {
            InitializeComponent();

            this.DataContext = new IncidentReportViewModel(); 

        }
    }
}
