using System;
using System.Collections.Generic;
using System.Text;

namespace KeyedServiceLookup
{
    public class SpanishTranslationStrategy : ITranslationStrategy
    {
        public string Translate()
        {
            return "Traducido al español";
        }
    }
}
