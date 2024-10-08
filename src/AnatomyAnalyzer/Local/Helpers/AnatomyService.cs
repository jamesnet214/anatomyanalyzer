﻿using AnatomyAnalyzer.Local.Models;
using System.Windows;

namespace AnatomyAnalyzer.Local.Helpers
{
    public class AnatomyService
    {
        public event EventHandler<AnatomyEventArgs> ControlSelected;
        public event EventHandler<AnatomyEventArgs> ControlLoaded;

        public event EventHandler<AnatomyEventArgs> ControlChanged;
        public Dictionary<Type, DependencyObject> Instances { get; set; }

        internal void Add(AnatomyItemCollection items)
        {
            var args = new AnatomyEventArgs();
            args.Controls = items;
            ControlChanged.Invoke(this, args);
        }

        internal void SelectControl(AnatomyItem item)
        {
            AnatomyEventArgs args = new();
            args.Item = item;
            ControlSelected.Invoke(this, args);
        }

        internal void LoadControl(AnatomyItem item)
        {
            AnatomyEventArgs args = new();
            args.Item = item;
            ControlLoaded.Invoke(this, args);
        }
    }
}
