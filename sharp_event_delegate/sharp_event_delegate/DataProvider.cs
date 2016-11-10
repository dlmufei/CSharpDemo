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

        private Thread threadRevData = null; 

        public DataProvider() 
        {
            
        }

        public DataProvider(int code)
        {
            threadRevData = new Thread(getData);
            threadRevData.Start();
        } 

        public void getData()
        {
            int index = 0;

            while (index < 100000 )
            {
                if (index % 100 == 0)
                {
                    Refresh(index);  
                }
                index++;
                Thread.Sleep(10);
            }
            
        }


    }
}
