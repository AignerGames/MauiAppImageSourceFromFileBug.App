using System.Collections.ObjectModel;

using Microsoft.Toolkit.Mvvm.ComponentModel;

namespace MauiAppImageSourceFromFileBug
{
    public partial class DemoViewModel : ObservableObject
    {
        [ObservableProperty]
        private ViewModelItem _selectedItem;

        public DemoViewModel()
        {
            var filePath = Path.Combine(FileSystem.AppDataDirectory, "test.png");

            // Prepare the test file
            var imageBytes = ImageResource.test;

            File.WriteAllBytes(filePath, imageBytes);

            // Actual test code
            var imageSource = ImageSource.FromFile(filePath);

            // Workaround: Comment the above line and use this instead, no more exception
            //var imageSource = ImageSource.FromStream(() => File.OpenRead(filePath));

            var demoItem = new ViewModelItem(filePath, imageSource);

            Items.Add(demoItem);

            Items.Add(new ViewModelItem("- Empty - ", null));
        }

        public ObservableCollection<ViewModelItem> Items { get; } = new();
    }
}
