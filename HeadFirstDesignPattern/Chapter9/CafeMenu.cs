using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class CafeMenu
    {
        Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            addItem("베지 버거와 에어 프라이", "통밀빵, 상추, 토마토, 감자튀김이 첨가된 베지 버거", true, 3.99);
            addItem("오늘의 스프", "샐러드가 곁들어진 오늘의 스프", false, 3.69);
            addItem("베리또", "통 핀토콩과 살사, 구아카몰이 곁들여진 푸짐한 베리또", true, 4.29);
        }

        private void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem.getName(), menuItem);
        }

        //public Hashtable getItems()
        //{
        //    return menuItems;
        //}

        public IEnumerator createEnumerator()
        {
            return menuItems.Values.GetEnumerator();
        }
    }
}
