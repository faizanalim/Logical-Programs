using System;
using System.Collections.Generic;
using System.Text;

namespace Logical_Programs
{
    public class compareTriplets
    {

        //* Complete the 'compareTriplets' function below.
        //*
        //* The function is expected to return an INTEGER_ARRAY.
        //* The function accepts following parameters:
        //*  1. INTEGER_ARRAY a
        //*  2. INTEGER_ARRAY b
        //        In this example:

        //Now, let's compare each individual score:

        //, so Alice receives
        //point.
        //, so nobody receives a point.
        //, so Bob receives

        //    point.

        //Alice's comparison score is
        //, and Bob's comparison score is . Thus, we return the array . 

        //*

        public static List<int> compareTriplets_HackerRank(List<int> a, List<int> b)
        {
            int alice = 0;
            int bob = 0;
            List<int> result = new List<int>();

            int aLen = a.Count;
            int bLen = b.Count;


            for (int i = 0; i <= aLen - 1; i++)
            {
                if (a[i] > b[i])
                {

                    alice += 1;
                }
                else if (a[i] < b[i])
                {
                    bob += 1;

                }
                else
                {

                }

            }
            result.Add(alice);
            result.Add(bob);

            return result;
        }
    }
}
