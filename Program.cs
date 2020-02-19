
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Iceland_TechTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string input;
            List<String[]> list = new List<String[]>();
            Console.WriteLine("Insert your Items using the format 'Name item','SellIn value','Quality value' (type EXIT to terminate): ");

            //READING OF ITEMS
            do
            {
                input = Console.ReadLine();
                //using exit word terminate 
                if (input.ToUpper() != "EXIT")
                {
                    char[] separator = { ',' };
                    String[] item = input.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    //if enter the wrong number of items 
                    if (item.Length != 3)
                    {
                        String[] value = { "Mistake!" };
                        list.Add(value);
                    }
                    else 
                    {
                        try { 
                            //read the single value of the item
                            string name = item[0];
                            int sellInValue = int.Parse(item[1]);
                            int qualityValue = int.Parse(item[2]);
                            //invoke the function to have the value updated
                            String[] itemUpdated= updateStatus(name, sellInValue, qualityValue);
                            //add the item value to the list of all items
                            list.Add(itemUpdated);
                        }
                            catch (FormatException e)
                        {
                            Console.WriteLine("Insert right value: Input string was not in a correct format.");
                        }
                    }
                                        
                }
            } while (input.ToUpper() != "EXIT");

            if (list.Count == 0) {
                Console.WriteLine("No Items");
            }
            else 
            {
                Console.WriteLine("\nUpdated inventory after adjusting the quality and sellin days for each item after 1 day: \n");
                foreach (String[] s in list)
                {
                    
                    Console.WriteLine(ConvertStringArrayToString(s));
                }
            }
            //from array string to string
            static string ConvertStringArrayToString(string[] array)
            {
                // Concatenate all the elements into a StringBuilder.
                StringBuilder builder = new StringBuilder();
                foreach (string value in array)
                {
                    builder.Append(value);
                    builder.Append(' ');
                }
                return builder.ToString();
            }

            //FUNCTION THAT UPDATE THE STATUS OF THE ITEMS
            String[] updateStatus(string name, int sellInValue, int qualityValue)
            {
                int sellInValueUpdated, qualityValueUpdated=0;
                switch (name)
                {
                    case "Aged Brie":
                        sellInValueUpdated = sellInValue - 1;
                        qualityValueUpdated = qualityValue + 1;
                        break;
                    case "Christmas Crackers":
                        sellInValueUpdated = sellInValue - 1;

                        DateTime FutureDate = DateTime.ParseExact("12/25/2020", "mm/dd/yyyy", CultureInfo.InvariantCulture);
                        DateTime TodayDate = DateTime.Today;
                        int numberOfDays = DaysBetween(TodayDate, FutureDate);
                        int DaysBetween(DateTime d1, DateTime d2)
                        {
                            TimeSpan span = d2.Subtract(d1);
                            return (int)span.Days;
                        }
                        if (numberOfDays > 10)
                            qualityValueUpdated = qualityValue + 1;
                        if(numberOfDays <= 10 & numberOfDays > 5)
                            qualityValueUpdated = qualityValue + 2;
                        if(numberOfDays <= 5 & numberOfDays > 0)
                            qualityValueUpdated = qualityValue + 3;
                        if(numberOfDays <= 0)
                            qualityValueUpdated = 0;
                        break;
                    case "Soap":
                        sellInValueUpdated = sellInValue;
                        qualityValueUpdated = qualityValue;
                        break;
                    case "Frozen Item":
                        sellInValueUpdated = sellInValue - 1;
                        if (sellInValue > 0)
                        {
                            qualityValueUpdated = qualityValue - 1;
                        }
                        else {
                            qualityValueUpdated = qualityValue - 2;
                        } 
                        break;
                    case "Fresh Item":
                        sellInValueUpdated = sellInValue - 1;
                        if (sellInValue > 0)
                        {
                            qualityValueUpdated = qualityValue - 2;
                        }
                        else
                        {
                            qualityValueUpdated = qualityValue - 4;
                        }
                        break;
                    default:
                        name = "NO SUCH ITEM";
                        sellInValueUpdated = sellInValue;
                        qualityValueUpdated = qualityValue;
                        break;
                }

                if (qualityValueUpdated <= 0) qualityValueUpdated = 0;
                if (qualityValueUpdated > 50) qualityValueUpdated = 50;

                String[] itemUpdated = { name, sellInValueUpdated.ToString(), qualityValueUpdated.ToString() };
                return itemUpdated;
            }
        }
    }
    
}
