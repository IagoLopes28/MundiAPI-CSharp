/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using MundiAPI.PCL;
using MundiAPI.PCL.Utilities;


namespace MundiAPI.PCL.Models
{
    [JsonConverter(typeof(GetTransactionResponseCreationConverter))]
    public class GetTransactionResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string gatewayId;
        private int amount;
        private string status;
        private bool success;
        private DateTime createdAt;
        private DateTime updatedAt;
        private int attemptCount;
        private int maxAttempts;
        private List<Models.GetSplitResponse> splits;
        private DateTime? nextAttempt;
        private string transactionType;
        private string id;
        private Models.GetGatewayResponseResponse gatewayResponse;
        private Models.GetAntifraudResponse antifraudResponse;
        private Dictionary<string, string> metadata;
        private List<Models.GetSplitResponse> split;

        /// <summary>
        /// Gateway transaction id
        /// </summary>
        [JsonProperty("gateway_id")]
        public string GatewayId 
        { 
            get 
            {
                return this.gatewayId; 
            } 
            set 
            {
                this.gatewayId = value;
                onPropertyChanged("GatewayId");
            }
        }

        /// <summary>
        /// Amount in cents
        /// </summary>
        [JsonProperty("amount")]
        public int Amount 
        { 
            get 
            {
                return this.amount; 
            } 
            set 
            {
                this.amount = value;
                onPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Transaction status
        /// </summary>
        [JsonProperty("status")]
        public string Status 
        { 
            get 
            {
                return this.status; 
            } 
            set 
            {
                this.status = value;
                onPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Indicates if the transaction ocurred successfuly
        /// </summary>
        [JsonProperty("success")]
        public bool Success 
        { 
            get 
            {
                return this.success; 
            } 
            set 
            {
                this.success = value;
                onPropertyChanged("Success");
            }
        }

        /// <summary>
        /// Creation date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("created_at")]
        public DateTime CreatedAt 
        { 
            get 
            {
                return this.createdAt; 
            } 
            set 
            {
                this.createdAt = value;
                onPropertyChanged("CreatedAt");
            }
        }

        /// <summary>
        /// Last update date
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt 
        { 
            get 
            {
                return this.updatedAt; 
            } 
            set 
            {
                this.updatedAt = value;
                onPropertyChanged("UpdatedAt");
            }
        }

        /// <summary>
        /// Number of attempts tried
        /// </summary>
        [JsonProperty("attempt_count")]
        public int AttemptCount 
        { 
            get 
            {
                return this.attemptCount; 
            } 
            set 
            {
                this.attemptCount = value;
                onPropertyChanged("AttemptCount");
            }
        }

        /// <summary>
        /// Max attempts
        /// </summary>
        [JsonProperty("max_attempts")]
        public int MaxAttempts 
        { 
            get 
            {
                return this.maxAttempts; 
            } 
            set 
            {
                this.maxAttempts = value;
                onPropertyChanged("MaxAttempts");
            }
        }

        /// <summary>
        /// Splits
        /// </summary>
        [JsonProperty("splits")]
        public List<Models.GetSplitResponse> Splits 
        { 
            get 
            {
                return this.splits; 
            } 
            set 
            {
                this.splits = value;
                onPropertyChanged("Splits");
            }
        }

        /// <summary>
        /// Date and time of the next attempt
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("next_attempt")]
        public DateTime? NextAttempt 
        { 
            get 
            {
                return this.nextAttempt; 
            } 
            set 
            {
                this.nextAttempt = value;
                onPropertyChanged("NextAttempt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("transaction_type")]
        public string TransactionType 
        { 
            get 
            {
                return this.transactionType; 
            } 
            set 
            {
                this.transactionType = value;
                onPropertyChanged("TransactionType");
            }
        }

        /// <summary>
        /// Código da transação
        /// </summary>
        [JsonProperty("id")]
        public string Id 
        { 
            get 
            {
                return this.id; 
            } 
            set 
            {
                this.id = value;
                onPropertyChanged("Id");
            }
        }

        /// <summary>
        /// The Gateway Response
        /// </summary>
        [JsonProperty("gateway_response")]
        public Models.GetGatewayResponseResponse GatewayResponse 
        { 
            get 
            {
                return this.gatewayResponse; 
            } 
            set 
            {
                this.gatewayResponse = value;
                onPropertyChanged("GatewayResponse");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("antifraud_response")]
        public Models.GetAntifraudResponse AntifraudResponse 
        { 
            get 
            {
                return this.antifraudResponse; 
            } 
            set 
            {
                this.antifraudResponse = value;
                onPropertyChanged("AntifraudResponse");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata 
        { 
            get 
            {
                return this.metadata; 
            } 
            set 
            {
                this.metadata = value;
                onPropertyChanged("Metadata");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("split")]
        public List<Models.GetSplitResponse> Split 
        { 
            get 
            {
                return this.split; 
            } 
            set 
            {
                this.split = value;
                onPropertyChanged("Split");
            }
        }
    }
} 