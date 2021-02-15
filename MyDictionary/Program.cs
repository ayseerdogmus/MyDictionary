using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> phoneList = new MyDictionary<string, int>();

            phoneList.Add("IPhone", 1);
            phoneList.Add("Samsung", 2);
            phoneList.Add("Xiaomi", 3);
            phoneList.Add("LG", 4);
            phoneList.Add("Huawei", 5);
            phoneList.List();
        }
    }
}
