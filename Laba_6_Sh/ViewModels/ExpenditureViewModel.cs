using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class ExpenditureViewModel : BaseViewModel
    {
        private DataTable expenditureDataTable = new DataTable();

        public DataTable ExpenditureDataTable
        {
            get { return expenditureDataTable; }
            set
            {
                expenditureDataTable = value;
                OnPropertyChanged(nameof(expenditureDataTable));
            }
        }
    }
}
