using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class PancakeHouseMenu
    {
        ArrayList menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new ArrayList();
            addItem("K&B 팬케이크 세트", "스크램블 에그와 토스트가곁들어진 팬케이크", true, 2.99);
            addItem("레귤러 팬케이크 세트", "달걀 후라이와 소시지가 곁들어진 팬케이크", false, 2.99);
            addItem("블루베리 팬케이크", "신선한 블루베리와 블루베리 시럽으로 만든 팬케이크", true, 3.49);
            addItem("와플", "와플, 취향에 따라 블루베리나 딸기를 얹을 수 있습니다.", true, 3.59);
        }

        private void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        //public ArrayList getMenuItems()
        //{
        //    return menuItems;
        //}

        public IEnumerator createEnumerator()
        {
            return menuItems.GetEnumerator();
        }
    }
}
