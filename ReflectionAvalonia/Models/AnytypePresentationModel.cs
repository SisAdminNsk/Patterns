using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReflectionAvalonia.Models
{
    public class AnytypePresentationModel
    {
        private PresentationComponent presentationComponent;


        private ObservableCollection<Node> treeView;

        public AnytypePresentationModel(object presentationObject)
        {
            var factory = new PresentationModelFactory();

            if(presentationObject is User.User user)
            {
                presentationComponent = factory.Create(user);
            }

            PresentationComponentToTreeViewAdapter toTreeViewAdapter = 
                new PresentationComponentToTreeViewAdapter(presentationComponent);

            treeView = toTreeViewAdapter.Adapt();
        }

        public ObservableCollection<Node> GetPresentation()
        {
            return this.treeView;
        }
    }
}
