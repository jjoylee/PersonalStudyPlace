using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class Waitress
    {
        //Menu pancakeHouseMenu;
        //Menu dinerMenu;
        //Menu cafeMenu;

        MenuComponent allMenus;

        //public Waitress(Menu pancakeHouseMenu, Menu dinerMenu, Menu cafeMenu)
        //{
        //    this.pancakeHouseMenu = pancakeHouseMenu;
        //    this.dinerMenu = dinerMenu;
        //    this.cafeMenu = cafeMenu;
        //}

        public Waitress(MenuComponent allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            //IEnumerator pancakeEnumerator = pancakeHouseMenu.createEnumerator();
            //IEnumerator dinerEnumerator = dinerMenu.createEnumerator();
            //IEnumerator cafeEnumerator = cafeMenu.createEnumerator();
            //Console.WriteLine("------ 아침 메뉴 ------");
            //printMenu(pancakeEnumerator);
            //Console.WriteLine("------ 점심 메뉴 ------");
            //printMenu(dinerEnumerator);
            //Console.WriteLine("------ 저녁 메뉴 ------");
            //printMenu(cafeEnumerator);

            //IEnumerator menuEnumerator = menus.GetEnumerator();
            //while (menuEnumerator.MoveNext())
            //{
            //    Menu menu = (Menu)menuEnumerator.Current;
            //    printMenu(menu.createEnumerator());
            //}

            allMenus.print();
        }

        //private void printMenu(IEnumerator enumerator)
        //{
        //    while (enumerator.MoveNext() && enumerator.Current != null)
        //    {
        //        MenuItem menuItem = (MenuItem)enumerator.Current;
        //        Console.Write(menuItem.getName() + ", ");
        //        Console.Write(menuItem.getPrice() + " -- ");
        //        Console.WriteLine(menuItem.getDescription());
        //    }
        //}

        public void printVegetarianMenu()
        {
            IEnumerator enumerator = allMenus.createEnumerator();
            Console.WriteLine("------ Vegetarian Menu ------");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;
                try
                {
                    if (menuComponent.isVegetarian())
                    {
                        menuComponent.print();
                    }
                } catch(Exception e) { }
            }
        }
    }
}
