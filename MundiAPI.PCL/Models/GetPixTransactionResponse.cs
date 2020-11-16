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
    public class GetPixTransactionResponse : GetTransactionResponse 
    {
        // These fields hold the values for the public properties.
        private string qrCode;
        private string qrCodeUrl;
        private DateTime expiresAt;
        private List<Models.PixAdditionalInformation> additionalInformation;

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("qr_code")]
        public string QrCode 
        { 
            get 
            {
                return this.qrCode; 
            } 
            set 
            {
                this.qrCode = value;
                onPropertyChanged("QrCode");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("qr_code_url")]
        public string QrCodeUrl 
        { 
            get 
            {
                return this.qrCodeUrl; 
            } 
            set 
            {
                this.qrCodeUrl = value;
                onPropertyChanged("QrCodeUrl");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonConverter(typeof(IsoDateTimeConverter))]
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt 
        { 
            get 
            {
                return this.expiresAt; 
            } 
            set 
            {
                this.expiresAt = value;
                onPropertyChanged("ExpiresAt");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("additional_information")]
        public List<Models.PixAdditionalInformation> AdditionalInformation 
        { 
            get 
            {
                return this.additionalInformation; 
            } 
            set 
            {
                this.additionalInformation = value;
                onPropertyChanged("AdditionalInformation");
            }
        }
    }
} 