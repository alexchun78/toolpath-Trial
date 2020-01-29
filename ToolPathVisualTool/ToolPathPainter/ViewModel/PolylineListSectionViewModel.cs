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
    public class PolylineListSectionViewModel : ViewModelBase
    {
        public ICommand ExitCommand { get; set; }

        public PolylineListSectionViewModel()
        {
            ExitCommand = new RelayCommand(ExitProgram);
        }

        public void ExitProgram()
        {
            try
            {
                if (Application.Current.Windows.Count > 1)
                {
                    Application.Current.Windows[1].Close();
                }
                    
            }
            catch(Exception e)
            {
                throw new System.Exception(e.Message.ToString());
            }
        }
    }
}
