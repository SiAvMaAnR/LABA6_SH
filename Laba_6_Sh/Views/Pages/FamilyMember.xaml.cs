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
    /// Логика взаимодействия для FamilyMember.xaml
    /// </summary>
    public partial class FamilyMember : Page
    {
        public FamilyMemberViewModel familyMemberViewModel = new FamilyMemberViewModel();
        public InteractionDataBaseService familyMemberDataBaseService = new SourceDataBaseService();

        public FamilyMember()
        {
            InitializeComponent();
            DataContext = familyMemberViewModel;
        }
    }
}
