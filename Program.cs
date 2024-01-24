Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here


if (daysUntilExpiration == 0)
{
    //Already expired
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    //1 day until expiration
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!\nRenew now and save {discountPercentage}%");
}
else if (daysUntilExpiration <= 5)
{
    //5 days or less until expiration
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%");
}
else if (daysUntilExpiration <= 10)
//10 days or less until expiration
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

//I didn't get the directions right. They wanted TWO if statements.
//They used a second if statement to write out the second line in with the discount percentage.
//if (discountPercentage > 0)
//{
//    Console.WriteLine($"Renew now and save {discountPercentage}%.");
//}
