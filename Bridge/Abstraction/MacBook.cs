namespace Bridge
{
    /// <summary>
    /// Concrete class of abstraction: class MacBook implements the Apple(abstraction) and defines their functionalities.
    /// </summary>
    public class MacBook : AppleProduct
    {
        public MacBook(IRequisite software, IRequisite hardware) : base(software, hardware) { }

        public override string SetProductName()
        {
            return "Apple MacBook Pro";
        }

        public override double SetProductPrice()
        {
            return 170000;
        }
    }
}