NewMethod ();

static void NewMethod () {
   Console.WriteLine ("Enter your name");
   string name = Console.ReadLine ();

   Console.WriteLine ("\nEnter your number");
   Random rnd = new ();
   int rnd_num = rnd.Next (0, 100);
   
   int j = 6;
   for (int i = 0; i <= j; i++) {
      
      int user_num = Convert.ToInt32 (Console.ReadLine ());

      if (rnd_num == user_num)
         Console.WriteLine ($"Your are a genius {name}", "\n");
      
      else if (rnd_num < user_num)
         Console.WriteLine ($"your guess is high, Try again you have {j - i} chances left", "\n");
      else 
         Console.WriteLine ($"your guess is low, Try again you have {j - i} chances left", "\n");
              
   }
   Console.WriteLine ("\nGame Over");

   Console.WriteLine ("\nCorrect answer is  " + rnd_num);
}
