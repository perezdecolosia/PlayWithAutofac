using System;
using System.Collections.Generic;
using System.Text;

namespace KeyedServiceLookup
{
    public class FrenchTranslationStrategy : ITranslationStrategy
    {
        public string Translate()
        {
            return "Traduit en français";
        }
    }
}
