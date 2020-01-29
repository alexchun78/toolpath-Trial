using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;

//using Microsoft.Win32;


namespace ToolPathPainter.ViewModel
{
    public class BasicControlSectionViewModel :ViewModelBase
    {
        public ICommand PolylineListCommand { get; set; }
        public ICommand FileImportCommand { get; set; }

        public BasicControlSectionViewModel()
        {
            PolylineListCommand = new RelayCommand(PolylineListToggle);
            FileImportCommand = new RelayCommand(FileImport);
        }

        private void PolylineListToggle()
        {
            
            if (System.Windows.Application.Current.Windows.Count > 1)
            {
                System.Windows.Application.Current.Windows[1].Close();                
            }
            else
            {
                PolylineListWindow polylineList = new PolylineListWindow();
                polylineList.Left = System.Windows.Application.Current.MainWindow.Left + System.Windows.Application.Current.MainWindow.ActualWidth;
                polylineList.Top = System.Windows.Application.Current.MainWindow.Top;

                polylineList.Show();
            }
        }

        private void FileImport()
        {
            string filePath = string.Empty;
            string fileName = string.Empty;
            string fileContent = string.Empty;

            bool bRtn = ShowFileDialog(ref filePath, ref fileName, ref fileContent);
            if (bRtn == false)
                return;

            // WKT(Well - Known Text) Geometry
            // MULTIPOLYGON(((1 1,5 1,5 5,1 5,1 1),(2 2, 3 2, 3 3, 2 3,2 2)),((3 3,6 2,3 3))) 

            // TO DO : 파일을 불러오고 -> 폴리곤 데이터들을 저장하고 -> 점으로 표현하고 -> 라인으로 그린다
            Stack<int> testStack = new Stack<int>();
            
            //var find = fileContent.
            foreach (var item in fileContent)
            {
                char iter = item;
                int a = 0;
            }

            System.Windows.Forms.MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

        }

        private bool ShowFileDialog(ref string filePath, ref string fileName, ref string fileContent)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "import files (*.txt,*.dat)|*.txt;*.dat;|All files (*.*)|*.*";
                openFileDialog.Multiselect = false; // 추후 다중 선택기능 추가
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;
                    fileName = openFileDialog.SafeFileName;

                    var fileStream = openFileDialog.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
                else
                    return false;
            }

            return true;
        }

    }
}
