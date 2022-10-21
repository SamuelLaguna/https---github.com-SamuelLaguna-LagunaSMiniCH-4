//Samuel Laguna
//10-19-22
//I am to rewrite this code in a diffrent way but to get the same answer. I am
//Also to add a play again feture

bool TryAgain = true;
bool end = false;
Console.Clear();
while(TryAgain == true){
Console.WriteLine("Whitch number is greater then the other");
Console.WriteLine("Please enter the first number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter a secind number");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num > num2){
        Console.WriteLine(num + " Is greater than " + num2);
    Console.WriteLine(num2 + " Is less than " + num);
}else{
    Console.WriteLine(num + " Is less than " + num2);
    Console.WriteLine(num2 + " Is greater than " + num);
    Console.WriteLine("Woudl you like to try again TryAgain to keep going end to end.");
}
      string ending = Console.ReadLine();
      if(ending == "end"){
        TryAgain = false;
        
      }else
      {
        end = true;
      }



}