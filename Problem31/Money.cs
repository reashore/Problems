namespace Problem31
{
    public class Money
    {
        #region Constructors, fields, and properties

        private Money()
        {
        }

        public Money(uint value = 0)
        {
            Value = value;
            Normalize(this, value);
        }

        public Money(
            uint pense200,
            uint pense100,
            uint pense50,
            uint pense20,
            uint pense10,
            uint pense5,
            uint pense2,
            uint pense1)
        {
            Pense200 = pense200;
            Pense100 = pense100;
            Pense50 = pense50;
            Pense20 = pense20;
            Pense10 = pense10;
            Pense5 = pense5;
            Pense2 = pense2;
            Pense1 = pense1;

            Value = GetValueFromMoney(this);
        }

        public uint Pense200 { get; private set; }

        public uint Pense100 { get; private set; }

        public uint Pense50 { get; private set; }

        public uint Pense20 { get; private set; }

        public uint Pense10 { get; private set; }

        public uint Pense5 { get; private set; }

        public uint Pense2 { get; private set; }

        public uint Pense1 { get; private set; }

        public uint Value { get; }

        #endregion

        #region Methods

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object other)
        {
            Money money = other as Money;
            return money != null && Equals(money);
        }

        private bool Equals(Money money)
        {
            bool areEqual =
                Pense200 == money.Pense200 &&
                Pense100 == money.Pense100 &&
                Pense50 == money.Pense50 &&
                Pense20 == money.Pense20 &&
                Pense10 == money.Pense10 &&
                Pense5 == money.Pense5 &&
                Pense2 == money.Pense2 &&
                Pense1 == money.Pense1;

            return areEqual;
        }

        #endregion

        #region Static methods

        public static uint GetValueFromMoney(Money money)
        {
            uint value = 0;

            value += money.Pense200 * 200;
            value += money.Pense100 * 100;
            value += money.Pense50 * 50;
            value += money.Pense20 * 20;
            value += money.Pense10 * 10;
            value += money.Pense5 * 5;
            value += money.Pense2 * 2;
            value += money.Pense1;

            return value;
        }

        public static Money GetMoneyFromValue(uint value)
        {
            Money money = new Money();
            Normalize(money, value);

            return money;
        }

        private static void Normalize(Money money, uint value)
        {
            money.Pense200 = value / 200;
            uint remainder200 = value % 200;

            money.Pense100 = remainder200 / 100;
            uint remainder100 = remainder200 % 100;

            money.Pense50 = remainder100 / 50;
            uint remainder50 = remainder100 % 50;

            money.Pense20 = remainder50 / 20;
            uint remainder20 = remainder50 % 20;

            money.Pense10 = remainder20 / 10;
            uint remainder10 = remainder20 % 10;

            money.Pense5 = remainder10 / 5;
            uint remainder5 = remainder10 % 5;

            money.Pense2 = remainder5 / 2;
            uint remainder2 = remainder5 % 2;

            money.Pense1 = remainder2;
        }

        public static bool operator ==(Money money1, Money money2)
        {
            uint value1 = GetValueFromMoney(money1);
            uint value2 = GetValueFromMoney(money2);

            return value1 == value2;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }

        #endregion
    }
}