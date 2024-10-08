﻿using System.Windows;
using System.Windows.Controls;

namespace AnatomyAnalyzer.UI.Units
{
    public class ControlTreeItem : TreeViewItem
    {
        static ControlTreeItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ControlTreeItem), new FrameworkPropertyMetadata(typeof(ControlTreeItem)));
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new ChildTreeItem();
        }
    }
}
