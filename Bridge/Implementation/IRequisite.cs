namespace Bridge
{
    /// <summary>
    /// Implementer: interface Requisite: It defines the interface for implementation classes.
    /// </summary>
    public interface IRequisite
    {
        /// <summary>
        /// Defines which software or hardware, product suppose to have.
        /// </summary>
        string SetFirmwareOrSoftwareVesrion();

        /// <summary>
        /// Set hardware/software's price.
        /// </summary>
        double SetPrice();

        /// <summary>
        /// Set hardware/software's name.
        /// </summary>
        string SetFirmwareOrSoftwareName();
    }
}