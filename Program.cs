// Chris Martinez
//09/07/22 
// Mini Challenge #1 "What is your name?"
//Peer Review: Jessie - Code looks good and is working.
// Console.Clear();
// string name;
// Console.Write("Buenos Dias!, What is your name:");
// name = Console.ReadLine();
// Console.WriteLine("Hola "  + name);
Console.Clear();
bool playing = true;
int wrong = 0;
bool number;
string no;
while(playing)
{
    Console.WriteLine("Hello what is your Nombre?<><><><><><> Mine is, HolaBot<><><><><><>.");
    string MyName = Console.ReadLine();
            number = Int32.TryParse(MyName, out wrong);
        if(number == true){
            Console.WriteLine("please enter a NAME not digits.");
        }else
        {
            Console.WriteLine("Gracias " + MyName + ".");
        }
            Console.WriteLine("would you like to play again? type in yes or no");
            no = Console.ReadLine();
        if(no == "no")
        {
            playing = false;
        }
}