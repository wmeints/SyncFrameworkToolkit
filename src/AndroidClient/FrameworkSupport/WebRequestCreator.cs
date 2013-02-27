namespace System.Net.Browser
{
    /// <summary>
    /// Provides objects for specifying whether the browser or the client handles HTTP requests and responses.
    /// </summary>
    public static class WebRequestCreator
    {
        private static IWebRequestCreate s_clientHttp;

        /// <summary>
        /// Gets an object that specifies client HTTP handling for Web requests and responses.
        /// </summary>
        /// 
        /// <returns>
        /// An <see cref="T:System.Net.IWebRequestCreate"/> object for use with Silverlight-based application that runs outside of a Web browser.
        /// </returns>
        public static IWebRequestCreate ClientHttp
        {
            get
            {
                if (WebRequestCreator.s_clientHttp == null)
                    WebRequestCreator.s_clientHttp = (IWebRequestCreate)new ClientHttpWebRequestCreator();
                return WebRequestCreator.s_clientHttp;
            }
        }

        static WebRequestCreator()
        {
        }
    }
}