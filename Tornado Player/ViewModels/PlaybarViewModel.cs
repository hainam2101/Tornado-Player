﻿namespace Tornado.Player.ViewModels
{
    using System;

    using Tornado.Player.Services.Interfaces;
    using Tornado.Player.ViewModels.Interfaces;

    internal class PlaybarViewModel : ViewModelBase, IPlaybarViewModel
    {
        private readonly IMusicPlayerService _musicPlayerService;

        public PlaybarViewModel(IMusicPlayerService musicPlayerService)
        {
            _musicPlayerService = musicPlayerService;

            _musicPlayerService.ProgressUpdated += (sender, e) => CurrentProgress = e.NewProgress;
            _musicPlayerService.TrackChanged += (sender, e) => Duration = e.Duration;
        }

        private TimeSpan _currentProgress;
        public TimeSpan CurrentProgress
        {
            get => _currentProgress;

            set
            {
                if (_currentProgress == value) return;

                _currentProgress = value;
                NotifyOfPropertyChange(() => CurrentProgress);
            }
        }

        private TimeSpan _duration;
        public TimeSpan Duration
        {
            get => _duration;

            private set
            {
                if (_duration == value) return;

                _duration = value;
                NotifyOfPropertyChange(() => Duration);
            }
        }
    }
}