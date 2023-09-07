namespace CommonLibraries.Dto
{
    /// <summary>
    /// A model for API responses
    /// </summary>
    public class ResponseDto
    {
        /// <summary>
        /// The object returned
        /// </summary>
        public object Result { get; set; }
        /// <summary>
        /// Whether was successful or not.
        /// </summary>
        public bool IsSucces { get; set; } = true;
        /// <summary>
        /// The error message.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
