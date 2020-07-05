using System;
using System.Globalization;

namespace ExercícioFixação_Interface_.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            return DueDate.ToShortDateString() + " - " + Amount.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
