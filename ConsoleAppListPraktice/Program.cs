using System.ComponentModel;
using System.Threading.Channels;

internal class Program
{
    private static void Main(string[] args)
    {
        //praktice1();
        //praktice2();
        //praktice3();
        praktice4();



    }

    /*
     1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

    If no one likes your post, it doesn't display anything.
    If only one person likes your post, it displays: [Friend's Name] likes your post.
    If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
    If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
     
     */

    public static void praktice1() {
              
        List<string> zoznamMien = new List<string>();

        while (true) {

            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                break;
            }
            zoznamMien.Add(input);
        }

        switch (zoznamMien.Count)
        {
            case 0:
                Console.WriteLine(" ");
                break;

            case 1:
                Console.WriteLine(zoznamMien[0]);
                break;

            case 2:
                Console.WriteLine(zoznamMien[0] + " " + zoznamMien[1]);
                break;

            default:
                Console.WriteLine(zoznamMien[0] + " " + zoznamMien[1] + " " + "+" +(zoznamMien.Count - 2));
                break;

        }

    }
    /* 
     2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.

     */
    public static void praktice2() {

        var input = Console.ReadLine();
        if (!String.IsNullOrWhiteSpace(input)) { 
        
            List<char> menoReverse = new List<char>();

            for (int i = input.Length -1; i >= 0 ; i--) {
                menoReverse.Add(input[i]);
            }
            
            //foreach (var item in menoReverse)
            //{
            //    Console.WriteLine(item);
            //}

            var reversed = new string(menoReverse.ToArray());
            Console.WriteLine(reversed);
        }
    
    }

    /*
     3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
        Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
     
     */

    public static void praktice3() {

        Console.WriteLine("Napis 5 unikatnych cisel");

        var pocet = 5;
        List<int> cisla = new List<int>();
        int input;
        var unique = true;
        
        while (pocet > 0) {
            
           input = Convert.ToInt32(Console.ReadLine());
           unique = true;

            foreach (int cislo in cisla) {

                if (cislo == input)
                {

                    Console.WriteLine("Cislo neni unikatne skus znova");
                    unique = false;
                    break;
                }
                
            }
            if (unique) {
                cisla.Add(input);
                pocet--;
            }
            

        }
        cisla.Sort();
        foreach (var item in cisla)
        {
            Console.WriteLine(item);
        }

    }

    /*
     4- Write a program and ask the user to continuously enter a number or type "quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
     */

    public static void praktice4() {
        Console.WriteLine("Napis cislo alebo quit pre ukoncenie");

        List<int> cisla = new List<int>();
        string input= " ";
        
        var pokracovat = true;
        
        while (pokracovat)
        {
            input = Console.ReadLine();

            if (input == "quit")
            {
                pokracovat = false;
            } else if (String.IsNullOrEmpty(input)) 
            {
                Console.WriteLine("Nezadali ste ziadne cislo");
            }
            else {

                cisla.Add(Convert.ToInt32(input));
            }
            

        }
        cisla.Sort();

        for (int i = 0; i < cisla.Count; i++)
        {
            
            int pom = 0;
            var unikatneCislo = cisla[i];

            for (int j = 0; j < cisla.Count; j++)
            {
                if (unikatneCislo == cisla[j]) 
                {
                    pom++;
                    
                }
                if (pom == 2) { break; }
            }
            if (pom == 1) {

                Console.WriteLine(cisla[i]);
            }
            
        }            

    }
}