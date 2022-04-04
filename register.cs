using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class register
    {
        public static Dictionary<int, List<string>> loginList = new Dictionary<int, List<string>>();

        public static int curSess;

        //memAdd memAdd = new memAdd();

        static public void addMember()
        {
            loginList.Add(loginList.Count + 1, new List<string> { memAdd.login, memAdd.password, memAdd.name, memAdd.lastname, memAdd.age, memAdd.admin });
        }
    }
}
