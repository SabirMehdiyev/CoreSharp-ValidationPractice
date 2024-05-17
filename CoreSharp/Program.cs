namespace CoreSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal resultTotal = 0;

            while (true)
            {
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");
                string operatorName;
                int size;
                int count;
                decimal price;
                string color;
                string brandName;
                string category;

                #region Operator name validaiton

                while (true)
                {
                    Console.Write("Operator's name : ");
                    operatorName = Console.ReadLine();

                    if (operatorName.Length >= 3 && operatorName.Length <= 15)
                        break;
                    else
                        Console.WriteLine("Ad duzgun daxil edilmeyib");
                }

                #endregion

                #region Size validation

                while (true)
                {
                    Console.Write("Size : ");
                    size = int.Parse(Console.ReadLine());

                    if (size >= 30 && size <= 50)
                        break;
                    else
                        Console.WriteLine("Size duzgun daxil edilmeyib");
                }

                #endregion

                #region Color validation

                while (true)
                {
                    Console.Write("Color : ");
                    color = Console.ReadLine();

                    if (color == "Red" || color == "Black" || color == "Blue")
                        break;
                    else
                        Console.WriteLine("Color duzgun daxil edilmeyib");
                }

                #endregion


                #region Brand validation
                while (true)
                {
                    Console.Write("Brand : ");
                    brandName = Console.ReadLine();

                    if (brandName == "Adidas" || brandName == "Nike" || brandName == "Puma")
                        break;
                    else
                        Console.WriteLine("Brand duzgun daxil edilmeyib");
                }

                #endregion

                #region Category validation
                while (true)
                {
                    Console.Write("Please select category (Sport , Classic , Sneakers) : ");
                    category = Console.ReadLine(); 
                    if (category == "Sport" || category == "Classic" || category == "Sneakers")
                        break;
                    else
                        Console.WriteLine("Kateqoriya duzgun daxil edilmeyib");
                }
                #endregion

                #region PriceValidation
                while (true)
                {
                    Console.Write("Price : ");
                    price = decimal.Parse(Console.ReadLine());
                    if (price > 0)
                        break;
                    else
                        Console.WriteLine("Price duzgun daxil edilmeyib");
                }
                #endregion

                #region Count Validation
                while (true)
                {
                    Console.Write("Count : ");
                    count = int.Parse(Console.ReadLine()); 
                    if (count > 0 && count < 100)
                        break;
                    else
                        Console.WriteLine("Count duzgun daxil edilmeyib");
                }
                #endregion

                decimal individualTotal = count * price;
                resultTotal = resultTotal + individualTotal;

                Console.WriteLine($"Size : {size},  Color : {color}, Brand name : {brandName}, Category : {category}, Price : {price}, Count : {count}, Total : {individualTotal}");
                Console.WriteLine("=============================================================================================");
                Console.WriteLine("=============================================================================================");

                Console.WriteLine("Yeni ayaqqabi elave olunsumu? (Yes, No) (Y, N) ");
                string loopTerminationResult = Console.ReadLine();

                if (loopTerminationResult == "No" || loopTerminationResult == "N")
                {
                    //break based loop control
                    break;

                }
            }


            Console.WriteLine("Result Total : " + resultTotal);

        }
    }
}