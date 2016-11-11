using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace sharp_event_delegate
{
    class DataProvider
    {
        public delegate void RefreshHandler(int data);

        public event RefreshHandler Refresh;
        public event RefreshHandler Refresh100;
        public event RefreshHandler Refresh200;

        private Thread threadRevData100 = null;
        private Thread threadRevData200 = null; 


        public DataProvider() 
        {
            
        }

        public DataProvider(int code)
        {
            threadRevData100 = new Thread(getData100);
            threadRevData100.Start();
            threadRevData200 = new Thread(getData200);
            threadRevData200.Start();
        }

        public void getData()
        {
            int index = 0;

            while (index < 100000)
            {
                if (index % 100 == 0)
                {
                    Refresh(index);
                }

                index++;
                Thread.Sleep(10);
            }
        }

        public void getData100()
        {
            int index = 0;

            while (index < 100000 )
            {
                if (index % 100 == 0)
                {
                    Refresh100(index);  
                }
                
                index++;
                Thread.Sleep(10);
            }            
        }

        public void getData200()
        {
            int index = 0;

            while (index < 100000)
            {
                if (index % 200 == 0)
                {
                    Refresh200(index);
                }

                index++;
                Thread.Sleep(10);
            }

        }


    }
}
