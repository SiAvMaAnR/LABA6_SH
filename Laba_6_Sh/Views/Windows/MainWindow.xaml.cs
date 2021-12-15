using FirebirdSql.Data.FirebirdClient;
using Laba_6_Sh.ViewModels;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Laba_6_Sh
{
    public partial class MainWindow : Window
    {
        private FbConnection connection;
        private MainViewModel mainViewModel;

        private Views.Pages.Source sourcePage;
        private Views.Pages.FamilyMember familyMemberPage;
        private Views.Pages.Plan planPage;
        private Views.Pages.Expenditure expenditurePage;
        private Views.Pages.Income incomePage;

        public MainWindow()
        {
            InitializeComponent();
            connection = new FbConnection(ConfigurationManager.ConnectionStrings["HFDB"].ConnectionString);
            mainViewModel = new MainViewModel();

            sourcePage = new Views.Pages.Source();
            familyMemberPage = new Views.Pages.FamilyMember();
            planPage = new Views.Pages.Plan();
            expenditurePage = new Views.Pages.Expenditure();
            incomePage = new Views.Pages.Income();

            mainViewModel.FrameCurrentPage = sourcePage;
            DataContext = mainViewModel;
            PageComboBox.SelectedIndex = 0;
            FillDataGrid();
        }

        public async Task<MainWindow> Create()
        {
            await connection.OpenAsync();
            return this;
        }

        private async void FillDataGrid()
        {
            sourcePage.sourceViewModel.SourceDataTable = await sourcePage.sourceDataBaseService.GetAllDataTable(connection, "Source");
            familyMemberPage.familyMemberViewModel.FamilyMemberDataTable = await familyMemberPage.familyMemberDataBaseService.GetAllDataTable(connection, "Family_Member");
            planPage.planViewModel.PlanDataTable = await planPage.planDataBaseService.GetAllDataTable(connection, "Plan_Member");
            expenditurePage.expenditureViewModel.ExpenditureDataTable = await expenditurePage.expenditureDataBaseService.GetAllDataTable(connection, "Expenditure");
            incomePage.incomeViewModel.IncomeDataTable = await incomePage.incomeDataBaseService.GetAllDataTable(connection, "Income");
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await sourcePage.sourceDataBaseService.UpdateBD(sourcePage.sourceViewModel.SourceDataTable);
                await familyMemberPage.familyMemberDataBaseService.UpdateBD(familyMemberPage.familyMemberViewModel.FamilyMemberDataTable);
                await planPage.planDataBaseService.UpdateBD(planPage.planViewModel.PlanDataTable);
                await expenditurePage.expenditureDataBaseService.UpdateBD(expenditurePage.expenditureViewModel.ExpenditureDataTable);
                await incomePage.incomeDataBaseService.UpdateBD(incomePage.incomeViewModel.IncomeDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;


            switch (selectedItem.Content.ToString())
            {
                case "Источники":
                    mainViewModel.FrameCurrentPage = sourcePage;
                    break;
                case "Члены семьи":
                    mainViewModel.FrameCurrentPage = familyMemberPage;
                    break;
                case "Доходы":
                    mainViewModel.FrameCurrentPage = planPage;
                    break;
                case "Планы":
                    mainViewModel.FrameCurrentPage = incomePage;
                    break;
                case "Расходы":
                    mainViewModel.FrameCurrentPage = expenditurePage;
                    break;
            }
        }

    }
}
