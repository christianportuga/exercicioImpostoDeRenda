namespace Exercicio11ImpostoRenda.Entities
{
    class IndividualPayer : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public IndividualPayer(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double TaxesPaid()
        {
            if (AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15 - 0.5 * HealthExpenditures;
            }
            else
            {
                return AnualIncome * 0.25 - 0.5 * HealthExpenditures;
            }
        }
    }
}
