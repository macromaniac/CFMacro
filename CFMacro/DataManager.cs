using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaasOne;
using MaasOne.Base;
using MaasOne.Finance;
using MaasOne.Finance.YahooFinance;
using System.IO;
namespace CFMacro {
    class DataManager {
        UpdateChartCallback updateChartCallback;
        GetStockInfo updateStockInfoCallback;
        public DataManager(UpdateChartCallback updateChartCallback, GetStockInfo updateStockInfoCallback) {
            this.updateChartCallback = updateChartCallback;
            this.updateStockInfoCallback = updateStockInfoCallback;
            downloadQuote();
            downloadChart();
        }

        public void downloadQuote() {
            QuotesDownload dl = new QuotesDownload();
            QuotesDownloadSettings settings = dl.Settings;
            settings.IDs = new string[] { "YHOO" };
            settings.Properties = new QuoteProperty[] { QuoteProperty.Symbol,
                                            QuoteProperty.Name, 
                                            QuoteProperty.LastTradePriceOnly,
                                          };
            dl.AsyncDownloadCompleted += this.eDownloadCompleted;
            dl.DownloadAsync();
        }
        public void downloadChart() {
            ChartDownload dl = new ChartDownload();
            ChartDownloadSettings settings = dl.Settings;
            settings.ID = "YHOO";
            settings.SimplifiedImage = false;
            settings.Culture = new Culture(Language.en,Country.US);
            settings.ImageSize = ChartImageSize.Middle;
            settings.Type = ChartType.Line;
            settings.Scale = ChartScale.Logarithmic;
            settings.TimeSpan = ChartTimeSpan.c1D;


            settings.TechnicalIndicators.Add(TechnicalIndicator.Volume);
            settings.TechnicalIndicators.Add(TechnicalIndicator.RSI);
            settings.MovingAverages.Add(MovingAverageInterval.m50);
            settings.ExponentialMovingAverages.Add(MovingAverageInterval.m20);
            settings.TechnicalIndicators.Add(TechnicalIndicator.Slow_Stoch);
            settings.TechnicalIndicators.Add(TechnicalIndicator.MACD);
            dl.AsyncDownloadCompleted += this.eChartDownloadCompleted;
            dl.DownloadAsync();
        }
        private void eDownloadCompleted(IDownload sender, IDownloadCompletedEventArgs e) {
            IResponse response = e.GetResponse();
            QuotesResult result = (QuotesResult)response.GetObjectResult();
            QuotesData[] qd = result.Items;
            updateStockInfoCallback(qd[0].LastTradePriceOnly.ToString());
        }
        private void eChartDownloadCompleted(IDownload sender, IDownloadCompletedEventArgs e) {
            IResponse response = e.GetResponse();
            ChartResult result = (ChartResult)response.GetObjectResult();
            System.IO.MemoryStream ms = result.Item;
            System.Drawing.Image imageStream;
            imageStream = System.Drawing.Image.FromStream(ms);
            updateChartCallback(ms);
        }
        
    }
}
