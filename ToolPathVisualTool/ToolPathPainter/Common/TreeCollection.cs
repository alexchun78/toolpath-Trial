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
        private readonly List<TreeNode<T>> _children = new List<TreeNode<T>>();
        public TreeNode (T value)
        {
            _value = value;
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

        public ReadOnlyCollection<TreeNode<T>> Children
        {
            get 
            {
                return _children.AsReadOnly();
            }
        }

        public TreeNode<T> AddChild(T value)
        {
            var node = new TreeNode<T>(value)
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
        //public TreeNode<T>[] AddChildren(params T[] values)
        //{
        //    return values.Select(AddChild).ToArray();
        //}


        //public void Traverse (Action<T> action)
        //{
        //    action(Value);
        //    foreach (var child in _children)
        //        child.Traverse(action);
        //}
        //public IEnumerable<T> Flatten()
        //{
        //    return new[] { Value }.Concat(_children.SelectMany(x => x.Flatten()));
        //}
    }

    public class Tree<T>
    {
        private TreeNode<T> m_root;
        private int m_count; // count 작업이 필요하다.

        public Tree(T value)
        {
            m_root = new TreeNode<T>(value);
            m_count = 0;
        }

        public TreeNode<T> Root
        {
            get => m_root;
            set => m_root = value;
        }

        public int Count
        { 
            get => m_count;
            set => m_count = value;
        }

        public TreeNode<T> AddChild(T value)
        {
            m_count++;
            return m_root.AddChild(value);
        }
    }
}
