// Copyright (c) FuchsFarbe Blazor 2024
// Oliver Conover
// FuchsFarbe Studios
namespace FuchsBlazor
{
    public interface IFuchsChangeState
    {
        /// <summary>
        /// Notifies the component that its state has changed. When applicable, this will
        /// cause the component to be re-rendered.
        /// </summary>
        void StateHasChanged();
    }
}