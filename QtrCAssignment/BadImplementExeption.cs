using System;
using System.Collections.Generic;
using System.Text;

namespace QtrCAssignment
{
    class BadImplementExeption : Exception
    {
        public BadImplementExeption()
            :base ("המימוש לא היה ברור ונאלצנו להחליף אותו בשגיאה זו על מנת להריץ את הטסטים")
        {

        }
        public BadImplementExeption(string message)
            : base(message)
        {

        }
        public BadImplementExeption(string message, Exception inner)
            : base (message, inner)
        {

        }
    }
}
