﻿namespace PortalMe.API.DTOs.Applications;

    public record ApplicationResponseDto(
        Guid Id,
        string NameApp,
        string Photo,
        string UrlApp
        );

