﻿using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Jamesnet.Wpf.Global.Composition;

namespace AnatomyAnalyzer.Local.ViewModels
{
    public partial class AnatomyWindowViewModel : ObservableBase, IViewLoadable
    {
        private readonly ContentManager _contentManager;

        public AnatomyWindowViewModel(ContentManager contentManager)
        {
            _contentManager = contentManager;
        }

        public void OnLoaded(IViewable view)
        {
            _contentManager.ActiveContent("MainRegion", "MainContent");
        }
    }
}
