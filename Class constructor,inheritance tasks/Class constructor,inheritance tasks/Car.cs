using System;
using System.Collections.Generic;
using System.Text;

namespace Class_constructor_inheritance_tasks
{
    internal class Car
    {
        //Aşağıdakı classları yaradırsınız:
        //Vehicle class:
        //- Brand
        // - Model
        // - Millage


        //Car class:
        //- FuelCapacity
        //- CurrentFuel
        //- AddFuel() - parametr olaraq neçə litr benzin əlavə etmək istənildiyi daxil edilməlidir və capacity-ni aşmırsa əlavə edilməlidir
        public void AddFuel(int fuel)
        {
            int totalFuel = fuel + CurrentFuel;
            if (totalFuel <= FuelCapacity)
            {
                CurrentFuel += fuel;
            } 
        }

        public int FuelCapacity;
        public int CurrentFuel;
    }

    

}
