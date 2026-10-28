using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Threading;
using System;
using System.Collections.Generic;

namespace minutnik.Views
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer _timer;
        private TimeSpan _currentTime;
        private bool _isWorking = true;
        private bool _isRunning = false;
        private int _cycles = 0;
        
        // Lista historii cykli (własna ręka)
        private readonly List<string> _history = new();

        public MainWindow()
        {
            InitializeComponent();

            _currentTime = TimeSpan.FromMinutes(25);

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromSeconds(1);
            _timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            if (_currentTime > TimeSpan.Zero)
            {
                _currentTime = _currentTime.Subtract(TimeSpan.FromSeconds(1));
            }
            else
            {
                if (_isWorking)
                {
                    // Zwiększenie licznika cykli oraz dodanie wpisu do historii (własna ręka)
                    _cycles++;
                    CyclesText.Text = _cycles.ToString();
                    
                    _history.Add($"{DateTime.Now:HH:mm} — cykl {_cycles}");
                    HistoryList.ItemsSource = _history.ToArray();

                    _isWorking = false;
                    StatusText.Text = "Przerwa";
                    _currentTime = GetTimeFromInput(BreakInput, 5);
                }
                else
                {
                    _isWorking = true;
                    StatusText.Text = "Praca";
                    _currentTime = GetTimeFromInput(WorkInput, 25);
                }
            }

            UpdateDisplay();
        }

        private void OnStartPauseClick(object? sender, RoutedEventArgs e)
        {
            if (_isRunning)
            {
                _timer.Stop();
                _isRunning = false;
                StartPauseButton.Content = "Start";
            }
            else
            {
                if (_currentTime == TimeSpan.Zero)
                {
                    ResetTimerValues();
                }
                _timer.Start();
                _isRunning = true;
                StartPauseButton.Content = "Pauza";
            }
        }

        private void OnResetClick(object? sender, RoutedEventArgs e)
        {
            _timer.Stop();
            _isRunning = false;
            StartPauseButton.Content = "Start";
            _isWorking = true;
            StatusText.Text = "Praca";
            ResetTimerValues();
            UpdateDisplay();
        }

        private void ResetTimerValues()
        {
            double minutes = GetTimeFromInput(WorkInput, 25).TotalMinutes;
            _currentTime = TimeSpan.FromMinutes(minutes);
        }

        private TimeSpan GetTimeFromInput(TextBox textBox, int fallbackMinutes)
        {
            if (double.TryParse(textBox.Text?.Replace('.', ','), out double minutes) && minutes > 0)
            {
                return TimeSpan.FromMinutes(minutes);
            }
            return TimeSpan.FromMinutes(fallbackMinutes);
        }

        private void UpdateDisplay()
        {
            TimeText.Text = _currentTime.ToString(@"mm\:ss");
        }
    }
}