using System.Threading.Tasks;

namespace MilitariaWPFGus.Data
{
    public class GusApi : BaseApi
    {
        public async Task<string> GetGus(string url)
        {
            var client = GetHttpClient();

            var result = await client.GetAsync(url);

            if (result.IsSuccessStatusCode)
            {
                return await result.Content.ReadAsStringAsync();
            }
            else
            {
                throw new System.Exception(await result.Content.ReadAsStringAsync());
            }
        }

    }
}
