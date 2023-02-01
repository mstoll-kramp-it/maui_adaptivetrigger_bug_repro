﻿#nullable disable
using Microsoft.Maui.Graphics;

namespace Microsoft.Maui.Controls
{
	static class ColorElement
	{
		public static readonly BindableProperty ColorProperty =
			BindableProperty.Create(nameof(IColorElement.Color), typeof(Color), typeof(IColorElement), null);
	}
}