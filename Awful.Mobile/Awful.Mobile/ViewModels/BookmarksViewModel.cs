﻿// <copyright file="BookmarksViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Awful.Core.Tools;
using Awful.Core.Utilities;
using Awful.Database.Context;
using Awful.Database.Entities;
using Awful.Mobile.UI.Tools.Commands;
using Awful.UI.Actions;
using Awful.UI.ViewModels;
using Xamarin.Forms;

namespace Awful.Mobile.ViewModels
{
    /// <summary>
    /// Bookmarks View Model.
    /// </summary>
    public class BookmarksViewModel : AwfulViewModel
    {
        private BookmarkAction bookmarks;
        private ObservableCollection<AwfulThread> threads;
        private RelayCommand refreshCommand;

        /// <summary>
        /// Initializes a new instance of the <see cref="BookmarksViewModel"/> class.
        /// </summary>
        /// <param name="properties">Awful Properties.</param>
        /// <param name="context">Awful Context.</param>
        public BookmarksViewModel(IPlatformProperties properties, AwfulContext context)
            : base(context)
        {
            this.bookmarks = new BookmarkAction(this.Client, context);
            if (this.IsSignedIn)
            {
                Task.Run(async () => await this.LoadBookmarksAsync().ConfigureAwait(false));
            }
        }

        /// <summary>
        /// Gets or sets Forum Threads.
        /// </summary>
        public ObservableCollection<AwfulThread> Threads
        {
            get { return this.threads; }
            set { this.SetProperty(ref this.threads, value); }
        }

        /// <summary>
        /// Gets the refresh command.
        /// </summary>
        public RelayCommand RefreshCommand
        {
            get
            {
                return this.refreshCommand ??= new RelayCommand(async () =>
                {
                    this.IsRefreshing = true;
                    await this.RefreshBookmarksAsync().ConfigureAwait(false);
                    this.IsRefreshing = false;
                });
            }
        }

        /// <summary>
        /// Load Bookmarks.
        /// </summary>
        /// <param name="reload">Force Reload.</param>
        /// <param name="forceDelay">For Reload Delay, for allowing the forum list to update.</param>
        /// <returns>Task.</returns>
        public async Task LoadBookmarksAsync(bool reload = false, int forceDelay = 0)
        {
            this.IsBusy = true;
            await Task.Delay(forceDelay).ConfigureAwait(false);
            var threads = await this.bookmarks.GetAllBookmarksAsync(reload).ConfigureAwait(false);
            this.Threads = new ObservableCollection<AwfulThread>();
            foreach (var thread in threads)
            {
                this.Threads.Add(thread);
            }

            this.IsBusy = false;
        }

        /// <summary>
        /// Refresh Bookmarks.
        /// </summary>
        /// <param name="forceDelay">For Reload Delay, for allowing the forum list to update.</param>
        /// <returns>Task.</returns>
        public async Task RefreshBookmarksAsync(int forceDelay = 0)
        {
            await this.LoadBookmarksAsync(true, forceDelay).ConfigureAwait(false);
        }
    }
}