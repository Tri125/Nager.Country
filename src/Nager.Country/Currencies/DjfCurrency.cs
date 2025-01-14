﻿namespace Nager.Country.Currencies
{
    public class DjfCurrency : ICurrency
    {
        public string Symbol => "Fdj";

        ///<inheritdoc/>
        public string Singular => "franc";

        ///<inheritdoc/>
        public string Plural => "francs";

        ///<inheritdoc/>
        public string IsoCode => "DJF";

        ///<inheritdoc/>
        public string NumericCode => "262";

        ///<inheritdoc/>
        public string Name => "Djiboutian franc";
    }
}
