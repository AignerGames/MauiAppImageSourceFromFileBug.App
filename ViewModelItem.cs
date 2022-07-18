using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MauiAppImageSourceFromFileBug
{
    public partial class ViewModelItem : ObservableObject
    {
        [ObservableProperty]
        private ImageSource _imageSource;

        public ViewModelItem(string name, ImageSource imageSource)
        {
            Name = name;
            ImageSource = imageSource;
        }

        public string Name { get; }
    }
}
