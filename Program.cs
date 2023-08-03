Console.WriteLine ("Enter your lucky number");
int unum = Convert.ToInt32 (Console.ReadLine ());

Random rnd = new ();
int num = rnd.Next (0, 100);
Console.WriteLine ("\nMatching result between your lucky number and computer generated number");// Guess the computer generated number

while (num == unum) {
   Console.WriteLine ("\nHurray winner winner chicken dinner,your guess is corect");
   break;
}

if (num < unum) 
   Console.WriteLine ("\nyour guess is high");
else 
   Console.WriteLine ("\nyour guess is low");

//Console.WriteLine ("\nCorrect answer is  " + num);
