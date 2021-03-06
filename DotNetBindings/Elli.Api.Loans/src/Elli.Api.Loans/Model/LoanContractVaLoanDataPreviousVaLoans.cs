/*
* Copyright 2017 Ellie Mae, Inc.
*
* Redistribution and use in source and binary forms, with or without
* modification, are permitted provided that the following conditions are met:
*
*  1. Redistributions of source code must retain the above copyright notice,
*     this list of conditions and the following disclaimer.
*
*  2. Redistributions in binary form must reproduce the above copyright notice,
*     this list of conditions and the following disclaimer in the documentation
*     and/or other materials provided with the distribution.
*
*  3. Neither the name of the copyright holder nor the names of its
*     contributors may be used to endorse or promote products derived from this
*     software without specific prior written permission.
*
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
* AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
* IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
* ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
* LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
* CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
* SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
* INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
* CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
* ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
* POSSIBILITY OF SUCH DAMAGE.
*/


/* 
 * Loan
 *
 * Returns the entire loan or specific entities of a loan.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Elli.Api.Loans.Client.SwaggerDateConverter;

namespace Elli.Api.Loans.Model
{
    /// <summary>
    /// LoanContractVaLoanDataPreviousVaLoans
    /// </summary>
    [DataContract]
    public partial class LoanContractVaLoanDataPreviousVaLoans :  IEquatable<LoanContractVaLoanDataPreviousVaLoans>, IValidatableObject
    {
    
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets DateOfLoan
        /// </summary>
        [DataMember(Name="dateOfLoan", EmitDefaultValue=false)]
        public DateTime? DateOfLoan { get; set; }

        /// <summary>
        /// Gets or Sets DateSold
        /// </summary>
        [DataMember(Name="dateSold", EmitDefaultValue=false)]
        public DateTime? DateSold { get; set; }

        /// <summary>
        /// Gets or Sets LoanType
        /// </summary>
        [DataMember(Name="loanType", EmitDefaultValue=false)]
        public string LoanType { get; set; }

        /// <summary>
        /// Gets or Sets PreviousVaLoanIndex
        /// </summary>
        [DataMember(Name="previousVaLoanIndex", EmitDefaultValue=false)]
        public int? PreviousVaLoanIndex { get; set; }

        /// <summary>
        /// Gets or Sets PropertyAddress
        /// </summary>
        [DataMember(Name="propertyAddress", EmitDefaultValue=false)]
        public string PropertyAddress { get; set; }

        /// <summary>
        /// Gets or Sets PropertyCity
        /// </summary>
        [DataMember(Name="propertyCity", EmitDefaultValue=false)]
        public string PropertyCity { get; set; }

        /// <summary>
        /// Gets or Sets PropertyOwned
        /// </summary>
        [DataMember(Name="propertyOwned", EmitDefaultValue=false)]
        public bool? PropertyOwned { get; set; }

        /// <summary>
        /// Gets or Sets PropertyPostalCode
        /// </summary>
        [DataMember(Name="propertyPostalCode", EmitDefaultValue=false)]
        public string PropertyPostalCode { get; set; }

        /// <summary>
        /// Gets or Sets PropertyState
        /// </summary>
        [DataMember(Name="propertyState", EmitDefaultValue=false)]
        public string PropertyState { get; set; }

        /// <summary>
        /// Gets or Sets VALoanNumber
        /// </summary>
        [DataMember(Name="vALoanNumber", EmitDefaultValue=false)]
        public string VALoanNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LoanContractVaLoanDataPreviousVaLoans {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DateOfLoan: ").Append(DateOfLoan).Append("\n");
            sb.Append("  DateSold: ").Append(DateSold).Append("\n");
            sb.Append("  LoanType: ").Append(LoanType).Append("\n");
            sb.Append("  PreviousVaLoanIndex: ").Append(PreviousVaLoanIndex).Append("\n");
            sb.Append("  PropertyAddress: ").Append(PropertyAddress).Append("\n");
            sb.Append("  PropertyCity: ").Append(PropertyCity).Append("\n");
            sb.Append("  PropertyOwned: ").Append(PropertyOwned).Append("\n");
            sb.Append("  PropertyPostalCode: ").Append(PropertyPostalCode).Append("\n");
            sb.Append("  PropertyState: ").Append(PropertyState).Append("\n");
            sb.Append("  VALoanNumber: ").Append(VALoanNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LoanContractVaLoanDataPreviousVaLoans);
        }

        /// <summary>
        /// Returns true if LoanContractVaLoanDataPreviousVaLoans instances are equal
        /// </summary>
        /// <param name="input">Instance of LoanContractVaLoanDataPreviousVaLoans to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LoanContractVaLoanDataPreviousVaLoans input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DateOfLoan == input.DateOfLoan ||
                    (this.DateOfLoan != null &&
                    this.DateOfLoan.Equals(input.DateOfLoan))
                ) && 
                (
                    this.DateSold == input.DateSold ||
                    (this.DateSold != null &&
                    this.DateSold.Equals(input.DateSold))
                ) && 
                (
                    this.LoanType == input.LoanType ||
                    (this.LoanType != null &&
                    this.LoanType.Equals(input.LoanType))
                ) && 
                (
                    this.PreviousVaLoanIndex == input.PreviousVaLoanIndex ||
                    (this.PreviousVaLoanIndex != null &&
                    this.PreviousVaLoanIndex.Equals(input.PreviousVaLoanIndex))
                ) && 
                (
                    this.PropertyAddress == input.PropertyAddress ||
                    (this.PropertyAddress != null &&
                    this.PropertyAddress.Equals(input.PropertyAddress))
                ) && 
                (
                    this.PropertyCity == input.PropertyCity ||
                    (this.PropertyCity != null &&
                    this.PropertyCity.Equals(input.PropertyCity))
                ) && 
                (
                    this.PropertyOwned == input.PropertyOwned ||
                    (this.PropertyOwned != null &&
                    this.PropertyOwned.Equals(input.PropertyOwned))
                ) && 
                (
                    this.PropertyPostalCode == input.PropertyPostalCode ||
                    (this.PropertyPostalCode != null &&
                    this.PropertyPostalCode.Equals(input.PropertyPostalCode))
                ) && 
                (
                    this.PropertyState == input.PropertyState ||
                    (this.PropertyState != null &&
                    this.PropertyState.Equals(input.PropertyState))
                ) && 
                (
                    this.VALoanNumber == input.VALoanNumber ||
                    (this.VALoanNumber != null &&
                    this.VALoanNumber.Equals(input.VALoanNumber))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DateOfLoan != null)
                    hashCode = hashCode * 59 + this.DateOfLoan.GetHashCode();
                if (this.DateSold != null)
                    hashCode = hashCode * 59 + this.DateSold.GetHashCode();
                if (this.LoanType != null)
                    hashCode = hashCode * 59 + this.LoanType.GetHashCode();
                if (this.PreviousVaLoanIndex != null)
                    hashCode = hashCode * 59 + this.PreviousVaLoanIndex.GetHashCode();
                if (this.PropertyAddress != null)
                    hashCode = hashCode * 59 + this.PropertyAddress.GetHashCode();
                if (this.PropertyCity != null)
                    hashCode = hashCode * 59 + this.PropertyCity.GetHashCode();
                if (this.PropertyOwned != null)
                    hashCode = hashCode * 59 + this.PropertyOwned.GetHashCode();
                if (this.PropertyPostalCode != null)
                    hashCode = hashCode * 59 + this.PropertyPostalCode.GetHashCode();
                if (this.PropertyState != null)
                    hashCode = hashCode * 59 + this.PropertyState.GetHashCode();
                if (this.VALoanNumber != null)
                    hashCode = hashCode * 59 + this.VALoanNumber.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
