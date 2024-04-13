using Avalonia.Media;
using DynamicData;
using ReactiveUI;
using ReflectionAvalonia.Models;
using System.Collections.ObjectModel;

namespace ReflectionAvalonia.ViewModels
{
    public class AnytypePresentationViewModel : ViewModelBase
    {
        private AnytypePresentationModel model;
        public AnytypePresentationViewModel(AnytypePresentationModel presentationModel)
        {
            this.model = presentationModel;
            TreeView = model.GetPresentation();
        }

        private ObservableCollection<Node> treeView;
        public ObservableCollection<Node> TreeView
        {
            get => treeView;
            set => this.RaiseAndSetIfChanged(ref treeView, value);
        }
    }
}
