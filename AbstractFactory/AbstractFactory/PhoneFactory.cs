namespace AbstractFactory
{
    abstract class PhoneFactory
    {
        public abstract Phone GetPhone();
        public abstract SmartPhone GetSmartPhone();
    }
}