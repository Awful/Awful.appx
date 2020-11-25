﻿// <copyright file="ForumThreadViewModel.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Awful.Core.Entities.JSON;
using Awful.Core.Entities.Threads;
using Awful.Core.Tools;
using Awful.Core.Utilities;
using Awful.Database.Context;
using Awful.Database.Entities;
using Awful.Mobile.UI.Tools.Commands;
using Awful.UI.Actions;
using Awful.UI.Entities;
using Awful.UI.ViewModels;
using Awful.Webview;
using Xamarin.CommunityToolkit.UI.Views;
using Xamarin.Forms;

namespace Awful.UI.ViewModels
{
    /// <summary>
    /// Awful Forums List View Model.
    /// </summary>
    public class ForumThreadViewModel : AwfulViewModel
    {
        private TemplateHandler handler;
        private ThreadPostActions threadActions;

        /// <summary>
        /// Initializes a new instance of the <see cref="ForumThreadViewModel"/> class.
        /// </summary>
        /// <param name="context">Awful Context.</param>
        public ForumThreadViewModel(TemplateHandler handler, AwfulContext context)
            : base(context)
        {
            this.handler = handler;
        }

        /// <summary>
        /// Gets or sets the internal webview.
        /// </summary>
        public WebView WebView { get; set; }

        /// <summary>
        /// Loads Thread Template into webview.
        /// </summary>
        /// <returns>Task.</returns>
        public async Task LoadTemplate(int threadId, int pageNumber, bool gotoNewestPost = false)
        {
            this.IsRefreshing = true;
            var defaults = await this.GenerateDefaultOptionsAsync().ConfigureAwait(false);
            var entry = await this.threadActions.GetThreadPostsAsync(threadId, pageNumber, gotoNewestPost).ConfigureAwait(false);
            var source = new HtmlWebViewSource();
            source.Html = this.threadActions.RenderThreadPostView(entry, defaults);
            Device.BeginInvokeOnMainThread(() => this.WebView.Source = source);
            await Task.Delay(2000).ConfigureAwait(false);
            this.IsRefreshing = false;
        }

        /// <inheritdoc/>
        public override Task OnLoad()
        {
            this.threadActions = new ThreadPostActions(this.Client, this.Context, this.handler);
            return base.OnLoad();
        }
    }
}