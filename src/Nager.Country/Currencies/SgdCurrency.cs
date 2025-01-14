namespace Nager.Country.Currencies
{
    public class SgdCurrency : ICurrency
    {
        public string Symbol => "$";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "SGD";

        ///<inheritdoc/>
        public string NumericCode => "702";

        ///<inheritdoc/>
        public string Name => "Singapore Dollar";
    }
}
