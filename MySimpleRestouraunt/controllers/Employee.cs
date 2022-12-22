using System;
using System.Windows.Forms;

namespace MySimpleRestouraunt.controllers
{
    public class Employee
    {
        private object copyrequest;
        public object menuitem;
        private int zabivchivost = 0;
        public object NewRequest (int quantity,object menuitem)
        {
            zabivchivost++;
            if (zabivchivost%3!=0)
            {
                if (menuitem is ChickenOrder)
                {
                    this.menuitem = new ChickenOrder(quantity);
                }
                else if (menuitem is EggOrder)
                {
                    this.menuitem = new EggOrder(quantity);
                }
            }
            else
            {
                if (menuitem is ChickenOrder)
                {
                    this.menuitem = new EggOrder(quantity);
                }
                else if (menuitem is EggOrder)
                {
                    this.menuitem = new ChickenOrder(quantity);
                }
            }
           
            copyrequest = this.menuitem;
            return this.menuitem;
        }

        public object CopyRequest()
        {
            if (copyrequest == null)
            {
                MessageBox.Show("Error");
                return null;
            }
            return copyrequest;
            
        }

        public string Inspect(object request)
        {
            string quality = "";
            if (request is ChickenOrder)
            {
                return "Проверка не требуется";
            }else if (request is EggOrder)
            {
                EggOrder eg =(EggOrder) request;
                quality=eg.GetQuality().ToString();
            }

            return quality;
        }

        public string PrepareFood(object request)
        {
            string msg = "";
            if (request is ChickenOrder)
            {
                ChickenOrder chiken = (ChickenOrder) request;
                for (int i = 0; i < chiken.GetQuantity(); i++)
                {
                    chiken.CutUp();
                }
                chiken.Cook();
                msg = "Курица успешно приготовлена!";
            }

            if (request is EggOrder)
            {
                EggOrder egg = (EggOrder) request;
                for (int i = 0; i < egg.GetQuantity(); i++)
                {
                    egg.DiscardShell();
                    egg.Crack();
                }

                msg = "яйцо успешно приготовлено";
                if (egg.GetQuality()<=25)
                {
                    msg += " качество яйца плохое!";
                }
                else
                {
                    msg += " качество яйца хорошое!";
                }
            }

            return msg;
        }
        
    }
}