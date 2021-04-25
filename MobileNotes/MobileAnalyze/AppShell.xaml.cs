﻿using MobileNotes.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileNotes
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));
        }
    }
}
