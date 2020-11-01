namespace hw2es
{
    public class Converter
    {
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double Rub { get; set; }

        private double UsdRate { get; }
        private double EurRate { get; }
        private double RubRate { get; }

        public Converter(double usd, double eur, double rub)
        {
            UsdRate = usd;
            EurRate = eur;
            RubRate = rub;
        }

        public double UahToUsd(double uah)
        {
            return uah / UsdRate;
        }

        public double UahToEur(double uah)
        {
            return uah / EurRate;
        }

        public double UahToRub(double uah)
        {
            return uah / RubRate;
        }

        public double UsdToUah(double usd)
        {
            return usd * UsdRate;
        }

        public double EurToUah(double eur)
        {
            return eur * EurRate;
        }

        public double RubToUah(double rub)
        {
            return rub * RubRate;
        }
    }
}