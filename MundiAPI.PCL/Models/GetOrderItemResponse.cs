/*
 * MundiAPI.PCL
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io )
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
    public class GetOrderItemResponse : BaseModel 
    {
        // These fields hold the values for the public properties.
        private int amount;
        private string description;
        private int quantity;
        private Models.GetSellerResponse getSellerResponse;

        /// <summary>
        /// TODO: Write general description for this method
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
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("description")]
        public string Description 
        { 
            get 
            {
                return this.description; 
            } 
            set 
            {
                this.description = value;
                onPropertyChanged("Description");
            }
        }

        /// <summary>
        /// TODO: Write general description for this method
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity 
        { 
            get 
            {
                return this.quantity; 
            } 
            set 
            {
                this.quantity = value;
                onPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Seller data
        /// </summary>
        [JsonProperty("GetSellerResponse")]
        public Models.GetSellerResponse GetSellerResponse 
        { 
            get 
            {
                return this.getSellerResponse; 
            } 
            set 
            {
                this.getSellerResponse = value;
                onPropertyChanged("GetSellerResponse");
            }
        }
    }
} 