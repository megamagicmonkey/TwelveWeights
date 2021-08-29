using System;
using System.Collections.Generic;

namespace TwelveWeights
{
    class Program
    {
        public static int uses = 3; //counts the number of times the scale can be used

        //Below are 12 weights. Currently, they weigh the same. Later, one weight chosen at random
        //will be assigned a random value that is NOT 100. Either above or below.
        //AT NO POINT WILL THE CODE YOU WRITE MODIFY THIS ARRAY
        public static int[] weights = new int[12];
        static void Main(string[] args)
        {
            //int rounds = 0; //ERASE this commenting to make it a loop
            //while (rounds < 100000){ //ERASE this commenting to make it a loop
                for (int i = 0; i < 12; i++)
                {
                    weights[i] = 100;
                }
                ChangeWeight(weights); //This changes a single weight to be either more or less than before

                string result = "";
                var toLeftScale = new List<int>(); //use these to send weights to the left scale
                var toRightScale = new List<int>(); //use these to send weights to the right scale
            /*BalanceScale() is your scale. Send two lists, one for the left scale and one for the right.
            Calls should look like: result = BalanceScale(toLeftScale, toRightScale);

            BalanceScale can return these results:
            "right" if the right scale weighs more.
            "left" if the left scale weighs more.
            "equal" if both scales weigh the same.
            "Scale cannot be used further" if you are trying to use the scale beyond its third use.
            Use these values to determine how to proceed to your next line of logic.
            Ideally, you should never return the fourth option. Just know it is there.

            Populate the above lists by adding the contents from weights into each scale based on which you wish to measure
            I.E. A list composed of the values of weights[0-3] to the left and the values of weights[4-7] to the right *hint hint*

            When your code is ready to declare an answer, invoke Accuse(int, bool);
            The integer should be the index of the weight you expect to be faulty.
            For the boolean, submit true if you think it's heavier than the others, and false if you think it is lighter.

            Only using the lists provided, and the feedback from BalanceScales, see if you can write an algorithm that will always find
            the right answer! Start by populating your two lists. Don't forget to clear them after each weighing!
            Also, you're going to need a lot of if/else logic!

            You won't need additional methods.
            You won't need additional variables, but you're welcome to use them.
            See if you can finish without creating additional Console.WriteLine();!
            */


            //====YOUR CODE BELOW====






            //====YOUR CODE ABOVE====

            //BONUS: To make extra sure your code works in all cases, erase the commenting in the ERASE lines.


            //rounds++; //ERASE this commenting to make it loop
            //} //ERASE this commenting to make it a loop



            //Printed out the weights to see if the randomization was working
            /*
            for (int i = 0; i < 12; i++ )
            {
                Console.WriteLine($"Weight {i+1} weighs {weights[i]}");
            }
            */
        }


        private static void Accuse(int index, bool heavier)
        {
            if (heavier)
            {
                Console.WriteLine($"Your code suspects weight {index} is heavier than the others.");
                if (weights[index] > 100)
                {
                    Console.WriteLine("And it is correct!");
                }
                else
                {
                    Console.WriteLine("And it is wrong...");
                }
            }
            else
            {
                Console.WriteLine($"Your code suspects weight {index} is lighter than the others.");
                if (weights[index] < 100)
                {
                    Console.WriteLine("And it is correct!");
                }
                else
                {
                    Console.WriteLine("And it is wrong...");
                }
            }
        }
        private static string BalanceScale( List<int> leftScale, List<int> rightScale )
        {
            int leftTotal = 0;
            int rightTotal = 0;

            //Returns a string value based on which side is heavier. "right" "left" and "equal"
            //If you try to run BalanceScale more than 3 times, it will output "Scale cannot be used further", so call it sparingly!

            if (uses != 0)
            {
                uses--;
                for (int i = 0; i < leftScale.Count; i++)
                {
                    leftTotal += leftScale[i]; //combines the weight values of the weights on leftScale
                }
                for (int i = 0; i < rightScale.Count; i++)
                {
                    rightTotal += rightScale[i]; //combines the weight values on rightScale
                }
                if (leftTotal > rightTotal)
                {
                    return "left";
                }
                 else if (leftTotal < rightTotal)
                {
                    return "right";
                }
                else if (leftTotal == rightTotal)
                {
                    return "equal";
                }
                else
                {
                    return "How did you get this?";
                }
            }
            else
            {
                return "Scale cannot be used further";
            }
            
        }
        private static void ChangeWeight(int[] weights)
        {
            Random rng = new Random();
            int index = rng.Next(0, 12);
            int change=0;

            while (change == 0) {
                change = rng.Next(-50, 51);
            }

            weights[index] += change;
        }
    }
}
