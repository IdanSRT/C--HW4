using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B16Ex04_Idanshuraty_201580990_SagiGleizer
{
    class Menu : IClickable
    {
        private string m_Title;
        private List<Menu> m_MenuItems;
        
        public string Title
        {
            get { return m_Title; }
            set { m_Title = value; }
        }
        public List<Menu> MenuItems
        {
            get { return m_MenuItems; }
            set { m_MenuItems = value; }
        }

        public void Onlick()
        {
            //Do something
        }
    }
}
