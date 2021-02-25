namespace Bridge
{
    /// <summary>
    /// Hardware.
    /// Concrete ImplementorA: concrete implementations that inherit from Implementer.
    /// </summary>
    public class Hardware : IRequisite
    {
        public string SetFirmwareOrSoftwareName()
        {
            return "MotherBoard FirmWare";
        }

        public string SetFirmwareOrSoftwareVesrion()
        {
            return "5.0";
        }

        public double SetPrice()
        {
            return 20000;
        }
    }
}