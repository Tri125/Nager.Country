namespace Nager.Country.Currencies
{
    public class HnlCurrency : ICurrency
    {
        public string Symbol => "L";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "HNL";

        ///<inheritdoc/>
        public string NumericCode => "340";

        ///<inheritdoc/>
        public string Name => "Honduran Lempira";
    }
}
