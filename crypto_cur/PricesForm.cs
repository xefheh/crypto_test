using Binance.Net.Clients;
using Bybit.Net.Clients;
using Kucoin.Net.Clients;

namespace crypto_cur
{
    public partial class PricesForm : Form
    {
        private readonly BinanceClient _binanceClient;
        private readonly KucoinClient _kucoinClient;
        private readonly BybitClient _bybitClient;
        private readonly Dictionary<string, ICryptoPriceGetter> _priceGetters;

        public PricesForm()
        {
            InitializeComponent();
            _binanceClient = new BinanceClient();
            _kucoinClient = new KucoinClient();
            _bybitClient = new BybitClient();
            _priceGetters = new Dictionary<string, ICryptoPriceGetter>();
            FillPriceGettersDictionary();
            _binanceBtcusdt.ReadOnly = true;
            _kucoinBtcusdt.ReadOnly = true;
            _byBitBtcusdt.ReadOnly = true;
            SetFirstPrices();
            StartUpdating();
        }

        private void FillPriceGettersDictionary()
        {
            _priceGetters.Add("Binance", new BinancePriceGetter(_binanceClient));
            _priceGetters.Add("Kucoin", new KucoinPriceGetter(_kucoinClient));
            _priceGetters.Add("ByBit", new ByBitPriceGetter(_bybitClient));
        }

        private static void UpdateTextBoxDecimal(decimal decimalValue, Control controlElement) =>
            controlElement.Text = $@"{decimalValue:F8}";

        private static async Task UpdatePriceAsync(Control controlElement,
            ICryptoPriceGetter priceGetter, string symbol)
        {
            var lastPrice = priceGetter.GetLastPrice(symbol);
            UpdateTextBoxDecimal(lastPrice, controlElement);
            await Task.Delay(5000);
        }

        private void SetFirstPrices()
        {
            _ = UpdatePriceAsync(_binanceBtcusdt, _priceGetters["Binance"],"BTCUSDT");
            _ = UpdatePriceAsync(_kucoinBtcusdt, _priceGetters["Kucoin"], "BTC-USDT");
            _ = UpdatePriceAsync(_byBitBtcusdt, _priceGetters["ByBit"], "BTCUSDT");
        }

        private static void InvokePriceUpdating(Control controlElement,
            ICryptoPriceGetter priceGetter, string symbol) => Task.Run(async () =>
                  {
                    while(true) await UpdatePriceAsync(controlElement,
                        priceGetter, symbol);
                  });

        private void StartUpdating()
        {
            InvokePriceUpdating(_binanceBtcusdt, _priceGetters["Binance"], "BTCUSDT");
            InvokePriceUpdating(_kucoinBtcusdt, _priceGetters["Kucoin"], "BTC-USDT");
            InvokePriceUpdating(_byBitBtcusdt, _priceGetters["ByBit"], "BTCUSDT");
        }
    }
}