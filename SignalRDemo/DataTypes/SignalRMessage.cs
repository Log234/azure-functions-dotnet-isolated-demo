﻿using Newtonsoft.Json;

namespace SignalRDemo.DataTypes
{
    /// <summary>
    /// Class that contains parameters needed for sending messages.
    /// There are three kinds of scope to send, and if more than one
    /// scopes are set, it will be resolved by the following order:
    ///     1. ConnectionId
    ///     2. UserId
    ///     3. GroupName
    /// </summary>
    [JsonObject]
    public class SignalRMessage
    {
        [JsonProperty("connectionId")]
        public string ConnectionId { get; set; }

        [JsonProperty("userId")]
        public string UserId { get; set; }

        [JsonProperty("groupName")]
        public string GroupName { get; set; }

        [JsonProperty("target"), JsonRequired]
        public string Target { get; set; }

        [JsonProperty("arguments"), JsonRequired]
        public object[] Arguments { get; set; }

        // [JsonProperty("endpoints")]
        // public ServiceEndpoint[] Endpoints { get; set; }
    }
}