using Avalonia.Media.Imaging;

namespace FNAFPorting.Models.Chat;

public record PendingGameFileAttachment(string Path, Bitmap Icon, string? DisplayName);
