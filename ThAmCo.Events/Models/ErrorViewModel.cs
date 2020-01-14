using System;

namespace ThAmCo.Events.Models
{   
    /// <summary>
    /// View model for error
    /// </summary>
    public class ErrorViewModel
    {
        /// <summary>
        /// request id
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// show request id
        /// </summary>
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}