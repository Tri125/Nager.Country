namespace Nager.Country.Currencies
{
    public class IqdCurrency : ICurrency
    {
        public string Symbol => "د.ع.‏";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "IQD";

        ///<inheritdoc/>
        public string NumericCode => "368";

        ///<inheritdoc/>
        public string Name => "Iraqi Dinar";
    }
}
