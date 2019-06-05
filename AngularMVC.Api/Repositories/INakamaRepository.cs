using AngularMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularMVC.Repositories {

	public interface INakamaRepository {

		Nakama GetNakama(int nakamaId);

		IEnumerable<Nakama> GetNakamas();
	}
}
