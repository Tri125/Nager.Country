namespace Nager.Country.Currencies
{
    public class MznCurrency : ICurrency
    {
        public string Symbol => "MT";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MZN";

        ///<inheritdoc/>
        public string NumericCode => "943";

        ///<inheritdoc/>
        public string Name => "Mozambican metical";
    }
}
