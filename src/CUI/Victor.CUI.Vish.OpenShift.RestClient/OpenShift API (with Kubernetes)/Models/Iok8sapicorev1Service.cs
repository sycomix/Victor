﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Victor.CUI.Vish.OpenShift.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Service is a named abstraction of software service (for example,
    /// mysql) consisting of local port (for example 3306) that the proxy
    /// listens on, and the selector that determines which pods will answer
    /// requests sent through the proxy.
    /// </summary>
    public partial class Iok8sapicorev1Service
    {
        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1Service class.
        /// </summary>
        public Iok8sapicorev1Service() { }

        /// <summary>
        /// Initializes a new instance of the Iok8sapicorev1Service class.
        /// </summary>
        public Iok8sapicorev1Service(string apiVersion = default(string), string kind = default(string), Iok8sapimachinerypkgapismetav1ObjectMeta metadata = default(Iok8sapimachinerypkgapismetav1ObjectMeta), Iok8sapicorev1ServiceSpec spec = default(Iok8sapicorev1ServiceSpec), Iok8sapicorev1ServiceStatus status = default(Iok8sapicorev1ServiceStatus))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Metadata = metadata;
            Spec = spec;
            Status = status;
        }

        /// <summary>
        /// APIVersion defines the versioned schema of this representation of
        /// an object. Servers should convert recognized schemas to the
        /// latest internal value, and may reject unrecognized values. More
        /// info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Kind is a string value representing the REST resource this object
        /// represents. Servers may infer this from the endpoint the client
        /// submits requests to. Cannot be updated. In CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public Iok8sapimachinerypkgapismetav1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Spec defines the behavior of a service.
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "spec")]
        public Iok8sapicorev1ServiceSpec Spec { get; set; }

        /// <summary>
        /// Most recently observed status of the service. Populated by the
        /// system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/api-conventions.md#spec-and-status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public Iok8sapicorev1ServiceStatus Status { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (this.Metadata != null)
            {
                this.Metadata.Validate();
            }
        }
    }
}