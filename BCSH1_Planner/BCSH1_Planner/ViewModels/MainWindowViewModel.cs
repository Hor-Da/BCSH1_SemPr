using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BCSH1_Planner.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{
    [ObservableProperty]
    private bool _isPaneOpen = true;

    [ObservableProperty] 
    private ViewModelBase _currentPage;

    public MainWindowViewModel()
    {
        CurrentPage = new HomePageViewModel();
    }

    [RelayCommand]
    private void TogglePane() => IsPaneOpen = !IsPaneOpen;
    
    [RelayCommand]
    private void NavigateToHome()
    {
        CurrentPage = new HomePageViewModel();
    }
    [RelayCommand]
    private void NavigateToClients()
    {
        CurrentPage = new ClientsPageViewModel();
    }
    [RelayCommand]
    private void NavigateToPlanner()
    {
        CurrentPage = new PlannerPageViewModel();
    }
    [RelayCommand]
    private void NavigateToStatistics()
    {
        CurrentPage = new StatisticsPageViewModel();
    }
}