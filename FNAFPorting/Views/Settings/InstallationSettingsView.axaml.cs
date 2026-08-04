using System.Linq;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.VisualTree;
using FNAFPorting.Framework;
using FNAFPorting.ViewModels.Settings;
using FNAFPorting.Controls.Navigation.Sidebar;
using FNAFPorting.Models.Installation;

namespace FNAFPorting.Views.Settings;

public partial class InstallationSettingsView : ViewBase<InstallationSettingsViewModel>
{
    public InstallationSettingsView() : base(AppSettings.Installation)
    {
        InitializeComponent();
    }

    // spaces aint working so easy fix ??
    private void OnTextBoxKeyDown(object? sender, KeyEventArgs e)
    {
        if (sender is not TextBox textBox) return;
        if (e.Key != Key.Space) return;

        textBox.Text = textBox.Text!.Insert(textBox.CaretIndex, " ");
        textBox.CaretIndex++;
    }
}