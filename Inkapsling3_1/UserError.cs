using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Inkapsling3_1
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    //vilka andra definitioner kan jag ha?
    class DateFormatInputError : UserError 
    { 
        public override string UEMessage() 
        {
            return "You input incorrect date format in the textfield, use YY-MM-DD";
        } 
    }

    class PasswordInputError: UserError
    {
        public override string UEMessage()
        {
            return "Did you enter correct username or password";
        }
    }

    class IllegalSymbolTextInputError : UserError
    {
        public override string UEMessage()
        {
            return "Your text have illegal symbols in your text field input, please use only A-Z or a-z inputs";
        }
    }

}
