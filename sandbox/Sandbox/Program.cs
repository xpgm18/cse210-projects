// using System;
Console.WriteLine("Hello, PiggyBank World!");
PiggyBank myBank = new PiggyBank();
myBank.Deposit(.75f);
Console.WriteLine($"My piggy bank has ${myBank.GetBalance()}");
myBank.Deposit(.38f);
Console.WriteLine($"My piggy bank has ${myBank.GetBalance()}");
PiggyBank yourBank = new();         // Another "instance" of PiggyBank
yourBank.Deposit(12.45f);
// Console.WriteLine($"Your piggy bank has ${yourBank.GetBalance()}");
Console.WriteLine($"Your bank has ${yourBank.GetBalance()} in it");
float withdrawal = myBank.Withdraw(.93f);    // except we can't do a withdrawal
Console.WriteLine($"I withdrew ${withdrawal} from my bank ");
float myMoney = myBank.Break();
Console.WriteLine($"I got ${myMoney} by braking the piggy bank. ");
myBank.Deposit(5.00f);
Console.WriteLine($"My piggy bank has ${myBank.GetBalance()}");
