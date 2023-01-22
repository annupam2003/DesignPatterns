﻿namespace FactoryMethodDesignPattern;

public interface ICreditCard
{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}