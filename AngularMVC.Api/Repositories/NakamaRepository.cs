using AngularMVC.Models;
using SqlKata;
using SqlKata.Compilers;
using SqlKata.Execution;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AngularMVC.Repositories {

    public sealed class NakamaRepository : INakamaRepository {

        private readonly List<Nakama> _nakamas = new List<Nakama>() {
            new Nakama(1, "Monkey D. Luffy", "https://vignette.wikia.nocookie.net/onepiece/images/f/f9/Monkey_D._Luffy%27s_Current_Wanted_Poster.png/revision/latest?cb=20190409101044", "Captain", 1500000000),
            new Nakama(2, "Zoro", "https://vignette.wikia.nocookie.net/onepiece/images/5/5d/Roronoa_Zoro%27s_Current_Wanted_Poster.png/revision/latest?cb=20161222000618", "Swordsman", 320000000),
            new Nakama(3, "Nami", "https://vignette.wikia.nocookie.net/onepiece/images/3/3b/Nami%27s_Current_Wanted_Poster.png/revision/latest?cb=20160619204508", "Navigator", 66000000),
            new Nakama(4, "Usopp", "https://vignette.wikia.nocookie.net/onepiece/images/5/5e/God_Usopp%27s_Wanted_Poster.png/revision/latest?cb=20160619204644", "Sniper", 200000000),
            new Nakama(5, "Sanji", "https://vignette.wikia.nocookie.net/onepiece/images/c/ca/Sanji%27s_Current_Wanted_Poster.png/revision/latest?cb=20190331050119", "Cook", 330000000),
            new Nakama(6, "Chopper", "https://vignette.wikia.nocookie.net/onepiece/images/7/75/Tony_Tony_Chopper%27s_Current_Wanted_Poster.png/revision/latest?cb=20160619204650", "Doctor", 100),
            new Nakama(7, "Robin", "https://vignette.wikia.nocookie.net/onepiece/images/b/b8/Nico_Robin%27s_Current_Wanted_Poster.png/revision/latest?cb=20161222000656", "Archaeologist", 130000000),
            new Nakama(8, "Franky", "https://vignette.wikia.nocookie.net/onepiece/images/e/e0/Cyborg_Franky%27s_Wanted_Poster.png/revision/latest?cb=20160619204639", "Shipwright", 94000000),
            new Nakama(9, "Brook", "https://vignette.wikia.nocookie.net/onepiece/images/0/09/Brook%27s_Concert_Wanted_Poster.png/revision/latest?cb=20160619204634", "Musician", 83000000),
            new Nakama(10, "Jinbe", "https://vignette.wikia.nocookie.net/onepiece/images/3/34/Jinbe%27s_Wanted_Poster.png/revision/latest?cb=20180731164329", "Helmsman", 438000000)
        };

        public Nakama GetNakama(int nakamaId) {
            return _nakamas.FirstOrDefault<Nakama>(x => x.ObjectID == nakamaId);
        }

        public IEnumerable<Nakama> GetNakamas() {
            //return _nakamas;
			try {
				var connection = new SqlConnection("Data Source=c:\\angularMVC.sqlite;");
				var compiler = new SqliteCompiler();

				var db = new QueryFactory(connection, compiler);
				return db.Query("Nakama").Get<Nakama>();
			} catch (Exception ex) {
				return new List<Nakama>();
			}
        }
    }
}