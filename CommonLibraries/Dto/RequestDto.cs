using CommonLibraries.Enum;

namespace CommonLibraries.Dto
{
    /// <summary>
    /// A model for requests
    /// </summary>
    public class RequestDto
    {
        /// <summary>
        /// The endpoint type
        /// </summary>
        public ApiType ApiType { get; set; } = ApiType.Get;
        /// <summary>
        /// The requested url
        /// </summary>
        public string Url { get; set; }
        /// <summary>
        /// Data to be sent.
        /// </summary>
        public object Data { get; set; }
        /// <summary>
        /// Access token for identity verification.
        /// </summary>
        public string AccessToken { get; set; }
    }
}
