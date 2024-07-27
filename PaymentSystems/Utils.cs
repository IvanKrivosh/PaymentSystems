namespace PaymentSystems
{
    static class Utils
    {
        public static void ValidationParams(params object[] parameters)
        {
            foreach (var parameter in parameters)
            {
                switch (parameter.GetType().Name)
                {
                    case "String":
                        ArgumentNullException.ThrowIfNullOrEmpty(parameter.ToString());
                        break;
                    default:
                        ArgumentNullException.ThrowIfNull(parameter);
                        break;
                }
            }
        }
    }
}
