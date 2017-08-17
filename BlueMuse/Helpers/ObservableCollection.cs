﻿using System;
using System.Collections.Specialized;
using System.ComponentModel;
using Windows.UI.Core;

namespace BlueMuse.Helpers
{
    public class ObservableCollection<T> : System.Collections.ObjectModel.ObservableCollection<T>
    {
        protected async override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        { 
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.High,
            () =>
                {
                    base.OnCollectionChanged(e);
                }
            );
        }

        protected async override void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            await Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.High,
            () =>
                {
                    base.OnPropertyChanged(e);
                }
            ); 
        }
    }
}
