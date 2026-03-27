using System.Collections.Generic;
using System.Linq;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using BCSH1_Planner.Models;

namespace BCSH1_Planner.Views;

public partial class ClientsPageView : UserControl
{
    public ClientsPageView()
    {
        InitializeComponent();
        Clients.ItemsSource = new string[]
        {
            "client1", "client2", "client3", "client4", "client5", "client6", "client7", "client8", "client9",
            "client10", "client11", "client12", "client13", "client14", "client15", "client16", "client17", "client18", 
            "client19"
        };
    }
}