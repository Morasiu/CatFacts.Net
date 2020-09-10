using System.Threading.Tasks;
using NUnit.Framework;

namespace CatFacts.Net.Tests {
	public class CatFactsClientTests {
		[Test]
		public async Task GetRandomFactsAsync_WithoutQueryParameters_ShouldReturnFactsList() {
			// Arrange
			var client = new CatFactsClient();
			// Act
			var facts = await client.GetRandomFactsAsync();
			// Assert
			Assert.NotNull(facts);
		}
	}
}