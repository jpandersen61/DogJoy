// See https://aka.ms/new-console-template for more information
using DogJoy;

Console.WriteLine();
Console.WriteLine("Opgave 2. Opret Klassen Dog.");
Dog d1 = new Dog(1,"Pluto",Race.Bulldog,2021);
Dog d2 = new Dog(2, "Fido",Race.Terrier, 2019);
Dog d3 = new Dog(2, "Rex", Race.Unknown, 2023);
Console.WriteLine(d1);
Console.WriteLine(d2);

Console.WriteLine();
Console.WriteLine("Opgave 3. Opret Klassen Member.");
Member m1 = new Member(1, "Donald Duck", "10 Duck Street" , new DateTime(1955, 2, 24), "123456789", "DDuck@gmail.com");
Member m2 = new Member(2, "Mickey Mouse", "20 Mouse Alley", new DateTime(1986, 7, 14), "987654321", "MMouse@gmail.com");
Console.WriteLine(m1);
Console.WriteLine(m2);

Console.WriteLine();
Console.WriteLine("Opgave 4: Opret CRUD metoder på klassen Member");
Console.WriteLine("Registering dogs");
m1.RegisterDog(d1);
m1.RegisterDog(d3);
m2.RegisterDog(d2);
m1.PrintDogs();
m2.PrintDogs();
Console.WriteLine("Remowing dog");
m1.RemoveDog(d1);
m1.PrintDogs();

Console.WriteLine();
Console.WriteLine("Opgave 6: Beregninger");

Console.WriteLine("Testing age");
Console.WriteLine($"bDate: {m1.BirthDate}, Age {m1.Age}");
Console.WriteLine($"bDate: {m2.BirthDate}, Age {m2.Age}");

Console.WriteLine();
Console.WriteLine("Testing member fee");

m1.RegisterDog(d1);
double baseFee1 = 500;
double baseFee2 = 1000;

Console.WriteLine();
Console.WriteLine("Testing with a member:");
Console.WriteLine(m1);
m1.PrintDogs();
Console.WriteLine($"Age: {m1.Age}");
Console.WriteLine($"Base fee: {baseFee1}, Member fee: {m1.MemberFee(baseFee1)}");
Console.WriteLine($"Base fee: {baseFee2}, Member fee: {m1.MemberFee(baseFee2)}");

Console.WriteLine();
Console.WriteLine("Testing with another member:");
Console.WriteLine(m2);
m2.PrintDogs();
Console.WriteLine($"Age: {m2.Age}");
Console.WriteLine($"Base fee: {baseFee1}, Member fee: {m2.MemberFee(baseFee1)}");
Console.WriteLine($"Base fee: {baseFee2}, Member fee: {m2.MemberFee(baseFee2)}");

Console.WriteLine();
Console.WriteLine("Opgave 7: Validerings funktioner");
Console.WriteLine();
Console.WriteLine("Testing with a valid member");
Member valid = new Member(42, "Name", "Address", new DateTime(1970, 2, 10), "123456789", "xxx@gmail.com");
Console.WriteLine($"Member: {valid}, Valid: {valid.Validate()}");

//Opgave 7 -> Rewritten for opgave 8
//Console.WriteLine();
//Console.WriteLine("Testing with invalid name");
//Member invalidName = new Member(42, "", "Address", new DateTime(1970, 2, 10), "123456789", "xxx@gmail.com");
//Console.WriteLine($"Member: {invalidName}, Valid: {invalidName.Validate()}");

//Console.WriteLine();
//Console.WriteLine("Testing with invalid address");
//Member invalidAddress = new Member(42, "Name", "", new DateTime(1970, 2, 10), "123456789", "xxx@gmail.com");
//Console.WriteLine($"Member: {invalidAddress}, Valid: {invalidAddress.Validate()}");

//Console.WriteLine();
//Console.WriteLine("Testing with invalid phone number");
//Member invalidPhone = new Member(42, "Name", "Address", new DateTime(1970, 2, 10), "", "xxx@gmail.com");
//Console.WriteLine($"Member: {invalidPhone}, Valid: {invalidPhone.Validate()}");

//Console.WriteLine();
//Console.WriteLine("Testing with invalid e-mail");
//Member invalidEmail = new Member(42, "Name", "Address", new DateTime(1970, 2, 10), "1234567890", "");
//Console.WriteLine($"Member: {invalidEmail}, Valid: {invalidEmail.Validate()}");

//Console.WriteLine();
//Console.WriteLine("Testing with too young too be a member");
//Member tooYoung = new Member(42, "Name", "Address", DateTime.Now, "1234567890", "xxx@gmail.com");
//Console.WriteLine($"Member: {tooYoung}, Valid: {tooYoung.Validate()}");

Console.WriteLine("Opgave 8: Exception handling");

Console.WriteLine();
Console.WriteLine("Testing with invalid name");
try
{
    Member invalidName = new Member(42, "", "Address", new DateTime(1970, 2, 10), "123456789", "xxx@gmail.com");
    Console.WriteLine($"Member: {invalidName}");
    invalidName.Validate();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();
Console.WriteLine("Testing with invalid address");
try
{ 
    Member invalidAddress = new Member(42, "Name", "", new DateTime(1970, 2, 10), "123456789", "xxx@gmail.com");
    Console.WriteLine($"Member: {invalidAddress}");
    invalidAddress.Validate();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();
Console.WriteLine("Testing with invalid phone number");
try
{ 
    Member invalidPhone = new Member(42, "Name", "Address", new DateTime(1970, 2, 10), "", "xxx@gmail.com");
    Console.WriteLine($"Member: {invalidPhone}");
    invalidPhone.Validate();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();
Console.WriteLine("Testing with invalid e-mail");
try
{ 
    Member invalidEmail = new Member(42, "Name", "Address", new DateTime(1970, 2, 10), "1234567890", "");
    Console.WriteLine($"Member: {invalidEmail}");
    invalidEmail.Validate();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine();
Console.WriteLine("Testing with too young too be a member");
try
{ 
    Member tooYoung = new Member(42, "Name", "Address", DateTime.Now, "1234567890", "xxx@gmail.com");
    Console.WriteLine($"Member: {tooYoung}");
    tooYoung.Validate();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



