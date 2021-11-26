using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace W1A3.Models
{
    public class GuessNumberModel
    {
        [ViewData]
        public int NumberToGuess { get; set; }

        [Required]
        [Range(0, 101, ErrorMessage = "The number is between 1 and 100."), MaxLength(3)]
        public int GuessedNumber { get; set; }


        public static string WriteMessage()
        {
            return "test";
        }

        public string CheckGuess(int guessedNumber)
        {
            string message;

            if (guessedNumber == NumberToGuess)
            {
                message = "You guessed correctly";
            }
            else if (guessedNumber > NumberToGuess)
            {
                message = ("The number is smaller");
            }
            else
            {
                message = ("Your number is larger");
            }
            return message;
        }
    }
}



// kika på detta senare
// https://docs.microsoft.com/en-us/dotnet/api/system.random?redirectedfrom=MSDN&view=net-6.0#ThreadSafety