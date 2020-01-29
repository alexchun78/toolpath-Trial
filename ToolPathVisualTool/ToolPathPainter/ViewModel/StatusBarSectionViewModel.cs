using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ToolPathPainter.ViewModel
{
    public class StatusBarSectionViewModel : ViewModelBase
    {
        public ICommand ExitCommand { get; set; }

        public StatusBarSectionViewModel()
        {
            ExitCommand = new RelayCommand(ExitProgram);
        }

        public void ExitProgram()
        {
            foreach (Window win in Application.Current.Windows)
                win.Close();
        }
    }
}
