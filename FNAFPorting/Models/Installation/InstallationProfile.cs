using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CUE4Parse.UE4.Versions;
using FluentAvalonia.UI.Controls;
using FNAFPorting.Models.CUE4Parse;
using FNAFPorting.Validators;
using Newtonsoft.Json;

namespace FNAFPorting.Models.Installation;

public partial class InstallationProfile : ObservableValidator
{
    [ObservableProperty] private string _profileName = "Unnammed";

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(UnrealVersionEnabled))]
    [NotifyPropertyChangedFor(nameof(EncryptionKeyEnabled))]
    [NotifyPropertyChangedFor(nameof(MappingsFileEnabled))]
    [NotifyPropertyChangedFor(nameof(TextureStreamingEnabled))]
    [NotifyPropertyChangedFor(nameof(LoadInstalledBundlesEnabled))]
    [NotifyPropertyChangedFor(nameof(IsCustom))]
    private EFNAFVersion _fnafVersion = EFNAFVersion.TJOC;

    [NotifyDataErrorInfo]
    [ArchiveDirectory]
    [ObservableProperty] private string _archiveDirectory = string.Empty;

    [ObservableProperty] private EGame _unrealVersion = EGame.GAME_UE5_2;

    [NotifyDataErrorInfo]
    [EncryptionKey(canValidateProperty: nameof(EncryptionKeyEnabled))]
    [ObservableProperty]
    private FileEncryptionKey _mainKey = FileEncryptionKey.Empty;

    [ObservableProperty] [property: JsonIgnore] private int _selectedExtraKeyIndex;
    [ObservableProperty] private ObservableCollection<FileEncryptionKey> _extraKeys = [];
    [ObservableProperty] [property: JsonIgnore] private string _fetchKeysVersion = string.Empty;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(MappingsFileEnabled))]
    private bool _useMappingsFile;

    [ObservableProperty] private string _mappingsFile = string.Empty;
    [ObservableProperty] [property: JsonIgnore] private string _fetchMappingsVersion = string.Empty;

    [ObservableProperty] private ELanguage _gameLanguage = ELanguage.English;
    [ObservableProperty] private bool _useTextureStreaming = false;
    [ObservableProperty] private bool _loadInstalledBundles = false;
    [ObservableProperty] private bool _loadNaniteData = true;

    [ObservableProperty] private bool _isSelected;

    [JsonIgnore] public bool IsCustom => FnafVersion is EFNAFVersion.Custom;
    [JsonIgnore] public bool UnrealVersionEnabled => IsCustom;
    [JsonIgnore] public bool EncryptionKeyEnabled => IsCustom;
    [JsonIgnore] public bool MappingsFileEnabled => IsCustom;
    [JsonIgnore] public bool TextureStreamingEnabled => false;
    [JsonIgnore] public bool LoadInstalledBundlesEnabled => false;

    public async Task BrowseArchivePath()
    {
        if (await App.BrowseFolderDialog() is { } path)
        {
            ArchiveDirectory = path;
        }
    }

    public async Task BrowseMappingsFile()
    {
        if (await App.BrowseFileDialog(fileTypes: Globals.MappingsFileType, suggestedFileName: MappingsFile) is { } path)
        {
            MappingsFile = path;
        }
    }

    public async Task AddEncryptionKey()
    {
        ExtraKeys.Add(FileEncryptionKey.Empty);
    }

    public async Task RemoveEncryptionKey()
    {
        var selectedIndexToRemove = SelectedExtraKeyIndex;
        ExtraKeys.RemoveAt(selectedIndexToRemove);
        SelectedExtraKeyIndex = selectedIndexToRemove == 0 ? 0 : selectedIndexToRemove - 1;
    }

    public override string ToString()
    {
        return ProfileName;
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        switch (e.PropertyName)
        {
            case nameof(FnafVersion):
            {
                ValidateAllProperties();
                break;
            }
        }
    }
}
