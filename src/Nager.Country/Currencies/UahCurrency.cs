namespace Nager.Country.Currencies
{
    public class UahCurrency : ICurrency
    {
        public string Symbol => "₴";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "UAH";

        ///<inheritdoc/>
        public string NumericCode => "980";

        ///<inheritdoc/>
        public string Name => "Ukrainian Hryvnia";
    }
}
