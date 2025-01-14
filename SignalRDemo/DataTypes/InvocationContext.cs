﻿using System.Collections.Generic;
using System.Text.Json;

namespace SignalRDemo.DataTypes
{
    public class InvocationContext
    {
        /// <summary>
        /// The arguments of invocation message.
        /// </summary>
        public JsonElement[] Arguments { get; set; }

        /// <summary>
        /// The error message of close connection event.
        /// Only close connection message can have this property, and it can be empty if connections close with no error.
        /// </summary>
        public string Error { get; set; }

        /// <summary>
        /// The category of the message.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The event of the message.
        /// </summary>
        public string Event { get; set; }

        /// <summary>
        /// The hub which message belongs to.
        /// </summary>
        public string Hub { get; set; }

        /// <summary>
        /// The connection-id of the client which send the message.
        /// </summary>
        public string ConnectionId { get; set; }

        /// <summary>
        /// The user identity of the client which send the message.
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// The headers of request.
        /// Headers with duplicated key will be joined by comma.
        /// </summary>
        public IDictionary<string, string> Headers { get; set; }

        /// <summary>
        /// The query of the request when client connect to the service.
        /// Queries with duplicated key will be joined by comma.
        /// </summary>
        public IDictionary<string, string> Query { get; set; }

        /// <summary>
        /// The claims of the client.
        /// If multiple claims have the same key, only the first one will be reserved.
        /// </summary>
        public IDictionary<string, string> Claims { get; set; }
    }
}