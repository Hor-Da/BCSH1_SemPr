using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BCSH1_Planner.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isPaneOpen = true;

    [ObservableProperty] 
    private ViewModelBase _currentPage = new HomePageViewModel();

    [RelayCommand]
    private void TogglePane() => IsPaneOpen = !IsPaneOpen;
}