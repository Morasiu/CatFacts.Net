using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CatFacts.Net.Models;
using RestSharp;

namespace CatFacts.Net {
	public class CatFactsClient {
		private readonly RestClient _restClient;

		public CatFactsClient() {
			_restClient = new RestClient("https://cat-fact.herokuapp.com");
		}

		public Task<List<Fact>> GetRandomFactsAsync(int amount = 1, params string[] animalTypes) {
			var request = new RestRequest("/facts/random");

			request.AddQueryParameter("amount", amount.ToString());
			request.AddQueryParameter("animal_type", string.Join(",", animalTypes));
			var facts = _restClient.GetAsync<List<Fact>>(request);
			return facts;
		}
	}
}