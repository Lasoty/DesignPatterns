﻿namespace Nadala.DesignPatterns.CreationPatterns.FactoryMethod;

/// <summary>
/// Concrete Products provide various implementations of the Product interface.
/// </summary>
class ConcreteProduct1 : IProduct
{
    public string Operation()
    {
        return "{Result of ConcreteProduct1}";
    }
}