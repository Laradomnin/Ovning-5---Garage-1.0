using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_5___Garage_1._0
{
    public class Garage <T> : IEnumerable <T> where T : Vehicle
    {
        private T[] fordon;


        public Garage(int capacity)
        {
            fordon = new T[capacity];
        }

        //["SAAB", "Volvo", " new vehicle here", "Lada", " "]
        
        public bool Park(T vehicle)
        {
            for (int i = 0; i < fordon.Length; i++)
            {
                if(fordon[i] is null)
                {
                    fordon[i] = vehicle;
                    return true;
                }
            }
            
            return false;
           
        }

        public bool Unpark (string regnr)
        {
            for (int i = 0; i < fordon.Length; i++)
            {
                if (fordon[i].RegNum == regnr)
                {                 
                    fordon[i] = default(T);
                    
                     return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < fordon.Length; i++)
            {
                if(fordon[i] is not null)
                {
                    yield return fordon[i];
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        //uint antal { get; set; };



    }
}
