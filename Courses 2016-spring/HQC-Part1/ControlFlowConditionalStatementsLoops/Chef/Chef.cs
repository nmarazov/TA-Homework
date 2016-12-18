namespace Chef
{
    public class Chef
    {
        private Bowl GetBowl()
        {
            //... 
            return new Bowl();
        }

        private Carrot GetCarrot()
        {
            //...
            return new Carrot();
        }

        private Potato GetPotato()
        {
            //...
            return new Potato();
        }

        private void Cut(IVegetable vegetable)
        {
            //...
        }

        public void Cook()
        {
            Potato potato = GetPotato();
            Carrot carrot = GetCarrot();
            Bowl bowl = GetBowl();

            potato.Peel();
            carrot.Peel();

            Cut(potato);
            Cut(carrot);

            bowl.Add(carrot);
            bowl.Add(potato);
        }
    }
}
