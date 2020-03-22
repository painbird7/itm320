
/*
    2) Create a DLL that contain 3x classes (DinnerWareSet class, Plate class and Bowl class). A DinnerWareSet class must contain one Plate class and one Bowl class 
    (You must use C# Composition methodology to execute this requirement). The following are additional attributes for each class that must be set by using C# Properties methodology.
    DinnerWareSet Class = SKU ( set to "2019DWSet"), Price (set to $79.99) and PromoNote (set to "Limited Edition Holiday 2019 Promo")
    Plate Class = SKU ( set to "ABC123") and Color (set to "2019HolidayRed")
    Bowl Class = SKU ( set to "DEF456") and Color (set to "2019HolidayRed") 
    Import the DLL, instantiate an object out of all the classes and use it on Main() to display all of the object's properties. See attached jpeg       < 5 pts >
*/


namespace hw6_2
{
    public class DinnerWareSet
    {
        public DinnerWareSet(string sku, decimal price, string promoNote, Bowl bowl1, Plate plate1)
        {
            Sku = sku;
            Price = price;
            PromoNote = promoNote;
            Bowl1 = bowl1;
            Plate1 = plate1;
        }
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public string PromoNote { get; set; }


        public Plate Plate1 { get; set; }
        public Bowl Bowl1 { get; set; }

        public override string ToString()
        {
            return $"{PromoNote} SKU: {Sku} Price: ${Price} \n{Bowl1} \n{Plate1}";
        }
    }
}