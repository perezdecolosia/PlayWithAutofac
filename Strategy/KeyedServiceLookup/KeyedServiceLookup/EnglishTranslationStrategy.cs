using System;
using System.Collections.Generic;
using System.Text;

namespace KeyedServiceLookup
{
    public class EnglishTranslationStrategy : ITranslationStrategy
    {
        public string Translate()
        {
            return "Translated to english";
        }
    }
}
