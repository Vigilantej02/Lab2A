using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Please enter the name of your item");
    var itemName = Console.ReadLine();
    Console.WriteLine("Please enter the quantity");
    var itemQuantity = Console.ReadLine();
    Console.WriteLine("Please enter the price per unit of the item");
    var itemUnitPrice = Console.ReadLine();
    int itemQuantity1 = Convert.ToInt32(itemQuantity);
    double itemUnitPrice1 = Convert.ToDouble(itemUnitPrice);
    Console.Write("Your total is $");
    Console.Write(itemQuantity1*itemUnitPrice1);
  }
}