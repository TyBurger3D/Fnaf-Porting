using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using FluentAvalonia.UI.Controls;
using FNAFPorting.Framework;
using FNAFPorting.Models.Files;
using FNAFPorting.Services;
using FNAFPorting.ViewModels;
using FNAFPorting.Controls.WrapPanel;

namespace FNAFPorting.Views;

public partial class FilesView : ViewBase<FilesViewModel>
{
    public FilesView() : base(FilesVM)
    {
        InitializeComponent();
    }
    
    private void OnFileItemTapped(TreeItem item)
    {
        if (item.Type != ENodeType.File) return;
        
        TaskService.RunDispatcher(async () => await ViewModel.Preview());
    }
}