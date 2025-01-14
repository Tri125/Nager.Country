namespace Nager.Country.Currencies
{
    public class PgkCurrency : ICurrency
    {
        public string Symbol => "K";

        ///<inheritdoc/>
        public string Singular => "kina";

        ///<inheritdoc/>
        public string Plural => "kina";

        ///<inheritdoc/>
        public string IsoCode => "PGK";

        ///<inheritdoc/>
        public string NumericCode => "598";

        ///<inheritdoc/>
        public string Name => "Papua New Guinean kina";
    }
}
