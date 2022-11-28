namespace Customer
{


    internal class Customer
    {
        public string firstname { get; set; }
        public string surname { get; set; }
        public string location { get; set; }
        public string Plot_no { get; set; }
        public double quantity_used { get; set; }
        double vat = 14;

        void customer_calculator()
        {
            Console.WriteLine("**************************************************");
        }



        public double getdomestic()
        {





            switch (quantity_used)
            {
                case 0 - 5:

                    Console.WriteLine("Portable Water Cost      :" + Math.Round((quantity_used * 3.60), 2));
                    Console.WriteLine("Waste Water Cost         :" + Math.Round((quantity_used * 0.65), 2));
                    Console.WriteLine("Total Amount             :" + Math.Round(((quantity_used * 0.65) + (quantity_used * 3.60)), 2));
                    break;

                case > 5 - 15:

                    Console.WriteLine("Portable Water Cost      :" + Math.Round(((5 * 3.60) + ((quantity_used - 5) * 13.43)), 2));
                    Console.WriteLine("Wastewater Cost          :" + Math.Round(((5 * 0.65) + ((quantity_used - 5) * 3.36)), 2));
                    Console.WriteLine("Total Amount             :" + Math.Round((((5 * 3.60) + ((quantity_used - 5) * 13.43)) + ((5 * 0.65) + ((quantity_used - 5) * 3.36))), 2));
                    break;

                case 15 - 25:

                    Console.WriteLine("Portable Water Cost      :" + Math.Round(((5 * 3.60) + (10 * 13.43) + ((quantity_used - 25) * 23.51)), 2));
                    Console.WriteLine("Waste Water Cost         :" + Math.Round(((5 * 0.65) + (10 * 3.36) + ((quantity_used - 25) * 5.03)), 2));
                    Console.WriteLine("Total Amount             :" + Math.Round((((5 * 3.60) + (10 * 13.43) + ((quantity_used - 25) * 23.51)) + ((5 * 0.65) + (10 * 3.36) + ((quantity_used - 25) * 5.03))), 2));
                    break;

                case > 25 - 40:

                    Console.WriteLine("Portable Water Cost      :" + Math.Round(((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + ((quantity_used - 25) * 36.16)), 2));
                    Console.WriteLine("Waste Water Cost         :" + Math.Round(((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + ((quantity_used - 25) * 6.71)), 2));
                    Console.WriteLine("Total Amount             :" + Math.Round((((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + ((quantity_used - 25) * 36.16)) + ((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + ((quantity_used - 25) * 6.71))), 2));
                    break;

                default:

                    Console.WriteLine("Portale Water Cost       :" + Math.Round(((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + (15 * 36.16) + ((quantity_used - 40) * 45.21)), 2));
                    Console.WriteLine("Waste Water Cost         :" + Math.Round(((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((quantity_used - 40) * 8.39)), 2));
                    Console.WriteLine("Total Amount             :" + Math.Round((((5 * 3.60) + (10 * 13.43) + (10 * 23.51) + (15 * 36.16) + ((quantity_used - 40) * 45.21)) + ((5 * 0.65) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((quantity_used - 40) * 8.39))), 2));

                    break;

                    

            }
            return quantity_used;

        }

        public double getBusiness()
        {




            switch (quantity_used)
            {



                case 0 - 5:
                    Console.WriteLine("Portable Water Cost      :" + Math.Round((quantity_used * 4.92), 2));
                    Console.WriteLine("Waste Water Cost         :" + Math.Round((quantity_used * 0.74), 2));
                    Console.WriteLine("Total Amount             :" + Math.Round(((quantity_used * 4.92) + (quantity_used * 0.74)), 2));
                    break ;

                case > 5 - 15:
                    
                        Console.WriteLine("Portale Water Cost       :" + Math.Round(((5 * 4.92) + ((quantity_used - 5) * 14.61)), 2));
                        Console.WriteLine("Waste Water Cost         :" + Math.Round(((5 * 0.74) + ((quantity_used - 5) * 3.36)), 2));
                        Console.WriteLine("Total Amount             :" + Math.Round((((5 * 4.92) + ((quantity_used - 5) * 14.61)) + ((5 * 0.74) + ((quantity_used - 5) * 3.36))), 2));
                    break;


                case 15 - 25:
                        Console.WriteLine("Portable Water Cost      :" + Math.Round(((5 * 4.92) + (10 * 14.61) + ((quantity_used - 25) * 25.58)), 2));
                        Console.WriteLine("Waste Water Cost         :" + Math.Round(((5 * 0.74) + (10 * 3.36) + ((quantity_used - 25) * 5.03)), 2));
                        Console.WriteLine("Total Amount             :" + Math.Round((((5 * 4.92) + (10 * 14.61) + ((quantity_used - 25) * 25.58)) + ((5 * 0.74) + (10 * 3.36) + ((quantity_used - 25) * 5.03))), 2));
                    break;

                case 25 - 40:
                    
                        Console.WriteLine("Portable Water Cost      :" + Math.Round(((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + ((quantity_used - 25) * 39.35)), 2));
                        Console.WriteLine("Waste Water Cost         :" + Math.Round(((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + ((quantity_used - 25) * 6.71)), 2));
                        Console.WriteLine("Total Amount             :" + Math.Round((((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + ((quantity_used - 25) * 39.35)) + ((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + ((quantity_used - 25) * 6.71))), 2));
                    break;

                default:
                    
                        Console.WriteLine("Portable Water Cost      :" + Math.Round(((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + (15 * 39.35) + ((quantity_used - 40) * 49.20)), 2));
                        Console.WriteLine("Waste Water Cost         :" + Math.Round(((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((quantity_used - 40) * 8.39)), 2));
                        Console.WriteLine("Total Amount             :" + Math.Round((((5 * 4.92) + (10 * 14.61) + (10 * 25.58) + (15 * 39.35) + ((quantity_used - 40) * 49.20)) + ((5 * 0.74) + (10 * 3.36) + (10 * 5.03) + (15 * 6.71) + ((quantity_used - 40) * 8.39))), 2));

                    break;

            }
            return quantity_used;
        }





      

        
    }
    internal class Customert
    {
        
        static void Main(string[] args)
        {
            StreamWriter outputFile;
            StreamWriter recordFile;
            outputFile = new("Customer.csv");
            recordFile = File.AppendText("Report.csv");
            ConsoleKeyInfo key;



            string password = ("");



            Console.WriteLine(" Please Enter Username");
            string Username = Console.ReadLine();



            Console.WriteLine("Please Enter Password ");
            do
            {
                key = Console.ReadKey(true);
                if (key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;



                    Console.Write("*************");



                }
                else
                {
                    if (password.Length > 0)
                    {
                        password = password.Substring(0, password.Length - 1);
                        Console.Write("\b \b");
                    }
                }



            } while (key.Key! == ConsoleKey.Enter);



            outputFile.WriteLine("User Name is : " + Username);
            outputFile.WriteLine("Password is :" + password);
            Console.ReadLine();

            Customer customer = new Customer();
            Console.WriteLine("Enter Customer Name");
            customer.firstname = Console.ReadLine();
            outputFile.WriteLine(customer.firstname);
            Console.WriteLine("Enter Customer Surname");
            customer.surname = Console.ReadLine();
            outputFile.WriteLine(customer.surname);
            Console.WriteLine("Enter Customer Location");
            customer.location = Console.ReadLine();
            outputFile.WriteLine(customer.location);
            Console.WriteLine("Please Enter Plot no");
            customer.Plot_no = Console.ReadLine();
            outputFile.WriteLine(customer.Plot_no);
            Console.WriteLine("Please enter amount of water used");
            customer.quantity_used = Convert.ToDouble(Console.ReadLine());
            outputFile.WriteLine(customer.quantity_used);
            Console.WriteLine("Please Enter 1 if you are a Domestic User" + "Please Enter 2 if you are a Commercial User");
             string answer;
            answer = Console.ReadLine();
            if (answer  == "1" )
            {
                Console.WriteLine("****************************************************************");
                Console.WriteLine(customer.getdomestic());
                outputFile.WriteLine(customer.getdomestic());
                Console.WriteLine("****************************************************************");
            }
            else if (answer == "2" )
            {
                Console.WriteLine("****************************************************************");
                Console.WriteLine(customer.getBusiness());
                outputFile.WriteLine(customer.getBusiness());
                Console.WriteLine("****************************************************************");

            }

            
          

            outputFile.Close();
            recordFile.Close();

        }


    }
}