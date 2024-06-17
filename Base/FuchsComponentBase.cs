// Copyright (c) FuchsFarbe Blazor 2024
// Oliver Conover
// FuchsFarbe Studios

using Microsoft.AspNetCore.Components;

namespace FuchsBlazor;

/// <summary>
/// Represents a base class for designing FuchsBlazor components.
/// </summary>
public class FuchsComponentBase : ComponentBase
{
	/// <summary>
	/// The CSS classes applied to this component.
	/// </summary>
	/// <remarks>
	/// Defaults to <c>null</c>.  You can use spaces to separate multiple classes.  Use the <see cref="Style"/> property to apply custom CSS styles.
	/// </remarks>
	[Parameter]
	public string? Class { get; set; }

	/// <summary>
	/// The CSS styles applied to this component.
	/// </summary>
	/// <remarks>
	/// Defaults to <c>null</c>.  Use the <see cref="Class"/> property to apply CSS classes.
	/// </remarks>
	[Parameter]
	public string? Style { get; set; }

	/// <summary>
	/// The additional HTML attributes to apply to this component.
	/// </summary>
	/// <remarks>
	/// This property is typically used to provide additional HTML attributes during rendering such as ARIA accessibility tags or a custom ID.
	/// </remarks>
	[Parameter(CaptureUnmatchedValues = true)]
	public Dictionary<string, object?> UserAttributes { get; set; } = new Dictionary<string, object?>();
}