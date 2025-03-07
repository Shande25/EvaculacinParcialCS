namespace EjemploMVC_MAT.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Archetype { get; set; }
        public List<CardImage> CardImages { get; set; }
        public List<CardPrice> CardPrices { get; set; }
    }

    public class CardImage
    {
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
        public string ImageUrlCropped { get; set; }
    }

    public class CardPrice
    {
        public string EbayPrice { get; set; }
        public string AmazonPrice { get; set; }
        public string TcgPlayerPrice { get; set; }
        public string CoolStuffIncPrice { get; set; }
    }
}
