using System.Collections.Generic;

namespace Problem31
{
    internal class Money
    {
        #region Constructors, fields, and properties

        private readonly int _value;

        private Money()
        {
        }

        public Money(int value = 0)
        {
            NormalizeMoney(this, value);
        }

        public Money(
            int pense200,
            int pense100,
            int pense50,
            int pense20,
            int pense10,
            int pense5,
            int pense2,
            int pense1)
        {
            Pense200 = pense200;
            Pense100 = pense100;
            Pense50 = pense50;
            Pense20 = pense20;
            Pense10 = pense10;
            Pense5 = pense5;
            Pense2 = pense2;
            Pense1 = pense1;

            _value = GetValueFromMoney(this);
        }

        public int Pense200 { get; private set; }

        public int Pense100 { get; private set; }

        public int Pense50 { get; private set; }

        public int Pense20 { get; private set; }

        public int Pense10 { get; private set; }

        public int Pense5 { get; private set; }

        public int Pense2 { get; private set; }

        public int Pense1 { get; private set; }

        #endregion

        #region Public methods

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        public override bool Equals(object other)
        {
            if (!(other is Money))
            {
                return false;
            }

            return Equals((Money) other);
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

        public static int GetValueFromMoney(Money money)
        {
            int value = 0;

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

        public static Money GetMoneyFromValue(int value)
        {
            Money money = new Money();
            NormalizeMoney(money, value);

            return money;
        }

        private static void NormalizeMoney(Money money, int value)
        {
            money.Pense200 = value / 200;
            int remainder200 = value % 200;

            money.Pense100 = remainder200 / 100;
            int remainder100 = remainder200 % 100;

            money.Pense50 = remainder100 / 50;
            int remainder50 = remainder100 % 50;

            money.Pense20 = remainder50 / 20;
            int remainder20 = remainder50 % 20;

            money.Pense10 = remainder20 / 10;
            int remainder10 = remainder20 % 10;

            money.Pense5 = remainder10 / 5;
            int remainder5 = remainder10 % 5;

            money.Pense2 = remainder5 / 2;
            int remainder2 = remainder5 % 2;

            money.Pense1 = remainder2;
        }

        public static bool operator ==(Money money1, Money money2)
        {
            int value1 = GetValueFromMoney(money1);
            int value2 = GetValueFromMoney(money2);

            return value1 == value2;
        }

        public static bool operator !=(Money money1, Money money2)
        {
            return !(money1 == money2);
        }

        private static List<Money> MakeChange(Money money)
        {
            List<Money> changeList = new List<Money>();



            return changeList;
        }

        #endregion
    }
}