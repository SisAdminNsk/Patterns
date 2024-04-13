using Avalonia.Skia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAvalonia.Models
{
    public class PresentationComponentToTreeViewAdapter
    {
        private PresentationComponent presentationComponent;

        public PresentationComponentToTreeViewAdapter(PresentationComponent presentationComponent)
        {
            this.presentationComponent = presentationComponent;
        }

        private ObservableCollection<Node> AdaptRecursivly(
            ObservableCollection<Node> currentLevel,
            PresentationComponent currentComponent)
        {
            if(currentComponent is PresentationLeaf leaf)
            {
                currentLevel.Add(new Node(leaf.Name,leaf.Value));
            }

            if(currentComponent is PresentationComposite composite)
            {
                foreach(var child in composite.Childern)
                {
                    if(child is PresentationLeaf nestedLeaf)
                    {
                        currentLevel.Add(new Node(nestedLeaf.Name, nestedLeaf.Value));
                    }
                    else
                    {
                        currentLevel.Add(new Node(child.Name,
                            child.Value,
                            AdaptRecursivly(new ObservableCollection<Node>(), child)));
                    }
                }
            }

            return currentLevel;
        }

        public ObservableCollection<Node> Adapt()
        {
            ObservableCollection<Node> treeview = new ObservableCollection<Node>();
            AdaptRecursivly(treeview, presentationComponent);
            return treeview;
        }
    }
}
