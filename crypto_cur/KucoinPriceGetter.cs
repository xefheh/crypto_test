using Kucoin.Net.Clients;

namespace crypto_cur;

internal class KucoinPriceGetter : ICryptoPriceGetter
{
    private readonly KucoinClient _client; 

    public KucoinPriceGetter(KucoinClient client) => _client = client;

    public decimal GetLastPrice(string symbol)
    {
        var ticker = _client.SpotApi.ExchangeData.GetTickerAsync(symbol);
        var price = ticker.Result.Data.LastPrice;
        if (price == null) throw new NullReferenceException();
        return price.Value;
    }
}