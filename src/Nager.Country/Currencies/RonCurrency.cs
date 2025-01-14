namespace Nager.Country.Currencies
{
    public class RonCurrency : ICurrency
    {
        public string Symbol => "lei";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "RON";

        ///<inheritdoc/>
        public string NumericCode => "946";

        ///<inheritdoc/>
        public string Name => "Romanian Leu";
    }
}
