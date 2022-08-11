using CommunityToolkit.Mvvm.ComponentModel;

namespace ErrorProperty;


[INotifyPropertyChanged]
public partial class MainViewModel
{
    public MainViewModel()
    {
        Test = "test string";
    }

    [ObservableProperty] private string _test;
}