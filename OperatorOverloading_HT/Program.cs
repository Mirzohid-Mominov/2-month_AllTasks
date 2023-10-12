
//N26 - HT1 - operator overloading

//MoneyType enum dan foydalaning(InBalance, Loan)
//Currency enum dan foydalaning(UZS, USD, RUB)

//Money modelidan foydalaning ( amount, currency, type )

//unda + va - operatorlarini overload qiling,
//bunda MoneyType dan kelib chiqib amal bajarilsin, masalan moneyA va moneyB bor deylik

//+ operatsiyasi uchun : 

//-moneyA va moneyB bir xil tipda bo'lsa - qo'shiladi
//- moneyA in balance va moneyB loan bo'lsa - moneyA - moneyB qilinadi
//- moneyB loan va moneyB in balance bo'lsa - moneyB - moneyA qilinadi

//- Money tipidagi kolleksiyaga bir nechta object qo'shing
//- ular orasida qarzlar ham bo'lsin
//- hammasini qo'shib ekranga chiqaring

//PS : bunda konversiyalarni o'g'irish uchun Convert methodidan foydalanish mumkin

//Fake data : 

using OperatorOverloading_HT;

List<Money> moneyList = new List<Money>()
{
    new Money { Amount = 100.00, Currency = Currency.UZS, Type = MoneyType.Inbalance },
    new Money { Amount = 50.00, Currency = Currency.USD, Type = MoneyType.Inbalance },
    new Money { Amount = 200.00, Currency = Currency.RUB, Type = MoneyType.Loan },
    new Money { Amount = 75.00, Currency = Currency.UZS, Type = MoneyType.Inbalance },
    new Money { Amount = 150.00, Currency = Currency.USD, Type = MoneyType.Loan },
    new Money { Amount = 25.00, Currency = Currency.RUB, Type = MoneyType.Inbalance },
    new Money { Amount = 50.00, Currency = Currency.USD, Type = MoneyType.Inbalance },
    new Money { Amount = 10.00, Currency = Currency.UZS, Type = MoneyType.Loan },
    new Money { Amount = 5.00, Currency = Currency.RUB, Type = MoneyType.Loan },
    new Money { Amount = 100.00, Currency = Currency.UZS, Type = MoneyType.Inbalance }
};

for (int i = 0; i < moneyList.Count - 1 ; i++)
{
    for (int j = 0; j < moneyList.Count; j++)
    {
        var item = moneyList[i] + moneyList[j];
        Console.WriteLine($"{item.Amount} - {item.Currency} - {item.Type}");
    }
}






















































