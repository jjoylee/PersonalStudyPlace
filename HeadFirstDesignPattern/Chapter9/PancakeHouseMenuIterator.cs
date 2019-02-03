using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    public class PancakeHouseMenuIterator : Iterator
    {
        ArrayList items;
        int position = 0;

        public PancakeHouseMenuIterator(ArrayList items)
        {
            this.items = items;
        }

        public bool hasNext()
        {
            if (position >= items.Count || items[position] == null) return false;
            return true;
        }

        public object next()
        {
            MenuItem menuItem = (MenuItem)items[position];
            position += 1;
            return menuItem;
        }
    }
}
