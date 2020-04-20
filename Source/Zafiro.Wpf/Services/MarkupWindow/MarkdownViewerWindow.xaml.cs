﻿using System.Diagnostics;
using System.Windows.Input;

namespace Zafiro.Wpf.Services.MarkupWindow
{
    
    public partial class MarkdownViewerWindow : ICloseable
    {
        public MarkdownViewerWindow()
        {
            InitializeComponent();
        }

        private void CommandBinding_OnExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Process.Start((string) e.Parameter);
        }
    }
}
