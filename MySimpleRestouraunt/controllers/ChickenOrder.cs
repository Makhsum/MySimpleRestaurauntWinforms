namespace MySimpleRestouraunt.controllers
{
    public class ChickenOrder
    {
        private int quantity;
        
        public ChickenOrder(int size)
        {
            quantity = size;
        }

        public int GetQuantity()
        {
            return quantity;
        }

        public void CutUp()
        {
            
        }
        public void Cook(){}
    }
}