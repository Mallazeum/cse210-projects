using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        Reference reff = new Reference("D&C",93,23);
        Scripture scripture = new Scripture(reff,"Ye were also in the begining with the father; that which is Spirit, even the Spirit of truth;");
        int hide = 0;
        do{
            Console.Clear();
            scripture.HideRandomWords(hide);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type quit to quit.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            hide = rand.Next(1,4);
        }while(scripture.IsCompletelyHidden() != true);

        Reference newReff = new Reference("3 Nephi",11,10,11);
        Scripture newScripture = new Scripture(newReff,"10 Behold, I am Jesus Christ, whom the prophets testified shall come into the world. 11 And behold, I am the light and the life of the world; and i have drunk out of that bitter cup which the Father hath given me, and have glorified the Father in taking upon me the sins of the world, in the which I have suffered the will of the fatherin all things from the begininning.");
        hide = 0;
        do{
            Console.Clear();
            newScripture.HideRandomWords(hide);
            Console.WriteLine(newScripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type quit to quit.");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            hide = rand.Next(1,4);
        }while(newScripture.IsCompletelyHidden() != true);
    }
}