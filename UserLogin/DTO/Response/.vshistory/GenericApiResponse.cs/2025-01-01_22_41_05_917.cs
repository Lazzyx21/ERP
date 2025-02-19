namespace Manufacturing_API.DTO.Response
{
    public class GenericApiResponse<T>
    {
        /// <summary>
        /// Processing Status from API
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Processing Result Message from the API
        /// </summary>
        public string ErrorDesc { get; set; }

        /// <summary>
        /// Processing Result Message from the API
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Data Payload if any as a result of processing
        /// </summary>
        public T Data { get; set; }
    }
}