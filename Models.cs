using System;

namespace DCIT318_Assignment.Question1
{
    // Question 1a: Define core models using records
    public record Transaction(int Id, DateTime Date, decimal Amount, string Category);
}