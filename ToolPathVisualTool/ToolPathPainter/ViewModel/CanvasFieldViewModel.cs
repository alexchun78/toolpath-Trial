using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolPathPainter.Models;
using ToolPathPainter.Views;
using ClipperLib;
using System.Windows.Shapes;

namespace ToolPathPainter.ViewModel
{
    public class CanvasFieldViewModel : ViewModelBase
    {
        public CanvasFieldViewModel()
        {
            m_polylineClipper = new List<CPolylineClipper>();
        }

        //public CanvasFieldViewModel(List<CPolylineClipper> polylineList)
        //{
        //    m_polylineClipper = new List<CPolylineClipper>();
        //    CPolylineClipper temp = new CPolylineClipper();
        //    foreach (var item in polylineList)
        //    {
        //        ClipperLib.IntPoint point_temp;
        //        foreach (var point in item.Path)
        //        {
        //            point_temp.X = point.X;
        //            point_temp.Y = point.Y;
        //            temp.Path.Add(point_temp);
        //        }
        //        temp.ShellIndex = item.ShellIndex;
        //        temp.InnerOrOuter = item.InnerOrOuter;
        //        temp.HoleOrOutline = item.HoleOrOutline;
        //        m_polylineClipper.Add(temp);
        //    }

            
        //}
        //private static CanvasFieldViewModel INSTANCE;

        //public static CanvasFieldViewModel getInstance()
        //{
        //    //인스턴스가 존재하지 않는다면 생성
        //    if (INSTANCE == null)
        //    {
        //        INSTANCE = new CanvasFieldViewModel();
        //    }
        //    return INSTANCE;
        //}

        public List<CPolylineClipper> m_polylineClipper = null;

        //public void Draw()
        //{
        //    CanvasField nnn = new CanvasField();
        //    var dd = nnn.g_pathCanvas;
        //    Line line = new Line();// = new g_pathCanvas.Children.Line();

        //    //첫번째 좌표 설정
        //    line.X1 = 10;
        //    line.Y1 = 10;

        //    //두번째 좌표 설정
        //    line.X2 = 20;
        //    line.Y2 = 20;
        //    nnn.g_pathCanvas.Children.Add(line);
        // //   line.Stroke = ;//선색 지정
        // //  line.StrokeThickness = thickness;//선 두께 지정
        // //  line.StrokeDashArray = dashStyle;//점선 설정 
        //}

    }

}
