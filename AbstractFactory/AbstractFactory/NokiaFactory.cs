namespace AbstractFactory
{
    internal class NokiaFactory : PhoneFactory
    {
        public override Phone GetPhone()
        {
            return new RegularNokiaPhone();
        }

        public override SmartPhone GetSmartPhone()
        {
            return new NokiaSmartPhone();
        }
    }
}