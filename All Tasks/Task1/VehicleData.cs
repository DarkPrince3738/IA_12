namespace Task1
{
    public struct VehicleData
    {
        public int weigth;
        public int height;
        public int width;
        public int price;
        public int maxSpeed;
        public override string ToString() =>
                $"{nameof(weigth)}:{weigth} \n" +
                $"{nameof(height)}:{height} \n" +
                $"{nameof(width)}:{width} \n" +
                $"{nameof(price)}:{price} \n" +
                $"{nameof(maxSpeed)}:{maxSpeed} \n";
    }
}
