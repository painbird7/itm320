namespace hw6_2
{
    public class Plate
    {
        public Plate(string sku, string color)
        {
            SKU = sku;
            Color = color;
        }
        public string SKU { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"This DinnerWare Set Contains Plate SKU: {SKU} in {Color} Color";
        }
    }
}