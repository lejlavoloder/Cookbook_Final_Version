using Cookbook.Model;
using System;
using System.Collections.Generic;
using GalaSoft.MvvmLight.Command;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Cookbook.MobileApp.Services;

namespace Cookbook.MobileApp.ViewModels
{
   public class DownloadViewModel:BaseViewModel
    {
        private double _progressValue;
        public double ProgressValue
        {
            get { return _progressValue; }
            set { SetProperty(ref _progressValue, value); }
        }

        private bool _isDownloading;

        public void Init(Dokument dokument)
        {
            StartDownloadCommand.Execute(dokument);
        }

            public bool IsDownloading
        {
            get { return _isDownloading; }
            set { SetProperty(ref _isDownloading, value); }
        }
        private readonly IDownloadService _downloadService;
        public ICommand StartDownloadCommand { get; }



        public DownloadViewModel(IDownloadService downloadService)
        {
            _downloadService = downloadService;
            StartDownloadCommand = new RelayCommand<Dokument>(async (dokument) => await StartDownloadAsync(dokument));
        }
        public async Task StartDownloadAsync(Dokument dokument)
        {
            var progressIndicator = new Progress<double>(ReportProgress);
            var cts = new CancellationTokenSource();
            try
            {
                IsDownloading = true;

                var url = "http://localhost:53404/api/Dokument/PreuzmiDokument/" + dokument.DokumentId;

                await _downloadService.DownloadFileAsync(url, progressIndicator, cts.Token);
            }
            catch (OperationCanceledException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
                //Manage cancellation here
            }
            finally
            {
                IsDownloading = false;
            }
        }
        internal void ReportProgress(double value)
        {
            ProgressValue = value;
        }
    }
}
