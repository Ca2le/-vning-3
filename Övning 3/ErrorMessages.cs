using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_3
{
    internal class ErrorMessages : UserError
    {
        override public string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }
    internal class TextInputError : UserError
    {
        override public string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
    internal class LengthInputError : UserError
    {
        override public string UEMessage()
        {
            return "You tried to use a text input that was too long. This fired an error!";
        }
    }
    internal class HeightInputError : UserError
    {
        override public string UEMessage()
        {
            return "You tried to use a height input that was too high. This fired an error!";
        }
    }
    internal class WeightInputError : UserError
    {
        override public string UEMessage()
        {
            return "Your weight input was too low. This fired an error!";
        }
    }
    internal class NoProps : UserError
    {
        override public string UEMessage()
        {
            return "This instance don't have any props! Hmm...";
        }
    }
}
