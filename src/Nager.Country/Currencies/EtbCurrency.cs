﻿namespace Nager.Country.Currencies
{
    public class EtbCurrency : ICurrency
    {
        public string Symbol => "ብር";

        ///<inheritdoc/>
        public string Singular => "birr";

        ///<inheritdoc/>
        public string Plural => "birr";

        ///<inheritdoc/>
        public string IsoCode => "ETB";

        ///<inheritdoc/>
        public string NumericCode => "230";

        ///<inheritdoc/>
        public string Name => "Ethiopian birr";
    }
}
