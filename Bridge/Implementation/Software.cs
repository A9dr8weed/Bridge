namespace Bridge
{
    /// <summary>
    /// Concrete ImplementorB: concrete implementations that inherit from Implementer.
    /// </summary>
    public class Software : IRequisite
    {
        public string SetFirmwareOrSoftwareName()
        {
            return "IOS production version 13.2";
        }

        public string SetFirmwareOrSoftwareVesrion()
        {
            return "IOS 13.2";
        }

        public double SetPrice()
        {
            return 15000;
        }
    }
}