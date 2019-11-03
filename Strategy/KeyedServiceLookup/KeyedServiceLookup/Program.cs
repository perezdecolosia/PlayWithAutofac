using Autofac;
using System;

namespace KeyedServiceLookup
{
    public class Program
    {
        static void Main()
        {
            CompositionRoot().Resolve<IApplication>().Run();
        }

        private static IContainer CompositionRoot()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<EnglishTranslationStrategy>().Keyed<ITranslationStrategy>(TranslationType.English);
            builder.RegisterType<FrenchTranslationStrategy>().Keyed<ITranslationStrategy>(TranslationType.French);
            builder.RegisterType<SpanishTranslationStrategy>().Keyed<ITranslationStrategy>(TranslationType.Spanish);

            return builder.Build();
        }
    }
}
