namespace MvcExperiment.GridMvc.Enums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using MvcExperiment.Domain.Attributes;

    /// <summary>
    /// カテゴリ
    /// </summary>
    public enum CaractorCategoryCd
    {
        /// <summary>
        /// 無所属
        /// </summary>
        [LabeledEnum("無所属")]
        Cd0 = 0,

        /// <summary>
        /// ロミオの青い空
        /// </summary>
        [LabeledEnum("ロミオの青い空")]
        Cd1 = 1,

        /// <summary>
        /// ムーミン
        /// </summary>
        [LabeledEnum("ムーミン")]
        Cd2 = 2,
    }

    /// <summary>
    /// 性別
    /// </summary>
    public enum CaractorSexCd
    {
        /// <summary>
        /// 無所属
        /// </summary>
        [LabeledEnum("無")]
        None = 0,

        /// <summary>
        /// 男
        /// </summary>
        [LabeledEnum("男")]
        Male = 1,

        /// <summary>
        /// 女
        /// </summary>
        [LabeledEnum("女")]
        Female = 2,
    }
}