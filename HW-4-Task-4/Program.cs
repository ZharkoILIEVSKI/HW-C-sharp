// Task 4

//     Make a method called AgeCalculator
//     The method will have one input parameter, your birthday date
//     The method should return your age
//     Show the age of a user after he inputs a date

//     Note: take into consideration if the birthday is today, after or before today


int AgeCalculator(DateTime mojRodenden)
{
    DateTime dt1 = DateTime.Today;
    return dt1.Year - mojRodenden.Year;

}
Console.WriteLine("Vnesete go vasiot rodenden: ");
DateTime rodenden = Convert.ToDateTime(Console.ReadLine());
int Age = AgeCalculator(rodenden);
Console.WriteLine(Age);

