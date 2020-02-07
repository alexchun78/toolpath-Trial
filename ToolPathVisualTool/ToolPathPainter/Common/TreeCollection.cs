using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolPathPainter.Common
{
    public class TreeNode<T> 
    {
        private readonly T _value;
        private bool _bValueFlag;
        private readonly List<TreeNode<T>> _children = new List<TreeNode<T>>();
        public TreeNode (T value, bool flag)
        {
            _value = value;
            _bValueFlag = flag;
        }

        public TreeNode<T> this[int i] // operator []
        {
            get 
            { 
                return _children[i]; 
            }
        }

        public TreeNode<T> Parent 
        { 
            get; 
            private set; 
        }

        public T Value 
        {
            get 
            {
                return _value;
            }
        }

        public bool ValueFlag
        {
            get => _bValueFlag;
            set => _bValueFlag = value;
        }

        public List<TreeNode<T>> Children
        {
            get => _children;
        }

        public TreeNode<T> AddChild(T value, bool bFlag)
        {
            var node = new TreeNode<T>(value, bFlag)
            {
                Parent = this
            };
            
            _children.Add(node);
            return node;
        }

        public bool RemoveChild(TreeNode<T> node)
        {
            return _children.Remove(node);
        }

        public void Traverse(Action<T, bool> action)
        {          
            action(Value, ValueFlag);
            foreach (var child in _children)
            {
                child.Traverse(action);
            }
        }
    }
}
