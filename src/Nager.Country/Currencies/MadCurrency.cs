namespace Nager.Country.Currencies
{
    public class MadCurrency : ICurrency
    {
        public string Symbol => "د.م.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MAD";

        ///<inheritdoc/>
        public string NumericCode => "504";

        ///<inheritdoc/>
        public string Name => "Moroccan Dirham";
    }
}
