using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung.EasterEgg
{
    class Input
    {
        //Load list of available Keyboard buttons
        private static Hashtable keyTable = new Hashtable();

        // check if button is pressed
        public static bool KeyPressed(Keys key)
        {
            if(keyTable[key] == null)
            {
                return false;
            }
            return (bool)keyTable[key];
        }

        //detect if keyboard button is pressed
        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
