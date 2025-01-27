using System;


namespace Lahiye_Back
{
    public class Program
    {
        static void Main(string[] args)
        {


            ToDoItem[] toDoItems = new ToDoItem[0];



            string str;
            do
            {
                Console.WriteLine("1. Tapsiriq yarat");
                Console.WriteLine("2. Butun tapsiriqlara bax");
                Console.WriteLine("3. Vaxti kecmis tapsiriqlara bax");
                Console.WriteLine("4. Secilmis statuslu tapsiriqlara bax");
                Console.WriteLine("5. Tarix intervalina gorə axtar");
                Console.WriteLine("6. Tapsirigin statusunu dəyismək");
                Console.WriteLine("7. Tapsirigi editlemek");
                Console.WriteLine("8. Tapsirigi silmek");
                Console.WriteLine("9. Tapsiriqlarda axtariş");
                Console.WriteLine("0.Cixis");
                str = Console.ReadLine();
                switch (str)
                {
                    case "1":
                        Console.WriteLine("Title daxil et");
                        string str6 = Console.ReadLine();
                        Console.WriteLine("Descriptionu daxil et");
                        string str7 = Console.ReadLine();
                        Console.WriteLine("Vaxti teyin ele");

                       
                        
                           string str8 = Console.ReadLine();
                          DateTime  newdate = Convert.ToDateTime(str8);
                        string num = "1";
                        var typeenum = Enum.Parse(typeof(Status), num);

                        ToDoItem toDoItem = new ToDoItem() {Title = str6, Description = str7, DeadLine = newdate, status = (Status)typeenum };
                        Array.Resize(ref toDoItems, toDoItems.Length + 1);
                        toDoItems[toDoItems.Length - 1] = toDoItem;


                        break;
                    case "2":
                        Console.WriteLine("\n============tasklar===========\n");

                        foreach (var item in toDoItems)
                        {

                            Console.WriteLine($"Task No: {item.No}");
                            Console.WriteLine($"Taskin Statusu: {item.status}");
                            Console.WriteLine($"Taskin Title: {item.Title}");
                            Console.WriteLine($"Taskin Descriptionu: {item.Description}");
                            Console.WriteLine($"Taskin DeadLine: {item.DeadLine}");
                            Console.WriteLine("\n ====================\n");
                        }
                        break;

                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":

                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "0":
                        break;

                    default:
                        Console.WriteLine("Secimiviz yanlistir");
                        break;
                }
            } while (str != "0");
        }
                 
       }
}
