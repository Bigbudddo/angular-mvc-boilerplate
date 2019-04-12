using AngularMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularMVC.Repositories {

    public sealed class NakamaRepository {

        private readonly List<Nakama> _nakamas = new List<Nakama>() {
            new Nakama(1, "Monkey D. Luffy", "https://vignette.wikia.nocookie.net/onepiece/images/6/6d/Monkey_D._Luffy_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20190124235416", "Captain"),
            new Nakama(2, "Nami", "https://vignette.wikia.nocookie.net/onepiece/images/6/68/Nami_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20160917032958", "Navigator"),
            new Nakama(3, "Zoro", "https://vignette.wikia.nocookie.net/onepiece/images/5/52/Roronoa_Zoro_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20141008195159", "Swordsman"),
            new Nakama(4, "Usopp", "https://vignette.wikia.nocookie.net/onepiece/images/3/35/Usopp_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20130708033601", "Sniper"),
            new Nakama(5, "Sanji", "https://vignette.wikia.nocookie.net/onepiece/images/b/b6/Sanji_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20170625125657", "Cook"),
            new Nakama(6, "Chopper", "https://vignette.wikia.nocookie.net/onepiece/images/a/af/Tony_Tony_Chopper_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20130428202154", "Doctor"),
            new Nakama(7, "Robin", "https://vignette.wikia.nocookie.net/onepiece/images/b/bc/Nico_Robin_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20190202051257", "Archaeologist"),
            new Nakama(8, "Franky", "https://vignette.wikia.nocookie.net/onepiece/images/8/8c/Franky_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20130225034035", "Shipwright"),
            new Nakama(9, "Brook", "https://vignette.wikia.nocookie.net/onepiece/images/4/41/Brook_Anime_Post_Timeskip_Infobox.png/revision/latest/scale-to-width-down/270?cb=20161016160925", "Musician"),
            new Nakama(10, "Jinbe", "https://vignette.wikia.nocookie.net/onepiece/images/8/81/Jinbe_Anime_Infobox.png/revision/latest/scale-to-width-down/270?cb=20170521201349", "Helmsman")
        };

        public Nakama GetNakama(int nakamaId) {
            return _nakamas.FirstOrDefault<Nakama>(x => x.Id == nakamaId);
        }

        public IEnumerable<Nakama> GetNakamas() {
            return _nakamas;
        }
    }
}