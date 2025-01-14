﻿namespace Nager.Country.Currencies
{
    public class MurCurrency : ICurrency
    {
        public string Symbol => "₨";

        ///<inheritdoc/>
        public string Singular => null;

        ///<inheritdoc/>
        public string Plural => null;

        ///<inheritdoc/>
        public string IsoCode => "MUR";

        ///<inheritdoc/>
        public string NumericCode => "480";

        ///<inheritdoc/>
        public string Name => "Mauritian rupee";
    }
}
