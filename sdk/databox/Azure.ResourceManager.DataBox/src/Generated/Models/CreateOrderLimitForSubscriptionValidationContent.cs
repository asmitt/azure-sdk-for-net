// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request to validate create order limit for current subscription. </summary>
    public partial class CreateOrderLimitForSubscriptionValidationContent : DataBoxValidationInputContent
    {
        /// <summary> Initializes a new instance of <see cref="CreateOrderLimitForSubscriptionValidationContent"/>. </summary>
        /// <param name="deviceType"> Device type to be used for the job. </param>
        public CreateOrderLimitForSubscriptionValidationContent(DataBoxSkuName deviceType)
        {
            DeviceType = deviceType;
            ValidationType = DataBoxValidationInputDiscriminator.ValidateCreateOrderLimit;
        }

        /// <summary> Device type to be used for the job. </summary>
        public DataBoxSkuName DeviceType { get; }
    }
}
