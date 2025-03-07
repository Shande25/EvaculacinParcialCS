namespace EjemploMVC_MAT.Models
{
    public class Card_Image
    {
        public string Image_Url { get; set; }
        public string Image_Url_Small { get; set; }
        public string Image_Url_Cropped { get; set; }
    }

    public class Card_Price
    {
        public string Cardmarket_Price { get; set; }
        public string Tcgplayer_Price { get; set; }
        public string Ebay_Price { get; set; }
        public string Amazon_Price { get; set; }
        public string Coolstuffinc_Price { get; set; }
    }

    public class Card_Set
    {
        public string Set_Name { get; set; }
        public string Set_Code { get; set; }
        public string Set_Rarity { get; set; }
        public string Set_Price { get; set; }
    }

    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Archetype { get; set; }
        public string Ygoprodeck_Url { get; set; }
        public List<Card_Set> Card_Sets { get; set; }
        public List<Card_Image> Card_Images { get; set; }
        public List<Card_Price> Card_Prices { get; set; }
        public string Image_Url { get; set; }
    }
}
