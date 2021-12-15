using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class IncomeViewModel:BaseViewModel
    {
        private DataTable incomeDataTable = new DataTable();

        public DataTable IncomeDataTable
        {
            get { return incomeDataTable; }
            set
            {
                incomeDataTable = value;
                OnPropertyChanged(nameof(incomeDataTable));
            }
        }
    }
}
