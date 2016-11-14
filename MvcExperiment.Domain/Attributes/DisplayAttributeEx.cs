namespace MvcExperiment.Domain.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    /// <summary>
    /// ディスプレイ属性のユーティリティクラス
    /// </summary>
    public static class DisplayAttributeEx
    {
        /// <summary>
        /// Display 属性で指定した名称を取得
        /// </summary>
        /// <typeparam name="T">型</typeparam>
        /// <param name="expression">ラムダ式</param>
        /// <returns>取得したDisplayAttribute</returns>
        public static string GetName<T>(Expression<Func<T>> expression)
        {
            MemberInfo info = null;

            var body = expression.Body;

            if (body.NodeType == ExpressionType.MemberAccess)
            {
                var member = body as MemberExpression;

                info = member.Member;
            }
            else if (body.NodeType == ExpressionType.Call)
            {
                var method = body as MethodCallExpression;

                info = method.Method;
            }
 
            // クラスのメンバ情報からディスプレイ属性を取得
            var attrs = (DisplayAttribute[])info.GetCustomAttributes(typeof(DisplayAttribute), false);

            // 最初のディスプレイ属性の名称を取得
            return attrs.Count() != 0 ? attrs[0].Name : string.Empty;
        }
    }
}
