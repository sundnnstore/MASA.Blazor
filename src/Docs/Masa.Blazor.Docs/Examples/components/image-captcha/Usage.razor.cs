﻿using Masa.Blazor.Presets;

namespace Masa.Blazor.Docs.Examples.components.image_captcha;

public class Usage : Masa.Blazor.Docs.Components.Usage
{
    public Usage() : base(typeof(PImageCaptcha)) { }

    protected override RenderFragment GenChildContent() => builder =>
    {
        builder.OpenComponent<Index>(0);
        builder.CloseComponent();
    };
}