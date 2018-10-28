using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace task_patterns.Singleton
{
    class SingleObject
    {
        public static SingleObject instanse;

        public SingleObject()
        {
            MessageBox.Show("Create new object");
        }

       public static SingleObject GetInstance()
        {
            if (instanse == null)
              instanse = new SingleObject();
                       
            
                return instanse;
            
              
            
        }
    }
}
