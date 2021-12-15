using Laba_6_Sh.Services;
using Laba_6_Sh.ViewModels;
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

namespace Laba_6_Sh.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Expenditure.xaml
    /// </summary>
    public partial class Expenditure : Page
    {
        public ExpenditureViewModel expenditureViewModel = new ExpenditureViewModel();
        public InteractionDataBaseService expenditureDataBaseService = new ExpenditureDataBaseService();
        public Expenditure()
        {
            InitializeComponent();
            DataContext = expenditureViewModel;
        }
    }
}
