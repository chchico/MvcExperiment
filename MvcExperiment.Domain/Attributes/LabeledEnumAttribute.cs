namespace MvcExperiment.Domain.Attributes
{
    using System;

    /// <summary>
    /// 列挙型のフィールドにラベル文字列を付加するカスタム属性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class LabeledEnumAttribute
        : Attribute
    {
        /// <summary>
        /// LabeledEnumAttribute クラスの新しいインスタンスを初期化
        /// </summary>
        /// <param name="label">ラベル文字列</param>
        /// <param name="optionLabel">オプションラベル文字列</param>
        /// <param name="enable">ラベル有効フラグ</param>
        public LabeledEnumAttribute(string label, string optionLabel = "", bool enable = true)
        {
            this.Label = label;
            this.Enable = enable;
            this.OptionLabel = optionLabel;
        }

        /// <summary>
        /// ラベル文字列
        /// </summary>
        public string Label { get; private set; }

        /// <summary>
        /// 追加用文字列
        /// </summary>
        public string OptionLabel { get; private set; }

        /// <summary>
        /// ラベル有効フラグ
        /// </summary>
        public bool Enable { get; private set; }

        /// <summary>
        /// 属性で指定されたラベル文字列を取得
        /// </summary>
        /// <param name="value">ラベル付きフィールド</param>
        /// <returns>ラベル文字列</returns>
        public static string GetLabel(Enum value)
        {
            // EnumもClass なので
            if (value == null)
            {
                return string.Empty;
            }

            // 型情報を取得
            Type enumType = value.GetType();

            // 引数から列挙型のメンバー名を取得
            string name = Enum.GetName(enumType, value);

            // メンバー名が取得できない場合は空文字を返す
            if (name == null)
            {
                return string.Empty;
            }

            // メンバーに割り当てられたLabeledEnum 属性を取得
            LabeledEnumAttribute[] attrs =
                (LabeledEnumAttribute[])enumType.GetField(name)
                .GetCustomAttributes(typeof(LabeledEnumAttribute), false);

            // 最初の属性のラベル文字列を返す
            return attrs[0].Enable ? attrs[0].Label : "";
        }

        /// <summary>
        /// 属性で指定された追加ラベル文字列を取得
        /// </summary>
        /// <param name="value">ラベル付きフィールド</param>
        /// <returns>追加ラベル文字列</returns>
        public static string GetOptionLabel(Enum value)
        {
            // EnumもClass なので
            if (value == null)
            {
                return string.Empty;
            }

            // 型情報を取得
            Type enumType = value.GetType();

            // 引数から列挙型のメンバー名を取得
            string name = Enum.GetName(enumType, value);

            // メンバー名が取得できない場合は空文字を返す
            if (name == null)
            {
                return string.Empty;
            }

            // メンバーに割り当てられたLabeledEnum 属性を取得
            LabeledEnumAttribute[] attrs =
                (LabeledEnumAttribute[])enumType.GetField(name)
                .GetCustomAttributes(typeof(LabeledEnumAttribute), false);

            // 最初の属性のラベル文字列を返す
            return attrs[0].Enable ? attrs[0].OptionLabel : "";
        }
    }
}