namespace Bridge
{
    /// <summary>
    /// Concrete class of abstraction: class iPhone implements the Apple(abstraction) and defines their functionalities.
    /// </summary>
    public class IPhone : AppleProduct
    {
        public IPhone(IRequisite software, IRequisite hardware) : base(software, hardware) { }

        public override string SetProductName()
        {
            return "IPhone X";
        }

        public override double SetProductPrice()
        {
            return 110000;
        }
    }
}
