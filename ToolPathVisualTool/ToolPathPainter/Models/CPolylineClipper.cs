using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClipperLib;

namespace ToolPathPainter.Models
{
    using Path = List<IntPoint>;
    public class CPolylineClipper
    {
        private int m_shellIndex = -1;
        private int m_innerOrOuter = -1; // innter = 0, outer = 1
        private int m_holeOrOutline = -1; // hole = 0, outline = 1
        private Path m_Path = null; // point list <- cpp에서 vector 개념
        
        public CPolylineClipper()
        {
            m_shellIndex = -1;
            m_innerOrOuter = -1; // innter = 0, outer = 1
            m_holeOrOutline = -1; // hole = 0, outline = 1
            m_Path = new Path();
        }

        public CPolylineClipper(Path path)
        {
            m_shellIndex = -1;
            m_innerOrOuter = -1; // innter = 0, outer = 1
            m_holeOrOutline = -1; // hole = 0, outline = 1
            m_Path = new Path();
            IntPoint temp;
            temp.X = 0;
            temp.Y = 0;
            foreach (var item in path)
            {
                temp.X = item.X;
                temp.Y = item.Y;
                m_Path.Add(temp);
            }

        }

        public int ShellIndex
        {
            get => m_shellIndex;
            set => m_shellIndex = value;
        }
        public int InnerOrOuter
        {
            get => m_innerOrOuter;
            set => m_innerOrOuter = value;
        }
        public int HoleOrOutline
        {
            get => m_holeOrOutline;
            set => m_holeOrOutline = value;
        }
        public Path Path
        {
            get => m_Path;
            set => m_Path = value;
        }
    }
}
