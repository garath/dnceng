﻿namespace PrepareDocs;

internal record class AppOptions(
    string Files,
    string? Category,
    bool SkipBlobs,
    string? StorageServiceBlobEndpoint,
    string? Container,
    string? TenantId,
    Guid? clientId,
    string? clientSecret,
    string? SearchServiceEndpoint,
    string? SearchIndexName,
    bool Remove,
    bool RemoveAll,
    string? FormRecognizerServiceEndpoint,
    bool Verbose,
    IConsole Console) : AppConsole(Console);

internal record class AppConsole(IConsole Console);
