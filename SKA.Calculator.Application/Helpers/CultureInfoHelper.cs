using System.Globalization;

namespace SKA.Calculator.Application.Helpers
{
    public static class CultureInfoHelper
    {
        public static CultureInfo SetCultureInfo()
        {
            CultureInfo culture = new CultureInfo("pt-BR");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
            return culture;
        }
    }
}
