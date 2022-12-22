using System;
using System.Windows.Forms;
namespace MySimpleRestouraunt.controllers
{
    public class EggOrder
    {
        private int quantity;
        private int zabivchivpst;
        public EggOrder(int size)
        {
            quantity = size;
            zabivchivpst++;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public int? GetQuality()
        {
            Random rnd = new Random();
            int quality = rnd.Next(1, 100);
            if (zabivchivpst%2==0)
            {
                return null;
            }
            return quality;
            
        }

        public void Crack()
        {
            int? quality = GetQuality();
            if (quality<=25)
            {
                MessageBox.Show("Качество яйца плохое");
            }
        }
        public void DiscardShell(){}
        public void Cook(){}
    }
}