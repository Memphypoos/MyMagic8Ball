using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class _8ball
    {
        public static string response()
        {
            Random rnd = new Random();
            string[] myArray = {"It is certain\n",
                                "It is decidedly so\n",
                                "Without a doubt\n",
                                "Yes, definitely\n",
                                "You may rely on it\n",
                                "Most likely\n",
                                "Outlook Good\n",
                                "Yes\n",
                                "Signs point to yes\n",
                                "Reply hazy, try again\n",
                                "Cannot predict now\n",
                                "Don't count on it\n",
                                "My reply is no\n",
                                "My sources say no\n",
                                "Outlook not so good\n",
                                "Very doubtful\n",
                                "Definitely maybe\n",
                                "Signs point to no\n" };
            var randomResponse = myArray[rnd.Next(myArray.Length)];
            return randomResponse.ToString();
        }

    }
}
