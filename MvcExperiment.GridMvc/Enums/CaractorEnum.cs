namespace MvcExperiment.GridMvc.Enums
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using MvcExperiment.Domain.Attributes;

    public enum CaractorCategoryCd
    {
        /// <summary>
        /// 無所属
        /// </summary>
        [LabeledEnum("無所属")]
        Cd0 = 0,

        /// <summary>
        /// カテゴリ1
        /// </summary>
        [LabeledEnum("カテゴリ1")]
        Cd1 = 1,

        /// <summary>
        /// カテゴリ2
        /// </summary>
        [LabeledEnum("カテゴリ2")]
        Cd2 = 2,
    }
}