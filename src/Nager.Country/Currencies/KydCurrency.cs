namespace Nager.Country.Currencies
{
    public class KydCurrency : ICurrency
    {
        public string Symbol => "$";
        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "KYD";

        ///<inheritdoc/>
        public string NumericCode => "136";

        ///<inheritdoc/>
        public string Name => "Cayman Islands dollar";
    }
}
