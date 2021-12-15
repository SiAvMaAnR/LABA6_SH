using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class FamilyMemberViewModel : BaseViewModel
    {
        private DataTable familyMemberDataTable = new DataTable();

        public DataTable FamilyMemberDataTable
        {
            get { return familyMemberDataTable; }
            set
            {
                familyMemberDataTable = value;
                OnPropertyChanged(nameof(familyMemberDataTable));
            }
        }
    }
}
