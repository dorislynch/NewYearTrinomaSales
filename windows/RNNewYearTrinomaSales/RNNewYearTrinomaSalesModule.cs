using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace New.Year.Trinoma.Sales.RNNewYearTrinomaSales
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNNewYearTrinomaSalesModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNNewYearTrinomaSalesModule"/>.
        /// </summary>
        internal RNNewYearTrinomaSalesModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNNewYearTrinomaSales";
            }
        }
    }
}
