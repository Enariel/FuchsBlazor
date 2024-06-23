namespace FuchsBlazor;

public class PseudoCss
{
    private string _scope = ":root";

    /// <summary>
    /// Set different scopes for the generated Theme
    /// </summary>
    /// <remarks>
    /// Ensure you use a valid CSS scope <see href="https://developer.mozilla.org/en-US/docs/Web/CSS/:root">Pseudo-classes Mozilla</see> for a list of valid ones
    /// Defaults to :root
    /// </remarks>
    public string Scope
    {
        get => _scope;
        set
        {
            if (string.IsNullOrEmpty(value))
                _scope = ":root";
            else
            {
                var trimmed = value.Trim(':');
                _scope = $":{trimmed}";
            }
        }
    }
}