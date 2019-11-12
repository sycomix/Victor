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
    /// Represents a host path mapped into a pod. Host path volumes do not
    /// support ownership management or SELinux relabeling.
    /// </summary>
    public partial class Iok8sapicorev1HostPathVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1HostPathVolumeSource class.
        /// </summary>
        public Iok8sapicorev1HostPathVolumeSource() { }

        /// <summary>
        /// Initializes a new instance of the
        /// Iok8sapicorev1HostPathVolumeSource class.
        /// </summary>
        public Iok8sapicorev1HostPathVolumeSource(string path, string type = default(string))
        {
            Path = path;
            Type = type;
        }

        /// <summary>
        /// Path of the directory on the host. If the path is a symlink, it
        /// will follow the link to the real path. More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Type for HostPath Volume Defaults to "" More info:
        /// https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
        }
    }
}