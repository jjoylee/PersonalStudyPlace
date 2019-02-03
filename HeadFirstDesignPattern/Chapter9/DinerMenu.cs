﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class DinerMenu
    {
        public const int MAX_ITEMS = 6;
        public int numberOfItems = 0;
        MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            addItem("채식주의자용 BLT", "통밀 위에 식물성 베이컨, 상추, 토마토를 얹은 메뉴", true, 2.99);
            addItem("BLT", "통밀 위에 베이컨, 상추, 토마토를 얹은 메뉴", false, 2.99);
            addItem("오늘의 스프", "감자 샐러드를 곁들인 오늘의 스프", false, 3.29);
            addItem("핫도그", "샤워크라우트, 갖은 양념, 양파, 치즈가 곁들어진 핫도그", false, 3.05);
        }

        private void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if(numberOfItems >= MAX_ITEMS)
                Console.WriteLine("죄송합니다. 메뉴가 꽉 찼습니다. 더이상 추가할 수 없습니다.");
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems += 1;
            }
        }

        //public MenuItem[] getMenuItmes()
        //{
        //    return menuItems;
        //}

        public IEnumerator createEnumerator()
        {
            return menuItems.GetEnumerator();
        }
    }
}
