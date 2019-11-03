
using Autofac.Features.Indexed;
using System;
using System.Collections.Generic;
using System.Text;

namespace KeyedServiceLookup
{
    internal class Application : IApplication
    {
        private readonly IIndex<TranslationType, ITranslationStrategy> _translationStrategies;
       
        public Application(IIndex<TranslationType, ITranslationStrategy> translationStrategies)
        {
            _translationStrategies = translationStrategies;
        }

        public void Run()
        {
            Console.WriteLine(_translationStrategies[TranslationType.Spanish].Translate());
            Console.WriteLine(_translationStrategies[TranslationType.French].Translate());
            Console.WriteLine(_translationStrategies[TranslationType.English].Translate());
        }
    }
}
