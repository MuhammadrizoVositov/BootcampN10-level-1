using N26_HT1;

List<Money> moneyList = new()
{
    new Money (){ Amount = 100.00M, Type = MoneType.Loan, Currency = Currency.RUB },
    new Money { Amount = 100.00m, Type = MoneType.InBalance, Currency = Currency.UZS },
    new Money { Amount = 50.00m, Type = MoneType.InBalance, Currency = Currency.USD },
    new Money { Amount = 200.00m, Type = MoneType.Loan, Currency = Currency.RUB },
    new Money { Amount = 75.00m, Type = MoneType.InBalance, Currency = Currency.UZS },
    new Money { Amount = 150.00m, Type = MoneType.Loan, Currency = Currency.USD },
    new Money { Amount = 25.00m, Type = MoneType.InBalance, Currency = Currency.RUB },
    new Money { Amount = 50.00m, Type = MoneType.InBalance, Currency = Currency.USD },
    new Money { Amount = 10.00m, Type = MoneType.Loan, Currency = Currency.UZS },
    new Money { Amount = 5.00m, Type = MoneType.Loan, Currency = Currency.USD },
    new Money { Amount = 100.00m, Type = MoneType.InBalance, Currency = Currency.RUB }
};

var con = moneyList[0];
for (int i = 1; i < moneyList.Count; i++)
{
    con += moneyList[i];
}
Console.WriteLine($"{con.Type} {con.Amount} {con.Amount}");

