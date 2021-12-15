using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class SourceViewModel: BaseViewModel
    {
        private DataTable sourceDataTable = new DataTable();

        public DataTable SourceDataTable
        {
            get { return sourceDataTable; }
            set
            {
                sourceDataTable = value;
                OnPropertyChanged(nameof(sourceDataTable));
            }
        }
    }
}
