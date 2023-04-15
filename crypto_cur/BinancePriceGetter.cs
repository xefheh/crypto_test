using Binance.Net.Clients;

namespace crypto_cur;

internal class BinancePriceGetter : ICryptoPriceGetter
{
    private BinanceClient _client;

    public BinancePriceGetter(BinanceClient client) => _client = client;

    public decimal GetLastPrice(string symbol)
    {
        var ticker = _client.SpotApi.ExchangeData.GetTickerAsync(symbol);
        var price = ticker.Result.Data.LastPrice;
        return price;
    }
}