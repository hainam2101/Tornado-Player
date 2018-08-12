﻿namespace Tornado.Player.Services.Interfaces
{
    using System;

    using Tornado.Player.EventArgs;
    using Tornado.Player.Models;

    internal interface IMusicPlayerService
    {
        event EventHandler<TrackChangedEventArgs> TrackChanged;

        event EventHandler<PlaylistLoadedEventArgs> PlaylistLoaded;

        Track[] Tracks { get; }
    }
}