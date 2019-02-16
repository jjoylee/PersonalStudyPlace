using System;

namespace Chapter12
{
    public interface Observer
    {
        void update(QuackObservable duck);
    }
}