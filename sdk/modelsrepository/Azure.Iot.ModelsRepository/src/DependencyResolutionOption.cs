// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Iot.ModelsRepository
{
    /// <summary>
    /// The model dependency resolution options.
    /// </summary>
    public enum DependencyResolutionOption
    {
        /// <summary>
        /// Try to get pre-computed model dependencies using .expanded.json.
        /// If the model expanded form does not exist fall back to normal dependency processing.
        /// </summary>
        TryFromExpanded = 2,

        /// <summary>
        /// Disable model dependency resolution.
        /// </summary>
        Disabled = 0,

        /// <summary>
        /// Enable model dependency resolution.
        /// </summary>
        Enabled = 1,
    }
}
