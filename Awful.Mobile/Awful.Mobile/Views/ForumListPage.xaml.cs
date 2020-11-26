﻿// <copyright file="ForumListPage.xaml.cs" company="Drastic Actions">
// Copyright (c) Drastic Actions. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Awful.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Awful.Mobile.Views
{
    /// <summary>
    /// Forum List Page View.
    /// </summary>
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ForumListPage : AuthorizationPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForumListPage"/> class.
        /// </summary>
        public ForumListPage()
        {
            this.InitializeComponent();
            this.BindingContext = App.Container.Resolve<ForumsListViewModel>();
        }

        protected override void OnAppearing()
        {
            this.ForumCollection.SelectedItem = null;
            base.OnAppearing();
        }
    }
}