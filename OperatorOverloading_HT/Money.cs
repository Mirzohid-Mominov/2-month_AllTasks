using OperatorOverloading_HT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

//PS : bunda konversiyalarni o'girish uchun Convert methodidan foydalanish mumkin

namespace OperatorOverloading_HT
{
    internal class Money
    {
        List<Money> moneys = new();
        public Money() { }
        public Money(double amount, Currency currency, MoneyType type)
        {
            Amount = amount;
            Currency = currency;
            Type = type;
        }

        public double Amount { get; set; }
        public Currency Currency { get; set; }
        public MoneyType Type { get; set; }


        //public static Money? operator +(Money moneyA, Money moneyB)
        //{
        //    if(moneyA.Type == moneyB.Type)
        //    {
        //        return 
        //    }
        //}

        //public static Money? operator -(Money moneyA, Money moneyB)
        //{
        //    if(moneyA.Amount <= moneyB.Amount)
        //    {

        //    }
        //}



        public static Money? operator +(Money? moneyA, Money? moneyB)
        {
            if (moneyA.Type.Equals(moneyB.Type))
            {
                ConvertCurrency(moneyA, moneyB);
                return new Money(moneyA.Amount + moneyB.Amount, moneyA.Currency, ConvertMoneyType(moneyA, moneyB));
            }
            else if (moneyA.Type == MoneyType.Inbalance && moneyB.Type == MoneyType.Loan)
            {
                ConvertCurrency(moneyA, moneyB);
                return new Money(MathModule(moneyA.Amount, moneyB.Amount), moneyA.Currency, ConvertMoneyType(moneyA, moneyB));
            }
            else
            {
                ConvertCurrency(moneyA, moneyB);
                return new Money(MathModule(moneyA.Amount, moneyB.Amount), moneyA.Currency, ConvertMoneyType(moneyA, moneyB));
            }
        }
        public static MoneyType ConvertMoneyType(Money moneyA, Money moneyB)
        {
            if (moneyA.Amount >= moneyB.Amount)
            {
                return MoneyType.Inbalance;
            }
            else
            {
                return MoneyType.Loan;
            }
        }
        public static double MathModule(double moneyA, double moneyB)
        {
            if (moneyA >= moneyB)
            {
                return moneyA - moneyB;
            }
            else
            {
                return moneyB - moneyA;
            }
        }
        public static Currency ConvertCurrency(Money? moneyA, Money? moneyB)
        {
            if (moneyA.Currency == moneyB.Currency)
                return moneyA.Currency;
            switch (moneyA.Currency)
            {
                case Currency.UZS:
                    if (moneyB.Currency == Currency.RUB)
                    {
                        moneyB.Amount = 200 * moneyB.Amount;
                        moneyB.Currency = moneyA.Currency;
                        return moneyA.Currency;
                    }
                    moneyB.Amount = 12500 * moneyB.Amount;
                    moneyB.Currency = moneyA.Currency;
                    return moneyA.Currency;
                case Currency.USD:
                    if (moneyB.Currency == Currency.UZS)
                    {
                        moneyB.Amount = moneyB.Amount / 12500;
                        moneyB.Currency = moneyA.Currency;
                        return moneyA.Currency;
                    }
                    moneyB.Amount = moneyB.Amount / 99;
                    moneyB.Currency = moneyA.Currency;
                    return moneyA.Currency;
                case Currency.RUB:
                    if (moneyB.Currency == Currency.UZS)
                    {
                        moneyB.Amount = moneyB.Amount / 200;
                        moneyB.Currency = moneyA.Currency;
                        return moneyA.Currency;
                    }
                    moneyB.Amount = moneyB.Amount * 99;
                    moneyB.Currency = moneyA.Currency;
                    return moneyA.Currency;
            }
            throw new Exception("There is convertion exception: ");
        }
    }
}




