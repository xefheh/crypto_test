using Bybit.Net.Clients;

namespace crypto_cur;

internal class ByBitPriceGetter : ICryptoPriceGetter
{
    private readonly BybitClient _client;

    public ByBitPriceGetter(BybitClient client) => _client = client;
    public decimal GetLastPrice(string symbol)
    {
        var ticker = _client.SpotApiV3.ExchangeData.GetTickerAsync(symbol);
        var price = ticker.Result.Data.LastPrice;
        return price;
    }
}