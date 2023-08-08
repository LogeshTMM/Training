NewMethod ();

static void NewMethod () {
   Console.WriteLine ("Enter your name");
   string uname = Console.ReadLine ();

   Console.WriteLine ("\nEnter your lucky number");
   Random rnd = new ();
   int num = rnd.Next (0, 100);
   //Console.WriteLine ("\nMatching result between your lucky number and computer generated number");// Guess the computer generated number
   int j = 6;
   for (int i = 0; i <= j; i++) {
      
      int unum = Convert.ToInt32 (Console.ReadLine ());

      if (num == unum)
         Console.WriteLine ($"Your are a genius {uname}","\n");
   
      else if (num < unum)
         Console.WriteLine ($"your guess is high, Try again you have {j-i} chances left","\n");
      else
         Console.WriteLine ($"your guess is low, Try again you have {j-i} chances left","\n");

   }

   //Console.WriteLine ("\nCorrect answer is  " + num);
}
