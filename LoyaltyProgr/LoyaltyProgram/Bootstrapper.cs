using System;
using Nancy;
using Nancy.Bootstrapper;


namespace LoyaltyProgr.LoyaltyProgram
{

    public class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override Func<ITypeCatalog, NancyInternalConfiguration> InternalConfiguration
         => NancyInternalConfiguration.WithOverrides(builder => builder.StatusCodeHandlers.Clear());
    }
}
