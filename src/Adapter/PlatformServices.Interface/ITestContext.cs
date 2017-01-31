// Copyright (c) Microsoft. All rights reserved.

namespace Microsoft.VisualStudio.TestPlatform.MSTestAdapter.PlatformServices.Interface
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;

    /// <summary>
    /// Operations on the TestContext object that is implemented differently for each platform.
    /// </summary>
    public interface ITestContext 
    {
        /// <summary>
        /// Gets the inner test context object.
        /// </summary>
        TestContext Context { get; }

        /// <summary>
        /// Returns whether property with parameter name is present.
        /// </summary>
        /// <param name="propertyName"> The property Name. </param>
        /// <param name="propertyValue"> The property Value. </param>
        /// <returns> True if the property is present. </returns>
        bool TryGetPropertyValue(string propertyName, out object propertyValue);
        
        /// <summary>
        /// Adds the parameter name/value pair to property bag.
        /// </summary>
        /// <param name="propertyName"> The property Name. </param>
        /// <param name="propertyValue"> The property Value. </param>
        void AddProperty(string propertyName, string propertyValue);

        /// <summary>
        /// Sets the outcome of a Test Method in the TestContext.
        /// </summary>
        /// <param name="outcome"> The outcome. </param>
        void SetOutcome(UnitTestOutcome outcome);

        /// <summary>
        /// Gets the attached Result files 
        /// </summary>
        /// <returns>
        /// The list of result files.
        /// </returns>
        IList<string> GetResultFiles();
    }
}