using System.Net;

namespace StudentManager
{
    internal class Helper
    {
        public static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(url);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    Image img = Image.FromStream(stream);
                    return img;
                }
            }
        }

    }
}
