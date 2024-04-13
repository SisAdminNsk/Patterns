using System.Collections.ObjectModel;

namespace ReflectionAvalonia.Models
{
    public class Node
    {
        public ObservableCollection<Node>? SubNodes { get; }
        public string Title { get; }
        public object Value { get; }

        public Node(string title,object value)
        {
            Title = title;
            Value = value;
        }

        public Node(string title,object value, ObservableCollection<Node> subNodes)
        {
            Title = title;
            Value = value;
            SubNodes = subNodes;
        }
    }
}
