﻿namespace Nadala.DesignPatterns.CreationPatterns.FactoryMethod;

class ConcreteCreator2 : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProduct2();
    }
}