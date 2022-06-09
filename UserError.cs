using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    abstract class UserError
        {
            public abstract string UEMessage();
        }
        class NumericInputError : UserError
        {
            public override string UEMessage()
            {
                return "You tried to use a numeric inputin a text only field. This fired an error";
            }
        }
        class TextInputError : UserError
        {
            public override string UEMessage()
            {
                return "“You tried to use a text input in anumericonly field. This fired an error!";
            }
        }
    }



