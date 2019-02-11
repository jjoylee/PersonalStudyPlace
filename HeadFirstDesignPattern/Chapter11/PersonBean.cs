using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    public interface PersonBean
    {
        string getName();
        string getGender();
        string getInterests();
        int getHotOrNotRating();

        void setName(string name);
        void setGender(string gender);
        void setInterest(string interests);
        void setHotOrNotRating(int rating);
    }
}
