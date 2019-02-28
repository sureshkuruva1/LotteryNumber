using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLogger
{
    /// <summary>
    /// This is Custom Exception Class
    /// </summary>
    public class BusinessException : Exception
    {
        /// <summary>
        /// initialization of private variable Code
        /// </summary>
        private readonly string code;

        /// <summary>
        /// initialization of private variable MessageDetail
        /// </summary>
        private readonly string messageDetail;

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException"/> class
        /// </summary>
        /// <param name="code">Error code</param>
        /// <param name="message">Error Message</param>
        /// <param name="exception">exception Message</param>
        public BusinessException(string code, string message, Exception exception)
            : base(message, exception)
        {
            this.code = code;
            this.messageDetail = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BusinessException"/> class
        /// </summary>
        /// <param name="code">Error code</param>
        /// <param name="message">exception Message</param>
        public BusinessException(string code, string message)
            : base(message)
        {
            this.code = code;
            this.messageDetail = message;
        }

        /// <summary>
        /// Gets the ECode
        /// </summary>
        public string ECode
        {
            get
            {
                return this.code;
            }
        }

        /// <summary>
        /// Gets the EMessage
        /// </summary>
        public string EMessage
        {
            get
            {
                return this.messageDetail;
            }
        }
    }
}
