using System.ComponentModel;

namespace ApiVersion2
{
    /// <summary>
    /// 框架枚举
    /// </summary>
    public class FrameworkEnum
    {
        /// <summary>
        /// 版本
        /// </summary>
        public enum ApiVersion
        {
            /// <summary>
            /// V1版本
            /// </summary>
            [Description("V1版本")]
            V1 = 1,

            /// <summary>
            /// V2版本
            /// </summary>
            [Description("V2版本")]
            V2 = 2,
        }
    }
}
