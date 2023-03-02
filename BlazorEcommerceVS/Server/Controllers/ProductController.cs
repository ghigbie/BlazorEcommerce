using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerceVS.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : Controller
{
    private static List<Product> Products = new List<Product>
        {

            new Product
            {
                Id = 1,
                Title = "The Hitchhiker's Guide to the Galaxy",
                Description = "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "Ready Player One",
                Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                Price = 7.99m
            },
            new Product
            {
                Id = 3,
                Title = "The Book of Five Rings",
                Description = "The Book of Five Rings (五輪書, Go Rin no Sho) is a text on kenjutsu and the martial arts in general, written by the Japanese swordsman Miyamoto Musashi around 1645. Many translations have been made, and it enjoys an audience considerably broader than other martial artists and people across East Asia. For instance, some foreign business leaders find its discussion of conflict and taking the advantage to be relevant to their work in a business context. The modern-day Hyōhō Niten Ichi-ryū employs it as a manual of technique and philosophy.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Musashi_ts_pic.jpg/440px-Musashi_ts_pic.jpg",
                Price = 6.99m

            }
        };
            
    [HttpGet]
    public async Task<IActionResult> GetProduct()
    {
        return Ok(Products);
    }
}