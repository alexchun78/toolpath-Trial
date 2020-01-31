using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.IO;
using ToolPathPainter.Models;
using ToolPathPainter.Common;

namespace ToolPathPainter.Models
{
    public class zIOModule
    {
        private Tree<int> m_wktRootNode = null; // wkt 데이터를 계층화하여 가지고 있는 tree data structure
        private List<CPolylineClipper> m_clipperPolylines = null; // 
        public zIOModule()
        {
            m_wktRootNode = new Tree<int>(0);
            m_clipperPolylines = new List<CPolylineClipper>();
        }

        public Tree<int> WKTRootNode
        {
            get => m_wktRootNode;
            set => m_wktRootNode = value;
        }
        public List<CPolylineClipper> ClipperPolylines
        {
            get => m_clipperPolylines;
            set => m_clipperPolylines = value;
        }
        public bool ShowFileDialog(ref string filePath, ref string fileName, ref string fileContent)
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
                        // [NOTE] WKT file 중에서 POLYGON과 MULTIPOLYGON만 import되도록 제한함
                        if (!fileContent.Contains("POLYGON"))
                            return false;
                    }
                }
                else
                    return false;
            }


            return true;
        }

        public bool ComposeClipperPolylineData()
        {
            int a = m_clipperPolylines.Count;

            return true;
        }

        public void ComposeHierarchyWKTData(string fileContent)
        {
            // tree의 count를 체크해서 예외처리해주어야 한다.
            // WKT(Well - Known Text) Geometry
            // MULTIPOLYGON(((100 100,500 100,500 500,100 500,100 100),(200 200, 3121 2221, 3332 32312, 212 3112,2212 211)),((3332 3121,6112 2333,2113 2213))) 

            int level = 1;
            int nPos = 0;
            TreeNode<int> node = m_wktRootNode.AddChild(level);
            Stack<char> charStack = new Stack<char>();
            for (int idx = fileContent.IndexOf('(', 0); idx < fileContent.Length; idx++)
            {
                switch (fileContent[idx])
                {
                    case '(':
                        node = node.AddChild(++level);
                        break;
                    case ')':
                        if (internal_ConvertCharStack2Int(ref charStack, ref nPos))
                            node.AddChild(nPos);

                        node = node.Parent;
                        level--;
                        break;
                    case ',':
                    case ' ':
                        if (internal_ConvertCharStack2Int(ref charStack, ref nPos))
                            node.AddChild(nPos);
                        break;
                    default:
                        charStack.Push(fileContent[idx]);
                        break;
                }
            }
        }

        public bool internal_ConvertCharStack2Int(ref Stack<char> inStack, ref int pos)
        {
            try
            {
                int size = inStack.Count;
                if (size == 0)
                    throw new IndexOutOfRangeException();

                char[] numArr = new char[size];
                while(inStack.Count != 0)
                {
                    numArr[--size] = inStack.Pop();
                }
                string strNum = new string(numArr);
                bool bRtn = int.TryParse(strNum, out pos);
                if (bRtn == false)
                    throw new NullReferenceException();
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                return false;
            }
            return true;
        }

        

    }
}
