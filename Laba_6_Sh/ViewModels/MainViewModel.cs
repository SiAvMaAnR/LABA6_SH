using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Laba_6_Sh.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private Page frameCurrentPage;
        public Page FrameCurrentPage
        {
            get { return frameCurrentPage; }
            set
            {
                frameCurrentPage = value;
                OnPropertyChanged(nameof(frameCurrentPage));
            }
        }


    }
}
