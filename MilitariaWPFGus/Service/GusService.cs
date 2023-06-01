using MilitariaWPFGus.Data;
using MilitariaWPFGus.Gus;

using System;
using System.Text;
using System.Threading.Tasks;

namespace MilitariaWPFGus.Service
{
    public class GusService
    {
        public async Task<GusM[]> GetGus(string language = "")
        {
            try
            {
                GusApi api = new GusApi();
                StringBuilder url = new StringBuilder();

                url.Append("?lang=");
                if (string.IsNullOrWhiteSpace(language))
                    url.Append("pl");
                else
                    url.Append(language);


                var json = await api.GetGus(url.ToString());
                var resutl = Newtonsoft.Json.JsonConvert.DeserializeObject<GusM[]>(json);

                return resutl;
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
