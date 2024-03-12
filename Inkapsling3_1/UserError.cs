namespace Exercise3
{
    //uppg 3.2.1: Skapa den abstrakta klassen UserError
    abstract class UserError
    {
        //uppg 3.2.2:  Skapa den abstrakta metodenUEMessage() som har returtypenstring.
        public abstract string UEMessage();
    }

    //uppg 3.2.3: Skapa en vanlig klass NumericInputError som ärverfrånUserError
    class NumericInputError : UserError
    {
        //uppg 3.2.4:  Skriv enoverride för UEMessage()så att den returerar “You tried to use numeric input in a text only field.This fired an error!”
        public override string UEMessage()
        {
            return "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    //uppg 3.2.5: Skapa en vanlig klass TextInputError som ärver frånUserError
    class TextInputError : UserError
    {
        //uppg: 3.2.6:  Skriv enoverride förUEMessage()så att den returerar “You tried to use a text input in a numeric only field.This fired an error!”
        public override string UEMessage()
        {
            return "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }

    // uppg 3.2.9: Skapa nu tre egna klasser med tre egna definitioner på UEMessage()
    class DateFormatInputError : UserError
    {
        public override string UEMessage()
        {
            return "You input incorrect date format in the textfield, use YY-MM-DD";
        }
    }

    class PasswordInputError : UserError
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
