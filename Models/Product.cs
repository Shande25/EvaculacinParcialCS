namespace EjemploMVC_MAT.Models
{
    public class CardImage
    {
        public string ImageUrl { get; set; }
        public string ImageUrlSmall { get; set; }
        public string ImageUrlCropped { get; set; }
    }

    public class CardPrice
    {
        public string CardmarketPrice { get; set; }
        public string TcgplayerPrice { get; set; }
        public string EbayPrice { get; set; }
        public string AmazonPrice { get; set; }
        public string CoolstuffincPrice { get; set; }
    }

    public class CardSet
    {
        public string SetName { get; set; }
        public string SetCode { get; set; }
        public string SetRarity { get; set; }
        public string SetPrice { get; set; }
    }

    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Desc { get; set; }
        public string Archetype { get; set; }
        public string YgoprodeckUrl { get; set; }
        public List<CardSet> CardSets { get; set; }
        public List<CardImage> CardImages { get; set; }
        public List<CardPrice> CardPrices { get; set; }
    }
}
