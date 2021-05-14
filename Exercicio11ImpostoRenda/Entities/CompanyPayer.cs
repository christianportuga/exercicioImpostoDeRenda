namespace Exercicio11ImpostoRenda.Entities
{
    class CompanyPayer : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public CompanyPayer(string name, double anualIncome, int numberOfEmployees) : base(name,anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxesPaid()
        {
            if (NumberOfEmployees < 10)
            {
                return AnualIncome * 0.16;
            }
            else
            {
                return AnualIncome * 0.14;
            }
        }
    }
}
