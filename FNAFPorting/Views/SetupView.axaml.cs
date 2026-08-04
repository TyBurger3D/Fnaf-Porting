using FNAFPorting.Framework;
using FNAFPorting.ViewModels;
using FNAFPorting.Views.Setup;

namespace FNAFPorting.Views;

public partial class SetupView : ViewBase<SetupViewModel>
{
    public SetupView()
    {
        InitializeComponent();
        DataContext = ViewModel;
        
        Navigation.Setup.Initialize(ContentFrame);
        Navigation.Setup.Open<WelcomeSetupView>();
    }
}
