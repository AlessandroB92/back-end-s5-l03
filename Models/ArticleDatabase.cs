namespace back_end_s5_l03.Models
{
    public static class ArticleDatabase
    {
        private static List<Article> _articles = new List<Article>
    {
        new Article
        {
            Id = 1,
            Name = "Scarpe da Tennis Nike Air Zoom Vapor X",
            Price = 129.99m,
            Description = "Le scarpe da tennis Nike Air Zoom Vapor X offrono un'ottima combinazione di ammortizzazione, stabilità e leggerezza. Ideali per giocatori di tutti i livelli.",
            CoverImage = "/images/nike_air_zoom_vapor_x.jpg",
            AdditionalImages = new List<string> { "/images/nike_air_zoom_vapor_x_2.jpg", "/images/nike_air_zoom_vapor_x_3.jpg" },
            IsDisplayedOnHomePage = true
        },
        new Article
        {
            Id = 2,
            Name = "Wilson Pro Staff RF97 Autograph",
            Price = 249.99m,
            Description = "La racchetta da tennis Wilson Pro Staff RF97 Autograph, progettata in collaborazione con Roger Federer, offre un controllo eccezionale e una sensazione classica.",
            CoverImage = "/images/wilson_pro_staff_rf97.jpg",
            AdditionalImages = new List<string> { "/images/wilson_pro_staff_rf97_2.jpg", "/images/wilson_pro_staff_rf97_3.jpg" },
            IsDisplayedOnHomePage = true
        },
        new Article
        {
            Id = 3,
            Name = "Head Graphene 360+ Speed Pro",
            Price = 219.99m,
            Description = "La racchetta da tennis Head Graphene 360+ Speed Pro offre una combinazione di potenza e controllo ideale per i giocatori avanzati.",
            CoverImage = "/images/head_graphene_speed_pro.jpg",
            AdditionalImages = new List<string> { "/images/head_graphene_speed_pro_2.jpg", "/images/head_graphene_speed_pro_3.jpg" },
            IsDisplayedOnHomePage = true
        },
        new Article
        {
            Id = 4,
            Name = "Babolat Pure Aero",
            Price = 199.99m,
            Description = "La Babolat Pure Aero è la scelta perfetta per i giocatori che cercano potenza e rotazione. La sua tecnologia Aero offre prestazioni eccezionali.",
            CoverImage = "/images/babolat_pure_aero.jpg",
            AdditionalImages = new List<string> { "/images/babolat_pure_aero_2.jpg", "/images/babolat_pure_aero_3.jpg" },
            IsDisplayedOnHomePage = true
        },
        new Article
        {
            Id = 5,
            Name = "Adidas Barricade 2018 Boost",
            Price = 159.99m,
            Description = "Le scarpe da tennis Adidas Barricade 2018 Boost offrono un'ottima combinazione di ammortizzazione e stabilità, ideali per il gioco aggressivo.",
            CoverImage = "/images/adidas_barricade_boost.jpg",
            AdditionalImages = new List<string> { "/images/adidas_barricade_boost_2.jpg", "/images/adidas_barricade_boost_3.jpg" },
            IsDisplayedOnHomePage = true
        },
        new Article
        {
            Id = 6,
            Name = "Yonex EZONE 98",
            Price = 209.99m,
            Description = "La racchetta da tennis Yonex EZONE 98 offre un mix di potenza e maneggevolezza, ideale per i giocatori che cercano precisione e controllo.",
            CoverImage = "/images/yonex_ezone_98.jpg",
            AdditionalImages = new List<string> { "/images/yonex_ezone_98_2.jpg", "/images/yonex_ezone_98_3.jpg" },
            IsDisplayedOnHomePage = true
        },
        new Article
        {
            Id = 7,
            Name = "Asics Gel Resolution 8",
            Price = 149.99m,
            Description = "Le scarpe da tennis Asics Gel Resolution 8 offrono un'ottima combinazione di stabilità, ammortizzazione e resistenza. Ideali per i giocatori che cercano prestazioni elevate.",
            CoverImage = "/images/asics_gel_resolution_8.jpg",
            AdditionalImages = new List<string> { "/images/asics_gel_resolution_8_2.jpg", "/images/asics_gel_resolution_8_3.jpg" },
            IsDisplayedOnHomePage = true 
        },
        new Article
        {
            Id = 8,
            Name = "Prince Textreme Tour 100P",
            Price = 209.99m,
            Description = "La racchetta da tennis Prince Textreme Tour 100P offre una combinazione di potenza e controllo ideale per i giocatori di livello avanzato. La tecnologia Textreme assicura una sensazione solida e confortevole.",
            CoverImage = "/images/prince_textreme_tour_100p.jpg",
            AdditionalImages = new List<string> { "/images/prince_textreme_tour_100p_2.jpg", "/images/prince_textreme_tour_100p_3.jpg" },
            IsDisplayedOnHomePage = true
        },
    };
        public static List<Article> GetAllArticles()
        {
            return _articles;
        }

        public static Article GetArticleById(int id)
        {
            return _articles.FirstOrDefault(a => a.Id == id);
        }

        public static void AddArticle(Article article)
        {
            _articles.Add(article);
        }

        public static void UpdateArticle(Article updatedArticle)
        {
            var index = _articles.FindIndex(a => a.Id == updatedArticle.Id);
            if (index != -1)
            {
                _articles[index] = updatedArticle;
            }
        }

        public static void DeleteArticle(int id)
        {
            _articles.RemoveAll(a => a.Id == id);
        }
    }

}
