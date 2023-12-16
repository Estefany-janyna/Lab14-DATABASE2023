﻿using System;
using Taipe14.DataContext;
using Taipe14.Interfaces;
using Taipe14.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Taipe14
{
    public partial class App : Application
    {
 
            public App()
            {
                InitializeComponent();
                GetContext().Database.EnsureCreated();
                MainPage = new CompraView();
            }

            public static AppDbContext GetContext()
            {
                string DbPath = DependencyService.Get<IConfigDataBase>().GetFullPath("efCore.db");

                return new AppDbContext(DbPath);
            }
            protected override void OnStart()
            {
            }

            protected override void OnSleep()
            {
            }

            protected override void OnResume()
            {
            }
        }
    }