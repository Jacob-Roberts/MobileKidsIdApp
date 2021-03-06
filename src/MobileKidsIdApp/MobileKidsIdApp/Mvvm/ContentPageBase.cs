﻿using Xamarin.Forms;

namespace MobileKidsIdApp
{
    public abstract class ContentPageBase : ContentPage
    {
        public ContentPageBase() => Visual = VisualMarker.Material;

        protected ViewModelBase ViewModel => BindingContext as ViewModelBase;

        protected override void OnAppearing() => ViewModel?.OnAppearing();

        protected override void OnDisappearing() => ViewModel?.OnDisappearing();

        public virtual void Initialize() { }
    }
}
