using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class PlanViewModel: BaseViewModel
    {
        private DataTable planDataTable = new DataTable();

        public DataTable PlanDataTable
        {
            get { return planDataTable; }
            set
            {
                planDataTable = value;
                OnPropertyChanged(nameof(planDataTable));
            }
        }
    }
}
