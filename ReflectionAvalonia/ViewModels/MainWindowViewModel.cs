using ReactiveUI;
using ReflectionAvalonia.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ReflectionAvalonia.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<AnytypePresentationViewModel> anytypePresentationViewModels 
            = new ObservableCollection<AnytypePresentationViewModel>();

        public MainWindowViewModel(List<AnytypePresentationModel> models)
        {
            foreach (var model in models)
            {
                anytypePresentationViewModels.Add(new AnytypePresentationViewModel(model));
            }

            DrawingContent = anytypePresentationViewModels[8]; // select first by default 
        }

        private object drawingContent;
        public object DrawingContent {

            get => drawingContent;
            set => this.RaiseAndSetIfChanged(ref drawingContent, value);
        }
    }
}
