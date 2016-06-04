using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B16Ex04_Idanshuraty_201580990_SagiGleizer
{
    public class MainMenu
    {
        private List<Menu> m_MenuItems;
        private int m_CurrentLevel;


        public int CurrentLevel
        {
            get { return m_CurrentLevel; }
            set { m_CurrentLevel = value; }
        }
        

        public List<Menu> MenuItems
        {
            get { return m_MenuItems; }
            set { m_MenuItems = value; }
        }
        
        public void Show()
        {
            bool wantToQuit = false;
            // Loop
            while (!wantToQuit)
            {
                // 1. Show the current level

                // 2. Asks the user to choose one of the items

                // 3. Recieves the user's choice

                // 4. Checks vlidation + shows attributed message when not valid

                // 5.a Clears the screen and invokes Menu.OnClick()

                //5.b Clears the screen and invokes Menu.OnClick(), and then shows to the current level
            }
        }
    }
}
