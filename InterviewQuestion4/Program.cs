//DESIGN PROBLEM
// We need to design application for creating invoices for customers.
// Invoice need to contains total amount(including VAT), total VAT,List of products with their prices, vat rate, name and quantity
// Please write reusable methods:
// - method for adding products to invoice, 
// - method for calculating total VAT for one product based on quantity
// - method for calculating total price for one product based on quantity
// - method for calculating total amount to pay
// - prices values should be possible with decimal places 
// - as a result i would like to see JSON with object representing INVOICE

//EXPECTED RESULT:
//{
//"Products": [
//    {
//      "Quantity": 5,
//      "TotalPrice": 61.25,
//      "TotalVAT": 12.25,
//      "Name": "Apple",
//      "Price": 12.25
//    },
//    {
//    "Quantity": 7,
//      "TotalPrice": 51.449999999999996,
//      "TotalVAT": 10.29,
//      "Name": "Orange",
//      "Price": 7.35
//    }
//  ],
//  "TotalAmount": 112.69999999999999,
//  "TotalVAT": 22.54
//}


using Newtonsoft.Json;

class MainProgram
{
    public static double VatRate = 0.20;
    static void Main(string[] args)
    {
      
       
        Console.ReadLine();
    }

   
}




