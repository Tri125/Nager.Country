namespace Nager.Country.Currencies
{
    public class SdgCurrency : ICurrency
    {
        public string Symbol => "SDG";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "SDG";

        ///<inheritdoc/>
        public string NumericCode => "938";

        ///<inheritdoc/>
        public string Name => "Sudanese pound";
    }
}
