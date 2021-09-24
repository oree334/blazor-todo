using Microsoft.Maui.Controls;
using System;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            bwv.RootComponents[0].ComponentType = typeof(TodoLib.App);
        }
    }
}
