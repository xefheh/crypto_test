namespace crypto_cur;

public interface ICryptoPriceGetter
{
    decimal GetLastPrice(string symbol);
}