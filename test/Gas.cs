using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test;

namespace test
{
    internal class Gas
    {
        public double gasfromto(int From, int Too)
        {
            double gas = 0;
           switch (Too)
            {

                //To the small shop 
                case 1:
                    switch (From)
                    {
                        case 0:
                            gas=25.7;
                            return gas;
                            
                        case 2:
                            gas = 56.2;
                            return gas;
                       
                        case 3:
                            gas = 23.6;
                            return gas;

                        case 4: 
                            gas = 180;
                            return gas;
                        default:
                            return gas;
                    }
               

                //to Shoping center
                case 2:
                    switch (From)
                    {
                        case 0:
                            gas = 63.2;
                            return gas;

                        case 1:
                            gas = 56.2;
                            return gas;

                        case 3:
                            gas = 86.2;
                            return gas;

                        case 4:
                            gas = 130;
                            return gas;
                        default:
                            return gas;

                    }
                
                //to gunrange
                case 3:
                    switch (From)
                    {
                        case 0:
                            gas = 28.7;
                            return gas;

                        case 1:
                            gas = 23.6;
                            return gas;

                        case 2:
                            gas = 86.2;
                            return gas;

                        case 4:
                            gas = 195;
                            return gas;
                        default:
                            return gas;

                    }
               
                //To end
                case 4:
                    switch (From)
                    {
                        case 0:
                            gas = 180;
                            return gas;

                        case 1:
                            gas = 202;
                            return gas;

                        case 2:
                            gas = 130;
                            return gas;

                        case 3:
                            gas = 195;
                            return gas;
                        default:
                            return gas;

                    }
             
                    default:
                    return gas;
           }
        }

    }
}
