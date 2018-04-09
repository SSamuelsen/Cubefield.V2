using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Cubefield_V2
{
    public class Barriers
    {


        string[] barrier = { "[]", "[]", "[]", "[]", "[]" };


        private DateTime gameTime = DateTime.Now;
        private static Random randomNumber = new Random();          //random number
        int randomX;
        //int y = 1;
        int updateInterval = 450;






        public void displayBarrier(int y) {      //prints out all the barriers to the console

            randomX = randomNumber.Next(1, 70);


            Console.SetCursorPosition(randomX, y);
                
             foreach (var x in barrier)
               {
                   Console.Write(x);
               }


            randomX = randomNumber.Next(1, 70);

            Console.SetCursorPosition(randomX, y);

            foreach (var x in barrier)
            {
                Console.Write(x);
            }

            Console.WriteLine();





        }//end of displayBarrier method




        public void displayLevel() {

            int i = 1;
            //Console.SetBufferSize(70, 700);


            while (true)
            {

                displayBarrier(i);
                i++;
                System.Threading.Thread.Sleep(100);

            }




        }










        public Barriers()       //constructor
        {
        }
    }
}
