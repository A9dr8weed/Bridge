using System;

namespace Bridge
{
    /// <summary>
    /// Abstract class Apple: the core of the bridge design pattern and contains a reference to the implementer (IRequisite).
    /// </summary>
    public abstract class AppleProduct
    {
        /// <summary>
        /// Reference to the object of software implementation.
        /// </summary>
        protected IRequisite Software;

        /// <summary>
        /// Reference to the object of hardware implementation.
        /// </summary>
        protected IRequisite Hardware;

        protected AppleProduct(IRequisite software, IRequisite hardware)
        {
            Software = software;
            Hardware = hardware;
        }

        public abstract string SetProductName();
        public abstract double SetProductPrice();

        /// <summary>
        /// Methods of this class delegate work to methods of the connected device.
        /// </summary>
        public void SetHardwareAndSoftware()
        {
            Console.WriteLine("---------Software Details---------");
            Console.WriteLine($"Name: {Software.SetFirmwareOrSoftwareName()}");
            Console.WriteLine($"Version: {Software.SetFirmwareOrSoftwareVesrion()}");
            Console.WriteLine($"Price: {Software.SetPrice()}");

            Console.WriteLine("---------Hardware Details---------");
            Console.WriteLine($"Name: {Hardware.SetFirmwareOrSoftwareName()}");
            Console.WriteLine($"Version: {Hardware.SetFirmwareOrSoftwareVesrion()}");
            Console.WriteLine($"Price: {Hardware.SetPrice()}");
        }
    }
}