using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace twozerofoureight
{
    public class Model
    {
        protected double Score;
        protected ArrayList oList;

        public string Show_Score_onBoard(string Sum)
        {
            Sum = Score.ToString();
            return Sum;
        }

        public Model()
        {
            oList = new ArrayList();
        }
        public void NotifyAll()
        {
            foreach (View m in oList)
            {
                m.Notify(this);
            }
        }

        public void AttachObserver(View m)
        {
            oList.Add(m);
        }

    }
}
