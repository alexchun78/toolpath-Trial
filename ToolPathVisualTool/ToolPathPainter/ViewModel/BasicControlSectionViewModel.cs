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
using ToolPathPainter.Common;
using ToolPathPainter.Models;

namespace ToolPathPainter.ViewModel
{
    public class BasicControlSectionViewModel :ViewModelBase
    {
        public ICommand PolylineListCommand { get; set; }
        public ICommand FileImportCommand { get; set; }

        public BasicControlSectionViewModel()
        {
            m_IOModule = new zIOModule();
            PolylineListCommand = new RelayCommand(PolylineListToggle);
            FileImportCommand = new RelayCommand(FileImport);
        }

        private zIOModule m_IOModule;

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

            try 
            {
                // [1] show dialog and import file content
                bool bRtn = m_IOModule.ShowFileDialog(ref filePath, ref fileName, ref fileContent);
                if (bRtn == false)
                    throw new FileFormatException("Failed to import file!!");

                // [2] compose hierachy dataset
                m_IOModule.ComposeHierarchyWKTData(fileContent);

                // [3] compose polyline dataset
                bRtn = m_IOModule.ComposeClipperPolylineData();
                if (bRtn == false)
                    throw new NullReferenceException("ClipperPolyline data is empty!");

                CPolylineClipper temp = new CPolylineClipper();
                foreach (var item in m_IOModule.ClipperPolylines)
                {
                    ClipperLib.IntPoint point_temp;
                    foreach (var point in item.Path)
                    {
                        point_temp.X = point.X;
                        point_temp.Y = point.Y;
                        temp.Path.Add(point_temp);
                    }
                    temp.ShellIndex = item.ShellIndex;
                    temp.InnerOrOuter = item.InnerOrOuter;
                    temp.HoleOrOutline = item.HoleOrOutline;
                   // CanvasFieldViewModel.getInstance().m_polylineClipper.Add(temp);
                }
              //  var nmm = CanvasFieldViewModel.getInstance().m_polylineClipper;
                // [4] bind polyline data to canvas?????

               // CanvasFieldViewModel.getInstance().Draw();

            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message + "Exception caught.", "[ERROR]", MessageBoxButtons.OK);
                //Console.WriteLine("{0} Exception caught.", e);
                return;
            }
        }
    }
}
