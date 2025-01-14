namespace Nager.Country.Currencies
{
    public class IskCurrency : ICurrency
    {
        public string Symbol => "kr";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "ISK";

        ///<inheritdoc/>
        public string NumericCode => "352";

        ///<inheritdoc/>
        public string Name => "Icelandic Króna";
    }
}
